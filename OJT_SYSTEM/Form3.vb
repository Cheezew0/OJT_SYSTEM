Public Class InternForm
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
            Application.Exit()
        End If
    End Sub

    Private Sub pnlStudInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlStudInfo.Paint

    End Sub
End Class