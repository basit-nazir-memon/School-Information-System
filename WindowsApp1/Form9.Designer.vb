<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 37)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "TimeTable Management"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(249, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(985, 560)
        Me.DataGridView1.TabIndex = 91
        '
        'PRole
        '
        Me.PRole.AutoSize = True
        Me.PRole.BackColor = System.Drawing.Color.Transparent
        Me.PRole.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRole.Location = New System.Drawing.Point(108, 150)
        Me.PRole.Name = "PRole"
        Me.PRole.Size = New System.Drawing.Size(67, 24)
        Me.PRole.TabIndex = 97
        Me.PRole.Text = "Admin"
        '
        'PName
        '
        Me.PName.AutoSize = True
        Me.PName.BackColor = System.Drawing.Color.Transparent
        Me.PName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PName.Location = New System.Drawing.Point(83, 116)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(121, 27)
        Me.PName.TabIndex = 96
        Me.PName.Text = "Basit Nazir"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.frame
        Me.PictureBox3.Location = New System.Drawing.Point(-4, 99)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(86, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 95
        Me.PictureBox3.TabStop = False
        '
        'Company
        '
        Me.Company.AutoSize = True
        Me.Company.BackColor = System.Drawing.Color.White
        Me.Company.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Company.Location = New System.Drawing.Point(13, 64)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(170, 29)
        Me.Company.TabIndex = 94
        Me.Company.Text = "Study Zone N"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.White
        Me.Logo.Image = Global.WindowsApp1.My.Resources.Resources.logo1
        Me.Logo.Location = New System.Drawing.Point(60, 9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(78, 52)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 93
        Me.Logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-1, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 395)
        Me.Panel1.TabIndex = 92
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
        Me.ManageResultToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageResultToolStripMenuItem.Name = "ManageResultToolStripMenuItem"
        Me.ManageResultToolStripMenuItem.Size = New System.Drawing.Size(206, 29)
        Me.ManageResultToolStripMenuItem.Text = "Manage Result"
        '
        'ManageTimeTableToolStripMenuItem
        '
        Me.ManageTimeTableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ManageTimeTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageTimeTableToolStripMenuItem.ForeColor = System.Drawing.Color.White
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
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Panel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 674)
        Me.Controls.Add(Me.PRole)
        Me.Controls.Add(Me.PName)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
