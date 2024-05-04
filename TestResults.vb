Public Class frmTestResults

    Private Sub frmTestResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        On Error Resume Next
        Dim reply As Byte
        reply = MsgBox("Are you sure ", MsgBoxStyle.YesNo, "Exit App")
        If reply = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub lblresults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblresults.Click
        lblFinalScore.Text = "You got" & score & " right answers"
        lblFinishTime.Text = "You took " & (250 - accumulator1) & " seconds to complete the quiz."

        If score >= 5 Then
            lblFinalScore.Text = user & " You have scored " & score & " out of " & 10 & vbCrLf & " You are ready to graduate."
            lblperfomance.Text = "Well Done "
            imgWellDone.Visible = True
        Else
            lblFinishTime.Text = (250 - accumulator1) & " seconds to complete the quiz."
            lblperfomance.Text = "Hard Luck! "
            lblFinalScore.Text = user & " You have scored " & score & " out of " & 10 & vbCrLf & " You need to start again!"
            imgrestart.Visible = True
        End If
    End Sub
End Class