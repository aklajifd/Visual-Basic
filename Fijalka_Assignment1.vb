' Author: Daniel Fijalka
' Date Last Modified: 8/20/23
' CS2453: Visual Basic, Assignment 1 - Theater Revenue

Public Class frmMain

    ' Class-Level constant
    Const sngPERCENTAGE As Single = 0.2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display current date in Long Date format in label
        lblCurrentDate.Text = Today.ToString("D")

    End Sub

    Private Sub btnCalTicketRevenue_Click(sender As Object, e As EventArgs) Handles btnCalTicketRevenue.Click

        ' Variable declaration
        Dim decAdultTicketPrice, decChildTicketPrice, decGrossAdultTotal, decGrossChildTotal, decTotalGross As Decimal
        Dim intAdultTicketsSold, intChildTicketsSold As Integer

        ' Start exception handlers with nested Try-Catch blocks to intercept unwanted input
        Try
            ' Convert input from adult ticket price entry to decimal
            decAdultTicketPrice = CDec(txtAdultTicketPrice.Text)

            ' Display ticket price TextBox with currency
            txtAdultTicketPrice.Text = decAdultTicketPrice.ToString("c")

            Try
                ' Convert input from adult tickets sold to integer
                intAdultTicketsSold = CInt(txtAdultTicketsSold.Text)

                Try
                    ' Convert input from child tricket price entry to decimal
                    decChildTicketPrice = CDec(txtChildTicketPrice.Text)

                    ' Display ticket price TextBox with currency
                    txtChildTicketPrice.Text = decChildTicketPrice.ToString("c")

                    Try
                        ' Convert input from child tickets sold to integer
                        intChildTicketsSold = CInt(txtChildTicketsSold.Text)

                        ' Calculate gross total for adult tickets
                        decGrossAdultTotal = decAdultTicketPrice * intAdultTicketsSold

                        ' Calculate gross total for child tickets
                        decGrossChildTotal = decChildTicketPrice * intChildTicketsSold

                        ' Calculate gross total for both adult and child tickets
                        decTotalGross = decGrossAdultTotal + decGrossChildTotal

                        ' Calculate net total for adult tickets
                        Dim sngNetAdultTotal As Single
                        sngNetAdultTotal = CSng(decGrossAdultTotal) * sngPERCENTAGE

                        ' Calculate net total for child tickets
                        Dim sngNetChildTotal As Single
                        sngNetChildTotal = CSng(decGrossChildTotal) * sngPERCENTAGE

                        ' Calculate net total for both adult and child tickets
                        Dim sngTotalNet As Single
                        sngTotalNet = sngNetAdultTotal + sngNetChildTotal

                        ' Display all gross and net results as currency
                        lblGrossAdultResult.Text = decGrossAdultTotal.ToString("c")
                        lblGrossChildResult.Text = decGrossChildTotal.ToString("c")
                        lblGrossTotalResult.Text = decTotalGross.ToString("c")
                        lblNetAdultResult.Text = sngNetAdultTotal.ToString("c")
                        lblNetChildResult.Text = sngNetChildTotal.ToString("c")
                        lblNetTotalResult.Text = sngTotalNet.ToString("c")

                        ' Display total amount of tickets sold with concatenation
                        lblTotalTicketsSold.Text = "Total Tickets Sold Today: " & (intAdultTicketsSold + intChildTicketsSold)

                    Catch
                        'Error message for invalid entries for child tickets sold
                        MessageBox.Show("Tickets sold must be an integer.")
                    End Try

                Catch
                    'Error message for invalid entries for child ticket price
                    MessageBox.Show("Price must be a numeric value.")
                End Try

            Catch
                'Error message for invalid entries for adult tickets sold
                MessageBox.Show("Tickets sold must be an integer.")
            End Try

        Catch
            'Error message for invalid entries for adult ticket price
            MessageBox.Show("Price must be a numeric value.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application by clicking on exit button
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clearing TextBoxes with Clear() method
        txtAdultTicketPrice.Clear()
        txtAdultTicketsSold.Clear()
        txtChildTicketPrice.Clear()
        txtChildTicketsSold.Clear()

        ' Clearing labels on form with String.Empty method
        lblGrossAdultResult.Text = String.Empty
        lblGrossChildResult.Text = String.Empty
        lblGrossTotalResult.Text = String.Empty
        lblNetAdultResult.Text = String.Empty
        lblNetChildResult.Text = String.Empty
        lblNetTotalResult.Text = String.Empty

        ' Return focus to first TextBox after clearing
        txtAdultTicketPrice.Focus()
    End Sub

    Private Sub txtAdultTicketPrice_GotFocus(sender As Object, e As EventArgs) Handles txtAdultTicketPrice.GotFocus
        ' Add GotFocus event for TextBox
        txtAdultTicketPrice.BackColor = Color.Yellow
    End Sub
    Private Sub txtAdultTicketPrice_LostFocus(sender As Object, e As EventArgs) Handles txtAdultTicketPrice.LostFocus
        ' Add LostFocus event for TextBox
        txtAdultTicketPrice.BackColor = Color.White
    End Sub

    Private Sub txtAdultTicketsSold_GotFocus(sender As Object, e As EventArgs) Handles txtAdultTicketsSold.GotFocus
        ' Add GotFocus event for TextBox
        txtAdultTicketsSold.BackColor = Color.Yellow
    End Sub
    Private Sub txtAdultTicketsSold_LostFocus(sender As Object, e As EventArgs) Handles txtAdultTicketsSold.LostFocus
        ' Add LostFocus event for TextBox
        txtAdultTicketsSold.BackColor = Color.White
    End Sub

    Private Sub txtChildTicketPrice_GotFocus(sender As Object, e As EventArgs) Handles txtChildTicketPrice.GotFocus
        ' Add GotFocus event for TextBox
        txtChildTicketPrice.BackColor = Color.Yellow
    End Sub
    Private Sub txtChildTicketPrice_LostFocus(sender As Object, e As EventArgs) Handles txtChildTicketPrice.LostFocus
        ' Add LostFocus event for TextBox
        txtChildTicketPrice.BackColor = Color.White
    End Sub

    Private Sub txtChildTicketsSold_GotFocus(sender As Object, e As EventArgs) Handles txtChildTicketsSold.GotFocus
        ' Add GotFocus event for TextBox
        txtChildTicketsSold.BackColor = Color.Yellow
    End Sub
    Private Sub txtChildTicketsSold_LostFocus(sender As Object, e As EventArgs) Handles txtChildTicketsSold.LostFocus
        ' Add LostFocus event for TextBox
        txtChildTicketsSold.BackColor = Color.White
    End Sub
End Class
