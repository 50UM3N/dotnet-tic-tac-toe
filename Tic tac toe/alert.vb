Public Class alert
    Public Sub crosswinner(ByVal msg As String, ByVal type As String)
        If type = "X" Then
            Me.BackColor = ColorTranslator.FromHtml("#F2EBD3")
            Label1.ForeColor = ColorTranslator.FromHtml("#545454")
            Label1.Text = msg
        ElseIf type = "O" Then
            Me.BackColor = ColorTranslator.FromHtml("#545454")
            Label1.ForeColor = ColorTranslator.FromHtml("#F2EBD3")
            Label1.Text = msg
        Else
            Me.BackColor = ColorTranslator.FromHtml("#545454")
            Label1.ForeColor = ColorTranslator.FromHtml("#F2EBD3")
            Label1.Text = "O-X draw"
        End If
        Me.Show()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class