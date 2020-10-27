Public Class frmMenuPrincipal

    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCadastroNutricional.Click

        frmCadastroNutricional.Show()

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Using frmConsultaMedidasCaseiras As New frmConsultaMedidasCaseiras
            frmConsultaMedidasCaseiras.ShowDialog()
        End Using
    End Sub

    Private Sub btnConfiguracao_Click(sender As Object, e As EventArgs) Handles btnConfiguracao.Click
        Using frmConfiguracoes As New frmConfiguracoes
            frmConfiguracoes.ShowDialog()
        End Using
    End Sub
End Class