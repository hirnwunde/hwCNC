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

End Class