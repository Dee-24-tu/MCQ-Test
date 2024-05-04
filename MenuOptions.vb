Public Class frmmenuoptions

    Private Sub frmmenuoptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

    End Sub

    Private Sub cmbcalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcalculator.Click
        On Error Resume Next
        Me.Hide()
        frmcalculator.Show()

    End Sub

    Private Sub cmbquiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbquiz.Click
        On Error Resume Next
        Me.Hide()
        frmMCQTest1.Show()
    End Sub

    Private Sub cmdhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhelp.Click
        On Error Resume Next
        Me.Hide()
        frmhelp.Show()
    End Sub

    Private Sub cmbexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbexit.Click
        On Error Resume Next
        End
    End Sub

End Class