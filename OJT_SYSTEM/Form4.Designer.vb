<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvaluationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EvaluationForm))
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
        pnlEval = New Panel()
        pnlRating = New Panel()
        Label18 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label17 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        Label2 = New Label()
        pnlStudInfo = New Panel()
        lblStatus = New Label()
        Label8 = New Label()
        lblComp = New Label()
        Label16 = New Label()
        lblSupervisor = New Label()
        Label12 = New Label()
        lblCourse = New Label()
        Label6 = New Label()
        lblStudName = New Label()
        Label5 = New Label()
        lblStudID = New Label()
        Label4 = New Label()
        Label3 = New Label()
        pnlsearch = New Panel()
        btnSearch = New Button()
        Label7 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        pnlActiveStud = New Panel()
        lblActStudCount = New Label()
        PictureBox2 = New PictureBox()
        lblActiveStud = New Label()
        Label1 = New Label()
        pnlSidebar.SuspendLayout()
        pnlBottomMenu.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlEval.SuspendLayout()
        pnlRating.SuspendLayout()
        pnlStudInfo.SuspendLayout()
        pnlsearch.SuspendLayout()
        pnlActiveStud.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlSidebar.TabIndex = 3
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
        pnlMain.Controls.Add(pnlEval)
        pnlMain.Controls.Add(pnlStudInfo)
        pnlMain.Controls.Add(pnlsearch)
        pnlMain.Controls.Add(Label1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(230, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1192, 858)
        pnlMain.TabIndex = 4
        ' 
        ' pnlEval
        ' 
        pnlEval.Controls.Add(pnlRating)
        pnlEval.Controls.Add(Button2)
        pnlEval.Controls.Add(Button1)
        pnlEval.Controls.Add(TextBox1)
        pnlEval.Controls.Add(Label17)
        pnlEval.Controls.Add(DateTimePicker1)
        pnlEval.Controls.Add(ComboBox5)
        pnlEval.Controls.Add(ComboBox4)
        pnlEval.Controls.Add(ComboBox3)
        pnlEval.Controls.Add(ComboBox2)
        pnlEval.Controls.Add(Label15)
        pnlEval.Controls.Add(Label14)
        pnlEval.Controls.Add(Label13)
        pnlEval.Controls.Add(Label11)
        pnlEval.Controls.Add(ComboBox1)
        pnlEval.Controls.Add(Label10)
        pnlEval.Controls.Add(Label9)
        pnlEval.Controls.Add(Label2)
        pnlEval.Location = New Point(424, 198)
        pnlEval.Name = "pnlEval"
        pnlEval.Size = New Size(722, 367)
        pnlEval.TabIndex = 13
        ' 
        ' pnlRating
        ' 
        pnlRating.Controls.Add(Label18)
        pnlRating.Location = New Point(444, 143)
        pnlRating.Name = "pnlRating"
        pnlRating.Size = New Size(236, 146)
        pnlRating.TabIndex = 18
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(11, 12)
        Label18.Name = "Label18"
        Label18.Size = New Size(106, 20)
        Label18.TabIndex = 15
        Label18.Text = "Overall Rating:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.Location = New Point(577, 307)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 35)
        Button2.TabIndex = 17
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(455, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 35)
        Button1.TabIndex = 16
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(551, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(129, 27)
        TextBox1.TabIndex = 15
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(455, 78)
        Label17.Name = "Label17"
        Label17.Size = New Size(77, 20)
        Label17.TabIndex = 14
        Label17.Text = "Comment:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(238, 121)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(152, 27)
        DateTimePicker1.TabIndex = 13
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(238, 314)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(152, 28)
        ComboBox5.TabIndex = 12
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(238, 266)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(152, 28)
        ComboBox4.TabIndex = 11
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(238, 219)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(152, 28)
        ComboBox3.TabIndex = 10
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(238, 171)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(152, 28)
        ComboBox2.TabIndex = 9
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(47, 317)
        Label15.Name = "Label15"
        Label15.Size = New Size(117, 20)
        Label15.TabIndex = 8
        Label15.Text = "Communication:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(47, 269)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 20)
        Label14.TabIndex = 7
        Label14.Text = "Skills:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(47, 222)
        Label13.Name = "Label13"
        Label13.Size = New Size(115, 20)
        Label13.TabIndex = 6
        Label13.Text = "Professionalism:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(47, 174)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 20)
        Label11.TabIndex = 5
        Label11.Text = "Punctuality:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(238, 75)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(152, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(47, 80)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 20)
        Label10.TabIndex = 3
        Label10.Text = "Evaluator:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(47, 126)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 20)
        Label9.TabIndex = 2
        Label9.Text = "Date of Visit:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 31)
        Label2.TabIndex = 1
        Label2.Text = "Evaluation:"
        ' 
        ' pnlStudInfo
        ' 
        pnlStudInfo.Controls.Add(lblStatus)
        pnlStudInfo.Controls.Add(Label8)
        pnlStudInfo.Controls.Add(lblComp)
        pnlStudInfo.Controls.Add(Label16)
        pnlStudInfo.Controls.Add(lblSupervisor)
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
        pnlStudInfo.Size = New Size(348, 367)
        pnlStudInfo.TabIndex = 12
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(186, 317)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 24
        lblStatus.Text = "Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(29, 317)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 20)
        Label8.TabIndex = 23
        Label8.Text = "Status:"
        ' 
        ' lblComp
        ' 
        lblComp.AutoSize = True
        lblComp.Location = New Point(185, 222)
        lblComp.Name = "lblComp"
        lblComp.Size = New Size(72, 20)
        lblComp.TabIndex = 22
        lblComp.Text = "Company"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(28, 222)
        Label16.Name = "Label16"
        Label16.Size = New Size(75, 20)
        Label16.TabIndex = 21
        Label16.Text = "Comapny:"
        ' 
        ' lblSupervisor
        ' 
        lblSupervisor.AutoSize = True
        lblSupervisor.Location = New Point(185, 269)
        lblSupervisor.Name = "lblSupervisor"
        lblSupervisor.Size = New Size(78, 20)
        lblSupervisor.TabIndex = 14
        lblSupervisor.Text = "Supervisor"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(28, 269)
        Label12.Name = "Label12"
        Label12.Size = New Size(81, 20)
        Label12.TabIndex = 13
        Label12.Text = "Supervisor:"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(185, 174)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(57, 20)
        lblCourse.TabIndex = 6
        lblCourse.Text = "Course:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(28, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 5
        Label6.Text = "Course:"
        ' 
        ' lblStudName
        ' 
        lblStudName.AutoSize = True
        lblStudName.Location = New Point(185, 126)
        lblStudName.Name = "lblStudName"
        lblStudName.Size = New Size(104, 20)
        lblStudName.TabIndex = 4
        lblStudName.Text = "Student Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 20)
        Label5.TabIndex = 3
        Label5.Text = "Student Name:"
        ' 
        ' lblStudID
        ' 
        lblStudID.AutoSize = True
        lblStudID.Location = New Point(185, 78)
        lblStudID.Name = "lblStudID"
        lblStudID.Size = New Size(79, 20)
        lblStudID.TabIndex = 2
        lblStudID.Text = "Student ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 1
        Label4.Text = "Student ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(257, 31)
        Label3.TabIndex = 0
        Label3.Text = "Student Summary Info"
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
        pnlsearch.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(351, 7)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(68, 27)
        btnSearch.TabIndex = 11
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label1.Location = New Point(98, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 50)
        Label1.TabIndex = 6
        Label1.Text = "Evaluation Log"
        ' 
        ' EvaluationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EvaluationForm"
        Text = "Pasig Institute of Technology"
        pnlSidebar.ResumeLayout(False)
        pnlBottomMenu.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlEval.ResumeLayout(False)
        pnlEval.PerformLayout()
        pnlRating.ResumeLayout(False)
        pnlRating.PerformLayout()
        pnlStudInfo.ResumeLayout(False)
        pnlStudInfo.PerformLayout()
        pnlsearch.ResumeLayout(False)
        pnlsearch.PerformLayout()
        pnlActiveStud.ResumeLayout(False)
        pnlActiveStud.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlsearch As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents pnlActiveStud As Panel
    Friend WithEvents lblActStudCount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblActiveStud As Label
    Friend WithEvents pnlStudInfo As Panel
    Friend WithEvents lblComp As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStudName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStudID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlEval As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlRating As Panel
    Private WithEvents Label18 As Label
End Class
