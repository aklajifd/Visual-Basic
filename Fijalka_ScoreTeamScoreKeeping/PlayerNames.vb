Public Class PlayerNames
    '*******************************************************************************
    ' Enter number of players: When user enters a number of soccer players in
    ' txtPlayerNumber, the user is then prompted to enter the names of the players.
    '*******************************************************************************
    Private Sub txtPlayerNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerNumber.TextChanged
        ' Local variable declaration and initialization
        Dim intPlayerNumber As Integer ' Variable for number of players
        Dim intCount As Integer = 0 ' Loop counter variable
        ' Validation for user input
        Try
            intPlayerNumber = CInt(txtPlayerNumber.Text)
            ' Must be 0 or more players
            If intPlayerNumber > 0 Then
                ReDim strPlayerNames(intPlayerNumber - 1) ' Resize array based on number of players
                ' Loop for entering player names
                Do While intCount < (strPlayerNames.Length)
                    strPlayerNames(intCount) = InputBox("Enter the name for Player " & (intCount + 1).ToString())
                    ' Ensure player name is not empty string or spaces
                    If strPlayerNames(intCount) <> String.Empty Then
                        frmMain.cboNames.Items.Add(strPlayerNames(intCount))
                        intCount += 1
                    Else
                        MessageBox.Show("The player name cannot be an empty string.")
                    End If
                Loop
                ' Add player name to ComboBox in MainForm
                frmMain.cboNames.Items.Add("Total Team Score")
                ' Disable mnuOptionsPlayers, no editing of players allowed once entered
                frmMain.mnuOptionsPlayers.Enabled = False
                frmMain.mnuOptionsPoints.Enabled = True ' Enable user to enter points
                Me.Close() ' Close form
            Else
                MessageBox.Show("Please enter a value greater than zero for the number of players.")
            End If
        Catch
            MessageBox.Show("Please enter a numeric value for the number of players.")
        End Try
    End Sub
    '*******************************************************************************
    '                           End: Enter number of players
    '*******************************************************************************
End Class