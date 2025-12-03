Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions          ' 👈 add this
Imports MySql.Data.MySqlClient

Public Class MyProfileForm

    Private connectionString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"
    Private studentIdValue As String

    Public Sub New(studentId As String)
        InitializeComponent()
        studentIdValue = studentId
    End Sub

    ' ===================== FORM LOAD =====================

    Private Sub MyProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPersonalInfo.Region = RoundCorners(pnlPersonalInfo, 20)
        RoundButtonCorners(btnEditProf, 20)
        RoundButtonCorners(btnSave, 20)
        RoundButtonCorners(btnCancel, 20)

        pnlPersonalInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
        btnSave.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        cmbSex.Items.AddRange(New String() {"Male", "Female", "Other"})
        cmbStatus.Items.AddRange(New String() {"Active", "Inactive", "Graduated"})
        cmbProgram.Items.AddRange(New String() {
            "BSIT",
            "BSCS",
            "BSBA",
            "BSA",
            "BSN",
            "BSCE",
            "BSCpE"
        })

        cmbSection.Items.AddRange(New String() {"4A", "4B", "4C", "4D"})

        ' 🔹 Department combo (read-only, auto from course)
        cmbDepartment.Items.Clear()
        cmbDepartment.Items.Add("Computer Science")          ' for BSCS
        cmbDepartment.Items.Add("Information Technology")    ' for BSIT

        LoadStudentInfo()
        DisableEditing()
    End Sub
    Private Function RoundCorners(myPanel As Panel, radius As Integer) As Region
        Dim path As New GraphicsPath()
        path.StartFigure()

        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(myPanel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(myPanel.Width - radius, myPanel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, myPanel.Height - radius, radius, radius), 90, 90)

        path.CloseFigure()
        Return New Region(path)
    End Function

    Private Sub RoundButtonCorners(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()

        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)

        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub


    ' ===================== LOAD STUDENT + PROFESSOR =====================

    Private Sub LoadStudentInfo()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String =
                    "SELECT s.student_id, s.first_name, s.last_name, s.middle_name, " &
                    "       s.program, s.email_address, s.address, s.student_contact, " &
                    "       s.section, s.status, s.sex, s.birthdate, " &
                    "       CONCAT(f.first_name, ' ', f.last_name) AS professor_name, " &
                    "       sa.email AS acc_email, " &
                    "       CASE " &
                    "         WHEN s.email_address IS NULL OR s.email_address = '' " &
                    "         THEN sa.email " &
                    "         ELSE s.email_address " &
                    "       END AS effective_email " &
                    "FROM student s " &
                    "LEFT JOIN faculty f ON s.faculty_id = f.faculty_id " &
                    "LEFT JOIN student_acc sa ON s.student_id = sa.student_id " &
                    "WHERE s.student_id = @StudentId;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@StudentId", studentIdValue)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' ---- PERSONAL INFO ----
                            mtxtStudId.Text = reader("student_id").ToString()
                            txtFname.Text = reader("first_name").ToString()
                            txtMName.Text = reader("middle_name").ToString()
                            txtLName.Text = reader("last_name").ToString()
                            txtAddr.Text = reader("address").ToString()

                            If Not IsDBNull(reader("birthdate")) Then
                                DateTimePicker1.Value = CDate(reader("birthdate"))
                            End If
                            If Not IsDBNull(reader("sex")) Then
                                cmbSex.Text = reader("sex").ToString()
                            End If

                            ' ---- ACADEMIC INFO ----
                            cmbProgram.Text = reader("program").ToString()
                            cmbSection.Text = reader("section").ToString()
                            cmbStatus.Text = reader("status").ToString()

                            ' auto-set department based on program
                            UpdateDepartmentFromProgram()

                            ' ---- PROFESSOR (read-only) ----
                            Dim profName As String = ""
                            If Not IsDBNull(reader("professor_name")) Then
                                profName = reader("professor_name").ToString()
                            End If
                            cmbProf.Items.Clear()
                            If profName <> "" Then
                                cmbProf.Items.Add(profName)
                                cmbProf.SelectedIndex = 0
                            End If

                            ' ---- CONTACT INFO (email + phone) ----
                            Dim emailToShow As String = ""
                            If Not IsDBNull(reader("effective_email")) Then
                                emailToShow = reader("effective_email").ToString()
                            End If
                            txtEmailaddress.Text = emailToShow

                            Dim contactRaw As String = reader("student_contact").ToString()

                            ' convert stored "09xxxxxxxxx" → "+639xxxxxxxxx" for display
                            If Regex.IsMatch(contactRaw, "^0\d{10}$") Then
                                txtContactNum.Text = "+63" & contactRaw.Substring(1)
                            Else
                                txtContactNum.Text = contactRaw
                            End If
                        Else
                            MessageBox.Show("Student record not found for ID: " & studentIdValue)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading profile: " & ex.Message)
            End Try
        End Using
    End Sub

    ' keep department in sync when course changes
    Private Sub cmbProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgram.SelectedIndexChanged
        UpdateDepartmentFromProgram()
    End Sub

    Private Sub UpdateDepartmentFromProgram()
        Select Case cmbProgram.Text

        ' Existing
            Case "BSCS"
                cmbDepartment.Text = "Computer Science"

            Case "BSIT"
                cmbDepartment.Text = "Information Technology"

        ' New programs and departments
            Case "BSBA", "BS Business Administration"
                cmbDepartment.Text = "Business Administration"

            Case "BSA", "BS Accountancy"
                cmbDepartment.Text = "Accountancy"

            Case "BSN", "BS Nursing"
                cmbDepartment.Text = "Nursing"

            Case "BSCE", "BS Civil Engineering",
             "BSCpE", "BS Computer Engineering"
                cmbDepartment.Text = "Engineering"

            Case Else
                cmbDepartment.Text = ""
        End Select
    End Sub


    ' ===================== ENABLE / DISABLE EDITING =====================

    Private Sub DisableEditing()
        txtEmailaddress.Enabled = False
        txtContactNum.Enabled = False
        txtLName.Enabled = False
        txtMName.Enabled = False
        txtFname.Enabled = False
        txtAddr.Enabled = False
        mtxtStudId.Enabled = False

        cmbSex.Enabled = False
        cmbStatus.Enabled = False
        cmbProgram.Enabled = False
        cmbSection.Enabled = False
        cmbDepartment.Enabled = False   ' derived from course
        cmbProf.Enabled = False

        DateTimePicker1.Enabled = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub EnableEditing()
        txtEmailaddress.Enabled = False   ' email still read-only
        txtContactNum.Enabled = True
        txtLName.Enabled = True
        txtMName.Enabled = True
        txtFname.Enabled = True
        txtAddr.Enabled = True

        mtxtStudId.Enabled = False

        cmbSex.Enabled = True
        cmbStatus.Enabled = True
        cmbProgram.Enabled = True
        cmbSection.Enabled = True

        cmbDepartment.Enabled = False     ' auto-filled
        cmbProf.Enabled = False

        DateTimePicker1.Enabled = True

        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    ' ===================== SAVE PROFILE =====================

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' --- normalize + validate contact number ---
        Dim contactInput As String = txtContactNum.Text.Trim()
        Dim normalizedContact As String = ""

        If contactInput <> "" Then
            ' already in +63xxxxxxxxxx format
            If Regex.IsMatch(contactInput, "^\+63\d{10}$") Then
                normalizedContact = contactInput

                ' local 09xxxxxxxxx → convert to +63xxxxxxxxxx
            ElseIf Regex.IsMatch(contactInput, "^0\d{10}$") Then
                normalizedContact = "+63" & contactInput.Substring(1)

            Else
                MessageBox.Show(
                    "Contact number must be in the format +63XXXXXXXXXX " &
                    "or 0XXXXXXXXXXX (11 digits starting with 0).",
                    "Invalid Contact Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
                Return
            End If
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String =
                    "UPDATE student SET " &
                    "first_name = @FirstName, " &
                    "middle_name = @MiddleName, " &
                    "last_name = @LastName, " &
                    "program = @Program, " &
                    "email_address = @Email, " &
                    "address = @Address, " &
                    "student_contact = @Contact, " &
                    "section = @Section, " &
                    "status = @Status, " &
                    "sex = @Sex, " &
                    "birthdate = @Birthdate " &
                    "WHERE student_id = @StudentId;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@FirstName", txtFname.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@Program", cmbProgram.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmailaddress.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddr.Text)
                    cmd.Parameters.AddWithValue("@Contact", normalizedContact)
                    cmd.Parameters.AddWithValue("@Section", cmbSection.Text)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@Sex", cmbSex.Text)
                    cmd.Parameters.AddWithValue("@Birthdate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@StudentId", studentIdValue)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Profile updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                DisableEditing()
                LoadStudentInfo()

            Catch ex As Exception
                MessageBox.Show("Error saving changes: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ===================== BUTTON EVENTS =====================

    Private Sub btnEditProf_Click(sender As Object, e As EventArgs) Handles btnEditProf.Click
        EnableEditing()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableEditing()
        LoadStudentInfo()
    End Sub

    Private Sub btnInternship_Click(sender As Object, e As EventArgs) Handles btnInternship.Click
        Dim btnInternshipForm As New StudInternForm(studentIdValue)
        btnInternshipForm.Show()
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

End Class
