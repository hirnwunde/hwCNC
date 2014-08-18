Public Class ManOp


    Private Function getActXPos() As Double
        Try
            Dim ActXPos As Double = CDbl(main.tb_ActPosX.Text)
            Return ActXPos
        Catch ex As Exception
            Return -1.0
        End Try
    End Function
    Private Function getActYPos() As Double
        Try
            Dim ActYPos As Double = CDbl(main.tb_ActPosY.Text)
            Return ActYPos
        Catch ex As Exception
            Return -1.0
        End Try
    End Function

    Private Sub btn_moveXplus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveXplus.Click
        Dim actpos As Double = getActXPos()
        Dim newpos As Double = actpos + 1.0
        If newpos >= main.maxXPos Then
            MsgBox("No movement beyond " + main.maxXPos.ToString)
        Else
            main.SendCommand("G1 X" + newpos.ToString + ";")
        End If
    End Sub
    Private Sub btn_MoveXplusplus_Click(sender As System.Object, e As System.EventArgs) Handles btn_MoveXplusplus.Click
        Dim actpos As Double = getActXPos()
        Dim newpos As Double = actpos + 10.0
        If newpos >= main.maxXPos Then
            MsgBox("No movement beyond " + main.maxXPos.ToString)
        Else
            main.SendCommand("G1 X" + newpos.ToString + ";")
        End If
    End Sub

    Private Sub btn_moveXminus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveXminus.Click
        Dim actpos As Double = getActXPos()
        Dim newpos As Double = actpos - 1.0
        If newpos >= 0.0 Then
            main.SendCommand("G1 X" + newpos.ToString + ";")
        Else
            MsgBox("No movement below 0.00")
        End If
    End Sub
    Private Sub btn_moveXminusminus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveXminusminus.Click
        Dim actpos As Double = getActXPos()
        Dim newpos As Double = actpos - 10.0

        If newpos >= 0.0 Then
            main.SendCommand("G1 X" + newpos.ToString + ";")
        Else
            MsgBox("No movement below 0.00")
        End If
    End Sub


    Private Sub btn_moveYminus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveYminus.Click
        Dim actpos As Double = getActYPos()
        Dim newpos As Double = actpos - 1.0
        If newpos >= 0.0 Then
            main.SendCommand("G1 Y" + newpos.ToString + ";")
        Else
            MsgBox("No movement below 0.00")
        End If
    End Sub
    Private Sub btn_moveYMinusminus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveYMinusminus.Click
        Dim actpos As Double = getActYPos()
        Dim newpos As Double = actpos - 10.0

        If newpos >= 0.0 Then
            main.SendCommand("G1 Y" + newpos.ToString + ";")
        Else
            MsgBox("No movement below 0.00")
        End If
    End Sub

    Private Sub btn_moveYplus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveYplus.Click
        Dim actpos As Double = getActYPos()
        Dim newpos As Double = actpos + 1.0
        If newpos >= main.maxYPos Then
            MsgBox("No movement beyond " + main.maxYPos.ToString)
        Else
            main.SendCommand("G1 Y" + newpos.ToString + ";")
        End If
    End Sub
    Private Sub btn_moveYPlusplus_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveYPlusplus.Click
        Dim actpos As Double = getActYPos()
        Dim newpos As Double = actpos + 10.0
        If newpos >= main.maxYPos Then
            MsgBox("No movement beyond " + main.maxYPos.ToString)
        Else
            main.SendCommand("G1 Y" + newpos.ToString + ";")
        End If
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class