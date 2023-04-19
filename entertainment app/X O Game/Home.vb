Public Class Home

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        YouVsBeginnerRobot.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        YouVsExpertRobot.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        YouVsYourFriend.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.Click
        RockPaperScissors.Show()
        Me.Hide()
    End Sub
End Class
