<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCQTest1
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
        Me.components = New System.ComponentModel.Container
        Me.tmrcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblqcount = New System.Windows.Forms.Label
        Me.lbloption3 = New System.Windows.Forms.Label
        Me.lblindex4 = New System.Windows.Forms.Label
        Me.lbloption1 = New System.Windows.Forms.Label
        Me.lbloption2 = New System.Windows.Forms.Label
        Me.lblindex3 = New System.Windows.Forms.Label
        Me.lblindex2 = New System.Windows.Forms.Label
        Me.lblindex1 = New System.Windows.Forms.Label
        Me.lblanswerfeedb = New System.Windows.Forms.Label
        Me.lblqindex = New System.Windows.Forms.Label
        Me.lblquestion = New System.Windows.Forms.Label
        Me.lblqno = New System.Windows.Forms.Label
        Me.cmbexit = New System.Windows.Forms.Button
        Me.lbloption4 = New System.Windows.Forms.Label
        Me.cmdnext = New System.Windows.Forms.Button
        Me.lblcounter = New System.Windows.Forms.Label
        Me.txtanswer = New System.Windows.Forms.TextBox
        Me.lblinstruction = New System.Windows.Forms.Label
        Me.lblheading = New System.Windows.Forms.Label
        Me.cmdstartest = New System.Windows.Forms.Button
        Me.lblsubh = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'lblqcount
        '
        Me.lblqcount.AutoSize = True
        Me.lblqcount.Location = New System.Drawing.Point(507, 128)
        Me.lblqcount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblqcount.Name = "lblqcount"
        Me.lblqcount.Size = New System.Drawing.Size(141, 20)
        Me.lblqcount.TabIndex = 7
        Me.lblqcount.Text = "What is your score???"
        '
        'lbloption3
        '
        Me.lbloption3.AutoSize = True
        Me.lbloption3.BackColor = System.Drawing.Color.MintCream
        Me.lbloption3.Location = New System.Drawing.Point(120, 276)
        Me.lbloption3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbloption3.Name = "lbloption3"
        Me.lbloption3.Size = New System.Drawing.Size(30, 20)
        Me.lbloption3.TabIndex = 13
        Me.lbloption3.Text = "???"
        '
        'lblindex4
        '
        Me.lblindex4.AutoSize = True
        Me.lblindex4.Location = New System.Drawing.Point(87, 318)
        Me.lblindex4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblindex4.Name = "lblindex4"
        Me.lblindex4.Size = New System.Drawing.Size(25, 20)
        Me.lblindex4.TabIndex = 14
        Me.lblindex4.Text = "(d)"
        '
        'lbloption1
        '
        Me.lbloption1.AutoSize = True
        Me.lbloption1.BackColor = System.Drawing.Color.MintCream
        Me.lbloption1.Location = New System.Drawing.Point(120, 203)
        Me.lbloption1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbloption1.Name = "lbloption1"
        Me.lbloption1.Size = New System.Drawing.Size(30, 20)
        Me.lbloption1.TabIndex = 9
        Me.lbloption1.Text = "???"
        '
        'lbloption2
        '
        Me.lbloption2.AutoSize = True
        Me.lbloption2.BackColor = System.Drawing.Color.MintCream
        Me.lbloption2.Location = New System.Drawing.Point(120, 239)
        Me.lbloption2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbloption2.Name = "lbloption2"
        Me.lbloption2.Size = New System.Drawing.Size(30, 20)
        Me.lbloption2.TabIndex = 11
        Me.lbloption2.Text = "???"
        '
        'lblindex3
        '
        Me.lblindex3.AutoSize = True
        Me.lblindex3.Location = New System.Drawing.Point(87, 276)
        Me.lblindex3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblindex3.Name = "lblindex3"
        Me.lblindex3.Size = New System.Drawing.Size(24, 20)
        Me.lblindex3.TabIndex = 12
        Me.lblindex3.Text = "(c)"
        '
        'lblindex2
        '
        Me.lblindex2.AutoSize = True
        Me.lblindex2.Location = New System.Drawing.Point(87, 239)
        Me.lblindex2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblindex2.Name = "lblindex2"
        Me.lblindex2.Size = New System.Drawing.Size(25, 20)
        Me.lblindex2.TabIndex = 10
        Me.lblindex2.Text = "(b)"
        '
        'lblindex1
        '
        Me.lblindex1.AutoSize = True
        Me.lblindex1.Location = New System.Drawing.Point(87, 203)
        Me.lblindex1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblindex1.Name = "lblindex1"
        Me.lblindex1.Size = New System.Drawing.Size(24, 20)
        Me.lblindex1.TabIndex = 8
        Me.lblindex1.Text = "(a)"
        '
        'lblanswerfeedb
        '
        Me.lblanswerfeedb.AutoSize = True
        Me.lblanswerfeedb.Location = New System.Drawing.Point(507, 90)
        Me.lblanswerfeedb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblanswerfeedb.Name = "lblanswerfeedb"
        Me.lblanswerfeedb.Size = New System.Drawing.Size(30, 20)
        Me.lblanswerfeedb.TabIndex = 5
        Me.lblanswerfeedb.Text = "???"
        '
        'lblqindex
        '
        Me.lblqindex.AutoSize = True
        Me.lblqindex.Location = New System.Drawing.Point(182, 90)
        Me.lblqindex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblqindex.Name = "lblqindex"
        Me.lblqindex.Size = New System.Drawing.Size(30, 20)
        Me.lblqindex.TabIndex = 4
        Me.lblqindex.Text = "???"
        '
        'lblquestion
        '
        Me.lblquestion.Location = New System.Drawing.Point(87, 128)
        Me.lblquestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(412, 41)
        Me.lblquestion.TabIndex = 6
        Me.lblquestion.Text = "Question...???"
        '
        'lblqno
        '
        Me.lblqno.AutoSize = True
        Me.lblqno.Location = New System.Drawing.Point(87, 90)
        Me.lblqno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblqno.Name = "lblqno"
        Me.lblqno.Size = New System.Drawing.Size(87, 20)
        Me.lblqno.TabIndex = 3
        Me.lblqno.Text = "Question No:"
        '
        'cmbexit
        '
        Me.cmbexit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmbexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmbexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbexit.Location = New System.Drawing.Point(507, 412)
        Me.cmbexit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbexit.Name = "cmbexit"
        Me.cmbexit.Size = New System.Drawing.Size(100, 35)
        Me.cmbexit.TabIndex = 20
        Me.cmbexit.Text = "&Exit"
        Me.cmbexit.UseVisualStyleBackColor = False
        '
        'lbloption4
        '
        Me.lbloption4.AutoSize = True
        Me.lbloption4.BackColor = System.Drawing.Color.MintCream
        Me.lbloption4.Location = New System.Drawing.Point(120, 318)
        Me.lbloption4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbloption4.Name = "lbloption4"
        Me.lbloption4.Size = New System.Drawing.Size(30, 20)
        Me.lbloption4.TabIndex = 15
        Me.lbloption4.Text = "???"
        '
        'cmdnext
        '
        Me.cmdnext.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmdnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdnext.Location = New System.Drawing.Point(138, 412)
        Me.cmdnext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(100, 35)
        Me.cmdnext.TabIndex = 19
        Me.cmdnext.Text = "&Next"
        Me.cmdnext.UseVisualStyleBackColor = False
        '
        'lblcounter
        '
        Me.lblcounter.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcounter.Location = New System.Drawing.Point(448, 353)
        Me.lblcounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcounter.Name = "lblcounter"
        Me.lblcounter.Size = New System.Drawing.Size(159, 43)
        Me.lblcounter.TabIndex = 18
        Me.lblcounter.Text = "You have 25 Seconds to complete the quiz."
        '
        'txtanswer
        '
        Me.txtanswer.BackColor = System.Drawing.Color.MintCream
        Me.txtanswer.Location = New System.Drawing.Point(250, 364)
        Me.txtanswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(100, 26)
        Me.txtanswer.TabIndex = 17
        '
        'lblinstruction
        '
        Me.lblinstruction.Location = New System.Drawing.Point(87, 353)
        Me.lblinstruction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinstruction.Name = "lblinstruction"
        Me.lblinstruction.Size = New System.Drawing.Size(154, 43)
        Me.lblinstruction.TabIndex = 16
        Me.lblinstruction.Text = "Enter your answer here: a, b, c, or d and click next."
        '
        'lblheading
        '
        Me.lblheading.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lblheading.Font = New System.Drawing.Font("Arial Narrow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblheading.Location = New System.Drawing.Point(124, 26)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(451, 53)
        Me.lblheading.TabIndex = 0
        Me.lblheading.Text = "The test consist of 10 questions with 4 options and only one answer is correct. E" & _
            "nter A,B, C, or D in the text field."
        Me.lblheading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdstartest
        '
        Me.cmdstartest.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmdstartest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdstartest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdstartest.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstartest.Location = New System.Drawing.Point(252, 203)
        Me.cmdstartest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdstartest.Name = "cmdstartest"
        Me.cmdstartest.Size = New System.Drawing.Size(169, 91)
        Me.cmdstartest.TabIndex = 2
        Me.cmdstartest.Text = "&Start"
        Me.cmdstartest.UseVisualStyleBackColor = False
        Me.cmdstartest.Visible = False
        '
        'lblsubh
        '
        Me.lblsubh.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lblsubh.Font = New System.Drawing.Font("Arial Narrow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblsubh.Location = New System.Drawing.Point(283, 97)
        Me.lblsubh.Name = "lblsubh"
        Me.lblsubh.Size = New System.Drawing.Size(138, 51)
        Me.lblsubh.TabIndex = 1
        Me.lblsubh.Text = "When ""Ready"" press ""Start""."
        Me.lblsubh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblsubh.Visible = False
        '
        'frmMCQTest1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblsubh)
        Me.Controls.Add(Me.cmdstartest)
        Me.Controls.Add(Me.lblheading)
        Me.Controls.Add(Me.lblqcount)
        Me.Controls.Add(Me.lbloption3)
        Me.Controls.Add(Me.lblindex4)
        Me.Controls.Add(Me.lbloption1)
        Me.Controls.Add(Me.lbloption2)
        Me.Controls.Add(Me.lblindex3)
        Me.Controls.Add(Me.lblindex2)
        Me.Controls.Add(Me.lblindex1)
        Me.Controls.Add(Me.lblanswerfeedb)
        Me.Controls.Add(Me.lblqindex)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.lblqno)
        Me.Controls.Add(Me.cmbexit)
        Me.Controls.Add(Me.lbloption4)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.lblcounter)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.lblinstruction)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMCQTest1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrcountdown As System.Windows.Forms.Timer
    Friend WithEvents lblqcount As System.Windows.Forms.Label
    Friend WithEvents lbloption3 As System.Windows.Forms.Label
    Friend WithEvents lblindex4 As System.Windows.Forms.Label
    Friend WithEvents lbloption1 As System.Windows.Forms.Label
    Friend WithEvents lbloption2 As System.Windows.Forms.Label
    Friend WithEvents lblindex3 As System.Windows.Forms.Label
    Friend WithEvents lblindex2 As System.Windows.Forms.Label
    Friend WithEvents lblindex1 As System.Windows.Forms.Label
    Friend WithEvents lblanswerfeedb As System.Windows.Forms.Label
    Friend WithEvents lblqindex As System.Windows.Forms.Label
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents lblqno As System.Windows.Forms.Label
    Friend WithEvents cmbexit As System.Windows.Forms.Button
    Friend WithEvents lbloption4 As System.Windows.Forms.Label
    Friend WithEvents cmdnext As System.Windows.Forms.Button
    Friend WithEvents lblcounter As System.Windows.Forms.Label
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents lblinstruction As System.Windows.Forms.Label
    Friend WithEvents lblheading As System.Windows.Forms.Label
    Friend WithEvents cmdstartest As System.Windows.Forms.Button
    Friend WithEvents lblsubh As System.Windows.Forms.Label
End Class
