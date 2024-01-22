'**********************************************************************************************************
' Programmer: Daniel Fijalka
' Date: 10/4/23
' Title: CS2453 Final Assignment - Cash Register
' Description: An application that includes a form to add, update, or display Inventory items. The 
' choices are presented as buttons, and the user is able to modify any property except the InvNumber 
' property. A text file is created named Inventory.txt, and the textfile is updated with any changes
' if the user selects a Save button. The user is able to select items from a ListBox and add them
' for purchasing. The form displays the calculated sales tax and total cost of selected items for purchase.
' Known Concerns: None
'**********************************************************************************************************
Option Strict On
Option Explicit On
Imports System.ComponentModel
Imports System.IO
Public Class frmMain
    '*******************************************************************************
    ' Creating FormAddItem instance: When user clicks on btnAddItem, an
    ' instance of frmPlayerNames is created and the form is shown.
    '*******************************************************************************
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim frmAdd As New FormAddItem
        frmAdd.ShowDialog()
        UpdateListBox() ' Update lstInventory display
    End Sub
    '*******************************************************************************
    '                        End: Creating FormAddItem instance
    '*******************************************************************************

    '*******************************************************************************
    ' Creating FormUpdateItem instance: When user clicks on btnUpdate, an
    ' instance of FormUpdateItem is created and the form is shown.
    '*******************************************************************************
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frmUpdate As New FormUpdateItem
        frmUpdate.ShowDialog()
        UpdateListBox() ' Update lstInventory display
    End Sub
    '*******************************************************************************
    '                   End: Creating FormUpdateItem instance
    '*******************************************************************************

    '*******************************************************************************
    ' Load Form: Upon form loading, a textfile named "Inventory.txt" is created if
    ' it does not already exist, and data for 5 inventory oebjts are written to it.
    ' If the file already exists, its' contents are populated into a collection of
    ' inventory objects.
    '*******************************************************************************
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCheckout.Enabled = False ' Disable checkout button while no items are selected
        If Not File.Exists("Inventory.txt") Then
            ' Define new StreamWriter object and create file
            Dim inventoryFile As StreamWriter
            Try
                inventoryFile = File.CreateText("Inventory.txt")
                inventoryFile.WriteLine("1A2023")
                inventoryFile.WriteLine("Hanging floor display")
                inventoryFile.WriteLine(40.0)
                inventoryFile.WriteLine(65.0)
                inventoryFile.WriteLine(7)
                inventoryFile.WriteLine("2A2023")
                inventoryFile.WriteLine("Plastic hangers")
                inventoryFile.WriteLine(3.5)
                inventoryFile.WriteLine(6.75)
                inventoryFile.WriteLine(30)
                inventoryFile.WriteLine("3A2023")
                inventoryFile.WriteLine("Clothing display rack")
                inventoryFile.WriteLine(35.0)
                inventoryFile.WriteLine(50.0)
                inventoryFile.WriteLine(4)
                inventoryFile.WriteLine("4A2023")
                inventoryFile.WriteLine("Glass Case")
                inventoryFile.WriteLine(120.0)
                inventoryFile.WriteLine(180.0)
                inventoryFile.WriteLine(2)
                inventoryFile.WriteLine("5A2023")
                inventoryFile.WriteLine("Comic book")
                inventoryFile.WriteLine(6.0)
                inventoryFile.WriteLine(9.0)
                inventoryFile.WriteLine(55)
                inventoryFile.Close() ' Close newly created file
            Catch
                MessageBox.Show("The file cannot be created.", "Error")
            End Try
        End If
        If File.Exists("Inventory.txt") Then
            ' Define new StreamWReader object
            Dim inputFile As StreamReader
            Try
                ' Open the file.
                inputFile = File.OpenText("Inventory.txt")
                ' Read the file's contents
                Do Until inputFile.EndOfStream
                    Dim newItem As New Inventory
                    newItem.InvNumber = inputFile.ReadLine()
                    newItem.Description = inputFile.ReadLine()
                    newItem.Cost = CDec(inputFile.ReadLine())
                    newItem.Retail = CDec(inputFile.ReadLine())
                    newItem.OnHand = CInt(inputFile.ReadLine())
                    AddItem(newItem) ' Add item to collection
                Loop
                inputFile.Close() ' Close file
                UpdateListBox() ' Show items in lstInventory
            Catch
                MessageBox.Show("The file cannot be opened.", "Error")
            End Try
        End If
    End Sub
    '*******************************************************************************
    '                                   End: Load Form
    '*******************************************************************************

    '*******************************************************************************
    ' Update ListBox: Function for updating and displaying the lstInventory.
    '*******************************************************************************
    Private Sub UpdateListBox()
        ' Clear the list box.
        lstInventory.Items.Clear()
        ' Load the inventory numbers in the collection into the list box.
        Dim i As Inventory
        For Each i In inventoryCollection
            If i.OnHand >= 0 Then ' Item shouldn't be available in lstInventory if number of units less than zero
                lstInventory.Items.Add(i.InvNumber)
            End If
        Next
    End Sub
    '*******************************************************************************
    '                               End: Update ListBox
    '*******************************************************************************

    '*******************************************************************************
    ' Display data: Function for displaying item properties in appropriate
    ' label fields. Called from btnLookupItem event handler.
    '*******************************************************************************
    Private Sub DisplayData(ByVal i As Inventory)
        lblInvNumberDisplay.Text = i.InvNumber
        lblDescriptionDisplay.Text = i.Description
        lblCostDisplay.Text = i.Cost.ToString("c")
        lblRetailDisplay.Text = i.Retail.ToString("c")
        lblOnHandDisplay.Text = i.OnHand.ToString()
    End Sub
    '*******************************************************************************
    '                                End: Display data
    '*******************************************************************************

    '*******************************************************************************
    ' Lookup item: When user clicks btnLookupItem, an InputBox is displayed
    ' prompting the user to enter the inventory number.
    '*******************************************************************************
    Private Sub btnLookupItem_Click(sender As Object, e As EventArgs) Handles btnLookupItem.Click
        Dim strUserLookup As String
        Dim i As Inventory
        Try
            strUserLookup = InputBox("Enter an inventory number.", "Inventory Number Lookup")
            i = CType(inventoryCollection.Item(strUserLookup), Inventory) ' Get inventory item from collection
            DisplayData(i)
        Catch ex As Exception
            ' Notify user that the InvNumber does not exist.
            MessageBox.Show("The inventory number was not located or does not exist. Please try again.", "Error")
        End Try
    End Sub
    '*******************************************************************************
    '                               End: Lookup item
    '*******************************************************************************

    '*******************************************************************************
    ' Change item selection: When user clicks on item in lstInventory, some of the
    ' item's information including description, retail price, and number of units
    ' on hand is displayed on the form.
    '*******************************************************************************
    Private Sub lstInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInventory.SelectedIndexChanged
        Try
            Dim i As Inventory
            i = CType(inventoryCollection.Item(lstInventory.SelectedItem.ToString()), Inventory) ' Find selected inventory item
            lblInventoryDescriptionDisplay.Text = i.Description
            lblInventoryRetailDisplay.Text = i.Retail.ToString("c")
            lblInventoryOnHandDisplay.Text = i.OnHand.ToString()
        Catch
            MessageBox.Show("The selected items were not found in the inventory.", "Error")
        End Try
    End Sub
    '*******************************************************************************
    '                           End: Change item selection
    '*******************************************************************************

    '*******************************************************************************
    ' Add item before purchase: When user clicks on btnAddSelected, the selected
    ' item's properties in lstInventory properties are extracted and used in
    ' calculations of the number of units left remaining for that item and the total
    ' cost if the user chooses to checkout.
    '*******************************************************************************
    Private Sub btnAddSelected_Click(sender As Object, e As EventArgs) Handles btnAddSelected.Click
        ' Procedure variables
        Dim i As Inventory
        Dim intNumPurchased As Integer = 0
        Dim decRetailPrice = 0.0D
        ' Enable btnCheckout after btnAddSelected is clicked
        btnCheckout.Enabled = True
        ' Check if item is selected in lstInventory
        If lstInventory.SelectedIndex <> -1 Then
            ' Get inventory item from collection
            i = CType(inventoryCollection.Item(lstInventory.SelectedItem.ToString()), Inventory)
            decRetailPrice = i.Retail ' Assign item's retail price to variable for calculations
            ' Validate user input in txtQuantity
            Try
                intNumPurchased = CInt(txtQuantity.Text)
                If intNumPurchased <= 0 Then
                    MessageBox.Show("Please enter a number greater than zero.")
                End If
                i.OnHand -= intNumPurchased ' Subtract added units from item stock
                lblInventoryOnHandDisplay.Text = i.OnHand.ToString()
                If i.OnHand < 0 Then
                    MessageBox.Show("The number of items added exceeds the number of items available." & ControlChars.CrLf &
                                        "Please re-enter the quantity of items to purchase.", "Error")
                    i.OnHand += intNumPurchased ' If subtracted units fall below zero, error and re-add units back to item stock
                    lblInventoryOnHandDisplay.Text = i.OnHand.ToString()
                End If
            Catch
                MessageBox.Show("Please enter a numeric value.")
            End Try
        Else
            MessageBox.Show("An item from the list must be selected and added before purchasing.", "Error")
        End If
        ' Calculations
        decSubtotal = CDec(intNumPurchased) * decRetailPrice
        decTotal += decSubtotal
    End Sub

    '*******************************************************************************
    '                           End: Add item before purchase
    '*******************************************************************************

    '*******************************************************************************
    ' Checkout items: When user clicks on btnCheckout, the total of all added
    ' items and the sales tax for all items added is displayed
    '*******************************************************************************
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        decSalesTaxTotal = decSALES_TAX * decSubtotal
        lblSalesTaxResult.Text = decSalesTaxTotal.ToString("c")
        lblTotalResult.Text = (decTotal + decSalesTaxTotal).ToString("c")
        ' Reset values
        decSubtotal = 0.0D
        decTotal = 0.0D
    End Sub
    '*******************************************************************************
    '                               End: Checkout items
    '*******************************************************************************

    '*******************************************************************************
    ' Closing without saving: When user tries to exit, the program checks to see
    ' if any new changes have been made to the collection since the last save. If
    ' so, it saves the changes to the text file before the form is closed.
    '*******************************************************************************
    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If blnIsChanged = False Then
            If MessageBox.Show("The current document is not saved. " & "Do you wish to discard your changes?",
                                "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    '*******************************************************************************
    '                           End: Closing without saving
    '*******************************************************************************

    '*******************************************************************************
    ' Save Form: When user clicks on btnSave, any edited or added items to the 
    ' inventory collection is updated in the text file.
    '*******************************************************************************
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim inventoryFile As StreamWriter
        Dim i As Inventory
        Try
            inventoryFile = File.AppendText("Inventory.txt") ' Open existing file and append data
            For Each i In inventoryCollection
                inventoryFile.WriteLine(i.InvNumber)
                inventoryFile.WriteLine(i.Description)
                inventoryFile.WriteLine(i.Cost)
                inventoryFile.WriteLine(i.Retail)
                inventoryFile.WriteLine(i.OnHand)
            Next
            inventoryFile.Close() ' Close file
        Catch
            MessageBox.Show("The file cannot be opened.", "Error")
        End Try
    End Sub
    '*******************************************************************************
    '                               End: Save Form
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on btnExit, the form closes
    '*******************************************************************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '*******************************************************************************
    '                               End: Exit Form
    '*******************************************************************************
End Class










