Imports System.Data.OleDb
Public Class Form1
    Dim connection As OleDb.OleDbConnection
    Dim uname As String
    Dim command As OleDbCommand
    Dim pass As String
    Dim reader As OleDbDataReader
    Public connectionString As String = DB.connString
    Public Shared PersonId As Integer
    Public Shared PersonRole As String
    Public Shared PersonName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'connection = New OleDbConnection(DB.connString)
        'connection.Open()
        'command = connection.CreateCommand()
        ''command.CommandText = "INSERT INTO Staff ([FullName], [Username], [Password], [Role], [Gender], [Email], [MobileNo], [Salary], [Specialization]) VALUES('Ahmed Javed', 'ahmed', '123456', 'Teacher', 'Male', 'ahmed@yahoo.com', '+921231234567', '350000', 'Science')"
        'command.CommandText = "INSERT INTO Timetable ([Grade], [Day], [Period1], [Period2], [Period3], [Period4], [Period5], [Period6], [Period7]) VALUES('Nursery', 'Monday', 'Physical Training', 'Games', 'English', '', '', '', '')"
        'command.ExecuteNonQuery()
        'connection.Close()
        Error1.Visible = False
        Error2.Visible = False
        uname = input1.Text
        pass = input2.Text
        If input1.Text = "" Then
            Error1.Text = "Enter Username"
            Error1.Visible = True
        End If
        If input2.Text = "" Then
            Error2.Text = "Enter Password"
            Error2.Visible = True
        End If

        connection = New OleDbConnection(connectionString)
        connection.Open()
        command = connection.CreateCommand()
        command.CommandText = "Select ID, role, FullName from Staff Where Username = '" & input1.Text & "' AND Password = '" & input2.Text & "'"
        reader = command.ExecuteReader
        If (reader.Read()) Then
            sprint.Visible = True
            sprint.Update()
            System.Threading.Thread.Sleep(4000)
            Me.Hide()
            PersonId = reader.GetValue(0)
            PersonRole = reader.GetValue(1)
            PersonName = reader.GetValue(2)
            Dim form As New Form2
            form.Show()
            input1.Text = ""
            input2.Text = ""
            sprint.Visible = False

        Else
            MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        connection.Close()
    End Sub
End Class
