<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignment2
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
        Me.txtFinalExamScore = New System.Windows.Forms.TextBox()
        Me.txtMidtermScore = New System.Windows.Forms.TextBox()
        Me.txtAssignment1 = New System.Windows.Forms.TextBox()
        Me.txtAssignment3 = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblAssignment1 = New System.Windows.Forms.Label()
        Me.lblAssignment2 = New System.Windows.Forms.Label()
        Me.lblAssignment3 = New System.Windows.Forms.Label()
        Me.lblMidtermTextBox = New System.Windows.Forms.Label()
        Me.lblFinalTextBox = New System.Windows.Forms.Label()
        Me.txtAssignment2 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFinalExamScore
        '
        Me.txtFinalExamScore.Location = New System.Drawing.Point(91, 226)
        Me.txtFinalExamScore.Name = "txtFinalExamScore"
        Me.txtFinalExamScore.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalExamScore.TabIndex = 4
        '
        'txtMidtermScore
        '
        Me.txtMidtermScore.Location = New System.Drawing.Point(91, 178)
        Me.txtMidtermScore.Name = "txtMidtermScore"
        Me.txtMidtermScore.Size = New System.Drawing.Size(100, 20)
        Me.txtMidtermScore.TabIndex = 3
        '
        'txtAssignment1
        '
        Me.txtAssignment1.Location = New System.Drawing.Point(91, 48)
        Me.txtAssignment1.Name = "txtAssignment1"
        Me.txtAssignment1.Size = New System.Drawing.Size(100, 20)
        Me.txtAssignment1.TabIndex = 0
        '
        'txtAssignment3
        '
        Me.txtAssignment3.Location = New System.Drawing.Point(91, 133)
        Me.txtAssignment3.Name = "txtAssignment3"
        Me.txtAssignment3.Size = New System.Drawing.Size(100, 20)
        Me.txtAssignment3.TabIndex = 2
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(91, 266)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(100, 20)
        Me.txtResults.TabIndex = 5
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(19, 273)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(42, 13)
        Me.lblResult.TabIndex = 14
        Me.lblResult.Text = "Results"
        '
        'lblAssignment1
        '
        Me.lblAssignment1.AutoSize = True
        Me.lblAssignment1.Location = New System.Drawing.Point(9, 51)
        Me.lblAssignment1.Name = "lblAssignment1"
        Me.lblAssignment1.Size = New System.Drawing.Size(70, 13)
        Me.lblAssignment1.TabIndex = 9
        Me.lblAssignment1.Text = "Assignment 1"
        '
        'lblAssignment2
        '
        Me.lblAssignment2.AutoSize = True
        Me.lblAssignment2.Location = New System.Drawing.Point(12, 91)
        Me.lblAssignment2.Name = "lblAssignment2"
        Me.lblAssignment2.Size = New System.Drawing.Size(70, 13)
        Me.lblAssignment2.TabIndex = 10
        Me.lblAssignment2.Text = "Assignment 2"
        '
        'lblAssignment3
        '
        Me.lblAssignment3.AutoSize = True
        Me.lblAssignment3.Location = New System.Drawing.Point(12, 133)
        Me.lblAssignment3.Name = "lblAssignment3"
        Me.lblAssignment3.Size = New System.Drawing.Size(70, 13)
        Me.lblAssignment3.TabIndex = 11
        Me.lblAssignment3.Text = "Assignment 3"
        '
        'lblMidtermTextBox
        '
        Me.lblMidtermTextBox.AutoSize = True
        Me.lblMidtermTextBox.Location = New System.Drawing.Point(19, 181)
        Me.lblMidtermTextBox.Name = "lblMidtermTextBox"
        Me.lblMidtermTextBox.Size = New System.Drawing.Size(44, 13)
        Me.lblMidtermTextBox.TabIndex = 12
        Me.lblMidtermTextBox.Text = "Midterm"
        '
        'lblFinalTextBox
        '
        Me.lblFinalTextBox.AutoSize = True
        Me.lblFinalTextBox.Location = New System.Drawing.Point(26, 229)
        Me.lblFinalTextBox.Name = "lblFinalTextBox"
        Me.lblFinalTextBox.Size = New System.Drawing.Size(29, 13)
        Me.lblFinalTextBox.TabIndex = 13
        Me.lblFinalTextBox.Text = "Final"
        '
        'txtAssignment2
        '
        Me.txtAssignment2.Location = New System.Drawing.Point(91, 91)
        Me.txtAssignment2.Name = "txtAssignment2"
        Me.txtAssignment2.Size = New System.Drawing.Size(100, 20)
        Me.txtAssignment2.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(91, 316)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(110, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Score"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(91, 361)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(91, 404)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(110, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmAssignment2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 448)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblFinalTextBox)
        Me.Controls.Add(Me.lblMidtermTextBox)
        Me.Controls.Add(Me.lblAssignment3)
        Me.Controls.Add(Me.lblAssignment2)
        Me.Controls.Add(Me.lblAssignment1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtAssignment3)
        Me.Controls.Add(Me.txtAssignment2)
        Me.Controls.Add(Me.txtAssignment1)
        Me.Controls.Add(Me.txtMidtermScore)
        Me.Controls.Add(Me.txtFinalExamScore)
        Me.Name = "frmAssignment2"
        Me.Text = "Assignment 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFinalExamScore As System.Windows.Forms.TextBox
    Friend WithEvents txtMidtermScore As System.Windows.Forms.TextBox
    Friend WithEvents txtAssignment1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAssignment3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblAssignment1 As System.Windows.Forms.Label
    Friend WithEvents lblAssignment2 As System.Windows.Forms.Label
    Friend WithEvents lblAssignment3 As System.Windows.Forms.Label
    Friend WithEvents lblMidtermTextBox As System.Windows.Forms.Label
    Friend WithEvents lblFinalTextBox As System.Windows.Forms.Label
    Friend WithEvents txtAssignment2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
