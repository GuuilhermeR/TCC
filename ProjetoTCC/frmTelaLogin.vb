Public Class frmTelaLogin
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'fINIConexao()

        Me.txtSenha.TextBoxValue.PasswordChar = "*"


    End Sub

    Private Sub txtRecuperarSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtRecuperarSenha.LinkClicked

    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click

#If DEBUG Then
        Me.Hide()
        frmMenuPrincipal.Show()
#Else
        If IsNullOrEmpty(Me.txtSenha.Text) AndAlso IsNullOrEmpty(Me.txtUsuario.Text) Then
            MsgBox("Favor preencher os campos")
            Exit Sub
        End If

        Dim strSQL As String = $"SELECT * FROM Login WHERE usuario = '{Me.txtUsuario.Text}' AND senha = '{Me.txtSenha.Text}'"

        Dim dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)

        If dr.Read Then
            If Me.txtUsuario.Text = dr("usuario") AndAlso Me.txtSenha.Text = dr("senha") Then
                Me.Hide()
                frmMenuPrincipal.Show()
            Else
                MsgBox("Senha Errada")
            End If
        End If
#End If



    End Sub
End Class
