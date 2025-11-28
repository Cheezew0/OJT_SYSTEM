Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class MyProfileForm

    Private _studentId As String

    Private connectionString As String =
        "Server=localhost;Database=ojt_management_system;Uid=root;Pwd=;"  ' adjust

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnInternship.Click
        Dim btnInternshipForm As New StudInternForm
        btnInternshipForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        pnlSidebar.BackColor = ColorTranslator.FromHtml("#1A4F5D")
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        pnlMain.BackColor = ColorTranslator.FromHtml("#B7C0D9")
    End Sub

    Private Sub MyProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPersonalInfo.Region = RoundCorners(pnlPersonalInfo, 20)
        RoundButtonCorners(btnEditProf, 20)
        RoundButtonCorners(btnSave, 20)
        RoundButtonCorners(btnCancel, 20)

        pnlPersonalInfo.BackColor = ColorTranslator.FromHtml("#F7F7F7")
        btnSave.BackColor = ColorTranslator.FromHtml("#1A4F5D")

        cmbSex.Items.AddRange(New String() {"Male", "Female", "Other"})
        cmbStatus.Items.AddRange(New String() {"Active", "Inactive", "Graduated"})
        cmbProgram.Items.AddRange(New String() {"BSIT", "BSCS"})
        cmbSection.Items.AddRange(New String() {"4A", "4B", "4C", "4D"})
        LoadStudentInfo()
        LoadProfessors()

        DisableEditing()
    End Sub


    Private Sub pnlStudent_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub pnlPersonalInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlPersonalInfo.Paint
    End Sub

    Private Sub pnlAcadInfo_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub pnlContactInfo_Paint(sender As Object, e As PaintEventArgs)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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

                    ' take values from your controls
                    cmd.Parameters.AddWithValue("@FirstName", txtFname.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@Program", cmbProgram.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmailaddress.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddr.Text)
                    cmd.Parameters.AddWithValue("@Contact", txtContactNum.Text)
                    cmd.Parameters.AddWithValue("@Section", cmbSection.Text)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@Sex", cmbSex.Text)
                    cmd.Parameters.AddWithValue("@Birthdate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))

                    ' this is the logged-in student's ID you stored earlier
                    cmd.Parameters.AddWithValue("@StudentId", studentIdValue)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Profile updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                DisableEditing()   ' lock the fields again

            Catch ex As Exception
                MessageBox.Show("Error saving changes: " & ex.Message)
            End Try
        End Using
    End Sub

    Private studentIdValue As String

    Public Sub New(studentId As String)
        InitializeComponent()   ' REQUIRED for the form to load
        studentIdValue = studentId
    End Sub

    Private Sub LoadStudentInfo()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String =
                "SELECT student_id, first_name, last_name, middle_name, " &
                "       program, email_address, address, student_contact, " &
                "       section, status " &
                "FROM student " &
                "WHERE student_id = @StudentId"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@StudentId", studentIdValue)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' ------ PERSONAL INFO ------
                            mtxtStudId.Text = reader("student_id").ToString()
                            txtFname.Text = reader("first_name").ToString()
                            txtMName.Text = reader("middle_name").ToString()
                            txtLName.Text = reader("last_name").ToString()
                            txtAddr.Text = reader("address").ToString()

                            ' If you already added birthdate & sex columns later:
                            'DateTimePicker1.Value = CDate(reader("birthdate"))
                            'cmbSex.SelectedItem = reader("sex").ToString()

                            ' ------ ACADEMIC INFO ------
                            cmbProgram.Text = reader("program").ToString()
                            cmbSection.Text = reader("section").ToString()
                            cmbProf.Text = reader("status").ToString()

                            ' ------ CONTACT INFO ------
                            txtContactNum.Text = reader("student_contact").ToString()
                            txtEmailaddress.Text = reader("email_address").ToString()
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
    Private Sub LoadProfessors()
        Using conn As New MySqlConnection(connectionString)
            Dim sql As String =
            "SELECT faculty_id, first_name, last_name " &
            "FROM faculty " &
            "ORDER BY last_name, first_name"

            Using cmd As New MySqlCommand(sql, conn)
                Try
                    conn.Open()

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    ' Build a FullName column for display
                    dt.Columns.Add("FullName", GetType(String))
                    For Each row As DataRow In dt.Rows
                        row("FullName") = row("first_name").ToString() & " " & row("last_name").ToString()
                    Next

                    cmbProf.DataSource = dt
                    cmbProf.DisplayMember = "FullName"   ' what user sees
                    cmbProf.ValueMember = "faculty_id"   ' underlying id we can use later

                    cmbProf.SelectedIndex = -1           ' nothing selected at start

                Catch ex As Exception
                    MessageBox.Show("Error loading professors: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

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
        cmbProf.Enabled = False

        DateTimePicker1.Enabled = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Private Sub EnableEditing()
        txtEmailaddress.Enabled = True
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
        cmbProf.Enabled = True

        DateTimePicker1.Enabled = True

        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnEditProf_Click(sender As Object, e As EventArgs) Handles btnEditProf.Click
        EnableEditing()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableEditing()
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
