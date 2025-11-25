Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class RoundedPanel
    Inherits DataGridView

    Public Property CornerRadius As Integer = 20

    Public Sub New()
        MyBase.New()
        InitializeStyle()
    End Sub

    Private Sub InitializeStyle()
        ' Header styling
        Me.EnableHeadersVisualStyles = False
        Me.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        Me.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.ColumnHeadersHeight = 35

        ' Row styling
        Me.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        Me.DefaultCellStyle.ForeColor = Color.Black
        Me.DefaultCellStyle.Font = New Font("Segoe UI", 9.0F)
        Me.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DefaultCellStyle.Padding = New Padding(5)

        ' Alternating row colors
        Me.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        Me.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

        ' Border and grid styling
        Me.BorderStyle = BorderStyle.None
        Me.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridColor = ColorTranslator.FromHtml("#E0E0E0")
        Me.RowHeadersVisible = False
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Selection styling
        Me.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#B7C0D9")
        Me.DefaultCellStyle.SelectionForeColor = Color.Black

        ' Row height
        Me.RowTemplate.Height = 30
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim rect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As New GraphicsPath()

        Dim radius As Integer = CornerRadius

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    End Sub
End Class
