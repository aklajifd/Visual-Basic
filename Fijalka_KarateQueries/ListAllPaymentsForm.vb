Public Class frmListAllPayments
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
    ' Load data: When user clicks on mnuPaymentsList, the appropriate 
    ' data is loaded into dgvPayments
    '*******************************************************************************
    Private Sub ListAllPaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateMembersPayments.Payments' table.
        ' You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateMembersPayments.Payments)
    End Sub
    '*******************************************************************************
    '                               End: Load data
    '*******************************************************************************
End Class