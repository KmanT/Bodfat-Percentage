'Kyle Turske
'Military Body Fat Calculator
'10/3/2016
Public Class BodyFat

    Const AGE_MIN As Integer = 17
    Const MEASURE_MIN As Double = 1
    Const AGE_MAX As Integer = 68
    Const HEIGHT_MAX As Double = 85
    Const NECK_MAX As Double = 25
    Const WAIST_MAX As Double = 60
    Const HIP_MAX As Double = 54

    Private Function IsPresent(textBox As TextBox, name As String) As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(name & " is a required field.", "Entry Error")
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    'You may also need to add other type check functions – such as IsDouble, IsInteger, etc.
    Private Function IsDouble(textBox As TextBox, name As String) As Boolean
        Dim number As Double = 0
        If Double.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be a decimal value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Private Function IsInt(textBox As TextBox, name As String) As Boolean
        Dim number As Integer = 0
        If Integer.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be a integer value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Private Function IsWithinRange(textBox As TextBox, name As String, min As Double,
      max As Double) As Boolean
        Dim number As Double = CDec(textBox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(name & " must be between " & min & " and " & max & ".", "Entry Error")
            textBox.Select(0, textBox.Text.Length)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function IsValid(textBox As TextBox, name As String, min As Integer, max As Integer) As Boolean
        If IsPresent(textBox, name) = False Then
            Return False
        ElseIf IsInt(textBox, name) = False Then
            Return False
        ElseIf IsWithinRange(textBox, name, min, max) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function IsValid(textBox As TextBox, name As String, min As Double, max As Double) As Boolean
        If IsPresent(textBox, name) = False Then
            Return False
        ElseIf IsDouble(textBox, name) = False Then
            Return False
        ElseIf IsWithinRange(textBox, name, min, max) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CalcBodyFat(height As Double, neck As Double, waist As Double) As Double 'Male Function
        Dim answer As Double
        answer = 86.01 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76
        Return answer
    End Function

    Private Function CalcBodyFat(height As Double, neck As Double, waist As Double, hip As Double) As Double 'Female Function
        Dim answer As Double
        answer = 163.205 * Math.Log10(waist + hip - neck) - 97.684 * Math.Log10(height) - 78.387
        Return answer
    End Function

    Private Function IsEligible(gender As Boolean, age As Integer, bFat As Double) As Boolean
        'True = Male False = Female
        Dim check As Boolean

        If gender = True Then 'Male
            Select Case age
                Case 17 To 20
                    If bFat > 20 Then
                        check = False
                    Else
                        check = True
                    End If
                Case 21 To 27
                    If bFat > 22 Then
                        check = False
                    Else
                        check = True
                    End If
                Case 28 To 39
                    If bFat > 24 Then
                        check = False
                    Else
                        check = True
                    End If
                Case > 40
                    If bFat > 26 Then
                        check = False
                    Else
                        check = True
                    End If
            End Select
        ElseIf gender = False Then 'Female
            Select Case age
                Case 17 To 20
                    If bFat > 28 Then
                        check = False
                    Else
                        check = True
                    End If
                Case 21 To 27
                    If bFat > 30 Then
                        check = False
                    Else
                        check = True
                    End If
                Case 28 To 39
                    If bFat > 32 Then
                        check = False
                    Else
                        check = True
                    End If
                Case > 40
                    If bFat > 34 Then
                        check = False
                    Else
                        check = True
                    End If
            End Select
        End If
        Return check
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim Age As Integer
        Dim BodyFat As Double
        Dim IsMale As Boolean

        If rdbMale.Checked Then
            IsMale = True
            If IsValid(txtAge, txtAge.Name, AGE_MIN, AGE_MAX) = False Then
                txtAge.Focus()
            ElseIf IsValid(txtHeight, txtHeight.Name, MEASURE_MIN, HEIGHT_MAX) = False Then
                txtHeight.Focus()
            ElseIf IsValid(txtNeck, txtNeck.Name, MEASURE_MIN, NECK_MAX) = False Then
                txtNeck.Focus()
            ElseIf IsValid(txtWaist, txtWaist.Name, MEASURE_MIN, WAIST_MAX) = False Then
                txtWaist.Focus()
            Else
                Age = CInt(txtAge.Text)
                'Calls Female Function
                BodyFat = CalcBodyFat(CDbl(txtHeight.Text), CDbl(txtNeck.Text), CDbl(txtWaist.Text))

                If IsEligible(IsMale, Age, BodyFat) = True Then
                    lblEligible.Text = "You are eligible."
                Else
                    lblEligible.Text = "You are ineligible."
                End If

                lblEligible.Visible = True
                BodyFat = Math.Round(BodyFat, 2)
                txtBodyFat.Text = CStr(BodyFat) & "%"

            End If 'End Male Logic

        ElseIf rdbFemale.Checked Then
            IsMale = False
            If IsValid(txtAge, txtAge.Name, AGE_MIN, AGE_MAX) = False Then
                txtAge.Focus()
            ElseIf IsValid(txtHeight, txtHeight.Name, MEASURE_MIN, HEIGHT_MAX) = False Then
                txtHeight.Focus()
            ElseIf IsValid(txtNeck, txtNeck.Name, MEASURE_MIN, NECK_MAX) = False Then
                txtNeck.Focus()
            ElseIf IsValid(txtWaist, txtWaist.Name, MEASURE_MIN, WAIST_MAX) = False Then
                txtWaist.Focus()
            ElseIf IsValid(txtHips, txtHips.Name, MEASURE_MIN, HIP_MAX) = False Then
                txtHips.Focus()

            Else
                Age = CInt(txtAge.Text)
                'Calls Female Function
                BodyFat = CalcBodyFat(CDbl(txtHeight.Text), CDbl(txtNeck.Text), CDbl(txtWaist.Text), CDbl(txtHips.Text))

                If IsEligible(IsMale, Age, BodyFat) = True Then
                    lblEligible.Text = "You are eligible."
                Else
                    lblEligible.Text = "You are ineligible."
                End If

                lblEligible.Visible = True
                BodyFat = Math.Round(BodyFat, 2)
                txtBodyFat.Text = CStr(BodyFat) & " %"

            End If 'End Female Logic
        Else
            MessageBox.Show("You must enter a gender.", "Entry Error")
            rdbMale.Focus()
        End If
    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        lblHips.Visible = True
        txtHips.Visible = True

    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        lblHips.Visible = False
        txtHips.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdbMale.Checked = False
        rdbFemale.Checked = False
        txtAge.Text = ""
        txtBodyFat.Text = ""
        txtHeight.Text = ""
        txtHips.Text = ""
        txtNeck.Text = ""
        txtWaist.Text = ""
        lblEligible.Visible = False
    End Sub
End Class
