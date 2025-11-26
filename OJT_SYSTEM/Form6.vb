Imports System.Drawing

Public Class FrmChooseLogin

    Private Sub FrmChooseLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set panel and form colors on load (correct place)
        panellf.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        Me.BackColor = ColorTranslator.FromHtml("#E6F2F4")
        StudentLogin.BackColor = ColorTranslator.FromHtml("#E6F2F4")
        FacultyLogin.BackColor = ColorTranslator.FromHtml("#E6F2F4")
    End Sub
    Private Sub StudentLogin_Click(sender As Object, e As EventArgs) Handles StudentLogin.Click
        Dim StudentPortal As New FrmStudentPortal
        StudentPortal.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyLogin_Click(sender As Object, e As EventArgs) Handles FacultyLogin.Click
        Dim FacultyLogin As New FrmFacultyLogIn
        FacultyLogin.Show()
        Me.Hide()
    End Sub
End Class
