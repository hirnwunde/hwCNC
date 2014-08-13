<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        Me.tb_logMessages = New System.Windows.Forms.TextBox()
        Me.btn_SaveLogFile = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_clearLog = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'tb_logMessages
        '
        Me.tb_logMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_logMessages.Location = New System.Drawing.Point(13, 13)
        Me.tb_logMessages.Multiline = True
        Me.tb_logMessages.Name = "tb_logMessages"
        Me.tb_logMessages.ReadOnly = True
        Me.tb_logMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_logMessages.Size = New System.Drawing.Size(606, 309)
        Me.tb_logMessages.TabIndex = 0
        '
        'btn_SaveLogFile
        '
        Me.btn_SaveLogFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_SaveLogFile.Location = New System.Drawing.Point(13, 328)
        Me.btn_SaveLogFile.Name = "btn_SaveLogFile"
        Me.btn_SaveLogFile.Size = New System.Drawing.Size(75, 23)
        Me.btn_SaveLogFile.TabIndex = 1
        Me.btn_SaveLogFile.Text = "save"
        Me.btn_SaveLogFile.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Location = New System.Drawing.Point(544, 328)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_clearLog
        '
        Me.btn_clearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_clearLog.Location = New System.Drawing.Point(94, 328)
        Me.btn_clearLog.Name = "btn_clearLog"
        Me.btn_clearLog.Size = New System.Drawing.Size(76, 23)
        Me.btn_clearLog.TabIndex = 3
        Me.btn_clearLog.Text = "clear"
        Me.btn_clearLog.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_clearLog)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_SaveLogFile)
        Me.Controls.Add(Me.tb_logMessages)
        Me.Name = "Log"
        Me.ShowIcon = False
        Me.Text = "Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_logMessages As System.Windows.Forms.TextBox
    Friend WithEvents btn_SaveLogFile As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_clearLog As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
