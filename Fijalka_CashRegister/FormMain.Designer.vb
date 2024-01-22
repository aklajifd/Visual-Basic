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
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnLookupItem = New System.Windows.Forms.Button()
        Me.lblInvNumber = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblRetail = New System.Windows.Forms.Label()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.grpInventoryRecords = New System.Windows.Forms.GroupBox()
        Me.lblOnHandDisplay = New System.Windows.Forms.Label()
        Me.lblRetailDisplay = New System.Windows.Forms.Label()
        Me.lblCostDisplay = New System.Windows.Forms.Label()
        Me.lblDescriptionDisplay = New System.Windows.Forms.Label()
        Me.lblInvNumberDisplay = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.grpCashRegister = New System.Windows.Forms.GroupBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnAddSelected = New System.Windows.Forms.Button()
        Me.lblTotalResult = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSalesTaxResult = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblInventoryOnHandDisplay = New System.Windows.Forms.Label()
        Me.lblInventoryRetailDisplay = New System.Windows.Forms.Label()
        Me.lblInventoryOnHand = New System.Windows.Forms.Label()
        Me.lblInventoryRetail = New System.Windows.Forms.Label()
        Me.lblInventoryDescriptionDisplay = New System.Windows.Forms.Label()
        Me.lblInventoryDescription = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpInventoryRecords.SuspendLayout()
        Me.grpCashRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddItem.Location = New System.Drawing.Point(59, 605)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(178, 51)
        Me.btnAddItem.TabIndex = 10
        Me.btnAddItem.Text = "&Add Item"
        Me.ToolTip1.SetToolTip(Me.btnAddItem, "Click to add item to inventory.")
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnLookupItem
        '
        Me.btnLookupItem.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLookupItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLookupItem.Location = New System.Drawing.Point(316, 605)
        Me.btnLookupItem.Name = "btnLookupItem"
        Me.btnLookupItem.Size = New System.Drawing.Size(178, 51)
        Me.btnLookupItem.TabIndex = 11
        Me.btnLookupItem.Text = "&Lookup Item"
        Me.ToolTip1.SetToolTip(Me.btnLookupItem, "Click to lookup item by inventory number.")
        Me.btnLookupItem.UseVisualStyleBackColor = False
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
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(133, 148)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(166, 32)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description:"
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
        'lblRetail
        '
        Me.lblRetail.AutoSize = True
        Me.lblRetail.Location = New System.Drawing.Point(202, 401)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(97, 32)
        Me.lblRetail.TabIndex = 6
        Me.lblRetail.Text = "Retail:"
        '
        'lblOnHand
        '
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Location = New System.Drawing.Point(163, 496)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(136, 32)
        Me.lblOnHand.TabIndex = 8
        Me.lblOnHand.Text = "OnHand: "
        '
        'grpInventoryRecords
        '
        Me.grpInventoryRecords.Controls.Add(Me.lblOnHandDisplay)
        Me.grpInventoryRecords.Controls.Add(Me.lblRetailDisplay)
        Me.grpInventoryRecords.Controls.Add(Me.lblCostDisplay)
        Me.grpInventoryRecords.Controls.Add(Me.lblDescriptionDisplay)
        Me.grpInventoryRecords.Controls.Add(Me.lblInvNumberDisplay)
        Me.grpInventoryRecords.Controls.Add(Me.btnUpdate)
        Me.grpInventoryRecords.Controls.Add(Me.lblOnHand)
        Me.grpInventoryRecords.Controls.Add(Me.lblInvNumber)
        Me.grpInventoryRecords.Controls.Add(Me.lblRetail)
        Me.grpInventoryRecords.Controls.Add(Me.lblDescription)
        Me.grpInventoryRecords.Controls.Add(Me.btnLookupItem)
        Me.grpInventoryRecords.Controls.Add(Me.btnAddItem)
        Me.grpInventoryRecords.Controls.Add(Me.lblCost)
        Me.grpInventoryRecords.Location = New System.Drawing.Point(23, 24)
        Me.grpInventoryRecords.Name = "grpInventoryRecords"
        Me.grpInventoryRecords.Size = New System.Drawing.Size(820, 744)
        Me.grpInventoryRecords.TabIndex = 0
        Me.grpInventoryRecords.TabStop = False
        Me.grpInventoryRecords.Text = "Inventory Records"
        '
        'lblOnHandDisplay
        '
        Me.lblOnHandDisplay.BackColor = System.Drawing.Color.White
        Me.lblOnHandDisplay.Location = New System.Drawing.Point(345, 496)
        Me.lblOnHandDisplay.Name = "lblOnHandDisplay"
        Me.lblOnHandDisplay.Size = New System.Drawing.Size(238, 38)
        Me.lblOnHandDisplay.TabIndex = 9
        '
        'lblRetailDisplay
        '
        Me.lblRetailDisplay.BackColor = System.Drawing.Color.White
        Me.lblRetailDisplay.Location = New System.Drawing.Point(345, 395)
        Me.lblRetailDisplay.Name = "lblRetailDisplay"
        Me.lblRetailDisplay.Size = New System.Drawing.Size(238, 38)
        Me.lblRetailDisplay.TabIndex = 7
        '
        'lblCostDisplay
        '
        Me.lblCostDisplay.BackColor = System.Drawing.Color.White
        Me.lblCostDisplay.Location = New System.Drawing.Point(345, 299)
        Me.lblCostDisplay.Name = "lblCostDisplay"
        Me.lblCostDisplay.Size = New System.Drawing.Size(238, 38)
        Me.lblCostDisplay.TabIndex = 5
        '
        'lblDescriptionDisplay
        '
        Me.lblDescriptionDisplay.BackColor = System.Drawing.Color.White
        Me.lblDescriptionDisplay.Location = New System.Drawing.Point(345, 148)
        Me.lblDescriptionDisplay.Name = "lblDescriptionDisplay"
        Me.lblDescriptionDisplay.Size = New System.Drawing.Size(366, 85)
        Me.lblDescriptionDisplay.TabIndex = 3
        '
        'lblInvNumberDisplay
        '
        Me.lblInvNumberDisplay.BackColor = System.Drawing.Color.White
        Me.lblInvNumberDisplay.Location = New System.Drawing.Point(351, 72)
        Me.lblInvNumberDisplay.Name = "lblInvNumberDisplay"
        Me.lblInvNumberDisplay.Size = New System.Drawing.Size(238, 38)
        Me.lblInvNumberDisplay.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(579, 606)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(177, 50)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "&Update Item"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Click to update inventory item.")
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.ItemHeight = 31
        Me.lstInventory.Location = New System.Drawing.Point(38, 37)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(374, 438)
        Me.lstInventory.TabIndex = 0
        '
        'grpCashRegister
        '
        Me.grpCashRegister.Controls.Add(Me.btnCheckout)
        Me.grpCashRegister.Controls.Add(Me.btnAddSelected)
        Me.grpCashRegister.Controls.Add(Me.lblTotalResult)
        Me.grpCashRegister.Controls.Add(Me.lblTotal)
        Me.grpCashRegister.Controls.Add(Me.lblSalesTaxResult)
        Me.grpCashRegister.Controls.Add(Me.lblSalesTax)
        Me.grpCashRegister.Controls.Add(Me.lblQuantity)
        Me.grpCashRegister.Controls.Add(Me.txtQuantity)
        Me.grpCashRegister.Controls.Add(Me.lblInventoryOnHandDisplay)
        Me.grpCashRegister.Controls.Add(Me.lblInventoryRetailDisplay)
        Me.grpCashRegister.Controls.Add(Me.lblInventoryOnHand)
        Me.grpCashRegister.Controls.Add(Me.lblInventoryRetail)
        Me.grpCashRegister.Controls.Add(Me.lblInventoryDescriptionDisplay)
        Me.grpCashRegister.Controls.Add(Me.lblInventoryDescription)
        Me.grpCashRegister.Controls.Add(Me.lstInventory)
        Me.grpCashRegister.Location = New System.Drawing.Point(927, 24)
        Me.grpCashRegister.Name = "grpCashRegister"
        Me.grpCashRegister.Size = New System.Drawing.Size(1203, 744)
        Me.grpCashRegister.TabIndex = 1
        Me.grpCashRegister.TabStop = False
        Me.grpCashRegister.Text = "Cash Register"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.PowderBlue
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckout.Location = New System.Drawing.Point(133, 603)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(177, 50)
        Me.btnCheckout.TabIndex = 10
        Me.btnCheckout.Text = "&Checkout"
        Me.ToolTip1.SetToolTip(Me.btnCheckout, "Click to make purchase.")
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnAddSelected
        '
        Me.btnAddSelected.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAddSelected.Location = New System.Drawing.Point(987, 386)
        Me.btnAddSelected.Name = "btnAddSelected"
        Me.btnAddSelected.Size = New System.Drawing.Size(177, 50)
        Me.btnAddSelected.TabIndex = 9
        Me.btnAddSelected.Text = "Add &item(s)"
        Me.ToolTip1.SetToolTip(Me.btnAddSelected, "Click to add item(s) to cart.")
        Me.btnAddSelected.UseVisualStyleBackColor = False
        '
        'lblTotalResult
        '
        Me.lblTotalResult.BackColor = System.Drawing.Color.White
        Me.lblTotalResult.Location = New System.Drawing.Point(916, 607)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(181, 43)
        Me.lblTotalResult.TabIndex = 14
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(811, 612)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 32)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total:"
        '
        'lblSalesTaxResult
        '
        Me.lblSalesTaxResult.BackColor = System.Drawing.Color.White
        Me.lblSalesTaxResult.Location = New System.Drawing.Point(558, 607)
        Me.lblSalesTaxResult.Name = "lblSalesTaxResult"
        Me.lblSalesTaxResult.Size = New System.Drawing.Size(181, 43)
        Me.lblSalesTaxResult.TabIndex = 12
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(386, 612)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(149, 32)
        Me.lblSalesTax.TabIndex = 11
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(474, 395)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(236, 32)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity of items:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(737, 392)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(194, 38)
        Me.txtQuantity.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtQuantity, "Enter item quantity.")
        '
        'lblInventoryOnHandDisplay
        '
        Me.lblInventoryOnHandDisplay.BackColor = System.Drawing.Color.White
        Me.lblInventoryOnHandDisplay.Location = New System.Drawing.Point(731, 276)
        Me.lblInventoryOnHandDisplay.Name = "lblInventoryOnHandDisplay"
        Me.lblInventoryOnHandDisplay.Size = New System.Drawing.Size(238, 38)
        Me.lblInventoryOnHandDisplay.TabIndex = 6
        '
        'lblInventoryRetailDisplay
        '
        Me.lblInventoryRetailDisplay.BackColor = System.Drawing.Color.White
        Me.lblInventoryRetailDisplay.Location = New System.Drawing.Point(731, 160)
        Me.lblInventoryRetailDisplay.Name = "lblInventoryRetailDisplay"
        Me.lblInventoryRetailDisplay.Size = New System.Drawing.Size(238, 38)
        Me.lblInventoryRetailDisplay.TabIndex = 4
        '
        'lblInventoryOnHand
        '
        Me.lblInventoryOnHand.AutoSize = True
        Me.lblInventoryOnHand.Location = New System.Drawing.Point(435, 279)
        Me.lblInventoryOnHand.Name = "lblInventoryOnHand"
        Me.lblInventoryOnHand.Size = New System.Drawing.Size(275, 32)
        Me.lblInventoryOnHand.TabIndex = 5
        Me.lblInventoryOnHand.Text = "Number of items left:"
        '
        'lblInventoryRetail
        '
        Me.lblInventoryRetail.AutoSize = True
        Me.lblInventoryRetail.Location = New System.Drawing.Point(613, 163)
        Me.lblInventoryRetail.Name = "lblInventoryRetail"
        Me.lblInventoryRetail.Size = New System.Drawing.Size(97, 32)
        Me.lblInventoryRetail.TabIndex = 3
        Me.lblInventoryRetail.Text = "Retail:"
        '
        'lblInventoryDescriptionDisplay
        '
        Me.lblInventoryDescriptionDisplay.BackColor = System.Drawing.Color.White
        Me.lblInventoryDescriptionDisplay.Location = New System.Drawing.Point(731, 47)
        Me.lblInventoryDescriptionDisplay.Name = "lblInventoryDescriptionDisplay"
        Me.lblInventoryDescriptionDisplay.Size = New System.Drawing.Size(366, 85)
        Me.lblInventoryDescriptionDisplay.TabIndex = 2
        '
        'lblInventoryDescription
        '
        Me.lblInventoryDescription.AutoSize = True
        Me.lblInventoryDescription.Location = New System.Drawing.Point(544, 47)
        Me.lblInventoryDescription.Name = "lblInventoryDescription"
        Me.lblInventoryDescription.Size = New System.Drawing.Size(166, 32)
        Me.lblInventoryDescription.TabIndex = 1
        Me.lblInventoryDescription.Text = "Description:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(1166, 805)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(252, 120)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit application.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LawnGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(752, 805)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(252, 120)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Click to save inventory data.")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2164, 978)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpCashRegister)
        Me.Controls.Add(Me.grpInventoryRecords)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Register by Daniel Fijalka"
        Me.grpInventoryRecords.ResumeLayout(False)
        Me.grpInventoryRecords.PerformLayout()
        Me.grpCashRegister.ResumeLayout(False)
        Me.grpCashRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnLookupItem As Button
    Friend WithEvents lblInvNumber As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblRetail As Label
    Friend WithEvents lblOnHand As Label
    Friend WithEvents grpInventoryRecords As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lstInventory As ListBox
    Friend WithEvents grpCashRegister As GroupBox
    Friend WithEvents lblInvNumberDisplay As Label
    Friend WithEvents lblDescriptionDisplay As Label
    Friend WithEvents lblOnHandDisplay As Label
    Friend WithEvents lblRetailDisplay As Label
    Friend WithEvents lblCostDisplay As Label
    Friend WithEvents lblTotalResult As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSalesTaxResult As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblInventoryOnHandDisplay As Label
    Friend WithEvents lblInventoryRetailDisplay As Label
    Friend WithEvents lblInventoryOnHand As Label
    Friend WithEvents lblInventoryRetail As Label
    Friend WithEvents lblInventoryDescriptionDisplay As Label
    Friend WithEvents lblInventoryDescription As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnAddSelected As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
