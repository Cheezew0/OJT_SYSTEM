<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacultyLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacultyLogIn))
        lblFacultyLogIn = New Label()
        btnLogIn = New Button()
        txtBoxEmail = New TextBox()
        TextBox1 = New TextBox()
        lblEmail = New Label()
        lblPassword = New Label()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblFacultyLogIn
        ' 
        lblFacultyLogIn.AutoSize = True
        lblFacultyLogIn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFacultyLogIn.ForeColor = Color.White
        lblFacultyLogIn.Location = New Point(224, 72)
        lblFacultyLogIn.Name = "lblFacultyLogIn"
        lblFacultyLogIn.Size = New Size(285, 54)
        lblFacultyLogIn.TabIndex = 1
        lblFacultyLogIn.Text = "Faculty Log In"
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        btnLogIn.Location = New Point(269, 497)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(131, 51)
        btnLogIn.TabIndex = 2
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' txtBoxEmail
        ' 
        txtBoxEmail.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtBoxEmail.Location = New Point(269, 253)
        txtBoxEmail.Name = "txtBoxEmail"
        txtBoxEmail.Size = New Size(304, 38)
        txtBoxEmail.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        TextBox1.Location = New Point(269, 362)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(304, 38)
        TextBox1.TabIndex = 4
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(145, 260)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(76, 31)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(145, 369)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(118, 31)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password:"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 37)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' FrmFacultyLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(750, 673)
        Controls.Add(btnBack)
        Controls.Add(lblPassword)
        Controls.Add(lblEmail)
        Controls.Add(TextBox1)
        Controls.Add(txtBoxEmail)
        Controls.Add(btnLogIn)
        Controls.Add(lblFacultyLogIn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmFacultyLogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Faculty Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFacultyLogIn As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogIn As Button
End Class
