Imports System.Data.SQLite
Public Class frmTelaLogin
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)
    Public usuario As New UsuarioDAO

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If String.IsNullOrEmpty(Me.txtLogin.Text) Then
            MsgBox("O campo de login não deve ficar em branco!")
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.txtSenha.Text) Then
            MsgBox("O campo de senha não deve ficar em branco!")
            Exit Sub
        End If

        If Not usuario.verificarUsuarioLogado() Then
            Me.lblLoginErrado.Visible = True
            Exit Sub
        End If

        Me.lblLoginErrado.Visible = False

        usuario.setUsuario(Me.txtLogin.Text)
        usuario.setUsuarioSenha(Me.txtSenha.Text)
        usuario.setNomeUsuario(Me.txtLogin.Text)

        Dim menu As New frmMenuPrincipal()
        menu.Show()
        Me.Hide()

    End Sub

    Private Sub txtSenha_Enter(sender As Object, e As EventArgs) Handles txtSenha.Enter
        Me.txtSenha.Text = ""
        Me.txtSenha.PasswordChar = "*"
    End Sub

    Private Sub txtLogin_Leave(sender As Object, e As EventArgs) Handles txtLogin.Leave
        Me.txtLogin.Text = LCase(Me.txtLogin.Text)
    End Sub
End Class