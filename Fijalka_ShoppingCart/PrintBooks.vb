Public Class frmPrintBooks
    '*******************************************************************************
    ' Select printed book: When user clicks on btnPrintAddBook, the user's selection
    ' is displayed in the lstShoppingCart in frmMain. A MessageBox is displayed if
    ' the user attempts to add a book without making a selection.
    '*******************************************************************************
    Private Sub btnPrintAddBook_Click(sender As Object, e As EventArgs) Handles btnPrintAddBook.Click
        ' Declare local variable for user book selection
        Dim userSelection As String
        ' Assign selected book to userSelection if an option was selected
        If lstPrintBook.SelectedIndex <> -1 Then
            userSelection = lstPrintBook.SelectedItem.ToString()
            frmMain.lstShoppingCart.Items.Add(userSelection)
            ' Call to AddPrintBook sub in MainForm
            frmMain.AddPrintBook(userSelection)
        Else ' Display MessageBox
            MessageBox.Show("Please select a book from the list.")
        End If
    End Sub
    '*******************************************************************************
    '                             End: Select printed book
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on btnPrintClose, the form closes
    '*******************************************************************************
    Private Sub btnPrintClose_Click(sender As Object, e As EventArgs)
        Me.Close() ' Close frmPrintBooks
    End Sub
    '*******************************************************************************
    '                               End: Exit Form
    '*******************************************************************************
End Class