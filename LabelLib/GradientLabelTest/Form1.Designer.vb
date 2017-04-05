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
        Me.GradientLabel1 = New LabelLib.GradientLabel()
        Me.SuspendLayout()
        '
        'GradientLabel1
        '
        Me.GradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientLabel1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradientLabel1.LeftColor = System.Drawing.Color.Yellow
        Me.GradientLabel1.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GradientLabel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientLabel1.Name = "GradientLabel1"
        Me.GradientLabel1.RightColor = System.Drawing.Color.Blue
        Me.GradientLabel1.Size = New System.Drawing.Size(284, 261)
        Me.GradientLabel1.TabIndex = 0
        Me.GradientLabel1.Text = "Fun Label"
        Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GradientLabel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fun Label Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientLabel1 As LabelLib.GradientLabel

End Class
