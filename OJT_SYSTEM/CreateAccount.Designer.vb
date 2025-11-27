<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountFrm
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
        pnlCreate = New Panel()
        txtConfirmPass = New TextBox()
        Label1 = New Label()
        btnBack2 = New Button()
        mkEmailReg = New MaskedTextBox()
        btnCreate = New Button()
        txtPass = New TextBox()
        txrBoxStudentID = New TextBox()
        lblPassword2 = New Label()
        lblEmail2 = New Label()
        LblStudentID = New Label()
        lblStudentSignUp = New Label()
        pnlCreate.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCreate
        ' 
        pnlCreate.Controls.Add(txtConfirmPass)
        pnlCreate.Controls.Add(Label1)
        pnlCreate.Controls.Add(btnBack2)
        pnlCreate.Controls.Add(mkEmailReg)
        pnlCreate.Controls.Add(btnCreate)
        pnlCreate.Controls.Add(txtPass)
        pnlCreate.Controls.Add(txrBoxStudentID)
        pnlCreate.Controls.Add(lblPassword2)
        pnlCreate.Controls.Add(lblEmail2)
        pnlCreate.Controls.Add(LblStudentID)
        pnlCreate.Controls.Add(lblStudentSignUp)
        pnlCreate.Dock = DockStyle.Right
        pnlCreate.Location = New Point(-3, 0)
        pnlCreate.Name = "pnlCreate"
        pnlCreate.Size = New Size(641, 630)
        pnlCreate.TabIndex = 3
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        txtConfirmPass.Location = New Point(150, 438)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.Size = New Size(336, 31)
        txtConfirmPass.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(150, 410)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 25)
        Label1.TabIndex = 11
        Label1.Text = "Confirm Password"
        ' 
        ' btnBack2
        ' 
        btnBack2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack2.Location = New Point(15, 12)
        btnBack2.Name = "btnBack2"
        btnBack2.Size = New Size(82, 37)
        btnBack2.TabIndex = 10
        btnBack2.Text = "Back"
        btnBack2.UseVisualStyleBackColor = True
        ' 
        ' mkEmailReg
        ' 
        mkEmailReg.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        mkEmailReg.Location = New Point(150, 282)
        mkEmailReg.Name = "mkEmailReg"
        mkEmailReg.Size = New Size(336, 31)
        mkEmailReg.TabIndex = 9
        ' 
        ' btnCreate
        ' 
        btnCreate.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.Location = New Point(226, 522)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(169, 35)
        btnCreate.TabIndex = 8
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        txtPass.Location = New Point(150, 356)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(336, 31)
        txtPass.TabIndex = 7
        ' 
        ' txrBoxStudentID
        ' 
        txrBoxStudentID.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        txrBoxStudentID.Location = New Point(150, 210)
        txrBoxStudentID.Name = "txrBoxStudentID"
        txrBoxStudentID.Size = New Size(336, 31)
        txrBoxStudentID.TabIndex = 5
        ' 
        ' lblPassword2
        ' 
        lblPassword2.AutoSize = True
        lblPassword2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword2.Location = New Point(150, 328)
        lblPassword2.Name = "lblPassword2"
        lblPassword2.Size = New Size(94, 25)
        lblPassword2.TabIndex = 4
        lblPassword2.Text = "Password:"
        ' 
        ' lblEmail2
        ' 
        lblEmail2.AutoSize = True
        lblEmail2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblEmail2.Location = New Point(150, 254)
        lblEmail2.Name = "lblEmail2"
        lblEmail2.Size = New Size(60, 25)
        lblEmail2.TabIndex = 3
        lblEmail2.Text = "Email:"
        ' 
        ' LblStudentID
        ' 
        LblStudentID.AutoSize = True
        LblStudentID.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        LblStudentID.Location = New Point(150, 182)
        LblStudentID.Name = "LblStudentID"
        LblStudentID.Size = New Size(105, 25)
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
        ' CreateAccountFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 630)
        Controls.Add(pnlCreate)
        Name = "CreateAccountFrm"
        Text = "CreateAccount"
        pnlCreate.ResumeLayout(False)
        pnlCreate.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCreate As Panel
    Friend WithEvents mkEmailReg As MaskedTextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txrBoxStudentID As TextBox
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents LblStudentID As Label
    Friend WithEvents lblStudentSignUp As Label
    Friend WithEvents btnBack2 As Button
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label1 As Label
End Class
