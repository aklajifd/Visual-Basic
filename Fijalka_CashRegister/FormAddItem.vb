Public Class FormAddItem
    '*******************************************************************************
    ' Add item: Function for adding new inventory object to colletion
    '*******************************************************************************
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim objItem As New Inventory
        ' Get data from the form
        GetData(objItem)
        AddItem(objItem) ' Add item to collection
        blnIsChanged = True ' Marker for change event 
        ClearForm()
    End Sub
    '*******************************************************************************
    '                                 End: Add item
    '*******************************************************************************

    '*******************************************************************************
    ' Get data: Function for displaying item properties in appropriate text boxes.
    '*******************************************************************************
    Private Sub GetData(ByVal item As Inventory)
        Try
            item.InvNumber = txtInvNumber.Text
            item.Description = txtDescription.Text
            item.Cost = CDec(txtCost.Text)
            item.Retail = CDec(txtRetail.Text)
            item.OnHand = CInt(txtOnHand.Text)
        Catch
            MessageBox.Show("Please enter valid values in the text boxes.", "Entry error")
        End Try
    End Sub
    '*******************************************************************************
    '                                 End: Get data
    '*******************************************************************************

    '*******************************************************************************
    ' Clear form: Function for clearing values in page text boxes.
    '*******************************************************************************
    Private Sub ClearForm()
        'Clear the text boxes.
        txtInvNumber.Text = String.Empty
        txtDescription.Text = String.Empty
        txtCost.Text = String.Empty
        txtRetail.Text = String.Empty
        txtOnHand.Text = String.Empty
        txtInvNumber.Focus() ' Return focus to top text box
    End Sub
    '*******************************************************************************
    '                                 End: Clear form
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on btnClose, the form closes
    '*******************************************************************************
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    '*******************************************************************************
    '                                 End: Exit Form
    '*******************************************************************************
End Class
