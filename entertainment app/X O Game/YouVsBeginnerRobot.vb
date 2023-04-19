Public Class YouVsBeginnerRobot
    Dim numberOfX, numberOfO As Integer
    Dim yourScore, yourFScore As Integer
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Home.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "" Then
            If numberOfX = numberOfO Then
                Button1.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button1.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "" Then
            If numberOfX = numberOfO Then
                Button2.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button2.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "" Then
            If numberOfX = numberOfO Then
                Button4.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button4.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "" Then
            If numberOfX = numberOfO Then
                Button5.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button5.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button7.Text = "" Then
            If numberOfX = numberOfO Then
                Button7.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button7.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button8.Text = "" Then
            If numberOfX = numberOfO Then
                Button8.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button8.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "" Then
            If numberOfX = numberOfO Then
                Button3.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button3.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button9.Text = "" Then
            If numberOfX = numberOfO Then
                Button9.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button9.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Text = "" Then
            If numberOfX = numberOfO Then
                Button6.Text = "X"
                numberOfX += 1
            ElseIf numberOfO = numberOfX - 1 Then
                Button6.Text = "O"
                numberOfO += 1
            End If
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Label4.Text = 0
        Label5.Text = 0
        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black
        Button9.ForeColor = Color.Black
        numberOfO = 0
        numberOfX = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Timer1.Enabled = False
            Button1.ForeColor = Color.Red
            Button2.ForeColor = Color.Red
            Button3.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Timer1.Enabled = False
            Button4.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Button6.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Timer1.Enabled = False
            Button7.ForeColor = Color.Red
            Button8.ForeColor = Color.Red
            Button9.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Timer1.Enabled = False
            Button1.ForeColor = Color.Red
            Button4.ForeColor = Color.Red
            Button7.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button2.Text = "X" And Button8.Text = "X" And Button5.Text = "X" Then
            Timer1.Enabled = False
            Button2.ForeColor = Color.Red
            Button8.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Timer1.Enabled = False
            Button3.ForeColor = Color.Red
            Button6.ForeColor = Color.Red
            Button9.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Timer1.Enabled = False
            Button1.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Button9.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Timer1.Enabled = False
            Button3.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Button7.ForeColor = Color.Red
            Label5.Text += 1
            MessageBox.Show("You have won")
            numberOfX = numberOfX - 5
            ' O START FORM HERE
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            Timer1.Enabled = False
            Button1.ForeColor = Color.Red
            Button2.ForeColor = Color.Red
            Button3.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            Timer1.Enabled = False
            Button4.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Button6.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            Timer1.Enabled = False
            Button7.ForeColor = Color.Red
            Button8.ForeColor = Color.Red
            Button9.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            Timer1.Enabled = False
            Button1.ForeColor = Color.Red
            Button4.ForeColor = Color.Red
            Button7.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button2.Text = "O" And Button8.Text = "O" And Button5.Text = "O" Then
            Timer1.Enabled = False
            Button2.ForeColor = Color.Red
            Button8.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            Timer1.Enabled = False
            Button3.ForeColor = Color.Red
            Button6.ForeColor = Color.Red
            Button9.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            Timer1.Enabled = False
            Button1.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Button9.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            Timer1.Enabled = False
            Button3.ForeColor = Color.Red
            Button5.ForeColor = Color.Red
            Button7.ForeColor = Color.Red
            Label4.Text += 1
            MessageBox.Show("Your friend have won")
            numberOfX = numberOfX - 5
        End If
        If numberOfX + numberOfO = 9 Then
            Timer1.Enabled = False
            MessageBox.Show("it is a draw")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black
        Button9.ForeColor = Color.Black
        numberOfO = 0
        numberOfX = 0
        Timer1.Enabled = True
    End Sub
End Class