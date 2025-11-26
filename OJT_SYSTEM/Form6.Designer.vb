<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChooseLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChooseLogin))
        picLogo = New PictureBox()
        panellf = New Panel()
        Label1 = New Label()
        FacultyLogin = New Button()
        StudentLogin = New Button()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        panellf.SuspendLayout()
        SuspendLayout()
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(21, 82)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(569, 504)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' panellf
        ' 
        panellf.BackColor = Color.Transparent
        panellf.Controls.Add(Label1)
        panellf.Controls.Add(FacultyLogin)
        panellf.Controls.Add(StudentLogin)
        panellf.Dock = DockStyle.Right
        panellf.Location = New Point(622, 0)
        panellf.Name = "panellf"
        panellf.Size = New Size(640, 673)
        panellf.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(39, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(598, 81)
        Label1.TabIndex = 2
        Label1.Text = "WELCOME PITCIAN!"
        ' 
        ' FacultyLogin
        ' 
        FacultyLogin.FlatAppearance.BorderSize = 0
        FacultyLogin.FlatStyle = FlatStyle.Popup
        FacultyLogin.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        FacultyLogin.Location = New Point(112, 373)
        FacultyLogin.Name = "FacultyLogin"
        FacultyLogin.Size = New Size(448, 95)
        FacultyLogin.TabIndex = 1
        FacultyLogin.Text = "CONTINUE AS FACULTY"
        FacultyLogin.UseVisualStyleBackColor = True
        ' 
        ' StudentLogin
        ' 
        StudentLogin.FlatAppearance.BorderSize = 0
        StudentLogin.FlatStyle = FlatStyle.Popup
        StudentLogin.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentLogin.Location = New Point(112, 221)
        StudentLogin.Name = "StudentLogin"
        StudentLogin.Size = New Size(448, 82)
        StudentLogin.TabIndex = 0
        StudentLogin.Text = "CONTINUE AS STUDENT"
        StudentLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmChooseLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 673)
        Controls.Add(panellf)
        Controls.Add(picLogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmChooseLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcome"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        panellf.ResumeLayout(False)
        panellf.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents panellf As Panel
    Friend WithEvents FacultyLogin As Button
    Friend WithEvents StudentLogin As Button
    Friend WithEvents Label1 As Label
End Class
