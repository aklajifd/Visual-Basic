Module InventoryCollectionModule
    ' Create a collection to hold Inventory objects
    Public inventoryCollection As New Collection
    ' Global variables
    Public Const decSALES_TAX As Decimal = 0.36D
    Public decSalesTaxTotal As Decimal = 0.0D
    Public decSubtotal As Decimal = 0.0D
    Public decTotal As Decimal = 0.0D
    Public blnIsChanged As Boolean = False

    '*******************************************************************************
    ' Adding item to collection: Function that accepts an inventory object as a
    ' parameter. The passed object is added to the inventory collection.
    '*******************************************************************************
    Public Sub AddItem(ByVal item As Inventory)
        Try
            inventoryCollection.Add(item, item.InvNumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*******************************************************************************
    '                       End: Adding item to collection
    '*******************************************************************************
End Module
