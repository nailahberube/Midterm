Public Class frmConversion
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare Variables 

        Dim decEnterValue As Decimal
        Dim decMeterstoInches As Decimal
        Dim decInchestoMeters As Decimal
        Dim decConversionEstimate As Decimal

        Dim decMetersinInches As Decimal = 0.0254D
        Dim decInchesinMeters As Decimal = 39.3700787D

        'Determine if the user entered a numeric value 
        If IsNumeric(txtEnterValue.Text) Then
            decEnterValue = Convert.ToDecimal(txtEnterValue.Text)
            'Did user enter a positive number 
            If decEnterValue > 0 Then
                If radInchestoMeters.Checked Then
                    decInchestoMeters = decInchesinMeters

                ElseIf radMeterstoInches.Checked Then
                    decMeterstoInches = decMetersinInches

                End If
                'Calculate and Display Conversion Meters to Inches 
                decConversionEstimate = decEnterValue / decMetersinInches
                lblMeasurementOutput.Text = decConversionEstimate.ToString("C")

                'Calculate and Display Conversion Inches to Meters 
                decConversionEstimate = decEnterValue / decInchesinMeters
                lblMeasurementOutput.Text = decConversionEstimate.ToString("C")
            Else
                'Tell user to enter a positive value
                MsgBox("You entered " & decEnterValue.ToString() & " Please enter a positive value.")
                txtEnterValue.Text = ""
                txtEnterValue.Focus()
            End If
        Else
            'Display error message telling the user to enter a numeric value 
            MsgBox("Please enter a numeric value for conversion.",, "Input Error")
            txtEnterValue.Text = ""
            txtEnterValue.Focus()
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEnterValue.Clear()
        lblMeasurementOutput.Text = ""
        radInchestoMeters.Checked = True
        radMeterstoInches.Checked = False
        txtEnterValue.Focus()
    End Sub

    Private Sub frmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear out the conversion estimate and set focus
        txtEnterValue.Focus()
        lblMeasurementOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
