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
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(104, 204)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(75, 23)
        Me.btnRollDice.TabIndex = 0
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(89, 85)
        Me.txtUserInput.MaxLength = 50
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUserInput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.btnRollDice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRollDice As System.Windows.Forms.Button
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox

End Class
