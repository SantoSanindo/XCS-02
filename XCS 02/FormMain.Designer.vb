<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_currentref = New System.Windows.Forms.Label()
        Me.lbl_wocounter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Msg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_msg = New System.Windows.Forms.Label()
        Me.Ethernet = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_localhostname = New System.Windows.Forms.Label()
        Me.lbl_localip = New System.Windows.Forms.Label()
        Me.lbl_plcip = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CMD_Read_Inputs = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_currcounter = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cmd_quit = New System.Windows.Forms.Button()
        Me.cmd_material = New System.Windows.Forms.Button()
        Me.cmd_database = New System.Windows.Forms.Button()
        Me.Cmd_CS = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RFID_Comm = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ethernet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Work Order Reference :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(66, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Work Order Qty :"
        '
        'lbl_currentref
        '
        Me.lbl_currentref.AutoSize = True
        Me.lbl_currentref.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentref.Location = New System.Drawing.Point(214, 17)
        Me.lbl_currentref.Name = "lbl_currentref"
        Me.lbl_currentref.Size = New System.Drawing.Size(63, 20)
        Me.lbl_currentref.TabIndex = 2
        Me.lbl_currentref.Text = "Label3"
        '
        'lbl_wocounter
        '
        Me.lbl_wocounter.AutoSize = True
        Me.lbl_wocounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wocounter.Location = New System.Drawing.Point(214, 37)
        Me.lbl_wocounter.Name = "lbl_wocounter"
        Me.lbl_wocounter.Size = New System.Drawing.Size(63, 20)
        Me.lbl_wocounter.TabIndex = 3
        Me.lbl_wocounter.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(559, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 73)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SC"
        '
        'Image1
        '
        Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image1.Location = New System.Drawing.Point(35, 25)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(100, 92)
        Me.Image1.TabIndex = 5
        Me.Image1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(172, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Press Output :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(197, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 55)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_wocounter)
        Me.GroupBox1.Controls.Add(Me.lbl_currentref)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "System Information"
        '
        'Txt_Msg
        '
        Me.Txt_Msg.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Msg.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Txt_Msg.Location = New System.Drawing.Point(35, 177)
        Me.Txt_Msg.Multiline = True
        Me.Txt_Msg.Name = "Txt_Msg"
        Me.Txt_Msg.Size = New System.Drawing.Size(314, 143)
        Me.Txt_Msg.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Operator Instruction's"
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = True
        Me.lbl_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.Red
        Me.lbl_msg.Location = New System.Drawing.Point(31, 353)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(143, 20)
        Me.lbl_msg.TabIndex = 12
        Me.lbl_msg.Text = "Please load head..."
        '
        'Ethernet
        '
        Me.Ethernet.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Ethernet.Location = New System.Drawing.Point(9, 24)
        Me.Ethernet.Name = "Ethernet"
        Me.Ethernet.Size = New System.Drawing.Size(20, 15)
        Me.Ethernet.TabIndex = 13
        Me.Ethernet.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(35, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Connect"
        '
        'lbl_localhostname
        '
        Me.lbl_localhostname.AutoSize = True
        Me.lbl_localhostname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localhostname.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_localhostname.Location = New System.Drawing.Point(6, 42)
        Me.lbl_localhostname.Name = "lbl_localhostname"
        Me.lbl_localhostname.Size = New System.Drawing.Size(37, 15)
        Me.lbl_localhostname.TabIndex = 14
        Me.lbl_localhostname.Text = "Label"
        '
        'lbl_localip
        '
        Me.lbl_localip.AutoSize = True
        Me.lbl_localip.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localip.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_localip.Location = New System.Drawing.Point(6, 57)
        Me.lbl_localip.Name = "lbl_localip"
        Me.lbl_localip.Size = New System.Drawing.Size(37, 15)
        Me.lbl_localip.TabIndex = 15
        Me.lbl_localip.Text = "Label"
        '
        'lbl_plcip
        '
        Me.lbl_plcip.AutoSize = True
        Me.lbl_plcip.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plcip.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_plcip.Location = New System.Drawing.Point(6, 72)
        Me.lbl_plcip.Name = "lbl_plcip"
        Me.lbl_plcip.Size = New System.Drawing.Size(182, 15)
        Me.lbl_plcip.TabIndex = 16
        Me.lbl_plcip.Text = "PLC IP Address : 126.254.108.2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_plcip)
        Me.GroupBox2.Controls.Add(Me.lbl_localip)
        Me.GroupBox2.Controls.Add(Me.lbl_localhostname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Ethernet)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(35, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 100)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ethernet Connection"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'CMD_Read_Inputs
        '
        Me.CMD_Read_Inputs.Location = New System.Drawing.Point(318, 399)
        Me.CMD_Read_Inputs.Name = "CMD_Read_Inputs"
        Me.CMD_Read_Inputs.Size = New System.Drawing.Size(44, 50)
        Me.CMD_Read_Inputs.TabIndex = 20
        Me.CMD_Read_Inputs.Text = "Read PLC"
        Me.CMD_Read_Inputs.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(255, 464)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "%MW101 -"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(318, 461)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(44, 20)
        Me.TextBox2.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.CMD_Read_Inputs)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.lbl_msg)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Txt_Msg)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Image1)
        Me.GroupBox3.Location = New System.Drawing.Point(42, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 512)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'lbl_currcounter
        '
        Me.lbl_currcounter.AutoSize = True
        Me.lbl_currcounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currcounter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_currcounter.Location = New System.Drawing.Point(484, 200)
        Me.lbl_currcounter.Name = "lbl_currcounter"
        Me.lbl_currcounter.Size = New System.Drawing.Size(52, 55)
        Me.lbl_currcounter.TabIndex = 25
        Me.lbl_currcounter.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label15.Location = New System.Drawing.Point(459, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 20)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Head Tester Output"
        '
        'Timer2
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(453, 262)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(335, 388)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'cmd_quit
        '
        Me.cmd_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_quit.Image = CType(resources.GetObject("cmd_quit.Image"), System.Drawing.Image)
        Me.cmd_quit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_quit.Location = New System.Drawing.Point(41, 32)
        Me.cmd_quit.Name = "cmd_quit"
        Me.cmd_quit.Size = New System.Drawing.Size(86, 58)
        Me.cmd_quit.TabIndex = 30
        Me.cmd_quit.Text = "   Quit"
        Me.cmd_quit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_quit.UseVisualStyleBackColor = True
        '
        'cmd_material
        '
        Me.cmd_material.Image = CType(resources.GetObject("cmd_material.Image"), System.Drawing.Image)
        Me.cmd_material.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_material.Location = New System.Drawing.Point(41, 110)
        Me.cmd_material.Name = "cmd_material"
        Me.cmd_material.Size = New System.Drawing.Size(86, 58)
        Me.cmd_material.TabIndex = 31
        Me.cmd_material.Text = "Rack"
        Me.cmd_material.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_material.UseVisualStyleBackColor = True
        '
        'cmd_database
        '
        Me.cmd_database.Image = CType(resources.GetObject("cmd_database.Image"), System.Drawing.Image)
        Me.cmd_database.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_database.Location = New System.Drawing.Point(41, 193)
        Me.cmd_database.Name = "cmd_database"
        Me.cmd_database.Size = New System.Drawing.Size(86, 62)
        Me.cmd_database.TabIndex = 32
        Me.cmd_database.Text = "Material"
        Me.cmd_database.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_database.UseVisualStyleBackColor = True
        '
        'Cmd_CS
        '
        Me.Cmd_CS.Image = CType(resources.GetObject("Cmd_CS.Image"), System.Drawing.Image)
        Me.Cmd_CS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cmd_CS.Location = New System.Drawing.Point(41, 285)
        Me.Cmd_CS.Name = "Cmd_CS"
        Me.Cmd_CS.Size = New System.Drawing.Size(86, 68)
        Me.Cmd_CS.TabIndex = 33
        Me.Cmd_CS.Text = "Change Series"
        Me.Cmd_CS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_CS.UseVisualStyleBackColor = True
        '
        'Command1
        '
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.Location = New System.Drawing.Point(41, 515)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(86, 68)
        Me.Command1.TabIndex = 34
        Me.Command1.Text = "Eye Open"
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Command1)
        Me.GroupBox4.Controls.Add(Me.Cmd_CS)
        Me.GroupBox4.Controls.Add(Me.cmd_database)
        Me.GroupBox4.Controls.Add(Me.cmd_material)
        Me.GroupBox4.Controls.Add(Me.cmd_quit)
        Me.GroupBox4.Location = New System.Drawing.Point(814, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(155, 620)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 681)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_currcounter)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormMain"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ethernet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_currentref As Label
    Friend WithEvents lbl_wocounter As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Image1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Msg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_msg As Label
    Friend WithEvents Ethernet As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_localhostname As Label
    Friend WithEvents lbl_localip As Label
    Friend WithEvents lbl_plcip As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CMD_Read_Inputs As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_currcounter As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cmd_quit As Button
    Friend WithEvents cmd_material As Button
    Friend WithEvents cmd_database As Button
    Friend WithEvents Cmd_CS As Button
    Friend WithEvents Command1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RFID_Comm As IO.Ports.SerialPort
End Class
