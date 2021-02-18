Public Class frmCadPaciente
    Private Sub txtCEP_Leave(sender As Object, e As EventArgs) Handles txtCEP.Leave

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

    Private Sub txtAltura_Leave(sender As Object, e As EventArgs) Handles txtAltura.Leave

        If Me.txtAltura.Text <> "" AndAlso Me.txtPeso.Text <> "" Then

            Dim IMC As Double

            IMC = Me.txtPeso.Text / (Me.txtAltura.Text * Me.txtAltura.Text)

            If IMC < 0 Or Nothing Then
                MsgBox("Por favor introduza os elementos válidos necessários.", MsgBoxStyle.Exclamation, "Inserção de Dados")
            ElseIf IMC < 18.5 Then
                MsgBox("O IMC é de: " & IMC & vbCrLf & "Magreza")
            ElseIf 24.9 < IMC < 18.5 Then
                MsgBox("O IMC é de: " & IMC & vbCrLf & "Normal")
            ElseIf 30 < IMC < 24.9 Then
                MsgBox("O IMC é de: " & IMC & vbCrLf & "Sobrepeso")
            ElseIf IMC > 30 Then
                MsgBox("O IMC é de: " & IMC & vbCrLf & "Obesidade")
            End If

        End If
    End Sub
End Class