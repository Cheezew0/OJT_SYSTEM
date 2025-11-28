Public Class StudInternForm
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
            FrmChooseLogin.Show()
        End If
    End Sub
End Class