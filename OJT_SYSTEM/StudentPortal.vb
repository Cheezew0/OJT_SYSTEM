Imports MySql.Data.MySqlClient

Public Class FrmStudentPortal
    Private Sub FrmStudentPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlStudentLogIn.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        Me.BackColor = ColorTranslator.FromHtml("#E6F2F4")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnBack.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        Dim ChooseLogIn As New FrmChooseLogin
        ChooseLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        btnLogIn.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        Dim email As String = txtBoxEmail.Text.Trim()
        Dim password As String = txtBoxPassword.Text.Trim()

        ' ----------------------------------
        ' BASIC INPUT VALIDATION
        ' ----------------------------------
        If email = "" OrElse password = "" Then
            MessageBox.Show("Please enter both email and password.")
            Exit Sub
        End If

        ' ----------------------------------
        ' DATABASE VALIDATION
        ' ----------------------------------
        Dim connectionString As String = "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String =
                    "SELECT student_id 
                 FROM student_acc 
                 WHERE email = @Email AND password = @Password 
                 LIMIT 1;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim studentId As String = result.ToString()

                        MessageBox.Show("Login Successful! Welcome, Student " & studentId)


                        Dim profile As New MyProfileForm(studentId)
                        profile.Show()
                        Me.Hide()

                    Else
                        MessageBox.Show("Incorrect email or password.",
                                        "Access Denied",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        btnCreate.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        Dim createAcc As New CreateAccountFrm
        createAcc.Show()
        Me.Hide()
    End Sub
End Class