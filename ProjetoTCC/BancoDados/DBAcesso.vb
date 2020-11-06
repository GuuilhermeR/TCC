Imports System.Data.SqlClient
Public Class DBAcesso

    Public Class mdlAcesso
        Private objConexao As SqlClient.SqlConnection
        Dim stringConexao As String = "Data Source=BancoDadosTCC.DB;VERSION=3;ReadOnly=False;"

        Public Sub Conectar()
            Try
                objConexao = New SqlClient.SqlConnection(stringConexao)
                objConexao.Open()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function Conexao()
            Return stringConexao
        End Function


        Public Sub Fechar()
            Try
                If Not IsNothing(objConexao) Then
                    If objConexao.State = ConnectionState.Open Then
                        objConexao.Close()
                    End If

                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function ExecuteQuery(ByVal Command As String) As DataSet


            Dim ds As New DataSet
            Dim objDataAdapter As New SqlClient.SqlDataAdapter
            Dim objCommand As New SqlClient.SqlCommand
            Try
                objCommand = objConexao.CreateCommand
                objCommand.CommandText = Command
                objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
                objDataAdapter.Fill(ds)
            Catch ex As Exception
                Throw ex
            End Try

            Return ds

        End Function


    End Class

End Class
