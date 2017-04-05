<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringBuilder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.updIterations = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.lblStringBuilder = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        CType(Me.updIterations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "String"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Iterations"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(86, 21)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(533, 20)
        Me.txtString.TabIndex = 0
        '
        'updIterations
        '
        Me.updIterations.Location = New System.Drawing.Point(86, 59)
        Me.updIterations.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.updIterations.Name = "updIterations"
        Me.updIterations.Size = New System.Drawing.Size(120, 20)
        Me.updIterations.TabIndex = 1
        Me.updIterations.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNormal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Normal String Concatenation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblStringBuilder)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 42)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "StringBuilder Concatenation"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDifference)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 42)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Difference"
        '
        'lblNormal
        '
        Me.lblNormal.AutoSize = True
        Me.lblNormal.ForeColor = System.Drawing.Color.Blue
        Me.lblNormal.Location = New System.Drawing.Point(71, 26)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(0, 13)
        Me.lblNormal.TabIndex = 0
        '
        'lblStringBuilder
        '
        Me.lblStringBuilder.AutoSize = True
        Me.lblStringBuilder.ForeColor = System.Drawing.Color.Blue
        Me.lblStringBuilder.Location = New System.Drawing.Point(71, 26)
        Me.lblStringBuilder.Name = "lblStringBuilder"
        Me.lblStringBuilder.Size = New System.Drawing.Size(0, 13)
        Me.lblStringBuilder.TabIndex = 1
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.ForeColor = System.Drawing.Color.Blue
        Me.lblDifference.Location = New System.Drawing.Point(71, 16)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(0, 13)
        Me.lblDifference.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(471, 244)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(123, 44)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "G&o"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmStringBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 300)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.updIterations)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStringBuilder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Normal vs StringBuilder Concatenation"
        CType(Me.updIterations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents updIterations As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNormal As System.Windows.Forms.Label
    Friend WithEvents lblStringBuilder As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
