Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class StudInternForm

    Private ReadOnly connString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    ' Keys we need to keep while the form is open
    Private CurrentStudentId As String
    Private CurrentInternshipId As Integer = 0
    Private CurrentCompanyId As Integer = 0
    Private CurrentSupervisorId As Integer = 0
    Private CurrentFacultyId As Integer = 0

    ' OPTIONAL: constructor that receives the logged-in student id
    Public Sub New(studentId As String)
        InitializeComponent()
        CurrentStudentId = studentId
    End Sub

    Private Sub btnInternship_Click(sender As Object, e As EventArgs) Handles btnInternship.Click
        ' you can navigate to this form from other forms if needed
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")

        btnProfile.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternship.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        pnlIntern.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlSummary.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlEvalHistory.BackColor = ColorTranslator.FromHtml("#F7F7F7")

        SetInternFieldsEnabled(False)
        SetSupervisorFieldsEnabled(False)
        btnSave.Enabled = False
        btnSsave.Enabled = False

        ' style the evaluation history grid
        StyleDataGridView(dtgEvalHistory)

        ' initialise summary labels
        lblProfRating.Text = "0"
        lblSupervisorRating.Text = "0"
        lblEvalComp.Text = "Evaluations Completed: 0"

        LoadInternshipForStudent()
    End Sub

    Private Sub StyleDataGridView(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersHeight = 35

        dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 9.0F)
        dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.DefaultCellStyle.Padding = New Padding(5)

        dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.GridColor = ColorTranslator.FromHtml("#E0E0E0")
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#B7C0D9")
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black

        dgv.RowTemplate.Height = 30
        dgv.AutoResizeColumns()
    End Sub

    Private Function RoundCorners(panel As Panel, radius As Integer) As Region
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()

        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(panel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, panel.Height - radius, radius, radius), 90, 90)

        path.CloseFigure()
        Return New Region(path)
    End Function

    Private Sub dtgEvalHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEvalHistory.CellContentClick
        ' you could show more details on click here if you want
    End Sub

    Private Sub pnlIntern_Paint(sender As Object, e As PaintEventArgs) Handles pnlIntern.Paint
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSummary.Paint
        pnlSummary.BackColor = ColorTranslator.FromHtml("#F7F7F7")
    End Sub

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

    Private Sub btnSsave_Click(sender As Object, e As EventArgs) Handles btnSsave.Click
        ' 1) Basic validation
        If String.IsNullOrWhiteSpace(txtSFName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLName.Text) Then
            MessageBox.Show("Please enter the supervisor's first and last name.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtInternCompany.Text) Then
            MessageBox.Show("Please enter company details before saving the supervisor.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim tran = conn.BeginTransaction()

                Try
                    ' ------------------------------------------------
                    ' 2) ENSURE A VALID COMPANY ROW (UPSERT + VERIFY)
                    ' ------------------------------------------------
                    ' If we think we already have a company id, check it really exists.
                    Dim mustInsertCompany As Boolean = (CurrentCompanyId = 0)

                    If Not mustInsertCompany Then
                        Dim checkCompanySql As String =
                        "SELECT COUNT(*) FROM company WHERE company_id = @id;"

                        Using checkCmd As New MySqlCommand(checkCompanySql, conn, tran)
                            checkCmd.Parameters.AddWithValue("@id", CurrentCompanyId)
                            Dim cnt As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                            If cnt = 0 Then
                                ' Our stored id is stale / invalid → treat as new company.
                                mustInsertCompany = True
                            End If
                        End Using
                    End If

                    If mustInsertCompany Then
                        ' INSERT new company
                        Dim insertCompanySql As String =
                        "INSERT INTO company (company_name, email, address, company_contact) " &
                        "VALUES (@name, @email, @address, @contact);"

                        Using cmdCompany As New MySqlCommand(insertCompanySql, conn, tran)
                            cmdCompany.Parameters.AddWithValue("@name", txtInternCompany.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@email", txtCompEmail.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@address", txtCompAddr.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@contact", "") ' no field on form

                            cmdCompany.ExecuteNonQuery()
                            CurrentCompanyId = CInt(cmdCompany.LastInsertedId)
                        End Using
                    Else
                        ' UPDATE existing company
                        Dim updateCompanySql As String =
                        "UPDATE company SET " &
                        " company_name = @name, " &
                        " email = @email, " &
                        " address = @address " &
                        "WHERE company_id = @companyId;"

                        Using cmdCompany As New MySqlCommand(updateCompanySql, conn, tran)
                            cmdCompany.Parameters.AddWithValue("@name", txtInternCompany.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@email", txtCompEmail.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@address", txtCompAddr.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@companyId", CurrentCompanyId)
                            cmdCompany.ExecuteNonQuery()
                        End Using
                    End If

                    ' SAFETY: if we *still* don't have a valid id, stop.
                    If CurrentCompanyId <= 0 Then
                        Throw New ApplicationException("Failed to determine a valid company ID before saving supervisor.")
                    End If

                    ' ------------------------------------------------
                    ' 3) INSERT OR UPDATE SUPERVISOR FOR THIS COMPANY
                    ' ------------------------------------------------
                    If CurrentSupervisorId > 0 Then
                        ' UPDATE existing supervisor
                        Dim updateSql As String =
                        "UPDATE companycontact SET " &
                        " first_name = @firstName, " &
                        " last_name = @lastName, " &
                        " position = @position, " &
                        " supervisor_email = @email, " &
                        " supervisor_contact = @contact, " &
                        " company_id = @companyId " &       ' keep fk in sync
                        "WHERE supervisor_id = @supervisorId;"

                        Using cmd As New MySqlCommand(updateSql, conn, tran)
                            cmd.Parameters.AddWithValue("@firstName", txtSFName.Text.Trim())
                            cmd.Parameters.AddWithValue("@lastName", txtLName.Text.Trim())
                            cmd.Parameters.AddWithValue("@position", txtPos.Text.Trim())
                            cmd.Parameters.AddWithValue("@email", txtSEmail.Text.Trim())
                            cmd.Parameters.AddWithValue("@contact", txtSContact.Text.Trim())
                            cmd.Parameters.AddWithValue("@companyId", CurrentCompanyId)
                            cmd.Parameters.AddWithValue("@supervisorId", CurrentSupervisorId)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' INSERT new supervisor attached to this company
                        Dim insertSql As String =
                        "INSERT INTO companycontact " &
                        " (first_name, last_name, position, supervisor_email, supervisor_contact, company_id) " &
                        "VALUES (@firstName, @lastName, @position, @email, @contact, @companyId);"

                        Using cmd As New MySqlCommand(insertSql, conn, tran)
                            cmd.Parameters.AddWithValue("@firstName", txtSFName.Text.Trim())
                            cmd.Parameters.AddWithValue("@lastName", txtLName.Text.Trim())
                            cmd.Parameters.AddWithValue("@position", txtPos.Text.Trim())
                            cmd.Parameters.AddWithValue("@email", txtSEmail.Text.Trim())
                            cmd.Parameters.AddWithValue("@contact", txtSContact.Text.Trim())
                            cmd.Parameters.AddWithValue("@companyId", CurrentCompanyId)

                            cmd.ExecuteNonQuery()
                            CurrentSupervisorId = CInt(cmd.LastInsertedId)
                        End Using
                    End If

                    tran.Commit()
                Catch
                    tran.Rollback()
                    Throw
                End Try
            End Using

            MessageBox.Show("Supervisor information saved successfully.", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            SetSupervisorFieldsEnabled(False)
            btnSsave.Enabled = False
            btnSedit.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error saving supervisor information: " & ex.Message)
        End Try
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SetInternFieldsEnabled(True)
        btnSave.Enabled = True
        btnEdit.Enabled = False
    End Sub

    Private Sub btnSedit_Click(sender As Object, e As EventArgs) Handles btnSedit.Click
        SetSupervisorFieldsEnabled(True)
        btnSsave.Enabled = True
        btnSedit.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtInternCompany.Text) Then
            MessageBox.Show("Please enter a company name.")
            Return
        End If

        Dim hoursRequired As Integer
        Dim hoursCompleted As Integer

        If Not Integer.TryParse(TextBox1.Text, hoursRequired) Then
            MessageBox.Show("Total Required Hours must be a number.")
            Return
        End If

        If Not Integer.TryParse(TextBox2.Text, hoursCompleted) Then
            MessageBox.Show("Hours Rendered must be a number.")
            Return
        End If

        ' which student this internship belongs to
        If String.IsNullOrWhiteSpace(CurrentStudentId) Then
            MessageBox.Show("Student ID is not set. Cannot save internship.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim tran = conn.BeginTransaction()

                Try
                    ' 2. Ensure student's facultyid 
                    If CurrentFacultyId = 0 Then
                        Dim facultySql As String =
                            "SELECT faculty_id FROM student WHERE student_id = @studentId LIMIT 1;"

                        Using cmdFaculty As New MySqlCommand(facultySql, conn, tran)
                            cmdFaculty.Parameters.AddWithValue("@studentId", CurrentStudentId)
                            Dim facObj = cmdFaculty.ExecuteScalar()
                            If facObj Is DBNull.Value OrElse facObj Is Nothing Then
                                MessageBox.Show("This student has no assigned faculty. Cannot save internship.")
                                tran.Rollback()
                                Return
                            End If
                            CurrentFacultyId = Convert.ToInt32(facObj)
                        End Using
                    End If

                    ' Upsert company
                    If CurrentCompanyId = 0 Then
                        Dim insertCompanySql As String =
                            "INSERT INTO company (company_name, email, address, company_contact) " &
                            "VALUES (@name, @email, @address, @contact); " &
                            "SELECT LAST_INSERT_ID();"

                        Using cmdCompany As New MySqlCommand(insertCompanySql, conn, tran)
                            cmdCompany.Parameters.AddWithValue("@name", txtInternCompany.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@email", txtCompEmail.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@address", txtCompAddr.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@contact", "") ' no field in form
                            CurrentCompanyId = Convert.ToInt32(cmdCompany.ExecuteScalar())
                        End Using
                    Else
                        Dim updateCompanySql As String =
                            "UPDATE company SET " &
                            " company_name = @name, " &
                            " email = @email, " &
                            " address = @address " &
                            "WHERE company_id = @companyId;"

                        Using cmdCompany As New MySqlCommand(updateCompanySql, conn, tran)
                            cmdCompany.Parameters.AddWithValue("@name", txtInternCompany.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@email", txtCompEmail.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@address", txtCompAddr.Text.Trim())
                            cmdCompany.Parameters.AddWithValue("@companyId", CurrentCompanyId)
                            cmdCompany.ExecuteNonQuery()
                        End Using
                    End If

                    '  Ensure we have a supervisor
                    If CurrentSupervisorId = 0 Then
                        MessageBox.Show("Please save supervisor information first before saving internship.")
                        tran.Rollback()
                        Return
                    End If

                    '  Upsert internship
                    Dim startDate As Date = DateTimePicker1.Value.Date
                    Dim endDate As Date = DateTimePicker2.Value.Date
                    Dim status As String = "Ongoing"

                    ' Try UPDATE first: internship for this student + company
                    Dim updateInternSql As String =
                        "UPDATE internship SET " &
                        " supervisor_id = @supervisorId, " &
                        " faculty_id = @facultyId, " &
                        " starting_date = @startDate, " &
                        " end_date = @endDate, " &
                        " hours_required = @hoursReq, " &
                        " hours_completed = @hoursComp, " &
                        " status = @status " &
                        "WHERE student_id = @studentId AND company_id = @companyId;"

                    Dim rowsAffected As Integer
                    Using cmdIntern As New MySqlCommand(updateInternSql, conn, tran)
                        cmdIntern.Parameters.AddWithValue("@supervisorId", CurrentSupervisorId)
                        cmdIntern.Parameters.AddWithValue("@facultyId", CurrentFacultyId)
                        cmdIntern.Parameters.AddWithValue("@startDate", startDate)
                        cmdIntern.Parameters.AddWithValue("@endDate", endDate)
                        cmdIntern.Parameters.AddWithValue("@hoursReq", hoursRequired)
                        cmdIntern.Parameters.AddWithValue("@hoursComp", hoursCompleted)
                        cmdIntern.Parameters.AddWithValue("@status", status)
                        cmdIntern.Parameters.AddWithValue("@studentId", CurrentStudentId)
                        cmdIntern.Parameters.AddWithValue("@companyId", CurrentCompanyId)

                        rowsAffected = cmdIntern.ExecuteNonQuery()
                    End Using

                    ' If no row was updated, INSERT a new internship
                    If rowsAffected = 0 Then
                        Dim insertInternSql As String =
                            "INSERT INTO internship " &
                            " (student_id, company_id, supervisor_id, faculty_id, " &
                            "  starting_date, end_date, hours_required, hours_completed, status) " &
                            "VALUES (@studentId, @companyId, @supervisorId, @facultyId, " &
                            "        @startDate, @endDate, @hoursReq, @hoursComp, @status);"

                        Using cmdIntern As New MySqlCommand(insertInternSql, conn, tran)
                            cmdIntern.Parameters.AddWithValue("@studentId", CurrentStudentId)
                            cmdIntern.Parameters.AddWithValue("@companyId", CurrentCompanyId)
                            cmdIntern.Parameters.AddWithValue("@supervisorId", CurrentSupervisorId)
                            cmdIntern.Parameters.AddWithValue("@facultyId", CurrentFacultyId)
                            cmdIntern.Parameters.AddWithValue("@startDate", startDate)
                            cmdIntern.Parameters.AddWithValue("@endDate", endDate)
                            cmdIntern.Parameters.AddWithValue("@hoursReq", hoursRequired)
                            cmdIntern.Parameters.AddWithValue("@hoursComp", hoursCompleted)
                            cmdIntern.Parameters.AddWithValue("@status", status)
                            cmdIntern.ExecuteNonQuery()
                        End Using
                    End If

                    tran.Commit()
                Catch
                    tran.Rollback()
                    Throw
                End Try
            End Using

            MessageBox.Show("Internship information saved successfully.", "Saved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            SetInternFieldsEnabled(False)
            btnSave.Enabled = False
            btnEdit.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error saving internship information: " & ex.Message)
        End Try

        ' Refresh the UI from database
        LoadInternshipForStudent()
    End Sub

    Private Sub SetInternFieldsEnabled(enabled As Boolean)
        txtInternCompany.ReadOnly = Not enabled
        txtCompAddr.ReadOnly = Not enabled
        txtCompEmail.ReadOnly = Not enabled   ' Company Email

        DateTimePicker1.Enabled = enabled     ' Starting date
        DateTimePicker2.Enabled = enabled     ' End date

        TextBox1.ReadOnly = Not enabled       ' Required hours
        TextBox2.ReadOnly = Not enabled       ' Hours rendered
    End Sub

    Private Sub SetSupervisorFieldsEnabled(enabled As Boolean)
        txtSFName.ReadOnly = Not enabled
        txtLName.ReadOnly = Not enabled
        txtPos.ReadOnly = Not enabled
        txtSEmail.ReadOnly = Not enabled
        txtSContact.ReadOnly = Not enabled
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnlEvalHistory.Paint
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim profileForm As New MyProfileForm(CurrentStudentId)
        profileForm.Show()
        Me.Hide()
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
    End Sub

    Private Sub LoadInternshipForStudent()
        If String.IsNullOrWhiteSpace(CurrentStudentId) Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim sql As String =
                    "SELECT i.internship_id, i.student_id, i.company_id, i.supervisor_id, i.faculty_id, " &
                    "       i.starting_date, i.end_date, i.hours_required, i.hours_completed, i.status, " &
                    "       c.company_name, c.email AS company_email, c.address AS company_address, " &
                    "       cc.first_name, cc.last_name, cc.position, " &
                    "       cc.supervisor_email, cc.supervisor_contact " &
                    "FROM internship i " &
                    "JOIN company c ON i.company_id = c.company_id " &
                    "JOIN companycontact cc ON i.supervisor_id = cc.supervisor_id " &
                    "WHERE i.student_id = @studentId " &
                    "ORDER BY i.internship_id DESC " &
                    "LIMIT 1;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@studentId", CurrentStudentId)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' store IDs for later saves
                            CurrentInternshipId = Convert.ToInt32(reader("internship_id"))
                            CurrentCompanyId = Convert.ToInt32(reader("company_id"))
                            CurrentSupervisorId = Convert.ToInt32(reader("supervisor_id"))
                            CurrentFacultyId = Convert.ToInt32(reader("faculty_id"))

                            ' company / internship UI 
                            txtInternCompany.Text = reader("company_name").ToString()
                            txtCompEmail.Text = reader("company_email").ToString()
                            txtCompAddr.Text = reader("company_address").ToString()

                            DateTimePicker1.Value = CDate(reader("starting_date"))
                            If Not IsDBNull(reader("end_date")) Then
                                DateTimePicker2.Value = CDate(reader("end_date"))
                            End If

                            TextBox1.Text = reader("hours_required").ToString()
                            TextBox2.Text = reader("hours_completed").ToString()

                            ' supervisor UI 
                            txtSFName.Text = reader("first_name").ToString()
                            txtLName.Text = reader("last_name").ToString()
                            txtPos.Text = reader("position").ToString()
                            txtSEmail.Text = reader("supervisor_email").ToString()
                            txtSContact.Text = reader("supervisor_contact").ToString()
                        Else
                            ' no internship yet
                            CurrentInternshipId = 0
                        End If
                    End Using
                End Using
            End Using

            ' After loading, keep fields locked
            SetInternFieldsEnabled(False)
            SetSupervisorFieldsEnabled(False)
            btnSave.Enabled = False
            btnSsave.Enabled = False
            btnEdit.Enabled = True
            btnSedit.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error loading internship information: " & ex.Message)
        End Try
    End Sub

    ' Computes remaining hours
    Private Sub UpdateRemainingHours()
        Dim hoursRequired As Integer
        Dim hoursCompleted As Integer

        Integer.TryParse(TextBox1.Text, hoursRequired)  ' total required hours
        Integer.TryParse(TextBox2.Text, hoursCompleted) ' hours rendered

        Dim remaining As Integer = hoursRequired - hoursCompleted
        If remaining < 0 Then remaining = 0

        Label9.Text = remaining.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        UpdateRemainingHours()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        UpdateRemainingHours()
    End Sub
    '  VIEW REPORTS BUTTON
    '  Uses GRADE TABLE ONLY
    Private Sub btnViewRpt_Click(sender As Object, e As EventArgs) Handles btnViewRpt.Click
        If CurrentInternshipId = 0 Then
            MessageBox.Show("No internship record found to view evaluations.", "No Record",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim sql As String =
                    "SELECT sup_total_percent, prof_total_percent " &
                    "FROM grade WHERE internship_id = @internshipId LIMIT 1;"

                Dim supPercent As Decimal = 0D
                Dim profPercent As Decimal = 0D
                Dim hasRow As Boolean = False

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@internshipId", CurrentInternshipId)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            hasRow = True
                            If Not IsDBNull(reader("sup_total_percent")) Then
                                supPercent = Convert.ToDecimal(reader("sup_total_percent"))
                            End If
                            If Not IsDBNull(reader("prof_total_percent")) Then
                                profPercent = Convert.ToDecimal(reader("prof_total_percent"))
                            End If
                        End If
                    End Using
                End Using

                dtgEvalHistory.Rows.Clear()
                Dim evalCount As Integer = 0

                If Not hasRow Then
                    MessageBox.Show("There are no evaluations recorded yet for this internship.",
                                    "No Evaluations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Professor rating label
                    lblProfRating.Text = profPercent.ToString("0.00") & "%"
                    lblSupervisorRating.Text = supPercent.ToString("0.00") & "%"

                    ' Add rows to history grid (latest values from grade table)
                    If profPercent > 0D Then
                        dtgEvalHistory.Rows.Add("Latest", profPercent.ToString("0.00") & "%", "Professor")
                        evalCount += 1
                    End If

                    If supPercent > 0D Then
                        dtgEvalHistory.Rows.Add("Latest", supPercent.ToString("0.00") & "%", "Supervisor")
                        evalCount += 1
                    End If
                End If

                lblEvalComp.Text = "Evaluations Completed: " & evalCount.ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading evaluation report: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
