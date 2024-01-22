'**********************************************************************************************************
' Programmer: Daniel Fijalka
' Date: 9/2/23
' Title: CS2453 Assignment 3 - ShoppingCartSystem
' Description: A program that allows the user to add a print book or audio book to a shopping
' cart via a menu. The subtotal, tax, shipping, and total cost is displayed. The user is able to
' remove items from the shopping cart and the total costs are recalculated and displayed. The menu
' also lets the user reset their selections.
' Known Concerns: I attempted to use the Standard Module as a startup object, but could not get
' my program to work with this method. I would normally troubleshoot this before turning the assignment
' in but I will be out of town this weekend, and didn't want to submit the assignment late. 
'**********************************************************************************************************
Option Strict On
Option Explicit On
Public Class frmMain
    '*******************************************************************************
    ' Reset Form: When user clicks on mnuFileReset, all labels and lstShoppingCart
    ' are cleared, and the global variables for total values are reset to 0D
    '*******************************************************************************
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        ' Clear the shopping cart and label text properties
        lstShoppingCart.Items.Clear()
        lblSubtotalResult.Text = String.Empty
        lblTaxResult.Text = String.Empty
        lblShippingResult.Text = String.Empty
        lblTotalResult.Text = String.Empty
        'Reset global variables for total values to 0D
        g_decSales_Tax_Total = 0D
        g_decShipping_Total = 0D
        g_decSubtotal = 0D
        g_decFinalTotal = 0D
    End Sub
    '*******************************************************************************
    '                                End: Reset Form
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on mnuFileExit, the form closes
    '*******************************************************************************
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close() 'Exit and close the form
    End Sub
    '*******************************************************************************
    '                                  End: Exit Form
    '*******************************************************************************

    '*******************************************************************************
    ' Creating frmPrintBooks instance: When user clicks on mnuProdcutsPrint or
    ' ctxPrintBooks, an instance of frmPrintBooks is created and the form is shown.
    '*******************************************************************************
    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProductsPrint.Click, ctxPrintBooks.Click
        Dim frmPrintBooks As New frmPrintBooks
        frmPrintBooks.ShowDialog()
    End Sub
    '*******************************************************************************
    '                       End: Creating frmPrintBooks instance
    '*******************************************************************************

    '*******************************************************************************
    ' Creating frmAudioBooks instance: When user clicks on mnuProdcutsAudio or
    ' ctxAudioBooks, an instance of frmAudioBooks is created and the form is shown.
    '*******************************************************************************
    Private Sub mnuProductsAudio_Click(sender As Object, e As EventArgs) Handles mnuProductsAudio.Click, ctxAudioBooks.Click
        Dim frmAudioBooks As New frmAudioBooks
        frmAudioBooks.ShowDialog()
    End Sub
    '*******************************************************************************
    '                       End: Creating frmAudioBooks instance
    '*******************************************************************************

    '*******************************************************************************
    ' Remove shopping cart item: When user clicks on btnRemove, the subtotal, tax 
    ' shipping, and total fields are adjusted accordingly
    '*******************************************************************************
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Local variable for selected item
        Dim productSelection As String
        ' Check if lstShoppingCart has any items
        If lstShoppingCart.SelectedIndex <> -1 Then
            productSelection = lstShoppingCart.SelectedItem.ToString()
            ' Recalculate values for the subtotal and shipping total, and call DisplayResults
            ' which will adjust for the tax and final total and display adjusted totals
            If productSelection = g_strPrintIDidIt Then
                g_decSubtotal -= g_decPRINT_I_DID_IT
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            ElseIf productSelection = g_strPrintTheHistory Then
                g_decSubtotal -= g_decPRINT_HISTORY_OF_SCOTLAND
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            ElseIf productSelection = g_strPrintLearnCalculus Then
                g_decSubtotal -= g_decPRINT_LEARN_CALCULUS
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            ElseIf productSelection = g_strPrintFeelTheStress Then
                g_decSubtotal -= g_decPRINT_FEEL_THE_STRESS
                g_decShipping_Total -= g_decSHIPPING_CHARGE
            ElseIf productSelection = g_strAudioLearnCalculus Then
                g_decSubtotal -= g_decAUDIO_LEARN_CALCULUS
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            ElseIf productSelection = g_strAudioTheHistory Then
                g_decSubtotal -= g_decAUDIO_HISTORY_OF_SCOTLAND
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            ElseIf productSelection = g_strAudioTheScience Then
                g_decSubtotal -= g_decAUDIO_SCIENCE_BODY
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            ElseIf productSelection = g_strAudioRelaxation Then
                g_decSubtotal -= g_decAUDIO_RELAXATION
                g_decShipping_Total -= g_decSHIPPING_CHARGE
                DisplayResults()
            End If
            ' Remove selected items from lstShoppingCart items
            lstShoppingCart.Items.Remove(productSelection)
        End If
    End Sub
    '*******************************************************************************
    '                           End: Remove shopping cart item
    '*******************************************************************************

    '*******************************************************************************
    ' Add printed book: This procedure is called from frmPrintBooks and accepts a
    ' string argument for the value of the user's selected book. The subtotal and
    ' shipping constant are added and the DisplayResults procedure is called to
    ' account for the tax and final total. Totals are displayed via DisplayResults.
    '*******************************************************************************
    Public Sub AddPrintBook(ByVal addedItem As String)
        If addedItem = g_strPrintIDidIt Then
            g_decSubtotal += g_decPRINT_I_DID_IT
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        ElseIf addedItem = g_strPrintTheHistory Then
            g_decSubtotal += g_decPRINT_HISTORY_OF_SCOTLAND
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        ElseIf addedItem = g_strPrintLearnCalculus Then
            g_decSubtotal += g_decPRINT_LEARN_CALCULUS
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        ElseIf addedItem = g_strPrintFeelTheStress Then
            g_decSubtotal += g_decPRINT_FEEL_THE_STRESS
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        End If
    End Sub
    '*******************************************************************************
    '                           End: Add printed book
    '*******************************************************************************

    '*******************************************************************************
    ' Add audio book: This procedure is called from frmAudioBooks and accepts a
    ' string argument for the value of the user's selected book. The subtotal and
    ' shipping constant are added and the DisplayResults procedure is called to
    ' account for the tax and final total. Totals are displayed via DisplayResults.
    '*******************************************************************************
    Public Sub AddAudioBook(ByVal addedItem As String)
        If addedItem = g_strAudioLearnCalculus Then
            g_decSubtotal += g_decAUDIO_LEARN_CALCULUS
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        ElseIf addedItem = g_strAudioTheHistory Then
            g_decSubtotal += g_decAUDIO_HISTORY_OF_SCOTLAND
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        ElseIf addedItem = g_strAudioTheScience Then
            g_decSubtotal += g_decAUDIO_SCIENCE_BODY
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        ElseIf addedItem = g_strAudioRelaxation Then
            g_decSubtotal += g_decAUDIO_RELAXATION
            g_decShipping_Total += g_decSHIPPING_CHARGE
            DisplayResults()
        End If
    End Sub
    '*******************************************************************************
    '                             End: Add audio book
    '*******************************************************************************

    '*******************************************************************************
    ' Calculate Tax Procedure: When procedure is called, the global variable for 
    ' sales tax is calculated based on the subtotal for items in lstShoppingCart
    '*******************************************************************************
    Public Sub CalculateTax()
        g_decSales_Tax_Total = g_decSubtotal * g_decSALES_TAX
    End Sub
    '*******************************************************************************
    '                       End: Calculate Tax Procedure
    '*******************************************************************************

    '*******************************************************************************
    ' Calculate Total Procedure: When procedure is called, the global variable for 
    ' final total is calculated based on the added subtotal, sales tax, and shipping
    '*******************************************************************************
    Public Sub CalculateTotal()
        g_decFinalTotal = g_decSubtotal + g_decSales_Tax_Total + g_decShipping_Total
    End Sub
    '*******************************************************************************
    '                       End: Calculate Total Procedure
    '*******************************************************************************

    '*******************************************************************************
    ' Display Results: When procedure is called, the label text properties are
    ' assigned to the appropriate calculated values and displayed as currency
    '*******************************************************************************
    Private Sub DisplayResults()
        CalculateTax()
        CalculateTotal()
        lblSubtotalResult.Text = g_decSubtotal.ToString("c")
        lblTaxResult.Text = g_decSales_Tax_Total.ToString("c")
        lblShippingResult.Text = g_decShipping_Total.ToString("c")
        lblTotalResult.Text = g_decFinalTotal.ToString("c")
    End Sub
    '*******************************************************************************
    '                              End: Display Results
    '*******************************************************************************


    '*******************************************************************************
    ' Display About Box: When user clicks on mnuHelpAbout, the About Box is shown
    '*******************************************************************************
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Program: Shopping Cart System" & ControlChars.CrLf &
                        "Programmer: Daniel Fijalka")
    End Sub
    '*******************************************************************************
    '                             End: Display About Box
    '*******************************************************************************
End Class
