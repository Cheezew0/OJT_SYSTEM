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
    ' FORM LOAD + COURSE/SECTION FILTER SETUP
    ' ===============================================
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnStudent.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnInternships.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnEvaluationLog.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnFaculty.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnLogout.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        ' Masked textbox for manual add/delete
        mtxtStudentId.Mask = "00-00000"
        mtxtStudentId.TextMaskFormat = MaskFormat.IncludeLiterals

        ' ----- Course combo -----
        cmbCourse.Items.Clear()
        cmbCourse.Items.Add("All courses") ' index 0
        cmbCourse.Items.Add("BSIT")
        cmbCourse.Items.Add("BSCS")
        cmbCourse.SelectedIndex = 0

        ' ----- Section combo -----
        cmbSection.Items.Clear()
        cmbSection.Items.Add("All sections") ' index 0
        cmbSection.Items.Add("4A")
        cmbSection.Items.Add("4B")
        cmbSection.Items.Add("4C")
        cmbSection.Items.Add("4D")
        cmbSection.SelectedIndex = 0

        ' Initial load = ONLY this faculty's students, no extra filters
        LoadStudents(useFilters:=False)
    End Sub

    ' ===============================================
    ' CSV UPLOAD → INSERT STUDENT IDs → ASSIGN faculty_id AUTOMATICALLY
    ' ===============================================
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

                ' Reload grid (only current faculty, with selected section filter)
                LoadStudents()

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

        If CurrentFacultyId <= 0 Then
            MessageBox.Show("The logged-in faculty ID is not set. Please log in again.",
                            "Invalid Faculty ID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' verify faculty exists
            Using checkFacultyCmd As New MySqlCommand(
                "SELECT COUNT(*) FROM faculty WHERE faculty_id = @FacultyId;", conn)
                checkFacultyCmd.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                Dim count As Integer = CInt(checkFacultyCmd.ExecuteScalar())
                If count = 0 Then
                    MessageBox.Show("Faculty ID " & CurrentFacultyId &
                                    " does not exist in the faculty table.",
                                    "Faculty Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

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

            Dim studentIdColIndex As Integer = 0
            Dim insertedCount As Integer = 0
            Dim claimedCount As Integer = 0
            Dim skippedOwnedByOther As Integer = 0

            For Each row As DataGridViewRow In dgvStudents.Rows
                If row.IsNewRow Then Continue For

                Dim idObj = row.Cells(studentIdColIndex).Value
                If idObj Is Nothing Then Continue For

                Dim studentId As String = idObj.ToString().Trim()
                If studentId = "" Then Continue For

                Dim existingFacultyId As Object = Nothing
                Using cmdSelect As New MySqlCommand(selectSql, conn)
                    cmdSelect.Parameters.AddWithValue("@StudentId", studentId)
                    existingFacultyId = cmdSelect.ExecuteScalar()
                End Using

                If existingFacultyId Is Nothing Then
                    Using cmdInsert As New MySqlCommand(insertSql, conn)
                        cmdInsert.Parameters.AddWithValue("@StudentId", studentId)
                        cmdInsert.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                    insertedCount += 1

                ElseIf existingFacultyId Is DBNull.Value Then
                    Using cmdClaim As New MySqlCommand(claimSql, conn)
                        cmdClaim.Parameters.AddWithValue("@StudentId", studentId)
                        cmdClaim.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                        Dim rowsAffected = cmdClaim.ExecuteNonQuery()
                        If rowsAffected > 0 Then claimedCount += 1
                    End Using

                Else
                    Dim ownerId As Integer = CInt(existingFacultyId)
                    If ownerId <> CurrentFacultyId Then
                        skippedOwnedByOther += 1
                    End If
                End If
            Next

            Dim msg As String =
                $"New students added: {insertedCount}" & Environment.NewLine &
                $"Unclaimed students now assigned to you: {claimedCount}" & Environment.NewLine &
                $"Skipped (already assigned to another faculty): {skippedOwnedByOther}"

            MessageBox.Show(msg, "Import Summary",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    ' ===============================================
    ' LOAD STUDENTS (ONLY CURRENT FACULTY + OPTIONAL FILTERS)
    ' ===============================================
    Private Sub LoadStudents(Optional useFilters As Boolean = False)
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' base query: only students of this faculty
                Dim sql As String =
"SELECT
    s.student_id,
    CONCAT_WS(' ', s.first_name, s.middle_name, s.last_name) AS full_name,
    s.program,
    s.section,
    d.department_name,
    co.company_name,
    CASE 
        WHEN sa.student_id IS NULL THEN ''  -- only uploaded by prof, no account yet
        WHEN (
            (s.first_name IS NULL OR s.first_name = '') AND
            (s.last_name  IS NULL OR s.last_name  = '') AND
            (s.address    IS NULL OR s.address    = '') AND
            (s.student_contact IS NULL OR s.student_contact = '')
        ) THEN 'Inactive'                   -- has account but profile not filled
        ELSE s.status                       -- normal status
    END AS display_status,
    CONCAT_WS(' ', sup.first_name, sup.last_name) AS supervisor_name,
    g.final_grade_percent
FROM student s
LEFT JOIN course c
    ON c.program_name = CASE
        WHEN s.program = 'BSCS' THEN 'BS Computer Science'
        WHEN s.program = 'BSIT' THEN 'BS Information Technology'
        ELSE s.program
    END
LEFT JOIN department d
    ON d.department_id = c.department_id
LEFT JOIN internship i
    ON i.student_id = s.student_id
LEFT JOIN company co
    ON co.company_id = i.company_id
LEFT JOIN companycontact sup
    ON sup.supervisor_id = i.supervisor_id
LEFT JOIN grade g
    ON g.internship_id = i.internship_id
LEFT JOIN student_acc sa
    ON sa.student_id = s.student_id
WHERE s.faculty_id = @FacultyId"

                ' ---- optional course/section filters ----
                Dim courseFilter As String = Nothing
                Dim sectionFilter As String = Nothing

                If useFilters Then
                    If cmbCourse.SelectedIndex > 0 Then
                        courseFilter = cmbCourse.SelectedItem.ToString()  ' BSIT / BSCS
                        sql &= " AND s.program = @Program"
                    End If

                    If cmbSection.SelectedIndex > 0 Then
                        sectionFilter = cmbSection.SelectedItem.ToString() ' 4A / 4B / ...
                        sql &= " AND s.section = @Section"
                    End If
                End If

                sql &= " ORDER BY s.student_id;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)

                    If courseFilter IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@Program", courseFilter)
                    End If
                    If sectionFilter IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@Section", sectionFilter)
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvStudents.Rows.Clear()

                        While reader.Read()
                            Dim idx As Integer = dgvStudents.Rows.Add()
                            Dim row = dgvStudents.Rows(idx)

                            row.Cells(0).Value = reader("student_id").ToString()
                            row.Cells(1).Value = reader("full_name").ToString()
                            row.Cells(2).Value = reader("program").ToString()
                            row.Cells(3).Value = reader("section").ToString()
                            row.Cells(4).Value = reader("department_name").ToString()
                            row.Cells(5).Value = reader("company_name").ToString()
                            row.Cells(6).Value = reader("display_status").ToString()
                            row.Cells(7).Value = reader("supervisor_name").ToString()

                            If Not IsDBNull(reader("final_grade_percent")) Then
                                row.Cells(8).Value =
                                    CDec(reader("final_grade_percent")).ToString("0.00")
                            Else
                                row.Cells(8).Value = ""
                            End If
                        End While

                        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        dgvStudents.Columns(0).FillWeight = 70   ' ID
                        dgvStudents.Columns(1).FillWeight = 200  ' Name
                        dgvStudents.Columns(4).FillWeight = 150  ' Department
                        dgvStudents.Columns(7).FillWeight = 150  ' Supervisor
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading students: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ===============================================
    ' SEARCH BUTTON  (apply course + section filters)
    ' ===============================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' useFilters := True -> LoadStudents will read cmbCourse & cmbSection
        LoadStudents(useFilters:=True)
    End Sub

    ' ===============================================
    ' RESET BUTTON (clear filters, show only faculty's students)
    ' ===============================================
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbCourse.SelectedIndex = 0   ' All courses
        cmbSection.SelectedIndex = 0  ' All sections

        ' useFilters := False -> only WHERE s.faculty_id = CurrentFacultyId
        LoadStudents(useFilters:=False)
    End Sub

    ' old helper now just calls LoadStudents()
    Private Sub LoadStudentsForCurrentFaculty()
        LoadStudents()
    End Sub

    ' ===============================================
    ' SECTION FILTER COMBOBOX (optional live reload)
    ' ===============================================
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
        LoadStudents()
    End Sub

    ' ===============================================
    ' HELPER: GET STUDENT ID FROM MASKED TEXTBOX
    ' ===============================================
    Private Function GetStudentIdFromMask() As String
        If Not mtxtStudentId.MaskFull Then
            Return ""
        End If

        Dim value As String = mtxtStudentId.Text.Trim()   ' "23-00613"

        If value.Length <> 8 OrElse Not value Like "##-#####" Then
            Return ""
        End If

        Return value
    End Function

    ' ===============================================
    ' ADD SINGLE STUDENT
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
                Using cmdInsert As New MySqlCommand(insertSql, conn)
                    cmdInsert.Parameters.AddWithValue("@StudentId", studentId)
                    cmdInsert.Parameters.AddWithValue("@FacultyId", CurrentFacultyId)
                    cmdInsert.ExecuteNonQuery()
                End Using
                MessageBox.Show("Student added and assigned to you.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf existingFacultyId Is DBNull.Value Then
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

        LoadStudents()
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

        LoadStudents()
    End Sub

    Private Sub mtxtStudentId_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtStudentId.MaskInputRejected
        ' optional tooltip if you want
    End Sub

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
            MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            Me.Hide()
            FrmChooseLogin.Show()
        End If
    End Sub
End Class
