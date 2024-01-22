Public Class FormUpdateItem
    ' Class level inventory object
    Dim i As Inventory

    '*******************************************************************************
    ' Update item: Function for loading inventory object properties upon form
    ' loading. The user is able to enter an InvNumber for an item and its' 
    ' properties are displayed
    '*******************************************************************************
    Private Sub FormUpdateItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInvNumber.Enabled = False ' Do not allow user to modify InvNumber property
        btnSave.Enabled = False ' Disable btnSave until changes are made
        Dim strUserLookup As String
        Try
            strUserLookup = InputBox("Enter an inventory number.", "Inventory Number Lookup")
            i = CType(inventoryCollection.Item(strUserLookup), Inventory)
            txtInvNumber.Text = i.InvNumber
            txtDescription.Text = i.Description
            txtCost.Text = i.Cost.ToString("c")
            txtRetail.Text = i.Retail.ToString("c")
            txtOnHand.Text = i.OnHand.ToString
            btnSave.Enabled = True ' Enable save button
        Catch
            MessageBox.Show("The inventory number was not located or does not exist. Please try again.", "Error")
        End Try
    End Sub
    '*******************************************************************************
    '                               End: Update item
    '*******************************************************************************

    '*******************************************************************************
    ' Save item: Function for saving inventory object properties from text fields
    '*******************************************************************************
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        i.Description = txtDescription.Text
        i.Cost = CDec(txtCost.Text)
        i.Retail = CDec(txtRetail.Text)
        i.OnHand = CInt(txtOnHand.Text)
        blnIsChanged = True ' Marker for change event
    End Sub
    '*******************************************************************************
    '                               End: Save item
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on btnExit, the form closes
    '*******************************************************************************
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    '*******************************************************************************
    '                               End:Exit Form
    '*******************************************************************************
End Class