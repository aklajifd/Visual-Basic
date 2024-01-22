<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSingleMemberPayments
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateSingleMemberPayments = New Fijalka_KarateQueries.KarateSingleMemberPayments()
        Me.dgvSinglePayments = New System.Windows.Forms.DataGridView()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateSingleMemberAmount = New Fijalka_KarateQueries.KarateSingleMemberAmount()
        Me.MembersTableAdapter = New Fijalka_KarateQueries.KarateSingleMemberPaymentsTableAdapters.MembersTableAdapter()
        Me.PaymentsTableAdapter = New Fijalka_KarateQueries.KarateSingleMemberAmountTableAdapters.PaymentsTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateSingleMemberPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSinglePayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateSingleMemberAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1070, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(87, 45)
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
        'lstMembers
        '
        Me.lstMembers.DataSource = Me.MembersBindingSource
        Me.lstMembers.DisplayMember = "Expr1"
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 31
        Me.lstMembers.Location = New System.Drawing.Point(62, 87)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(400, 562)
        Me.lstMembers.Sorted = True
        Me.lstMembers.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lstMembers, "Select a name to display payment details.")
        Me.lstMembers.ValueMember = "ID"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateSingleMemberPayments
        '
        'KarateSingleMemberPayments
        '
        Me.KarateSingleMemberPayments.DataSetName = "KarateSingleMemberPayments"
        Me.KarateSingleMemberPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvSinglePayments
        '
        Me.dgvSinglePayments.AllowUserToAddRows = False
        Me.dgvSinglePayments.AllowUserToDeleteRows = False
        Me.dgvSinglePayments.AutoGenerateColumns = False
        Me.dgvSinglePayments.BackgroundColor = System.Drawing.Color.White
        Me.dgvSinglePayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinglePayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvSinglePayments.DataSource = Me.PaymentsBindingSource
        Me.dgvSinglePayments.Location = New System.Drawing.Point(517, 87)
        Me.dgvSinglePayments.Name = "dgvSinglePayments"
        Me.dgvSinglePayments.ReadOnly = True
        Me.dgvSinglePayments.RowHeadersVisible = False
        Me.dgvSinglePayments.RowHeadersWidth = 102
        Me.dgvSinglePayments.RowTemplate.Height = 40
        Me.dgvSinglePayments.Size = New System.Drawing.Size(492, 368)
        Me.dgvSinglePayments.TabIndex = 2
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.KarateSingleMemberAmount
        '
        'KarateSingleMemberAmount
        '
        Me.KarateSingleMemberAmount.DataSetName = "KarateSingleMemberAmount"
        Me.KarateSingleMemberAmount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'frmSingleMemberPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 733)
        Me.Controls.Add(Me.dgvSinglePayments)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSingleMemberPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payments by One Member"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateSingleMemberPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSinglePayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateSingleMemberAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents lstMembers As ListBox
    Friend WithEvents dgvSinglePayments As DataGridView
    Friend WithEvents KarateSingleMemberPayments As KarateSingleMemberPayments
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As KarateSingleMemberPaymentsTableAdapters.MembersTableAdapter
    Friend WithEvents KarateSingleMemberAmount As KarateSingleMemberAmount
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As KarateSingleMemberAmountTableAdapters.PaymentsTableAdapter
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
