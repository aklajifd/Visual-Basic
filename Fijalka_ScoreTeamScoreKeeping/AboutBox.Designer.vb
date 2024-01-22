<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.toolAbout = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblProgrammer = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(848, 559)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(200, 50)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        Me.toolAbout.SetToolTip(Me.btnOK, "Click to close ""About"".")
        '
        'txtDescription
        '
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Location = New System.Drawing.Point(16, 251)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(16, 7, 8, 7)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(1032, 294)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.TabStop = False
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'lblProgrammer
        '
        Me.lblProgrammer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProgrammer.Location = New System.Drawing.Point(16, 122)
        Me.lblProgrammer.Margin = New System.Windows.Forms.Padding(16, 0, 8, 0)
        Me.lblProgrammer.MaximumSize = New System.Drawing.Size(0, 41)
        Me.lblProgrammer.Name = "lblProgrammer"
        Me.lblProgrammer.Size = New System.Drawing.Size(1032, 41)
        Me.lblProgrammer.TabIndex = 0
        Me.lblProgrammer.Text = "Programmer: Daniel Fijalka"
        Me.lblProgrammer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Location = New System.Drawing.Point(16, 61)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(16, 0, 8, 0)
        Me.lblVersion.MaximumSize = New System.Drawing.Size(0, 41)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(1032, 41)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Version: 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAppName
        '
        Me.lblAppName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAppName.Location = New System.Drawing.Point(16, 0)
        Me.lblAppName.Margin = New System.Windows.Forms.Padding(16, 0, 8, 0)
        Me.lblAppName.MaximumSize = New System.Drawing.Size(0, 41)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(1032, 41)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "Soccer Team Score Keeping"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 1
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Controls.Add(Me.lblAppName, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblVersion, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.lblProgrammer, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.txtDescription, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.btnOK, 0, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(24, 21)
        Me.TableLayoutPanel.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(1056, 616)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(1104, 658)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.Padding = New System.Windows.Forms.Padding(24, 21, 24, 21)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolAbout As ToolTip
    Friend WithEvents btnOK As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblProgrammer As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
End Class
