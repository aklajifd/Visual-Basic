<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddItem
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
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblInvNumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtInvNumber = New System.Windows.Forms.TextBox()
        Me.grpAddItem = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpAddItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(351, 401)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(238, 38)
        Me.txtRetail.TabIndex = 7
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(351, 299)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(238, 38)
        Me.txtCost.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(351, 148)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(366, 85)
        Me.txtDescription.TabIndex = 3
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(218, 305)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(81, 32)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost:"
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddItem.Location = New System.Drawing.Point(340, 723)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(178, 51)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "&Add Item"
        Me.ToolTip1.SetToolTip(Me.btnAddItem, "Click to add inventory item.")
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'txtOnHand
        '
        Me.txtOnHand.Location = New System.Drawing.Point(351, 496)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.Size = New System.Drawing.Size(238, 38)
        Me.txtOnHand.TabIndex = 9
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(133, 148)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(166, 32)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Retail:"
        '
        'lblInvNumber
        '
        Me.lblInvNumber.AutoSize = True
        Me.lblInvNumber.Location = New System.Drawing.Point(53, 72)
        Me.lblInvNumber.Name = "lblInvNumber"
        Me.lblInvNumber.Size = New System.Drawing.Size(246, 32)
        Me.lblInvNumber.TabIndex = 0
        Me.lblInvNumber.Text = "Inventory Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "OnHand: "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(634, 723)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(177, 50)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnClose, "Click to close page.")
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtInvNumber
        '
        Me.txtInvNumber.Location = New System.Drawing.Point(351, 72)
        Me.txtInvNumber.Name = "txtInvNumber"
        Me.txtInvNumber.Size = New System.Drawing.Size(238, 38)
        Me.txtInvNumber.TabIndex = 1
        '
        'grpAddItem
        '
        Me.grpAddItem.Controls.Add(Me.txtInvNumber)
        Me.grpAddItem.Controls.Add(Me.Label4)
        Me.grpAddItem.Controls.Add(Me.lblInvNumber)
        Me.grpAddItem.Controls.Add(Me.Label3)
        Me.grpAddItem.Controls.Add(Me.lblDescription)
        Me.grpAddItem.Controls.Add(Me.txtOnHand)
        Me.grpAddItem.Controls.Add(Me.lblCost)
        Me.grpAddItem.Controls.Add(Me.txtDescription)
        Me.grpAddItem.Controls.Add(Me.txtCost)
        Me.grpAddItem.Controls.Add(Me.txtRetail)
        Me.grpAddItem.Location = New System.Drawing.Point(171, 27)
        Me.grpAddItem.Name = "grpAddItem"
        Me.grpAddItem.Size = New System.Drawing.Size(820, 633)
        Me.grpAddItem.TabIndex = 0
        Me.grpAddItem.TabStop = False
        Me.grpAddItem.Text = "Inventory Item"
        '
        'FormAddItem
        '
        Me.AcceptButton = Me.btnAddItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1162, 844)
        Me.Controls.Add(Me.grpAddItem)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddItem)
        Me.Name = "FormAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Item"
        Me.grpAddItem.ResumeLayout(False)
        Me.grpAddItem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRetail As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents txtOnHand As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInvNumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtInvNumber As TextBox
    Friend WithEvents grpAddItem As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
