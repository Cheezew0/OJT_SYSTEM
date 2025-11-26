<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Label1 = New Label()
        btnInternship = New Button()
        btnProfile = New Button()
        PictureBoxLogo = New PictureBox()
        btnLogout = New Button()
        btnFaculty = New Button()
        pnlBottomMenu = New Panel()
        pnlSidebar = New Panel()
        pnlMain = New Panel()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlBottomMenu.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
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
        pnlBottomMenu.Location = New Point(0, 719)
        pnlBottomMenu.Name = "pnlBottomMenu"
        pnlBottomMenu.Size = New Size(230, 139)
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
        pnlMain.Controls.Add(Label1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1422, 858)
        pnlMain.TabIndex = 7
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 858)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlMain)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form6"
        Text = "Pasig Institute of Technology"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlBottomMenu.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
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
End Class
