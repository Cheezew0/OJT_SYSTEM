Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions      ' for pattern checks

Public Class CreateAccountFrm

    Private connectionString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    ' Flags for show/hide password state
    Private passVisible As Boolean = False
    Private confirmVisible As Boolean = False

    ' ================== FORM LOAD ==================
    Private Sub CreateAccountFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mask password fields by default
        txtPass.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True

        ' Set default eye icons (closed)
        ' Make sure these resources exist: My.Resources.hide, My.Resources.view
        Try
            picPassEye.Image = My.Resources.hide
            picConfirmEye.Image = My.Resources.hide
        Catch
            ' If resources not found, ignore to avoid crash
        End Try

        lblPasswordMatch.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        btnBack2.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        Dim btnBack As New FrmStudentPortal
        btnBack.Show()
        Me.Hide()
    End Sub

    ' ================== CREATE ACCOUNT ==================
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        btnCreate.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        ' ================== RAW VALUES FROM CONTROLS ==================
        Dim rawStudentId As String = mtxtStudentID.Text.Trim()
        Dim password As String = txtPass.Text.Trim()
        Dim confirmPass As String = txtConfirmPass.Text.Trim()
        Dim emailInput As String = mkEmailReg.Text.Trim()

        ' ============= BASIC VALIDATION =============
        If rawStudentId = "" OrElse password = "" OrElse confirmPass = "" OrElse emailInput = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        ' ============= PASSWORD MINIMUM LENGTH RULE =============
        If password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.")
            Exit Sub
        End If

        ' Still enforce equality on click (even though we check live)
        If password <> confirmPass Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If

        ' Make sure the mask is fully filled (no underscores)
        If Not mtxtStudentID.MaskFull Then
            MessageBox.Show("Please enter a complete Student ID in the format 00-00000.")
            Exit Sub
        End If

        ' ============= STUDENT ID FORMAT xx-xxxxx =============
        If Not Regex.IsMatch(rawStudentId, "^\d{2}-\d{5}$") Then
            MessageBox.Show("Student ID must be in the format 00-00000 (e.g. 23-00613).")
            Exit Sub
        End If

        Dim studentId As String = rawStudentId   ' includes "-"

        ' ============= EMAIL FORMAT VALIDATION (ANY DOMAIN) =============
        Dim email As String = emailInput
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"

        If Not Regex.IsMatch(email, emailPattern) Then
            MessageBox.Show("Please enter a valid email address (example: name@example.com).",
                            "Invalid Email",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ================== DATABASE LOGIC ==================
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' 1) CHECK IF THIS STUDENT ALREADY HAS AN ACCOUNT
                Dim checkSql As String =
                    "SELECT COUNT(*) FROM student_acc WHERE student_id = @student_id"

                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@student_id", studentId)

                    Dim exists As Integer = CInt(checkCmd.ExecuteScalar())
                    If exists > 0 Then
                        MessageBox.Show(
                            "This student ID already has an account. Please log in instead.",
                            "Account already exists",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                        Exit Sub
                    End If
                End Using

                ' 2) INSERT NEW ACCOUNT
                Dim query As String =
                    "INSERT INTO student_acc (student_id, password, email) " &
                    "VALUES (@student_id, @password, @Email)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@student_id", studentId)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account created successfully!")

                mtxtStudentID.Clear()
                txtPass.Clear()
                txtConfirmPass.Clear()
                mkEmailReg.Clear()
                lblPasswordMatch.Visible = False   ' hide status after reset

            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("This email is already used.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf ex.Number = 1452 Then
                    MessageBox.Show("This Student ID does not exist in the student list.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Database error: " & ex.Message)
                End If

            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ================== LIVE PASSWORD MATCH + STRENGTH CHECK ==================

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        CheckPasswordMatch()
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        CheckPasswordMatch()
    End Sub

    Private Sub CheckPasswordMatch()
        Dim pwd As String = txtPass.Text
        Dim conf As String = txtConfirmPass.Text

        ' If both empty, hide label
        If String.IsNullOrEmpty(pwd) AndAlso String.IsNullOrEmpty(conf) Then
            lblPasswordMatch.Visible = False
            Return
        End If

        ' -------- Match check --------
        Dim matchOk As Boolean = (pwd <> "" AndAlso pwd = conf)

        ' -------- Length check (8+) --------
        Dim lengthOk As Boolean = (pwd.Length >= 8)

        ' -------- Strength checks --------
        Dim hasUpper As Boolean = Regex.IsMatch(pwd, "[A-Z]")
        Dim hasLower As Boolean = Regex.IsMatch(pwd, "[a-z]")
        Dim hasDigit As Boolean = Regex.IsMatch(pwd, "\d")
        Dim hasSymbol As Boolean = Regex.IsMatch(pwd, "[^A-Za-z0-9]")

        ' Score-based strength
        Dim score As Integer = 0
        If lengthOk Then score += 1
        If hasUpper AndAlso hasLower Then score += 1
        If hasDigit Then score += 1
        If hasSymbol Then score += 1

        Dim strength As String
        If score <= 1 Then
            strength = "Weak"
        ElseIf score = 2 OrElse score = 3 Then
            strength = "Medium"
        Else
            strength = "Strong"
        End If

        ' -------- Build label text --------
        Dim matchText As String = If(matchOk, "Passwords match ✓", "Passwords do not match ✗")
        Dim lengthText As String = If(lengthOk,
                                      "Length: OK (8+)",
                                      "Length: too short (<8)")
        Dim strengthText As String = "Strength: " & strength

        lblPasswordMatch.Text = matchText & " | " & lengthText & " | " & strengthText
        lblPasswordMatch.Visible = True

        ' -------- Color logic --------
        If Not matchOk OrElse Not lengthOk Then
            ' If they don't match or too short => red
            lblPasswordMatch.ForeColor = Color.Red
        Else
            ' They match and length OK -> color by strength
            Select Case strength
                Case "Weak"
                    lblPasswordMatch.ForeColor = Color.OrangeRed
                Case "Medium"
                    lblPasswordMatch.ForeColor = Color.DarkOrange
                Case "Strong"
                    lblPasswordMatch.ForeColor = Color.Green
            End Select
        End If
    End Sub

    ' ================== SHOW / HIDE PASSWORD EYES ==================

    Private Sub picPassEye_Click(sender As Object, e As EventArgs) Handles picPassEye.Click
        If passVisible Then
            ' Hide password
            txtPass.UseSystemPasswordChar = True
            Try
                picPassEye.Image = My.Resources.hide
            Catch
            End Try
            passVisible = False
        Else
            ' Show password
            txtPass.UseSystemPasswordChar = False
            Try
                picPassEye.Image = My.Resources.view
            Catch
            End Try
            passVisible = True
        End If
    End Sub

    Private Sub picConfirmEye_Click(sender As Object, e As EventArgs) Handles picConfirmEye.Click
        If confirmVisible Then
            ' Hide confirm password
            txtConfirmPass.UseSystemPasswordChar = True
            Try
                picConfirmEye.Image = My.Resources.hide
            Catch
            End Try
            confirmVisible = False
        Else
            ' Show confirm password
            txtConfirmPass.UseSystemPasswordChar = False
            Try
                picConfirmEye.Image = My.Resources.view
            Catch
            End Try
            confirmVisible = True
        End If
    End Sub

    ' MaskedTextBox event – optional
    Private Sub mtxtStudentID_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtStudentID.MaskInputRejected
        ' Optional: tooltip / message for invalid characters
    End Sub

End Class
