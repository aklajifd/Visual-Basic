<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifyPayments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblID As System.Windows.Forms.Label
        Dim lblMemberID As System.Windows.Forms.Label
        Dim lblPaymentDate As System.Windows.Forms.Label
        Dim lblAmount As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifyPayments))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvModifyPayments = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateModifyMemberPayments = New Fijalka_KarateQueries.KarateModifyMemberPayments()
        Me.KarateModifyPayments = New Fijalka_KarateQueries.KarateModifyPayments()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New Fijalka_KarateQueries.KarateModifyPaymentsTableAdapters.PaymentsTableAdapter()
        Me.TableAdapterManager = New Fijalka_KarateQueries.KarateModifyPaymentsTableAdapters.TableAdapterManager()
        Me.PaymentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaymentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.MembersTableAdapter = New Fijalka_KarateQueries.KarateModifyMemberPaymentsTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager1 = New Fijalka_KarateQueries.KarateModifyMemberPaymentsTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        lblID = New System.Windows.Forms.Label()
        lblMemberID = New System.Windows.Forms.Label()
        lblPaymentDate = New System.Windows.Forms.Label()
        lblAmount = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvModifyPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateModifyMemberPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateModifyPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Location = New System.Drawing.Point(166, 169)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(50, 32)
        lblID.TabIndex = 1
        lblID.Text = "ID:"
        '
        'lblMemberID
        '
        lblMemberID.AutoSize = True
        lblMemberID.Location = New System.Drawing.Point(60, 242)
        lblMemberID.Name = "lblMemberID"
        lblMemberID.Size = New System.Drawing.Size(156, 32)
        lblMemberID.TabIndex = 3
        lblMemberID.Text = "Member Id:"
        '
        'lblPaymentDate
        '
        lblPaymentDate.AutoSize = True
        lblPaymentDate.Location = New System.Drawing.Point(14, 315)
        lblPaymentDate.Name = "lblPaymentDate"
        lblPaymentDate.Size = New System.Drawing.Size(202, 32)
        lblPaymentDate.TabIndex = 5
        lblPaymentDate.Text = "Payment Date:"
        '
        'lblAmount
        '
        lblAmount.AutoSize = True
        lblAmount.Location = New System.Drawing.Point(95, 388)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New System.Drawing.Size(121, 32)
        lblAmount.TabIndex = 7
        lblAmount.Text = "Amount:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1249, 52)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(87, 48)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Click to display options."
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(448, 54)
        Me.mnuFileClose.Text = "&Close"
        Me.mnuFileClose.ToolTipText = "Click to close page."
        '
        'dgvModifyPayments
        '
        Me.dgvModifyPayments.AllowUserToAddRows = False
        Me.dgvModifyPayments.AllowUserToDeleteRows = False
        Me.dgvModifyPayments.AutoGenerateColumns = False
        Me.dgvModifyPayments.BackgroundColor = System.Drawing.Color.White
        Me.dgvModifyPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModifyPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn})
        Me.dgvModifyPayments.DataSource = Me.MembersBindingSource
        Me.dgvModifyPayments.Location = New System.Drawing.Point(520, 164)
        Me.dgvModifyPayments.Name = "dgvModifyPayments"
        Me.dgvModifyPayments.ReadOnly = True
        Me.dgvModifyPayments.RowHeadersVisible = False
        Me.dgvModifyPayments.RowHeadersWidth = 102
        Me.dgvModifyPayments.RowTemplate.Height = 40
        Me.dgvModifyPayments.Size = New System.Drawing.Size(685, 570)
        Me.dgvModifyPayments.TabIndex = 9
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateModifyMemberPayments
        '
        'KarateModifyMemberPayments
        '
        Me.KarateModifyMemberPayments.DataSetName = "KarateModifyMemberPayments"
        Me.KarateModifyMemberPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KarateModifyPayments
        '
        Me.KarateModifyPayments.DataSetName = "KarateModifyPayments"
        Me.KarateModifyPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.KarateModifyPayments
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PaymentsTableAdapter = Me.PaymentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Fijalka_KarateQueries.KarateModifyPaymentsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentsBindingNavigator
        '
        Me.PaymentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentsBindingNavigator.BindingSource = Me.PaymentsBindingSource
        Me.PaymentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentsBindingNavigator.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.PaymentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentsBindingNavigatorSaveItem})
        Me.PaymentsBindingNavigator.Location = New System.Drawing.Point(0, 52)
        Me.PaymentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentsBindingNavigator.Name = "PaymentsBindingNavigator"
        Me.PaymentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentsBindingNavigator.Size = New System.Drawing.Size(1249, 51)
        Me.PaymentsBindingNavigator.TabIndex = 10
        Me.PaymentsBindingNavigator.Text = "BindingNavigator1"
        Me.ToolTip1.SetToolTip(Me.PaymentsBindingNavigator, "Use the navigator tools to modify and save existing payments.")
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(58, 44)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(87, 44)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 44)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(58, 44)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(58, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 51)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 47)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 51)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(58, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(58, 44)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 51)
        '
        'PaymentsBindingNavigatorSaveItem
        '
        Me.PaymentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentsBindingNavigatorSaveItem.Name = "PaymentsBindingNavigatorSaveItem"
        Me.PaymentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 44)
        Me.PaymentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "ID", True))
        Me.txtID.Location = New System.Drawing.Point(262, 166)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(105, 38)
        Me.txtID.TabIndex = 2
        '
        'txtMemberID
        '
        Me.txtMemberID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Member_Id", True))
        Me.txtMemberID.Location = New System.Drawing.Point(262, 239)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(105, 38)
        Me.txtMemberID.TabIndex = 4
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentsBindingSource, "Payment_Date", True))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(262, 312)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(200, 38)
        Me.dtpPaymentDate.TabIndex = 6
        '
        'txtAmount
        '
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Amount", True))
        Me.txtAmount.Location = New System.Drawing.Point(262, 385)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 38)
        Me.txtAmount.TabIndex = 8
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Fijalka_KarateQueries.KarateModifyMemberPaymentsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmModifyPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 775)
        Me.Controls.Add(lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(lblMemberID)
        Me.Controls.Add(Me.txtMemberID)
        Me.Controls.Add(lblPaymentDate)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(lblAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.PaymentsBindingNavigator)
        Me.Controls.Add(Me.dgvModifyPayments)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmModifyPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modify Existing Payments"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvModifyPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateModifyMemberPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateModifyPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentsBindingNavigator.ResumeLayout(False)
        Me.PaymentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents dgvModifyPayments As DataGridView
    Friend WithEvents KarateModifyPayments As KarateModifyPayments
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As KarateModifyPaymentsTableAdapters.PaymentsTableAdapter
    Friend WithEvents TableAdapterManager As KarateModifyPaymentsTableAdapters.TableAdapterManager
    Friend WithEvents PaymentsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PaymentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents KarateModifyMemberPayments As KarateModifyMemberPayments
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As KarateModifyMemberPaymentsTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager1 As KarateModifyMemberPaymentsTableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
