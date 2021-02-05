Imports System.Data.SQLite
Public Class UsuarioDAO

    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Public usuario As String
    Public senha As String

    Public Sub getUsuario(usuarioLogado As String)
        Me.usuario = usuarioLogado
    End Sub

    Public Sub setUsuario(usuario As String)
        usuario = Me.usuario
    End Sub

    Public Sub getUsuarioSenha(senhaAtual As String)
        Me.senha = senhaAtual
    End Sub

    Public Sub setUsuarioSenha(senhaAtual As String)
        senhaAtual = Me.senha
    End Sub

    Public Function verificarUsuarioLogado()

        Dim strSQL As String = String.Empty
        Dim usuarioOK As Boolean = False

        strSQL = $"SELECT count(1) AS existe FROM Login WHERE usuario = '{frmTelaLogin.txtLogin.Text}' AND senha = '{frmTelaLogin.txtSenha.Text}'"

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        If dr.Read Then
            usuarioOK = dr("existe") > 0
        End If
        objConexao.Close()

        Return usuarioOK
    End Function

End Class
