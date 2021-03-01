
Public Class frmMenuPrincipal

    Private Sub btnCadastrarAlimento_Click(sender As Object, e As EventArgs) Handles btnCadAlimento.Click
        Dim frmCadastroAlimento As New frmAlimento()
        frmCadastroAlimento.Show()
    End Sub

    Private Sub btnConsultarAlimentos_Click(sender As Object, e As EventArgs)
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

    Private Sub btnCadastrarPaciente_Click(sender As Object, e As EventArgs)
        Dim frmCadPaciente As New frmPaciente()
        frmCadPaciente.Show()
    End Sub

    Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnDeslogar_Click(sender As Object, e As EventArgs) Handles btnDeslogar.Click
        Application.Exit()
    End Sub

    Private Sub BtnPacientes_Click(sender As Object, e As EventArgs) Handles BtnPacientes.Click
        Dim frmPaciente As New frmPaciente()
        frmPaciente.Show()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim frmConfiguracoes As New frmConfiguracoes()
        frmConfiguracoes.Show()
    End Sub

    Private Sub btnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click
        Dim frmAgenda As New frmAgenda()
        frmAgenda.Show()
    End Sub

    Private Sub btnCadCardapio_Click(sender As Object, e As EventArgs) Handles btnCadCardapio.Click
        Dim frmPlanilhaCardapio As New frmPlanilhaCardapio()
        frmPlanilhaCardapio.Show()
    End Sub
End Class