
Public Class frmMenuPrincipal


    Private Sub btnConfiguracao_Click(sender As Object, e As EventArgs)
        Dim frmConfiguracoes As New frmConfiguracoes()
        frmConfiguracoes.Show()
    End Sub

    Private Sub btnCadastrarAlimento_Click(sender As Object, e As EventArgs) Handles btnCadAlimento.Click
        Dim frmCadastroAlimento As New frmCadastroAlimento()
        frmCadastroAlimento.Show()
    End Sub

    Private Sub btnConsultarAlimentos_Click(sender As Object, e As EventArgs) Handles btnConAlimentos.Click
        Dim frmConfiguracoes As New frmConfiguracoes()
        frmConfiguracoes.Show()
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.lblUsuario.Text = $"Seja bem vindo(a) ao sistema {frmTelaLogin.usuario.getNomeUsuario}"

    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        pnlBotoes.Hide()
        btnMostrar.Show()
        btnOcultar.Hide()
        Me.pbxLogoGrande.Location = New Point(295, 120)
        Me.lblNomeApp.Location = New Point(375, 470)

    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        pnlBotoes.Show()
        btnMostrar.Hide()
        btnOcultar.Show()
        Me.pbxLogoGrande.Location = New Point(385, 120)
        Me.lblNomeApp.Location = New Point(462, 470)
    End Sub

    Private Sub btnCadastrarPaciente_Click(sender As Object, e As EventArgs) Handles btnCadPaciente.Click

    End Sub
End Class