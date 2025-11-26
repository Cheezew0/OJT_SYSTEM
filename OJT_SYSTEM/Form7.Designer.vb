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
        lblStudentLogIn = New Label()
        pnlStudentLogIn = New Panel()
        btnBack = New Button()
        btnLogIn = New Button()
        txtBoxPassword = New TextBox()
        lblPassword = New Label()
        lblEmail = New Label()
        txtBoxEmail = New TextBox()
        pnlCreate = New Panel()
        btnCreate = New Button()
        txtBoxPassword2 = New TextBox()
        txtBoxEmail2 = New TextBox()
        txrBoxStudentID = New TextBox()
        lblPassword2 = New Label()
        lblEmail2 = New Label()
        LblStudentID = New Label()
        lblStudentSignUp = New Label()
        pnlStudentLogIn.SuspendLayout()
        pnlCreate.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblStudentLogIn
        ' 
        lblStudentLogIn.AutoSize = True
        lblStudentLogIn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentLogIn.ForeColor = Color.White
        lblStudentLogIn.Location = New Point(146, 83)
        lblStudentLogIn.Name = "lblStudentLogIn"
        lblStudentLogIn.Size = New Size(299, 54)
        lblStudentLogIn.TabIndex = 0
        lblStudentLogIn.Text = "Student Log In"
        ' 
        ' pnlStudentLogIn
        ' 
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
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 37)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        btnLogIn.Location = New Point(172, 489)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(169, 57)
        btnLogIn.TabIndex = 5
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = True
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
        lblPassword.ForeColor = Color.White
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
        lblEmail.ForeColor = Color.White
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
        ' pnlCreate
        ' 
        pnlCreate.Controls.Add(btnCreate)
        pnlCreate.Controls.Add(txtBoxPassword2)
        pnlCreate.Controls.Add(txtBoxEmail2)
        pnlCreate.Controls.Add(txrBoxStudentID)
        pnlCreate.Controls.Add(lblPassword2)
        pnlCreate.Controls.Add(lblEmail2)
        pnlCreate.Controls.Add(LblStudentID)
        pnlCreate.Controls.Add(lblStudentSignUp)
        pnlCreate.Dock = DockStyle.Right
        pnlCreate.Location = New Point(621, 0)
        pnlCreate.Name = "pnlCreate"
        pnlCreate.Size = New Size(641, 673)
        pnlCreate.TabIndex = 2
        ' 
        ' btnCreate
        ' 
        btnCreate.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        btnCreate.Location = New Point(255, 489)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(169, 57)
        btnCreate.TabIndex = 8
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' txtBoxPassword2
        ' 
        txtBoxPassword2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtBoxPassword2.Location = New Point(241, 387)
        txtBoxPassword2.Name = "txtBoxPassword2"
        txtBoxPassword2.Size = New Size(292, 38)
        txtBoxPassword2.TabIndex = 7
        ' 
        ' txtBoxEmail2
        ' 
        txtBoxEmail2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtBoxEmail2.Location = New Point(241, 299)
        txtBoxEmail2.Name = "txtBoxEmail2"
        txtBoxEmail2.Size = New Size(292, 38)
        txtBoxEmail2.TabIndex = 6
        ' 
        ' txrBoxStudentID
        ' 
        txrBoxStudentID.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txrBoxStudentID.Location = New Point(241, 216)
        txrBoxStudentID.Name = "txrBoxStudentID"
        txrBoxStudentID.Size = New Size(292, 38)
        txrBoxStudentID.TabIndex = 5
        ' 
        ' lblPassword2
        ' 
        lblPassword2.AutoSize = True
        lblPassword2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblPassword2.Location = New Point(105, 394)
        lblPassword2.Name = "lblPassword2"
        lblPassword2.Size = New Size(118, 31)
        lblPassword2.TabIndex = 4
        lblPassword2.Text = "Password:"
        ' 
        ' lblEmail2
        ' 
        lblEmail2.AutoSize = True
        lblEmail2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblEmail2.Location = New Point(105, 306)
        lblEmail2.Name = "lblEmail2"
        lblEmail2.Size = New Size(76, 31)
        lblEmail2.TabIndex = 3
        lblEmail2.Text = "Email:"
        ' 
        ' LblStudentID
        ' 
        LblStudentID.AutoSize = True
        LblStudentID.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        LblStudentID.Location = New Point(105, 223)
        LblStudentID.Name = "LblStudentID"
        LblStudentID.Size = New Size(130, 31)
        LblStudentID.TabIndex = 1
        LblStudentID.Text = "Student ID:"
        ' 
        ' lblStudentSignUp
        ' 
        lblStudentSignUp.AutoSize = True
        lblStudentSignUp.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentSignUp.Location = New Point(175, 83)
        lblStudentSignUp.Name = "lblStudentSignUp"
        lblStudentSignUp.Size = New Size(311, 54)
        lblStudentSignUp.TabIndex = 0
        lblStudentSignUp.Text = "Create Account"
        ' 
        ' FrmStudentPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 673)
        Controls.Add(pnlCreate)
        Controls.Add(pnlStudentLogIn)
        Name = "FrmStudentPortal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
        pnlStudentLogIn.ResumeLayout(False)
        pnlStudentLogIn.PerformLayout()
        pnlCreate.ResumeLayout(False)
        pnlCreate.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblStudentLogIn As Label
    Friend WithEvents pnlStudentLogIn As Panel
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents pnlCreate As Panel
    Friend WithEvents lblStudentSignUp As Label
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents LblStudentID As Label
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents txrBoxStudentID As TextBox
    Friend WithEvents txtBoxPassword2 As TextBox
    Friend WithEvents txtBoxEmail2 As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBack As Button
End Class
