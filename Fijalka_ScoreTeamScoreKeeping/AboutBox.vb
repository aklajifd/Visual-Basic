Public NotInheritable Class AboutBox
    '*******************************************************************************
    ' Load AboutBox Form: Default settings from AboutBox template upon form loading.
    '*******************************************************************************
    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
    End Sub
    '*******************************************************************************
    '                              End: Load AboutBox Form
    '*******************************************************************************

    '*******************************************************************************
    ' Close AboutBox Form: Close AboutBox when user selects OK button.
    '*******************************************************************************
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close() ' Close form
    End Sub

    '*******************************************************************************
    '                              End: Close AboutBox Form
    '*******************************************************************************
End Class
