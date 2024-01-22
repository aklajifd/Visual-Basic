'**********************************************************************************************************
' Programmer: Daniel Fijalka
' Date: 8/27/23
' Title: CS2453 Assignment 2 - Workshop Selector
' Description: An application that allows the user to select a workshop from a list box and a location
' from another list box. The total cost of user selections are displayed in a third list box, and when
' the user clicks on a button the total cost of all workshops are calculated and displayed.  
' Known Concerns: None
'**********************************************************************************************************
Option Strict On
Option Explicit On
Public Class frmMain
    '*******************************************************************************
    ' Add Workshop: When user clicks on btnWorkshop, the costs associated with
    ' the selected workshop and selected location are added, and the total is
    ' displayed in lstCosts. Validations are present to ensure user selects both
    ' a workshop and a location.
    '*******************************************************************************
    Private Sub btnWorkshop_Click(sender As Object, e As EventArgs) Handles btnWorkshop.Click
        ' Variable declaration
        Dim strWorkshop, strLocation As String
        Dim intLodgingFee, intAddTotalCost As Integer

        ' Validation using If...Then conditional statements to check if user has 
        ' selected both a workshop and location from ListBoxes
        If lstWorkshop.SelectedIndex <> -1 Then
            If lstLocation.SelectedIndex <> -1 Then
                ' Grab user selected items from ListBoxes 
                strWorkshop = lstWorkshop.SelectedItem.ToString()
                strLocation = lstLocation.SelectedItem.ToString()
                ' Select Case statement to assign lodging fee based on selected location
                Select Case strLocation
                    Case "Austin"
                        intLodgingFee = 95
                    Case "Chicago"
                        intLodgingFee = 125
                    Case "Dallas"
                        intLodgingFee = 110
                    Case "Orlando"
                        intLodgingFee = 100
                    Case "Phoenix"
                        intLodgingFee = 92
                    Case "Raleigh"
                        intLodgingFee = 90
                End Select
                ' Select Case statement to assign registration fee based on selected workshop and the workshops'
                ' number of days. Add to intAddTotalCost variable which will be displayed in lstCosts.
                Select Case strWorkshop
                    Case "Handling Stress"
                        intAddTotalCost = (intLodgingFee * 3) + 595
                    Case "Time Management"
                        intAddTotalCost = (intLodgingFee * 3) + 695
                    Case "Supervision Skills"
                        intAddTotalCost = (intLodgingFee * 3) + 995
                    Case "Negotiation"
                        intAddTotalCost = (intLodgingFee * 5) + 1295
                    Case "How to Interview"
                        intAddTotalCost = (intLodgingFee * 1) + 395
                End Select
                ' Add intAddTotalCost value to lstCosts items and display in currency
                lstCosts.Items.Add(intAddTotalCost.ToString("c"))
                ' Enable btnTotal once cost entry is added to lstCosts
                btnTotal.Enabled = True
            Else
                MessageBox.Show("You must select a location from the location list.") ' Display message if no location selected
            End If
        Else
            MessageBox.Show("You must select a workshop from the workshop list.") ' Display message if no workshop selected
        End If
    End Sub
    '*******************************************************************************
    '                              End: Add Workshop
    '*******************************************************************************

    '*******************************************************************************
    ' Calculate Total: When user clicks on btnTotal, the costs present in lstCosts
    ' are added and the total amount is displayed in lblCostResult.
    '*******************************************************************************
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' Variable declaration
        Dim intItemInCostList, intCostListTotal As Integer

        ' Error checking to ensure entries exist in lstCosts
        If Not lstCosts.Items.Count = 0 Then
            For intItemInCostList = 0 To (lstCosts.Items.Count - 1) ' Loop over Items in lstCosts
                intCostListTotal += CInt(lstCosts.Items.Item(intItemInCostList).ToString()) ' Convert running total to integer
            Next
            ' Display total cost in lblTotalCost formatted to currency
            lblCostResult.Text = intCostListTotal.ToString("c")
        End If
    End Sub
    '*******************************************************************************
    '                               End: Calculate Total 
    '*******************************************************************************

    '*******************************************************************************
    ' Reset Form: When user clicks on btnReset, the list boxes and labels on the 
    ' form are cleared, btnTotal becomes disabled, and the focus is returned 
    ' to the first ListBox.
    '*******************************************************************************
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear ListBoxes
        lstWorkshop.SelectedIndex = -1
        lstLocation.SelectedIndex = -1
        lstCosts.Items.Clear()
        ' Clear lblCostResult
        lblCostResult.Text = String.Empty
        ' Disable btnTotal
        btnTotal.Enabled = False
        ' Return focus to first ListBox which is lstWorkshop
        lstWorkshop.Focus()
    End Sub
    '*******************************************************************************
    '                                 End: Reset Form
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on btnExit, the form closes
    '*******************************************************************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close form
    End Sub
    '*******************************************************************************
    '                                 End: Exit Form
    '*******************************************************************************
End Class
