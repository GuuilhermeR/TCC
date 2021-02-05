Imports System.Data.SQLite
Public Class frmTelaLogin
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrEmpty(Me.txtLogin.Text) Then
            MsgBox("O campo de login não deve ficar em branco!")
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.txtSenha.Text) Then
            MsgBox("O campo de senha não deve ficar em branco!")
            Exit Sub
        End If

        If Not verificarUsuarioLogado() Then
            Me.lblLoginErrado.Visible = True
            Exit Sub
        End If

        Me.lblLoginErrado.Visible = False

        Dim usuario As New UsuarioDAO
        usuario.usuario = Me.txtLogin.Text
        usuario.senha = Me.txtSenha.Text

        Dim menu As New frmMenuPrincipal()
        menu.Show()
        Me.Hide()

    End Sub

    Private Function verificarUsuarioLogado()

        Dim strSQL As String = String.Empty
        Dim usuarioOK As Boolean = False

        strSQL = $"SELECT count(1) AS existe FROM Login WHERE usuario = '{Me.txtLogin.Text}' AND senha = '{Me.txtSenha.Text}'"

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        If dr.Read Then
            usuarioOK = dr("existe") > 0
        End If
        objConexao.Close()

        Return usuarioOK
    End Function

    Private Sub txtSenha_Enter(sender As Object, e As EventArgs) Handles txtSenha.Enter
        Me.txtSenha.Text = ""
        Me.txtSenha.PasswordChar = "*"
    End Sub
End Class