<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenuoptions
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
        Me.cmbquiz = New System.Windows.Forms.Button
        Me.cmbcalculator = New System.Windows.Forms.Button
        Me.cmbexit = New System.Windows.Forms.Button
        Me.cmdhelp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbquiz
        '
        Me.cmbquiz.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmbquiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmbquiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbquiz.Location = New System.Drawing.Point(295, 158)
        Me.cmbquiz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbquiz.Name = "cmbquiz"
        Me.cmbquiz.Size = New System.Drawing.Size(149, 35)
        Me.cmbquiz.TabIndex = 1
        Me.cmbquiz.Text = "&MCQ Test"
        Me.cmbquiz.UseVisualStyleBackColor = False
        '
        'cmbcalculator
        '
        Me.cmbcalculator.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmbcalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmbcalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbcalculator.Location = New System.Drawing.Point(295, 241)
        Me.cmbcalculator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbcalculator.Name = "cmbcalculator"
        Me.cmbcalculator.Size = New System.Drawing.Size(149, 35)
        Me.cmbcalculator.TabIndex = 2
        Me.cmbcalculator.Text = "&Calculator"
        Me.cmbcalculator.UseVisualStyleBackColor = False
        '
        'cmbexit
        '
        Me.cmbexit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmbexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmbexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbexit.Location = New System.Drawing.Point(295, 401)
        Me.cmbexit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbexit.Name = "cmbexit"
        Me.cmbexit.Size = New System.Drawing.Size(149, 35)
        Me.cmbexit.TabIndex = 4
        Me.cmbexit.Text = "&Exit"
        Me.cmbexit.UseVisualStyleBackColor = False
        '
        'cmdhelp
        '
        Me.cmdhelp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmdhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdhelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdhelp.Location = New System.Drawing.Point(295, 321)
        Me.cmdhelp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdhelp.Name = "cmdhelp"
        Me.cmdhelp.Size = New System.Drawing.Size(149, 35)
        Me.cmdhelp.TabIndex = 3
        Me.cmdhelp.Text = "&Help"
        Me.cmdhelp.UseVisualStyleBackColor = False
        '
        'frmmenuoptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.cmdhelp)
        Me.Controls.Add(Me.cmbexit)
        Me.Controls.Add(Me.cmbcalculator)
        Me.Controls.Add(Me.cmbquiz)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmmenuoptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbquiz As System.Windows.Forms.Button
    Friend WithEvents cmbcalculator As System.Windows.Forms.Button
    Friend WithEvents cmbexit As System.Windows.Forms.Button
    Friend WithEvents cmdhelp As System.Windows.Forms.Button
End Class
