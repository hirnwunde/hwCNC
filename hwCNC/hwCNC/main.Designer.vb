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
        Me.btn_G999 = New System.Windows.Forms.Button()
        Me.btn_moveX10 = New System.Windows.Forms.Button()
        Me.btn_moveX100Y200 = New System.Windows.Forms.Button()
        Me.tb_GCodeProgramm = New System.Windows.Forms.TextBox()
        Me.btn_tmpbutton = New System.Windows.Forms.Button()
        Me.btn_sendProgram = New System.Windows.Forms.Button()
        Me.btn_loadProgram = New System.Windows.Forms.Button()
        Me.ofd_GCODE = New System.Windows.Forms.OpenFileDialog()
        Me.btn_MoreOrLess = New System.Windows.Forms.Button()
        Me.btn_cleanGCode = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ConnectToSelectedPort
        '
        Me.btn_ConnectToSelectedPort.Location = New System.Drawing.Point(12, 67)
        Me.btn_ConnectToSelectedPort.Name = "btn_ConnectToSelectedPort"
        Me.btn_ConnectToSelectedPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_ConnectToSelectedPort.TabIndex = 0
        Me.btn_ConnectToSelectedPort.Text = "connect"
        Me.btn_ConnectToSelectedPort.UseVisualStyleBackColor = True
        '
        'lb_serialOutput
        '
        Me.lb_serialOutput.FormattingEnabled = True
        Me.lb_serialOutput.Location = New System.Drawing.Point(597, 252)
        Me.lb_serialOutput.Name = "lb_serialOutput"
        Me.lb_serialOutput.Size = New System.Drawing.Size(366, 238)
        Me.lb_serialOutput.TabIndex = 1
        '
        'cb_COMPort
        '
        Me.cb_COMPort.FormattingEnabled = True
        Me.cb_COMPort.Location = New System.Drawing.Point(13, 38)
        Me.cb_COMPort.Name = "cb_COMPort"
        Me.cb_COMPort.Size = New System.Drawing.Size(75, 21)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X:"
        '
        'tb_ActPosX
        '
        Me.tb_ActPosX.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ActPosX.Location = New System.Drawing.Point(61, 13)
        Me.tb_ActPosX.Name = "tb_ActPosX"
        Me.tb_ActPosX.Size = New System.Drawing.Size(97, 44)
        Me.tb_ActPosX.TabIndex = 10
        '
        'tb_ActPosY
        '
        Me.tb_ActPosY.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ActPosY.Location = New System.Drawing.Point(62, 68)
        Me.tb_ActPosY.Name = "tb_ActPosY"
        Me.tb_ActPosY.Size = New System.Drawing.Size(96, 44)
        Me.tb_ActPosY.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Y:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_ActPosY)
        Me.GroupBox1.Controls.Add(Me.tb_ActPosX)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 123)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position"
        '
        'btn_DoHoming
        '
        Me.btn_DoHoming.Location = New System.Drawing.Point(12, 180)
        Me.btn_DoHoming.Name = "btn_DoHoming"
        Me.btn_DoHoming.Size = New System.Drawing.Size(75, 56)
        Me.btn_DoHoming.TabIndex = 14
        Me.btn_DoHoming.Text = "Go home!"
        Me.btn_DoHoming.UseVisualStyleBackColor = True
        '
        'btn_CloseComPort
        '
        Me.btn_CloseComPort.Location = New System.Drawing.Point(12, 96)
        Me.btn_CloseComPort.Name = "btn_CloseComPort"
        Me.btn_CloseComPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_CloseComPort.TabIndex = 16
        Me.btn_CloseComPort.Text = "disconnect"
        Me.btn_CloseComPort.UseVisualStyleBackColor = True
        '
        'btn_getMachineConfig
        '
        Me.btn_getMachineConfig.Location = New System.Drawing.Point(12, 125)
        Me.btn_getMachineConfig.Name = "btn_getMachineConfig"
        Me.btn_getMachineConfig.Size = New System.Drawing.Size(75, 49)
        Me.btn_getMachineConfig.TabIndex = 17
        Me.btn_getMachineConfig.Text = "get Config from machine"
        Me.btn_getMachineConfig.UseVisualStyleBackColor = True
        '
        'tb_single_command
        '
        Me.tb_single_command.Location = New System.Drawing.Point(12, 522)
        Me.tb_single_command.Name = "tb_single_command"
        Me.tb_single_command.Size = New System.Drawing.Size(170, 20)
        Me.tb_single_command.TabIndex = 21
        '
        'btn_sendSingleCommand
        '
        Me.btn_sendSingleCommand.Location = New System.Drawing.Point(188, 520)
        Me.btn_sendSingleCommand.Name = "btn_sendSingleCommand"
        Me.btn_sendSingleCommand.Size = New System.Drawing.Size(72, 23)
        Me.btn_sendSingleCommand.TabIndex = 22
        Me.btn_sendSingleCommand.Text = "senden"
        Me.btn_sendSingleCommand.UseVisualStyleBackColor = True
        '
        'tb_serialOutput
        '
        Me.tb_serialOutput.Location = New System.Drawing.Point(597, 11)
        Me.tb_serialOutput.Multiline = True
        Me.tb_serialOutput.Name = "tb_serialOutput"
        Me.tb_serialOutput.Size = New System.Drawing.Size(366, 235)
        Me.tb_serialOutput.TabIndex = 23
        '
        'btn_G999
        '
        Me.btn_G999.Location = New System.Drawing.Point(392, 407)
        Me.btn_G999.Name = "btn_G999"
        Me.btn_G999.Size = New System.Drawing.Size(129, 23)
        Me.btn_G999.TabIndex = 25
        Me.btn_G999.Text = "G999;"
        Me.btn_G999.UseVisualStyleBackColor = True
        '
        'btn_moveX10
        '
        Me.btn_moveX10.Location = New System.Drawing.Point(392, 437)
        Me.btn_moveX10.Name = "btn_moveX10"
        Me.btn_moveX10.Size = New System.Drawing.Size(129, 23)
        Me.btn_moveX10.TabIndex = 26
        Me.btn_moveX10.Text = "G1 X10 Y0 F500;"
        Me.btn_moveX10.UseVisualStyleBackColor = True
        '
        'btn_moveX100Y200
        '
        Me.btn_moveX100Y200.Location = New System.Drawing.Point(392, 466)
        Me.btn_moveX100Y200.Name = "btn_moveX100Y200"
        Me.btn_moveX100Y200.Size = New System.Drawing.Size(129, 23)
        Me.btn_moveX100Y200.TabIndex = 27
        Me.btn_moveX100Y200.Text = "G1 X100 Y200F300;"
        Me.btn_moveX100Y200.UseVisualStyleBackColor = True
        '
        'tb_GCodeProgramm
        '
        Me.tb_GCodeProgramm.Location = New System.Drawing.Point(350, 12)
        Me.tb_GCodeProgramm.Multiline = True
        Me.tb_GCodeProgramm.Name = "tb_GCodeProgramm"
        Me.tb_GCodeProgramm.Size = New System.Drawing.Size(225, 192)
        Me.tb_GCodeProgramm.TabIndex = 28
        Me.tb_GCodeProgramm.Text = "G1 X1 Y0 F200;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X2 Y30;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X3 Y40;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M30;"
        '
        'btn_tmpbutton
        '
        Me.btn_tmpbutton.Location = New System.Drawing.Point(888, 504)
        Me.btn_tmpbutton.Name = "btn_tmpbutton"
        Me.btn_tmpbutton.Size = New System.Drawing.Size(75, 41)
        Me.btn_tmpbutton.TabIndex = 29
        Me.btn_tmpbutton.Text = "Button1"
        Me.btn_tmpbutton.UseVisualStyleBackColor = True
        '
        'btn_sendProgram
        '
        Me.btn_sendProgram.Location = New System.Drawing.Point(490, 210)
        Me.btn_sendProgram.Name = "btn_sendProgram"
        Me.btn_sendProgram.Size = New System.Drawing.Size(83, 30)
        Me.btn_sendProgram.TabIndex = 30
        Me.btn_sendProgram.Text = "send program"
        Me.btn_sendProgram.UseVisualStyleBackColor = True
        '
        'btn_loadProgram
        '
        Me.btn_loadProgram.Location = New System.Drawing.Point(348, 210)
        Me.btn_loadProgram.Name = "btn_loadProgram"
        Me.btn_loadProgram.Size = New System.Drawing.Size(77, 30)
        Me.btn_loadProgram.TabIndex = 31
        Me.btn_loadProgram.Text = "load program"
        Me.btn_loadProgram.UseVisualStyleBackColor = True
        '
        'btn_MoreOrLess
        '
        Me.btn_MoreOrLess.Location = New System.Drawing.Point(500, 519)
        Me.btn_MoreOrLess.Name = "btn_MoreOrLess"
        Me.btn_MoreOrLess.Size = New System.Drawing.Size(75, 23)
        Me.btn_MoreOrLess.TabIndex = 33
        Me.btn_MoreOrLess.Text = "more >>>"
        Me.btn_MoreOrLess.UseVisualStyleBackColor = True
        '
        'btn_cleanGCode
        '
        Me.btn_cleanGCode.Location = New System.Drawing.Point(428, 214)
        Me.btn_cleanGCode.Name = "btn_cleanGCode"
        Me.btn_cleanGCode.Size = New System.Drawing.Size(56, 23)
        Me.btn_cleanGCode.TabIndex = 34
        Me.btn_cleanGCode.Text = "clean"
        Me.btn_cleanGCode.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 242)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 108)
        Me.ListBox1.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(350, 247)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 119)
        Me.TextBox1.TabIndex = 36
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 555)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_cleanGCode)
        Me.Controls.Add(Me.btn_MoreOrLess)
        Me.Controls.Add(Me.btn_loadProgram)
        Me.Controls.Add(Me.btn_sendProgram)
        Me.Controls.Add(Me.btn_tmpbutton)
        Me.Controls.Add(Me.tb_GCodeProgramm)
        Me.Controls.Add(Me.btn_moveX100Y200)
        Me.Controls.Add(Me.btn_moveX10)
        Me.Controls.Add(Me.btn_G999)
        Me.Controls.Add(Me.tb_serialOutput)
        Me.Controls.Add(Me.btn_sendSingleCommand)
        Me.Controls.Add(Me.tb_single_command)
        Me.Controls.Add(Me.btn_getMachineConfig)
        Me.Controls.Add(Me.btn_CloseComPort)
        Me.Controls.Add(Me.btn_DoHoming)
        Me.Controls.Add(Me.GroupBox1)
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
    Friend WithEvents btn_G999 As System.Windows.Forms.Button
    Friend WithEvents btn_moveX10 As System.Windows.Forms.Button
    Friend WithEvents btn_moveX100Y200 As System.Windows.Forms.Button
    Friend WithEvents tb_GCodeProgramm As System.Windows.Forms.TextBox
    Friend WithEvents btn_tmpbutton As System.Windows.Forms.Button
    Friend WithEvents btn_sendProgram As System.Windows.Forms.Button
    Friend WithEvents btn_loadProgram As System.Windows.Forms.Button
    Friend WithEvents ofd_GCODE As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_MoreOrLess As System.Windows.Forms.Button
    Friend WithEvents btn_cleanGCode As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
