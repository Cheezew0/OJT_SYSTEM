Public Class Form1

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sidebar button style
        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        ' ADMIN button
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        ' LOGOUT button
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlStudent.Paint
        pnlStudent.BackColor = ColorTranslator.FromHtml("#D9D9D9")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblStudCount.Click

    End Sub

    Private Sub pnlActiveStud_Paint(sender As Object, e As PaintEventArgs) Handles pnlActiveStud.Paint
        pnlActiveStud.BackColor = ColorTranslator.FromHtml("#D9D9D9")
    End Sub

    Private Sub pnlCompIntern_Paint(sender As Object, e As PaintEventArgs) Handles pnlCompIntern.Paint
        pnlCompIntern.BackColor = ColorTranslator.FromHtml("#D9D9D9")
    End Sub

    Private Sub pnlPartnerComp_Paint(sender As Object, e As PaintEventArgs) Handles pnlPartnerComp.Paint
        pnlPartnerComp.BackColor = ColorTranslator.FromHtml("#D9D9D9")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblCompIntern.Click

    End Sub
    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlActivities_Paint(sender As Object, e As PaintEventArgs) Handles pnlActivitiesMain.Paint
        pnlActivitiesMain.BackColor = ColorTranslator.FromHtml("#D9D9D9")
    End Sub

    Private Sub pnlAct1_Paint(sender As Object, e As PaintEventArgs) Handles pnlAct1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles notifComp.Click

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


End Class
