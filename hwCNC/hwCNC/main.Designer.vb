<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_ConnectToSelectedPort = New System.Windows.Forms.Button()
        Me.lb_serialOutput = New System.Windows.Forms.ListBox()
        Me.cb_COMPort = New System.Windows.Forms.ComboBox()
        Me.btn_RefreshCOMPort = New System.Windows.Forms.Button()
        Me.btn_moveXplus = New System.Windows.Forms.Button()
        Me.btn_moveXminus = New System.Windows.Forms.Button()
        Me.btn_moveYminus = New System.Windows.Forms.Button()
        Me.btn_moveYplus = New System.Windows.Forms.Button()
        Me.chkb_FastMovement = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_ActPosX = New System.Windows.Forms.TextBox()
        Me.tb_ActPosY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_DoHoming = New System.Windows.Forms.Button()
        Me.btn_CloseComPort = New System.Windows.Forms.Button()
        Me.btn_getMachineConfig = New System.Windows.Forms.Button()
        Me.tb_single_command = New System.Windows.Forms.TextBox()
        Me.btn_sendSingleCommand = New System.Windows.Forms.Button()
        Me.tb_serialOutput = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_G999 = New System.Windows.Forms.Button()
        Me.btn_moveX10 = New System.Windows.Forms.Button()
        Me.btn_moveX100Y200 = New System.Windows.Forms.Button()
        Me.tb_GCodeProgramm = New System.Windows.Forms.TextBox()
        Me.btn_tmpbutton = New System.Windows.Forms.Button()
        Me.btn_sendProgramm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ConnectToSelectedPort
        '
        Me.btn_ConnectToSelectedPort.Location = New System.Drawing.Point(13, 38)
        Me.btn_ConnectToSelectedPort.Name = "btn_ConnectToSelectedPort"
        Me.btn_ConnectToSelectedPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_ConnectToSelectedPort.TabIndex = 0
        Me.btn_ConnectToSelectedPort.Text = "connect"
        Me.btn_ConnectToSelectedPort.UseVisualStyleBackColor = True
        '
        'lb_serialOutput
        '
        Me.lb_serialOutput.FormattingEnabled = True
        Me.lb_serialOutput.Location = New System.Drawing.Point(610, 292)
        Me.lb_serialOutput.Name = "lb_serialOutput"
        Me.lb_serialOutput.Size = New System.Drawing.Size(366, 251)
        Me.lb_serialOutput.TabIndex = 1
        '
        'cb_COMPort
        '
        Me.cb_COMPort.FormattingEnabled = True
        Me.cb_COMPort.Location = New System.Drawing.Point(94, 9)
        Me.cb_COMPort.Name = "cb_COMPort"
        Me.cb_COMPort.Size = New System.Drawing.Size(121, 21)
        Me.cb_COMPort.TabIndex = 2
        '
        'btn_RefreshCOMPort
        '
        Me.btn_RefreshCOMPort.Location = New System.Drawing.Point(13, 9)
        Me.btn_RefreshCOMPort.Name = "btn_RefreshCOMPort"
        Me.btn_RefreshCOMPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_RefreshCOMPort.TabIndex = 3
        Me.btn_RefreshCOMPort.Text = "refresh"
        Me.btn_RefreshCOMPort.UseVisualStyleBackColor = True
        '
        'btn_moveXplus
        '
        Me.btn_moveXplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXplus.Location = New System.Drawing.Point(559, 21)
        Me.btn_moveXplus.Name = "btn_moveXplus"
        Me.btn_moveXplus.Size = New System.Drawing.Size(45, 40)
        Me.btn_moveXplus.TabIndex = 4
        Me.btn_moveXplus.Text = "X +"
        Me.btn_moveXplus.UseVisualStyleBackColor = True
        '
        'btn_moveXminus
        '
        Me.btn_moveXminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXminus.Location = New System.Drawing.Point(508, 21)
        Me.btn_moveXminus.Name = "btn_moveXminus"
        Me.btn_moveXminus.Size = New System.Drawing.Size(45, 40)
        Me.btn_moveXminus.TabIndex = 5
        Me.btn_moveXminus.Text = "X -"
        Me.btn_moveXminus.UseVisualStyleBackColor = True
        '
        'btn_moveYminus
        '
        Me.btn_moveYminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYminus.Location = New System.Drawing.Point(508, 67)
        Me.btn_moveYminus.Name = "btn_moveYminus"
        Me.btn_moveYminus.Size = New System.Drawing.Size(45, 40)
        Me.btn_moveYminus.TabIndex = 7
        Me.btn_moveYminus.Text = "Y -"
        Me.btn_moveYminus.UseVisualStyleBackColor = True
        '
        'btn_moveYplus
        '
        Me.btn_moveYplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYplus.Location = New System.Drawing.Point(559, 67)
        Me.btn_moveYplus.Name = "btn_moveYplus"
        Me.btn_moveYplus.Size = New System.Drawing.Size(45, 40)
        Me.btn_moveYplus.TabIndex = 6
        Me.btn_moveYplus.Text = "Y +"
        Me.btn_moveYplus.UseVisualStyleBackColor = True
        '
        'chkb_FastMovement
        '
        Me.chkb_FastMovement.AutoSize = True
        Me.chkb_FastMovement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_FastMovement.Location = New System.Drawing.Point(517, 113)
        Me.chkb_FastMovement.Name = "chkb_FastMovement"
        Me.chkb_FastMovement.Size = New System.Drawing.Size(77, 20)
        Me.chkb_FastMovement.TabIndex = 8
        Me.chkb_FastMovement.Text = "RAPID!"
        Me.chkb_FastMovement.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 54)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X:"
        '
        'tb_ActPosX
        '
        Me.tb_ActPosX.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold)
        Me.tb_ActPosX.Location = New System.Drawing.Point(72, 13)
        Me.tb_ActPosX.Name = "tb_ActPosX"
        Me.tb_ActPosX.Size = New System.Drawing.Size(170, 62)
        Me.tb_ActPosX.TabIndex = 10
        '
        'tb_ActPosY
        '
        Me.tb_ActPosY.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold)
        Me.tb_ActPosY.Location = New System.Drawing.Point(72, 81)
        Me.tb_ActPosY.Name = "tb_ActPosY"
        Me.tb_ActPosY.Size = New System.Drawing.Size(170, 62)
        Me.tb_ActPosY.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 54)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Y:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_ActPosY)
        Me.GroupBox1.Controls.Add(Me.tb_ActPosX)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 154)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position"
        '
        'btn_DoHoming
        '
        Me.btn_DoHoming.Location = New System.Drawing.Point(13, 181)
        Me.btn_DoHoming.Name = "btn_DoHoming"
        Me.btn_DoHoming.Size = New System.Drawing.Size(76, 56)
        Me.btn_DoHoming.TabIndex = 14
        Me.btn_DoHoming.Text = "Go home!"
        Me.btn_DoHoming.UseVisualStyleBackColor = True
        '
        'btn_CloseComPort
        '
        Me.btn_CloseComPort.Location = New System.Drawing.Point(13, 67)
        Me.btn_CloseComPort.Name = "btn_CloseComPort"
        Me.btn_CloseComPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_CloseComPort.TabIndex = 16
        Me.btn_CloseComPort.Text = "disconnect"
        Me.btn_CloseComPort.UseVisualStyleBackColor = True
        '
        'btn_getMachineConfig
        '
        Me.btn_getMachineConfig.Location = New System.Drawing.Point(13, 126)
        Me.btn_getMachineConfig.Name = "btn_getMachineConfig"
        Me.btn_getMachineConfig.Size = New System.Drawing.Size(76, 49)
        Me.btn_getMachineConfig.TabIndex = 17
        Me.btn_getMachineConfig.Text = "get Config from machine"
        Me.btn_getMachineConfig.UseVisualStyleBackColor = True
        '
        'tb_single_command
        '
        Me.tb_single_command.Location = New System.Drawing.Point(12, 492)
        Me.tb_single_command.Name = "tb_single_command"
        Me.tb_single_command.Size = New System.Drawing.Size(138, 20)
        Me.tb_single_command.TabIndex = 21
        '
        'btn_sendSingleCommand
        '
        Me.btn_sendSingleCommand.Location = New System.Drawing.Point(159, 492)
        Me.btn_sendSingleCommand.Name = "btn_sendSingleCommand"
        Me.btn_sendSingleCommand.Size = New System.Drawing.Size(72, 23)
        Me.btn_sendSingleCommand.TabIndex = 22
        Me.btn_sendSingleCommand.Text = "senden"
        Me.btn_sendSingleCommand.UseVisualStyleBackColor = True
        '
        'tb_serialOutput
        '
        Me.tb_serialOutput.Location = New System.Drawing.Point(610, 12)
        Me.tb_serialOutput.Multiline = True
        Me.tb_serialOutput.Name = "tb_serialOutput"
        Me.tb_serialOutput.Size = New System.Drawing.Size(366, 252)
        Me.tb_serialOutput.TabIndex = 23
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 518)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(507, 20)
        Me.TextBox3.TabIndex = 24
        '
        'btn_G999
        '
        Me.btn_G999.Location = New System.Drawing.Point(159, 318)
        Me.btn_G999.Name = "btn_G999"
        Me.btn_G999.Size = New System.Drawing.Size(129, 23)
        Me.btn_G999.TabIndex = 25
        Me.btn_G999.Text = "G999;"
        Me.btn_G999.UseVisualStyleBackColor = True
        '
        'btn_moveX10
        '
        Me.btn_moveX10.Location = New System.Drawing.Point(159, 348)
        Me.btn_moveX10.Name = "btn_moveX10"
        Me.btn_moveX10.Size = New System.Drawing.Size(129, 23)
        Me.btn_moveX10.TabIndex = 26
        Me.btn_moveX10.Text = "G1 X10 Y0 F500;"
        Me.btn_moveX10.UseVisualStyleBackColor = True
        '
        'btn_moveX100Y200
        '
        Me.btn_moveX100Y200.Location = New System.Drawing.Point(159, 377)
        Me.btn_moveX100Y200.Name = "btn_moveX100Y200"
        Me.btn_moveX100Y200.Size = New System.Drawing.Size(129, 23)
        Me.btn_moveX100Y200.TabIndex = 27
        Me.btn_moveX100Y200.Text = "G1 X100 Y200F300;"
        Me.btn_moveX100Y200.UseVisualStyleBackColor = True
        '
        'tb_GCodeProgramm
        '
        Me.tb_GCodeProgramm.Location = New System.Drawing.Point(1034, 59)
        Me.tb_GCodeProgramm.Multiline = True
        Me.tb_GCodeProgramm.Name = "tb_GCodeProgramm"
        Me.tb_GCodeProgramm.Size = New System.Drawing.Size(225, 323)
        Me.tb_GCodeProgramm.TabIndex = 28
        Me.tb_GCodeProgramm.Text = "G1 X1 Y0 F200;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X2 Y30;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X3 Y40;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M30;"
        '
        'btn_tmpbutton
        '
        Me.btn_tmpbutton.Location = New System.Drawing.Point(1184, 12)
        Me.btn_tmpbutton.Name = "btn_tmpbutton"
        Me.btn_tmpbutton.Size = New System.Drawing.Size(75, 41)
        Me.btn_tmpbutton.TabIndex = 29
        Me.btn_tmpbutton.Text = "Button1"
        Me.btn_tmpbutton.UseVisualStyleBackColor = True
        '
        'btn_sendProgramm
        '
        Me.btn_sendProgramm.Location = New System.Drawing.Point(1155, 388)
        Me.btn_sendProgramm.Name = "btn_sendProgramm"
        Me.btn_sendProgramm.Size = New System.Drawing.Size(104, 30)
        Me.btn_sendProgramm.TabIndex = 30
        Me.btn_sendProgramm.Text = "send programm"
        Me.btn_sendProgramm.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 555)
        Me.Controls.Add(Me.btn_sendProgramm)
        Me.Controls.Add(Me.btn_tmpbutton)
        Me.Controls.Add(Me.tb_GCodeProgramm)
        Me.Controls.Add(Me.btn_moveX100Y200)
        Me.Controls.Add(Me.btn_moveX10)
        Me.Controls.Add(Me.btn_G999)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tb_serialOutput)
        Me.Controls.Add(Me.btn_sendSingleCommand)
        Me.Controls.Add(Me.tb_single_command)
        Me.Controls.Add(Me.btn_getMachineConfig)
        Me.Controls.Add(Me.btn_CloseComPort)
        Me.Controls.Add(Me.btn_DoHoming)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkb_FastMovement)
        Me.Controls.Add(Me.btn_moveYminus)
        Me.Controls.Add(Me.btn_moveYplus)
        Me.Controls.Add(Me.btn_moveXminus)
        Me.Controls.Add(Me.btn_moveXplus)
        Me.Controls.Add(Me.btn_RefreshCOMPort)
        Me.Controls.Add(Me.cb_COMPort)
        Me.Controls.Add(Me.lb_serialOutput)
        Me.Controls.Add(Me.btn_ConnectToSelectedPort)
        Me.Name = "main"
        Me.Text = "hwCNC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ConnectToSelectedPort As System.Windows.Forms.Button
    Friend WithEvents lb_serialOutput As System.Windows.Forms.ListBox
    Friend WithEvents cb_COMPort As System.Windows.Forms.ComboBox
    Friend WithEvents btn_RefreshCOMPort As System.Windows.Forms.Button
    Friend WithEvents btn_moveXplus As System.Windows.Forms.Button
    Friend WithEvents btn_moveXminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveYminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveYplus As System.Windows.Forms.Button
    Friend WithEvents chkb_FastMovement As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_ActPosX As System.Windows.Forms.TextBox
    Friend WithEvents tb_ActPosY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_DoHoming As System.Windows.Forms.Button
    Friend WithEvents btn_CloseComPort As System.Windows.Forms.Button
    Friend WithEvents btn_getMachineConfig As System.Windows.Forms.Button
    Friend WithEvents tb_single_command As System.Windows.Forms.TextBox
    Friend WithEvents btn_sendSingleCommand As System.Windows.Forms.Button
    Friend WithEvents tb_serialOutput As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_G999 As System.Windows.Forms.Button
    Friend WithEvents btn_moveX10 As System.Windows.Forms.Button
    Friend WithEvents btn_moveX100Y200 As System.Windows.Forms.Button
    Friend WithEvents tb_GCodeProgramm As System.Windows.Forms.TextBox
    Friend WithEvents btn_tmpbutton As System.Windows.Forms.Button
    Friend WithEvents btn_sendProgramm As System.Windows.Forms.Button

End Class
