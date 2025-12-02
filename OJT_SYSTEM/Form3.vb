Imports MySql.Data.MySqlClient

Public Class InternForm
    Private Sub LoadInternshipDetails(studentId As String)
        Dim cs As String = "server=localhost;user id=root;password=;database=ojt_management_system;"

        ' === VALIDATE FACULTY SESSION ===
        If SessionData.CurrentFacultyId <= 0 Then
            MessageBox.Show("Faculty information missing. Please log in again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(cs)
            conn.Open()

            Dim query As String =
        "SELECT 
            s.student_id,
            CONCAT(s.first_name, ' ', s.last_name) AS student_name,
            s.program,
            s.email_address,

            i.starting_date,
            i.end_date,
            i.hours_required,
            i.hours_completed,
            i.status,

            c.company_name,
            c.address AS company_address,

            cc.first_name AS sup_fname,
            cc.last_name AS sup_lname
         FROM internship i
         INNER JOIN student s ON i.student_id = s.student_id
         INNER JOIN company c ON i.company_id = c.company_id
         INNER JOIN companycontact cc ON i.supervisor_id = cc.supervisor_id
         WHERE i.student_id = @studentId
           AND i.faculty_id = @facultyId
         LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentId", studentId)
                cmd.Parameters.AddWithValue("@facultyId", SessionData.CurrentFacultyId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' ===== STUDENT INFO =====
                        lblStudID.Text = reader("student_id").ToString()
                        lblStudName.Text = reader("student_name").ToString()
                        lblCourse.Text = reader("program").ToString()
                        lblEmail.Text = reader("email_address").ToString()

                        ' ===== INTERNSHIP INFO =====
                        lblStartdate.Text = CDate(reader("starting_date")).ToShortDateString()
                        lblEndDate.Text = CDate(reader("end_date")).ToShortDateString()
                        lblReqHrs.Text = reader("hours_required").ToString()
                        lblStatus.Text = reader("status").ToString()

                        ' ===== COMPANY INFO =====
                        lblCompany.Text = reader("company_name").ToString()
                        lblAddress.Text = reader("company_address").ToString()

                        ' ===== SUPERVISOR INFO =====
                        lblSupervisor.Text = reader("sup_fname").ToString() & " " &
                                         reader("sup_lname").ToString()
                    Else
                        ClearStudentInfo()
                        MessageBox.Show(
                        "No internship record found for this student ID under your supervision.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnInternships_Click(sender As Object, e As EventArgs) Handles btnInternships.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim studentForm As New StudentForm()
        studentForm.Show()
        Me.Hide()
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub InternForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")
        pnlsearch.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlStudInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlInternInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlProgress.BackColor = ColorTranslator.FromHtml("#F7F7F7")


        pnlProgress.Region = RoundCorners(pnlProgress, 20)
        pnlInternInfo.Region = RoundCorners(pnlInternInfo, 20)
        pnlsearch.Region = RoundCorners(pnlsearch, 20)
        pnlStudInfo.Region = RoundCorners(pnlStudInfo, 20)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnlsearch.Paint
        pnlsearch.BackColor = ColorTranslator.FromHtml("#F7F7F7")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Function RoundCorners(myPanel As Panel, radius As Integer) As Region
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()

        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(myPanel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(myPanel.Width - radius, myPanel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, myPanel.Height - radius, radius, radius), 90, 90)

        path.CloseFigure()
        Return New Region(path)
    End Function

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles lblStartdate.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlInternInfo.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnEvaluationLog_Click(sender As Object, e As EventArgs) Handles btnEvaluationLog.Click
        Dim evaluationForm As New EvaluationForm()
        evaluationForm.Show()
        Me.Hide()
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

    Private Sub pnlStudInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlStudInfo.Paint

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ClearStudentInfo()

        If SessionData.CurrentFacultyId <= 0 Then
            MessageBox.Show("Faculty information missing. Please log in again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sid As String = MaskedTextBox1.Text.Trim()

        If Not MaskedTextBox1.MaskCompleted Then
            MessageBox.Show("Please enter a complete student ID.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If sid.Length < 5 Then
            MessageBox.Show("Please enter a valid student ID.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        LoadInternshipDetails(sid)
    End Sub


    Private Sub ClearStudentInfo()
        lblStudID.Text = ""
        lblStudName.Text = ""
        lblCourse.Text = ""
        lblEmail.Text = ""
        lblAddress.Text = ""
        lblStatus.Text = ""
    End Sub

End Class