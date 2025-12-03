Imports MySql.Data.MySqlClient

Public Class FrmFacultyLogIn

    ' <<< add this field >>>
    Private passwordShown As Boolean = False

    Private connectionString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    Private Sub FrmFacultyLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#E6F2F4")

        ' hide password by default
        TextBox1.UseSystemPasswordChar = True

        ' set default eye icon (closed)
        picEye.Image = My.Resources.hide    ' make sure this name matches your resource
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

                ' Get faculty_id + email + account_id using JOIN
                Dim sql As String =
                    "SELECT f.faculty_id, f.email, fa.account_id " &
                    "FROM faculty_acc fa " &
                    "JOIN faculty f ON fa.faculty_email = f.email " &
                    "WHERE fa.faculty_email = @Email AND fa.password = @Password " &
                    "LIMIT 1;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            CurrentFacultyId = CInt(reader("faculty_id"))
                            CurrentFacultyEmail = reader("email").ToString()
                            CurrentAccountId = CInt(reader("account_id"))

                            MessageBox.Show("Faculty login successful!",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)

                            Dim fDash As New DashboardForm(CurrentAccountId)
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
                End Using

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub picEye_Click(sender As Object, e As EventArgs) Handles picEye.Click
        If passwordShown = False Then
            TextBox1.UseSystemPasswordChar = False
            picEye.Image = My.Resources.view   ' open-eye icon
            passwordShown = True
        Else
            TextBox1.UseSystemPasswordChar = True
            picEye.Image = My.Resources.hide   ' closed-eye icon
            passwordShown = False
        End If
    End Sub

End Class
