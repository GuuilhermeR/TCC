Public Class frmCadastroNutricional

    Private Sub frmCalculadoraNutricional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtAlimento.Conexao = conexaoPadrao
    End Sub

    Private Sub VerificarAlimentoCadastrado()

        Dim strSQL As String = $" SELECT COUNT(1) as Existe FROM InfosAlimentosNutricionais WHERE "

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        btnConsultar.ShowWait(True)

        Dim transaction As MvtConnection.Helpers.TransactionHelper = MvtConnection.Helpers.TransactionHelper.Create(conexaoPadrao)

        Try

            transaction.BeginTransaction()

            conexaoPadrao.NewTable("InfosAlimentosNutricionais", False)

            conexaoPadrao.InsertField("codAlimento", Me.txtAlimento.ValueSQL)
            conexaoPadrao.InsertField("gramas", Me.txtGramas.ValueSQL)
            conexaoPadrao.InsertField("qtde", Me.txtQtde.ValueSQL)
            conexaoPadrao.InsertField("kcal", Me.txtKcal.ValueSQL)
            conexaoPadrao.InsertField("proteina", Me.txtProteina.ValueSQL)
            conexaoPadrao.InsertField("carboidrato", Me.txtCarboidrato.ValueSQL)
            conexaoPadrao.InsertField("lipidio", Me.txtLipidio.ValueSQL)
            conexaoPadrao.InsertField("calcio", Me.txtCalcio.ValueSQL)
            conexaoPadrao.InsertField("ferro", Me.txtFerro.ValueSQL)
            conexaoPadrao.InsertField("VitC", Me.txtVitC.ValueSQL)

            Dim erro As String = conexaoPadrao.ExecuteInsertUpDate(True)

            transaction.CommitTransaction()

            MsgBox("Seus dados foram salvos.", MsgBoxStyle.Exclamation, "MOV.TECH")


        Catch ex As Exception

            MsgBox("Ocorreu um erro ao salvar." & ex.Message & "!", MsgBoxStyle.Exclamation, "MOV.TECH")

            transaction.RollbackTransaction()

        End Try

        btnConsultar.HideWait(True)

    End Sub
End Class