Public Class frmCadastroNutricional

    '    Private Sub frmCalculadoraNutricional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Me.txtCodAlimento.Conexao = conexaoPadrao
    '    End Sub

    '    Private Sub VerificarAlimentoCadastrado()

    '        Dim strSQL As String = $" SELECT COUNT(1) as Existe FROM InfosAlimentosNutricionais WHERE "

    '    End Sub

    '    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

    '        btnConsultar.ShowWait(True)

    '        Dim transaction As MvtConnection.Helpers.TransactionHelper = MvtConnection.Helpers.TransactionHelper.Create(conexaoPadrao)

    '        Try

    '            transaction.BeginTransaction()

    '            conexaoPadrao.NewTable("InfosAlimentosNutricionais", Not IsNullOrEmpty(Me.txtCodAlimento.Text))

    '            conexaoPadrao.InsertField("Alimento", Me.txtAlimento.ValueSQL)
    '            conexaoPadrao.InsertField("qtde", Me.txtQtde.ValueSQL)
    '            conexaoPadrao.InsertField("kcal", Me.txtKcal.ValueSQL)
    '            conexaoPadrao.InsertField("proteina", Me.txtProteina.ValueSQL)
    '            conexaoPadrao.InsertField("carboidrato", Me.txtCarboidrato.ValueSQL)
    '            conexaoPadrao.InsertField("lipidio", Me.txtLipidio.ValueSQL)
    '            conexaoPadrao.InsertField("calcio", Me.txtCalcio.ValueSQL)
    '            conexaoPadrao.InsertField("ferro", Me.txtFerro.ValueSQL)
    '            conexaoPadrao.InsertField("VitC", Me.txtVitC.ValueSQL)

    '            Dim erro As String = conexaoPadrao.ExecuteInsertUpDate(True)

    '            transaction.CommitTransaction()
    '            btnConsultar.HideWait(True)
    '            MsgBox("Seus dados foram salvos.", MsgBoxStyle.Exclamation, "MOV.TECH")
    '            limparCampos()

    '        Catch ex As Exception
    '            btnConsultar.HideWait(True)
    '            MsgBox("Ocorreu um erro ao salvar." & ex.Message & "!", MsgBoxStyle.Exclamation, "MOV.TECH")
    '            transaction.RollbackTransaction()
    '        End Try

    '    End Sub

    '    Private Sub txtCodAlimento_Leave(sender As Object, e As EventArgs) Handles txtCodAlimento.Leave

    '        Me.txtAlimento.Text = Me.txtCodAlimento.LabelName.Text
    '        Me.txtCodAlimento.LabelName.Visible = False

    '        If String.IsNullOrEmpty(Me.txtCodAlimento.Text) Then
    '            limparCampos()
    '            Exit Sub
    '        End If

    '        Dim strSQL As String = String.Empty

    '        strSQL = $"SELECT Alimento 
    '                          , qtde
    '                          , kcal
    '                          , proteina
    '                          , carboidrato
    '                          , lipidio
    '                          , calcio
    '                          , ferro
    '                          , vitC 
    '                  FROM InfosAlimentosNutricionais 
    '                  WHERE codAlimento = {Me.txtCodAlimento.Text}" & Chr(13) & Chr(10)

    '        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)

    '            While dr.Read

    '                Me.txtAlimento.Text = dr("Alimento")
    '                Me.txtQtde.Text = dr("qtde")
    '                Me.txtKcal.Text = dr("kcal")
    '                Me.txtProteina.Text = dr("proteina")
    '                Me.txtCarboidrato.Text = dr("carboidrato")
    '                Me.txtLipidio.Text = dr("lipidio")
    '                Me.txtCalcio.Text = dr("calcio")
    '                Me.txtFerro.Text = dr("ferro")
    '                Me.txtVitC.Text = dr("vitC")

    '            End While

    '        End Using

    '    End Sub

    '    Private Sub limparCampos()

    '        Me.txtAlimento.Text = ""
    '        Me.txtQtde.Text = ""
    '        Me.txtKcal.Text = ""
    '        Me.txtProteina.Text = ""
    '        Me.txtCarboidrato.Text = ""
    '        Me.txtLipidio.Text = ""
    '        Me.txtCalcio.Text = ""
    '        Me.txtFerro.Text = ""
    '        Me.txtVitC.Text = ""

    '    End Sub

    '    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

    '        btnConsultar.ShowWait(True)

    '        Dim transaction As MvtConnection.Helpers.TransactionHelper = MvtConnection.Helpers.TransactionHelper.Create(conexaoPadrao)

    '        Try

    '            transaction.BeginTransaction()

    '            conexaoPadrao.NewTable("InfosAlimentosNutricionais", True)

    '            conexaoPadrao.InsertKey("codAlimento", Me.txtCodAlimento.Text)

    '            Dim erro As String = conexaoPadrao.ExecuteDelete(True)

    '            transaction.CommitTransaction()

    '            btnConsultar.HideWait(True)
    '            mMensagemAviso("O alimento foi excluído com sucesso.")

    '        Catch ex As Exception
    '            btnConsultar.HideWait(True)
    '            mMensagemAviso("Ocorreu um erro ao excluir.")

    '            transaction.RollbackTransaction()

    '        End Try
    '        limparCampos()

    '    End Sub
End Class