Imports System.Data.SQLite
Public Class UsuarioDAO

    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Private usuario As String
    Private senha As String
    Private nome As String

    Public Sub setNomeUsuario(usuarioLogin As String)
        If Not usuarioLogin Is Nothing Then
            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim strSQL As String = $"SELECT Nome FROM Login WHERE usuario = '{usuarioLogin}'" & Chr(13) & Chr(10)

            Using cmd As New SQLiteCommand(strSQL, objConexao)
                Using dr As SQLiteDataReader = cmd.ExecuteReader
                    While dr.Read
                        Me.nome = dr("Nome")
                    End While

                End Using
            End Using

            objConexao.Close()
        End If
    End Sub

    Public Function getNomeUsuario()
        Return Me.nome
    End Function

    Public Function getUsuario()
        Return Me.usuario
    End Function

    Public Sub setUsuario(usuarioLogado As String)
        Me.usuario = usuarioLogado
    End Sub

    Public Function getUsuarioSenha()
        Return Me.senha
    End Function

    Public Sub setUsuarioSenha(senhaatual As String)
        Me.senha = senhaatual
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
