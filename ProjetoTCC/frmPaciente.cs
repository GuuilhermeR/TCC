using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web;

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
            tbConsulta.Name = "tbConsulta";
            _txtNomePaciente.Name = "txtNomePaciente";
            _dtgConsultaPacientes.Name = "dtgConsultaPacientes";
        }

        public PacienteDAO paciente = new PacienteDAO();


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

        private void buscarEndCep(string CEP)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($@"https://viacep.com.br/ws/{CEP}/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível");
                return;
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    txtCEP.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtEndereco.Text = valor[1];
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtComplemento.Text = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtBairro.Text = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtMunicipio.Text = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtUF.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }

        }

        private void tbConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void txtNomePaciente_Leave(object sender, EventArgs e)
        {
            paciente.Buscar(dtgConsultaPacientes, txtNomePaciente.Text);
        }

        private void btnProcurarPaciente_Click(object sender, EventArgs e)
        {
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
                buscarEndCep(dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value.ToString());
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
            if (txtCodPaciente.Text != "")
            {
                paciente.Atualizar(Convert.ToDouble(txtCodPaciente.Text), txtNome.Text, txtCPF.Text, txtDtNasc.Text, txtEmail.Text, txtPeso.Text, txtAltura.Text, txtCEP.Text,
                                Convert.ToDouble(txtNumero.Text), txtTelefone.Text, txtCelular.Text, txtEndereco.Text, txtBairro.Text, txtMunicipio.Text, txtUF.Text, txtComplemento.Text);
            }
            else
            {
                paciente.Salvar(txtNome.Text, txtCPF.Text, txtDtNasc.Text, txtEmail.Text, txtPeso.Text, txtAltura.Text, txtCEP.Text,Convert.ToDouble(txtNumero.Text), 
                               txtTelefone.Text, txtCelular.Text, txtEndereco.Text, txtBairro.Text, txtMunicipio.Text, txtUF.Text, txtComplemento.Text);
            }
           
            limparCamposCadPaciente();

        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            buscarEndCep(txtCEP.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPaciente.Text))
            {
                paciente.Deletar(Conversions.ToInteger(txtCodPaciente.Text));
                limparCamposCadPaciente();
            }
            else
            {
                Interaction.MsgBox("Não é possível excluir sem antes informar o código.");
            }
        }
    }
}