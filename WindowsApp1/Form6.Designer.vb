<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeacherList = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TeacherSelection = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRole = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Company = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTimeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherSelection.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 37)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Assign Courses"
        '
        'TeacherList
        '
        Me.TeacherList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherList.FormattingEnabled = True
        Me.TeacherList.Location = New System.Drawing.Point(36, 83)
        Me.TeacherList.Name = "TeacherList"
        Me.TeacherList.Size = New System.Drawing.Size(382, 30)
        Me.TeacherList.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 25)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Select Teacher"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(252, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 18)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "No Teacher Selected"
        Me.Label7.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(16, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(428, 58)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TeacherSelection
        '
        Me.TeacherSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TeacherSelection.Controls.Add(Me.Button3)
        Me.TeacherSelection.Controls.Add(Me.Label7)
        Me.TeacherSelection.Controls.Add(Me.Label4)
        Me.TeacherSelection.Controls.Add(Me.TeacherList)
        Me.TeacherSelection.Location = New System.Drawing.Point(504, 119)
        Me.TeacherSelection.Name = "TeacherSelection"
        Me.TeacherSelection.Size = New System.Drawing.Size(461, 356)
        Me.TeacherSelection.TabIndex = 85
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.ComboBox5)
        Me.Panel2.Controls.Add(Me.ComboBox4)
        Me.Panel2.Controls.Add(Me.ComboBox3)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(242, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(785, 505)
        Me.Panel2.TabIndex = 86
        Me.Panel2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(88, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 58)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Nursery", "Kinder Garden", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"})
        Me.ComboBox5.Location = New System.Drawing.Point(177, 344)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(218, 24)
        Me.ComboBox5.TabIndex = 9
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Nursery", "Kinder Garden", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"})
        Me.ComboBox4.Location = New System.Drawing.Point(177, 273)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(218, 24)
        Me.ComboBox4.TabIndex = 8
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Nursery", "Kinder Garden", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"})
        Me.ComboBox3.Location = New System.Drawing.Point(177, 207)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(218, 24)
        Me.ComboBox3.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Nursery", "Kinder Garden", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"})
        Me.ComboBox2.Location = New System.Drawing.Point(177, 141)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(218, 24)
        Me.ComboBox2.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nursery", "Kinder Garden", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"})
        Me.ComboBox1.Location = New System.Drawing.Point(177, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(173, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 22)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Class 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Class 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Class 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Class 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Class 1"
        '
        'PRole
        '
        Me.PRole.AutoSize = True
        Me.PRole.BackColor = System.Drawing.Color.Transparent
        Me.PRole.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRole.Location = New System.Drawing.Point(111, 153)
        Me.PRole.Name = "PRole"
        Me.PRole.Size = New System.Drawing.Size(67, 24)
        Me.PRole.TabIndex = 92
        Me.PRole.Text = "Admin"
        '
        'PName
        '
        Me.PName.AutoSize = True
        Me.PName.BackColor = System.Drawing.Color.Transparent
        Me.PName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PName.Location = New System.Drawing.Point(86, 119)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(121, 27)
        Me.PName.TabIndex = 91
        Me.PName.Text = "Basit Nazir"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.frame
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 102)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(86, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 90
        Me.PictureBox3.TabStop = False
        '
        'Company
        '
        Me.Company.AutoSize = True
        Me.Company.BackColor = System.Drawing.Color.White
        Me.Company.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Company.Location = New System.Drawing.Point(16, 67)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(170, 29)
        Me.Company.TabIndex = 89
        Me.Company.Text = "Study Zone N"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.White
        Me.Logo.Image = Global.WindowsApp1.My.Resources.Resources.logo1
        Me.Logo.Location = New System.Drawing.Point(63, 12)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(78, 52)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 88
        Me.Logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 395)
        Me.Panel1.TabIndex = 87
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.StaffToolStripMenuItem, Me.PatientsToolStripMenuItem, Me.RegisterPatientToolStripMenuItem, Me.RegisterStaffToolStripMenuItem, Me.BookAppointmentToolStripMenuItem, Me.ManageResultToolStripMenuItem, Me.ManageTimeTableToolStripMenuItem, Me.RegisterEmployeesToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(213, 296)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ProfileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'PatientsToolStripMenuItem
        '
        Me.PatientsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PatientsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem"
        Me.PatientsToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.PatientsToolStripMenuItem.Text = "Students"
        '
        'RegisterPatientToolStripMenuItem
        '
        Me.RegisterPatientToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.RegisterPatientToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterPatientToolStripMenuItem.Name = "RegisterPatientToolStripMenuItem"
        Me.RegisterPatientToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.RegisterPatientToolStripMenuItem.Text = "Register Student"
        '
        'RegisterStaffToolStripMenuItem
        '
        Me.RegisterStaffToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RegisterStaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterStaffToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RegisterStaffToolStripMenuItem.Name = "RegisterStaffToolStripMenuItem"
        Me.RegisterStaffToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.RegisterStaffToolStripMenuItem.Text = "Assign Courses"
        '
        'BookAppointmentToolStripMenuItem
        '
        Me.BookAppointmentToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.BookAppointmentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookAppointmentToolStripMenuItem.Name = "BookAppointmentToolStripMenuItem"
        Me.BookAppointmentToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.BookAppointmentToolStripMenuItem.Text = "Staff Appointment"
        '
        'ManageResultToolStripMenuItem
        '
        Me.ManageResultToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageResultToolStripMenuItem.Name = "ManageResultToolStripMenuItem"
        Me.ManageResultToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.ManageResultToolStripMenuItem.Text = "Manage Result"
        '
        'ManageTimeTableToolStripMenuItem
        '
        Me.ManageTimeTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageTimeTableToolStripMenuItem.Name = "ManageTimeTableToolStripMenuItem"
        Me.ManageTimeTableToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.ManageTimeTableToolStripMenuItem.Text = "Manage Time Table"
        '
        'RegisterEmployeesToolStripMenuItem
        '
        Me.RegisterEmployeesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterEmployeesToolStripMenuItem.Name = "RegisterEmployeesToolStripMenuItem"
        Me.RegisterEmployeesToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.RegisterEmployeesToolStripMenuItem.Text = "Log Out"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.PRole)
        Me.Controls.Add(Me.PName)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TeacherSelection)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.TeacherSelection.ResumeLayout(False)
        Me.TeacherSelection.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TeacherList As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TeacherSelection As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PRole As Label
    Friend WithEvents PName As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Company As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageTimeTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterEmployeesToolStripMenuItem As ToolStripMenuItem
End Class
