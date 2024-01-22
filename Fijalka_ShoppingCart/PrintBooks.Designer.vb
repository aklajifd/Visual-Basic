<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintBooks
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
        Me.btnPrintClose = New System.Windows.Forms.Button()
        Me.btnPrintAddBook = New System.Windows.Forms.Button()
        Me.grpSelectPrintBook = New System.Windows.Forms.GroupBox()
        Me.lstPrintBook = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSelectPrintBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrintClose
        '
        Me.btnPrintClose.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPrintClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrintClose.Location = New System.Drawing.Point(498, 373)
        Me.btnPrintClose.Name = "btnPrintClose"
        Me.btnPrintClose.Size = New System.Drawing.Size(265, 99)
        Me.btnPrintClose.TabIndex = 2
        Me.btnPrintClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnPrintClose, "Click to exit form.")
        Me.btnPrintClose.UseVisualStyleBackColor = False
        '
        'btnPrintAddBook
        '
        Me.btnPrintAddBook.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPrintAddBook.Location = New System.Drawing.Point(183, 373)
        Me.btnPrintAddBook.Name = "btnPrintAddBook"
        Me.btnPrintAddBook.Size = New System.Drawing.Size(265, 99)
        Me.btnPrintAddBook.TabIndex = 1
        Me.btnPrintAddBook.Text = "&Add Book to Cart"
        Me.ToolTip1.SetToolTip(Me.btnPrintAddBook, "Click to add book to cart.")
        Me.btnPrintAddBook.UseVisualStyleBackColor = False
        '
        'grpSelectPrintBook
        '
        Me.grpSelectPrintBook.Controls.Add(Me.lstPrintBook)
        Me.grpSelectPrintBook.Location = New System.Drawing.Point(54, 31)
        Me.grpSelectPrintBook.Name = "grpSelectPrintBook"
        Me.grpSelectPrintBook.Size = New System.Drawing.Size(838, 320)
        Me.grpSelectPrintBook.TabIndex = 0
        Me.grpSelectPrintBook.TabStop = False
        Me.grpSelectPrintBook.Text = "Select a Print Book"
        '
        'lstPrintBook
        '
        Me.lstPrintBook.FormattingEnabled = True
        Me.lstPrintBook.ItemHeight = 31
        Me.lstPrintBook.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrintBook.Location = New System.Drawing.Point(60, 57)
        Me.lstPrintBook.Name = "lstPrintBook"
        Me.lstPrintBook.Size = New System.Drawing.Size(717, 221)
        Me.lstPrintBook.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstPrintBook, "Select an item from the list.")
        '
        'frmPrintBooks
        '
        Me.AcceptButton = Me.btnPrintAddBook
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnPrintClose
        Me.ClientSize = New System.Drawing.Size(933, 528)
        Me.Controls.Add(Me.btnPrintClose)
        Me.Controls.Add(Me.btnPrintAddBook)
        Me.Controls.Add(Me.grpSelectPrintBook)
        Me.Name = "frmPrintBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Books"
        Me.grpSelectPrintBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrintClose As Button
    Friend WithEvents btnPrintAddBook As Button
    Friend WithEvents grpSelectPrintBook As GroupBox
    Friend WithEvents lstPrintBook As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
