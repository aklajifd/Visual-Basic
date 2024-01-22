'**********************************************************************************************************
' Programmer: Daniel Fijalka
' Date: 9/24/23
' Title: CS2453 Assignment 6 - Sales Staff
' Description: The ASP.Net application utilizes the Company.mdf database file to display one
' record at a time with the DetailsView control. The user may update a record. To access the 
' update page, the user must enter a valid email address and zip code. Validations are in 
' place to ensure the user enters appropriate login values.
' Known Concerns: None
'**********************************************************************************************************
Option Strict On
Option Explicit On
Public Class _Default
    Inherits System.Web.UI.Page
    '**************************************************************************************
    ' Redirect to Dataform page: When user clicks on btnLogin, the application 
    ' loads and displays the DataForm.aspx page.
    '**************************************************************************************
    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Response.Redirect("Dataform.aspx")
    End Sub
    '**************************************************************************************
    '                           End: Redirect to Dataform page
    '**************************************************************************************
End Class