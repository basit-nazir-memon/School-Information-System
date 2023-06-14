Imports System.Data.OleDb
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form6

    Dim conn As OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Dim TeacherName As String
    Public Sub New()
        InitializeComponent()
        conn = New OleDbConnection(Form1.connectionString)
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = "Select FullName from Staff Where Role = 'Teacher'"
        reader = cmd.ExecuteReader
        While reader.Read
            TeacherList.Items.Add(reader.GetValue(0))
        End While
        conn.Close()

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label7.Visible = False
        If TeacherList.Text = "" Then
            Label7.Text = "Teacher not selected"
            Label7.Visible = True
        Else
            TeacherName = TeacherList.Text
            conn = New OleDbConnection(Form1.connectionString)
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandText = "Select class1, class2, class3, class4, class5 from Staff Where FullName = '" & TeacherName & "'"
            reader = cmd.ExecuteReader
            MessageBox.Show(TeacherName)
            If reader.Read() Then
                If Not (reader.IsDBNull(0)) Then
                    ComboBox1.Text = reader.GetValue(0)
                End If
                If Not (reader.IsDBNull(1)) Then
                    ComboBox2.Text = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(2)) Then
                    ComboBox3.Text = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    ComboBox4.Text = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    ComboBox5.Text = reader.GetValue(4)
                End If
                TeacherSelection.Visible = False
                Panel2.Visible = True
            Else
                Label7.Text = "Teacher not Exist"
                Label7.Visible = True
            End If
            conn.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDbConnection(Form1.connectionString)
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = "Update Staff Set Class1 = '" & ComboBox1.Text & "', Class2 = '" & ComboBox2.Text & "', Class3 = '" & ComboBox3.Text & "', Class4 = '" & ComboBox4.Text & "', Class5 = '" & ComboBox5.Text & "' Where FullName = '" & TeacherName & "'"
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class