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
        Me.CBO1 = New System.Windows.Forms.ComboBox()
        Me.CBO2 = New System.Windows.Forms.ComboBox()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnGetBalance = New System.Windows.Forms.Button()
        Me.btnShowBankAssets = New System.Windows.Forms.Button()
        Me.btnShowBalance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBO1
        '
        Me.CBO1.FormattingEnabled = True
        Me.CBO1.Location = New System.Drawing.Point(24, 43)
        Me.CBO1.Name = "CBO1"
        Me.CBO1.Size = New System.Drawing.Size(121, 21)
        Me.CBO1.TabIndex = 0
        Me.CBO1.Visible = False
        '
        'CBO2
        '
        Me.CBO2.FormattingEnabled = True
        Me.CBO2.Location = New System.Drawing.Point(207, 43)
        Me.CBO2.Name = "CBO2"
        Me.CBO2.Size = New System.Drawing.Size(121, 21)
        Me.CBO2.TabIndex = 1
        Me.CBO2.TabStop = False
        Me.CBO2.Visible = False
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(46, 110)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(99, 40)
        Me.btnGetData.TabIndex = 2
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnGetBalance
        '
        Me.btnGetBalance.Location = New System.Drawing.Point(207, 162)
        Me.btnGetBalance.Name = "btnGetBalance"
        Me.btnGetBalance.Size = New System.Drawing.Size(99, 40)
        Me.btnGetBalance.TabIndex = 5
        Me.btnGetBalance.Text = "Balances < $5000"
        Me.btnGetBalance.UseVisualStyleBackColor = True
        '
        'btnShowBankAssets
        '
        Me.btnShowBankAssets.Location = New System.Drawing.Point(207, 110)
        Me.btnShowBankAssets.Name = "btnShowBankAssets"
        Me.btnShowBankAssets.Size = New System.Drawing.Size(99, 40)
        Me.btnShowBankAssets.TabIndex = 3
        Me.btnShowBankAssets.Text = "Show Bank Assets"
        Me.btnShowBankAssets.UseVisualStyleBackColor = True
        '
        'btnShowBalance
        '
        Me.btnShowBalance.Location = New System.Drawing.Point(46, 162)
        Me.btnShowBalance.Name = "btnShowBalance"
        Me.btnShowBalance.Size = New System.Drawing.Size(99, 40)
        Me.btnShowBalance.TabIndex = 4
        Me.btnShowBalance.Text = "Show Balance"
        Me.btnShowBalance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 248)
        Me.Controls.Add(Me.btnShowBankAssets)
        Me.Controls.Add(Me.btnShowBalance)
        Me.Controls.Add(Me.btnGetBalance)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.CBO2)
        Me.Controls.Add(Me.CBO1)
        Me.Name = "Form1"
        Me.Text = "Assignmen 10"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBO1 As System.Windows.Forms.ComboBox
    Friend WithEvents CBO2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents btnGetBalance As System.Windows.Forms.Button
    Friend WithEvents btnShowBankAssets As System.Windows.Forms.Button
    Friend WithEvents btnShowBalance As System.Windows.Forms.Button

End Class
