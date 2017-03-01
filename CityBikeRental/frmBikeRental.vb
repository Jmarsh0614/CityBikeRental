'Program: City Bike Rental
'Author : Joshua Marshall
'Date: February 23, 2017
'Purpose: This application calculates and displays 
'the total cost Of renting multiple bikes For a 24-hour period.


Option Strict On


Public Class frmBikeRental

    'Cost per bike rental - used in mulitple procedures
    Const _cdecPricePerBike As Decimal = 9.95D


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This event handler is executed when the user taps or clicks the
        'Calculate button. It calculates and displays the cost
        'of the bikes rented (number of bikes times the cost per bike).
        Dim strNumberOfBikes As String
        Dim intNumberOfBikes As Integer
        Dim decTotalCost As Decimal

        strNumberOfBikes = txtNumberOfBikes.Text
        intNumberOfBikes = Convert.ToInt32(strNumberOfBikes)
        decTotalCost = intNumberOfBikes * _cdecPricePerBike
        lblTotalCost.Text = decTotalCost.ToString("C") '("C") for currency will show $X.XX




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user taps or clicks the 
        'Clear button. It clears the numer of bikes text box
        'and the Text property of the Total Cost label.
        'Then it sents the focus to the txtNumberOfBikes Textbox object. 
        txtNumberOfBikes.Clear()
        lblTotalCost.Text = ""
        txtNumberOfBikes.Focus()


    End Sub

    Private Sub frmBikeRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded.
        'It displays the cost heading, clears the Text property of the 
        'Total Cost label and sets the focus on
        'the txtNumberOfBikes Textbox object.

        lblCostHeading.Text = _cdecPricePerBike.ToString("C") & " Per Bike for 24 Hours"
        lblTotalCost.Text = ""
        txtNumberOfBikes.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler is triggered when the user taps or clicks the Exit button. 
        'It closes the window and terminates the application.

        Close()

    End Sub
End Class
