<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        pnlSidebar = New Panel()
        pnlBottomMenu = New Panel()
        btnLogout = New Button()
        btnFaculty = New Button()
        btnStudent = New Button()
        btnProfile = New Button()
        PictureBoxLogo = New PictureBox()
        pnlMain = New Panel()
        pnlStudent = New Panel()
        lblTotalStudentsTitle = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        pnlSidebar.SuspendLayout()
        pnlBottomMenu.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlStudent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.Transparent
        pnlSidebar.Controls.Add(pnlBottomMenu)
        pnlSidebar.Controls.Add(btnStudent)
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
        btnFaculty.Text = "Student"
        btnFaculty.TextAlign = ContentAlignment.MiddleRight
        btnFaculty.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFaculty.UseVisualStyleBackColor = False
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
        btnStudent.Text = "Internship"
        btnStudent.TextAlign = ContentAlignment.MiddleRight
        btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStudent.UseVisualStyleBackColor = False
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
        pnlMain.Controls.Add(pnlStudent)
        pnlMain.Controls.Add(Label1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(230, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1192, 858)
        pnlMain.TabIndex = 5
        ' 
        ' pnlStudent
        ' 
        pnlStudent.BackColor = SystemColors.ButtonShadow
        pnlStudent.Controls.Add(Label2)
        pnlStudent.Controls.Add(Label5)
        pnlStudent.Controls.Add(Label7)
        pnlStudent.Controls.Add(Label3)
        pnlStudent.Controls.Add(lblTotalStudentsTitle)
        pnlStudent.Location = New Point(98, 156)
        pnlStudent.Name = "pnlStudent"
        pnlStudent.Size = New Size(688, 421)
        pnlStudent.TabIndex = 7
        ' 
        ' lblTotalStudentsTitle
        ' 
        lblTotalStudentsTitle.AutoSize = True
        lblTotalStudentsTitle.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalStudentsTitle.Location = New Point(36, 37)
        lblTotalStudentsTitle.Name = "lblTotalStudentsTitle"
        lblTotalStudentsTitle.Size = New Size(102, 23)
        lblTotalStudentsTitle.TabIndex = 0
        lblTotalStudentsTitle.Text = "Student ID:"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 23)
        Label3.TabIndex = 3
        Label3.Text = "Student Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(36, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 23)
        Label5.TabIndex = 7
        Label5.Text = "Sex:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(36, 103)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 23)
        Label7.TabIndex = 5
        Label7.Text = "Course:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 8
        Label2.Text = "Address:"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Name = "Form5"
        Text = "Form5"
        pnlSidebar.ResumeLayout(False)
        pnlBottomMenu.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlStudent.ResumeLayout(False)
        pnlStudent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlBottomMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnEvaluationLog As Button
    Friend WithEvents btnInternships As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlStudent As Panel
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
