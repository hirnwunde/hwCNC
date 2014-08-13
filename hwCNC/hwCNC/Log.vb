Public Class Log

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_clearLog_Click(sender As System.Object, e As System.EventArgs) Handles btn_clearLog.Click
        tb_logMessages.Clear()
    End Sub

    Private Sub btn_SaveLogFile_Click(sender As System.Object, e As System.EventArgs) Handles btn_SaveLogFile.Click


        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.FileName = "hwCNCLog"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, tb_logMessages.Text, True)
        End If
    End Sub

    Private Sub Log_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class