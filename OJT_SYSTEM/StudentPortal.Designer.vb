<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudentPortal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStudentPortal))
        lblStudentLogIn = New Label()
        pnlStudentLogIn = New Panel()
        picEye = New PictureBox()
        picLogo = New PictureBox()
        btnCreate = New Button()
        btnBack = New Button()
        btnLogIn = New Button()
        txtBoxPassword = New TextBox()
        lblPassword = New Label()
        lblEmail = New Label()
        txtBoxEmail = New TextBox()
        pnlStudentLogIn.SuspendLayout()
        CType(picEye, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStudentLogIn
        ' 
        lblStudentLogIn.AutoSize = True
        lblStudentLogIn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentLogIn.ForeColor = Color.Black
        lblStudentLogIn.Location = New Point(146, 83)
        lblStudentLogIn.Name = "lblStudentLogIn"
        lblStudentLogIn.Size = New Size(299, 54)
        lblStudentLogIn.TabIndex = 0
        lblStudentLogIn.Text = "Student Log In"
        ' 
        ' pnlStudentLogIn
        ' 
        pnlStudentLogIn.Controls.Add(picEye)
        pnlStudentLogIn.Controls.Add(picLogo)
        pnlStudentLogIn.Controls.Add(btnCreate)
        pnlStudentLogIn.Controls.Add(btnBack)
        pnlStudentLogIn.Controls.Add(btnLogIn)
        pnlStudentLogIn.Controls.Add(txtBoxPassword)
        pnlStudentLogIn.Controls.Add(lblPassword)
        pnlStudentLogIn.Controls.Add(lblEmail)
        pnlStudentLogIn.Controls.Add(txtBoxEmail)
        pnlStudentLogIn.Controls.Add(lblStudentLogIn)
        pnlStudentLogIn.Dock = DockStyle.Left
        pnlStudentLogIn.Location = New Point(0, 0)
        pnlStudentLogIn.Name = "pnlStudentLogIn"
        pnlStudentLogIn.Size = New Size(615, 673)
        pnlStudentLogIn.TabIndex = 1
        ' 
        ' picEye
        ' 
        picEye.BackColor = SystemColors.Window
        picEye.Location = New Point(434, 370)
        picEye.Name = "picEye"
        picEye.Size = New Size(44, 33)
        picEye.SizeMode = PictureBoxSizeMode.Zoom
        picEye.TabIndex = 19
        picEye.TabStop = False
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(451, 0)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(164, 147)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 18
        picLogo.TabStop = False
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnCreate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.ForeColor = Color.Black
        btnCreate.Location = New Point(187, 551)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(258, 56)
        btnCreate.TabIndex = 7
        btnCreate.Text = "Create an Account"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnBack.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 37)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.DarkTurquoise
        btnLogIn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogIn.Location = New Point(187, 466)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(258, 58)
        btnLogIn.TabIndex = 5
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' txtBoxPassword
        ' 
        txtBoxPassword.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtBoxPassword.Location = New Point(188, 365)
        txtBoxPassword.Name = "txtBoxPassword"
        txtBoxPassword.Size = New Size(304, 38)
        txtBoxPassword.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblPassword.ForeColor = Color.Black
        lblPassword.Location = New Point(64, 370)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(118, 31)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.Black
        lblEmail.Location = New Point(64, 227)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(76, 31)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email:"
        ' 
        ' txtBoxEmail
        ' 
        txtBoxEmail.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtBoxEmail.Location = New Point(188, 220)
        txtBoxEmail.Name = "txtBoxEmail"
        txtBoxEmail.Size = New Size(304, 38)
        txtBoxEmail.TabIndex = 1
        ' 
        ' FrmStudentPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(615, 673)
        Controls.Add(pnlStudentLogIn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmStudentPortal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Portal"
        pnlStudentLogIn.ResumeLayout(False)
        pnlStudentLogIn.PerformLayout()
        CType(picEye, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblStudentLogIn As Label
    Friend WithEvents pnlStudentLogIn As Panel
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picEye As PictureBox
End Class
