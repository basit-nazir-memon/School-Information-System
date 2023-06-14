Imports System.Data.OleDb

Public Class Form11
    Dim conn As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim dataset As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Dim Grade As String

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Error1.Visible = False
        Error2.Visible = False

        If GradeSelector.Text = "" Then
            Error1.Text = "No Grade Selected"
            Error1.Visible = True
        Else
            Grade = GradeSelector.Text
            GradeForm.Visible = False
            Panel2.Visible = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Error1.Visible = False
        Error2.Visible = False
        If ComboBox1.Text = "" Then
            Error2.Text = "No Subject Selected"
            Error2.Visible = True
        Else
            Panel2.Visible = False
            conn = New OleDbConnection(Form1.connectionString)
            dataset = New DataSet
            tables = dataset.Tables
            adapter = New OleDbDataAdapter("Select * from Results Where Grade = '" & Grade & "' AND Course = '" & ComboBox1.Text & "' ", conn)
            adapter.Fill(dataset, "Results")
            Dim view As New DataView(tables(0))
            source.DataSource = view
            DataGridView1.DataSource = view
            conn.Close()
            DataGridView1.Visible = True
        End If
    End Sub


End Class