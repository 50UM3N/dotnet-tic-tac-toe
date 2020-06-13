Imports Guna.UI.WinForms
Public Class Form1

    Public score1, score2 As Integer
    Public re As String = "O"
    Public arr() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i"}
    Public g As Graphics
    Public p As Pen = New Pen(Brushes.Red, 2)
    Public Sub winner(msg As String, type As String)
        Dim f As alert = New alert
        f.crosswinner(msg, type)
    End Sub
    Public Sub reset()
        re = "O"
        arr(0) = "a"
        arr(1) = "b"
        arr(2) = "c"
        arr(3) = "d"
        arr(4) = "e"
        arr(5) = "f"
        arr(6) = "g"
        arr(7) = "h"
        arr(8) = "i"
        For Each ctrl As Control In Me.Panel2.Controls
            If TypeOf ctrl Is GunaImageButton Then
                ctrl.Enabled = True
            End If
        Next
        GunaImageButton1.Enabled = True
        GunaImageButton1.Image = Nothing
        GunaImageButton2.Image = Nothing
        GunaImageButton3.Image = Nothing
        GunaImageButton4.Image = Nothing
        GunaImageButton5.Image = Nothing
        GunaImageButton6.Image = Nothing
        GunaImageButton7.Image = Nothing
        GunaImageButton8.Image = Nothing
        GunaImageButton9.Image = Nothing
    End Sub
    Private Sub check()
        Dim s As String
        s = re + " is win"
        If arr(0) = arr(1) And arr(1) = arr(2) Then
            winner(arr(0) + " is win", arr(0))
            If arr(0) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(3) = arr(4) And arr(4) = arr(5) Then
            winner(arr(3) + " is win", arr(3))
            If arr(3) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(6) = arr(7) And arr(7) = arr(8) Then
            winner(arr(6) + " is win", arr(6))
            If arr(6) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(0) = arr(3) And arr(3) = arr(6) Then
            winner(arr(0) + " is win", arr(0))
            If arr(0) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(1) = arr(4) And arr(4) = arr(7) Then
            winner(arr(1) + " is win", arr(1))
            If arr(1) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(2) = arr(5) And arr(5) = arr(8) Then
            winner(arr(2) + " is win", arr(2))
            If arr(2) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(0) = arr(4) And arr(4) = arr(8) Then
            winner(arr(0) + " is win", arr(0))
            If arr(0) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(2) = arr(4) And arr(4) = arr(6) Then
            winner(arr(2) + " is win", arr(2))
            If arr(2) = "X" Then
                score2 += 1
                BunifuFlatButton2.Text = score2
            Else
                score1 += 1
                BunifuFlatButton1.Text = score1
            End If
            reset()
        ElseIf arr(0) <> "a" And arr(1) <> "b" And arr(2) <> "c" And arr(3) <> "d" And arr(4) <> "e" And arr(5) <> "f" And arr(6) <> "g" And arr(7) <> "h" And arr(8) <> "i" Then
            winner(arr(0) + " is win", "draw")
            reset()
        End If
    End Sub
    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        If re = "O" Then
            re = "X"
            arr(0) = "O"
            GunaImageButton1.Image = My.Resources.circle
            GunaImageButton1.Enabled = False
            check()
        Else
            re = "O"
            arr(0) = "X"
            GunaImageButton1.Image = My.Resources.cross
            GunaImageButton1.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton2_Click(sender As Object, e As EventArgs) Handles GunaImageButton2.Click
        If re = "O" Then
            re = "X"
            arr(1) = "O"
            GunaImageButton2.Image = My.Resources.circle
            GunaImageButton2.Enabled = False
            check()
        Else
            re = "O"
            arr(1) = "X"
            GunaImageButton2.Image = My.Resources.cross
            GunaImageButton2.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton3_Click(sender As Object, e As EventArgs) Handles GunaImageButton3.Click
        If re = "O" Then
            re = "X"
            arr(2) = "O"
            GunaImageButton3.Image = My.Resources.circle
            GunaImageButton3.Enabled = False
            check()
        Else
            re = "O"
            arr(2) = "X"
            GunaImageButton3.Image = My.Resources.cross
            GunaImageButton3.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton4_Click(sender As Object, e As EventArgs) Handles GunaImageButton4.Click
        If re = "O" Then
            re = "X"
            arr(3) = "O"
            GunaImageButton4.Image = My.Resources.circle
            GunaImageButton4.Enabled = False
            check()
        Else
            re = "O"
            arr(3) = "X"
            GunaImageButton4.Image = My.Resources.cross
            GunaImageButton4.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton5_Click(sender As Object, e As EventArgs) Handles GunaImageButton5.Click
        If re = "O" Then
            re = "X"
            arr(4) = "O"
            GunaImageButton5.Image = My.Resources.circle
            GunaImageButton5.Enabled = False
            check()
        Else
            re = "O"
            arr(4) = "X"
            GunaImageButton5.Image = My.Resources.cross
            GunaImageButton5.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton6_Click(sender As Object, e As EventArgs) Handles GunaImageButton6.Click
        If re = "O" Then
            re = "X"
            arr(5) = "O"
            GunaImageButton6.Image = My.Resources.circle
            GunaImageButton6.Enabled = False
            check()
        Else
            re = "O"
            arr(5) = "X"
            GunaImageButton6.Image = My.Resources.cross
            GunaImageButton6.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton7_Click(sender As Object, e As EventArgs) Handles GunaImageButton7.Click
        If re = "O" Then
            re = "X"
            arr(6) = "O"
            GunaImageButton7.Image = My.Resources.circle
            GunaImageButton7.Enabled = False
            check()
        Else
            re = "O"
            arr(6) = "X"
            GunaImageButton7.Image = My.Resources.cross
            GunaImageButton7.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaImageButton8_Click(sender As Object, e As EventArgs) Handles GunaImageButton8.Click
        If re = "O" Then
            re = "X"
            arr(7) = "O"
            GunaImageButton8.Image = My.Resources.circle
            GunaImageButton8.Enabled = False
            check()
        Else
            re = "O"
            arr(7) = "X"
            GunaImageButton8.Image = My.Resources.cross
            GunaImageButton8.Enabled = False
            check()
        End If
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        score1 = 0
        score2 = 0
        BunifuFlatButton1.Text = 0
        BunifuFlatButton2.Text = 0
        reset()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaImageButton9_Click(sender As Object, e As EventArgs) Handles GunaImageButton9.Click
        If re = "O" Then
            re = "X"
            arr(8) = "O"
            GunaImageButton9.Image = My.Resources.circle
            GunaImageButton9.Enabled = False
            check()
        Else
            re = "O"
            arr(8) = "X"
            GunaImageButton9.Image = My.Resources.cross
            GunaImageButton9.Enabled = False
            check()
        End If
    End Sub

End Class
