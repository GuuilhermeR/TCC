Public Class frmPaciente

    Public Property paciente As PacienteDAO


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

    Private Sub buscarEndCep(CEP As Integer)

        Using WS = New BuscaCEP.AtendeClienteClient()
            Try
                Dim Resultado = WS.consultaCEP(CEP)
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

    Private Sub tbConsulta_Enter(sender As Object, e As EventArgs) Handles tbConsulta.Enter
        paciente.Buscar(dtgConsultaPacientes)
    End Sub

    Private Sub txtNomePaciente_Leave(sender As Object, e As EventArgs) Handles txtNomePaciente.Leave

        paciente.Buscar(dtgConsultaPacientes)

    End Sub

    Private Sub btnProcurarPaciente_Click(sender As Object, e As EventArgs) Handles btnProcurarPaciente.Click
        tbPaciente.SelectedTab = tbConsulta
    End Sub

    Private Sub dtgConsultaPacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgConsultaPacientes.CellDoubleClick
        'FAZER FUNÇÃO PARA PEGAR OS DADOS SELECIONADOS E MANDAR PARA A TELA DE CADASTRO.
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then

            Me.txtCodPaciente.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtNomePaciente.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtCPF.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtDtNasc.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtEmail.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtPeso.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtAltura.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtCEP.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtNumero.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtComplemento.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtTelefone.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value
            Me.txtCelular.Text = Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value

            buscarEndCep(Me.dtgConsultaPacientes.Rows(e.RowIndex).Cells("").Value)

            Me.tbPaciente.SelectedTab = tbCadastro

        End If
    End Sub

    Private Sub limparCamposCadPaciente()

        Me.txtCodPaciente.Text = ""
        Me.txtNomePaciente.Text = ""
        Me.txtCPF.Text = ""
        Me.txtDtNasc.Text = ""
        Me.txtEmail.Text = ""
        Me.txtPeso.Text = ""
        Me.txtAltura.Text = ""
        Me.txtCEP.Text = ""
        Me.txtEndereco.Text = ""
        Me.txtNumero.Text = ""
        Me.txtBairro.Text = ""
        Me.txtMunicipio.Text = ""
        Me.txtUF.Text = ""
        Me.txtComplemento.Text = ""
        Me.txtTelefone.Text = ""
        Me.txtCelular.Text = ""

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        paciente.Salvar(Me.txtCodPaciente.Text, Me.txtNomePaciente.Text, Me.txtCEP.Text, Me.txtNumero.Text, Me.txtDtNasc.Text,
                        Me.txtEmail.Text, Me.txtPeso.Text, Me.txtAltura.Text, Me.txtCEP.Text, Me.txtTelefone.Text, Me.txtCelular.Text)
    End Sub

    Private Sub txtCEP_Leave(sender As Object, e As EventArgs) Handles txtCEP.Leave
        buscarEndCep(Me.txtCEP.Text)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If Me.txtCodPaciente.Text <> Nothing Then
            paciente.Deletar(Me.txtCodPaciente.Text)
        Else
            MsgBox("Não é possível excluir sem antes informar o código.")
        End If
    End Sub
End Class