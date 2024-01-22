Public Class frmListByJoinDate
    '*******************************************************************************
    ' Exit Form: When user clicks on mnuFileClose, the form closes
    '*******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close() ' Close form
    End Sub
    '*******************************************************************************
    '                               End: Exit Form
    '*******************************************************************************

    '*******************************************************************************
    ' List Before Date: When user clicks on rdoBeforeays, the event handler assigns
    ' one of the two binding sources to the DataSource property of dvgMembers. 
    ' Members who have joined before the selected date are displayed.
    '*******************************************************************************
    Private Sub rdoBefore_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBefore.CheckedChanged
        dvgMembers.DataSource = MembersBindingSource
        Me.MembersTableAdapter.ByDate(Me.KarateMembersSet1.Members, CDate(dtpTimePicker.Value.ToString("d")))
    End Sub
    '*******************************************************************************
    '                              End: List Before Date
    '*******************************************************************************

    '*******************************************************************************
    ' List On or After: When user clicks on rdoOnOrAfter, the event handler assigns
    ' one of the two binding sources to the DataSource property of dvgMembers. 
    ' Members that have joined on or after the selected date are displayed.
    '*******************************************************************************
    Private Sub rdoOnOrAfter_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOnOrAfter.CheckedChanged
        dvgMembers.DataSource = MembersBindingSource1
        Me.MembersTableAdapter1.ByDate2(Me.KarateMembersSet2.Members, CDate(dtpTimePicker.Value.ToString("d")))
    End Sub
    '*******************************************************************************
    '                               End: List On or After
    '*******************************************************************************
End Class