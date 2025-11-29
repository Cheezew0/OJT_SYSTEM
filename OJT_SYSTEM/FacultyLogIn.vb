Imports MySql.Data.MySqlClient

Public Class FrmFacultyLogIn
    Private connectionString As String =
    "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    Private Sub FrmFacultyLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim ChooseLogIn As New FrmChooseLogin
        ChooseLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim email As String = txtBoxEmail.Text.Trim()
        Dim password As String = TextBox1.Text.Trim()   ' your password textbox

        ' --- basic validation ---
        If email = "" OrElse password = "" Then
            MessageBox.Show("Please enter both email and password.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String =
                    "SELECT account_id " &
                    "FROM faculty_acc " &
                    "WHERE faculty_email = @Email AND password = @Password " &
                    "LIMIT 1;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        ' --- LOGIN SUCCESS ---
                        Dim accountId As Integer = CInt(result)
                        MessageBox.Show("Faculty login successful!")


                        Dim fDash As New DashboardForm(accountId)
                        fDash.Show()
                        Me.Hide()

                    Else
                        ' --- LOGIN FAILED ---
                        MessageBox.Show("Incorrect email or password.",
                                        "Access Denied",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using

    End Sub

End Class