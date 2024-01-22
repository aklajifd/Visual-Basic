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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnCalTicketRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAdultTicketPrice = New System.Windows.Forms.TextBox()
        Me.txtChildTicketsSold = New System.Windows.Forms.TextBox()
        Me.txtChildTicketPrice = New System.Windows.Forms.TextBox()
        Me.txtAdultTicketsSold = New System.Windows.Forms.TextBox()
        Me.lblAdultTicketPrice = New System.Windows.Forms.Label()
        Me.lblAdultTicketsSold = New System.Windows.Forms.Label()
        Me.lblChildTicketPrice = New System.Windows.Forms.Label()
        Me.lblChildTicketsSold = New System.Windows.Forms.Label()
        Me.lblGrossAdultSales = New System.Windows.Forms.Label()
        Me.lblGrossChildSales = New System.Windows.Forms.Label()
        Me.lblTotalGrossRevenue = New System.Windows.Forms.Label()
        Me.lblNetAdultSales = New System.Windows.Forms.Label()
        Me.lblNetChildSales = New System.Windows.Forms.Label()
        Me.lblTotalNetRevenue = New System.Windows.Forms.Label()
        Me.grpBoxAdultSales = New System.Windows.Forms.GroupBox()
        Me.grpBoxChildSales = New System.Windows.Forms.GroupBox()
        Me.grpBoxGrossRevenue = New System.Windows.Forms.GroupBox()
        Me.lblGrossTotalResult = New System.Windows.Forms.Label()
        Me.lblGrossChildResult = New System.Windows.Forms.Label()
        Me.lblGrossAdultResult = New System.Windows.Forms.Label()
        Me.grpBoxNetRevenue = New System.Windows.Forms.GroupBox()
        Me.lblNetTotalResult = New System.Windows.Forms.Label()
        Me.lblNetChildResult = New System.Windows.Forms.Label()
        Me.lblNetAdultResult = New System.Windows.Forms.Label()
        Me.picBoxTheaterImage = New System.Windows.Forms.PictureBox()
        Me.lblTotalTicketsSold = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.grpBoxAdultSales.SuspendLayout()
        Me.grpBoxChildSales.SuspendLayout()
        Me.grpBoxGrossRevenue.SuspendLayout()
        Me.grpBoxNetRevenue.SuspendLayout()
        CType(Me.picBoxTheaterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalTicketRevenue
        '
        Me.btnCalTicketRevenue.BackColor = System.Drawing.Color.Wheat
        Me.btnCalTicketRevenue.Location = New System.Drawing.Point(947, 971)
        Me.btnCalTicketRevenue.Name = "btnCalTicketRevenue"
        Me.btnCalTicketRevenue.Size = New System.Drawing.Size(422, 85)
        Me.btnCalTicketRevenue.TabIndex = 6
        Me.btnCalTicketRevenue.Text = "&Calculate Ticket Revenue"
        Me.btnCalTicketRevenue.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Wheat
        Me.btnClear.Location = New System.Drawing.Point(1428, 971)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(191, 85)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(1670, 971)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(187, 85)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAdultTicketPrice
        '
        Me.txtAdultTicketPrice.Location = New System.Drawing.Point(447, 82)
        Me.txtAdultTicketPrice.Name = "txtAdultTicketPrice"
        Me.txtAdultTicketPrice.Size = New System.Drawing.Size(230, 38)
        Me.txtAdultTicketPrice.TabIndex = 1
        Me.txtAdultTicketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChildTicketsSold
        '
        Me.txtChildTicketsSold.Location = New System.Drawing.Point(450, 184)
        Me.txtChildTicketsSold.Name = "txtChildTicketsSold"
        Me.txtChildTicketsSold.Size = New System.Drawing.Size(230, 38)
        Me.txtChildTicketsSold.TabIndex = 3
        Me.txtChildTicketsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChildTicketPrice
        '
        Me.txtChildTicketPrice.Location = New System.Drawing.Point(450, 91)
        Me.txtChildTicketPrice.Name = "txtChildTicketPrice"
        Me.txtChildTicketPrice.Size = New System.Drawing.Size(230, 38)
        Me.txtChildTicketPrice.TabIndex = 1
        Me.txtChildTicketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdultTicketsSold
        '
        Me.txtAdultTicketsSold.Location = New System.Drawing.Point(447, 178)
        Me.txtAdultTicketsSold.Name = "txtAdultTicketsSold"
        Me.txtAdultTicketsSold.Size = New System.Drawing.Size(230, 38)
        Me.txtAdultTicketsSold.TabIndex = 3
        Me.txtAdultTicketsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAdultTicketPrice
        '
        Me.lblAdultTicketPrice.AutoSize = True
        Me.lblAdultTicketPrice.Location = New System.Drawing.Point(179, 88)
        Me.lblAdultTicketPrice.Name = "lblAdultTicketPrice"
        Me.lblAdultTicketPrice.Size = New System.Drawing.Size(219, 32)
        Me.lblAdultTicketPrice.TabIndex = 0
        Me.lblAdultTicketPrice.Text = "&Price per Ticket:"
        '
        'lblAdultTicketsSold
        '
        Me.lblAdultTicketsSold.AutoSize = True
        Me.lblAdultTicketsSold.Location = New System.Drawing.Point(220, 184)
        Me.lblAdultTicketsSold.Name = "lblAdultTicketsSold"
        Me.lblAdultTicketsSold.Size = New System.Drawing.Size(178, 32)
        Me.lblAdultTicketsSold.TabIndex = 2
        Me.lblAdultTicketsSold.Text = "&Tickets Sold:"
        '
        'lblChildTicketPrice
        '
        Me.lblChildTicketPrice.AutoSize = True
        Me.lblChildTicketPrice.Location = New System.Drawing.Point(186, 91)
        Me.lblChildTicketPrice.Name = "lblChildTicketPrice"
        Me.lblChildTicketPrice.Size = New System.Drawing.Size(219, 32)
        Me.lblChildTicketPrice.TabIndex = 0
        Me.lblChildTicketPrice.Text = "Pr&ice per Ticket:"
        '
        'lblChildTicketsSold
        '
        Me.lblChildTicketsSold.AutoSize = True
        Me.lblChildTicketsSold.Location = New System.Drawing.Point(227, 190)
        Me.lblChildTicketsSold.Name = "lblChildTicketsSold"
        Me.lblChildTicketsSold.Size = New System.Drawing.Size(178, 32)
        Me.lblChildTicketsSold.TabIndex = 2
        Me.lblChildTicketsSold.Text = "Tickets &Sold:"
        '
        'lblGrossAdultSales
        '
        Me.lblGrossAdultSales.AutoSize = True
        Me.lblGrossAdultSales.Location = New System.Drawing.Point(137, 77)
        Me.lblGrossAdultSales.Name = "lblGrossAdultSales"
        Me.lblGrossAdultSales.Size = New System.Drawing.Size(251, 32)
        Me.lblGrossAdultSales.TabIndex = 0
        Me.lblGrossAdultSales.Text = "Adult Ticket Sales:"
        '
        'lblGrossChildSales
        '
        Me.lblGrossChildSales.AutoSize = True
        Me.lblGrossChildSales.Location = New System.Drawing.Point(137, 176)
        Me.lblGrossChildSales.Name = "lblGrossChildSales"
        Me.lblGrossChildSales.Size = New System.Drawing.Size(251, 32)
        Me.lblGrossChildSales.TabIndex = 2
        Me.lblGrossChildSales.Text = "Child Ticket Sales:"
        '
        'lblTotalGrossRevenue
        '
        Me.lblTotalGrossRevenue.AutoSize = True
        Me.lblTotalGrossRevenue.Location = New System.Drawing.Point(106, 247)
        Me.lblTotalGrossRevenue.Name = "lblTotalGrossRevenue"
        Me.lblTotalGrossRevenue.Size = New System.Drawing.Size(282, 64)
        Me.lblTotalGrossRevenue.TabIndex = 4
        Me.lblTotalGrossRevenue.Text = "Total Gross Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        for Ticket Sales:"
        '
        'lblNetAdultSales
        '
        Me.lblNetAdultSales.AutoSize = True
        Me.lblNetAdultSales.Location = New System.Drawing.Point(127, 80)
        Me.lblNetAdultSales.Name = "lblNetAdultSales"
        Me.lblNetAdultSales.Size = New System.Drawing.Size(251, 32)
        Me.lblNetAdultSales.TabIndex = 0
        Me.lblNetAdultSales.Text = "Adult Ticket Sales:"
        '
        'lblNetChildSales
        '
        Me.lblNetChildSales.AutoSize = True
        Me.lblNetChildSales.Location = New System.Drawing.Point(127, 168)
        Me.lblNetChildSales.Name = "lblNetChildSales"
        Me.lblNetChildSales.Size = New System.Drawing.Size(251, 32)
        Me.lblNetChildSales.TabIndex = 2
        Me.lblNetChildSales.Text = "Child Ticket Sales:"
        '
        'lblTotalNetRevenue
        '
        Me.lblTotalNetRevenue.AutoSize = True
        Me.lblTotalNetRevenue.Location = New System.Drawing.Point(104, 239)
        Me.lblTotalNetRevenue.Name = "lblTotalNetRevenue"
        Me.lblTotalNetRevenue.Size = New System.Drawing.Size(274, 64)
        Me.lblTotalNetRevenue.TabIndex = 4
        Me.lblTotalNetRevenue.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        for Ticket Sales:"
        '
        'grpBoxAdultSales
        '
        Me.grpBoxAdultSales.Controls.Add(Me.lblAdultTicketPrice)
        Me.grpBoxAdultSales.Controls.Add(Me.txtAdultTicketPrice)
        Me.grpBoxAdultSales.Controls.Add(Me.txtAdultTicketsSold)
        Me.grpBoxAdultSales.Controls.Add(Me.lblAdultTicketsSold)
        Me.grpBoxAdultSales.Location = New System.Drawing.Point(105, 40)
        Me.grpBoxAdultSales.Name = "grpBoxAdultSales"
        Me.grpBoxAdultSales.Size = New System.Drawing.Size(757, 292)
        Me.grpBoxAdultSales.TabIndex = 0
        Me.grpBoxAdultSales.TabStop = False
        Me.grpBoxAdultSales.Text = "Adult Ticket Sales"
        '
        'grpBoxChildSales
        '
        Me.grpBoxChildSales.Controls.Add(Me.lblChildTicketPrice)
        Me.grpBoxChildSales.Controls.Add(Me.txtChildTicketPrice)
        Me.grpBoxChildSales.Controls.Add(Me.txtChildTicketsSold)
        Me.grpBoxChildSales.Controls.Add(Me.lblChildTicketsSold)
        Me.grpBoxChildSales.Location = New System.Drawing.Point(1028, 40)
        Me.grpBoxChildSales.Name = "grpBoxChildSales"
        Me.grpBoxChildSales.Size = New System.Drawing.Size(757, 292)
        Me.grpBoxChildSales.TabIndex = 1
        Me.grpBoxChildSales.TabStop = False
        Me.grpBoxChildSales.Text = "Child Ticket Sales"
        '
        'grpBoxGrossRevenue
        '
        Me.grpBoxGrossRevenue.Controls.Add(Me.lblGrossTotalResult)
        Me.grpBoxGrossRevenue.Controls.Add(Me.lblGrossChildResult)
        Me.grpBoxGrossRevenue.Controls.Add(Me.lblGrossAdultResult)
        Me.grpBoxGrossRevenue.Controls.Add(Me.lblGrossAdultSales)
        Me.grpBoxGrossRevenue.Controls.Add(Me.lblGrossChildSales)
        Me.grpBoxGrossRevenue.Controls.Add(Me.lblTotalGrossRevenue)
        Me.grpBoxGrossRevenue.Location = New System.Drawing.Point(105, 375)
        Me.grpBoxGrossRevenue.Name = "grpBoxGrossRevenue"
        Me.grpBoxGrossRevenue.Size = New System.Drawing.Size(757, 355)
        Me.grpBoxGrossRevenue.TabIndex = 2
        Me.grpBoxGrossRevenue.TabStop = False
        Me.grpBoxGrossRevenue.Text = "Gross Ticket Revenue"
        '
        'lblGrossTotalResult
        '
        Me.lblGrossTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossTotalResult.Location = New System.Drawing.Point(447, 246)
        Me.lblGrossTotalResult.Name = "lblGrossTotalResult"
        Me.lblGrossTotalResult.Size = New System.Drawing.Size(230, 61)
        Me.lblGrossTotalResult.TabIndex = 5
        Me.lblGrossTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossChildResult
        '
        Me.lblGrossChildResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossChildResult.Location = New System.Drawing.Point(447, 147)
        Me.lblGrossChildResult.Name = "lblGrossChildResult"
        Me.lblGrossChildResult.Size = New System.Drawing.Size(230, 61)
        Me.lblGrossChildResult.TabIndex = 3
        Me.lblGrossChildResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossAdultResult
        '
        Me.lblGrossAdultResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossAdultResult.Location = New System.Drawing.Point(447, 48)
        Me.lblGrossAdultResult.Name = "lblGrossAdultResult"
        Me.lblGrossAdultResult.Size = New System.Drawing.Size(230, 61)
        Me.lblGrossAdultResult.TabIndex = 1
        Me.lblGrossAdultResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBoxNetRevenue
        '
        Me.grpBoxNetRevenue.Controls.Add(Me.lblNetTotalResult)
        Me.grpBoxNetRevenue.Controls.Add(Me.lblNetChildResult)
        Me.grpBoxNetRevenue.Controls.Add(Me.lblNetAdultResult)
        Me.grpBoxNetRevenue.Controls.Add(Me.lblNetAdultSales)
        Me.grpBoxNetRevenue.Controls.Add(Me.lblNetChildSales)
        Me.grpBoxNetRevenue.Controls.Add(Me.lblTotalNetRevenue)
        Me.grpBoxNetRevenue.Location = New System.Drawing.Point(1028, 375)
        Me.grpBoxNetRevenue.Name = "grpBoxNetRevenue"
        Me.grpBoxNetRevenue.Size = New System.Drawing.Size(757, 355)
        Me.grpBoxNetRevenue.TabIndex = 3
        Me.grpBoxNetRevenue.TabStop = False
        Me.grpBoxNetRevenue.Text = "Net Ticket Revenue"
        '
        'lblNetTotalResult
        '
        Me.lblNetTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetTotalResult.Location = New System.Drawing.Point(450, 242)
        Me.lblNetTotalResult.Name = "lblNetTotalResult"
        Me.lblNetTotalResult.Size = New System.Drawing.Size(230, 61)
        Me.lblNetTotalResult.TabIndex = 5
        Me.lblNetTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetChildResult
        '
        Me.lblNetChildResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetChildResult.Location = New System.Drawing.Point(450, 139)
        Me.lblNetChildResult.Name = "lblNetChildResult"
        Me.lblNetChildResult.Size = New System.Drawing.Size(230, 61)
        Me.lblNetChildResult.TabIndex = 3
        Me.lblNetChildResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetAdultResult
        '
        Me.lblNetAdultResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetAdultResult.Location = New System.Drawing.Point(450, 51)
        Me.lblNetAdultResult.Name = "lblNetAdultResult"
        Me.lblNetAdultResult.Size = New System.Drawing.Size(230, 61)
        Me.lblNetAdultResult.TabIndex = 1
        Me.lblNetAdultResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBoxTheaterImage
        '
        Me.picBoxTheaterImage.Image = CType(resources.GetObject("picBoxTheaterImage.Image"), System.Drawing.Image)
        Me.picBoxTheaterImage.Location = New System.Drawing.Point(105, 754)
        Me.picBoxTheaterImage.Name = "picBoxTheaterImage"
        Me.picBoxTheaterImage.Size = New System.Drawing.Size(300, 230)
        Me.picBoxTheaterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBoxTheaterImage.TabIndex = 9
        Me.picBoxTheaterImage.TabStop = False
        '
        'lblTotalTicketsSold
        '
        Me.lblTotalTicketsSold.AutoSize = True
        Me.lblTotalTicketsSold.Location = New System.Drawing.Point(1022, 788)
        Me.lblTotalTicketsSold.Name = "lblTotalTicketsSold"
        Me.lblTotalTicketsSold.Size = New System.Drawing.Size(249, 32)
        Me.lblTotalTicketsSold.TabIndex = 4
        Me.lblTotalTicketsSold.Text = "Total Tickets Sold:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Georgia", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(1022, 856)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(204, 32)
        Me.lblCurrentDate.TabIndex = 5
        Me.lblCurrentDate.Text = "Current Date"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalTicketRevenue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1915, 1318)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblTotalTicketsSold)
        Me.Controls.Add(Me.picBoxTheaterImage)
        Me.Controls.Add(Me.grpBoxNetRevenue)
        Me.Controls.Add(Me.grpBoxGrossRevenue)
        Me.Controls.Add(Me.grpBoxChildSales)
        Me.Controls.Add(Me.grpBoxAdultSales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalTicketRevenue)
        Me.Name = "frmMain"
        Me.Text = "Theater Revenue by Daniel Fijalka"
        Me.grpBoxAdultSales.ResumeLayout(False)
        Me.grpBoxAdultSales.PerformLayout()
        Me.grpBoxChildSales.ResumeLayout(False)
        Me.grpBoxChildSales.PerformLayout()
        Me.grpBoxGrossRevenue.ResumeLayout(False)
        Me.grpBoxGrossRevenue.PerformLayout()
        Me.grpBoxNetRevenue.ResumeLayout(False)
        Me.grpBoxNetRevenue.PerformLayout()
        CType(Me.picBoxTheaterImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalTicketRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAdultTicketPrice As TextBox
    Friend WithEvents txtChildTicketsSold As TextBox
    Friend WithEvents txtChildTicketPrice As TextBox
    Friend WithEvents txtAdultTicketsSold As TextBox
    Friend WithEvents lblAdultTicketPrice As Label
    Friend WithEvents lblAdultTicketsSold As Label
    Friend WithEvents lblChildTicketPrice As Label
    Friend WithEvents lblChildTicketsSold As Label
    Friend WithEvents lblGrossAdultSales As Label
    Friend WithEvents lblGrossChildSales As Label
    Friend WithEvents lblTotalGrossRevenue As Label
    Friend WithEvents lblNetAdultSales As Label
    Friend WithEvents lblNetChildSales As Label
    Friend WithEvents lblTotalNetRevenue As Label
    Friend WithEvents grpBoxAdultSales As GroupBox
    Friend WithEvents grpBoxChildSales As GroupBox
    Friend WithEvents grpBoxGrossRevenue As GroupBox
    Friend WithEvents lblGrossTotalResult As Label
    Friend WithEvents lblGrossChildResult As Label
    Friend WithEvents lblGrossAdultResult As Label
    Friend WithEvents grpBoxNetRevenue As GroupBox
    Friend WithEvents lblNetTotalResult As Label
    Friend WithEvents lblNetChildResult As Label
    Friend WithEvents lblNetAdultResult As Label
    Friend WithEvents picBoxTheaterImage As PictureBox
    Friend WithEvents lblTotalTicketsSold As Label
    Friend WithEvents lblCurrentDate As Label
End Class
