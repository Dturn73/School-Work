<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSharedClass
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
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Arizona", "California", "Idaho", "Nevada", "Oregon", "Washington"})
        Me.cboState.Location = New System.Drawing.Point(147, 50)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(174, 21)
        Me.cboState.TabIndex = 0
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(147, 131)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(174, 20)
        Me.txtCapital.TabIndex = 1
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(66, 58)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(63, 13)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "State Name"
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(66, 138)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(39, 13)
        Me.lblCapital.TabIndex = 3
        Me.lblCapital.Text = "Capital"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(222, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(102, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "S&ave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSharedClass
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(379, 310)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.cboState)
        Me.Name = "frmSharedClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capital Cities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents txtCapital As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCapital As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
