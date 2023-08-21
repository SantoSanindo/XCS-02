<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModbus
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboRegType = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtNewValue = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server IP : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port :"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(130, 46)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(100, 20)
        Me.txtIP.TabIndex = 2
        Me.txtIP.Text = "127.0.0.1"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(294, 46)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "502"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(55, 84)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(118, 42)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(276, 84)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(118, 42)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Red
        Me.lbl_status.Location = New System.Drawing.Point(126, 129)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(116, 20)
        Me.lbl_status.TabIndex = 6
        Me.lbl_status.Text = "Not Connected"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Reg Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Value :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "New Value :"
        '
        'cboRegType
        '
        Me.cboRegType.BackColor = System.Drawing.SystemColors.Window
        Me.cboRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegType.DropDownWidth = 230
        Me.cboRegType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegType.FormattingEnabled = True
        Me.cboRegType.ItemHeight = 18
        Me.cboRegType.Items.AddRange(New Object() {"Coil Outputs      (00000)", "Digital Inputs    (10000)", "Analogue Inputs   (30000)", "Holding Registers (40000)"})
        Me.cboRegType.Location = New System.Drawing.Point(130, 156)
        Me.cboRegType.Name = "cboRegType"
        Me.cboRegType.Size = New System.Drawing.Size(128, 26)
        Me.cboRegType.TabIndex = 20
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(130, 188)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 12
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(130, 219)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 13
        '
        'txtNewValue
        '
        Me.txtNewValue.Location = New System.Drawing.Point(130, 250)
        Me.txtNewValue.Name = "txtNewValue"
        Me.txtNewValue.Size = New System.Drawing.Size(100, 20)
        Me.txtNewValue.TabIndex = 14
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(283, 156)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(111, 50)
        Me.btnRead.TabIndex = 15
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(283, 219)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(111, 51)
        Me.btnWrite.TabIndex = 16
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(423, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 70)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FormModbus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 290)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtNewValue)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.cboRegType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormModbus"
        Me.Text = "FormModbus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents lbl_status As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboRegType As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtNewValue As TextBox
    Friend WithEvents btnRead As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents Button5 As Button
End Class
