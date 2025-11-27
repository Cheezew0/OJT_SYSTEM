<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyProfileForm))
        pnlSidebar = New Panel()
        pnlBottomMenu = New Panel()
        btnLogout = New Button()
        btnFaculty = New Button()
        btnInternship = New Button()
        btnProfile = New Button()
        PictureBoxLogo = New PictureBox()
        pnlMain = New Panel()
        Label1 = New Label()
        pnlPersonalInfo = New Panel()
        cmbProf = New ComboBox()
        cmbStatus = New ComboBox()
        txtEmailaddress = New TextBox()
        Label17 = New Label()
        btnCancel = New Button()
        cmbProgram = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label16 = New Label()
        cmbSection = New ComboBox()
        btnSave = New Button()
        txtContactNum = New TextBox()
        txtLName = New TextBox()
        txtMName = New TextBox()
        Label9 = New Label()
        Label12 = New Label()
        btnEditProf = New Button()
        Label11 = New Label()
        lbl = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label7 = New Label()
        txtAddr = New TextBox()
        cmbSex = New ComboBox()
        mtxtStudId = New MaskedTextBox()
        txtFname = New TextBox()
        Label4 = New Label()
        Label10 = New Label()
        Label2 = New Label()
        Label13 = New Label()
        Label3 = New Label()
        lblTotalStudentsTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlBottomMenu.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlPersonalInfo.SuspendLayout()
        SuspendLayout()
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
        pnlSidebar.TabIndex = 4
        ' 
        ' pnlBottomMenu
        ' 
        pnlBottomMenu.Controls.Add(btnLogout)
        pnlBottomMenu.Controls.Add(btnFaculty)
        pnlBottomMenu.Dock = DockStyle.Bottom
        pnlBottomMenu.Location = New Point(0, 708)
        pnlBottomMenu.Name = "pnlBottomMenu"
        pnlBottomMenu.Size = New Size(230, 150)
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
        btnFaculty.Text = "Student"
        btnFaculty.TextAlign = ContentAlignment.MiddleRight
        btnFaculty.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFaculty.UseVisualStyleBackColor = False
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
        ' pnlMain
        ' 
        pnlMain.Controls.Add(Label1)
        pnlMain.Controls.Add(pnlPersonalInfo)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(230, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1192, 858)
        pnlMain.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label1.Location = New Point(98, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 50)
        Label1.TabIndex = 6
        Label1.Text = "My Profile"
        ' 
        ' pnlPersonalInfo
        ' 
        pnlPersonalInfo.Controls.Add(cmbProf)
        pnlPersonalInfo.Controls.Add(cmbStatus)
        pnlPersonalInfo.Controls.Add(txtEmailaddress)
        pnlPersonalInfo.Controls.Add(Label17)
        pnlPersonalInfo.Controls.Add(btnCancel)
        pnlPersonalInfo.Controls.Add(cmbProgram)
        pnlPersonalInfo.Controls.Add(DateTimePicker1)
        pnlPersonalInfo.Controls.Add(Label16)
        pnlPersonalInfo.Controls.Add(cmbSection)
        pnlPersonalInfo.Controls.Add(btnSave)
        pnlPersonalInfo.Controls.Add(txtContactNum)
        pnlPersonalInfo.Controls.Add(txtLName)
        pnlPersonalInfo.Controls.Add(txtMName)
        pnlPersonalInfo.Controls.Add(Label9)
        pnlPersonalInfo.Controls.Add(Label12)
        pnlPersonalInfo.Controls.Add(btnEditProf)
        pnlPersonalInfo.Controls.Add(Label11)
        pnlPersonalInfo.Controls.Add(lbl)
        pnlPersonalInfo.Controls.Add(Label6)
        pnlPersonalInfo.Controls.Add(Label5)
        pnlPersonalInfo.Controls.Add(Label15)
        pnlPersonalInfo.Controls.Add(Label14)
        pnlPersonalInfo.Controls.Add(Label7)
        pnlPersonalInfo.Controls.Add(txtAddr)
        pnlPersonalInfo.Controls.Add(cmbSex)
        pnlPersonalInfo.Controls.Add(mtxtStudId)
        pnlPersonalInfo.Controls.Add(txtFname)
        pnlPersonalInfo.Controls.Add(Label4)
        pnlPersonalInfo.Controls.Add(Label10)
        pnlPersonalInfo.Controls.Add(Label2)
        pnlPersonalInfo.Controls.Add(Label13)
        pnlPersonalInfo.Controls.Add(Label3)
        pnlPersonalInfo.Controls.Add(lblTotalStudentsTitle)
        pnlPersonalInfo.Location = New Point(98, 139)
        pnlPersonalInfo.Name = "pnlPersonalInfo"
        pnlPersonalInfo.Size = New Size(1048, 544)
        pnlPersonalInfo.TabIndex = 25
        ' 
        ' cmbProf
        ' 
        cmbProf.FormattingEnabled = True
        cmbProf.Location = New Point(256, 409)
        cmbProf.Name = "cmbProf"
        cmbProf.Size = New Size(226, 28)
        cmbProf.TabIndex = 36
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(256, 374)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(226, 28)
        cmbStatus.TabIndex = 35
        ' 
        ' txtEmailaddress
        ' 
        txtEmailaddress.Location = New Point(800, 345)
        txtEmailaddress.Name = "txtEmailaddress"
        txtEmailaddress.Size = New Size(226, 27)
        txtEmailaddress.TabIndex = 31
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(17, 410)
        Label17.Name = "Label17"
        Label17.Size = New Size(90, 23)
        Label17.TabIndex = 32
        Label17.Text = "Professor:"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(812, 453)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(98, 38)
        btnCancel.TabIndex = 30
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' cmbProgram
        ' 
        cmbProgram.FormattingEnabled = True
        cmbProgram.Location = New Point(256, 304)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(226, 28)
        cmbProgram.TabIndex = 31
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(756, 131)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(226, 27)
        DateTimePicker1.TabIndex = 34
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(631, 133)
        Label16.Name = "Label16"
        Label16.Size = New Size(91, 23)
        Label16.TabIndex = 33
        Label16.Text = "Birthdate:"
        ' 
        ' cmbSection
        ' 
        cmbSection.FormattingEnabled = True
        cmbSection.Location = New Point(256, 340)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(226, 28)
        cmbSection.TabIndex = 30
        ' 
        ' btnSave
        ' 
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(690, 453)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 38)
        btnSave.TabIndex = 29
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtContactNum
        ' 
        txtContactNum.Location = New Point(800, 306)
        txtContactNum.Name = "txtContactNum"
        txtContactNum.Size = New Size(226, 27)
        txtContactNum.TabIndex = 30
        ' 
        ' txtLName
        ' 
        txtLName.Location = New Point(226, 166)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(226, 27)
        txtLName.TabIndex = 32
        ' 
        ' txtMName
        ' 
        txtMName.Location = New Point(226, 134)
        txtMName.Name = "txtMName"
        txtMName.Size = New Size(226, 27)
        txtMName.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(17, 375)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 23)
        Label9.TabIndex = 12
        Label9.Text = "Status:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label12.Location = New Point(568, 257)
        Label12.Name = "Label12"
        Label12.Size = New Size(313, 41)
        Label12.TabIndex = 24
        Label12.Text = "Contact Information:"
        ' 
        ' btnEditProf
        ' 
        btnEditProf.ForeColor = Color.Teal
        btnEditProf.Location = New Point(566, 453)
        btnEditProf.Name = "btnEditProf"
        btnEditProf.Size = New Size(118, 38)
        btnEditProf.TabIndex = 28
        btnEditProf.Text = "Edit Profile"
        btnEditProf.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label11.Location = New Point(17, 257)
        Label11.Name = "Label11"
        Label11.Size = New Size(340, 41)
        Label11.TabIndex = 23
        Label11.Text = "Academic Information:"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl.Location = New Point(17, 341)
        lbl.Name = "lbl"
        lbl.Size = New Size(74, 23)
        lbl.TabIndex = 9
        lbl.Text = "Section:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(568, 309)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 23)
        Label6.TabIndex = 10
        Label6.Text = "Contact Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 307)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 23)
        Label5.TabIndex = 7
        Label5.Text = "Course:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(17, 167)
        Label15.Name = "Label15"
        Label15.Size = New Size(99, 23)
        Label15.TabIndex = 30
        Label15.Text = "Last Name:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(17, 134)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 23)
        Label14.TabIndex = 29
        Label14.Text = "Middle Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(568, 346)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 23)
        Label7.TabIndex = 5
        Label7.Text = "Email:"
        ' 
        ' txtAddr
        ' 
        txtAddr.Location = New Point(756, 101)
        txtAddr.Name = "txtAddr"
        txtAddr.Size = New Size(226, 27)
        txtAddr.TabIndex = 28
        ' 
        ' cmbSex
        ' 
        cmbSex.FormattingEnabled = True
        cmbSex.Location = New Point(756, 69)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(226, 28)
        cmbSex.TabIndex = 27
        ' 
        ' mtxtStudId
        ' 
        mtxtStudId.Location = New Point(226, 70)
        mtxtStudId.Mask = "00-00000"
        mtxtStudId.Name = "mtxtStudId"
        mtxtStudId.Size = New Size(226, 27)
        mtxtStudId.TabIndex = 26
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(226, 102)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(226, 27)
        txtFname.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(631, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 23)
        Label4.TabIndex = 24
        Label4.Text = "Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(17, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(323, 41)
        Label10.TabIndex = 22
        Label10.Text = "Personal Information:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(631, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 23)
        Label2.TabIndex = 8
        Label2.Text = "Sex:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(17, 103)
        Label13.Name = "Label13"
        Label13.Size = New Size(102, 23)
        Label13.TabIndex = 3
        Label13.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 23)
        Label3.TabIndex = 3
        Label3.Text = "First Name:"
        ' 
        ' lblTotalStudentsTitle
        ' 
        lblTotalStudentsTitle.AutoSize = True
        lblTotalStudentsTitle.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalStudentsTitle.Location = New Point(17, 70)
        lblTotalStudentsTitle.Name = "lblTotalStudentsTitle"
        lblTotalStudentsTitle.Size = New Size(102, 23)
        lblTotalStudentsTitle.TabIndex = 0
        lblTotalStudentsTitle.Text = "Student ID:"
        ' 
        ' MyProfileForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MyProfileForm"
        Text = "Pasig Institute of Technology"
        pnlSidebar.ResumeLayout(False)
        pnlBottomMenu.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlPersonalInfo.ResumeLayout(False)
        pnlPersonalInfo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlBottomMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnEvaluationLog As Button
    Friend WithEvents btnInternships As Button
    Friend WithEvents btnInternship As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEditProf As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlPersonalInfo As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAddr As TextBox
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents mtxtStudId As MaskedTextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents txtEmailaddress As TextBox
    Friend WithEvents txtContactNum As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbProf As ComboBox
    Friend WithEvents cmbStatus As ComboBox
End Class
