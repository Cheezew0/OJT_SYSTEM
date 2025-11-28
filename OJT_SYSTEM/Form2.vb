Imports System.IO
Imports MySql.Data.MySqlClient

Public Class StudentForm
    Private connectionString As String =
    "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStudents = New RoundedPanel()

        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInternships_Click(sender As Object, e As EventArgs) Handles btnInternships.Click
        Dim internForm As New InternForm()
        internForm.Show()
        Me.Hide()
    End Sub
    '
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
            FrmChooseLogin.Show()
        End If
    End Sub

    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select CSV file"
        ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines() As String = File.ReadAllLines(ofd.FileName)

                dgvStudents.Rows.Clear()

                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i).Trim()
                    If line = "" Then Continue For

                    Dim parts() As String = line.Split(","c)

                    If parts.Length > 0 Then
                        Dim studentId As String = parts(0).Trim()

                        Dim rowIndex As Integer = dgvStudents.Rows.Add()
                        dgvStudents.Rows(rowIndex).Cells("colStudentID").Value = studentId
                    End If
                Next

                MessageBox.Show("Student IDs loaded from CSV.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error reading CSV file: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveStudentIdsToDatabase()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String =
            "INSERT INTO student " &
            "(student_id, first_name, last_name, middle_name, program, email_address, address, student_contact, section, status) " &
            "VALUES (@StudentId, '', '', '', '', '', '', NULL, '', 'Active') " &
            "ON DUPLICATE KEY UPDATE student_id = student_id;"

            Using cmd As New MySqlCommand(sql, conn)

                For Each row As DataGridViewRow In dgvStudents.Rows
                    If row.IsNewRow Then Continue For

                    Dim idObj = row.Cells("colStudentID").Value
                    If idObj Is Nothing Then Continue For

                    Dim studentId As String = idObj.ToString().Trim()
                    If studentId = "" Then Continue For

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@StudentId", studentId)
                    cmd.ExecuteNonQuery()
                Next

            End Using
        End Using
    End Sub

End Class