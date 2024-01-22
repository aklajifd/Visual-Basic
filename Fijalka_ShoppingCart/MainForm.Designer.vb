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
        Me.grpProductsSelected = New System.Windows.Forms.GroupBox()
        Me.lblTotalResult = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblShippingResult = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTaxResult = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotalResult = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductsPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductsAudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxPrintBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxAudioBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpProductsSelected.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ctxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProductsSelected
        '
        Me.grpProductsSelected.Controls.Add(Me.lblTotalResult)
        Me.grpProductsSelected.Controls.Add(Me.lblTotal)
        Me.grpProductsSelected.Controls.Add(Me.lblShippingResult)
        Me.grpProductsSelected.Controls.Add(Me.lblShipping)
        Me.grpProductsSelected.Controls.Add(Me.lblTaxResult)
        Me.grpProductsSelected.Controls.Add(Me.lblTax)
        Me.grpProductsSelected.Controls.Add(Me.lblSubtotalResult)
        Me.grpProductsSelected.Controls.Add(Me.lblSubtotal)
        Me.grpProductsSelected.Controls.Add(Me.btnRemove)
        Me.grpProductsSelected.Controls.Add(Me.lstShoppingCart)
        Me.grpProductsSelected.Location = New System.Drawing.Point(67, 141)
        Me.grpProductsSelected.Name = "grpProductsSelected"
        Me.grpProductsSelected.Size = New System.Drawing.Size(1248, 553)
        Me.grpProductsSelected.TabIndex = 1
        Me.grpProductsSelected.TabStop = False
        Me.grpProductsSelected.Text = "Products Selected"
        '
        'lblTotalResult
        '
        Me.lblTotalResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalResult.Location = New System.Drawing.Point(1006, 358)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(222, 61)
        Me.lblTotalResult.TabIndex = 8
        Me.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblTotalResult, "Total value.")
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(875, 372)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 32)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total:"
        '
        'lblShippingResult
        '
        Me.lblShippingResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblShippingResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShippingResult.Location = New System.Drawing.Point(1006, 252)
        Me.lblShippingResult.Name = "lblShippingResult"
        Me.lblShippingResult.Size = New System.Drawing.Size(222, 61)
        Me.lblShippingResult.TabIndex = 6
        Me.lblShippingResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblShippingResult, "Shipping value.")
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(826, 266)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(136, 32)
        Me.lblShipping.TabIndex = 5
        Me.lblShipping.Text = "Shipping:"
        '
        'lblTaxResult
        '
        Me.lblTaxResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxResult.Location = New System.Drawing.Point(1006, 150)
        Me.lblTaxResult.Name = "lblTaxResult"
        Me.lblTaxResult.Size = New System.Drawing.Size(222, 61)
        Me.lblTaxResult.TabIndex = 4
        Me.lblTaxResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblTaxResult, "Tax value.")
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(892, 164)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(70, 32)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotalResult
        '
        Me.lblSubtotalResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSubtotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotalResult.Location = New System.Drawing.Point(1006, 47)
        Me.lblSubtotalResult.Name = "lblSubtotalResult"
        Me.lblSubtotalResult.Size = New System.Drawing.Size(222, 61)
        Me.lblSubtotalResult.TabIndex = 2
        Me.lblSubtotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblSubtotalResult, "Subtotal value.")
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(833, 61)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(129, 32)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRemove.Location = New System.Drawing.Point(255, 417)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(270, 101)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Rem&ove"
        Me.ToolTip1.SetToolTip(Me.btnRemove, "Click to remove selected product.")
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.ItemHeight = 31
        Me.lstShoppingCart.Location = New System.Drawing.Point(40, 57)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(701, 314)
        Me.lstShoppingCart.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstShoppingCart, "List of added products.")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuProducts, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(87, 45)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuFileReset.Size = New System.Drawing.Size(448, 54)
        Me.mnuFileReset.Text = "R&eset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(448, 54)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuProducts
        '
        Me.mnuProducts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProductsPrint, Me.mnuProductsAudio})
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(159, 45)
        Me.mnuProducts.Text = "&Products"
        '
        'mnuProductsPrint
        '
        Me.mnuProductsPrint.Name = "mnuProductsPrint"
        Me.mnuProductsPrint.Size = New System.Drawing.Size(448, 54)
        Me.mnuProductsPrint.Text = "P&rint Books"
        '
        'mnuProductsAudio
        '
        Me.mnuProductsAudio.Name = "mnuProductsAudio"
        Me.mnuProductsAudio.Size = New System.Drawing.Size(448, 54)
        Me.mnuProductsAudio.Text = "&Audio Books"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(104, 45)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(266, 54)
        Me.mnuHelpAbout.Text = "&About"
        '
        'ctxMain
        '
        Me.ctxMain.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ctxMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxPrintBooks, Me.ctxAudioBooks})
        Me.ctxMain.Name = "ctxMain"
        Me.ctxMain.Size = New System.Drawing.Size(265, 100)
        '
        'ctxPrintBooks
        '
        Me.ctxPrintBooks.Name = "ctxPrintBooks"
        Me.ctxPrintBooks.Size = New System.Drawing.Size(264, 48)
        Me.ctxPrintBooks.Text = "Print Books"
        '
        'ctxAudioBooks
        '
        Me.ctxAudioBooks.Name = "ctxAudioBooks"
        Me.ctxAudioBooks.Size = New System.Drawing.Size(264, 48)
        Me.ctxAudioBooks.Text = "Audio Books"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 726)
        Me.ContextMenuStrip = Me.ctxMain
        Me.Controls.Add(Me.grpProductsSelected)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart by Daniel Fijalka"
        Me.grpProductsSelected.ResumeLayout(False)
        Me.grpProductsSelected.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ctxMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpProductsSelected As GroupBox
    Friend WithEvents lblTotalResult As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblShippingResult As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTaxResult As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotalResult As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuProducts As ToolStripMenuItem
    Friend WithEvents mnuProductsPrint As ToolStripMenuItem
    Friend WithEvents mnuProductsAudio As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents ctxMain As ContextMenuStrip
    Friend WithEvents ctxPrintBooks As ToolStripMenuItem
    Friend WithEvents ctxAudioBooks As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
