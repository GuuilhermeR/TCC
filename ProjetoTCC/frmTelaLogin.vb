Public Class frmTelaLogin
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fINIConexao()

        Me.txtSenha.TextBoxValue.PasswordChar = "*"


    End Sub

    Private Sub txtRecuperarSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtRecuperarSenha.LinkClicked

    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click

        Dim strSQL As String = $"SELECT * FROM Login WHERE usuario = {Me.txtUsuario.Text} AND senha = {Me.txtSenha.Text}"

        Dim dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)

        If dr.Read Then
            Me.Hide()
            frmMenuPrincipal.Show()
        ElseIf IsNullOrEmpty(Me.txtSenha.Text) AndAlso IsNullOrEmpty(Me.txtUsuario.Text) Then
            MsgBox("Favor preencher os campos")
        Else
            MsgBox("Senha Errada")
        End If

    End Sub
End Class


'Dim myConnString1 As String = "DataSource=C:\BancoDadosTCC.db;"
'Dim sqConnection1 As New SQLiteConnection(myConnString1)
'Dim myInsertQuery As String = "SELECT * FROM Login"
'Dim sqCommand As New SQLiteCommand(myInsertQuery)
'sqCommand.Connection = sqConnection1
'sqConnection1.Open()
'Try
'    sqCommand.ExecuteNonQuery()
'Finally
'    sqConnection1.Close()
'End Try
