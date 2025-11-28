Imports MySql.Data.MySqlClient

Public Class InternForm
    Private ReadOnly connStr As String =
    "Server=localhost;Database=ojt_management_system;User Id=root;Password=;"

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
        Dim studentId As String = MaskedTextBox1.Text.Trim()

        If String.IsNullOrEmpty(studentId) Then
            MessageBox.Show("Please enter a Student ID.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connStr)
            Dim sql As String =
            "SELECT student_id, first_name, middle_name, last_name, " &
            "       program, email_address, address, status " &
            "FROM student " &
            "WHERE student_id = @id;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", studentId)

                Try
                    conn.Open()
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim first As String = rdr("first_name").ToString()
                            Dim middle As String = If(IsDBNull(rdr("middle_name")), "", rdr("middle_name").ToString())
                            Dim last As String = rdr("last_name").ToString()
                            Dim fullName As String = (first & " " & middle & " " & last).Replace("  ", " ").Trim()

                            lblStudID.Text = rdr("student_id").ToString()
                            lblStudName.Text = fullName
                            lblCourse.Text = rdr("program").ToString()
                            lblEmail.Text = rdr("email_address").ToString()
                            lblAddress.Text = rdr("address").ToString()
                            lblStatus.Text = rdr("status").ToString()
                        Else
                            MessageBox.Show("Student not found.")
                            ClearStudentInfo()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error while searching: " & ex.Message)
                End Try
            End Using
        End Using
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