﻿Imports System.Threading

Public Class main

    Dim singlecmd As Boolean = False
    Dim cmdProcessed As Boolean = False
    Dim WithEvents CNCComPort As New System.IO.Ports.SerialPort
    Delegate Sub SetTextCallback([text] As String)
    Delegate Sub SettextCallbackPos([text] As String)


    Private Sub main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CNCComPort.IsOpen Then CNCComPort.Close()
    End Sub

    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshCOMPort()
        tb_ActPosX.Text = "UNDEF"
        tb_ActPosY.Text = "UNDEF"

        btn_CloseComPort.Enabled = False
    End Sub

    Private Sub refreshCOMPort()
        cb_COMPort.Items.Clear()
        For Each comport As String In System.IO.Ports.SerialPort.GetPortNames
            cb_COMPort.Items.Add(comport)
        Next
        If cb_COMPort.Items.Count = 1 Then cb_COMPort.SelectedIndex = 0
    End Sub


    Private Sub btn_RefreshCOMPort_Click(sender As System.Object, e As System.EventArgs) Handles btn_RefreshCOMPort.Click
        refreshCOMPort()
    End Sub

    Private Sub btn_ConnectToSelectedPort_Click(sender As System.Object, e As System.EventArgs) Handles btn_ConnectToSelectedPort.Click
        If cb_COMPort.Items.Count > 0 Then
            Try
                CNCComPort.PortName = cb_COMPort.Text
                CNCComPort.BaudRate = 57600
                CNCComPort.DataBits = 8
                CNCComPort.RtsEnable = True
                CNCComPort.DtrEnable = True
                CNCComPort.Parity = System.IO.Ports.Parity.None
                CNCComPort.StopBits = System.IO.Ports.StopBits.One
                CNCComPort.ReadBufferSize = 64

                CNCComPort.Open()
                btn_ConnectToSelectedPort.Enabled = False
                btn_CloseComPort.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No COM-Port available.")
        End If

    End Sub
    Private Sub CNCComPort_ErrorReceived(sender As Object, e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles CNCComPort.ErrorReceived
        MsgBox(e.ToString)
    End Sub

    ''' <summary>
    ''' When data is send from Arduino to PC: get it!
    ''' here we look, what is send and react on it individually.
    ''' If string starts with "POS_TRK-" it is a new position and we have to update tb_ActPosX.Text and tb_ActPosY.Text
    ''' If string starts with "LNMVEND" the last G1-Command is fully processed and we have to send the next command
    ''' All other will be written to tb_serialOutput and/or lb_serialOutput
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CNCComPort_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles CNCComPort.DataReceived
        Dim tmparr1(), tmparr2() As String
        Dim actxpos, actypos, posstring As String
        Dim act_output As String
            Try
                If CNCComPort.IsOpen Then
                    act_output = CNCComPort.ReadLine()

                    If act_output.StartsWith("POS_TRK-") Then
                        'POS_TRK-X0.50,Y0.00
                        tmparr1 = act_output.Split("-")
                        tmparr2 = tmparr1(1).Split(",")
                        actxpos = tmparr2(0)
                        actypos = tmparr2(1)

                        posstring = actxpos.ToString.Remove(0, 1) + ";" + actypos.ToString.Remove(0, 1)
                        SetTextPos(posstring)

                        'MsgBox("poschange:" + act_output)
                    ElseIf act_output.StartsWith("LNMVEND") Then
                    cmdProcessed = True
                    Else
                        Me.SetText(act_output)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

    End Sub

    Private Sub SetText(ByVal [text] As String)
        If Me.lb_serialOutput.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.tb_serialOutput.AppendText([text] + vbCrLf)
            Me.lb_serialOutput.Items.Add([text])
            If singlecmd Then
                tb_single_command.AppendText([text])
            End If
        End If
    End Sub

    Private Sub SetTextPos(ByVal [text] As String)
        Dim posarr(2) As String
        If Me.tb_ActPosX.InvokeRequired Or Me.tb_ActPosY.InvokeRequired Then
            Dim d As New SettextCallbackPos(AddressOf SetTextPos)
            Me.Invoke(d, New Object() {[text]})
        Else
            posarr = [text].Split(";")

            Me.tb_ActPosX.Text = posarr(0)
            Me.tb_ActPosY.Text = posarr(1)


        End If
    End Sub


    Private Sub btn_CloseComPort_Click(sender As System.Object, e As System.EventArgs) Handles btn_CloseComPort.Click
        If CNCComPort.IsOpen Then
            Try
                CNCComPort.Close()
                btn_ConnectToSelectedPort.Enabled = True
                btn_CloseComPort.Enabled = False
                tb_ActPosX.Text = "UNDEF"
                tb_ActPosY.Text = "UNDEF"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_getMachineConfig_Click(sender As System.Object, e As System.EventArgs) Handles btn_getMachineConfig.Click
        SendCommand("V1;")
    End Sub


    Private Sub btn_sendSingleCommand_Click(sender As System.Object, e As System.EventArgs) Handles btn_sendSingleCommand.Click
        SendCommand(tb_single_command.Text)
    End Sub

    ''' <summary>
    ''' Send a command to the Arduino.
    ''' Add a ";" if it's missing
    ''' </summary>
    ''' <param name="command">Command to send (adds missing ";")</param>
    ''' <remarks></remarks>
    Private Sub SendCommand(ByVal command As String)

        If Not command.EndsWith(";") Then command = command + ";"

        If CNCComPort.IsOpen Then
            Try
                CNCComPort.Write(command)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btn_DoHoming_Click(sender As System.Object, e As System.EventArgs) Handles btn_DoHoming.Click
        SendCommand("G999")
    End Sub

    Private Sub btn_moveXplus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveXplus.Click
        SendCommand("V121;")
    End Sub

    Private Sub btn_G999_Click(sender As System.Object, e As System.EventArgs) Handles btn_G999.Click
        SendCommand("G999;")
        tb_ActPosX.Text = "0.00"
        tb_ActPosY.Text = "0.00"
    End Sub

    Private Sub btn_moveX10_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveX10.Click
        SendCommand("G1 X10 Y0 F500;")
    End Sub

    Private Sub btn_moveX100Y200_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveX100Y200.Click
        SendCommand("G1 X100 Y200 F500;")
    End Sub

    Private Sub tb_ActPosX_GotFocus(sender As Object, e As System.EventArgs) Handles tb_ActPosX.GotFocus
        btn_tmpbutton.Focus()
    End Sub
    Private Sub tb_ActPosY_GotFocus(sender As Object, e As System.EventArgs) Handles tb_ActPosY.GotFocus
        btn_tmpbutton.Focus()
    End Sub

    Private Sub btn_sendProgramm_Click(sender As System.Object, e As System.EventArgs) Handles btn_sendProgramm.Click
        For Each line In tb_GCodeProgramm.Lines

            SendCommand(line)
            'While Not cmdProcessed
            'System.Threading.Thread.Sleep(100)
            'End While
            cmdProcessed = False

        Next
    End Sub
End Class
