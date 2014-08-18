Public Class timer
    Private dSTart As DateTime

    Public Sub New()
        dStart = Now
    End Sub

    Public Sub New(ByVal startD As DateTime)
        dSTart = startD
    End Sub

    Public Sub Restart()
        dSTart = Now
    End Sub

    Public ReadOnly Property Zeitmessung() As String
        Get
            Dim tdiff As TimeSpan = DateTime.op_Subtraction(Now, dSTart)
            Return tdiff.TotalMilliseconds.ToString & " ms"
        End Get
    End Property

    Public ReadOnly Property getMs As Long
        Get
            Dim tdiff As TimeSpan = DateTime.op_Subtraction(Now, dSTart)
            Return tdiff.TotalMilliseconds
        End Get
    End Property

    Public ReadOnly Property getTime As String
        Get
            Dim tdiff As TimeSpan = DateTime.op_Subtraction(Now, dSTart)
            Return FormatTimeSpan(tdiff)
        End Get
    End Property


    Private Function FormatTimeSpan(ByVal time_span As  _
    TimeSpan, Optional ByVal whole_seconds As Boolean = _
    True) As String
        Dim txt As String = ""

        If time_span.Days > 0 Then
            txt &= ", " & time_span.Days.ToString() & " days"
            time_span = time_span.Subtract(New  _
                TimeSpan(time_span.Days, 0, 0, 0))
        End If
        If time_span.Hours > 0 Then
            txt &= ", " & time_span.Hours.ToString() & " hours"
            time_span = time_span.Subtract(New TimeSpan(0, _
                time_span.Hours, 0, 0))
        End If
        If time_span.Minutes > 0 Then
            txt &= ", " & time_span.Minutes.ToString() & " " & _
                "minutes"
            time_span = time_span.Subtract(New TimeSpan(0, 0, _
                time_span.Minutes, 0))
        End If

        If whole_seconds Then
            ' Display only whole seconds.
            If time_span.Seconds > 0 Then
                txt &= ", " & time_span.Seconds.ToString() & " " & _
                    "seconds"
            End If
        Else
            ' Display fractional seconds.
            txt &= ", " & time_span.TotalSeconds.ToString() & " " & _
                "seconds"
        End If

        ' Remove the leading ", ".
        If txt.Length > 0 Then txt = txt.Substring(2)

        ' Return the result.
        Return txt
    End Function
End Class
