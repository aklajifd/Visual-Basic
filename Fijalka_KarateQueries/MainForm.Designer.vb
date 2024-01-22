<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembership = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipListMembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipListPhoneNumbers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsModify = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsView = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlOuter = New System.Windows.Forms.Panel()
        Me.pnlInner = New System.Windows.Forms.Panel()
        Me.lblManagement = New System.Windows.Forms.Label()
        Me.lblKarateSchool = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlOuter.SuspendLayout()
        Me.pnlInner.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMembership, Me.mnuPayments})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1368, 52)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(87, 56)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Click to display options."
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(448, 54)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "Click to exit program."
        '
        'mnuMembership
        '
        Me.mnuMembership.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMembershipListMembers, Me.mnuMembershipListPhoneNumbers})
        Me.mnuMembership.Name = "mnuMembership"
        Me.mnuMembership.Size = New System.Drawing.Size(210, 56)
        Me.mnuMembership.Text = "&Membership"
        Me.mnuMembership.ToolTipText = "Click to display membership options."
        '
        'mnuMembershipListMembers
        '
        Me.mnuMembershipListMembers.Name = "mnuMembershipListMembers"
        Me.mnuMembershipListMembers.Size = New System.Drawing.Size(534, 54)
        Me.mnuMembershipListMembers.Text = "&List Members by Join Date"
        Me.mnuMembershipListMembers.ToolTipText = "Click to display member join dates."
        '
        'mnuMembershipListPhoneNumbers
        '
        Me.mnuMembershipListPhoneNumbers.Name = "mnuMembershipListPhoneNumbers"
        Me.mnuMembershipListPhoneNumbers.Size = New System.Drawing.Size(534, 54)
        Me.mnuMembershipListPhoneNumbers.Text = "List Phone &Numbers"
        Me.mnuMembershipListPhoneNumbers.ToolTipText = "Click to display member phone numbers."
        '
        'mnuPayments
        '
        Me.mnuPayments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentsList, Me.mnuPaymentsModify, Me.mnuPaymentsView})
        Me.mnuPayments.Name = "mnuPayments"
        Me.mnuPayments.Size = New System.Drawing.Size(170, 56)
        Me.mnuPayments.Text = "&Payments"
        Me.mnuPayments.ToolTipText = "Click to display payment options."
        '
        'mnuPaymentsList
        '
        Me.mnuPaymentsList.Name = "mnuPaymentsList"
        Me.mnuPaymentsList.Size = New System.Drawing.Size(523, 54)
        Me.mnuPaymentsList.Text = "L&ist All Payments"
        Me.mnuPaymentsList.ToolTipText = "Click to display member payments."
        '
        'mnuPaymentsModify
        '
        Me.mnuPaymentsModify.Name = "mnuPaymentsModify"
        Me.mnuPaymentsModify.Size = New System.Drawing.Size(523, 54)
        Me.mnuPaymentsModify.Text = "Modify &Existing Payments"
        Me.mnuPaymentsModify.ToolTipText = "Click to edit payment info."
        '
        'mnuPaymentsView
        '
        Me.mnuPaymentsView.Name = "mnuPaymentsView"
        Me.mnuPaymentsView.Size = New System.Drawing.Size(523, 54)
        Me.mnuPaymentsView.Text = "&View for Single Member"
        Me.mnuPaymentsView.ToolTipText = "Click to display individual payments."
        '
        'pnlOuter
        '
        Me.pnlOuter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOuter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOuter.Controls.Add(Me.pnlInner)
        Me.pnlOuter.Location = New System.Drawing.Point(179, 225)
        Me.pnlOuter.Name = "pnlOuter"
        Me.pnlOuter.Size = New System.Drawing.Size(964, 542)
        Me.pnlOuter.TabIndex = 2
        '
        'pnlInner
        '
        Me.pnlInner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInner.Controls.Add(Me.lblManagement)
        Me.pnlInner.Controls.Add(Me.lblKarateSchool)
        Me.pnlInner.Location = New System.Drawing.Point(55, 26)
        Me.pnlInner.Name = "pnlInner"
        Me.pnlInner.Size = New System.Drawing.Size(851, 483)
        Me.pnlInner.TabIndex = 0
        '
        'lblManagement
        '
        Me.lblManagement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblManagement.AutoSize = True
        Me.lblManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagement.Location = New System.Drawing.Point(193, 282)
        Me.lblManagement.Name = "lblManagement"
        Me.lblManagement.Size = New System.Drawing.Size(461, 46)
        Me.lblManagement.TabIndex = 1
        Me.lblManagement.Text = "Management System 1.0"
        '
        'lblKarateSchool
        '
        Me.lblKarateSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblKarateSchool.AutoSize = True
        Me.lblKarateSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKarateSchool.Location = New System.Drawing.Point(114, 155)
        Me.lblKarateSchool.Name = "lblKarateSchool"
        Me.lblKarateSchool.Size = New System.Drawing.Size(619, 69)
        Me.lblKarateSchool.TabIndex = 0
        Me.lblKarateSchool.Text = "Kyoshi Karate School"
        '
        'lblIntro
        '
        Me.lblIntro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIntro.AutoSize = True
        Me.lblIntro.BackColor = System.Drawing.Color.Azure
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(96, 84)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(1009, 72)
        Me.lblIntro.TabIndex = 1
        Me.lblIntro.Text = "Welcome to the Kyoshi Karate School! Click through the menu options" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "above to dis" &
    "play or modify membership and payment information."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 894)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.pnlOuter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate Queries by Daniel Fijalka"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlOuter.ResumeLayout(False)
        Me.pnlInner.ResumeLayout(False)
        Me.pnlInner.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuMembership As ToolStripMenuItem
    Friend WithEvents mnuMembershipListMembers As ToolStripMenuItem
    Friend WithEvents mnuMembershipListPhoneNumbers As ToolStripMenuItem
    Friend WithEvents mnuPayments As ToolStripMenuItem
    Friend WithEvents mnuPaymentsList As ToolStripMenuItem
    Friend WithEvents mnuPaymentsModify As ToolStripMenuItem
    Friend WithEvents mnuPaymentsView As ToolStripMenuItem
    Friend WithEvents pnlOuter As Panel
    Friend WithEvents pnlInner As Panel
    Friend WithEvents lblManagement As Label
    Friend WithEvents lblKarateSchool As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents lblIntro As Label
End Class
