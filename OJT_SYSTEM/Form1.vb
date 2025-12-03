Imports MySql.Data.MySqlClient

Public Class DashboardForm

    Private _accountId As Integer

    Private ReadOnly connectionString As String =
        "server=localhost;user id=root;password=;database=ojt_management_system;"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(accountId As Integer)
        Me.New()
        _accountId = accountId
    End Sub
    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        pnlStudent.Region = RoundCorners(pnlStudent, 20)
        pnlActiveStud.Region = RoundCorners(pnlActiveStud, 20)
        pnlCompIntern.Region = RoundCorners(pnlCompIntern, 20)
        pnlPartnerComp.Region = RoundCorners(pnlPartnerComp, 20)
        pnlActivitiesMain.Region = RoundCorners(pnlActivitiesMain, 20)

        LoadDashboardForFaculty()
        StyleDashboardGrid()
    End Sub
    Private Sub StyleDashboardGrid()
        If dtgDashboard Is Nothing Then Return

        ' General behavior
        dtgDashboard.ReadOnly = True
        dtgDashboard.AllowUserToAddRows = False
        dtgDashboard.AllowUserToDeleteRows = False
        dtgDashboard.AllowUserToResizeRows = False
        dtgDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgDashboard.MultiSelect = False
        dtgDashboard.RowHeadersVisible = False
        dtgDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgDashboard.BorderStyle = BorderStyle.None
        dtgDashboard.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgDashboard.GridColor = ColorTranslator.FromHtml("#E0E0E0")
        dtgDashboard.BackgroundColor = ColorTranslator.FromHtml("#D9DCEB")   ' matches card background a bit

        ' Header style
        dtgDashboard.EnableHeadersVisualStyles = False
        dtgDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgDashboard.ColumnHeadersHeight = 32

        dtgDashboard.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        dtgDashboard.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dtgDashboard.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        dtgDashboard.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Default row style
        dtgDashboard.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        dtgDashboard.DefaultCellStyle.ForeColor = Color.Black
        dtgDashboard.DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        dtgDashboard.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#B7C0D9")
        dtgDashboard.DefaultCellStyle.SelectionForeColor = Color.Black
        dtgDashboard.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgDashboard.DefaultCellStyle.Padding = New Padding(4, 2, 4, 2)

        ' Alternating rows
        dtgDashboard.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        dtgDashboard.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

        ' Row template
        dtgDashboard.RowTemplate.Height = 26

        ' Optional: specific column header text (just in case)
        If dtgDashboard.Columns.Contains("colStudId") Then
            dtgDashboard.Columns("colStudId").HeaderText = "Student ID"
        End If
        If dtgDashboard.Columns.Contains("colStatus") Then
            dtgDashboard.Columns("colStatus").HeaderText = "Active Students"
        End If
        If dtgDashboard.Columns.Contains("colCompIntern") Then
            dtgDashboard.Columns("colCompIntern").HeaderText = "Completed Internship"
        End If
        If dtgDashboard.Columns.Contains("colCompany") Then
            dtgDashboard.Columns("colCompany").HeaderText = "Company"
            dtgDashboard.Columns("colCompany").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End If
    End Sub

    Private Sub LoadDashboardForFaculty()
        Dim facultyId As Integer = SessionData.CurrentFacultyId

        If facultyId <= 0 Then
            ' No faculty logged in – show zeros
            lblStudCount.Text = "0"
            lblActStudCount.Text = "0"
            lblCompIntern.Text = "0"
            lblPartnerCompCount.Text = "0"
            If dtgDashboard IsNot Nothing Then
                dtgDashboard.Rows.Clear()
            End If
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' ========================
                ' 1) SUMMARY COUNTS
                ' ========================

                ' Total students handled by this professor
                Dim totalStudents As Integer
                Using cmd As New MySqlCommand(
                "SELECT COUNT(*) " &
                "FROM student " &
                "WHERE faculty_id = @fid;", conn)
                    cmd.Parameters.AddWithValue("@fid", facultyId)
                    totalStudents = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Active students (internship status = Ongoing)
                Dim activeStudents As Integer
                Using cmd As New MySqlCommand(
                "SELECT COUNT(DISTINCT i.student_id) " &
                "FROM internship i " &
                "JOIN student s ON s.student_id = i.student_id " &
                "WHERE s.faculty_id = @fid AND i.status = 'Ongoing';", conn)
                    cmd.Parameters.AddWithValue("@fid", facultyId)
                    activeStudents = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Completed internships
                Dim completedInternships As Integer
                Using cmd As New MySqlCommand(
                "SELECT COUNT(*) " &
                "FROM internship i " &
                "JOIN student s ON s.student_id = i.student_id " &
                "WHERE s.faculty_id = @fid AND i.status = 'Completed';", conn)
                    cmd.Parameters.AddWithValue("@fid", facultyId)
                    completedInternships = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Partner companies (distinct companies of this professor's students)
                Dim partnerCompanies As Integer
                Using cmd As New MySqlCommand(
                "SELECT COUNT(DISTINCT i.company_id) " &
                "FROM internship i " &
                "JOIN student s ON s.student_id = i.student_id " &
                "WHERE s.faculty_id = @fid AND i.company_id IS NOT NULL;", conn)
                    cmd.Parameters.AddWithValue("@fid", facultyId)
                    partnerCompanies = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' ✅ Show in the correct labels
                lblStudCount.Text = totalStudents.ToString()
                lblActStudCount.Text = activeStudents.ToString()
                lblCompIntern.Text = completedInternships.ToString()
                lblPartnerCompCount.Text = partnerCompanies.ToString()


                If dtgDashboard IsNot Nothing Then
                    dtgDashboard.Rows.Clear()

                    Dim listSql As String =
                    "SELECT s.student_id, i.status, c.company_name " &
                    "FROM internship i " &
                    "JOIN student s ON s.student_id = i.student_id " &
                    "LEFT JOIN company c ON c.company_id = i.company_id " &
                    "WHERE s.faculty_id = @fid " &
                    "ORDER BY s.student_id;"

                    Using cmdList As New MySqlCommand(listSql, conn)
                        cmdList.Parameters.AddWithValue("@fid", facultyId)

                        Using r = cmdList.ExecuteReader()
                            While r.Read()
                                Dim sid As String = r("student_id").ToString()
                                Dim status As String = r("status").ToString()
                                Dim company As String =
                                If(IsDBNull(r("company_name")), "N/A", r("company_name").ToString())

                                Dim isActive As String = If(status = "Ongoing", "Yes", "No")
                                Dim isCompleted As String = If(status = "Completed", "Yes", "No")

                                dtgDashboard.Rows.Add(sid, isActive, isCompleted, company)
                            End While
                        End Using
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlStudent.Paint
        pnlStudent.BackColor = ColorTranslator.FromHtml("#f7f7f7")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblStudCount.Click

    End Sub

    Private Sub pnlActiveStud_Paint(sender As Object, e As PaintEventArgs) Handles pnlActiveStud.Paint
        pnlActiveStud.BackColor = ColorTranslator.FromHtml("#f7f7f7")
    End Sub

    Private Sub pnlCompIntern_Paint(sender As Object, e As PaintEventArgs) Handles pnlCompIntern.Paint
        pnlCompIntern.BackColor = ColorTranslator.FromHtml("#f7f7f7")
    End Sub

    Private Sub pnlPartnerComp_Paint(sender As Object, e As PaintEventArgs) Handles pnlPartnerComp.Paint
        pnlPartnerComp.BackColor = ColorTranslator.FromHtml("#f7f7f7")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles label.Click

    End Sub
    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlActivities_Paint(sender As Object, e As PaintEventArgs) Handles pnlActivitiesMain.Paint
        pnlActivitiesMain.BackColor = ColorTranslator.FromHtml("#f7f7f7")
    End Sub

    Private Sub pnlAct1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

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

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim studentForm As New StudentForm()
        studentForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

    Private Sub btnInternships_Click(sender As Object, e As EventArgs) Handles btnInternships.Click
        Dim internForm As New InternForm()
        internForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnEvaluationLog_Click(sender As Object, e As EventArgs) Handles btnEvaluationLog.Click
        Dim evalForm As New EvaluationForm()
        evalForm.Show()
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

End Class
