Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class MyProfileForm
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnInternship.Click
        Dim btnInternshipForm As New StudInternForm
        btnInternshipForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub MyProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPersonalInfo.Region = RoundCorners(pnlPersonalInfo, 20)
        pnlAcadInfo.Region = RoundCorners(pnlAcadInfo, 20)
        pnlContactInfo.Region = RoundCorners(pnlContactInfo, 20)

        RoundButtonCorners(btnEditProf, 20)
        RoundButtonCorners(btnSave, 20)
        RoundButtonCorners(btnCancel, 20)

        pnlContactInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlAcadInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlPersonalInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")

        btnSave.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub pnlStudent_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub pnlPersonalInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlPersonalInfo.Paint
    End Sub

    Private Sub pnlAcadInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlAcadInfo.Paint
    End Sub

    Private Sub pnlContactInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlContactInfo.Paint
    End Sub

    Private Function RoundCorners(myPanel As Panel, radius As Integer) As Region
        Dim path As New GraphicsPath()
        path.StartFigure()

        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(myPanel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(myPanel.Width - radius, myPanel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, myPanel.Height - radius, radius, radius), 90, 90)

        path.CloseFigure()
        Return New Region(path)
    End Function

    Private Sub RoundButtonCorners(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()

        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)

        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class