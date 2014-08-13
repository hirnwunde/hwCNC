<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManOp
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_moveYminus = New System.Windows.Forms.Button()
        Me.btn_moveXplus = New System.Windows.Forms.Button()
        Me.btn_moveXminus = New System.Windows.Forms.Button()
        Me.btn_moveYplus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.btn_moveYminus)
        Me.GroupBox2.Controls.Add(Me.btn_moveXplus)
        Me.GroupBox2.Controls.Add(Me.btn_moveXminus)
        Me.GroupBox2.Controls.Add(Me.btn_moveYplus)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 228)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movement"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(234, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Y - 10"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(175, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 40)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "X + 10"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(175, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "X - 10"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(234, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 40)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Y + 10"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_moveYminus
        '
        Me.btn_moveYminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYminus.Location = New System.Drawing.Point(65, 65)
        Me.btn_moveYminus.Name = "btn_moveYminus"
        Me.btn_moveYminus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveYminus.TabIndex = 7
        Me.btn_moveYminus.Text = "Y - 1"
        Me.btn_moveYminus.UseVisualStyleBackColor = True
        '
        'btn_moveXplus
        '
        Me.btn_moveXplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXplus.Location = New System.Drawing.Point(6, 19)
        Me.btn_moveXplus.Name = "btn_moveXplus"
        Me.btn_moveXplus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveXplus.TabIndex = 4
        Me.btn_moveXplus.Text = "X + 1"
        Me.btn_moveXplus.UseVisualStyleBackColor = True
        '
        'btn_moveXminus
        '
        Me.btn_moveXminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXminus.Location = New System.Drawing.Point(6, 65)
        Me.btn_moveXminus.Name = "btn_moveXminus"
        Me.btn_moveXminus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveXminus.TabIndex = 5
        Me.btn_moveXminus.Text = "X - 1"
        Me.btn_moveXminus.UseVisualStyleBackColor = True
        '
        'btn_moveYplus
        '
        Me.btn_moveYplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYplus.Location = New System.Drawing.Point(65, 19)
        Me.btn_moveYplus.Name = "btn_moveYplus"
        Me.btn_moveYplus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveYplus.TabIndex = 6
        Me.btn_moveYplus.Text = "Y + 1"
        Me.btn_moveYplus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 42)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "unfinished"
        '
        'ManOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 340)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ManOp"
        Me.Text = "ManOp"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btn_moveYminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveXplus As System.Windows.Forms.Button
    Friend WithEvents btn_moveXminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveYplus As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
