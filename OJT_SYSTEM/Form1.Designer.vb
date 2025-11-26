<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
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
        Label8 = New Label()
        pnlPending = New Panel()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label6 = New Label()
        pnlEvalSched = New Panel()
        Label18 = New Label()
        Label19 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        lblPartnerCompNew = New Label()
        notifComp = New Label()
        pnlPcomp = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label7 = New Label()
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pnlSidebar.SuspendLayout()
        pnlBottomMenu.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlActivitiesMain.SuspendLayout()
        pnlPending.SuspendLayout()
        pnlEvalSched.SuspendLayout()
        Panel1.SuspendLayout()
        pnlPcomp.SuspendLayout()
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
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlBottomMenu
        ' 
        pnlBottomMenu.Controls.Add(btnLogout)
        pnlBottomMenu.Controls.Add(btnFaculty)
        pnlBottomMenu.Dock = DockStyle.Bottom
        pnlBottomMenu.Location = New Point(0, 670)
        pnlBottomMenu.Name = "pnlBottomMenu"
        pnlBottomMenu.Size = New Size(230, 188)
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
        btnLogout.Location = New Point(42, 106)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(150, 64)
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
        btnFaculty.Location = New Point(42, 36)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.Padding = New Padding(20, 0, 0, 0)
        btnFaculty.RightToLeft = RightToLeft.No
        btnFaculty.Size = New Size(150, 64)
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
        pnlMain.TabIndex = 1
        ' 
        ' pnlActivitiesMain
        ' 
        pnlActivitiesMain.Controls.Add(Label8)
        pnlActivitiesMain.Controls.Add(pnlPending)
        pnlActivitiesMain.Controls.Add(pnlEvalSched)
        pnlActivitiesMain.Controls.Add(Panel1)
        pnlActivitiesMain.Controls.Add(pnlPcomp)
        pnlActivitiesMain.Location = New Point(98, 264)
        pnlActivitiesMain.Name = "pnlActivitiesMain"
        pnlActivitiesMain.Size = New Size(1014, 524)
        pnlActivitiesMain.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(28, 34)
        Label8.Name = "Label8"
        Label8.Size = New Size(243, 25)
        Label8.TabIndex = 4
        Label8.Text = "Activities and Notifications"
        ' 
        ' pnlPending
        ' 
        pnlPending.BackColor = Color.White
        pnlPending.Controls.Add(Label21)
        pnlPending.Controls.Add(Label22)
        pnlPending.Controls.Add(Label23)
        pnlPending.Controls.Add(Label24)
        pnlPending.Controls.Add(Label6)
        pnlPending.Location = New Point(28, 298)
        pnlPending.Name = "pnlPending"
        pnlPending.Size = New Size(383, 195)
        pnlPending.TabIndex = 3
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(24, 97)
        Label21.Name = "Label21"
        Label21.Size = New Size(17, 23)
        Label21.TabIndex = 11
        Label21.Text = "•"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(47, 97)
        Label22.Name = "Label22"
        Label22.Size = New Size(93, 23)
        Label22.TabIndex = 10
        Label22.Text = "Evaluation"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(24, 61)
        Label23.Name = "Label23"
        Label23.Size = New Size(17, 23)
        Label23.TabIndex = 9
        Label23.Text = "•"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(47, 61)
        Label24.Name = "Label24"
        Label24.Size = New Size(100, 23)
        Label24.TabIndex = 8
        Label24.Text = "Evaluations"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 23)
        Label6.TabIndex = 2
        Label6.Text = "Pending Evaluations"
        ' 
        ' pnlEvalSched
        ' 
        pnlEvalSched.BackColor = Color.White
        pnlEvalSched.Controls.Add(Label18)
        pnlEvalSched.Controls.Add(Label19)
        pnlEvalSched.Controls.Add(Label16)
        pnlEvalSched.Controls.Add(Label17)
        pnlEvalSched.Controls.Add(Label15)
        pnlEvalSched.Controls.Add(Label14)
        pnlEvalSched.Controls.Add(Label3)
        pnlEvalSched.Location = New Point(564, 80)
        pnlEvalSched.Name = "pnlEvalSched"
        pnlEvalSched.Size = New Size(383, 195)
        pnlEvalSched.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(24, 140)
        Label18.Name = "Label18"
        Label18.Size = New Size(53, 23)
        Label18.TabIndex = 8
        Label18.Text = "Date:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(97, 140)
        Label19.Name = "Label19"
        Label19.Size = New Size(83, 23)
        Label19.TabIndex = 7
        Label19.Text = "New Eval"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(24, 103)
        Label16.Name = "Label16"
        Label16.Size = New Size(53, 23)
        Label16.TabIndex = 6
        Label16.Text = "Date:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(97, 103)
        Label17.Name = "Label17"
        Label17.Size = New Size(83, 23)
        Label17.TabIndex = 5
        Label17.Text = "New Eval"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(24, 67)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 23)
        Label15.TabIndex = 4
        Label15.Text = "Date:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(97, 67)
        Label14.Name = "Label14"
        Label14.Size = New Size(83, 23)
        Label14.TabIndex = 3
        Label14.Text = "New Eval"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 23)
        Label3.TabIndex = 1
        Label3.Text = "Evaluation Schedule"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(lblPartnerCompNew)
        Panel1.Controls.Add(notifComp)
        Panel1.Location = New Point(564, 298)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(383, 195)
        Panel1.TabIndex = 1
        ' 
        ' lblPartnerCompNew
        ' 
        lblPartnerCompNew.AutoSize = True
        lblPartnerCompNew.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPartnerCompNew.Location = New Point(24, 61)
        lblPartnerCompNew.Name = "lblPartnerCompNew"
        lblPartnerCompNew.Size = New Size(203, 23)
        lblPartnerCompNew.TabIndex = 2
        lblPartnerCompNew.Text = "New Partner Companies"
        ' 
        ' notifComp
        ' 
        notifComp.AutoSize = True
        notifComp.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        notifComp.Location = New Point(24, 23)
        notifComp.Name = "notifComp"
        notifComp.Size = New Size(203, 23)
        notifComp.TabIndex = 1
        notifComp.Text = "New Partner Companies"
        ' 
        ' pnlPcomp
        ' 
        pnlPcomp.BackColor = Color.White
        pnlPcomp.Controls.Add(Label12)
        pnlPcomp.Controls.Add(Label13)
        pnlPcomp.Controls.Add(Label10)
        pnlPcomp.Controls.Add(Label11)
        pnlPcomp.Controls.Add(Label9)
        pnlPcomp.Controls.Add(Label4)
        pnlPcomp.Controls.Add(Label7)
        pnlPcomp.Location = New Point(28, 80)
        pnlPcomp.Name = "pnlPcomp"
        pnlPcomp.Size = New Size(383, 195)
        pnlPcomp.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(24, 140)
        Label12.Name = "Label12"
        Label12.Size = New Size(17, 23)
        Label12.TabIndex = 7
        Label12.Text = "•"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(47, 140)
        Label13.Name = "Label13"
        Label13.Size = New Size(203, 23)
        Label13.TabIndex = 6
        Label13.Text = "New Partner Companies"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(24, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(17, 23)
        Label10.TabIndex = 5
        Label10.Text = "•"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(47, 103)
        Label11.Name = "Label11"
        Label11.Size = New Size(203, 23)
        Label11.TabIndex = 4
        Label11.Text = "New Partner Companies"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(24, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(17, 23)
        Label9.TabIndex = 3
        Label9.Text = "•"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(47, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 23)
        Label4.TabIndex = 2
        Label4.Text = "New Partner Companies"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(203, 23)
        Label7.TabIndex = 1
        Label7.Text = "New Partner Companies"
        ' 
        ' pnlPartnerComp
        ' 
        pnlPartnerComp.Controls.Add(lblPartnerCompCount)
        pnlPartnerComp.Controls.Add(PictureBox4)
        pnlPartnerComp.Controls.Add(lblPartnerComp)
        pnlPartnerComp.Location = New Point(882, 142)
        pnlPartnerComp.Name = "pnlPartnerComp"
        pnlPartnerComp.Size = New Size(230, 92)
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
        pnlCompIntern.Location = New Point(624, 142)
        pnlCompIntern.Name = "pnlCompIntern"
        pnlCompIntern.Size = New Size(230, 92)
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
        pnlActiveStud.Location = New Point(363, 142)
        pnlActiveStud.Name = "pnlActiveStud"
        pnlActiveStud.Size = New Size(230, 92)
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
        lblActiveStud.Size = New Size(136, 23)
        lblActiveStud.TabIndex = 3
        lblActiveStud.Text = "Active Students"
        ' 
        ' pnlStudent
        ' 
        pnlStudent.BackColor = SystemColors.ButtonShadow
        pnlStudent.Controls.Add(lblStudCount)
        pnlStudent.Controls.Add(PictureBox1)
        pnlStudent.Controls.Add(lblTotalStudentsTitle)
        pnlStudent.Location = New Point(98, 142)
        pnlStudent.Name = "pnlStudent"
        pnlStudent.Size = New Size(230, 92)
        pnlStudent.TabIndex = 1
        ' 
        ' lblStudCount
        ' 
        lblStudCount.AutoSize = True
        lblStudCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudCount.ForeColor = Color.Black
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
        Label1.Size = New Size(296, 50)
        Label1.TabIndex = 0
        Label1.Text = "Summary Cards"
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "DashboardForm"
        Text = "Pasig Institute of Technology"
        pnlSidebar.ResumeLayout(False)
        pnlBottomMenu.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlActivitiesMain.ResumeLayout(False)
        pnlActivitiesMain.PerformLayout()
        pnlPending.ResumeLayout(False)
        pnlPending.PerformLayout()
        pnlEvalSched.ResumeLayout(False)
        pnlEvalSched.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlPcomp.ResumeLayout(False)
        pnlPcomp.PerformLayout()
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
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnInternships As Button
    Friend WithEvents btnEvaluationLog As Button
    Friend WithEvents pnlBottomMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlStudent As Panel
    Friend WithEvents pnlPartnerComp As Panel
    Friend WithEvents pnlCompIntern As Panel
    Friend WithEvents pnlActiveStud As Panel
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblStudCount As Label
    Friend WithEvents lblActStudCount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblActiveStud As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCompIntern As Label
    Friend WithEvents lblPartnerCompCount As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblPartnerComp As Label
    Friend WithEvents pnlActivitiesMain As Panel
    Friend WithEvents pnlPcomp As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents notifComp As Label
    Friend WithEvents pnlPending As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlEvalSched As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPartnerCompNew As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label

End Class
