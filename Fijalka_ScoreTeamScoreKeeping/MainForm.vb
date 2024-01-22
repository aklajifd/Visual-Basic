'**********************************************************************************************************
' Programmer: Daniel Fijalka
' Date: 9/10/23
' Title: CS2453 Assignment 4 - Soccer Team Score Keeping
' Description: An application where the user can specify how many soccer players they want to
' record points for. Via a menu, the user is able to add the names of soccer players and 
' the points each player has. The main form utilizes a ComboBox where the user can select an
' individual player or the entire team to view the points. A reset option and AboutBox are also
' available in the menu.
' Known Concerns: None
'**********************************************************************************************************
Option Strict On
Option Explicit On
Public Class frmMain
    '*******************************************************************************
    ' Load Form: Upon form loading, set cboNames and mnuOptionsPoints 'Enabled'
    ' property to False. mnuOptionsPoints will become enabled again once user has
    ' entered player names, and cboNames will become enabled again once user has
    ' entered both player names and points.
    '*******************************************************************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNames.Enabled = False
        mnuOptionsPoints.Enabled = False
    End Sub
    '*******************************************************************************
    '                               End:Load Form
    '*******************************************************************************

    '*******************************************************************************
    ' Reset Form: When user clicks on mnuFileReset, all labels and items in
    ' cboNames are cleared, global arrays are resized, mnuOptionsPlayers is Enabled,
    ' and mnuOptionsPoints and cboNames are Disabled.
    '*******************************************************************************
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        ReDim strPlayerNames(0)
        ReDim intPlayerScores(0)
        lblPlayerScore.Text = ""
        lblTeamScore.Text = ""
        cboNames.Items.Clear()
        mnuOptionsPlayers.Enabled = True
        mnuOptionsPoints.Enabled = False
        cboNames.Enabled = False
    End Sub
    '*******************************************************************************
    '                                End: Reset Form
    '*******************************************************************************

    '*******************************************************************************
    ' Exit Form: When user clicks on mnuFileExit, the form closes
    '*******************************************************************************
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close() ' Close form
    End Sub
    '*******************************************************************************
    '                                  End: Exit Form
    '*******************************************************************************

    '*******************************************************************************
    ' Creating frmPlayerNames instance: When user clicks on mnuOptionsPlayers, an
    ' instance of frmPlayerNames is created and the form is shown.
    '*******************************************************************************
    Private Sub mnuOptionsPlayers_Click(sender As Object, e As EventArgs) Handles mnuOptionsPlayers.Click
        Dim frmPlayerNames As New PlayerNames
        frmPlayerNames.ShowDialog()
    End Sub
    '*******************************************************************************
    '                       End: Creating frmPlayerNames instance
    '*******************************************************************************

    '*******************************************************************************
    ' Creating frmPlayerScores instance: When user clicks on mnuOptionsPoints, an
    ' instance of frmPlayerScores is created and the form is shown.
    '*******************************************************************************
    Private Sub mnuOptionsPoints_Click(sender As Object, e As EventArgs) Handles mnuOptionsPoints.Click
        Dim frmPlayerScores As New PlayerScores
        frmPlayerScores.ShowDialog()
    End Sub
    '*******************************************************************************
    '                       End: Creating frmPlayerScores instance
    '*******************************************************************************

    '*******************************************************************************
    ' ComboBox selection: When user clicks on an option from cboNames, the 
    ' selected item is used to retrieve parallel array items.
    '*******************************************************************************
    Private Sub cboStats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNames.SelectedIndexChanged
        ' Local variable declaration and initialization
        Dim intScore As Integer = 0 ' Variable for individual score
        Dim intCboCount As Integer = cboNames.Items.Count ' Variable for total item count in ComboBox
        Dim intTeamTotal As Integer = 0 ' Variable for total team score
        ' Check if user has made selection from ComboBox
        If cboNames.SelectedIndex <> -1 Then
            ' Check if user selected "Total Team Score" option, which is the last option in the array
            If cboNames.SelectedIndex = intCboCount - 1 Then
                For Each currentScore In intPlayerScores ' For Each loop to calculate total score
                    intTeamTotal += currentScore
                Next
                lblPlayerScore.Text = ""
                lblPlayer.Text = "Player Score:"
                lblTeamScore.Text = intTeamTotal.ToString() ' Display total score of team
            Else
                intScore = intPlayerScores(cboNames.SelectedIndex) ' Retrieve parallel array items
                lblPlayer.Text = "Score for " & cboNames.SelectedItem.ToString() ' Display player name
                lblPlayerScore.Text = intScore.ToString() ' Display individual score
                lblTeamScore.Text = ""
            End If
        End If
    End Sub
    '*******************************************************************************
    '                               End: ComboBox selection
    '*******************************************************************************

    '*******************************************************************************
    ' Display About Box: When user clicks on mnuHelpAbout, the About Box is shown
    '*******************************************************************************
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim frmAboutBox As New AboutBox
        frmAboutBox.ShowDialog()
    End Sub
    '*******************************************************************************
    '                             End: Display About Box
    '*******************************************************************************
End Class
