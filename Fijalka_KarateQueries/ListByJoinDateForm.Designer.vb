<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListByJoinDate
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
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dvgMembers = New System.Windows.Forms.DataGridView()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateMembersSet1 = New Fijalka_KarateQueries.KarateMembersSet1()
        Me.lblMembers = New System.Windows.Forms.Label()
        Me.dtpTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.rdoOnOrAfter = New System.Windows.Forms.RadioButton()
        Me.KarateMembersSet2 = New Fijalka_KarateQueries.KarateMembersSet2()
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter1 = New Fijalka_KarateQueries.KarateMembersSet2TableAdapters.MembersTableAdapter()
        Me.MembersTableAdapter = New Fijalka_KarateQueries.KarateMembersSet1TableAdapters.MembersTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dvgMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateMembersSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateMembersSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 49)
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
        'dvgMembers
        '
        Me.dvgMembers.AllowUserToAddRows = False
        Me.dvgMembers.AllowUserToDeleteRows = False
        Me.dvgMembers.AutoGenerateColumns = False
        Me.dvgMembers.BackgroundColor = System.Drawing.Color.White
        Me.dvgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dvgMembers.DataSource = Me.MembersBindingSource
        Me.dvgMembers.Location = New System.Drawing.Point(74, 247)
        Me.dvgMembers.Name = "dvgMembers"
        Me.dvgMembers.ReadOnly = True
        Me.dvgMembers.RowHeadersVisible = False
        Me.dvgMembers.RowHeadersWidth = 102
        Me.dvgMembers.RowTemplate.Height = 40
        Me.dvgMembers.Size = New System.Drawing.Size(974, 503)
        Me.dvgMembers.TabIndex = 6
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
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        Me.DateJoinedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateMembersSet1
        '
        'KarateMembersSet1
        '
        Me.KarateMembersSet1.DataSetName = "KarateMembersSet1"
        Me.KarateMembersSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMembers
        '
        Me.lblMembers.AutoSize = True
        Me.lblMembers.Location = New System.Drawing.Point(68, 174)
        Me.lblMembers.Name = "lblMembers"
        Me.lblMembers.Size = New System.Drawing.Size(300, 32)
        Me.lblMembers.TabIndex = 3
        Me.lblMembers.Text = "Members who joined..."
        '
        'dtpTimePicker
        '
        Me.dtpTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTimePicker.Location = New System.Drawing.Point(699, 86)
        Me.dtpTimePicker.Name = "dtpTimePicker"
        Me.dtpTimePicker.Size = New System.Drawing.Size(248, 38)
        Me.dtpTimePicker.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(465, 89)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(193, 32)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Select a Date:"
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.Location = New System.Drawing.Point(417, 172)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(251, 36)
        Me.rdoBefore.TabIndex = 4
        Me.rdoBefore.Text = "Before this date"
        Me.ToolTip1.SetToolTip(Me.rdoBefore, "Click to filter before selected date.")
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'rdoOnOrAfter
        '
        Me.rdoOnOrAfter.AutoSize = True
        Me.rdoOnOrAfter.Location = New System.Drawing.Point(717, 172)
        Me.rdoOnOrAfter.Name = "rdoOnOrAfter"
        Me.rdoOnOrAfter.Size = New System.Drawing.Size(301, 36)
        Me.rdoOnOrAfter.TabIndex = 5
        Me.rdoOnOrAfter.Text = "On or after this date"
        Me.ToolTip1.SetToolTip(Me.rdoOnOrAfter, "Click to filter on or after selected date. ")
        Me.rdoOnOrAfter.UseVisualStyleBackColor = True
        '
        'KarateMembersSet2
        '
        Me.KarateMembersSet2.DataSetName = "KarateMembersSet2"
        Me.KarateMembersSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource1
        '
        Me.MembersBindingSource1.DataMember = "Members"
        Me.MembersBindingSource1.DataSource = Me.KarateMembersSet2
        '
        'MembersTableAdapter1
        '
        Me.MembersTableAdapter1.ClearBeforeFill = True
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'frmListByJoinDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1122, 791)
        Me.Controls.Add(Me.rdoOnOrAfter)
        Me.Controls.Add(Me.rdoBefore)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpTimePicker)
        Me.Controls.Add(Me.lblMembers)
        Me.Controls.Add(Me.dvgMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmListByJoinDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Karate Member Dates"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dvgMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateMembersSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateMembersSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents dvgMembers As DataGridView
    Friend WithEvents lblMembers As Label
    Friend WithEvents dtpTimePicker As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoOnOrAfter As RadioButton
    Friend WithEvents KarateMembersSet1 As KarateMembersSet1
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As KarateMembersSet1TableAdapters.MembersTableAdapter
    Friend WithEvents KarateMembersSet2 As KarateMembersSet2
    Friend WithEvents MembersBindingSource1 As BindingSource
    Friend WithEvents MembersTableAdapter1 As KarateMembersSet2TableAdapters.MembersTableAdapter
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
