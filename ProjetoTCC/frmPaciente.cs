using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    public partial class frmPaciente
    {
        public frmPaciente()
        {
            InitializeComponent();
            _btnProcurarPaciente.Name = "btnProcurarPaciente";
            _btnExcluir.Name = "btnExcluir";
            _btnSalvar.Name = "btnSalvar";
            _txtCEP.Name = "txtCEP";
            _tbConsulta.Name = "tbConsulta";
            _txtNomePaciente.Name = "txtNomePaciente";
            _dtgConsultaPacientes.Name = "dtgConsultaPacientes";
        }

        public PacienteDAO paciente { get; set; }


        // CLASSIFICAÇÃO  	 MASCULINO  	 FEMININO  
        // RISCO BAIXO  	    17,9 A 18,9 	15,0 A 17,9  
        // IDEAL  	        19,0 A 24,9  	18,0 A 24,4  
        // RISCO MODERADO  	25,0 A 27,7   	24,5 A 27,2  
        // RISCO ELEVADO  	ACIMA DE 27,8  	ACIMA DE 27,3 

        private void txtAltura_Leave(object sender, EventArgs e)
        {

            // If Me.txtAltura.Text <> "" AndAlso Me.txtPeso.Text <> "" Then

            // Dim IMC As Double

            // IMC = Me.txtPeso.Text / (Me.txtAltura.Text * Me.txtAltura.Text)

            // If IMC < 0 Or Nothing Then
            // MsgBox("Para carregar o campo do IMC é necessário preencher os campos de peso e altura!", MsgBoxStyle.Exclamation, "Inserção de Dados")
            // ElseIf IMC < 18.5 Then
            // Me.txtIMC.Text = ("O IMC é de: " & IMC & vbCrLf & " Kg/m² - Magreza")
            // ElseIf 24.9 < IMC < 18.5 Then
            // Me.txtIMC.Text = ("O IMC é de: " & IMC & vbCrLf & " Kg/m² - Normal")
            // ElseIf 30 < IMC < 24.9 Then
            // Me.txtIMC.Text = ("O IMC é de: " & IMC & vbCrLf & " Kg/m² - Sobrepeso")
            // ElseIf IMC > 30 Then
            // Me.txtIMC.Text = ("O IMC é de: " & IMC & " Kg/m² - Obesidade")
            // End If

            // End If
        }

        private void buscarEndCep(int CEP)
        {
            using (var WS = new BuscaCEP.AtendeClienteClient())
            {
                try
                {
                    var Resultado = WS.consultaCEP(CEP.ToString());
                    txtEndereco.Text = Resultado.end;
                    txtComplemento.Text = Resultado.complemento2;
                    txtMunicipio.Text = Resultado.cidade;
                    txtBairro.Text = Resultado.bairro;
                    txtUF.Text = Resultado.uf;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbConsulta_Enter(object sender, EventArgs e)
        {

            paciente.Buscar(dtgConsultaPacientes);
        }

        private void txtNomePaciente_Leave(object sender, EventArgs e)
        {
            paciente.Buscar(dtgConsultaPacientes);
        }

        private void btnProcurarPaciente_Click(object sender, EventArgs e)
        {
            tbPaciente.SelectedTab = tbConsulta;
        }

        private void dtgConsultaPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // FAZER FUNÇÃO PARA PEGAR OS DADOS SELECIONADOS E MANDAR PARA A TELA DE CADASTRO.
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                txtCodPaciente.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtNomePaciente.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCPF.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtDtNasc.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtEmail.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtPeso.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtAltura.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCEP.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtNumero.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtComplemento.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtTelefone.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCelular.Text = Conversions.ToString(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                buscarEndCep(Conversions.ToInteger(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value));
                tbPaciente.SelectedTab = tbCadastro;
            }
        }

        private void limparCamposCadPaciente()
        {
            txtCodPaciente.Text = "";
            txtNomePaciente.Text = "";
            txtCPF.Text = "";
            txtDtNasc.Text = "";
            txtEmail.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
            txtUF.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            paciente.Salvar(Conversions.ToInteger(txtCodPaciente.Text), txtNomePaciente.Text, Conversions.ToInteger(txtCEP.Text), Conversions.ToDate(txtNumero.Text), txtDtNasc.Text, Conversions.ToDouble(txtEmail.Text), Conversions.ToDouble(txtPeso.Text), Conversions.ToInteger(txtAltura.Text), Conversions.ToInteger(txtCEP.Text), Conversions.ToInteger(txtTelefone.Text), Conversions.ToInteger(txtCelular.Text));
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            buscarEndCep(Conversions.ToInteger(txtCEP.Text));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPaciente.Text))
            {
                paciente.Deletar(Conversions.ToInteger(txtCodPaciente.Text));
            }
            else
            {
                Interaction.MsgBox("Não é possível excluir sem antes informar o código.");
            }
        }
    }
}