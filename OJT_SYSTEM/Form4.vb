Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class EvaluationForm
    Private ReadOnly connectionString As String =
    "server=localhost;user id=root;password=;database=ojt_management_system;"
    Private currentInternshipId As Integer = 0

    ' 🔹 Cached supervisor grades
    Private supPunc As Integer = -1
    Private supProf As Integer = -1
    Private supSkills As Integer = -1
    Private supSoft As Integer = -1
    Private supTotalPercent As Decimal = 0D

    ' 🔹 Cached professor grades
    Private profPunc As Integer = -1
    Private profProf As Integer = -1
    Private profSkills As Integer = -1
    Private profSoft As Integer = -1
    Private profTotalPercent As Decimal = 0D

    ' 🔹 Do we have any grades loaded for this internship?
    Private gradesLoaded As Boolean = False
    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub
    Private Sub PanelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        ' Added rating options for comboboxes
        Dim ratingOptions As Object() = {"0 - Incomplete", "1 - Poor", "2 - Bad", "3 - Good", "4 - Very Good", "5 - Excellent"}
        cmbPunc.Items.AddRange(ratingOptions)
        cmbProfessionalism.Items.AddRange(ratingOptions)
        cmbSkills.Items.AddRange(ratingOptions)
        cmbSoftSkills.Items.AddRange(ratingOptions)
        cmbReportType.Items.Clear()
        cmbReportType.Items.AddRange(New Object() {
            "Summary Report",
            "Detailed Evaluator Report",
            "Student Performance Report",
            "Internship Completion Report"
        })
        cmbReportType.SelectedIndex = 0   ' default

        cmbInteractionType.Items.Clear()
        cmbInteractionType.Items.AddRange(New Object() {
            "Site Visit",
            "Virtual Meeting",
            "Phone Call",
            "Company Feedback",
            "Follow-Up Evaluation"
        })
        cmbInteractionType.SelectedIndex = 0
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub pnlStudInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlStudInfo.Paint
        pnlStudInfo.BackColor = ColorTranslator.FromHtml("#F7F7f7")
        pnlStudInfo.Region = RoundCorners(pnlStudInfo, 20)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim mainForm As New DashboardForm()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim studentForm As New StudentForm()
        studentForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnInternships_Click(sender As Object, e As EventArgs) Handles btnInternships.Click
        Dim internForm As New InternForm()
        internForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlEval.Paint
        pnlEval.BackColor = ColorTranslator.FromHtml("#F7F7f7")
        pnlStudInfo.Region = RoundCorners(pnlStudInfo, 20)
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlRating.Paint
        pnlRating.BackColor = SetPanelTransparency(pnlRating, 50)
    End Sub

    Private Function SetPanelTransparency(panel As Panel, opacity As Integer) As Color
        Dim alphaValue As Integer = CInt((opacity / 100.0) * 255)
        Return Color.FromArgb(alphaValue, 255, 255, 255)
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        )

        If result = DialogResult.Yes Then
            Me.Hide()
            FrmChooseLogin.Show()
        End If
    End Sub

    Private Sub btnEvaluationLog_Click(sender As Object, e As EventArgs) Handles btnEvaluationLog.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPunc.SelectedIndexChanged

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim studentId As String = MaskedTextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(studentId) Then
            MessageBox.Show("Please enter a Student ID.", "Missing Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Reset ratings when searching a new student
        gradesLoaded = False
        ClearRatingInputs()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' 1) Load student + internship + company + supervisor + professor
                Dim sql As String =
                    "SELECT " &
                    "  i.internship_id, " &
                    "  s.student_id, s.first_name, s.last_name, s.middle_name, " &
                    "  s.program, s.status AS student_status, " &
                    "  i.status AS internship_status, " &
                    "  c.company_name, " &
                    "  cc.first_name AS sup_first_name, cc.last_name AS sup_last_name, " &
                    "  f.first_name AS fac_first_name, f.last_name AS fac_last_name, f.role AS fac_role " &
                    "FROM student s " &
                    "LEFT JOIN internship i ON i.student_id = s.student_id " &
                    "LEFT JOIN company c ON c.company_id = i.company_id " &
                    "LEFT JOIN companycontact cc ON cc.supervisor_id = i.supervisor_id " &
                    "LEFT JOIN faculty f ON f.faculty_id = i.faculty_id " &
                    "WHERE s.student_id = @studentId " &
                    "ORDER BY i.internship_id DESC " &
                    "LIMIT 1;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@studentId", studentId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' --- Internship ID (may be NULL if no internship yet) ---
                            If Not Convert.IsDBNull(reader("internship_id")) Then
                                currentInternshipId = Convert.ToInt32(reader("internship_id"))
                            Else
                                currentInternshipId = 0
                            End If

                            ' ===== Student basic info =====
                            Dim lastName As String = reader("last_name").ToString()
                            Dim firstName As String = reader("first_name").ToString()
                            Dim middleName As String = reader("middle_name").ToString()

                            Dim fullName As String = $"{lastName}, {firstName}".Trim()
                            If Not String.IsNullOrWhiteSpace(middleName) Then
                                fullName &= " " & middleName
                            End If

                            lblStudID.Text = reader("student_id").ToString()
                            lblStudName.Text = fullName
                            lblCourse.Text = reader("program").ToString()

                            ' Company
                            If Not Convert.IsDBNull(reader("company_name")) Then
                                lblComp.Text = reader("company_name").ToString()
                            Else
                                lblComp.Text = "N/A"
                            End If

                            ' Supervisor name
                            Dim supFirst As String = If(Convert.IsDBNull(reader("sup_first_name")), "", reader("sup_first_name").ToString())
                            Dim supLast As String = If(Convert.IsDBNull(reader("sup_last_name")), "", reader("sup_last_name").ToString())

                            If String.IsNullOrWhiteSpace(supFirst) AndAlso String.IsNullOrWhiteSpace(supLast) Then
                                lblSupervisor.Text = "N/A"
                            Else
                                lblSupervisor.Text = (supFirst & " " & supLast).Trim()
                            End If

                            ' Status (prefer internship status if present)
                            Dim internshipStatus As String = If(Convert.IsDBNull(reader("internship_status")), "", reader("internship_status").ToString())
                            Dim studentStatus As String = reader("student_status").ToString()

                            If Not String.IsNullOrWhiteSpace(internshipStatus) Then
                                lblStatus.Text = internshipStatus
                            Else
                                lblStatus.Text = studentStatus
                            End If

                            ' ===== Fill evaluator combobox (Professor + Supervisor) =====
                            cmbEval.Items.Clear()

                            Dim facFirst As String = If(Convert.IsDBNull(reader("fac_first_name")), "", reader("fac_first_name").ToString())
                            Dim facLast As String = If(Convert.IsDBNull(reader("fac_last_name")), "", reader("fac_last_name").ToString())
                            Dim facRole As String = If(Convert.IsDBNull(reader("fac_role")), "", reader("fac_role").ToString())

                            ' Professor item
                            If Not String.IsNullOrWhiteSpace(facFirst) OrElse Not String.IsNullOrWhiteSpace(facLast) Then
                                Dim profName As String = (facLast & ", " & facFirst).Trim().TrimStart(","c).Trim()
                                Dim professorText As String = "Professor: " & profName
                                If Not String.IsNullOrWhiteSpace(facRole) Then
                                    professorText &= " - " & facRole
                                End If
                                cmbEval.Items.Add(professorText)
                            End If

                            ' Supervisor item
                            If Not (String.IsNullOrWhiteSpace(supFirst) AndAlso String.IsNullOrWhiteSpace(supLast)) Then
                                Dim supName As String = (supFirst & " " & supLast).Trim()
                                Dim supervisorText As String = "Supervisor: " & supName
                                cmbEval.Items.Add(supervisorText)
                            End If

                            If cmbEval.Items.Count > 0 Then
                                cmbEval.SelectedIndex = 0
                            End If

                        Else
                            ' No student found
                            MessageBox.Show("Student ID not found.", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearStudentInfoLabels()
                            cmbEval.Items.Clear()
                            currentInternshipId = 0
                            gradesLoaded = False
                            ClearRatingInputs()
                            Exit Sub
                        End If
                    End Using
                End Using

                ' 2) Load existing grades for this internship (if any)
                supPunc = -1 : supProf = -1 : supSkills = -1 : supSoft = -1 : supTotalPercent = 0D
                profPunc = -1 : profProf = -1 : profSkills = -1 : profSoft = -1 : profTotalPercent = 0D
                gradesLoaded = False

                If currentInternshipId <> 0 Then
                    Dim gradeSql As String =
                        "SELECT sup_punctuality, sup_professionalism, sup_skills, sup_softskills, sup_total_percent, " &
                        "       prof_punctuality, prof_professionalism, prof_skills, prof_softskills, prof_total_percent " &
                        "FROM grade WHERE internship_id = @internshipId LIMIT 1;"

                    Using gradeCmd As New MySqlCommand(gradeSql, conn)
                        gradeCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)

                        Using gr As MySqlDataReader = gradeCmd.ExecuteReader()
                            If gr.Read() Then
                                ' Supervisor grades
                                supPunc = Convert.ToInt32(gr("sup_punctuality"))
                                supProf = Convert.ToInt32(gr("sup_professionalism"))
                                supSkills = Convert.ToInt32(gr("sup_skills"))
                                supSoft = Convert.ToInt32(gr("sup_softskills"))
                                supTotalPercent = Convert.ToDecimal(gr("sup_total_percent"))

                                ' Professor grades
                                profPunc = Convert.ToInt32(gr("prof_punctuality"))
                                profProf = Convert.ToInt32(gr("prof_professionalism"))
                                profSkills = Convert.ToInt32(gr("prof_skills"))
                                profSoft = Convert.ToInt32(gr("prof_softskills"))
                                profTotalPercent = Convert.ToDecimal(gr("prof_total_percent"))

                                gradesLoaded = True
                            End If
                        End Using
                    End Using
                End If
            End Using

            ' 3) After loading everything, show grades for the currently selected evaluator
            If cmbEval.Items.Count > 0 Then
                cmbEval_SelectedIndexChanged(cmbEval, EventArgs.Empty)
            Else
                ClearRatingInputs()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching student: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbEval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEval.SelectedIndexChanged
        If cmbEval.SelectedIndex < 0 Then
            ClearRatingInputs()
            Return
        End If

        If Not gradesLoaded Then
            ' No grades yet for this internship
            ClearRatingInputs()
            Return
        End If

        Dim evaluatorText As String = cmbEval.SelectedItem.ToString()
        Dim isProfessor As Boolean = evaluatorText.StartsWith("Professor:", StringComparison.OrdinalIgnoreCase)
        Dim isSupervisor As Boolean = evaluatorText.StartsWith("Supervisor:", StringComparison.OrdinalIgnoreCase)

        If isSupervisor Then
            If supTotalPercent > 0D Then
                ' Show supervisor's grades
                cmbPunc.SelectedIndex = Math.Max(Math.Min(supPunc, 5), 0)
                cmbProfessionalism.SelectedIndex = Math.Max(Math.Min(supProf, 5), 0)
                cmbSkills.SelectedIndex = Math.Max(Math.Min(supSkills, 5), 0)
                cmbSoftSkills.SelectedIndex = Math.Max(Math.Min(supSoft, 5), 0)
                lblRating.Text = supTotalPercent.ToString("0.00") & "%"
            Else
                ' Supervisor has not graded yet
                ClearRatingInputs()
            End If

        ElseIf isProfessor Then
            If profTotalPercent > 0D Then
                ' Show professor's grades
                cmbPunc.SelectedIndex = Math.Max(Math.Min(profPunc, 5), 0)
                cmbProfessionalism.SelectedIndex = Math.Max(Math.Min(profProf, 5), 0)
                cmbSkills.SelectedIndex = Math.Max(Math.Min(profSkills, 5), 0)
                cmbSoftSkills.SelectedIndex = Math.Max(Math.Min(profSoft, 5), 0)
                lblRating.Text = profTotalPercent.ToString("0.00") & "%"
            Else
                ' Professor has not graded yet
                ClearRatingInputs()
            End If
        Else
            ClearRatingInputs()
        End If
    End Sub

    Private Sub ClearStudentInfoLabels()
        lblStudID.Text = ""
        lblStudName.Text = ""
        lblCourse.Text = ""
        lblComp.Text = ""
        lblSupervisor.Text = ""
        lblStatus.Text = ""
    End Sub

    Private Sub ClearRatingInputs()
        cmbPunc.SelectedIndex = -1
        cmbProfessionalism.SelectedIndex = -1
        cmbSkills.SelectedIndex = -1
        cmbSoftSkills.SelectedIndex = -1
        lblRating.Text = ""
    End Sub
    Private Function GetRatingValue(cmb As ComboBox, fieldName As String) As Integer
        If cmb.SelectedIndex < 0 Then
            Throw New ApplicationException("Please select a rating for " & fieldName & ".")
        End If

        ' Items are "0 - Incomplete" ... "5 - Excellent"
        ' so SelectedIndex corresponds to numeric value
        Return cmb.SelectedIndex
    End Function

    Private Sub btnSaveEval_Click(sender As Object, e As EventArgs) Handles btnSaveEval.Click
        Try
            ' 1. Basic validation
            If currentInternshipId = 0 Then
                MessageBox.Show("This student has no internship record to evaluate.", "No Internship",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cmbEval.SelectedIndex < 0 Then
                MessageBox.Show("Please select who is evaluating (Professor or Supervisor) in the Evaluator dropdown.",
                            "Missing Evaluator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cmbReportType.SelectedIndex < 0 Then
                MessageBox.Show("Please select a Report Type.", "Missing Report Type",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cmbInteractionType.SelectedIndex < 0 Then
                MessageBox.Show("Please select an Interaction Type.", "Missing Interaction Type",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' 2. Who is evaluating?
            Dim evaluatorText As String = cmbEval.SelectedItem.ToString()
            Dim isProfessor As Boolean = evaluatorText.StartsWith("Professor:", StringComparison.OrdinalIgnoreCase)
            Dim isSupervisor As Boolean = evaluatorText.StartsWith("Supervisor:", StringComparison.OrdinalIgnoreCase)

            If Not (isProfessor OrElse isSupervisor) Then
                MessageBox.Show("Unknown evaluator type. Please make sure cmbEval items start with 'Professor:' or 'Supervisor:'.",
                            "Evaluator Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 3. Get ratings from comboboxes (0–5 based on SelectedIndex)
            Dim punc As Integer = GetRatingValue(cmbPunc, "Punctuality")
            Dim prof As Integer = GetRatingValue(cmbProfessionalism, "Professionalism")
            Dim skills As Integer = GetRatingValue(cmbSkills, "Skills")
            Dim soft As Integer = GetRatingValue(cmbSoftSkills, "Soft Skills")

            Dim totalScore As Integer = punc + prof + skills + soft           ' 0–20
            Dim totalPercent As Decimal = CDec(totalScore) / 20D * 100D       ' 0–100

            ' 4. Visit/report meta from controls
            Dim reportType As String = cmbReportType.SelectedItem.ToString()
            Dim interactionMode As String = cmbInteractionType.SelectedItem.ToString()
            Dim visitDate As Date = dtpVisit.Value.Date   ' your DateTimePicker

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' -------------------------------
                ' 4a. Check if a grade row exists
                ' -------------------------------
                Dim gradeExists As Boolean = False
                Dim supTotalExisting As Decimal = 0D
                Dim profTotalExisting As Decimal = 0D

                Dim checkSql As String =
                "SELECT sup_total_percent, prof_total_percent " &
                "FROM grade WHERE internship_id = @internshipId LIMIT 1;"

                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)

                    Using r As MySqlDataReader = checkCmd.ExecuteReader()
                        If r.Read() Then
                            gradeExists = True
                            supTotalExisting = Convert.ToDecimal(r("sup_total_percent"))
                            profTotalExisting = Convert.ToDecimal(r("prof_total_percent"))
                        End If
                    End Using
                End Using

                ' 5. Validation: prevent double grading per evaluator
                If gradeExists Then
                    If isSupervisor AndAlso supTotalExisting > 0D Then
                        MessageBox.Show("The supervisor has already submitted a grade for this student.",
                                    "Already Graded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If isProfessor AndAlso profTotalExisting > 0D Then
                        MessageBox.Show("The professor has already submitted a grade for this student.",
                                    "Already Graded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                ' -------------------------------
                ' 6. Insert or update grade row
                ' -------------------------------
                If Not gradeExists Then
                    ' First evaluator creating the grade record
                    Dim insertSql As String =
                    "INSERT INTO grade (" &
                    "  internship_id, " &
                    "  sup_punctuality, sup_professionalism, sup_skills, sup_softskills, sup_total_percent, " &
                    "  prof_punctuality, prof_professionalism, prof_skills, prof_softskills, prof_total_percent" &
                    ") VALUES (" &
                    "  @internshipId, " &
                    "  @sup_punc, @sup_prof, @sup_skills, @sup_soft, @sup_total, " &
                    "  @prof_punc, @prof_prof, @prof_skills, @prof_soft, @prof_total" &
                    ");"

                    Using insertCmd As New MySqlCommand(insertSql, conn)
                        insertCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)

                        If isSupervisor Then
                            insertCmd.Parameters.AddWithValue("@sup_punc", punc)
                            insertCmd.Parameters.AddWithValue("@sup_prof", prof)
                            insertCmd.Parameters.AddWithValue("@sup_skills", skills)
                            insertCmd.Parameters.AddWithValue("@sup_soft", soft)
                            insertCmd.Parameters.AddWithValue("@sup_total", totalPercent)

                            insertCmd.Parameters.AddWithValue("@prof_punc", 0)
                            insertCmd.Parameters.AddWithValue("@prof_prof", 0)
                            insertCmd.Parameters.AddWithValue("@prof_skills", 0)
                            insertCmd.Parameters.AddWithValue("@prof_soft", 0)
                            insertCmd.Parameters.AddWithValue("@prof_total", 0D)

                        ElseIf isProfessor Then
                            insertCmd.Parameters.AddWithValue("@sup_punc", 0)
                            insertCmd.Parameters.AddWithValue("@sup_prof", 0)
                            insertCmd.Parameters.AddWithValue("@sup_skills", 0)
                            insertCmd.Parameters.AddWithValue("@sup_soft", 0)
                            insertCmd.Parameters.AddWithValue("@sup_total", 0D)

                            insertCmd.Parameters.AddWithValue("@prof_punc", punc)
                            insertCmd.Parameters.AddWithValue("@prof_prof", prof)
                            insertCmd.Parameters.AddWithValue("@prof_skills", skills)
                            insertCmd.Parameters.AddWithValue("@prof_soft", soft)
                            insertCmd.Parameters.AddWithValue("@prof_total", totalPercent)
                        End If

                        insertCmd.ExecuteNonQuery()
                    End Using

                Else
                    ' Grade row exists, update only the current evaluator's fields
                    If isSupervisor Then
                        Dim updateSupSql As String =
                        "UPDATE grade SET " &
                        "  sup_punctuality = @sup_punc, " &
                        "  sup_professionalism = @sup_prof, " &
                        "  sup_skills = @sup_skills, " &
                        "  sup_softskills = @sup_soft, " &
                        "  sup_total_percent = @sup_total " &
                        "WHERE internship_id = @internshipId;"

                        Using updateCmd As New MySqlCommand(updateSupSql, conn)
                            updateCmd.Parameters.AddWithValue("@sup_punc", punc)
                            updateCmd.Parameters.AddWithValue("@sup_prof", prof)
                            updateCmd.Parameters.AddWithValue("@sup_skills", skills)
                            updateCmd.Parameters.AddWithValue("@sup_soft", soft)
                            updateCmd.Parameters.AddWithValue("@sup_total", totalPercent)
                            updateCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)
                            updateCmd.ExecuteNonQuery()
                        End Using

                    ElseIf isProfessor Then
                        Dim updateProfSql As String =
                        "UPDATE grade SET " &
                        "  prof_punctuality = @prof_punc, " &
                        "  prof_professionalism = @prof_prof, " &
                        "  prof_skills = @prof_skills, " &
                        "  prof_softskills = @prof_soft, " &
                        "  prof_total_percent = @prof_total " &
                        "WHERE internship_id = @internshipId;"

                        Using updateCmd As New MySqlCommand(updateProfSql, conn)
                            updateCmd.Parameters.AddWithValue("@prof_punc", punc)
                            updateCmd.Parameters.AddWithValue("@prof_prof", prof)
                            updateCmd.Parameters.AddWithValue("@prof_skills", skills)
                            updateCmd.Parameters.AddWithValue("@prof_soft", soft)
                            updateCmd.Parameters.AddWithValue("@prof_total", totalPercent)
                            updateCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If

                ' -------------------------------
                ' 7. Update cached grades + UI
                ' -------------------------------
                If isSupervisor Then
                    supPunc = punc
                    supProf = prof
                    supSkills = skills
                    supSoft = soft
                    supTotalPercent = totalPercent
                ElseIf isProfessor Then
                    profPunc = punc
                    profProf = prof
                    profSkills = skills
                    profSoft = soft
                    profTotalPercent = totalPercent
                End If

                gradesLoaded = True
                lblRating.Text = totalPercent.ToString("0.00") & "%"

                ' -------------------------------
                ' 8. INSERT VISIT LOG ROW
                ' -------------------------------
                ' We need faculty_id / supervisor_id from internship
                Dim facultyIdObj As Object = DBNull.Value
                Dim supervisorIdObj As Object = DBNull.Value
                Dim reportedBy As String

                Dim infoSql As String =
                "SELECT faculty_id, supervisor_id " &
                "FROM internship WHERE internship_id = @internshipId LIMIT 1;"

                Using infoCmd As New MySqlCommand(infoSql, conn)
                    infoCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)
                    Using rInfo = infoCmd.ExecuteReader()
                        If rInfo.Read() Then
                            If isProfessor Then
                                ' Faculty report
                                facultyIdObj = rInfo("faculty_id")
                                reportedBy = "Faculty"
                                supervisorIdObj = DBNull.Value
                            Else
                                ' Company supervisor report
                                supervisorIdObj = rInfo("supervisor_id")
                                reportedBy = "CompanySupervisor"
                                facultyIdObj = DBNull.Value
                            End If
                        Else
                            ' No internship row found (should not happen if currentInternshipId is valid)
                            reportedBy = If(isProfessor, "Faculty", "CompanySupervisor")
                        End If
                    End Using
                End Using

                Dim visitSql As String =
                "INSERT INTO visitlog " &
                " (internship_id, faculty_id, supervisor_id, visit_date, report_type, interaction_mode, reported_by) " &
                "VALUES " &
                " (@internshipId, @facultyId, @supervisorId, @visitDate, @reportType, @interactionMode, @reportedBy);"

                Using visitCmd As New MySqlCommand(visitSql, conn)
                    visitCmd.Parameters.AddWithValue("@internshipId", currentInternshipId)
                    visitCmd.Parameters.AddWithValue("@facultyId", facultyIdObj)
                    visitCmd.Parameters.AddWithValue("@supervisorId", supervisorIdObj)
                    visitCmd.Parameters.AddWithValue("@visitDate", visitDate)
                    visitCmd.Parameters.AddWithValue("@reportType", reportType)
                    visitCmd.Parameters.AddWithValue("@interactionMode", interactionMode)
                    visitCmd.Parameters.AddWithValue("@reportedBy", If(isProfessor, "Faculty", "CompanySupervisor"))
                    visitCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Grade and visit log saved successfully.", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ApplicationException
            ' From GetRatingValue validation
            MessageBox.Show(ex.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("Error while saving grade/visit: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGenReport_Click(sender As Object, e As EventArgs) Handles btnGenReport.Click
        Try
            ' --- Basic validation ---
            If String.IsNullOrWhiteSpace(lblStudID.Text) OrElse lblStudID.Text.Contains("_") Then
                MessageBox.Show("Please search and load a student before generating a report.",
                            "No Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If currentInternshipId = 0 Then
                MessageBox.Show("This student has no internship record. Cannot generate report.",
                            "No Internship", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' We need grades already loaded from the DB (via Search or Save)
            If Not gradesLoaded Then
                MessageBox.Show("No saved grades found for this internship. " &
                            "Please save at least one evaluation first.",
                            "No Grades", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim hasSupervisor As Boolean = (supTotalPercent > 0D)
            Dim hasProfessor As Boolean = (profTotalPercent > 0D)

            If Not hasSupervisor AndAlso Not hasProfessor Then
                MessageBox.Show("Neither the supervisor nor the professor has submitted grades yet.",
                            "No Evaluations", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' --- Ask where to save the PDF ---
            Dim sfd As New SaveFileDialog() With {
            .Filter = "PDF files (*.pdf)|*.pdf",
            .FileName = $"{lblStudID.Text}_CombinedEvaluationReport.pdf"
        }

            If sfd.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            ' --- Gather data from the form (student + generic report info) ---
            Dim studentId As String = lblStudID.Text
            Dim studentName As String = lblStudName.Text
            Dim course As String = lblCourse.Text
            Dim company As String = lblComp.Text
            Dim supervisorName As String = lblSupervisor.Text
            Dim status As String = lblStatus.Text

            ' Try to get professor name from cmbEval items (optional but nice)
            Dim professorName As String = "N/A"
            For Each item As Object In cmbEval.Items
                Dim txt As String = item.ToString()
                If txt.StartsWith("Professor:", StringComparison.OrdinalIgnoreCase) Then
                    professorName = txt.Substring("Professor:".Length).Trim()
                    Exit For
                End If
            Next

            Dim visitDate As String = dtpVisit.Value.ToString("MMMM dd, yyyy")
            Dim reportType As String = If(cmbReportType.SelectedIndex >= 0,
                                      cmbReportType.SelectedItem.ToString(),
                                      "N/A")
            Dim interactionType As String = If(cmbInteractionType.SelectedIndex >= 0,
                                           cmbInteractionType.SelectedItem.ToString(),
                                           "N/A")

            ' We only have a single comments box; treat it as a general comment
            Dim comments As String = txtComm.Text.Trim()

            ' --- PDF creation ---
            Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 50)

            Using fs As New FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim writer As iTextSharp.text.pdf.PdfWriter =
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs)
                doc.Open()

                ' =======================
                ' Fonts
                ' =======================
                Dim titleFont As New iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.HELVETICA,
                16,
                iTextSharp.text.Font.BOLD
            )

                Dim normalFont As New iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.HELVETICA,
                11,
                iTextSharp.text.Font.NORMAL
            )

                Dim boldFont As New iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.HELVETICA,
                11,
                iTextSharp.text.Font.BOLD
            )

                Dim sectionHeaderFont As New iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.HELVETICA,
                13,
                iTextSharp.text.Font.BOLD
            )

                Dim headerCellFont As New iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.HELVETICA,
                11,
                iTextSharp.text.Font.BOLD
            )

                ' =======================
                ' Title
                ' =======================
                Dim header As New iTextSharp.text.Paragraph("Internship Evaluation Report", titleFont)
                header.Alignment = iTextSharp.text.Element.ALIGN_CENTER
                header.SpacingAfter = 20.0F
                doc.Add(header)

                ' =======================
                ' Student info
                ' =======================
                Dim studInfo As New iTextSharp.text.Paragraph()
                studInfo.Add(New iTextSharp.text.Chunk("Student ID: ", boldFont))
                studInfo.Add(New iTextSharp.text.Chunk(studentId & Environment.NewLine, normalFont))

                studInfo.Add(New iTextSharp.text.Chunk("Student Name: ", boldFont))
                studInfo.Add(New iTextSharp.text.Chunk(studentName & Environment.NewLine, normalFont))

                studInfo.Add(New iTextSharp.text.Chunk("Course/Program: ", boldFont))
                studInfo.Add(New iTextSharp.text.Chunk(course & Environment.NewLine, normalFont))

                studInfo.Add(New iTextSharp.text.Chunk("Company: ", boldFont))
                studInfo.Add(New iTextSharp.text.Chunk(company & Environment.NewLine, normalFont))

                studInfo.Add(New iTextSharp.text.Chunk("Supervisor: ", boldFont))
                studInfo.Add(New iTextSharp.text.Chunk(supervisorName & Environment.NewLine, normalFont))

                studInfo.Add(New iTextSharp.text.Chunk("Status: ", boldFont))
                studInfo.Add(New iTextSharp.text.Chunk(status & Environment.NewLine, normalFont))

                studInfo.SpacingAfter = 10.0F
                doc.Add(studInfo)

                ' =======================
                ' General report info
                ' =======================
                Dim evalInfo As New iTextSharp.text.Paragraph()
                evalInfo.Add(New iTextSharp.text.Chunk("Visit Date: ", boldFont))
                evalInfo.Add(New iTextSharp.text.Chunk(visitDate & Environment.NewLine, normalFont))

                evalInfo.Add(New iTextSharp.text.Chunk("Report Type: ", boldFont))
                evalInfo.Add(New iTextSharp.text.Chunk(reportType & Environment.NewLine, normalFont))

                evalInfo.Add(New iTextSharp.text.Chunk("Interaction Type: ", boldFont))
                evalInfo.Add(New iTextSharp.text.Chunk(interactionType & Environment.NewLine, normalFont))

                evalInfo.SpacingAfter = 15.0F
                doc.Add(evalInfo)

                ' =======================
                ' Helper: rating text
                ' =======================
                Dim ratingText = Function(idx As Integer) As String
                                     Select Case idx
                                         Case 0 : Return "0 - Incomplete"
                                         Case 1 : Return "1 - Poor"
                                         Case 2 : Return "2 - Bad"
                                         Case 3 : Return "3 - Good"
                                         Case 4 : Return "4 - Very Good"
                                         Case 5 : Return "5 - Excellent"
                                         Case Else : Return idx.ToString()
                                     End Select
                                 End Function

                ' Helper: build rating table for an evaluator
                Dim buildTable = Sub(punc As Integer, prof As Integer, skills As Integer, soft As Integer)
                                     Dim table As New iTextSharp.text.pdf.PdfPTable(3)
                                     table.WidthPercentage = 100
                                     table.SetWidths(New Single() {50.0F, 25.0F, 25.0F})

                                     Dim c1 As New iTextSharp.text.pdf.PdfPCell(
                                     New iTextSharp.text.Phrase("Criteria", headerCellFont))
                                     c1.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                     table.AddCell(c1)

                                     Dim c2 As New iTextSharp.text.pdf.PdfPCell(
                                     New iTextSharp.text.Phrase("Rating (0–5)", headerCellFont))
                                     c2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                     table.AddCell(c2)

                                     Dim c3 As New iTextSharp.text.pdf.PdfPCell(
                                     New iTextSharp.text.Phrase("Description", headerCellFont))
                                     c3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                     table.AddCell(c3)

                                     table.AddCell("Punctuality")
                                     table.AddCell(punc.ToString())
                                     table.AddCell(ratingText(punc))

                                     table.AddCell("Professionalism")
                                     table.AddCell(prof.ToString())
                                     table.AddCell(ratingText(prof))

                                     table.AddCell("Skills")
                                     table.AddCell(skills.ToString())
                                     table.AddCell(ratingText(skills))

                                     table.AddCell("Soft Skills")
                                     table.AddCell(soft.ToString())
                                     table.AddCell(ratingText(soft))

                                     doc.Add(table)
                                 End Sub

                ' =======================
                ' SUPERVISOR SECTION
                ' =======================
                If hasSupervisor Then
                    Dim supHeader As New iTextSharp.text.Paragraph("SUPERVISOR EVALUATION", sectionHeaderFont)
                    supHeader.SpacingBefore = 10.0F
                    supHeader.SpacingAfter = 8.0F
                    doc.Add(supHeader)

                    buildTable(supPunc, supProf, supSkills, supSoft)

                    Dim supOverallPara As New iTextSharp.text.Paragraph()
                    supOverallPara.SpacingBefore = 8.0F
                    supOverallPara.Add(New iTextSharp.text.Chunk("Supervisor Name: ", boldFont))
                    supOverallPara.Add(New iTextSharp.text.Chunk(supervisorName & Environment.NewLine, normalFont))

                    supOverallPara.Add(New iTextSharp.text.Chunk("Overall Rating: ", boldFont))
                    supOverallPara.Add(New iTextSharp.text.Chunk(supTotalPercent.ToString("0.00") & "%" &
                                                             Environment.NewLine, normalFont))
                    doc.Add(supOverallPara)
                End If

                ' =======================
                ' PROFESSOR SECTION
                ' =======================
                If hasProfessor Then
                    Dim profHeader As New iTextSharp.text.Paragraph("FACULTY / PROFESSOR EVALUATION", sectionHeaderFont)
                    profHeader.SpacingBefore = 15.0F
                    profHeader.SpacingAfter = 8.0F
                    doc.Add(profHeader)

                    buildTable(profPunc, profProf, profSkills, profSoft)

                    Dim profOverallPara As New iTextSharp.text.Paragraph()
                    profOverallPara.SpacingBefore = 8.0F
                    profOverallPara.Add(New iTextSharp.text.Chunk("Professor: ", boldFont))
                    profOverallPara.Add(New iTextSharp.text.Chunk(professorName & Environment.NewLine, normalFont))

                    profOverallPara.Add(New iTextSharp.text.Chunk("Overall Rating: ", boldFont))
                    profOverallPara.Add(New iTextSharp.text.Chunk(profTotalPercent.ToString("0.00") & "%" &
                                                              Environment.NewLine, normalFont))
                    doc.Add(profOverallPara)
                End If

                ' =======================
                ' General comments (single box)
                ' =======================
                If comments <> "" Then
                    Dim commPara As New iTextSharp.text.Paragraph()
                    commPara.SpacingBefore = 15.0F
                    commPara.Add(New iTextSharp.text.Chunk("General Comments: ", boldFont))
                    commPara.Add(New iTextSharp.text.Chunk(comments, normalFont))
                    doc.Add(commPara)
                End If

                doc.Close()
            End Using

            MessageBox.Show("Combined PDF report (faculty and supervisor) generated successfully.",
                        "Report Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating combined report: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

