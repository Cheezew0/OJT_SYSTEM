Public Class EvaluationForm
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
        pnlEval.Region = RoundCorners(pnlEval, 20)
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlRating.Paint
        pnlRating.BackColor = SetPanelTransparency(pnlRating, 50)
        pnlRating.Region = RoundCorners(pnlRating, 20)
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
            FrmChooseLogin.Show()
        End If
    End Sub

    Private Sub btnEvaluationLog_Click(sender As Object, e As EventArgs) Handles btnEvaluationLog.Click

    End Sub
End Class