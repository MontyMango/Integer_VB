Public Class Form1

    'Create double variables that are private
    Private dblIntegerInput, dblTotal As Double

    'Converts the imput string into an interger, and clears the input
    Private Sub Stringtoint()
        'Converts the input into an integer
        dblIntegerInput = Convert.ToDouble(txtIntegerInput.Text)

        'If the radiobuttons aren't checked
        If radKeepTotal.Checked = False And radKeepInput.Checked = False Then

            'Clear the textbox
            txtIntegerInput.Text = ""

        End If
    End Sub

    'Keeps the total by converting the total to a string
    Private Sub KeepTheTotal()
        'If the total radio button is checked
        If radKeepTotal.Checked = True Then

            'Convert the double total to a string and put it in the textbox
            txtIntegerInput.Text = Convert.ToString(dblTotal)

        End If
    End Sub

    'When the double button is clicked, the number is checked then doubled.
    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        'If the box has nothing in it, then display a message
        If txtIntegerInput.Text = "" Then
            'Display a message
            MsgBox("Please provide a number in the textbox", vbExclamation)
        Else
            'Goes to the subfuntion to convert the input into an integer
            Stringtoint()

            'Times the input by 2
            dblTotal = dblIntegerInput * 2

            'Displays it's result
            MsgBox("The double of " & dblIntegerInput & " is " & dblTotal)

            'Checks if the box is check to keep the total in the inputbox
            KeepTheTotal()
        End If
    End Sub

    'When the half button is clicked, the input number is halved.
    Private Sub btnHalf_Click(sender As Object, e As EventArgs) Handles btnHalf.Click
        'If the input box has nothing in it, then display a message.
        If txtIntegerInput.Text = "" Then
            MsgBox("Please provide a number in the textbox", vbExclamation)
        Else
            'Goes to the subfuntion to convert the input into an integer
            Stringtoint()

            'Half the integer input
            dblTotal = dblIntegerInput / 2

            'Displays it's results
            MsgBox("Half of " & dblIntegerInput & " is " & dblTotal)

            'Checks if the box is check to keep the total in the inputbox
            KeepTheTotal()
        End If
    End Sub



    '  __                      __
    ' |  |                    |  |
    '_|  |_                  _|  |_
    '\    /                  \    /
    ' \  /                    \  /
    '  \/ EXTRA FEATURES BELOW \/



    'When the exit button is pressed, the application closes.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the main window.
        Me.Close()
    End Sub

    'When the random number button is clicked, the application puts a random number in the input box.
    Private Sub btnRandomNum_Click(sender As Object, e As EventArgs) Handles btnRandomNum.Click
        'Declares the RandomNumber as an Integer
        Dim RandomNumber As Integer

        'Chooses a random number between 0 - 1000
        RandomNumber = Math.Ceiling(Rnd() * 1000)

        'Assigns the textbox as a random number
        txtIntegerInput.Text = RandomNumber
    End Sub

    'If the Triple button is clicked, the input is multiplied by 4
    Private Sub btnTriple_Click(sender As Object, e As EventArgs) Handles btnTriple.Click

        'If the inputbox has nothing in it.
        If txtIntegerInput.Text = "" Then
            'Display a message
            MsgBox("Please provide a number in the textbox", vbExclamation)
        Else
            'Goes to the subfuntion to convert the input into an integer
            Stringtoint()

            'Times the input by 3
            dblTotal = dblIntegerInput * 3

            'Displays it's result
            MsgBox("The triple of " & dblIntegerInput & " is " & dblTotal)

            'Checks if the box is check to keep the total in the inputbox
            KeepTheTotal()
        End If
    End Sub

    'If the Quarter button is clicked, the input is divided by 4
    Private Sub btnQuarter_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        If txtIntegerInput.Text = "" Then
            'Display a message
            MsgBox("Please provide a number in the textbox", vbExclamation)
        Else
            'Goes to the subfuntion to convert the input into an integer
            Stringtoint()

            'Divides the input by 4
            dblTotal = dblIntegerInput / 4

            'Displays it's result
            MsgBox("The quarter of " & dblIntegerInput & " is " & dblTotal)

            'Checks if the box is check to keep the total in the inputbox
            KeepTheTotal()
        End If
    End Sub

    'When the Unselect button is clicked, it clears the radio buttons
    Private Sub btnUnselect_Click(sender As Object, e As EventArgs) Handles btnUnselect.Click
        'Uncircles the radio buttons
        radKeepInput.Checked = False
        radKeepTotal.Checked = False
    End Sub
End Class
