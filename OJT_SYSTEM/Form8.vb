Public Class FrmFacultyLogIn
    Private Sub FrmFacultyLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim ChooseLogIn As New FrmChooseLogin
        ChooseLogIn.Show()
        Me.Hide()
    End Sub

End Class