Public Class Form1

    Dim sekunden As String = 0
    Dim minuten As String = 0
    Dim stunden As String = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sekunden = 0
        minuten = 0
        stunden = 0
        Label1.Text = "0:00:00"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sekunden += 1
        If minuten < 10 And sekunden < 10 Then
            Label1.Text = stunden & ":0" & minuten & ":0" & sekunden
        End If
        If minuten < 10 And sekunden > 10 Then
            Label1.Text = stunden & ":0" & minuten & ":" & sekunden
        End If
        If minuten > 10 And sekunden < 10 Then
            Label1.Text = stunden & ":" & minuten & ":0" & sekunden
        End If
        If minuten > 10 And sekunden < 10 Then
            Label1.Text = stunden & ":" & minuten & ":" & sekunden
        End If
        If sekunden = 60 Then
            sekunden = 0
            minuten += 1
        End If
        If minuten = 60 Then
            minuten = 0
            stunden += 1
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
