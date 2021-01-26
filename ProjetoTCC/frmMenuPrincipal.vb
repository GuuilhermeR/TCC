Public Class frmMenuPrincipal


    Private Sub btnConfiguracao_Click(sender As Object, e As EventArgs)
        Using frmConfiguracoes As New frmConfiguracoes()
            frmConfiguracoes.Show()
        End Using
    End Sub

    Private Sub btnCadastrarAlimento_Click(sender As Object, e As EventArgs) Handles btnCadastrarAlimento.Click
        Using frmCadastroAlimento As New frmCadastroAlimento()
            frmCadastroAlimento.Show()
        End Using
    End Sub

    Private Sub btnConsultarAlimentos_Click(sender As Object, e As EventArgs) Handles btnConsultarAlimentos.Click
        Using frmConfiguracoes As New frmConfiguracoes()
            frmConfiguracoes.Show()
        End Using
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        pnlBotoes.Hide()
        btnMostrar.Show()
        btnOcultar.Hide()
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        pnlBotoes.Show()
        btnMostrar.Hide()
        btnOcultar.Show()
    End Sub
End Class