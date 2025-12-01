Imports System.IO
Imports MySql.Data.MySqlClient

Public Class StudentForm
    Private connectionString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        ' Current form
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    ' ===============================================
    ' FORM LOAD + FILTER SETUP
    ' ===============================================
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DO NOT recreate dgvStudents here (that erased all columns before)
        ' dgvStudents = New RoundedPanel()   ' <-- keep this removed

        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        ' 🔹 Force mask and keep the dash when reading Text
        mtxtStudentId.Mask = "00-00000"
        mtxtStudentId.TextMaskFormat = MaskFormat.IncludeLiterals   ' <-- important

        ' --- FILTER SETUP ---
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("All students")
        cmbFilter.Items.Add("My students")
        cmbFilter.SelectedIndex = 0   ' default = All students

        ' Load initial data: all students
        LoadStudents(showAll:=True)
    End Sub

    ' ===============================================
    ' LOAD ONLY CURRENT FACULTY'S STUDENTS (helper)
    ' ===============================================
    Private Sub LoadStudentsForCurrentFaculty()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String =
                    "SELECT student_id " &
                    "FROM student " &
                    "WHERE faculty_id = @FacultyId " &
                    "ORDER BY student_id;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)

                    Using reader = cmd.ExecuteReader()
                        dgvStudents.Rows.Clear()
                        While reader.Read()
                            Dim idx = dgvStudents.Rows.Add()
                            dgvStudents.Rows(idx).Cells(0).Value = reader("student_id").ToString()
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try
    End Sub

    ' ==========================================================

    Private Sub btnInternships_Click(sender As Object, e As EventArgs) Handles btnInternships.Click
        Dim internForm As New InternForm()
        internForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnEvaluationLog_Click(sender As Object, e As EventArgs) Handles btnEvaluationLog.Click
        Dim evalForm As New EvaluationForm()
        evalForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        )

        If result = DialogResult.Yes Then
            Me.Hide()
            FrmChooseLogin.Show()
        End If
    End Sub

    ' ===============================================================
    ' CSV UPLOAD → INSERT STUDENT IDs → ASSIGN faculty_id AUTOMATICALLY
    ' ===============================================================
    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select CSV file"
        ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines() As String = File.ReadAllLines(ofd.FileName)

                dgvStudents.Rows.Clear()

                Dim studentIdColIndex As Integer = 0

                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i).Trim()
                    If line = "" Then Continue For

                    Dim parts() As String = line.Split(","c)
                    If parts.Length > 0 Then
                        Dim studentId As String = parts(0).Trim()
                        Dim rowIndex As Integer = dgvStudents.Rows.Add()
                        dgvStudents.Rows(rowIndex).Cells(studentIdColIndex).Value = studentId
                    End If
                Next

                ' Save to DB and assign faculty_id
                SaveStudentIdsToDatabase()

                MessageBox.Show("Student IDs loaded from CSV and saved to database.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh student list so only this faculty's rows appear
                LoadStudentsForCurrentFaculty()

            Catch ex As Exception
                MessageBox.Show("Error reading CSV file: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ===============================================================
    ' SAVE TO DATABASE + TAG WITH CURRENT FACULTY ID
    ' ===============================================================
    Private Sub SaveStudentIdsToDatabase()

        ' 0) BASIC CHECK THAT CurrentFacultyId IS SET
        If CurrentFacultyId <= 0 Then
            MessageBox.Show("The logged-in faculty ID is not set. " &
                            "Please log in again before importing students.",
                            "Invalid Faculty ID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' 0.1) VERIFY THAT THIS FACULTY EXISTS IN THE faculty TABLE
            Using checkFacultyCmd As New MySqlCommand(
                "SELECT COUNT(*) FROM faculty WHERE faculty_id = @FacultyId;", conn)
                checkFacultyCmd.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                Dim count As Integer = CInt(checkFacultyCmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show(
                        "Faculty ID " & CurrentFacultyId &
                        " does not exist in the faculty table." & Environment.NewLine &
                        "Students cannot be imported because the foreign key would fail.",
                        "Faculty Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            ' 1) command to check who (if anyone) owns this student_id
            Dim selectSql As String =
                "SELECT faculty_id FROM student WHERE student_id = @StudentId;"

            ' 2) command to insert a brand-new student_id
            Dim insertSql As String =
                "INSERT INTO student " &
                "(student_id, first_name, last_name, middle_name, program, " &
                " email_address, address, student_contact, section, status, faculty_id) " &
                "VALUES (@StudentId, '', '', '', '', '', '', NULL, '', 'Active', @FacultyId);"

            ' 3) command to “claim” an unowned student (faculty_id IS NULL)
            Dim claimSql As String =
                "UPDATE student " &
                "SET faculty_id = @FacultyId " &
                "WHERE student_id = @StudentId AND faculty_id IS NULL;"

            Dim studentIdColIndex As Integer = 0

            ' optional counters for debugging / messages
            Dim insertedCount As Integer = 0
            Dim claimedCount As Integer = 0
            Dim skippedOwnedByOther As Integer = 0

            For Each row As DataGridViewRow In dgvStudents.Rows
                If row.IsNewRow Then Continue For

                Dim idObj = row.Cells(studentIdColIndex).Value
                If idObj Is Nothing Then Continue For

                Dim studentId As String = idObj.ToString().Trim()
                If studentId = "" Then Continue For

                ' ----------------------------
                ' Step 1: does this ID exist?
                ' ----------------------------
                Dim existingFacultyId As Object = Nothing
                Using cmdSelect As New MySqlCommand(selectSql, conn)
                    cmdSelect.Parameters.AddWithValue("@StudentId", studentId)
                    existingFacultyId = cmdSelect.ExecuteScalar()
                End Using

                If existingFacultyId Is Nothing Then
                    ' ID does NOT exist yet -> INSERT with this faculty
                    Using cmdInsert As New MySqlCommand(insertSql, conn)
                        cmdInsert.Parameters.AddWithValue("@StudentId", studentId)
                        cmdInsert.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                    insertedCount += 1

                ElseIf existingFacultyId Is DBNull.Value Then
                    ' ID exists but is unclaimed (faculty_id IS NULL).
                    Using cmdClaim As New MySqlCommand(claimSql, conn)
                        cmdClaim.Parameters.AddWithValue("@StudentId", studentId)
                        cmdClaim.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                        Dim rowsAffected = cmdClaim.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            claimedCount += 1
                        End If
                    End Using

                Else
                    ' ID exists AND already has a faculty owner
                    Dim ownerId As Integer = CInt(existingFacultyId)
                    If ownerId = CurrentFacultyId Then
                        ' already belongs to this faculty – nothing to do
                    Else
                        ' belongs to another faculty – skip this ID
                        skippedOwnedByOther += 1
                    End If
                End If
            Next

            ' Optional: show more detailed info if you like
            Dim msg As String =
                $"New students added: {insertedCount}" & Environment.NewLine &
                $"Unclaimed students now assigned to you: {claimedCount}" & Environment.NewLine &
                $"Skipped (already assigned to another faculty): {skippedOwnedByOther}"

            MessageBox.Show(msg, "Import Summary",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    ' ===============================================
    ' LOAD STUDENTS (ALL or ONLY CURRENT FACULTY)
    ' ===============================================
    Private Sub LoadStudents(Optional showAll As Boolean = False)
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "SELECT student_id FROM student"

                If Not showAll Then
                    sql &= " WHERE faculty_id = @FacultyId"
                End If

                sql &= " ORDER BY student_id;"

                Using cmd As New MySqlCommand(sql, conn)
                    If Not showAll Then
                        cmd.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvStudents.Rows.Clear()

                        While reader.Read()
                            Dim idx As Integer = dgvStudents.Rows.Add()
                            dgvStudents.Rows(idx).Cells(0).Value = reader("student_id").ToString()
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading students: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ===============================================
    ' FILTER COMBOBOX
    ' ===============================================
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Dim showAll As Boolean = (cmbFilter.SelectedIndex = 0)   ' 0 = All students
        LoadStudents(showAll)
    End Sub

    ' ===============================================
    ' HELPER: GET STUDENT ID FROM MASKED TEXTBOX
    ' Mask should be 00-00000. We only accept when mask is full.
    ' ===============================================
    Private Function GetStudentIdFromMask() As String
        ' Require the mask to be fully filled (e.g., "23-00613")
        If Not mtxtStudentId.MaskFull Then
            Return ""
        End If

        Dim value As String = mtxtStudentId.Text.Trim()   ' returns "23-00613" now

        ' Optional extra safety: validate length & pattern
        If value.Length <> 8 OrElse Not value Like "##-#####" Then
            Return ""
        End If

        Return value
    End Function

    ' ===============================================
    ' ADD SINGLE STUDENT (MaskedTextBox + button)
    ' ===============================================
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim studentId As String = GetStudentIdFromMask()

        If studentId = "" Then
            MessageBox.Show("Please enter a valid Student ID in the format 00-00000.",
                            "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim selectSql As String =
                "SELECT faculty_id FROM student WHERE student_id = @StudentId;"

            Dim insertSql As String =
                "INSERT INTO student " &
                "(student_id, first_name, last_name, middle_name, program, " &
                " email_address, address, student_contact, section, status, faculty_id) " &
                "VALUES (@StudentId, '', '', '', '', '', '', NULL, '', 'Active', @FacultyId);"

            Dim claimSql As String =
                "UPDATE student " &
                "SET faculty_id = @FacultyId " &
                "WHERE student_id = @StudentId AND faculty_id IS NULL;"

            Dim existingFacultyId As Object = Nothing
            Using cmdSelect As New MySqlCommand(selectSql, conn)
                cmdSelect.Parameters.AddWithValue("@StudentId", studentId)
                existingFacultyId = cmdSelect.ExecuteScalar()
            End Using

            If existingFacultyId Is Nothing Then
                ' brand new ID -> insert
                Using cmdInsert As New MySqlCommand(insertSql, conn)
                    cmdInsert.Parameters.AddWithValue("@StudentId", studentId)
                    cmdInsert.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                    cmdInsert.ExecuteNonQuery()
                End Using
                MessageBox.Show("Student added and assigned to you.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf existingFacultyId Is DBNull.Value Then
                ' exists but unclaimed -> claim it
                Using cmdClaim As New MySqlCommand(claimSql, conn)
                    cmdClaim.Parameters.AddWithValue("@StudentId", studentId)
                    cmdClaim.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                    Dim rows = cmdClaim.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Unassigned student is now assigned to you.", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Could not assign student (maybe already claimed).", "Info",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using

            Else
                Dim ownerId As Integer = CInt(existingFacultyId)
                If ownerId = CurrentFacultyId Then
                    MessageBox.Show("This student is already assigned to you.", "Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("This student is assigned to another faculty and cannot be taken.",
                                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End Using

        ' refresh grid based on current filter
        Dim showAll As Boolean = (cmbFilter.SelectedIndex = 0)
        LoadStudents(showAll)
    End Sub

    ' ===============================================
    ' DELETE STUDENT (only if assigned to this faculty)
    ' ===============================================
    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Dim studentId As String = GetStudentIdFromMask()

        If studentId = "" Then
            MessageBox.Show("Please enter a valid Student ID in the format 00-00000.",
                            "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm = MessageBox.Show(
            $"Are you sure you want to delete student {studentId}?",
            "Confirm delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2)

        If confirm <> DialogResult.Yes Then Return

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim selectSql As String =
                "SELECT faculty_id FROM student WHERE student_id = @StudentId;"

            Dim deleteSql As String =
                "DELETE FROM student WHERE student_id = @StudentId AND faculty_id = @FacultyId;"

            Dim existingFacultyId As Object = Nothing
            Using cmdSelect As New MySqlCommand(selectSql, conn)
                cmdSelect.Parameters.AddWithValue("@StudentId", studentId)
                existingFacultyId = cmdSelect.ExecuteScalar()
            End Using

            If existingFacultyId Is Nothing Then
                MessageBox.Show("Student ID does not exist in the database.", "Not found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If existingFacultyId Is DBNull.Value Then
                MessageBox.Show("Student exists but is not assigned to any faculty; deletion is not allowed here.",
                                "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ownerId As Integer = CInt(existingFacultyId)
            If ownerId <> CurrentFacultyId Then
                MessageBox.Show("You can only delete students that are assigned to you.",
                                "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using cmdDelete As New MySqlCommand(deleteSql, conn)
                cmdDelete.Parameters.AddWithValue("@StudentId", studentId)
                cmdDelete.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                Dim rows = cmdDelete.ExecuteNonQuery()
                If rows > 0 Then
                    MessageBox.Show("Student deleted.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Delete failed.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using

        ' refresh grid based on current filter
        Dim showAll As Boolean = (cmbFilter.SelectedIndex = 0)
        LoadStudents(showAll)
    End Sub

    ' optional: you can show a small tooltip here if you like
    Private Sub mtxtStudentId_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtStudentId.MaskInputRejected
        ' You can leave this empty or show a hint; not required for correctness.
    End Sub

End Class
