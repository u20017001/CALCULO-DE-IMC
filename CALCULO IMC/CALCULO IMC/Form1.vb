Public Class Form1
    Dim imc As Double

    Private Sub lblResultado_Click(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub

    Private Sub btnCALCULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCALCULAR.Click
        imc = Val(txtPeso.Text) / (Val(txtAltura.Text) * Val(txtAltura.Text))
        Select Case imc
            Case Is < 18.49
                triesgo.Text = ("MUY POCO PESO")
            Case 18.5 To 24.9
                triesgo.Text = ("PROMEDIO")
            Case 25 To 29.9
                triesgo.Text = ("AUMENTADO")
            Case 30 To 34.9
                triesgo.Text = ("MODERADO")
            Case 35 To 39.9
                triesgo.Text = ("SEVERO")
            Case Else
                triesgo.Text = ("MUY SEVERO")
        End Select

        lblResultado.Text = Format(imc, "##.##")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtAltura.Clear()
        txtPeso.Clear()
        lblResultado.Text = ""
        txtPeso.Focus()
    End Sub

    Private Sub triesgo_Click(sender As Object, e As EventArgs) Handles triesgo.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class