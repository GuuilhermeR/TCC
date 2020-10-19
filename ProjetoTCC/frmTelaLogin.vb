Public Class frmTelaLogin
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fINIConexao()

        Me.txtSenha.TextBoxValue.PasswordChar = "*"

    End Sub

    Private Sub txtRecuperarSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtRecuperarSenha.LinkClicked

    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click

        If Me.txtUsuario.Text = "" AndAlso Me.txtSenha.Text = "" Then
            Me.Hide()
            frmMenuPrincipal.Show()

        ElseIf IsNullOrEmpty(Me.txtSenha.Text) AndAlso IsNullOrEmpty(Me.txtUsuario.Text) Then
            MsgBox("Favor preencher os campos")
        Else
            MsgBox("Senha Errada")
        End If
    End Sub
End Class
