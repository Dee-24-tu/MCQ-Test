<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestResults))
        Me.lblresults = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.lblFinalScore = New System.Windows.Forms.Label
        Me.lblFinishTime = New System.Windows.Forms.Label
        Me.imgWellDone = New System.Windows.Forms.PictureBox
        Me.imgrestart = New System.Windows.Forms.PictureBox
        Me.lblperfomance = New System.Windows.Forms.Label
        CType(Me.imgWellDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgrestart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblresults
        '
        Me.lblresults.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lblresults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.lblresults.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblresults.Location = New System.Drawing.Point(123, 282)
        Me.lblresults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblresults.Name = "lblresults"
        Me.lblresults.Size = New System.Drawing.Size(100, 35)
        Me.lblresults.TabIndex = 0
        Me.lblresults.Text = "&Display Results"
        Me.lblresults.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmdexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Location = New System.Drawing.Point(123, 367)
        Me.cmdexit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(100, 35)
        Me.cmdexit.TabIndex = 1
        Me.cmdexit.Text = "&Exit "
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Location = New System.Drawing.Point(121, 132)
        Me.lblFinalScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(102, 20)
        Me.lblFinalScore.TabIndex = 2
        Me.lblFinalScore.Text = "Final Score ???"
        '
        'lblFinishTime
        '
        Me.lblFinishTime.Location = New System.Drawing.Point(121, 201)
        Me.lblFinishTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinishTime.Name = "lblFinishTime"
        Me.lblFinishTime.Size = New System.Drawing.Size(232, 49)
        Me.lblFinishTime.TabIndex = 3
        Me.lblFinishTime.Text = "Time taken to complete the test???"
        '
        'imgWellDone
        '
        Me.imgWellDone.Image = CType(resources.GetObject("imgWellDone.Image"), System.Drawing.Image)
        Me.imgWellDone.Location = New System.Drawing.Point(389, 122)
        Me.imgWellDone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imgWellDone.Name = "imgWellDone"
        Me.imgWellDone.Size = New System.Drawing.Size(255, 280)
        Me.imgWellDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgWellDone.TabIndex = 4
        Me.imgWellDone.TabStop = False
        Me.imgWellDone.Visible = False
        '
        'imgrestart
        '
        Me.imgrestart.Image = CType(resources.GetObject("imgrestart.Image"), System.Drawing.Image)
        Me.imgrestart.Location = New System.Drawing.Point(389, 122)
        Me.imgrestart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imgrestart.Name = "imgrestart"
        Me.imgrestart.Size = New System.Drawing.Size(242, 280)
        Me.imgrestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgrestart.TabIndex = 5
        Me.imgrestart.TabStop = False
        Me.imgrestart.Visible = False
        '
        'lblperfomance
        '
        Me.lblperfomance.AutoSize = True
        Me.lblperfomance.Location = New System.Drawing.Point(404, 83)
        Me.lblperfomance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblperfomance.Name = "lblperfomance"
        Me.lblperfomance.Size = New System.Drawing.Size(137, 20)
        Me.lblperfomance.TabIndex = 6
        Me.lblperfomance.Text = "How did you do...???"
        '
        'frmTestResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblperfomance)
        Me.Controls.Add(Me.imgrestart)
        Me.Controls.Add(Me.imgWellDone)
        Me.Controls.Add(Me.lblFinishTime)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.lblresults)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTestResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Results"
        CType(Me.imgWellDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgrestart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblresults As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents lblFinalScore As System.Windows.Forms.Label
    Friend WithEvents lblFinishTime As System.Windows.Forms.Label
    Friend WithEvents imgWellDone As System.Windows.Forms.PictureBox
    Friend WithEvents imgrestart As System.Windows.Forms.PictureBox
    Friend WithEvents lblperfomance As System.Windows.Forms.Label
End Class
