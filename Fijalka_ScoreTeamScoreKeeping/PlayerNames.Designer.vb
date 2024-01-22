<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerNames
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
        Me.lblHowManyPlayers = New System.Windows.Forms.Label()
        Me.txtPlayerNumber = New System.Windows.Forms.TextBox()
        Me.toolPlayerNames = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblHowManyPlayers
        '
        Me.lblHowManyPlayers.AutoSize = True
        Me.lblHowManyPlayers.Location = New System.Drawing.Point(84, 138)
        Me.lblHowManyPlayers.Name = "lblHowManyPlayers"
        Me.lblHowManyPlayers.Size = New System.Drawing.Size(461, 32)
        Me.lblHowManyPlayers.TabIndex = 0
        Me.lblHowManyPlayers.Text = "Enter the number of soccer players:"
        '
        'txtPlayerNumber
        '
        Me.txtPlayerNumber.BackColor = System.Drawing.Color.FloralWhite
        Me.txtPlayerNumber.Location = New System.Drawing.Point(586, 135)
        Me.txtPlayerNumber.Name = "txtPlayerNumber"
        Me.txtPlayerNumber.Size = New System.Drawing.Size(178, 38)
        Me.txtPlayerNumber.TabIndex = 1
        Me.toolPlayerNames.SetToolTip(Me.txtPlayerNumber, "Click to enter amount of players.")
        '
        'PlayerNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 365)
        Me.Controls.Add(Me.txtPlayerNumber)
        Me.Controls.Add(Me.lblHowManyPlayers)
        Me.Name = "PlayerNames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PlayerNames"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHowManyPlayers As Label
    Friend WithEvents txtPlayerNumber As TextBox
    Friend WithEvents toolPlayerNames As ToolTip
End Class
