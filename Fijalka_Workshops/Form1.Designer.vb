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
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.grpWorkshop = New System.Windows.Forms.GroupBox()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.grpCosts = New System.Windows.Forms.GroupBox()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblCostResult = New System.Windows.Forms.Label()
        Me.btnWorkshop = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpWorkshop.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWorkshop
        '
        Me.lstWorkshop.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.ItemHeight = 41
        Me.lstWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshop.Location = New System.Drawing.Point(38, 49)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(359, 291)
        Me.lstWorkshop.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstWorkshop, "Click an item to select a workshop.")
        '
        'grpWorkshop
        '
        Me.grpWorkshop.Controls.Add(Me.lstWorkshop)
        Me.grpWorkshop.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWorkshop.Location = New System.Drawing.Point(80, 50)
        Me.grpWorkshop.Name = "grpWorkshop"
        Me.grpWorkshop.Size = New System.Drawing.Size(427, 359)
        Me.grpWorkshop.TabIndex = 0
        Me.grpWorkshop.TabStop = False
        Me.grpWorkshop.Text = "Pick a Workshop"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lstLocation)
        Me.grpLocation.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocation.Location = New System.Drawing.Point(547, 50)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(427, 359)
        Me.grpLocation.TabIndex = 1
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Pick a Location"
        '
        'lstLocation
        '
        Me.lstLocation.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.ItemHeight = 41
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(38, 49)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(359, 291)
        Me.lstLocation.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstLocation, "Click an item to select a location.")
        '
        'grpCosts
        '
        Me.grpCosts.Controls.Add(Me.lstCosts)
        Me.grpCosts.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCosts.Location = New System.Drawing.Point(1014, 50)
        Me.grpCosts.Name = "grpCosts"
        Me.grpCosts.Size = New System.Drawing.Size(427, 359)
        Me.grpCosts.TabIndex = 2
        Me.grpCosts.TabStop = False
        Me.grpCosts.Text = "List of Costs"
        '
        'lstCosts
        '
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.ItemHeight = 41
        Me.lstCosts.Location = New System.Drawing.Point(38, 49)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(359, 291)
        Me.lstCosts.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstCosts, "List of workshop costs.")
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(463, 470)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(166, 36)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Total Cost: "
        '
        'lblCostResult
        '
        Me.lblCostResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCostResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostResult.Location = New System.Drawing.Point(657, 456)
        Me.lblCostResult.Name = "lblCostResult"
        Me.lblCostResult.Size = New System.Drawing.Size(298, 60)
        Me.lblCostResult.TabIndex = 4
        Me.lblCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnWorkshop
        '
        Me.btnWorkshop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnWorkshop.Location = New System.Drawing.Point(147, 599)
        Me.btnWorkshop.Name = "btnWorkshop"
        Me.btnWorkshop.Size = New System.Drawing.Size(270, 90)
        Me.btnWorkshop.TabIndex = 5
        Me.btnWorkshop.Text = "&Add Workshop"
        Me.ToolTip1.SetToolTip(Me.btnWorkshop, "Click to add workshop. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Both a workshop and a location must be selected.")
        Me.btnWorkshop.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnTotal.Enabled = False
        Me.btnTotal.Location = New System.Drawing.Point(464, 599)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(270, 90)
        Me.btnTotal.TabIndex = 6
        Me.btnTotal.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnTotal, "Click to display total cost.")
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReset.Location = New System.Drawing.Point(781, 599)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(270, 90)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click to clear selections.")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(1098, 599)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(270, 90)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 400
        Me.ToolTip1.ReshowDelay = 100
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnWorkshop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1524, 785)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnWorkshop)
        Me.Controls.Add(Me.lblCostResult)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.grpCosts)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.grpWorkshop)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workshop Selector by Daniel Fijalka"
        Me.grpWorkshop.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstWorkshop As ListBox
    Friend WithEvents grpWorkshop As GroupBox
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents lstLocation As ListBox
    Friend WithEvents grpCosts As GroupBox
    Friend WithEvents lstCosts As ListBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCostResult As Label
    Friend WithEvents btnWorkshop As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
