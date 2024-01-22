'**********************************************************************************************************
' Programmer: Daniel Fijalka
' Date: 9/17/23
' Title: CS2453 Assignment 5 - Karate
' Description: The program utilizes several menu options that allow a user to interact with a
' Karate database attached to the application. The user can display the names and phone numbers 
' of members, display payment details made to the karate school by all members, display the
' dates members joined, and display the payments made by an individual member.
' Known Concerns: None
'**********************************************************************************************************
Option Strict On
Option Explicit On
Public Class frmMain
    '****************************************************************************
    ' Exit Form: When user clicks on mnuFileExit, the form closes
    '****************************************************************************
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close() ' Close form
    End Sub
    '****************************************************************************
    '                                  End: Exit Form
    '****************************************************************************

    '**************************************************************************************
    ' Creating frmListByJoinDate instance: When user clicks on mnuMembershipListMembers, 
    ' instance of frmListByJoinDate is created and the form is shown.
    '**************************************************************************************
    Private Sub mnuMembershipListMembers_Click(sender As Object, e As EventArgs) Handles mnuMembershipListMembers.Click
        Dim frmListByJoinDate As New frmListByJoinDate ' Create instance
        frmListByJoinDate.ShowDialog() ' Display form
    End Sub
    '**************************************************************************************
    '                       End: Creating frmListByJoinDate instance
    '**************************************************************************************

    '****************************************************************************************
    ' Creating fmrPhoneNumbers instance: When user clicks on mnuMembershipListPhoneNumbers, 
    ' instance of fmrPhoneNumbers is created and the form is shown.
    '****************************************************************************************
    Private Sub mnuMembershipListPhoneNumbers_Click(sender As Object, e As EventArgs) Handles mnuMembershipListPhoneNumbers.Click
        Dim frmPhoneNumbers As New fmrPhoneNumbers ' Create instance
        frmPhoneNumbers.ShowDialog() ' Display form
    End Sub
    '****************************************************************************************
    '                       End: Creating fmrPhoneNumbers instance
    '****************************************************************************************

    '********************************************************************************
    ' Creating frmListAllPayments instance: When user clicks on mnuPaymentsList, 
    ' instance of frmListAllPayments is created and the form is shown.
    '********************************************************************************
    Private Sub mnuPaymentsList_Click(sender As Object, e As EventArgs) Handles mnuPaymentsList.Click
        Dim frmListAllPayments As New frmListAllPayments ' Create instance
        frmListAllPayments.ShowDialog() ' Display form
    End Sub
    '********************************************************************************
    '                       End: Creating frmListAllPayments instance
    '********************************************************************************

    '*********************************************************************************
    ' Creating frmModifyPayments instance: When user clicks on mnuPaymentsModify, 
    ' instance of frmModifyPayments is created and the form is shown.
    '*********************************************************************************
    Private Sub mnuPaymentsModify_Click(sender As Object, e As EventArgs) Handles mnuPaymentsModify.Click
        Dim frmModifyPaymentsForm As New frmModifyPayments ' Create instance
        frmModifyPaymentsForm.ShowDialog() ' Display form
    End Sub
    '*********************************************************************************
    '                    End: Creating frmModifyPayments instance
    '*********************************************************************************

    '***********************************************************************************
    ' Creating frmSingleMemberPayments instance: When user clicks on mnuPaymentsView, 
    ' instance of frmSingleMemberPayments is created and the form is shown.
    '***********************************************************************************
    Private Sub mnuPaymentsView_Click(sender As Object, e As EventArgs) Handles mnuPaymentsView.Click
        Dim frmSingleMemberPayment As New frmSingleMemberPayments ' Create instance
        frmSingleMemberPayment.ShowDialog() ' Display form
    End Sub

    '***********************************************************************************
    '                   End: Creating frmSingleMemberPayments instance
    '***********************************************************************************
End Class
