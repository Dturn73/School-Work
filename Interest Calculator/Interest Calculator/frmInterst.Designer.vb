<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterst
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
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtTimesCompounded = New System.Windows.Forms.TextBox()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblAnnualInterestRate = New System.Windows.Forms.Label()
        Me.lblTimesCompounded = New System.Windows.Forms.Label()
        Me.txtSimpleInterest = New System.Windows.Forms.TextBox()
        Me.txtCompoundInterest = New System.Windows.Forms.TextBox()
        Me.txtContinuousCompounding = New System.Windows.Forms.TextBox()
        Me.lblSimpleInterest = New System.Windows.Forms.Label()
        Me.lblCompoundInterest = New System.Windows.Forms.Label()
        Me.lblContinuous = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(53, 36)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(47, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Principal"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(211, 29)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(158, 20)
        Me.txtPrincipal.TabIndex = 1
        Me.txtPrincipal.Text = "6000"
        Me.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(294, 294)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(211, 55)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(158, 20)
        Me.txtYears.TabIndex = 3
        Me.txtYears.Text = "7"
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(211, 81)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(158, 20)
        Me.txtInterestRate.TabIndex = 4
        Me.txtInterestRate.Text = "4.0"
        Me.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTimesCompounded
        '
        Me.txtTimesCompounded.Location = New System.Drawing.Point(211, 107)
        Me.txtTimesCompounded.Name = "txtTimesCompounded"
        Me.txtTimesCompounded.Size = New System.Drawing.Size(158, 20)
        Me.txtTimesCompounded.TabIndex = 5
        Me.txtTimesCompounded.Text = "12"
        Me.txtTimesCompounded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(53, 62)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(34, 13)
        Me.lblYears.TabIndex = 6
        Me.lblYears.Text = "Years"
        '
        'lblAnnualInterestRate
        '
        Me.lblAnnualInterestRate.AutoSize = True
        Me.lblAnnualInterestRate.Location = New System.Drawing.Point(53, 88)
        Me.lblAnnualInterestRate.Name = "lblAnnualInterestRate"
        Me.lblAnnualInterestRate.Size = New System.Drawing.Size(104, 13)
        Me.lblAnnualInterestRate.TabIndex = 7
        Me.lblAnnualInterestRate.Text = "Annual Interest Rate"
        '
        'lblTimesCompounded
        '
        Me.lblTimesCompounded.AutoSize = True
        Me.lblTimesCompounded.Location = New System.Drawing.Point(53, 114)
        Me.lblTimesCompounded.Name = "lblTimesCompounded"
        Me.lblTimesCompounded.Size = New System.Drawing.Size(128, 13)
        Me.lblTimesCompounded.TabIndex = 8
        Me.lblTimesCompounded.Text = "Times Compounded/Year"
        '
        'txtSimpleInterest
        '
        Me.txtSimpleInterest.ForeColor = System.Drawing.Color.Blue
        Me.txtSimpleInterest.Location = New System.Drawing.Point(211, 187)
        Me.txtSimpleInterest.Name = "txtSimpleInterest"
        Me.txtSimpleInterest.ReadOnly = True
        Me.txtSimpleInterest.Size = New System.Drawing.Size(158, 20)
        Me.txtSimpleInterest.TabIndex = 9
        Me.txtSimpleInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCompoundInterest
        '
        Me.txtCompoundInterest.ForeColor = System.Drawing.Color.Blue
        Me.txtCompoundInterest.Location = New System.Drawing.Point(211, 213)
        Me.txtCompoundInterest.Name = "txtCompoundInterest"
        Me.txtCompoundInterest.ReadOnly = True
        Me.txtCompoundInterest.Size = New System.Drawing.Size(158, 20)
        Me.txtCompoundInterest.TabIndex = 10
        Me.txtCompoundInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContinuousCompounding
        '
        Me.txtContinuousCompounding.ForeColor = System.Drawing.Color.Blue
        Me.txtContinuousCompounding.Location = New System.Drawing.Point(211, 239)
        Me.txtContinuousCompounding.Name = "txtContinuousCompounding"
        Me.txtContinuousCompounding.ReadOnly = True
        Me.txtContinuousCompounding.Size = New System.Drawing.Size(158, 20)
        Me.txtContinuousCompounding.TabIndex = 11
        Me.txtContinuousCompounding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSimpleInterest
        '
        Me.lblSimpleInterest.AutoSize = True
        Me.lblSimpleInterest.Location = New System.Drawing.Point(53, 194)
        Me.lblSimpleInterest.Name = "lblSimpleInterest"
        Me.lblSimpleInterest.Size = New System.Drawing.Size(76, 13)
        Me.lblSimpleInterest.TabIndex = 12
        Me.lblSimpleInterest.Text = "Simple Interest"
        '
        'lblCompoundInterest
        '
        Me.lblCompoundInterest.AutoSize = True
        Me.lblCompoundInterest.Location = New System.Drawing.Point(53, 220)
        Me.lblCompoundInterest.Name = "lblCompoundInterest"
        Me.lblCompoundInterest.Size = New System.Drawing.Size(96, 13)
        Me.lblCompoundInterest.TabIndex = 13
        Me.lblCompoundInterest.Text = "Compound Interest"
        '
        'lblContinuous
        '
        Me.lblContinuous.AutoSize = True
        Me.lblContinuous.Location = New System.Drawing.Point(53, 246)
        Me.lblContinuous.Name = "lblContinuous"
        Me.lblContinuous.Size = New System.Drawing.Size(128, 13)
        Me.lblContinuous.TabIndex = 14
        Me.lblContinuous.Text = "Continuous Compounding"
        '
        'lblDivider
        '
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(32, 155)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(337, 3)
        Me.lblDivider.TabIndex = 15
        '
        'frmInterst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 342)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblContinuous)
        Me.Controls.Add(Me.lblCompoundInterest)
        Me.Controls.Add(Me.lblSimpleInterest)
        Me.Controls.Add(Me.txtContinuousCompounding)
        Me.Controls.Add(Me.txtCompoundInterest)
        Me.Controls.Add(Me.txtSimpleInterest)
        Me.Controls.Add(Me.lblTimesCompounded)
        Me.Controls.Add(Me.lblAnnualInterestRate)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.txtTimesCompounded)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "frmInterst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple vs. Compound Interest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrincipal As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents txtTimesCompounded As System.Windows.Forms.TextBox
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents lblAnnualInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblTimesCompounded As System.Windows.Forms.Label
    Friend WithEvents txtSimpleInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtCompoundInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtContinuousCompounding As System.Windows.Forms.TextBox
    Friend WithEvents lblSimpleInterest As System.Windows.Forms.Label
    Friend WithEvents lblCompoundInterest As System.Windows.Forms.Label
    Friend WithEvents lblContinuous As System.Windows.Forms.Label
    Friend WithEvents lblDivider As System.Windows.Forms.Label
End Class
