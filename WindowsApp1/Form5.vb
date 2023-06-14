Imports System.Data.OleDb

Public Class Form5
    Private ReadOnly connection As OleDb.OleDbConnection
    Private ReadOnly command As OleDbCommand
    Private ReadOnly reader As OleDbDataReader
    Public Sub New()
        InitializeComponent()
        connection = New OleDbConnection(Form1.connectionString)
        connection.Open()
        command = connection.CreateCommand()
        command.CommandText = "Select * from Staff Where ID = " & Form1.PersonId & ""
        reader = command.ExecuteReader
        If reader.Read() Then
            FName.Text = reader.GetValue(1)
            UName.Text = reader.GetValue(2)
            Pass.Text = reader.GetValue(3)
            Rol.Text = reader.GetValue(4)
            Mail.Text = reader.GetValue(6)
            Gen.Text = reader.GetValue(5)
            Salry.Text = reader.GetValue(7)
            Specialize.Text = reader.GetValue(8)
            Number.Text = reader.GetValue(9)
        End If
        connection.Close()

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


End Class