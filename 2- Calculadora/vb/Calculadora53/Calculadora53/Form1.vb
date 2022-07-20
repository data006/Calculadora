Public Class Calculadora

    Dim primerNumero As Double = 0
    Dim segundoNumero As Double = 0
    Dim punto As Boolean = False
    Dim repeticion As Boolean = False

    Dim estado As Integer = 0

    Dim operacionRealizar As String = " "





    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "0"

        Else

            txtDisplay.Text = "0"
            estado = 0

        End If

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "1"

        Else

            txtDisplay.Text = "1"
            estado = 0

        End If

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "2"

        Else

            txtDisplay.Text = "2"
            estado = 0

        End If

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "3"

        Else

            txtDisplay.Text = "3"
            estado = 0

        End If

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "4"

        Else

            txtDisplay.Text = "4"
            estado = 0

        End If

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "5"

        Else

            txtDisplay.Text = "5"
            estado = 0

        End If

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "6"

        Else

            txtDisplay.Text = "6"
            estado = 0

        End If

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "7"

        Else

            txtDisplay.Text = "7"
            estado = 0

        End If

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "8"

        Else

            txtDisplay.Text = "8"
            estado = 0

        End If

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        repeticion = False
        If estado = 0 Then

            txtDisplay.Text = txtDisplay.Text + "9"

        Else

            txtDisplay.Text = "9"
            estado = 0

        End If

    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click

        If estado = 0 Then
            If punto = False Then
                txtDisplay.Text = txtDisplay.Text + "."
                punto = True
                repeticion = False
            ElseIf punto = True Then
                punto = True
            End If
        Else

            If punto = False Then
                txtDisplay.Text = "."
                estado = 0
                punto = True
                repeticion = False
            ElseIf punto = True Then
                punto = True
            End If




        End If

    End Sub







    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click

        If repeticion = False Then



            If operacionRealizar = " " Then

                primerNumero = Val(txtDisplay.Text)
                txtDisplay.Text = " "
                operacionRealizar = "Suma"
                punto = False


            ElseIf operacionRealizar = "Suma" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero + segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Suma"
                punto = False



            ElseIf operacionRealizar = "Resta" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero - segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Suma"
                punto = False


            ElseIf operacionRealizar = "Multiplicacion" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero * segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Suma"
                punto = False


            ElseIf operacionRealizar = "Division" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero / segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Suma"
                punto = False

            ElseIf operacionRealizar = "Pow" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero ^ segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Suma"
                punto = False

            End If

            repeticion = True

        End If

    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click

        If repeticion = False Then

            If operacionRealizar = " " Then

            primerNumero = Val(txtDisplay.Text)
            txtDisplay.Text = " "
            operacionRealizar = "Resta"
            punto = False


        ElseIf operacionRealizar = "Suma" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero + segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Resta"
            punto = False



        ElseIf operacionRealizar = "Resta" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero - segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Resta"
            punto = False


        ElseIf operacionRealizar = "Multiplicacion" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero * segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Resta"
            punto = False


        ElseIf operacionRealizar = "Division" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero / segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Resta"
            punto = False


        ElseIf operacionRealizar = "Pow" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero ^ segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Resta"
            punto = False

        End If

            repeticion = True

        End If



    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click

        If repeticion = False Then

            If operacionRealizar = " " Then

            primerNumero = Val(txtDisplay.Text)
            txtDisplay.Text = " "
            operacionRealizar = "Multiplicacion"
            punto = False


        ElseIf operacionRealizar = "Suma" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero + segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Multiplicacion"
            punto = False



        ElseIf operacionRealizar = "Resta" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero - segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Multiplicacion"
            punto = False


        ElseIf operacionRealizar = "Multiplicacion" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero * segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Multiplicacion"
            punto = False


        ElseIf operacionRealizar = "Division" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero / segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Multiplicacion"
            punto = False

        ElseIf operacionRealizar = "Pow" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero ^ segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Multiplicacion"
            punto = False

        End If


            repeticion = True

        End If

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        If repeticion = False Then

            If operacionRealizar = " " Then

            primerNumero = Val(txtDisplay.Text)
            txtDisplay.Text = " "
            operacionRealizar = "Division"
            punto = False


        ElseIf operacionRealizar = "Suma" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero + segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Division"
            punto = False



        ElseIf operacionRealizar = "Resta" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero - segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Division"
            punto = False


        ElseIf operacionRealizar = "Multiplicacion" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero * segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Division"
            punto = False


        ElseIf operacionRealizar = "Division" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero / segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Division"
            punto = False


        ElseIf operacionRealizar = "Pow" Then

            segundoNumero = Val(txtDisplay.Text)

            primerNumero = primerNumero ^ segundoNumero

            txtDisplay.Text = primerNumero
            estado = 1
            operacionRealizar = "Division"
            punto = False

        End If

            repeticion = True

        End If

    End Sub


    Private Sub btnPow_Click(sender As Object, e As EventArgs) Handles btnPow.Click

        If repeticion = False Then

            If operacionRealizar = " " Then

                primerNumero = Val(txtDisplay.Text)
                txtDisplay.Text = " "
                operacionRealizar = "Pow"
                punto = False


            ElseIf operacionRealizar = "Suma" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero + segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Pow"
                punto = False



            ElseIf operacionRealizar = "Resta" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero - segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Pow"
                punto = False


            ElseIf operacionRealizar = "Multiplicacion" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero * segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Pow"
                punto = False


            ElseIf operacionRealizar = "Division" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero / segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Pow"
                punto = False


            ElseIf operacionRealizar = "Pow" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero ^ segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = "Pow"
                punto = False

            End If

            repeticion = True

        End If
    End Sub





    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click

        If txtDisplay.Text IsNot "" Then

            If operacionRealizar = " " Then

                primerNumero = Val(txtDisplay.Text)
                txtDisplay.Text = primerNumero
                operacionRealizar = " "
                punto = False

            ElseIf operacionRealizar = "Suma" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero + segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = " "
                punto = False



            ElseIf operacionRealizar = "Resta" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero - segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = " "
                punto = False


            ElseIf operacionRealizar = "Multiplicacion" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero * segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = " "
                punto = False


            ElseIf operacionRealizar = "Division" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero / segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = " "
                punto = False

            ElseIf operacionRealizar = "Pow" Then

                segundoNumero = Val(txtDisplay.Text)

                primerNumero = primerNumero ^ segundoNumero

                txtDisplay.Text = primerNumero
                estado = 1
                operacionRealizar = " "
                punto = False

            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtDisplay.Text = " "
        operacionRealizar = " "
        punto = False
        estado = 0
        primerNumero = 0
        segundoNumero = 0

    End Sub

    Private Sub btnNeg_Click(sender As Object, e As EventArgs) Handles btnNeg.Click
        If txtDisplay.Text IsNot "" Then
            txtDisplay.Text = txtDisplay.Text * (-1)
        End If

    End Sub
End Class
