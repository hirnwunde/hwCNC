﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn_sendProgram = New System.Windows.Forms.Button()
        Me.ofd_GCODE = New System.Windows.Forms.OpenFileDialog()
        Me.btn_MoreOrLess = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadNCProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavecleanedNCProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_tmpbutton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ConnectToSelectedPort
        '
        Me.btn_ConnectToSelectedPort.Location = New System.Drawing.Point(5, 85)
        Me.btn_ConnectToSelectedPort.Name = "btn_ConnectToSelectedPort"
        Me.btn_ConnectToSelectedPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_ConnectToSelectedPort.TabIndex = 0
        Me.btn_ConnectToSelectedPort.Text = "connect"
        Me.btn_ConnectToSelectedPort.UseVisualStyleBackColor = True
        '
        'cb_COMPort
        '
        Me.cb_COMPort.FormattingEnabled = True
        Me.cb_COMPort.Location = New System.Drawing.Point(6, 56)
        Me.cb_COMPort.Name = "cb_COMPort"
        Me.cb_COMPort.Size = New System.Drawing.Size(75, 21)
        Me.cb_COMPort.TabIndex = 2
        '
        'btn_RefreshCOMPort
        '
        Me.btn_RefreshCOMPort.Location = New System.Drawing.Point(6, 27)
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
        Me.tb_ActPosX.Size = New System.Drawing.Size(145, 44)
        Me.tb_ActPosX.TabIndex = 10
        '
        'tb_ActPosY
        '
        Me.tb_ActPosY.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ActPosY.Location = New System.Drawing.Point(62, 68)
        Me.tb_ActPosY.Name = "tb_ActPosY"
        Me.tb_ActPosY.Size = New System.Drawing.Size(144, 44)
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
        Me.GroupBox1.Location = New System.Drawing.Point(360, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 123)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position"
        '
        'btn_DoHoming
        '
        Me.btn_DoHoming.Location = New System.Drawing.Point(87, 81)
        Me.btn_DoHoming.Name = "btn_DoHoming"
        Me.btn_DoHoming.Size = New System.Drawing.Size(75, 56)
        Me.btn_DoHoming.TabIndex = 14
        Me.btn_DoHoming.Text = "Go home!"
        Me.btn_DoHoming.UseVisualStyleBackColor = True
        '
        'btn_CloseComPort
        '
        Me.btn_CloseComPort.Location = New System.Drawing.Point(5, 114)
        Me.btn_CloseComPort.Name = "btn_CloseComPort"
        Me.btn_CloseComPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_CloseComPort.TabIndex = 16
        Me.btn_CloseComPort.Text = "disconnect"
        Me.btn_CloseComPort.UseVisualStyleBackColor = True
        '
        'btn_getMachineConfig
        '
        Me.btn_getMachineConfig.Location = New System.Drawing.Point(87, 27)
        Me.btn_getMachineConfig.Name = "btn_getMachineConfig"
        Me.btn_getMachineConfig.Size = New System.Drawing.Size(75, 49)
        Me.btn_getMachineConfig.TabIndex = 17
        Me.btn_getMachineConfig.Text = "get Config from machine"
        Me.btn_getMachineConfig.UseVisualStyleBackColor = True
        '
        'tb_single_command
        '
        Me.tb_single_command.Location = New System.Drawing.Point(6, 19)
        Me.tb_single_command.Name = "tb_single_command"
        Me.tb_single_command.Size = New System.Drawing.Size(344, 20)
        Me.tb_single_command.TabIndex = 21
        '
        'btn_sendSingleCommand
        '
        Me.btn_sendSingleCommand.Location = New System.Drawing.Point(116, 45)
        Me.btn_sendSingleCommand.Name = "btn_sendSingleCommand"
        Me.btn_sendSingleCommand.Size = New System.Drawing.Size(140, 23)
        Me.btn_sendSingleCommand.TabIndex = 22
        Me.btn_sendSingleCommand.Text = "send"
        Me.btn_sendSingleCommand.UseVisualStyleBackColor = True
        '
        'tb_serialOutput
        '
        Me.tb_serialOutput.Location = New System.Drawing.Point(6, 12)
        Me.tb_serialOutput.Multiline = True
        Me.tb_serialOutput.Name = "tb_serialOutput"
        Me.tb_serialOutput.Size = New System.Drawing.Size(344, 384)
        Me.tb_serialOutput.TabIndex = 23
        '
        'btn_G999
        '
        Me.btn_G999.Location = New System.Drawing.Point(210, 52)
        Me.btn_G999.Name = "btn_G999"
        Me.btn_G999.Size = New System.Drawing.Size(129, 23)
        Me.btn_G999.TabIndex = 25
        Me.btn_G999.Text = "G999;"
        Me.btn_G999.UseVisualStyleBackColor = True
        '
        'btn_moveX10
        '
        Me.btn_moveX10.Location = New System.Drawing.Point(210, 82)
        Me.btn_moveX10.Name = "btn_moveX10"
        Me.btn_moveX10.Size = New System.Drawing.Size(129, 23)
        Me.btn_moveX10.TabIndex = 26
        Me.btn_moveX10.Text = "G1 X10 Y0 F500;"
        Me.btn_moveX10.UseVisualStyleBackColor = True
        '
        'btn_moveX100Y200
        '
        Me.btn_moveX100Y200.Location = New System.Drawing.Point(210, 111)
        Me.btn_moveX100Y200.Name = "btn_moveX100Y200"
        Me.btn_moveX100Y200.Size = New System.Drawing.Size(129, 23)
        Me.btn_moveX100Y200.TabIndex = 27
        Me.btn_moveX100Y200.Text = "G1 X100 Y200F300;"
        Me.btn_moveX100Y200.UseVisualStyleBackColor = True
        '
        'tb_GCodeProgramm
        '
        Me.tb_GCodeProgramm.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_GCodeProgramm.Location = New System.Drawing.Point(3, 0)
        Me.tb_GCodeProgramm.Multiline = True
        Me.tb_GCodeProgramm.Name = "tb_GCodeProgramm"
        Me.tb_GCodeProgramm.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_GCodeProgramm.Size = New System.Drawing.Size(272, 271)
        Me.tb_GCodeProgramm.TabIndex = 28
        Me.tb_GCodeProgramm.Text = "G1 X1 Y1 F200;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X2 Y2;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X3 Y3;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G2 X4 Y4 I4 J4 F75;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X5 Y5;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G3 X6 Y6 I6" & _
    " J6 F75;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G1 X7 Y7;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M30;"
        '
        'btn_sendProgram
        '
        Me.btn_sendProgram.Location = New System.Drawing.Point(18, 478)
        Me.btn_sendProgram.Name = "btn_sendProgram"
        Me.btn_sendProgram.Size = New System.Drawing.Size(83, 30)
        Me.btn_sendProgram.TabIndex = 30
        Me.btn_sendProgram.Text = "send program"
        Me.btn_sendProgram.UseVisualStyleBackColor = True
        '
        'btn_MoreOrLess
        '
        Me.btn_MoreOrLess.Location = New System.Drawing.Point(497, 485)
        Me.btn_MoreOrLess.Name = "btn_MoreOrLess"
        Me.btn_MoreOrLess.Size = New System.Drawing.Size(75, 23)
        Me.btn_MoreOrLess.TabIndex = 33
        Me.btn_MoreOrLess.Text = "more >>>"
        Me.btn_MoreOrLess.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(266, 271)
        Me.TextBox1.TabIndex = 36
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ManualOperationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadNCProgramToolStripMenuItem, Me.SavecleanedNCProgramToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadNCProgramToolStripMenuItem
        '
        Me.LoadNCProgramToolStripMenuItem.Name = "LoadNCProgramToolStripMenuItem"
        Me.LoadNCProgramToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.LoadNCProgramToolStripMenuItem.Text = "load NC-Program"
        '
        'SavecleanedNCProgramToolStripMenuItem
        '
        Me.SavecleanedNCProgramToolStripMenuItem.Name = "SavecleanedNCProgramToolStripMenuItem"
        Me.SavecleanedNCProgramToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SavecleanedNCProgramToolStripMenuItem.Text = "save (cleaned) NC-Program"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.LoadToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ShowToolStripMenuItem.Text = "show"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.LoadToolStripMenuItem.Text = "load"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.QuitToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ManualOperationsToolStripMenuItem
        '
        Me.ManualOperationsToolStripMenuItem.Name = "ManualOperationsToolStripMenuItem"
        Me.ManualOperationsToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ManualOperationsToolStripMenuItem.Text = "manual operations"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_RefreshCOMPort)
        Me.GroupBox2.Controls.Add(Me.btn_ConnectToSelectedPort)
        Me.GroupBox2.Controls.Add(Me.cb_COMPort)
        Me.GroupBox2.Controls.Add(Me.btn_DoHoming)
        Me.GroupBox2.Controls.Add(Me.btn_CloseComPort)
        Me.GroupBox2.Controls.Add(Me.btn_getMachineConfig)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 149)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SplitContainer1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(560, 290)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NC-Program"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tb_GCodeProgramm)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(554, 271)
        Me.SplitContainer1.SplitterDistance = 278
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tb_serialOutput)
        Me.GroupBox4.Location = New System.Drawing.Point(615, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(356, 401)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "serial output"
        '
        'btn_tmpbutton
        '
        Me.btn_tmpbutton.Location = New System.Drawing.Point(390, 650)
        Me.btn_tmpbutton.Name = "btn_tmpbutton"
        Me.btn_tmpbutton.Size = New System.Drawing.Size(75, 23)
        Me.btn_tmpbutton.TabIndex = 43
        Me.btn_tmpbutton.Text = "Button1"
        Me.btn_tmpbutton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tb_single_command)
        Me.GroupBox5.Controls.Add(Me.btn_sendSingleCommand)
        Me.GroupBox5.Location = New System.Drawing.Point(615, 435)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(356, 73)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "send single Command"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 522)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btn_tmpbutton)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_MoreOrLess)
        Me.Controls.Add(Me.btn_sendProgram)
        Me.Controls.Add(Me.btn_moveX100Y200)
        Me.Controls.Add(Me.btn_moveX10)
        Me.Controls.Add(Me.btn_G999)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "hwCNC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ConnectToSelectedPort As System.Windows.Forms.Button
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
    Friend WithEvents btn_sendProgram As System.Windows.Forms.Button
    Friend WithEvents ofd_GCODE As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_MoreOrLess As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadNCProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavecleanedNCProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ManualOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_tmpbutton As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox

End Class
