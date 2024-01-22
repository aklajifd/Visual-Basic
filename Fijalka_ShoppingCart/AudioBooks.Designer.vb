<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioBooks
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
        Me.btnAudioClose = New System.Windows.Forms.Button()
        Me.btnAudioAddBook = New System.Windows.Forms.Button()
        Me.grpSelectAudioBook = New System.Windows.Forms.GroupBox()
        Me.lstAudioBook = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSelectAudioBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAudioClose
        '
        Me.btnAudioClose.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAudioClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAudioClose.Location = New System.Drawing.Point(500, 386)
        Me.btnAudioClose.Name = "btnAudioClose"
        Me.btnAudioClose.Size = New System.Drawing.Size(265, 99)
        Me.btnAudioClose.TabIndex = 2
        Me.btnAudioClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnAudioClose, "Click to exit form.")
        Me.btnAudioClose.UseVisualStyleBackColor = False
        '
        'btnAudioAddBook
        '
        Me.btnAudioAddBook.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAudioAddBook.Location = New System.Drawing.Point(185, 386)
        Me.btnAudioAddBook.Name = "btnAudioAddBook"
        Me.btnAudioAddBook.Size = New System.Drawing.Size(265, 99)
        Me.btnAudioAddBook.TabIndex = 1
        Me.btnAudioAddBook.Text = "&Add Book to Cart"
        Me.ToolTip1.SetToolTip(Me.btnAudioAddBook, "Click to add book to cart.")
        Me.btnAudioAddBook.UseVisualStyleBackColor = False
        '
        'grpSelectAudioBook
        '
        Me.grpSelectAudioBook.Controls.Add(Me.lstAudioBook)
        Me.grpSelectAudioBook.Location = New System.Drawing.Point(56, 44)
        Me.grpSelectAudioBook.Name = "grpSelectAudioBook"
        Me.grpSelectAudioBook.Size = New System.Drawing.Size(838, 320)
        Me.grpSelectAudioBook.TabIndex = 0
        Me.grpSelectAudioBook.TabStop = False
        Me.grpSelectAudioBook.Text = "Select an Audio Book"
        '
        'lstAudioBook
        '
        Me.lstAudioBook.FormattingEnabled = True
        Me.lstAudioBook.ItemHeight = 31
        Me.lstAudioBook.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstAudioBook.Location = New System.Drawing.Point(60, 57)
        Me.lstAudioBook.Name = "lstAudioBook"
        Me.lstAudioBook.Size = New System.Drawing.Size(717, 221)
        Me.lstAudioBook.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstAudioBook, "Select an item from the list.")
        '
        'frmAudioBooks
        '
        Me.AcceptButton = Me.btnAudioAddBook
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAudioClose
        Me.ClientSize = New System.Drawing.Size(950, 553)
        Me.Controls.Add(Me.btnAudioClose)
        Me.Controls.Add(Me.btnAudioAddBook)
        Me.Controls.Add(Me.grpSelectAudioBook)
        Me.Name = "frmAudioBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AudioBooks"
        Me.grpSelectAudioBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAudioClose As Button
    Friend WithEvents btnAudioAddBook As Button
    Friend WithEvents grpSelectAudioBook As GroupBox
    Friend WithEvents lstAudioBook As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
