Public Class FrmStudentPortal
    Private Sub FrmStudentPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlStudentLogIn.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        Me.BackColor = ColorTranslator.FromHtml("#E6F2F4")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim ChooseLogIn As New FrmChooseLogin
        ChooseLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim profileForm As New MyProfileForm()
        profileForm.Show()
        Me.Hide()
    End Sub
End Class