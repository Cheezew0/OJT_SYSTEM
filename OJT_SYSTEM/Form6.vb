Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class StudInternForm

    Private ReadOnly connectionString As String =
        "server=localhost;user id=root;password=;database=ojt_management_system;"

    Private Sub btnInternship_Click(sender As Object, e As EventArgs) Handles btnInternship.Click

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
        Panel2.BackColor = ColorTranslator.FromHtml("#F7F7F7")

        pnlIntern.Region = RoundCorners(pnlIntern, 20)
        pnlSummary.Region = RoundCorners(pnlSummary, 20)
        Panel2.Region = RoundCorners(Panel2, 20)

        StyleDataGridView(dtgEvalHistory)
        SetInternFieldsEnabled(False)
        SetSupervisorFieldsEnabled(False)
        btnSave.Enabled = False
        btnSsave.Enabled = False
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

    End Sub

    Private Sub pnlIntern_Paint(sender As Object, e As PaintEventArgs) Handles pnlIntern.Paint
        pnlIntern.BackColor = ColorTranslator.FromHtml("#F7F7F7")
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
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtSFName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLName.Text) Then
            MessageBox.Show("Please enter the supervisor's first and last name.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Example: update or insert supervisor for CurrentCompanyId
                Dim updateSql As String =
                "UPDATE companycontact " &
                "SET first_name = @firstName, " &
                "    last_name = @lastName, " &
                "    position = @position, " &
                "    supervisor_email = @email, " &
                "    supervisor_contact = @contact " &
                "WHERE company_id = @companyId;"

                Using cmd As New MySqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@firstName", txtSFName.Text.Trim())
                    cmd.Parameters.AddWithValue("@lastName", txtLName.Text.Trim())
                    cmd.Parameters.AddWithValue("@position", txtPos.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtSEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtSContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@companyId", CurrentCompanyId)

                    Dim rows = cmd.ExecuteNonQuery()

                    ' If this company has no supervisor yet, insert one
                    If rows = 0 Then
                        cmd.CommandText =
                        "INSERT INTO companycontact " &
                        " (first_name, last_name, position, supervisor_email, supervisor_contact, company_id) " &
                        "VALUES (@firstName, @lastName, @position, @email, @contact, @companyId);"

                        cmd.ExecuteNonQuery()
                    End If
                End Using
            End Using

            MessageBox.Show("Supervisor information saved successfully.", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Lock fields again
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
        btnEdit.Enabled = False           ' optional: prevent double-clicking Edit
    End Sub

    Private Sub btnSedit_Click(sender As Object, e As EventArgs) Handles btnSedit.Click
        SetSupervisorFieldsEnabled(True)
        btnSsave.Enabled = True
        btnSedit.Enabled = False          ' optional
    End Sub

    Private CurrentStudentId As String = "23-00604"   ' example
    Private CurrentCompanyId As Integer = 1           ' example company_id
    Private CurrentSupervisorId As Integer = 1        ' example supervisor_id
    Private CurrentFacultyId As Integer = 2           ' example faculty_id

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic validation – add more as you like
        If String.IsNullOrWhiteSpace(txtInternCompany.Text) Then
            MessageBox.Show("Please enter a company name.")
            Return
        End If

        Dim hoursRequired As Integer
        Dim hoursCompleted As Integer

        If Not Integer.TryParse(TextBox1.Text, hoursRequired) Then
            MessageBox.Show("Hours required must be a number.")
            Return
        End If

        If Not Integer.TryParse(TextBox2.Text, hoursCompleted) Then
            MessageBox.Show("Hours completed must be a number.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' 1) Optional: update company info based on CurrentCompanyId
                Dim updateCompanySql As String =
                "UPDATE company " &
                "SET company_name = @name, email = @email, address = @address " &
                "WHERE company_id = @companyId;"

                Using cmdCompany As New MySqlCommand(updateCompanySql, conn)
                    cmdCompany.Parameters.AddWithValue("@name", txtInternCompany.Text.Trim())
                    cmdCompany.Parameters.AddWithValue("@email", txtCompEmail.Text.Trim())
                    cmdCompany.Parameters.AddWithValue("@address", txtCompAddr.Text.Trim())
                    cmdCompany.Parameters.AddWithValue("@companyId", CurrentCompanyId)
                    cmdCompany.ExecuteNonQuery()
                End Using

                ' 2) Update or insert internship row for this student
                ' Example: UPDATE existing internship
                Dim updateInternSql As String =
                "UPDATE internship " &
                "SET starting_date = @startDate, " &
                "    end_date = @endDate, " &
                "    hours_required = @hoursReq, " &
                "    hours_completed = @hoursComp, " &
                "    status = @status " &
                "WHERE student_id = @studentId " &
                "  AND company_id = @companyId;"

                Using cmdIntern As New MySqlCommand(updateInternSql, conn)
                    cmdIntern.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.Date)
                    cmdIntern.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.Date)
                    cmdIntern.Parameters.AddWithValue("@hoursReq", hoursRequired)
                    cmdIntern.Parameters.AddWithValue("@hoursComp", hoursCompleted)
                    cmdIntern.Parameters.AddWithValue("@status", "Ongoing")   ' or Planned/Completed
                    cmdIntern.Parameters.AddWithValue("@studentId", CurrentStudentId)
                    cmdIntern.Parameters.AddWithValue("@companyId", CurrentCompanyId)

                    Dim rowsAffected = cmdIntern.ExecuteNonQuery()

                    ' If no row was updated, you can INSERT instead:
                    If rowsAffected = 0 Then
                        cmdIntern.CommandText =
                        "INSERT INTO internship " &
                        " (student_id, company_id, supervisor_id, faculty_id, " &
                        "  starting_date, end_date, hours_required, hours_completed, status) " &
                        "VALUES (@studentId, @companyId, @supervisorId, @facultyId, " &
                        "        @startDate, @endDate, @hoursReq, @hoursComp, @status);"

                        cmdIntern.Parameters.AddWithValue("@supervisorId", CurrentSupervisorId)
                        cmdIntern.Parameters.AddWithValue("@facultyId", CurrentFacultyId)
                        cmdIntern.ExecuteNonQuery()
                    End If
                End Using
            End Using

            MessageBox.Show("Internship information saved successfully.", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Lock fields again
            SetInternFieldsEnabled(False)
            btnSave.Enabled = False
            btnEdit.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error saving internship information: " & ex.Message)
        End Try
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
End Class