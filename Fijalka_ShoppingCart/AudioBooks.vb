Public Class frmAudioBooks
    '*******************************************************************************
    ' Select audio book: When user clicks on btnAudioAddBook, the user's selection
    ' is displayed in the lstShoppingCart in frmMain. A MessageBox is displayed if
    ' the user attempts to add a book without making a selection.
    '*******************************************************************************
    Private Sub btnAudioAddBook_Click(sender As Object, e As EventArgs) Handles btnAudioAddBook.Click
        ' Declare local variable for user book selection
        Dim userSelection As String
        ' Assign selected book to userSelection if an option was selected
        If lstAudioBook.SelectedIndex <> -1 Then
            userSelection = lstAudioBook.SelectedItem.ToString()
            frmMain.lstShoppingCart.Items.Add(userSelection)
            ' Call to AddAudioBook sub in MainForm
            frmMain.AddAudioBook(userSelection)
        Else ' Display MessageBox
            MessageBox.Show("Please select a book from the list.")
        End If
    End Sub
    '*******************************************************************************
    '                             End: Select audio book
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on btnAudioClose, the form closes
    '*******************************************************************************
    Private Sub btnAudioClose_Click(sender As Object, e As EventArgs) Handles btnAudioClose.Click
        Me.Close()  ' Close frmAudioBooks
    End Sub
    '*******************************************************************************
    '                             End: Exit Form
    '*******************************************************************************
End Class