<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        pnlBottomMenu = New Panel()
        btnLogout = New Button()
        btnFaculty = New Button()
        btnEvaluationLog = New Button()
        btnInternships = New Button()
        btnStudent = New Button()
        btnDashboard = New Button()
        PictureBoxLogo = New PictureBox()
        pnlMain = New Panel()
        pnlActivitiesMain = New Panel()
        btnAddFile = New Button()
        dgvStudents = New RoundedPanel()
        Student_ID = New DataGridViewTextBoxColumn()
        Student_Name = New DataGridViewTextBoxColumn()
        Program = New DataGridViewTextBoxColumn()
        Department = New DataGridViewTextBoxColumn()
        Company = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Supervisor = New DataGridViewTextBoxColumn()
        Rating = New DataGridViewTextBoxColumn()
        pnlPartnerComp = New Panel()
        lblPartnerCompCount = New Label()
        PictureBox4 = New PictureBox()
        lblPartnerComp = New Label()
        pnlCompIntern = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        lblCompIntern = New Label()
        pnlActiveStud = New Panel()
        lblActStudCount = New Label()
        PictureBox2 = New PictureBox()
        lblActiveStud = New Label()
        pnlStudent = New Panel()
        lblStudCount = New Label()
        PictureBox1 = New PictureBox()
        lblTotalStudentsTitle = New Label()
        Label1 = New Label()
        pnlSidebar.SuspendLayout()
        pnlBottomMenu.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlActivitiesMain.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlPartnerComp.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlCompIntern.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlActiveStud.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudent.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.Transparent
        pnlSidebar.Controls.Add(pnlBottomMenu)
        pnlSidebar.Controls.Add(btnEvaluationLog)
        pnlSidebar.Controls.Add(btnInternships)
        pnlSidebar.Controls.Add(btnStudent)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(PictureBoxLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 858)
        pnlSidebar.TabIndex = 1
        ' 
        ' pnlBottomMenu
        ' 
        pnlBottomMenu.Controls.Add(btnLogout)
        pnlBottomMenu.Controls.Add(btnFaculty)
        pnlBottomMenu.Dock = DockStyle.Bottom
        pnlBottomMenu.Location = New Point(0, 719)
        pnlBottomMenu.Name = "pnlBottomMenu"
        pnlBottomMenu.Size = New Size(230, 139)
        pnlBottomMenu.TabIndex = 5
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
        btnFaculty.Text = "Faculty"
        btnFaculty.TextAlign = ContentAlignment.MiddleRight
        btnFaculty.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFaculty.UseVisualStyleBackColor = False
        ' 
        ' btnEvaluationLog
        ' 
        btnEvaluationLog.BackColor = Color.Transparent
        btnEvaluationLog.BackgroundImageLayout = ImageLayout.None
        btnEvaluationLog.FlatAppearance.BorderSize = 0
        btnEvaluationLog.FlatStyle = FlatStyle.Flat
        btnEvaluationLog.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluationLog.ForeColor = Color.White
        btnEvaluationLog.Image = My.Resources.Resources.Task
        btnEvaluationLog.Location = New Point(12, 369)
        btnEvaluationLog.Name = "btnEvaluationLog"
        btnEvaluationLog.Padding = New Padding(10, 0, 0, 0)
        btnEvaluationLog.Size = New Size(205, 65)
        btnEvaluationLog.TabIndex = 4
        btnEvaluationLog.Text = "  Evaluation Log"
        btnEvaluationLog.TextAlign = ContentAlignment.MiddleRight
        btnEvaluationLog.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEvaluationLog.UseVisualStyleBackColor = False
        ' 
        ' btnInternships
        ' 
        btnInternships.BackColor = Color.Transparent
        btnInternships.BackgroundImageLayout = ImageLayout.None
        btnInternships.FlatAppearance.BorderSize = 0
        btnInternships.FlatStyle = FlatStyle.Flat
        btnInternships.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInternships.ForeColor = Color.White
        btnInternships.Image = My.Resources.Resources.Job_Seeker
        btnInternships.Location = New Point(12, 298)
        btnInternships.Name = "btnInternships"
        btnInternships.Padding = New Padding(10, 0, 0, 0)
        btnInternships.Size = New Size(205, 65)
        btnInternships.TabIndex = 3
        btnInternships.Text = " Internships"
        btnInternships.TextAlign = ContentAlignment.MiddleRight
        btnInternships.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInternships.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.Transparent
        btnStudent.BackgroundImageLayout = ImageLayout.None
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.White
        btnStudent.Image = My.Resources.Resources.Graduation_Cap
        btnStudent.Location = New Point(12, 227)
        btnStudent.Name = "btnStudent"
        btnStudent.Padding = New Padding(10, 0, 0, 0)
        btnStudent.Size = New Size(205, 65)
        btnStudent.TabIndex = 2
        btnStudent.Text = "      Student"
        btnStudent.TextAlign = ContentAlignment.MiddleRight
        btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.BackgroundImageLayout = ImageLayout.None
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Image = My.Resources.Resources.Home
        btnDashboard.Location = New Point(12, 156)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 0, 0)
        btnDashboard.Size = New Size(205, 65)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = " Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleRight
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = False
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
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlActivitiesMain)
        pnlMain.Controls.Add(pnlPartnerComp)
        pnlMain.Controls.Add(pnlCompIntern)
        pnlMain.Controls.Add(pnlActiveStud)
        pnlMain.Controls.Add(pnlStudent)
        pnlMain.Controls.Add(Label1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(230, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1192, 858)
        pnlMain.TabIndex = 2
        ' 
        ' pnlActivitiesMain
        ' 
        pnlActivitiesMain.Controls.Add(btnAddFile)
        pnlActivitiesMain.Controls.Add(dgvStudents)
        pnlActivitiesMain.Location = New Point(98, 117)
        pnlActivitiesMain.Name = "pnlActivitiesMain"
        pnlActivitiesMain.Size = New Size(1052, 457)
        pnlActivitiesMain.TabIndex = 5
        ' 
        ' btnAddFile
        ' 
        btnAddFile.Location = New Point(935, 10)
        btnAddFile.Name = "btnAddFile"
        btnAddFile.Size = New Size(94, 29)
        btnAddFile.TabIndex = 7
        btnAddFile.Text = "Add File"
        btnAddFile.UseVisualStyleBackColor = True
        ' 
        ' dgvStudents
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle1.ForeColor = Color.Black
        dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(26), CByte(79), CByte(93))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {Student_ID, Student_Name, Program, Department, Company, Status, Supervisor, Rating})
        dgvStudents.CornerRadius = 20
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.Padding = New Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(183), CByte(192), CByte(217))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle3
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.Gray
        dgvStudents.Location = New Point(28, 53)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(1001, 395)
        dgvStudents.TabIndex = 0
        ' 
        ' Student_ID
        ' 
        Student_ID.HeaderText = "Student ID"
        Student_ID.MinimumWidth = 6
        Student_ID.Name = "Student_ID"
        Student_ID.Width = 125
        ' 
        ' Student_Name
        ' 
        Student_Name.HeaderText = "Full Name"
        Student_Name.MinimumWidth = 6
        Student_Name.Name = "Student_Name"
        Student_Name.Width = 125
        ' 
        ' Program
        ' 
        Program.HeaderText = "Course"
        Program.MinimumWidth = 6
        Program.Name = "Program"
        Program.Width = 125
        ' 
        ' Department
        ' 
        Department.HeaderText = "Department"
        Department.MinimumWidth = 6
        Department.Name = "Department"
        Department.Width = 125
        ' 
        ' Company
        ' 
        Company.HeaderText = "Company"
        Company.MinimumWidth = 6
        Company.Name = "Company"
        Company.Width = 125
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Width = 125
        ' 
        ' Supervisor
        ' 
        Supervisor.HeaderText = "Supervisor"
        Supervisor.MinimumWidth = 6
        Supervisor.Name = "Supervisor"
        Supervisor.Width = 125
        ' 
        ' Rating
        ' 
        Rating.HeaderText = "Rating"
        Rating.MinimumWidth = 6
        Rating.Name = "Rating"
        Rating.Width = 125
        ' 
        ' pnlPartnerComp
        ' 
        pnlPartnerComp.Controls.Add(lblPartnerCompCount)
        pnlPartnerComp.Controls.Add(PictureBox4)
        pnlPartnerComp.Controls.Add(lblPartnerComp)
        pnlPartnerComp.Location = New Point(882, 156)
        pnlPartnerComp.Name = "pnlPartnerComp"
        pnlPartnerComp.Size = New Size(0, 0)
        pnlPartnerComp.TabIndex = 4
        ' 
        ' lblPartnerCompCount
        ' 
        lblPartnerCompCount.AutoSize = True
        lblPartnerCompCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPartnerCompCount.Location = New Point(161, 37)
        lblPartnerCompCount.Name = "lblPartnerCompCount"
        lblPartnerCompCount.Size = New Size(35, 41)
        lblPartnerCompCount.TabIndex = 11
        lblPartnerCompCount.Text = "0"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.Location = New Point(30, 40)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(41, 38)
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' lblPartnerComp
        ' 
        lblPartnerComp.AutoSize = True
        lblPartnerComp.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPartnerComp.Location = New Point(30, 14)
        lblPartnerComp.Name = "lblPartnerComp"
        lblPartnerComp.Size = New Size(162, 23)
        lblPartnerComp.TabIndex = 9
        lblPartnerComp.Text = "Partner Companies"
        ' 
        ' pnlCompIntern
        ' 
        pnlCompIntern.Controls.Add(Label2)
        pnlCompIntern.Controls.Add(PictureBox3)
        pnlCompIntern.Controls.Add(lblCompIntern)
        pnlCompIntern.Location = New Point(625, 156)
        pnlCompIntern.Name = "pnlCompIntern"
        pnlCompIntern.Size = New Size(0, 0)
        pnlCompIntern.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(152, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 41)
        Label2.TabIndex = 8
        Label2.Text = "0"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.Location = New Point(21, 40)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(41, 38)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' lblCompIntern
        ' 
        lblCompIntern.AutoSize = True
        lblCompIntern.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompIntern.Location = New Point(21, 14)
        lblCompIntern.Name = "lblCompIntern"
        lblCompIntern.Size = New Size(192, 23)
        lblCompIntern.TabIndex = 6
        lblCompIntern.Text = "Completed Internships"
        ' 
        ' pnlActiveStud
        ' 
        pnlActiveStud.Controls.Add(lblActStudCount)
        pnlActiveStud.Controls.Add(PictureBox2)
        pnlActiveStud.Controls.Add(lblActiveStud)
        pnlActiveStud.Location = New Point(362, 156)
        pnlActiveStud.Name = "pnlActiveStud"
        pnlActiveStud.Size = New Size(0, 0)
        pnlActiveStud.TabIndex = 2
        ' 
        ' lblActStudCount
        ' 
        lblActStudCount.AutoSize = True
        lblActStudCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActStudCount.Location = New Point(163, 37)
        lblActStudCount.Name = "lblActStudCount"
        lblActStudCount.Size = New Size(35, 41)
        lblActStudCount.TabIndex = 5
        lblActStudCount.Text = "0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(32, 40)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 38)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' lblActiveStud
        ' 
        lblActiveStud.AutoSize = True
        lblActiveStud.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActiveStud.Location = New Point(32, 14)
        lblActiveStud.Name = "lblActiveStud"
        lblActiveStud.Size = New Size(125, 23)
        lblActiveStud.TabIndex = 3
        lblActiveStud.Text = "Total Students"
        ' 
        ' pnlStudent
        ' 
        pnlStudent.BackColor = SystemColors.ButtonShadow
        pnlStudent.Controls.Add(lblStudCount)
        pnlStudent.Controls.Add(PictureBox1)
        pnlStudent.Controls.Add(lblTotalStudentsTitle)
        pnlStudent.Location = New Point(98, 156)
        pnlStudent.Name = "pnlStudent"
        pnlStudent.Size = New Size(0, 0)
        pnlStudent.TabIndex = 1
        ' 
        ' lblStudCount
        ' 
        lblStudCount.AutoSize = True
        lblStudCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudCount.Location = New Point(159, 37)
        lblStudCount.Name = "lblStudCount"
        lblStudCount.Size = New Size(35, 41)
        lblStudCount.TabIndex = 2
        lblStudCount.Text = "0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Education1
        PictureBox1.Location = New Point(28, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 38)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblTotalStudentsTitle
        ' 
        lblTotalStudentsTitle.AutoSize = True
        lblTotalStudentsTitle.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalStudentsTitle.Location = New Point(28, 14)
        lblTotalStudentsTitle.Name = "lblTotalStudentsTitle"
        lblTotalStudentsTitle.Size = New Size(125, 23)
        lblTotalStudentsTitle.TabIndex = 0
        lblTotalStudentsTitle.Text = "Total Students"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(98, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 50)
        Label1.TabIndex = 0
        Label1.Text = "Student Table"
        ' 
        ' StudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "StudentForm"
        Text = "Pasig Institute of Technology"
        pnlSidebar.ResumeLayout(False)
        pnlBottomMenu.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlActivitiesMain.ResumeLayout(False)
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlPartnerComp.ResumeLayout(False)
        pnlPartnerComp.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlCompIntern.ResumeLayout(False)
        pnlCompIntern.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlActiveStud.ResumeLayout(False)
        pnlActiveStud.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlStudent.ResumeLayout(False)
        pnlStudent.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlBottomMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnEvaluationLog As Button
    Friend WithEvents btnInternships As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlActivitiesMain As Panel
    Friend WithEvents pnlPartnerComp As Panel
    Friend WithEvents lblPartnerCompCount As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblPartnerComp As Label
    Friend WithEvents pnlCompIntern As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCompIntern As Label
    Friend WithEvents pnlActiveStud As Panel
    Friend WithEvents lblActStudCount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblActiveStud As Label
    Friend WithEvents pnlStudent As Panel
    Friend WithEvents lblStudCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Student_ID As DataGridViewTextBoxColumn
    Friend WithEvents Student_Name As DataGridViewTextBoxColumn
    Friend WithEvents Program As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Company As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Supervisor As DataGridViewTextBoxColumn
    Friend WithEvents Rating As DataGridViewTextBoxColumn
    Friend WithEvents dgvStudents As RoundedPanel
    Friend WithEvents btnAddFile As Button
End Class
