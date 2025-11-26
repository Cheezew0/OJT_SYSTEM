<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudInternForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudInternForm))
        Label1 = New Label()
        btnInternship = New Button()
        btnProfile = New Button()
        PictureBoxLogo = New PictureBox()
        btnLogout = New Button()
        btnFaculty = New Button()
        pnlBottomMenu = New Panel()
        pnlSidebar = New Panel()
        pnlMain = New Panel()
        Panel2 = New Panel()
        dtgEvalHistory = New DataGridView()
        colDate = New DataGridViewTextBoxColumn()
        colScore = New DataGridViewTextBoxColumn()
        colEvaluator = New DataGridViewTextBoxColumn()
        Label12 = New Label()
        pnlSummary = New Panel()
        lblRating = New Label()
        lblEvalComp = New Label()
        btnViewRpt = New Button()
        Label11 = New Label()
        Label10 = New Label()
        pnlIntern = New Panel()
        btnEdit = New Button()
        Label9 = New Label()
        Label8 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        txtCompAddr = New TextBox()
        Label3 = New Label()
        txtInternCompany = New TextBox()
        Label2 = New Label()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlBottomMenu.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dtgEvalHistory, ComponentModel.ISupportInitialize).BeginInit()
        pnlSummary.SuspendLayout()
        pnlIntern.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label1.Location = New Point(333, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 50)
        Label1.TabIndex = 6
        Label1.Text = "Internship"
        ' 
        ' btnInternship
        ' 
        btnInternship.BackColor = Color.Transparent
        btnInternship.BackgroundImageLayout = ImageLayout.None
        btnInternship.FlatAppearance.BorderSize = 0
        btnInternship.FlatStyle = FlatStyle.Flat
        btnInternship.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInternship.ForeColor = Color.White
        btnInternship.Image = My.Resources.Resources.Graduation_Cap
        btnInternship.Location = New Point(12, 227)
        btnInternship.Name = "btnInternship"
        btnInternship.Padding = New Padding(10, 0, 0, 0)
        btnInternship.Size = New Size(205, 65)
        btnInternship.TabIndex = 2
        btnInternship.Text = "Internship"
        btnInternship.TextAlign = ContentAlignment.MiddleRight
        btnInternship.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInternship.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Transparent
        btnProfile.BackgroundImageLayout = ImageLayout.None
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfile.ForeColor = Color.White
        btnProfile.Image = My.Resources.Resources.Home
        btnProfile.Location = New Point(12, 156)
        btnProfile.Name = "btnProfile"
        btnProfile.Padding = New Padding(10, 0, 0, 0)
        btnProfile.Size = New Size(205, 65)
        btnProfile.TabIndex = 1
        btnProfile.Text = "My Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleRight
        btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.ErrorImage = CType(resources.GetObject("PictureBoxLogo.ErrorImage"), Image)
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.InitialImage = CType(resources.GetObject("PictureBoxLogo.InitialImage"), Image)
        PictureBoxLogo.Location = New Point(42, 22)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(125, 101)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImageLayout = ImageLayout.None
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Image = My.Resources.Resources.Logout
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(42, 75)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(150, 48)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Log Out"
        btnLogout.TextAlign = ContentAlignment.MiddleRight
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnFaculty
        ' 
        btnFaculty.BackgroundImageLayout = ImageLayout.None
        btnFaculty.FlatAppearance.BorderSize = 0
        btnFaculty.FlatStyle = FlatStyle.Flat
        btnFaculty.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFaculty.ForeColor = Color.White
        btnFaculty.Image = My.Resources.Resources.Test_Account
        btnFaculty.ImageAlign = ContentAlignment.MiddleLeft
        btnFaculty.Location = New Point(42, 21)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.Padding = New Padding(20, 0, 0, 0)
        btnFaculty.RightToLeft = RightToLeft.No
        btnFaculty.Size = New Size(150, 48)
        btnFaculty.TabIndex = 0
        btnFaculty.Text = "Student"
        btnFaculty.TextAlign = ContentAlignment.MiddleRight
        btnFaculty.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFaculty.UseVisualStyleBackColor = False
        ' 
        ' pnlBottomMenu
        ' 
        pnlBottomMenu.Controls.Add(btnLogout)
        pnlBottomMenu.Controls.Add(btnFaculty)
        pnlBottomMenu.Dock = DockStyle.Bottom
        pnlBottomMenu.Location = New Point(0, 706)
        pnlBottomMenu.Name = "pnlBottomMenu"
        pnlBottomMenu.Size = New Size(230, 152)
        pnlBottomMenu.TabIndex = 5
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.Transparent
        pnlSidebar.Controls.Add(pnlBottomMenu)
        pnlSidebar.Controls.Add(btnInternship)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(PictureBoxLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 858)
        pnlSidebar.TabIndex = 6
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(Panel2)
        pnlMain.Controls.Add(pnlSummary)
        pnlMain.Controls.Add(pnlIntern)
        pnlMain.Controls.Add(Label1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1422, 858)
        pnlMain.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dtgEvalHistory)
        Panel2.Controls.Add(Label12)
        Panel2.Location = New Point(333, 514)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(824, 218)
        Panel2.TabIndex = 9
        ' 
        ' dtgEvalHistory
        ' 
        dtgEvalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgEvalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgEvalHistory.Columns.AddRange(New DataGridViewColumn() {colDate, colScore, colEvaluator})
        dtgEvalHistory.Dock = DockStyle.Fill
        dtgEvalHistory.Location = New Point(0, 0)
        dtgEvalHistory.Name = "dtgEvalHistory"
        dtgEvalHistory.RowHeadersWidth = 51
        dtgEvalHistory.Size = New Size(824, 218)
        dtgEvalHistory.TabIndex = 3
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date:"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        ' 
        ' colScore
        ' 
        colScore.HeaderText = "Score:"
        colScore.MinimumWidth = 6
        colScore.Name = "colScore"
        ' 
        ' colEvaluator
        ' 
        colEvaluator.HeaderText = "Evaluator"
        colEvaluator.MinimumWidth = 6
        colEvaluator.Name = "colEvaluator"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label12.Location = New Point(19, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(175, 25)
        Label12.TabIndex = 2
        Label12.Text = "Evaluation History:"
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Controls.Add(lblRating)
        pnlSummary.Controls.Add(lblEvalComp)
        pnlSummary.Controls.Add(btnViewRpt)
        pnlSummary.Controls.Add(Label11)
        pnlSummary.Controls.Add(Label10)
        pnlSummary.Location = New Point(333, 396)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(824, 112)
        pnlSummary.TabIndex = 8
        ' 
        ' lblRating
        ' 
        lblRating.AutoSize = True
        lblRating.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRating.Location = New Point(92, 52)
        lblRating.Name = "lblRating"
        lblRating.Size = New Size(22, 25)
        lblRating.TabIndex = 17
        lblRating.Text = "0"
        ' 
        ' lblEvalComp
        ' 
        lblEvalComp.AutoSize = True
        lblEvalComp.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEvalComp.Location = New Point(411, 52)
        lblEvalComp.Name = "lblEvalComp"
        lblEvalComp.Size = New Size(194, 25)
        lblEvalComp.TabIndex = 16
        lblEvalComp.Text = "Evaluations Completed"
        ' 
        ' btnViewRpt
        ' 
        btnViewRpt.Location = New Point(611, 51)
        btnViewRpt.Name = "btnViewRpt"
        btnViewRpt.Size = New Size(175, 31)
        btnViewRpt.TabIndex = 15
        btnViewRpt.Text = "View Reports"
        btnViewRpt.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(19, 52)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 25)
        Label11.TabIndex = 14
        Label11.Text = "Rating:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label10.Location = New Point(19, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(159, 25)
        Label10.TabIndex = 1
        Label10.Text = "Summary Rating:"
        ' 
        ' pnlIntern
        ' 
        pnlIntern.Controls.Add(btnEdit)
        pnlIntern.Controls.Add(Label9)
        pnlIntern.Controls.Add(Label8)
        pnlIntern.Controls.Add(TextBox2)
        pnlIntern.Controls.Add(TextBox1)
        pnlIntern.Controls.Add(Label7)
        pnlIntern.Controls.Add(Label6)
        pnlIntern.Controls.Add(DateTimePicker2)
        pnlIntern.Controls.Add(DateTimePicker1)
        pnlIntern.Controls.Add(Label5)
        pnlIntern.Controls.Add(Label4)
        pnlIntern.Controls.Add(txtCompAddr)
        pnlIntern.Controls.Add(Label3)
        pnlIntern.Controls.Add(txtInternCompany)
        pnlIntern.Controls.Add(Label2)
        pnlIntern.Location = New Point(333, 119)
        pnlIntern.Name = "pnlIntern"
        pnlIntern.Size = New Size(1015, 271)
        pnlIntern.TabIndex = 7
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(886, 44)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 28)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(611, 212)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 20)
        Label9.TabIndex = 13
        Label9.Text = "Time Remaining:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(611, 181)
        Label8.Name = "Label8"
        Label8.Size = New Size(155, 25)
        Label8.TabIndex = 12
        Label8.Text = "Time Remaining:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(341, 209)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(144, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(19, 209)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(341, 181)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 25)
        Label7.TabIndex = 9
        Label7.Text = "Hours Rendered:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(19, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(197, 25)
        Label6.TabIndex = 8
        Label6.Text = "Total Required Hours:"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(341, 128)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(241, 27)
        DateTimePicker2.TabIndex = 7
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(19, 128)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(241, 27)
        DateTimePicker1.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(341, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 25)
        Label5.TabIndex = 5
        Label5.Text = "End Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(19, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 4
        Label4.Text = "Start Date:"
        ' 
        ' txtCompAddr
        ' 
        txtCompAddr.Location = New Point(433, 45)
        txtCompAddr.Name = "txtCompAddr"
        txtCompAddr.Size = New Size(333, 27)
        txtCompAddr.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(433, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 25)
        Label3.TabIndex = 2
        Label3.Text = "Company Address:"
        ' 
        ' txtInternCompany
        ' 
        txtInternCompany.Location = New Point(19, 45)
        txtInternCompany.Name = "txtInternCompany"
        txtInternCompany.Size = New Size(333, 27)
        txtInternCompany.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(19, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 25)
        Label2.TabIndex = 0
        Label2.Text = "Internship Company:"
        ' 
        ' StudInternForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlMain)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "StudInternForm"
        Text = "Pasig Institute of Technology"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlBottomMenu.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dtgEvalHistory, ComponentModel.ISupportInitialize).EndInit()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        pnlIntern.ResumeLayout(False)
        pnlIntern.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInternship As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents pnlBottomMenu As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlIntern As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInternCompany As TextBox
    Friend WithEvents txtCompAddr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents btnViewRpt As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents lblEvalComp As Label
    Friend WithEvents dtgEvalHistory As DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colScore As DataGridViewTextBoxColumn
    Friend WithEvents colEvaluator As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As Button
End Class
