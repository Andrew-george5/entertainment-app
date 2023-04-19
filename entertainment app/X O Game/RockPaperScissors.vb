Public Class RockPaperScissors
    Dim rock, paper, sesores, answer As Integer
    Dim robot As New Random
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Hide()
        Home.Show()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox5.Image = PictureBox1.Image
        rock = 1
        answer = robot.Next(1, 4)
        If answer = 1 Then
            PictureBox4.Image = PictureBox1.Image
        ElseIf answer = 2 Then
            PictureBox4.Image = PictureBox2.Image
        Else
            PictureBox4.Image = PictureBox3.Image
        End If
        If rock = answer Then
            MsgBox("it is a draw")
        ElseIf rock = answer - 2 Then
            Label1.Text = Label1.Text + 1
        Else
            Label3.Text = Label3.Text + 1
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox5.Image = PictureBox2.Image
        paper = 2
        answer = robot.Next(1, 4)
        If answer = 1 Then
            PictureBox4.Image = PictureBox1.Image
        ElseIf answer = 2 Then
            PictureBox4.Image = PictureBox2.Image
        Else
            PictureBox4.Image = PictureBox3.Image
        End If
        If paper = answer Then
            MsgBox("it is a draw")
        ElseIf paper = answer + 1 Then
            Label1.Text = Label1.Text + 1
        Else
            Label3.Text = Label3.Text + 1
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox5.Image = PictureBox3.Image
        sesores = 3
        answer = robot.Next(1, 4)
        If answer = 1 Then
            PictureBox4.Image = PictureBox1.Image
        ElseIf answer = 2 Then
            PictureBox4.Image = PictureBox2.Image
        Else
            PictureBox4.Image = PictureBox3.Image
        End If
        If sesores = answer Then
            MsgBox("it is a draw")
        ElseIf sesores = answer + 1 Then
            Label1.Text = Label1.Text + 1
        Else
            Label3.Text = Label3.Text + 1
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
