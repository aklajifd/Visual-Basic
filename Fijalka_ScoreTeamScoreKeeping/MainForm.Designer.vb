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
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsPlayers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsPoints = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboNames = New System.Windows.Forms.ComboBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblTeamScore = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.toolMainForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOptions, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1299, 60)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(87, 45)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Click to reset or exit."
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.Size = New System.Drawing.Size(256, 54)
        Me.mnuFileReset.Text = "&Reset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(256, 54)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsPlayers, Me.mnuOptionsPoints})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(148, 45)
        Me.mnuOptions.Text = "&Options"
        Me.mnuOptions.ToolTipText = "Click to add players or points."
        '
        'mnuOptionsPlayers
        '
        Me.mnuOptionsPlayers.Name = "mnuOptionsPlayers"
        Me.mnuOptionsPlayers.Size = New System.Drawing.Size(343, 54)
        Me.mnuOptionsPlayers.Text = "Add &players"
        '
        'mnuOptionsPoints
        '
        Me.mnuOptionsPoints.Name = "mnuOptionsPoints"
        Me.mnuOptionsPoints.Size = New System.Drawing.Size(343, 54)
        Me.mnuOptionsPoints.Text = "&Enter points"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(104, 45)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Click for About info."
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(266, 54)
        Me.mnuHelpAbout.Text = "&About"
        '
        'cboNames
        '
        Me.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNames.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNames.FormattingEnabled = True
        Me.cboNames.Location = New System.Drawing.Point(260, 357)
        Me.cboNames.Name = "cboNames"
        Me.cboNames.Size = New System.Drawing.Size(262, 43)
        Me.cboNames.TabIndex = 3
        Me.toolMainForm.SetToolTip(Me.cboNames, "Click to display either player or team score.")
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.BackColor = System.Drawing.Color.Transparent
        Me.lblDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.Location = New System.Drawing.Point(20, 99)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(1129, 39)
        Me.lblDirections.TabIndex = 1
        Me.lblDirections.Text = "Select an option from the list below to display the individual or team score." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Gadugi", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(611, 412)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(222, 40)
        Me.lblPlayer.TabIndex = 4
        Me.lblPlayer.Text = "Player Score:"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Gadugi", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(611, 556)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(204, 40)
        Me.lblTeam.TabIndex = 6
        Me.lblTeam.Text = "Team Total:"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.BackColor = System.Drawing.Color.FloralWhite
        Me.lblPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerScore.Font = New System.Drawing.Font("Gadugi", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(982, 399)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(207, 67)
        Me.lblPlayerScore.TabIndex = 5
        Me.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolMainForm.SetToolTip(Me.lblPlayerScore, "Individual player score.")
        '
        'lblTeamScore
        '
        Me.lblTeamScore.BackColor = System.Drawing.Color.FloralWhite
        Me.lblTeamScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTeamScore.Font = New System.Drawing.Font("Gadugi", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamScore.Location = New System.Drawing.Point(982, 543)
        Me.lblTeamScore.Name = "lblTeamScore"
        Me.lblTeamScore.Size = New System.Drawing.Size(207, 67)
        Me.lblTeamScore.TabIndex = 7
        Me.lblTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolMainForm.SetToolTip(Me.lblTeamScore, "Score for entire team.")
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(19, 174)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(745, 128)
        Me.lblNote.TabIndex = 2
        Me.lblNote.Text = "***The list will be disabled until the player names and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     scores are entered" &
    ". Click on 'Options' in the menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     to add player names and scores." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 750)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTeamScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.cboNames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soccer Score Keeper by Daniel Fijalka"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuOptionsPlayers As ToolStripMenuItem
    Friend WithEvents mnuOptionsPoints As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents cboNames As ComboBox
    Friend WithEvents lblDirections As Label
    Friend WithEvents lblPlayer As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblTeamScore As Label
    Friend WithEvents toolMainForm As ToolTip
    Friend WithEvents lblNote As Label
End Class
