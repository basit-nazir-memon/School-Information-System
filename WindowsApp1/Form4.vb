Imports System.Data.OleDb

Public Class Form4
    Dim gender As String
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Appoint.Click
        Error1.Visible = False
        Error2.Visible = False
        Error3.Visible = False
        Error4.Visible = False
        Error5.Visible = False
        Error6.Visible = False
        Error7.Visible = False
        Error8.Visible = False

        If (RadioButton1.Checked = True) Then
            gender = "Male"
        ElseIf RadioButton2.Checked = True Then
            gender = "Female"
        Else
            gender = "Other"
        End If

        If (ENAme.Text = "") Then
            Error1.Visible = True
        End If
        If (EUNAme.Text = "") Then
            Error2.Visible = True
        End If
        If (EPAss.Text = "") Then
            Error3.Visible = True
        End If
        If (ERole.Text = "") Then
            Error4.Visible = True
        End If
        If (EEMail.Text = "") Then
            Error5.Visible = True
        End If
        If (ESalary.Text = "") Then
            Error6.Visible = True
        End If
        If (ESpecialize.Text = "") Then
            Error7.Visible = True
        End If
        If (ENumber.Text = "") Then
            Error8.Visible = True
        End If

        If ENAme.Text <> "" And EUNAme.Text <> "" And EPAss.Text <> "" And ERole.Text <> "" And EEMail.Text <> "" And ESalary.Text <> "" And ESpecialize.Text <> "" And ENumber.Text <> "" Then
            connection = New OleDbConnection(Form1.connectionString)
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "INSERT INTO Staff ([FullName], [Username], [Password], [Role], [Email], [Gender] , [Salary], [Specialization], [MobileNo]) VALUES('" & ENAme.Text & "', '" & EUNAme.Text & "', '" & EPAss.Text & "', '" & ERole.Text & "', '" & EEMail.Text & "', '" & gender & "', '" & ESalary.Text & "', '" & ESpecialize.Text & "', '" & ENumber.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()
            ENAme.Text = ""
            EUNAme.Text = ""
            EEMail.Text = ""
            ENumber.Text = ""
            ERole.Text = ""
            EPAss.Text = ""
            ESalary.Text = ""
            ESpecialize.Text = ""
        End If
    End Sub
End Class