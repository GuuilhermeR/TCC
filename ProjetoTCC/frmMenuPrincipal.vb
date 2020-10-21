Public Class frmMenuPrincipal

    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCalculos.Click

        frmCadastroNutricional.Show()

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Using frmConsultaMedidasCaseiras As New frmConsultaMedidasCaseiras
            frmConsultaMedidasCaseiras.ShowDialog()
        End Using

    End Sub
End Class