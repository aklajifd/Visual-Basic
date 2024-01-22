Public Class fmrPhoneNumbers
    '*******************************************************************************
    ' Load data: When user clicks on mnuMembershipListPhoneNumbers, the appropriate 
    ' data is loaded into dgvPhoneNumbers
    '*******************************************************************************
    Private Sub PhoneNumbersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateMemberPhoneNumbers.Members' table.
        ' You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateMemberPhoneNumbers.Members)
    End Sub
    '*******************************************************************************
    '                               End: Load data
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on mnuFileClose, the form closes
    '*******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close() ' Close form
    End Sub
    '*******************************************************************************
    '                               End: Exit Form
    '*******************************************************************************
End Class