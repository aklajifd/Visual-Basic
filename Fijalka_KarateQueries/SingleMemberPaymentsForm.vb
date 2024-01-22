Public Class frmSingleMemberPayments
    '*******************************************************************************
    ' Exit Form: When user clicks on mnuFileClose, the form closes
    '*******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub
    '*******************************************************************************
    '                               End: Exit Form
    '*******************************************************************************

    '*******************************************************************************
    ' Load data: When user clicks on mnuPaymentsView, the appropriate 
    ' data is loaded into lstMembers and dgvSinglePayments. No items in lstMembers
    ' are selected by default. 
    '*******************************************************************************
    Private Sub frmSingleMemberPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateSingleMemberAmount.Payments' table.
        'You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateSingleMemberAmount.Payments)
        'TODO: This line of code loads data into the 'KarateSingleMemberPayments.Members' table.
        'You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateSingleMemberPayments.Members)
        lstMembers.SelectedIndex = -1 ' Deselect any items in lstMembers
    End Sub
    '*******************************************************************************
    '                               End: Load data
    '*******************************************************************************

    '*******************************************************************************
    ' Display Member Names: When user clicks on item in lstMembers,
    ' dgvSinglePayments displays the payment datae and amount of all payments made
    ' by the selected member.
    '*******************************************************************************
    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        Dim srtValue As Short = CShort(Me.lstMembers.SelectedValue) ' Convert selected index to short value
        Me.PaymentsTableAdapter.FillBy1(Me.KarateSingleMemberAmount.Payments, srtValue) ' Assign SelectedValue to query parameter 
    End Sub
    '*******************************************************************************
    '                           End: Display Member Names
    '*******************************************************************************
End Class