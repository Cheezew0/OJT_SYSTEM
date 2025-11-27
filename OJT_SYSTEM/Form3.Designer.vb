<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InternForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InternForm))
        pnlSidebar = New Panel()
        pnlBottomMenu = New Panel()
        btnLogout = New Button()
        btnFaculty = New Button()
        btnEvaluationLog = New Button()
        btnInternships = New Button()
        btnStudent = New Button()
        btnDashboard = New Button()
        PictureBoxLogo = New PictureBox()
        pnlStudent = New Panel()
        lblStudCount = New Label()
        PictureBox1 = New PictureBox()
        lblTotalStudentsTitle = New Label()
        pnlActiveStud = New Panel()
        lblActStudCount = New Label()
        PictureBox2 = New PictureBox()
        lblActiveStud = New Label()
        pnlCompIntern = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        lblCompIntern = New Label()
        pnlPartnerComp = New Panel()
        lblPartnerCompCount = New Label()
        PictureBox4 = New PictureBox()
        lblPartnerComp = New Label()
        Label1 = New Label()
        pnlMain = New Panel()
        pnlProgress = New Panel()
        Label13 = New Label()
        lblEndDate = New Label()
        Label19 = New Label()
        Label20 = New Label()
        lblStartdate = New Label()
        Label22 = New Label()
        lblReqHrs = New Label()
        Panel3 = New Panel()
        Label24 = New Label()
        PictureBox5 = New PictureBox()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        pnlInternInfo = New Panel()
        Label25 = New Label()
        lblAddress = New Label()
        Label14 = New Label()
        lblStatus = New Label()
        Label8 = New Label()
        Label10 = New Label()
        lblCompany = New Label()
        lblSupervisor = New Label()
        Label9 = New Label()
        pnlsearch = New Panel()
        btnSearch = New Button()
        Label7 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        pnlStudInfo = New Panel()
        lblEmail = New Label()
        Label16 = New Label()
        lblDepartment = New Label()
        Label12 = New Label()
        lblCourse = New Label()
        Label6 = New Label()
        lblStudName = New Label()
        Label5 = New Label()
        lblStudID = New Label()
        Label4 = New Label()
        Label3 = New Label()
        pnlSidebar.SuspendLayout()
        pnlBottomMenu.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudent.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlActiveStud.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlCompIntern.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlPartnerComp.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlProgress.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        pnlInternInfo.SuspendLayout()
        pnlsearch.SuspendLayout()
        pnlStudInfo.SuspendLayout()
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
        pnlSidebar.TabIndex = 2
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
        ' pnlActiveStud
        ' 
        pnlActiveStud.Controls.Add(lblActStudCount)
        pnlActiveStud.Controls.Add(PictureBox2)
        pnlActiveStud.Controls.Add(lblActiveStud)
        pnlActiveStud.Location = New Point(262, 18)
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
        ' pnlPartnerComp
        ' 
        pnlPartnerComp.Controls.Add(lblPartnerCompCount)
        pnlPartnerComp.Controls.Add(PictureBox4)
        pnlPartnerComp.Controls.Add(lblPartnerComp)
        pnlPartnerComp.Location = New Point(206, 204)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label1.Location = New Point(98, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 50)
        Label1.TabIndex = 6
        Label1.Text = "Internship"
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlProgress)
        pnlMain.Controls.Add(pnlInternInfo)
        pnlMain.Controls.Add(pnlsearch)
        pnlMain.Controls.Add(pnlStudInfo)
        pnlMain.Controls.Add(Label1)
        pnlMain.Controls.Add(pnlCompIntern)
        pnlMain.Controls.Add(pnlStudent)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(230, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1192, 858)
        pnlMain.TabIndex = 3
        ' 
        ' pnlProgress
        ' 
        pnlProgress.Controls.Add(Label13)
        pnlProgress.Controls.Add(lblEndDate)
        pnlProgress.Controls.Add(Label19)
        pnlProgress.Controls.Add(Label20)
        pnlProgress.Controls.Add(lblStartdate)
        pnlProgress.Controls.Add(Label22)
        pnlProgress.Controls.Add(lblReqHrs)
        pnlProgress.Controls.Add(Panel3)
        pnlProgress.Controls.Add(Label27)
        pnlProgress.Controls.Add(Label28)
        pnlProgress.Location = New Point(669, 198)
        pnlProgress.Name = "pnlProgress"
        pnlProgress.Size = New Size(483, 276)
        pnlProgress.TabIndex = 26
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(33, 31)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 31)
        Label13.TabIndex = 0
        Label13.Text = "Progress"
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Location = New Point(328, 221)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(70, 20)
        lblEndDate.TabIndex = 10
        lblEndDate.Text = "End Date"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label19.Location = New Point(33, 221)
        Label19.Name = "Label19"
        Label19.Size = New Size(75, 20)
        Label19.TabIndex = 9
        Label19.Text = "End Date:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label20.Location = New Point(33, 128)
        Label20.Name = "Label20"
        Label20.Size = New Size(120, 20)
        Label20.TabIndex = 11
        Label20.Text = "Required Hours:"
        ' 
        ' lblStartdate
        ' 
        lblStartdate.AutoSize = True
        lblStartdate.Location = New Point(328, 176)
        lblStartdate.Name = "lblStartdate"
        lblStartdate.Size = New Size(97, 20)
        lblStartdate.TabIndex = 8
        lblStartdate.Text = "Starting Date"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(328, 80)
        Label22.Name = "Label22"
        Label22.Size = New Size(31, 20)
        Label22.TabIndex = 16
        Label22.Text = "0/0"
        ' 
        ' lblReqHrs
        ' 
        lblReqHrs.AutoSize = True
        lblReqHrs.Location = New Point(328, 128)
        lblReqHrs.Name = "lblReqHrs"
        lblReqHrs.Size = New Size(112, 20)
        lblReqHrs.TabIndex = 12
        lblReqHrs.Text = "Required Hours"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label24)
        Panel3.Controls.Add(PictureBox5)
        Panel3.Controls.Add(Label26)
        Panel3.Location = New Point(206, 204)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(0, 0)
        Panel3.TabIndex = 4
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(161, 37)
        Label24.Name = "Label24"
        Label24.Size = New Size(35, 41)
        Label24.TabIndex = 11
        Label24.Text = "0"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.Location = New Point(30, 40)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(41, 38)
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(30, 14)
        Label26.Name = "Label26"
        Label26.Size = New Size(162, 23)
        Label26.TabIndex = 9
        Label26.Text = "Partner Companies"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label27.Location = New Point(33, 176)
        Label27.Name = "Label27"
        Label27.Size = New Size(103, 20)
        Label27.TabIndex = 7
        Label27.Text = "Starting Date:"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label28.Location = New Point(33, 80)
        Label28.Name = "Label28"
        Label28.Size = New Size(140, 20)
        Label28.TabIndex = 15
        Label28.Text = "Hourse Completed:"
        ' 
        ' pnlInternInfo
        ' 
        pnlInternInfo.Controls.Add(Label25)
        pnlInternInfo.Controls.Add(lblAddress)
        pnlInternInfo.Controls.Add(Label14)
        pnlInternInfo.Controls.Add(lblStatus)
        pnlInternInfo.Controls.Add(Label8)
        pnlInternInfo.Controls.Add(Label10)
        pnlInternInfo.Controls.Add(lblCompany)
        pnlInternInfo.Controls.Add(lblSupervisor)
        pnlInternInfo.Controls.Add(pnlPartnerComp)
        pnlInternInfo.Controls.Add(Label9)
        pnlInternInfo.Location = New Point(46, 528)
        pnlInternInfo.Name = "pnlInternInfo"
        pnlInternInfo.Size = New Size(594, 279)
        pnlInternInfo.TabIndex = 25
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(33, 31)
        Label25.Name = "Label25"
        Label25.Size = New Size(266, 31)
        Label25.TabIndex = 0
        Label25.Text = "Internship Information:"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(370, 80)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(62, 20)
        lblAddress.TabIndex = 24
        lblAddress.Text = "Address"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label14.Location = New Point(33, 80)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 20)
        Label14.TabIndex = 23
        Label14.Text = "Address:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(370, 221)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.Location = New Point(33, 221)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 20)
        Label8.TabIndex = 9
        Label8.Text = "Status:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label10.Location = New Point(33, 128)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 11
        Label10.Text = "Supervisor:"
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Location = New Point(370, 176)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(70, 20)
        lblCompany.TabIndex = 8
        lblCompany.Text = "company"
        ' 
        ' lblSupervisor
        ' 
        lblSupervisor.AutoSize = True
        lblSupervisor.Location = New Point(370, 125)
        lblSupervisor.Name = "lblSupervisor"
        lblSupervisor.Size = New Size(81, 20)
        lblSupervisor.TabIndex = 12
        lblSupervisor.Text = "Supervisor:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.Location = New Point(33, 176)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 20)
        Label9.TabIndex = 7
        Label9.Text = "Company:"
        ' 
        ' pnlsearch
        ' 
        pnlsearch.Controls.Add(btnSearch)
        pnlsearch.Controls.Add(Label7)
        pnlsearch.Controls.Add(MaskedTextBox1)
        pnlsearch.Controls.Add(pnlActiveStud)
        pnlsearch.Location = New Point(46, 140)
        pnlsearch.Name = "pnlsearch"
        pnlsearch.Size = New Size(430, 37)
        pnlsearch.TabIndex = 10
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(351, 7)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(68, 27)
        btnSearch.TabIndex = 10
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 20)
        Label7.TabIndex = 9
        Label7.Text = "Search Student ID"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(231, 7)
        MaskedTextBox1.Mask = "00-00000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(114, 27)
        MaskedTextBox1.TabIndex = 8
        ' 
        ' pnlStudInfo
        ' 
        pnlStudInfo.Controls.Add(lblEmail)
        pnlStudInfo.Controls.Add(Label16)
        pnlStudInfo.Controls.Add(lblDepartment)
        pnlStudInfo.Controls.Add(Label12)
        pnlStudInfo.Controls.Add(lblCourse)
        pnlStudInfo.Controls.Add(Label6)
        pnlStudInfo.Controls.Add(lblStudName)
        pnlStudInfo.Controls.Add(Label5)
        pnlStudInfo.Controls.Add(lblStudID)
        pnlStudInfo.Controls.Add(Label4)
        pnlStudInfo.Controls.Add(Label3)
        pnlStudInfo.Location = New Point(46, 198)
        pnlStudInfo.Name = "pnlStudInfo"
        pnlStudInfo.Size = New Size(594, 319)
        pnlStudInfo.TabIndex = 7
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(370, 221)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 20)
        lblEmail.TabIndex = 22
        lblEmail.Text = "Email:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label16.Location = New Point(28, 221)
        Label16.Name = "Label16"
        Label16.Size = New Size(50, 20)
        Label16.TabIndex = 21
        Label16.Text = "Email:"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Location = New Point(370, 269)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(89, 20)
        lblDepartment.TabIndex = 14
        lblDepartment.Text = "Department"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label12.Location = New Point(28, 269)
        Label12.Name = "Label12"
        Label12.Size = New Size(91, 20)
        Label12.TabIndex = 13
        Label12.Text = "Department"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(370, 173)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(57, 20)
        lblCourse.TabIndex = 6
        lblCourse.Text = "Course:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.Location = New Point(28, 173)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 5
        Label6.Text = "Course:"
        ' 
        ' lblStudName
        ' 
        lblStudName.AutoSize = True
        lblStudName.Location = New Point(370, 125)
        lblStudName.Name = "lblStudName"
        lblStudName.Size = New Size(104, 20)
        lblStudName.TabIndex = 4
        lblStudName.Text = "Student Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.Location = New Point(28, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 20)
        Label5.TabIndex = 3
        Label5.Text = "Student Name:"
        ' 
        ' lblStudID
        ' 
        lblStudID.AutoSize = True
        lblStudID.Location = New Point(370, 78)
        lblStudID.Name = "lblStudID"
        lblStudID.Size = New Size(79, 20)
        lblStudID.TabIndex = 2
        lblStudID.Text = "Student ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(28, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 1
        Label4.Text = "Student ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(234, 31)
        Label3.TabIndex = 0
        Label3.Text = "Student Information"
        ' 
        ' InternForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "InternForm"
        Text = "Pasig Institute of Technology"
        pnlSidebar.ResumeLayout(False)
        pnlBottomMenu.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlStudent.ResumeLayout(False)
        pnlStudent.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlActiveStud.ResumeLayout(False)
        pnlActiveStud.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlCompIntern.ResumeLayout(False)
        pnlCompIntern.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlPartnerComp.ResumeLayout(False)
        pnlPartnerComp.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlProgress.ResumeLayout(False)
        pnlProgress.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        pnlInternInfo.ResumeLayout(False)
        pnlInternInfo.PerformLayout()
        pnlsearch.ResumeLayout(False)
        pnlsearch.PerformLayout()
        pnlStudInfo.ResumeLayout(False)
        pnlStudInfo.PerformLayout()
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
    Friend WithEvents pnlStudent As Panel
    Friend WithEvents lblStudCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents pnlActiveStud As Panel
    Friend WithEvents lblActStudCount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblActiveStud As Label
    Friend WithEvents pnlCompIntern As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCompIntern As Label
    Friend WithEvents pnlPartnerComp As Panel
    Friend WithEvents lblPartnerCompCount As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblPartnerComp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlStudInfo As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStudName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStudID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlsearch As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pnlInternInfo As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblStartdate As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblReqHrs As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnSearch As Button
    Friend Protected WithEvents pnlProgress As Panel
End Class
