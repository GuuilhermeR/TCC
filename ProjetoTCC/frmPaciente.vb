Public Class frmPaciente
    Private Sub txtCEP_Leave(sender As Object, e As EventArgs)

        Using WS = New BuscaCEP.AtendeClienteClient()
            Try
                Dim Resultado = WS.consultaCEP(txtCEP.Text)
                Me.txtEndereco.Text = Resultado.[end]
                Me.txtComplemento.Text = Resultado.complemento2
                Me.txtMunicipio.Text = Resultado.cidade
                Me.txtBairro.Text = Resultado.bairro
                Me.txtUF.Text = Resultado.uf
            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Using

    End Sub


    'CLASSIFICAÇÃO  	 MASCULINO  	 FEMININO  
    'RISCO BAIXO  	    17,9 A 18,9 	15,0 A 17,9  
    'IDEAL  	        19,0 A 24,9  	18,0 A 24,4  
    'RISCO MODERADO  	25,0 A 27,7   	24,5 A 27,2  
    'RISCO ELEVADO  	ACIMA DE 27,8  	ACIMA DE 27,3 

    Private Sub txtAltura_Leave(sender As Object, e As EventArgs)

        'If Me.txtAltura.Text <> "" AndAlso Me.txtPeso.Text <> "" Then

        '    Dim IMC As Double

        '    IMC = Me.txtPeso.Text / (Me.txtAltura.Text * Me.txtAltura.Text)

        '    If IMC < 0 Or Nothing Then
        '        MsgBox("Para carregar o campo do IMC é necessário preencher os campos de peso e altura!", MsgBoxStyle.Exclamation, "Inserção de Dados")
        '    ElseIf IMC < 18.5 Then
        '        Me.txtIMC.Text = ("O IMC é de: " & IMC & vbCrLf & " Kg/m² - Magreza")
        '    ElseIf 24.9 < IMC < 18.5 Then
        '        Me.txtIMC.Text = ("O IMC é de: " & IMC & vbCrLf & " Kg/m² - Normal")
        '    ElseIf 30 < IMC < 24.9 Then
        '        Me.txtIMC.Text = ("O IMC é de: " & IMC & vbCrLf & " Kg/m² - Sobrepeso")
        '    ElseIf IMC > 30 Then
        '        Me.txtIMC.Text = ("O IMC é de: " & IMC & " Kg/m² - Obesidade")
        '    End If

        'End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

    End Sub
End Class