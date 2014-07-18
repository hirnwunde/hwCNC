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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shapeTX = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.btn_CloseComPort = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ConnectToSelectedPort
        '
        Me.btn_ConnectToSelectedPort.Location = New System.Drawing.Point(36, 120)
        Me.btn_ConnectToSelectedPort.Name = "btn_ConnectToSelectedPort"
        Me.btn_ConnectToSelectedPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_ConnectToSelectedPort.TabIndex = 0
        Me.btn_ConnectToSelectedPort.Text = "connect"
        Me.btn_ConnectToSelectedPort.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(136, 383)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(366, 160)
        Me.ListBox1.TabIndex = 1
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
        Me.btn_moveXplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXplus.Location = New System.Drawing.Point(810, 217)
        Me.btn_moveXplus.Name = "btn_moveXplus"
        Me.btn_moveXplus.Size = New System.Drawing.Size(80, 80)
        Me.btn_moveXplus.TabIndex = 4
        Me.btn_moveXplus.Text = "X +"
        Me.btn_moveXplus.UseVisualStyleBackColor = True
        '
        'btn_moveXminus
        '
        Me.btn_moveXminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXminus.Location = New System.Drawing.Point(638, 217)
        Me.btn_moveXminus.Name = "btn_moveXminus"
        Me.btn_moveXminus.Size = New System.Drawing.Size(80, 80)
        Me.btn_moveXminus.TabIndex = 5
        Me.btn_moveXminus.Text = "X -"
        Me.btn_moveXminus.UseVisualStyleBackColor = True
        '
        'btn_moveYminus
        '
        Me.btn_moveYminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYminus.Location = New System.Drawing.Point(724, 303)
        Me.btn_moveYminus.Name = "btn_moveYminus"
        Me.btn_moveYminus.Size = New System.Drawing.Size(80, 80)
        Me.btn_moveYminus.TabIndex = 7
        Me.btn_moveYminus.Text = "Y -"
        Me.btn_moveYminus.UseVisualStyleBackColor = True
        '
        'btn_moveYplus
        '
        Me.btn_moveYplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYplus.Location = New System.Drawing.Point(724, 131)
        Me.btn_moveYplus.Name = "btn_moveYplus"
        Me.btn_moveYplus.Size = New System.Drawing.Size(80, 80)
        Me.btn_moveYplus.TabIndex = 6
        Me.btn_moveYplus.Text = "Y +"
        Me.btn_moveYplus.UseVisualStyleBackColor = True
        '
        'chkb_FastMovement
        '
        Me.chkb_FastMovement.AutoSize = True
        Me.chkb_FastMovement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_FastMovement.Location = New System.Drawing.Point(726, 250)
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
        Me.tb_ActPosX.Enabled = False
        Me.tb_ActPosX.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold)
        Me.tb_ActPosX.Location = New System.Drawing.Point(72, 13)
        Me.tb_ActPosX.Name = "tb_ActPosX"
        Me.tb_ActPosX.Size = New System.Drawing.Size(170, 62)
        Me.tb_ActPosX.TabIndex = 10
        '
        'tb_ActPosY
        '
        Me.tb_ActPosY.Enabled = False
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
        Me.btn_DoHoming.Location = New System.Drawing.Point(12, 490)
        Me.btn_DoHoming.Name = "btn_DoHoming"
        Me.btn_DoHoming.Size = New System.Drawing.Size(75, 53)
        Me.btn_DoHoming.TabIndex = 14
        Me.btn_DoHoming.Text = "Go home!"
        Me.btn_DoHoming.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapeTX})
        Me.ShapeContainer1.Size = New System.Drawing.Size(911, 555)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'shapeTX
        '
        Me.shapeTX.BackColor = System.Drawing.Color.Khaki
        Me.shapeTX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.shapeTX.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shapeTX.Location = New System.Drawing.Point(661, 493)
        Me.shapeTX.Name = "shapeTX"
        Me.shapeTX.Size = New System.Drawing.Size(20, 20)
        '
        'btn_CloseComPort
        '
        Me.btn_CloseComPort.Location = New System.Drawing.Point(36, 149)
        Me.btn_CloseComPort.Name = "btn_CloseComPort"
        Me.btn_CloseComPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_CloseComPort.TabIndex = 16
        Me.btn_CloseComPort.Text = "disconnect"
        Me.btn_CloseComPort.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "M114"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 232)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(348, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 555)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_ConnectToSelectedPort)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "main"
        Me.Text = "hwCNC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ConnectToSelectedPort As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
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
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shapeTX As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents btn_CloseComPort As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
