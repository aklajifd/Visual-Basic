Public Class frmModifyPayments
    '*******************************************************************************
    ' Exit Form: When user clicks on mnuFileClose, the form closes
    '*******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close() ' Close form
    End Sub
    '*******************************************************************************
    '                               End: Exit Form
    '*******************************************************************************

    '*******************************************************************************
    ' Binding Navigator Code: When user interacts with the Binding Navigator in
    ' frmModifyPayments, changes can be made to the Payments table.
    '*******************************************************************************
    Private Sub PaymentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KarateModifyPayments)
    End Sub
    '*******************************************************************************
    '                           End: Binding Navigator Code
    '*******************************************************************************

    '*******************************************************************************
    ' Load data: When user clicks on mnuPayments modify, the appropriate 
    ' data is loaded into dgvModifyPayments
    '*******************************************************************************
    Private Sub frmModifyPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateModifyMemberPayments.Members' table.
        'You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateModifyMemberPayments.Members)
        'TODO: This line of code loads data into the 'KarateModifyPayments.Payments' table.
        'You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateModifyPayments.Payments)
    End Sub
    '*******************************************************************************
    '                                  End: Load data
    '*******************************************************************************

    '*******************************************************************************
    ' Check for numeric: When user modifies txtAmount, display error if value
    ' entered is not numercial.
    '*******************************************************************************
    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If Not IsNumeric(txtAmount.Text) Then
            MessageBox.Show("You must enter a numeric value for the Amount.")
        End If
    End Sub
    '*******************************************************************************
    '                               End: Check for numeric
    '*******************************************************************************
End Class