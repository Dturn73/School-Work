<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtEnterAGuess = New System.Windows.Forms.TextBox()
        Me.txtEnterAMaxRange = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblEnterAGuess = New System.Windows.Forms.Label()
        Me.lblEnterAMaxRange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEnterAGuess
        '
        Me.txtEnterAGuess.Location = New System.Drawing.Point(117, 75)
        Me.txtEnterAGuess.Name = "txtEnterAGuess"
        Me.txtEnterAGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterAGuess.TabIndex = 0
        '
        'txtEnterAMaxRange
        '
        Me.txtEnterAMaxRange.Location = New System.Drawing.Point(117, 113)
        Me.txtEnterAMaxRange.Name = "txtEnterAMaxRange"
        Me.txtEnterAMaxRange.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterAMaxRange.TabIndex = 1
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(25, 210)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(118, 210)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(210, 210)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblEnterAGuess
        '
        Me.lblEnterAGuess.AutoSize = True
        Me.lblEnterAGuess.Location = New System.Drawing.Point(32, 82)
        Me.lblEnterAGuess.Name = "lblEnterAGuess"
        Me.lblEnterAGuess.Size = New System.Drawing.Size(77, 13)
        Me.lblEnterAGuess.TabIndex = 5
        Me.lblEnterAGuess.Text = "Enter a Guess:"
        '
        'lblEnterAMaxRange
        '
        Me.lblEnterAMaxRange.AutoSize = True
        Me.lblEnterAMaxRange.Location = New System.Drawing.Point(12, 120)
        Me.lblEnterAMaxRange.Name = "lblEnterAMaxRange"
        Me.lblEnterAMaxRange.Size = New System.Drawing.Size(102, 13)
        Me.lblEnterAMaxRange.TabIndex = 6
        Me.lblEnterAMaxRange.Text = "Enter a Max Range:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(305, 268)
        Me.Controls.Add(Me.lblEnterAMaxRange)
        Me.Controls.Add(Me.lblEnterAGuess)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtEnterAMaxRange)
        Me.Controls.Add(Me.txtEnterAGuess)
        Me.Name = "Form1"
        Me.Text = "Assignment4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEnterAGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterAMaxRange As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblEnterAGuess As System.Windows.Forms.Label
    Friend WithEvents lblEnterAMaxRange As System.Windows.Forms.Label

End Class
