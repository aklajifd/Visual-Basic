Public Class PlayerScores
    '*******************************************************************************
    ' Enter player scores: The user enters the scores for each player.
    '*******************************************************************************
    Private Sub PlayerScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Local variable declaration and initialization
        Dim intCount As Integer = 0 ' Loop counter variable
        Dim intScore As Integer ' Variable for player score
        ReDim intPlayerScores(frmMain.cboNames.Items.Count - 1) ' Resize array based on number of players
        ' Loop for entering player scores
        Do While intCount < (intPlayerScores.Length - 1)
            ' Input validation
            If Integer.TryParse(InputBox("Enter the score for " &
                frmMain.cboNames.Items.Item(intCount).ToString()), intScore) Then
                If intScore >= 0 Then
                    intPlayerScores(intCount) = intScore
                    intCount += 1
                Else
                    MessageBox.Show("Score cannot be a negative number. Please re-enter using " &
                                    "a value of zero or greater.")
                End If
            Else
                MessageBox.Show("Score must be a numeric value of zero or greater.")
            End If
        Loop
        frmMain.cboNames.Enabled = True ' Enable ComboBox control on MainForm
        ' Disable mnuOptionsPoints, no editing of players allowed once entered
        frmMain.mnuOptionsPoints.Enabled = False
        Me.Close() ' Close form
    End Sub
    '*******************************************************************************
    '                               End: Enter player scores
    '*******************************************************************************
End Class