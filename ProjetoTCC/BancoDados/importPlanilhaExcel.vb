Imports System.Data.OleDb

Public Class importPlanilhaExcel

    Sub BuscarPlanilha(caminhoArquivoExcel As String, nomePlanilhaExcel As String)

        Dim cmd As New OleDbCommand
        nomePlanilhaExcel = nomePlanilhaExcel & "$"
        Dim conexaoOleDb As OleDbConnection = Nothing
        conexaoOleDb = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & caminhoArquivoExcel & ";Extended Properties=Excel 8.0;")
        cmd.CommandText = "Select * from [" & nomePlanilhaExcel & "]"

    End Sub

End Class
