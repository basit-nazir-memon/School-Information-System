Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form3
    Dim connection As OleDb.OleDbConnection
    Dim command As OleDbCommand

    Public Sub New()
        InitializeComponent()
        If Form1.PersonRole = "Teacher" Then
            StaffToolStripMenuItem.Visible = False
            PatientsToolStripMenuItem.Visible = False
            RegisterPatientToolStripMenuItem.Visible = False
            BookAppointmentToolStripMenuItem.Visible = False
            RegisterStaffToolStripMenuItem.Visible = False
            ManageTimeTableToolStripMenuItem.Visible = False
        End If

        If Form1.PersonRole = "Principal" Then
            RegisterPatientToolStripMenuItem.Visible = False
            BookAppointmentToolStripMenuItem.Visible = False
            ManageTimeTableToolStripMenuItem.Visible = False

        End If

        If Form1.PersonRole = "Clerk" Then
            RegisterPatientToolStripMenuItem.Visible = False
            BookAppointmentToolStripMenuItem.Visible = False
            RegisterStaffToolStripMenuItem.Visible = False
            ManageTimeTableToolStripMenuItem.Visible = False

        End If

        If Form1.PersonRole = "Peon" Then
            StaffToolStripMenuItem.Visible = False
            PatientsToolStripMenuItem.Visible = False
            RegisterPatientToolStripMenuItem.Visible = False
            BookAppointmentToolStripMenuItem.Visible = False
            RegisterStaffToolStripMenuItem.Visible = False
            ManageTimeTableToolStripMenuItem.Visible = False
            ManageResultToolStripMenuItem.Visible = False
        End If
    End Sub


    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim Newform As New Form2
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim Newform As New Form5
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Dim Newform As New Form8
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub PatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientsToolStripMenuItem.Click
        Dim Newform As New Form7
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub RegisterPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterPatientToolStripMenuItem.Click
        Dim Newform As New Form3
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub BookAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookAppointmentToolStripMenuItem.Click
        Dim Newform As New Form4
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub RegisterStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStaffToolStripMenuItem.Click
        Dim Newform As New Form6
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub ManageResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageResultToolStripMenuItem.Click
        Dim Newform As New Form11
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub ManageTimeTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageTimeTableToolStripMenuItem.Click
        Dim Newform As New Form9
        Me.Close()
        Newform.Show()
    End Sub

    Private Sub RegisterEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterEmployeesToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Register.Click
        Error1.Visible = False
        Error2.Visible = False
        Error3.Visible = False
        Dim Gender As String
        If RadioButton1.Checked = True Then
            gender = "Male"
        ElseIf RadioButton2.Checked = True Then
            gender = "Female"
        Else
            gender = "Other"
        End If

        If (SNAme.Text = "") Then
            Error1.Visible = True
        End If
        If (FathName.Text = "") Then
            Error2.Visible = True
        End If
        If (Number.Text = "") Then
            Error3.Visible = True
        End If
        If (SGrade.Text = "") Then
            Error4.Visible = True
        End If
        If (SSection.Text = "") Then
            Error5.Visible = True
        End If
        If (STution.Text = "") Then
            Error6.Visible = True
        End If

        If SNAme.Text <> "" And FathName.Text <> "" And Number.Text <> "" And SGrade.Text <> "" And SSection.Text <> "" And STution.Text <> "" Then
            connection = New OleDbConnection(Form1.connectionString)
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "INSERT into Students ([Name], [FatherName], [Gender], [FatherMobileNo], [DOB], [Grade], [Section], [TutionFee]) VALUES('" & SNAme.Text & "', '" & FathName.Text & "', '" & Gender & "', '" & Number.Text & "', '" & SDOB.Text & "', '" & SGrade.Text & "', '" & SSection.Text & "', '" & STution.Text & "')"
            command.ExecuteNonQuery()
            Dim i As Integer = 0
            If (ComboBox1.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox1.Text & "')"
                command.ExecuteNonQuery()
            End If

            If (ComboBox2.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox2.Text & "')"
                command.ExecuteNonQuery()
            End If

            If (ComboBox3.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox3.Text & "')"
                command.ExecuteNonQuery()
            End If

            If (ComboBox4.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox4.Text & "')"
                command.ExecuteNonQuery()
            End If

            If (ComboBox5.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox5.Text & "')"
                command.ExecuteNonQuery()
            End If

            If (ComboBox6.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox6.Text & "')"
                command.ExecuteNonQuery()
            End If

            If (ComboBox7.Text <> "") Then
                command.CommandText = "Insert into results([StudentName], [Grade], [Course]) values('" & SNAme.Text & "', '" & SGrade.Text & "', '" & ComboBox7.Text & "')"
                command.ExecuteNonQuery()
            End If
            connection.Close()
            Me.AutoScroll = False
            AdmissionForm.Visible = True
            Label30.Text = SNAme.Text
            Label31.Text = FathName.Text
            Label32.Text = Gender
            Label33.Text = Number.Text
            Label14.Text = SDOB.Text
            Label1.Text = SGrade.Text
            Label49.Text = SSection.Text
            Label48.Text = STution.Text
            Label40.Text = ComboBox1.Text
            Label38.Text = ComboBox2.Text
            Label37.Text = ComboBox3.Text
            Label36.Text = ComboBox4.Text
            Label35.Text = ComboBox5.Text
            Label34.Text = ComboBox6.Text
            Label10.Text = ComboBox7.Text
            SNAme.Text = ""
            FathName.Text = ""
            Number.Text = ""
            SGrade.Text = ""
            SSection.Text = ""
            STution.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox5.Text = ""
            ComboBox6.Text = ""
            ComboBox7.Text = ""
        End If

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Me.AutoScroll = True
        AdmissionForm.Visible = False
    End Sub
End Class