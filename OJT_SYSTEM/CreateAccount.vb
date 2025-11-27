Imports MySql.Data.MySqlClient

Public Class CreateAccountFrm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        btnBack2.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        Dim btnBack As New FrmStudentPortal
        btnBack.Show()
        Me.Hide()

    End Sub

    Private connectionString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        btnCreate.BackColor = ColorTranslator.FromHtml("#f7f7f7")

        Dim studentId As String = txrBoxStudentID.Text.Trim()
        Dim password As String = txtPass.Text.Trim()
        Dim confirmPass As String = txtConfirmPass.Text.Trim()
        Dim email As String = mkEmailReg.Text.Trim()

        'validation
        If studentId = "" OrElse password = "" OrElse confirmPass = "" OrElse email = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        If password <> confirmPass Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If

        If studentId.Length > 8 Then
            MessageBox.Show("Student ID must be 8 characters only.")
            Exit Sub
        End If

        'data insert
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String =
                    "INSERT INTO student_acc (student_id, password, email) 
                     VALUES (@student_id, @password, @Email)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@student_id", studentId)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@Email", email)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account created successfully!")

                txrBoxStudentID.Clear()
                txtPass.Clear()
                txtConfirmPass.Clear()
                mkEmailReg.Clear()

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
End Class