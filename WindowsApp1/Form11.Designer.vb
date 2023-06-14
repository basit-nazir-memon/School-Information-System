<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GradeForm = New System.Windows.Forms.Panel()
        Me.Error1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GradeSelector = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Error2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradeForm.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(250, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 37)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Result Management"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(257, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(978, 557)
        Me.DataGridView1.TabIndex = 140
        Me.DataGridView1.Visible = False
        '
        'GradeForm
        '
        Me.GradeForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.GradeForm.Controls.Add(Me.Error1)
        Me.GradeForm.Controls.Add(Me.Label5)
        Me.GradeForm.Controls.Add(Me.GradeSelector)
        Me.GradeForm.Controls.Add(Me.Button1)
        Me.GradeForm.Location = New System.Drawing.Point(542, 191)
        Me.GradeForm.Name = "GradeForm"
        Me.GradeForm.Size = New System.Drawing.Size(475, 357)
        Me.GradeForm.TabIndex = 141
        '
        'Error1
        '
        Me.Error1.AutoSize = True
        Me.Error1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Error1.ForeColor = System.Drawing.Color.Red
        Me.Error1.Location = New System.Drawing.Point(31, 135)
        Me.Error1.Name = "Error1"
        Me.Error1.Size = New System.Drawing.Size(47, 18)
        Me.Error1.TabIndex = 87
        Me.Error1.Text = "Error"
        Me.Error1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 25)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Select Grade"
        '
        'GradeSelector
        '
        Me.GradeSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeSelector.FormattingEnabled = True
        Me.GradeSelector.Items.AddRange(New Object() {"Nursery", "Kinder Garden", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"})
        Me.GradeSelector.Location = New System.Drawing.Point(33, 101)
        Me.GradeSelector.Name = "GradeSelector"
        Me.GradeSelector.Size = New System.Drawing.Size(382, 30)
        Me.GradeSelector.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(13, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 58)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "View Result"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Error2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(539, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 357)
        Me.Panel2.TabIndex = 142
        Me.Panel2.Visible = False
        '
        'Error2
        '
        Me.Error2.AutoSize = True
        Me.Error2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Error2.ForeColor = System.Drawing.Color.Red
        Me.Error2.Location = New System.Drawing.Point(31, 135)
        Me.Error2.Name = "Error2"
        Me.Error2.Size = New System.Drawing.Size(47, 18)
        Me.Error2.TabIndex = 87
        Me.Error2.Text = "Error"
        Me.Error2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Select Subject"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"None", "Science", "Mathematics", "Urdu", "Sindhi", "English", "Chemistry", "Biology", "Physics", "Computer Science", "Islamiyat", "Pakistan Studies"})
        Me.ComboBox1.Location = New System.Drawing.Point(33, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(382, 30)
        Me.ComboBox1.TabIndex = 82
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(13, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(428, 58)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "View Result"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PRole
        '
        Me.PRole.AutoSize = True
        Me.PRole.BackColor = System.Drawing.Color.Transparent
        Me.PRole.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRole.Location = New System.Drawing.Point(112, 153)
        Me.PRole.Name = "PRole"
        Me.PRole.Size = New System.Drawing.Size(67, 24)
        Me.PRole.TabIndex = 93
        Me.PRole.Text = "Admin"
        '
        'PName
        '
        Me.PName.AutoSize = True
        Me.PName.BackColor = System.Drawing.Color.Transparent
        Me.PName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PName.Location = New System.Drawing.Point(87, 119)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(121, 27)
        Me.PName.TabIndex = 92
        Me.PName.Text = "Basit Nazir"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.frame
        Me.PictureBox3.Location = New System.Drawing.Point(0, 102)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(86, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 91
        Me.PictureBox3.TabStop = False
        '
        'Company
        '
        Me.Company.AutoSize = True
        Me.Company.BackColor = System.Drawing.Color.White
        Me.Company.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Company.Location = New System.Drawing.Point(17, 67)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(170, 29)
        Me.Company.TabIndex = 90
        Me.Company.Text = "Study Zone N"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.White
        Me.Logo.Image = Global.WindowsApp1.My.Resources.Resources.logo1
        Me.Logo.Location = New System.Drawing.Point(64, 12)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(78, 52)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 89
        Me.Logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 395)
        Me.Panel1.TabIndex = 88
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
        Me.RegisterStaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ManageResultToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ManageResultToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageResultToolStripMenuItem.ForeColor = System.Drawing.Color.White
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
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Panel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 674)
        Me.Controls.Add(Me.PRole)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PName)
        Me.Controls.Add(Me.GradeForm)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradeForm.ResumeLayout(False)
        Me.GradeForm.PerformLayout()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GradeForm As Panel
    Friend WithEvents Error1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GradeSelector As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Error2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
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
