Imports System.Threading

Public Class main

    Dim WithEvents CNCComPort As New System.IO.Ports.SerialPort

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
                CNCComPort.Parity = System.IO.Ports.Parity.None
                CNCComPort.StopBits = System.IO.Ports.StopBits.One
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

    Private Sub CNCComPort_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles CNCComPort.DataReceived
        '    ReceivedText(SerialPort1.ReadExisting())

        shapeTX.BackColor = Color.Red
        ListBox1.Items.Add(CNCComPort.ReadTo(">"))
        shapeTX.BackColor = Color.Khaki


    End Sub


    Private Sub btn_CloseComPort_Click(sender As System.Object, e As System.EventArgs) Handles btn_CloseComPort.Click

        If CNCComPort.IsOpen Then
            Try
                CNCComPort.Close()
                btn_ConnectToSelectedPort.Enabled = True
                btn_CloseComPort.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If CNCComPort.IsOpen Then
            Try
                CNCComPort.WriteLine("M114;")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If CNCComPort.IsOpen Then

            Try
                CNCComPort.Write(TextBox1.Text + vbCrLf)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If




    End Sub

    Private Sub CNCComPort_ErrorReceived(sender As Object, e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles CNCComPort.ErrorReceived
        MsgBox(e.ToString)
    End Sub
End Class
