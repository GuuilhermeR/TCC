Imports System.Data.SQLite
Public Class PacienteDAO

    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Public listaPacientes As Dictionary(Of Integer, String)

    Private Function retornaUltimoCodPaciente() As Integer

        objConexao.Open()

        Dim strSQL As String = String.Empty

        Dim codPaciente As Integer

        strSQL = $"SELECT MAX(codigo) As Codigo FROM Paciente"

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        If dr.Read Then
            codPaciente = dr("Codigo")
        End If
        objConexao.Close()

        Return codPaciente

    End Function

    Public Sub Salvar(codPaciente As Integer, nomeCompleto As String, cpf As Integer, dtNasc As Date, email As String, peso As Double, altura As Double, cep As Integer, telefone As Integer, celular As Integer)

        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            If codPaciente <> "" Then
                strSQL = $"UPDATE Paciente SET nome= '{nomeCompleto}', cpf = {cpf}, dtNasc = '{dtNasc.ToString("dd/MM/yyyy")}', 
                            email = '{email}', peso = {peso}, altura = {altura}, cep ={cep}, telefone = {telefone}, celular = {celular} WHERE codigo = {codPaciente}"
            Else
                strSQL = $"INSERT INTO Paciente (nome, cpf, dtNasc, email, peso, altura, cep, telefone, celular) 
                            values ('{nomeCompleto}', {cpf}, '{dtNasc.ToString("dd/MM/yyyy")}', '{email}', {peso}, {altura}, {cep}, {telefone}, {celular})"
            End If

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.ExecuteNonQuery()

            MsgBox("O Paciente foi salvo.", vbInformation, "Atenção!")

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar o Paciente." & Chr(10) & ex.Message, vbOKOnly, "Alerta")
        End Try

        objConexao.Close()

    End Sub

    Public Sub Deletar(codPaciente As Integer, nomeCompleto As String, cpf As Integer, dtNasc As Date, email As String, peso As Double, altura As Double, cep As Integer, telefone As Integer, celular As Integer)

        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            strSQL = $"DELETE FROM Paciente WHERE codAlimento = {codPaciente}"

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.ExecuteNonQuery()
            MsgBox("O Paciente foi excluído!", vbInformation, "Atenção!")

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao excluir o Paciente." & Chr(10) & ex.Message, vbOKOnly, "Alerta")
        End Try

        objConexao.Close()

    End Sub

    Public Sub Buscar(dtgDados As DataGridView)

        Dim strSQL As String = String.Empty

        strSQL = "SELECT codigo, nome, cpf, dtNasc, email, peso, altura, cep, telefone, celular FROM Paciente"

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        While dr.Read
            dtgDados.Rows.Add(dr.Item("codigo"), dr.Item("nome"), dr.Item("cpf"), dr.Item("dtNasc"),
                              dr.Item("email"), dr.Item("peso"), dr.Item("altura"), dr.Item("cep"),
                              dr.Item("telefone"), dr.Item("celular"))
        End While
        objConexao.Close()
    End Sub

    Public Sub BuscarPeloNome(nomePaciente As String, dtgDados As DataGridView)

        If nomePaciente Is Nothing Then
            MsgBox("Favor inserir o filtro de nome do Paciente.")
            Exit Sub
        End If

        Dim strSQL As String = String.Empty

        strSQL = "SELECT codigo, nome FROM Paciente"
        strSQL &= $"WHERE nome LIKE '%{nomePaciente}%'"

        Dim cmd = New SQLiteCommand(strSQL, objConexao)
        objConexao.Open()
        Dim dr = cmd.ExecuteReader()

        While dr.Read
            dtgDados.Rows.Add(dr.Item("codigo"), dr.Item("nome"))
        End While
        objConexao.Close()

    End Sub

End Class
