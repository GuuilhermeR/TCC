Imports System.Data.SQLite
Public Class AlimentoDAO

    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Private Function retornaUltimoCodAlimento() As Integer

        objConexao.Open()

        Dim strSQL As String = String.Empty

        Dim codAlimento As Integer

        strSQL = $"SELECT MAX(codigo) As Codigo FROM Alimento"

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        If dr.Read Then
            codAlimento = dr("Codigo")
        End If
        objConexao.Close()

        Return codAlimento

    End Function

    Public Sub Salvar(codAlimento As Integer, alimento As String, qtd As Integer, medidaCaseira As String, kCal As String, proteina As Double, carboidrato As Double, lipidio As Integer, calcio As Integer, ferro As Integer)

        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            If codAlimento <> "" Then
                strSQL = $"UPDATE Paciente SET nome= '{alimento}', qtd = {qtd}, medidaCaseira = '{medidaCaseira}', 
                            kCal = '{kCal}', proteina = {proteina}, carboidrato = {carboidrato}, lipidio ={qtd}, calcio = {calcio}, ferro = {ferro} WHERE codigo = {codAlimento}"
            Else
                strSQL = $"INSERT INTO Paciente (nome, cpf, medidaCaseira, kCal, proteina, carboidrato, lipidio, calcio, ferro) 
                            values ('{alimento}', {qtd}, '{medidaCaseira}', '{kCal}', {proteina}, {carboidrato}, {qtd}, {calcio}, {ferro})"
            End If

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.ExecuteNonQuery()

            MsgBox("O Alimento foi salvo.", vbInformation, "Atenção!")

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar o Alimento." & Chr(10) & ex.Message, vbOKOnly, "Alerta")
        End Try

        objConexao.Close()

    End Sub

    Public Sub Deletar(codAlimento As Integer)

        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            strSQL = $"DELETE FROM Alimento WHERE codAlimento = {codAlimento}"

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.ExecuteNonQuery()
            MsgBox("O Alimento foi excluído!", vbInformation, "Atenção!")

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao excluir o Alimento." & Chr(10) & ex.Message, vbOKOnly, "Alerta")
        End Try

        objConexao.Close()

    End Sub

    Public Sub Buscar(dtgDados As DataGridView, nomeAlimento As String)

        Dim strSQL As String = String.Empty

        strSQL = "SELECT codigo, nome, cpf, medidaCaseira, kCal, proteina, carboidrato, lipidio, calcio, ferro, vitC FROM Alimento"
        If nomeAlimento <> Nothing Then
            strSQL &= $"WHERE nome LIKE '%{nomeAlimento}%'"
        End If

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        While dr.Read
            dtgDados.Rows.Add(dr.Item("codigo"), dr.Item("nome"), dr.Item("cpf"), dr.Item("medidaCaseira"),
                              dr.Item("kCal"), dr.Item("proteina"), dr.Item("carboidrato"), dr.Item("lipidio"),
                              dr.Item("calcio"), dr.Item("ferro"))
        End While
        objConexao.Close()
    End Sub

End Class
