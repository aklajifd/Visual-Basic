Option Strict On
Option Explicit On
Public Class DataForm
    Inherits System.Web.UI.Page
    '**************************************************************************************
    ' Redirect to Default page: When user clicks on btnLogout, the application 
    ' returns to the Default.aspx page.
    '**************************************************************************************
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Response.Redirect("Default.aspx")
    End Sub
    '**************************************************************************************
    '                               End: Redirect to Default page
    '**************************************************************************************
End Class