Imports System.Data.SQLite
Public Class frmTelaLogin
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As New UsuarioDAO

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

        usuario.usuario = Me.txtLogin.Text
        usuario.senha = Me.txtSenha.Text

        Dim menu As New frmMenuPrincipal()
        menu.Show()
        Me.Hide()

    End Sub



    Private Sub txtSenha_Enter(sender As Object, e As EventArgs) Handles txtSenha.Enter
        Me.txtSenha.Text = ""
        Me.txtSenha.PasswordChar = "*"
    End Sub
End Class