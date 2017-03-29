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
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.btnCheckPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(96, 95)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtUserPassword.TabIndex = 0
        '
        'btnCheckPassword
        '
        Me.btnCheckPassword.Location = New System.Drawing.Point(86, 179)
        Me.btnCheckPassword.Name = "btnCheckPassword"
        Me.btnCheckPassword.Size = New System.Drawing.Size(122, 39)
        Me.btnCheckPassword.TabIndex = 1
        Me.btnCheckPassword.Text = "Check Password"
        Me.btnCheckPassword.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCheckPassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCheckPassword)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Name = "Form1"
        Me.Text = "Password Check"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCheckPassword As System.Windows.Forms.Button

End Class
