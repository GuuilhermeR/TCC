Public Class UsuarioDAO

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

End Class
