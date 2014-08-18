Imports System.Threading

Public Class main

    Dim singlecmd As Boolean = False
    Dim cmdProcessed As Boolean = False
    Dim COMPortClosing As Boolean = False
    Dim folded As Boolean = True
    Dim lines As New List(Of String)
    Dim CurrentRow As Integer = 0

    Public maxYPos As Double = 20.0
    Public maxXPos As Double = 20.0

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
        btn_getMachineConfig.Enabled = False
        btn_DoHoming.Enabled = False
        btn_sendProgram.Enabled = False
        btn_sendSingleCommand.Enabled = False
        ManualOperationsToolStripMenuItem.Enabled = False

        Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")

        btn_tmpbutton.Focus()

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
                'CNCComPort.ReadTimeout = 200
                'CNCComPort.WriteTimeout = 200

                CNCComPort.Open()
                btn_ConnectToSelectedPort.Enabled = False
                btn_CloseComPort.Enabled = True
                btn_getMachineConfig.Enabled = True
                btn_DoHoming.Enabled = True

                btn_sendSingleCommand.Enabled = True
                ManualOperationsToolStripMenuItem.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No COM-Port available.")
        End If

    End Sub
    Private Sub CNCComPort_ErrorReceived(sender As Object, e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles CNCComPort.ErrorReceived
        If Not COMPortClosing Then MsgBox(e.ToString)
    End Sub

    ''' <summary>
    ''' When data is send from Arduino to PC: get it!
    ''' here we look, what is send and react on it individually.
    ''' If string starts with "POS_TRK-" it is a new position and we have to update tb_ActPosX.Text and tb_ActPosY.Text
    ''' If string starts with "LNMVEND" the last G0/G1-Command is fully processed and we have to send the next command
    ''' If string starts with ">" nothing will be displayed (Exit Sub)
    ''' All other will be written to tb_serialOutput and/or lb_serialOutput
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CNCComPort_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles CNCComPort.DataReceived
        
        If Not COMPortClosing Then

            Dim tmparr1(), tmparr2() As String
            Dim actxpos, actypos, posstring As String
            Dim act_output As String

            Try
                If CNCComPort.IsOpen Then
                    act_output = CNCComPort.ReadLine()

                    If act_output.StartsWith("POS_TRK-") Then
                        'POS_TRK-X0.50,Y0.00
                        If chkb_debug.Checked Then Me.SetText(act_output)
                        tmparr1 = act_output.Split("-")
                        tmparr2 = tmparr1(1).Split(",")
                        actxpos = tmparr2(0)
                        actypos = tmparr2(1)

                        posstring = actxpos.ToString.Remove(0, 1) + ";" + actypos.ToString.Remove(0, 1)
                        SetTextPos(posstring)

                        'MsgBox("poschange:" + act_output)
                    ElseIf act_output.StartsWith("LNMVEND") Then

                        If chkb_debug.Checked Then Me.SetText(act_output)

                        If singlecmd Then
                            singlecmd = False
                        Else
                            SendNextLine()
                        End If

                        'cmdProcessed = True
                        'MsgBox("Fertig ...")

                    ElseIf act_output.StartsWith(">") Then
                        If chkb_debug.Checked Then Me.SetText(act_output)
                        Exit Sub
                    Else
                        Me.SetText(act_output)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub SetText(ByVal [text] As String)
        If Me.tb_serialOutput.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.tb_serialOutput.AppendText([text] + vbCrLf)
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
        COMPortClosing = True

        If CNCComPort.IsOpen Then
           
            Try
                CNCComPort.Close()
                btn_ConnectToSelectedPort.Enabled = True
                btn_CloseComPort.Enabled = False
                btn_CloseComPort.Enabled = False
                btn_getMachineConfig.Enabled = False
                btn_DoHoming.Enabled = False
                btn_sendProgram.Enabled = False
                btn_sendSingleCommand.Enabled = False
                ManualOperationsToolStripMenuItem.Enabled = False
                tb_ActPosX.Text = "UNDEF"
                tb_ActPosY.Text = "UNDEF"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        COMPortClosing = False
    End Sub

    Private Sub btn_getMachineConfig_Click(sender As System.Object, e As System.EventArgs) Handles btn_getMachineConfig.Click
        'SendCommand("V1;")
        MsgBox("Not yet implemented")
    End Sub


    Private Sub btn_sendSingleCommand_Click(sender As System.Object, e As System.EventArgs) Handles btn_sendSingleCommand.Click
        singlecmd = True
        SendCommand(tb_single_command.Text)
        System.Threading.Thread.Sleep(500)
        singlecmd = False
    End Sub

    ''' <summary>
    ''' Send a command to the Arduino.
    ''' Add a ";" if it's missing
    ''' </summary>
    ''' <param name="command">Command to send (adds missing ";")</param>
    ''' <remarks></remarks>
    Public Sub SendCommand(ByVal command As String)

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
        tb_ActPosX.Text = "0.00"
        tb_ActPosY.Text = "0.00"
    End Sub

    Private Sub btn_moveXplus_Click(sender As System.Object, e As System.EventArgs)

        SendCommand("V121;")

    End Sub

    Private Sub btn_moveXminus_Click(sender As System.Object, e As System.EventArgs)

        SendCommand("V122;")

    End Sub

    Private Sub btn_moveYminus_Click(sender As System.Object, e As System.EventArgs)

        SendCommand("V123;")

    End Sub

    Private Sub btn_moveYplus_Click(sender As System.Object, e As System.EventArgs)

        SendCommand("V124;")

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


    Private Sub btn_sendProgramm_Click(sender As System.Object, e As System.EventArgs) Handles btn_sendProgram.Click

        ' fillGCodeArray
        ' 

        For Each line In tb_cleanedGCode.Lines
            If line <> "" Then lines.Add(line)
        Next

        SendNextLine()

    End Sub

    Private Sub SendNextLine()

        Try

            If CurrentRow < lines.Count Then
                SendCommand(lines(CurrentRow))
                CurrentRow = CurrentRow + 1
            End If

        Catch ex As Exception
            MsgBox("Error while sending:" + vbCrLf + vbCrLf + ex.Message)
        End Try

    End Sub


    Private Sub tb_single_command_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tb_single_command.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendCommand(tb_single_command.Text)

            MsgBox("asd")

        End If
    End Sub

    Private Sub btn_MoreOrLess_Click(sender As System.Object, e As System.EventArgs) Handles btn_MoreOrLess.Click

        If folded Then
            Me.Size = New Size(989, 550)
            folded = False
            btn_MoreOrLess.Text = "<<< less"
        Else
            Me.Size = New Size(590, 550)
            folded = True
            btn_MoreOrLess.Text = "more >>>"
        End If

    End Sub

    Private Sub btn_cleanGCode_Click(sender As System.Object, e As System.EventArgs)
        cleanGcode()
    End Sub


    Private Sub btn_OpenManOp_Click(sender As System.Object, e As System.EventArgs)
        ManOp.StartPosition = FormStartPosition.Manual

        ManOp.Location = New Point(25, 200)

        ManOp.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        ' {X=232,Y=323}
        Dim loc, tmpposy As String
        Dim posX, posY As Int16
        Dim loc2() As String

        loc = Me.Location.ToString
        loc2 = loc.Split(",")

        ' loc(0) = {X=232
        ' loc(1) = Y=232}
        posX = CInt(loc2(0).Remove(0, 3))
        tmpposy = loc2(1).Remove(0, 2)
        posY = CInt(tmpposy.Remove(tmpposy.Length - 1, 1))



        MsgBox(posX.ToString + " - " + posY.ToString)


    End Sub


    Private Sub loadNCProgram()

        Dim chooseFileRes As DialogResult
        ofd_GCODE.InitialDirectory = Environment.SpecialFolder.MyComputer
        ofd_GCODE.Filter = "G-code Files(*.CNC;*.NC;*.G;*.TXT)|*.CNC;*.NC;*.G;*.TXT|All files (*.*)|*.*"
        chooseFileRes = ofd_GCODE.ShowDialog()
        If chooseFileRes = Windows.Forms.DialogResult.OK Then

            tb_GCodeProgramm.Clear()

            Try

                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(ofd_GCODE.FileName)
                Dim a As String

                a = reader.ReadToEnd
                tb_GCodeProgramm.AppendText(a + vbCrLf)

                reader.Close()

                MsgBox("readed " + tb_GCodeProgramm.Lines.Count.ToString + " lines")

            Catch ex As Exception
                MsgBox("error reading file:" + vbCrLf + ex.Message)
            End Try
        End If

    End Sub

    Private Sub cleanGcode()
        Dim GCMDSupported As Boolean = False
        Dim MCMDSupported As Boolean = False
        Dim linecnt As Int32 = 1
        Dim writeline As Boolean = True
        Dim actline() As String
        Dim whichCMD As String
        Dim GorMCommand As String = "UNDEF"
        Dim dblVal As Double
        Dim MoreThanTwo As Double
        Dim newline As String = ""
        Dim thisX As String = ""
        Dim thisY As String = ""
        Dim thisF As String = ""
        Dim UnsupportedCommand As Boolean = False
        Dim processComment As Boolean = False

        tb_cleanedGCode.Clear()

        For Each line As String In tb_GCodeProgramm.Lines

            'If line.StartsWith("(") Then
            '    processComment = True
            '    tb_cleanedGCode.AppendText(line + vbCrLf)
            'End If

            'If processComment Then
            '    If Not line.Contains("(") Then
            '        tb_cleanedGCode.AppendText(line + vbCrLf)
            '        If line.Contains(")") Then processComment = False
            '    End If
            'End If



            line = line.Replace(",", ".")

            actline = Split(line, " ") ' split lines by spaces

            For Each ele As String In actline

                If ele.ToUpper.StartsWith("G") Then
                    ' we have a G-Command
                    GorMCommand = "G"
                    whichCMD = ele.Remove(0, 1)
                    If whichCMD = "0" Or whichCMD = "1" Or
                       whichCMD = "4" Or whichCMD = "28" Or
                       whichCMD = "90" Or whichCMD = "91" Or
                       whichCMD = "92" Or whichCMD = "999" Then

                        GCMDSupported = True

                        newline = newline + ele

                    Else
                        GCMDSupported = False
                    End If

                End If

                If ele.ToUpper.StartsWith("M") Then
                    ' we have a M-Command
                    GorMCommand = "M"
                    whichCMD = ele.Remove(0, 1)
                    If whichCMD = "18" Or whichCMD = "100" Or whichCMD = "114" Then
                        MCMDSupported = True

                        newline = newline + ele

                    Else
                        MCMDSupported = False
                    End If
                End If

                If ele.ToUpper.StartsWith("Z") Then
                    Log.tb_logMessages.AppendText("Z-Axes in line " + linecnt.ToString + " not supported!" + vbCrLf)
                    writeline = False
                    UnsupportedCommand = True
                    Exit For
                End If

                ' alle nachkommastellen nach der zweiten stelle abschneiden
                If ele.ToUpper.StartsWith("X") Then
                    If ele.EndsWith(";") Then ele.Remove(ele.Length - 1)
                    MoreThanTwo = CDbl(ele.Remove(0, 1))
                    If Double.TryParse(MoreThanTwo, dblVal) Then

                        thisX = Format(MoreThanTwo, "0.00")
                        newline = newline + " X" + thisX

                    End If
                End If

                If ele.ToUpper.StartsWith("Y") Then

                    thisY = ele.Remove(0, 1) ' cut "Y"
                    thisY.Trim()

                    If thisY.EndsWith(";") Then
                        thisY = thisY.Remove(thisY.Length - 1, 1) ' cut ";"
                    End If

                    MoreThanTwo = CDbl(thisY)
                    If Double.TryParse(MoreThanTwo, dblVal) Then

                        thisY = Format(MoreThanTwo, "0.00")
                        newline = newline + " Y" + thisY

                    End If
                End If

                If ele.ToUpper.StartsWith("F") Then
                    If ele.EndsWith(";") Then ele.Remove(ele.Length - 1)

                    newline = newline + " " + ele

                End If

                If Not MCMDSupported And GorMCommand = "M" Then
                    Log.tb_logMessages.AppendText("M-Command in line " + linecnt.ToString + " not supported!" + vbCrLf)
                    writeline = False
                    UnsupportedCommand = True
                    Exit For
                End If

                If Not GCMDSupported And GorMCommand = "G" Then
                    Log.tb_logMessages.AppendText("G-Command in line " + linecnt.ToString + " not supported!" + vbCrLf)
                    writeline = False
                    UnsupportedCommand = True
                    Exit For
                End If

            Next

            If writeline And newline.Length <> 0 Then
                If Not newline.EndsWith(";") Then newline = newline + ";"
                tb_cleanedGCode.AppendText(newline + vbCrLf)
            End If

            linecnt = linecnt + 1
            newline = ""
            writeline = True
        Next

        Dim strMsg As String = "The NC-File contains unsupported commands." + vbCrLf _
                             + "It is unsave to operate with this program!" + vbCrLf _
                             + "Shall i display the logfile?"

        Dim msgResult As MsgBoxResult
        msgResult = MsgBox(strMsg, MsgBoxStyle.YesNo)
        If msgResult = MsgBoxResult.Yes Then Log.Show()


    End Sub

    Private Sub LoadNCProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadNCProgramToolStripMenuItem.Click
        loadNCProgram()
        cleanGcode()

        If CNCComPort.IsOpen Then btn_sendProgram.Enabled = True

    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogToolStripMenuItem.Click
        Log.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ManualOperationsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManualOperationsToolStripMenuItem.Click
        ManOp.Show()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cleanGcode()
    End Sub

    Private Sub btn_goX0Y0_Click(sender As System.Object, e As System.EventArgs) Handles btn_goX0Y0.Click
        SendCommand("G1 X0 Y0 F800;")
    End Sub

    Private Sub SavecleanedNCProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SavecleanedNCProgramToolStripMenuItem.Click

        SFD_NCFile.DefaultExt = "nc"
        SFD_NCFile.Filter = "Numeric Control Files (*.nc)|*.nc"

        If SFD_NCFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(SFD_NCFile.FileName, tb_cleanedGCode.Text, True)
                MsgBox("File" + vbCrLf + SFD_NCFile.FileName + vbCrLf + "saved.")
            Catch ex As Exception
                MsgBox("Error while saveing file " + SFD_NCFile.FileName + ":" + vbCrLf + ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim startend As New List(Of String)
        Dim newstart As Integer = 0
        Dim actpos As Integer = 0

        Dim timerstart As New timer

        lines.Clear()

        For Each line In tb_cleanedGCode.Lines
            If line <> "" Then lines.Add(line)
        Next

        For Each ele In lines
            tb_cleanedGCode.SelectionStart = newstart
            tb_cleanedGCode.SelectionLength = ele.Length
            tb_cleanedGCode.Select()
            tb_cleanedGCode.ScrollToCaret()
            actpos = newstart + ele.Length
            newstart = actpos + 2
            System.Threading.Thread.Sleep(850)
        Next

        TimerRuntime.Stop()

        tb_cleanedGCode.SelectionStart = 0
        tb_cleanedGCode.SelectionLength = 0
        tb_cleanedGCode.Select()

        MsgBox("Runtime: " + timerstart.getTime)

    End Sub
End Class
