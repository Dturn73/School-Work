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
        Me.RoomInformation = New System.Windows.Forms.GroupBox()
        Me.gbxMiscellaneousCharges = New System.Windows.Forms.GroupBox()
        Me.lblHighlanderHotel = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblNightlyCharge = New System.Windows.Forms.Label()
        Me.lnlRoomService = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblMisc = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtNightlyCharges = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.txtRoomCharges = New System.Windows.Forms.TextBox()
        Me.txtAddCharges = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCharges = New System.Windows.Forms.TextBox()
        Me.btnCalculateCharges = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDisplayDate = New System.Windows.Forms.Label()
        Me.lblDisplayTime = New System.Windows.Forms.Label()
        Me.RoomInformation.SuspendLayout()
        Me.gbxMiscellaneousCharges.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RoomInformation
        '
        Me.RoomInformation.Controls.Add(Me.txtNightlyCharges)
        Me.RoomInformation.Controls.Add(Me.txtNights)
        Me.RoomInformation.Controls.Add(Me.lblNightlyCharge)
        Me.RoomInformation.Controls.Add(Me.lblNights)
        Me.RoomInformation.Font = New System.Drawing.Font("Helvetica", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomInformation.Location = New System.Drawing.Point(22, 145)
        Me.RoomInformation.Name = "RoomInformation"
        Me.RoomInformation.Size = New System.Drawing.Size(241, 100)
        Me.RoomInformation.TabIndex = 5
        Me.RoomInformation.TabStop = False
        Me.RoomInformation.Text = "Room Information"
        '
        'gbxMiscellaneousCharges
        '
        Me.gbxMiscellaneousCharges.Controls.Add(Me.txtMisc)
        Me.gbxMiscellaneousCharges.Controls.Add(Me.txtTelephone)
        Me.gbxMiscellaneousCharges.Controls.Add(Me.txtRoomService)
        Me.gbxMiscellaneousCharges.Controls.Add(Me.lblMisc)
        Me.gbxMiscellaneousCharges.Controls.Add(Me.lblTelephone)
        Me.gbxMiscellaneousCharges.Controls.Add(Me.lnlRoomService)
        Me.gbxMiscellaneousCharges.Location = New System.Drawing.Point(269, 145)
        Me.gbxMiscellaneousCharges.Name = "gbxMiscellaneousCharges"
        Me.gbxMiscellaneousCharges.Size = New System.Drawing.Size(241, 100)
        Me.gbxMiscellaneousCharges.TabIndex = 6
        Me.gbxMiscellaneousCharges.TabStop = False
        Me.gbxMiscellaneousCharges.Text = "Misc Charges"
        '
        'lblHighlanderHotel
        '
        Me.lblHighlanderHotel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHighlanderHotel.Font = New System.Drawing.Font("Helvetica", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighlanderHotel.Location = New System.Drawing.Point(101, 25)
        Me.lblHighlanderHotel.Name = "lblHighlanderHotel"
        Me.lblHighlanderHotel.Size = New System.Drawing.Size(346, 44)
        Me.lblHighlanderHotel.TabIndex = 0
        Me.lblHighlanderHotel.Text = "Highlander Hotel"
        Me.lblHighlanderHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.Location = New System.Drawing.Point(88, 91)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(91, 15)
        Me.lblDateToday.TabIndex = 1
        Me.lblDateToday.Text = " Today's Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(139, 119)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(40, 15)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Time:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotalCharges)
        Me.GroupBox1.Controls.Add(Me.txtTax)
        Me.GroupBox1.Controls.Add(Me.txtSubtotal)
        Me.GroupBox1.Controls.Add(Me.txtAddCharges)
        Me.GroupBox1.Controls.Add(Me.txtRoomCharges)
        Me.GroupBox1.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblAddCharges)
        Me.GroupBox1.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 177)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Charges"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharges.Location = New System.Drawing.Point(53, 137)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(92, 15)
        Me.lblTotalCharges.TabIndex = 8
        Me.lblTotalCharges.Text = "Total Charges:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(112, 113)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(33, 15)
        Me.lblTax.TabIndex = 6
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(86, 87)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(59, 15)
        Me.lblSubtotal.TabIndex = 4
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblAddCharges
        '
        Me.lblAddCharges.AutoSize = True
        Me.lblAddCharges.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddCharges.Location = New System.Drawing.Point(25, 61)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(120, 15)
        Me.lblAddCharges.TabIndex = 2
        Me.lblAddCharges.Text = "Additional Charges:"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.AutoSize = True
        Me.lblRoomCharges.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomCharges.Location = New System.Drawing.Point(48, 34)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(97, 15)
        Me.lblRoomCharges.TabIndex = 0
        Me.lblRoomCharges.Text = "Room Charges:"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.Location = New System.Drawing.Point(61, 25)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(48, 15)
        Me.lblNights.TabIndex = 0
        Me.lblNights.Text = "Nights:"
        '
        'lblNightlyCharge
        '
        Me.lblNightlyCharge.AutoSize = True
        Me.lblNightlyCharge.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNightlyCharge.Location = New System.Drawing.Point(6, 58)
        Me.lblNightlyCharge.Name = "lblNightlyCharge"
        Me.lblNightlyCharge.Size = New System.Drawing.Size(103, 15)
        Me.lblNightlyCharge.TabIndex = 2
        Me.lblNightlyCharge.Text = "Nightly Charges:"
        '
        'lnlRoomService
        '
        Me.lnlRoomService.AutoSize = True
        Me.lnlRoomService.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlRoomService.Location = New System.Drawing.Point(6, 20)
        Me.lnlRoomService.Name = "lnlRoomService"
        Me.lnlRoomService.Size = New System.Drawing.Size(93, 15)
        Me.lnlRoomService.TabIndex = 0
        Me.lnlRoomService.Text = "Room Service:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(28, 43)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(71, 15)
        Me.lblTelephone.TabIndex = 2
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblMisc
        '
        Me.lblMisc.AutoSize = True
        Me.lblMisc.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMisc.Location = New System.Drawing.Point(60, 68)
        Me.lblMisc.Name = "lblMisc"
        Me.lblMisc.Size = New System.Drawing.Size(39, 15)
        Me.lblMisc.TabIndex = 4
        Me.lblMisc.Text = "Misc:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(115, 23)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 1
        '
        'txtNightlyCharges
        '
        Me.txtNightlyCharges.Location = New System.Drawing.Point(115, 56)
        Me.txtNightlyCharges.Name = "txtNightlyCharges"
        Me.txtNightlyCharges.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharges.TabIndex = 3
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(117, 18)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomService.TabIndex = 1
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(117, 41)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 3
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(117, 66)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 20)
        Me.txtMisc.TabIndex = 5
        '
        'txtRoomCharges
        '
        Me.txtRoomCharges.BackColor = System.Drawing.SystemColors.Menu
        Me.txtRoomCharges.Location = New System.Drawing.Point(170, 32)
        Me.txtRoomCharges.Name = "txtRoomCharges"
        Me.txtRoomCharges.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomCharges.TabIndex = 2
        '
        'txtAddCharges
        '
        Me.txtAddCharges.BackColor = System.Drawing.SystemColors.Menu
        Me.txtAddCharges.Location = New System.Drawing.Point(170, 59)
        Me.txtAddCharges.Name = "txtAddCharges"
        Me.txtAddCharges.Size = New System.Drawing.Size(100, 20)
        Me.txtAddCharges.TabIndex = 3
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Menu
        Me.txtSubtotal.Location = New System.Drawing.Point(170, 85)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 5
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.SystemColors.Menu
        Me.txtTax.Location = New System.Drawing.Point(170, 111)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 7
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.BackColor = System.Drawing.SystemColors.Menu
        Me.txtTotalCharges.Location = New System.Drawing.Point(170, 135)
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCharges.TabIndex = 9
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCharges.Location = New System.Drawing.Point(62, 453)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(117, 23)
        Me.btnCalculateCharges.TabIndex = 10
        Me.btnCalculateCharges.Text = "Calculate"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(214, 453)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(369, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDisplayDate
        '
        Me.lblDisplayDate.AutoSize = True
        Me.lblDisplayDate.Location = New System.Drawing.Point(255, 93)
        Me.lblDisplayDate.Name = "lblDisplayDate"
        Me.lblDisplayDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayDate.TabIndex = 13
        '
        'lblDisplayTime
        '
        Me.lblDisplayTime.AutoSize = True
        Me.lblDisplayTime.Location = New System.Drawing.Point(255, 119)
        Me.lblDisplayTime.Name = "lblDisplayTime"
        Me.lblDisplayTime.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayTime.TabIndex = 14
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculateCharges
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(553, 504)
        Me.Controls.Add(Me.lblDisplayTime)
        Me.Controls.Add(Me.lblDisplayDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.lblHighlanderHotel)
        Me.Controls.Add(Me.gbxMiscellaneousCharges)
        Me.Controls.Add(Me.RoomInformation)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.RoomInformation.ResumeLayout(False)
        Me.RoomInformation.PerformLayout()
        Me.gbxMiscellaneousCharges.ResumeLayout(False)
        Me.gbxMiscellaneousCharges.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RoomInformation As System.Windows.Forms.GroupBox
    Friend WithEvents gbxMiscellaneousCharges As System.Windows.Forms.GroupBox
    Friend WithEvents lblHighlanderHotel As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblNightlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents lnlRoomService As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblMisc As System.Windows.Forms.Label
    Friend WithEvents txtNightlyCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAddCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomCharges As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDisplayDate As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTime As System.Windows.Forms.Label

End Class
