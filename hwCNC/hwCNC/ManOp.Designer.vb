'* hwCNC - a program to control an GCodeAFMotorV2-Firmware based X/Y-Plotter
'* 
'* Copyright (C) 2014 Oliver Beck
'* 
'* This file is part of hwCNC.
'* 
'* hwCNC is free software: you can redistribute it and/or modify it under the terms of the
'* GNU General Public License version 3 as published by the Free Software Foundation.
'* 
'* hwCNC is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
'* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
'* 
'* See the GNU General Public License for more details. You should have received a copy of the GNU
'* General Public License along with hwCNC. If not, see <http://www.gnu.org/licenses/>.
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
        Me.btn_moveYMinusminus = New System.Windows.Forms.Button()
        Me.btn_MoveXplusplus = New System.Windows.Forms.Button()
        Me.btn_moveXminusminus = New System.Windows.Forms.Button()
        Me.btn_moveYPlusplus = New System.Windows.Forms.Button()
        Me.btn_moveYminus = New System.Windows.Forms.Button()
        Me.btn_moveXplus = New System.Windows.Forms.Button()
        Me.btn_moveXminus = New System.Windows.Forms.Button()
        Me.btn_moveYplus = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_moveYMinusminus)
        Me.GroupBox2.Controls.Add(Me.btn_MoveXplusplus)
        Me.GroupBox2.Controls.Add(Me.btn_moveXminusminus)
        Me.GroupBox2.Controls.Add(Me.btn_moveYPlusplus)
        Me.GroupBox2.Controls.Add(Me.btn_moveYminus)
        Me.GroupBox2.Controls.Add(Me.btn_moveXplus)
        Me.GroupBox2.Controls.Add(Me.btn_moveXminus)
        Me.GroupBox2.Controls.Add(Me.btn_moveYplus)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 114)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movement"
        '
        'btn_moveYMinusminus
        '
        Me.btn_moveYMinusminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYMinusminus.Location = New System.Drawing.Point(234, 65)
        Me.btn_moveYMinusminus.Name = "btn_moveYMinusminus"
        Me.btn_moveYMinusminus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveYMinusminus.TabIndex = 11
        Me.btn_moveYMinusminus.Text = "Y - 10"
        Me.btn_moveYMinusminus.UseVisualStyleBackColor = True
        '
        'btn_MoveXplusplus
        '
        Me.btn_MoveXplusplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MoveXplusplus.Location = New System.Drawing.Point(175, 19)
        Me.btn_MoveXplusplus.Name = "btn_MoveXplusplus"
        Me.btn_MoveXplusplus.Size = New System.Drawing.Size(53, 40)
        Me.btn_MoveXplusplus.TabIndex = 8
        Me.btn_MoveXplusplus.Text = "X + 10"
        Me.btn_MoveXplusplus.UseVisualStyleBackColor = True
        '
        'btn_moveXminusminus
        '
        Me.btn_moveXminusminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveXminusminus.Location = New System.Drawing.Point(175, 65)
        Me.btn_moveXminusminus.Name = "btn_moveXminusminus"
        Me.btn_moveXminusminus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveXminusminus.TabIndex = 9
        Me.btn_moveXminusminus.Text = "X - 10"
        Me.btn_moveXminusminus.UseVisualStyleBackColor = True
        '
        'btn_moveYPlusplus
        '
        Me.btn_moveYPlusplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moveYPlusplus.Location = New System.Drawing.Point(234, 19)
        Me.btn_moveYPlusplus.Name = "btn_moveYPlusplus"
        Me.btn_moveYPlusplus.Size = New System.Drawing.Size(53, 40)
        Me.btn_moveYPlusplus.TabIndex = 10
        Me.btn_moveYPlusplus.Text = "Y + 10"
        Me.btn_moveYPlusplus.UseVisualStyleBackColor = True
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
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(232, 139)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 35
        Me.btn_close.Text = "close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'ManOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximumSize = New System.Drawing.Size(334, 208)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(334, 208)
        Me.Name = "ManOp"
        Me.ShowIcon = False
        Me.Text = "ManOp"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_moveYMinusminus As System.Windows.Forms.Button
    Friend WithEvents btn_MoveXplusplus As System.Windows.Forms.Button
    Friend WithEvents btn_moveXminusminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveYPlusplus As System.Windows.Forms.Button
    Friend WithEvents btn_moveYminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveXplus As System.Windows.Forms.Button
    Friend WithEvents btn_moveXminus As System.Windows.Forms.Button
    Friend WithEvents btn_moveYplus As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
End Class
