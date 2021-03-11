using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmPaciente : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.tbPaciente = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this._btnProcurarPaciente = new System.Windows.Forms.Button();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._btnExcluir = new System.Windows.Forms.Button();
            this._btnSalvar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this._txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtDtNasc = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this._txtNomePaciente = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this._dtgConsultaPacientes = new System.Windows.Forms.DataGridView();
            this.tbAntropometricos = new System.Windows.Forms.TabPage();
            this.tbPaciente.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPaciente
            // 
            this.tbPaciente.Controls.Add(this.tbCadastro);
            this.tbPaciente.Controls.Add(this.tbConsulta);
            this.tbPaciente.Controls.Add(this.tbAntropometricos);
            this.tbPaciente.Location = new System.Drawing.Point(2, 3);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.SelectedIndex = 0;
            this.tbPaciente.Size = new System.Drawing.Size(798, 517);
            this.tbPaciente.TabIndex = 0;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this._btnProcurarPaciente);
            this.tbCadastro.Controls.Add(this.txtCodPaciente);
            this.tbCadastro.Controls.Add(this.Label6);
            this.tbCadastro.Controls.Add(this.txtPeso);
            this.tbCadastro.Controls.Add(this.Label5);
            this.tbCadastro.Controls.Add(this.Label4);
            this.tbCadastro.Controls.Add(this.txtAltura);
            this.tbCadastro.Controls.Add(this.Label3);
            this.tbCadastro.Controls.Add(this.Label2);
            this.tbCadastro.Controls.Add(this._btnExcluir);
            this.tbCadastro.Controls.Add(this._btnSalvar);
            this.tbCadastro.Controls.Add(this.txtNumero);
            this.tbCadastro.Controls.Add(this.lblNum);
            this.tbCadastro.Controls.Add(this.txtEmail);
            this.tbCadastro.Controls.Add(this.Label1);
            this.tbCadastro.Controls.Add(this.txtComplemento);
            this.tbCadastro.Controls.Add(this.lblComplemento);
            this.tbCadastro.Controls.Add(this.txtUF);
            this.tbCadastro.Controls.Add(this.lblUF);
            this.tbCadastro.Controls.Add(this.txtCelular);
            this.tbCadastro.Controls.Add(this.lblCelular);
            this.tbCadastro.Controls.Add(this.txtTelefone);
            this.tbCadastro.Controls.Add(this.lblTelefone);
            this.tbCadastro.Controls.Add(this.txtMunicipio);
            this.tbCadastro.Controls.Add(this.lblMunicipio);
            this.tbCadastro.Controls.Add(this._txtCEP);
            this.tbCadastro.Controls.Add(this.lblCEP);
            this.tbCadastro.Controls.Add(this.txtBairro);
            this.tbCadastro.Controls.Add(this.lblBairro);
            this.tbCadastro.Controls.Add(this.txtEndereco);
            this.tbCadastro.Controls.Add(this.lblEndereco);
            this.tbCadastro.Controls.Add(this.txtDtNasc);
            this.tbCadastro.Controls.Add(this.lblDataNascimento);
            this.tbCadastro.Controls.Add(this.txtCPF);
            this.tbCadastro.Controls.Add(this.lblCPF);
            this.tbCadastro.Controls.Add(this.txtNome);
            this.tbCadastro.Controls.Add(this.PictureBox1);
            this.tbCadastro.Controls.Add(this.lblNome);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(790, 491);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // _btnProcurarPaciente
            // 
            this._btnProcurarPaciente.Image = global::ProjetoTCC.My.Resources.Resources.consultar;
            this._btnProcurarPaciente.Location = new System.Drawing.Point(388, 13);
            this._btnProcurarPaciente.Name = "_btnProcurarPaciente";
            this._btnProcurarPaciente.Size = new System.Drawing.Size(30, 23);
            this._btnProcurarPaciente.TabIndex = 262;
            this._btnProcurarPaciente.UseVisualStyleBackColor = true;
            this._btnProcurarPaciente.Click += new System.EventHandler(this.btnProcurarPaciente_Click);
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Enabled = false;
            this.txtCodPaciente.Location = new System.Drawing.Point(324, 15);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(58, 20);
            this.txtCodPaciente.TabIndex = 225;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(213, 18);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 13);
            this.Label6.TabIndex = 261;
            this.Label6.Text = "Código Paciente:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(253, 190);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(60, 20);
            this.txtPeso.TabIndex = 230;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(471, 193);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(21, 13);
            this.Label5.TabIndex = 260;
            this.Label5.Text = "cm";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(319, 193);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(20, 13);
            this.Label4.TabIndex = 259;
            this.Label4.Text = "Kg";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(405, 190);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 20);
            this.txtAltura.TabIndex = 231;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(362, 193);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 258;
            this.Label3.Text = "Altura:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(213, 193);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 257;
            this.Label2.Text = "Peso:";
            // 
            // _btnExcluir
            // 
            this._btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExcluir.Image = global::ProjetoTCC.My.Resources.Resources.DeleteRed;
            this._btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcluir.Location = new System.Drawing.Point(694, 455);
            this._btnExcluir.Name = "_btnExcluir";
            this._btnExcluir.Size = new System.Drawing.Size(89, 30);
            this._btnExcluir.TabIndex = 242;
            this._btnExcluir.Text = "Excluir";
            this._btnExcluir.UseVisualStyleBackColor = true;
            this._btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // _btnSalvar
            // 
            this._btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSalvar.Image = global::ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16;
            this._btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSalvar.Location = new System.Drawing.Point(599, 455);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(89, 30);
            this._btnSalvar.TabIndex = 241;
            this._btnSalvar.Text = "Salvar";
            this._btnSalvar.UseVisualStyleBackColor = true;
            this._btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(675, 246);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 20);
            this.txtNumero.TabIndex = 234;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(645, 249);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 13);
            this.lblNum.TabIndex = 256;
            this.lblNum.Text = "Nº:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(324, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 229;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(213, 156);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 255;
            this.Label1.Text = "E-mail:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(101, 344);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(634, 20);
            this.txtComplemento.TabIndex = 238;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(18, 347);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 254;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(675, 296);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(60, 20);
            this.txtUF.TabIndex = 237;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(645, 299);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 253;
            this.lblUF.Text = "UF:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(332, 393);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(180, 20);
            this.txtCelular.TabIndex = 240;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(284, 396);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 252;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 393);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(180, 20);
            this.txtTelefone.TabIndex = 239;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 396);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 251;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Enabled = false;
            this.txtMunicipio.Location = new System.Drawing.Point(447, 296);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(180, 20);
            this.txtMunicipio.TabIndex = 236;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(384, 299);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 250;
            this.lblMunicipio.Text = "Município:";
            // 
            // _txtCEP
            // 
            this._txtCEP.Location = new System.Drawing.Point(61, 246);
            this._txtCEP.Name = "_txtCEP";
            this._txtCEP.Size = new System.Drawing.Size(124, 20);
            this._txtCEP.TabIndex = 232;
            this._txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(18, 249);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 249;
            this.lblCEP.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(61, 296);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(315, 20);
            this.txtBairro.TabIndex = 235;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(18, 299);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 248;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(275, 246);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(352, 20);
            this.txtEndereco.TabIndex = 233;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(213, 249);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 247;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(324, 118);
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(100, 20);
            this.txtDtNasc.TabIndex = 228;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(213, 121);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.lblDataNascimento.TabIndex = 246;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(324, 82);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 227;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(213, 85);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 245;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(324, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 226;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::ProjetoTCC.My.Resources.Resources.default_user;
            this.PictureBox1.Location = new System.Drawing.Point(7, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(195, 208);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 244;
            this.PictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(213, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 243;
            this.lblNome.Text = "Nome Completo:";
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this._txtNomePaciente);
            this.tbConsulta.Controls.Add(this.lblNomePaciente);
            this.tbConsulta.Controls.Add(this._dtgConsultaPacientes);
            this.tbConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(790, 491);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            this.tbConsulta.Enter += new System.EventHandler(this.tbConsulta_Enter);
            // 
            // _txtNomePaciente
            // 
            this._txtNomePaciente.Location = new System.Drawing.Point(50, 12);
            this._txtNomePaciente.Name = "_txtNomePaciente";
            this._txtNomePaciente.Size = new System.Drawing.Size(734, 20);
            this._txtNomePaciente.TabIndex = 2;
            this._txtNomePaciente.Leave += new System.EventHandler(this.txtNomePaciente_Leave);
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(6, 15);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(38, 13);
            this.lblNomePaciente.TabIndex = 1;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // _dtgConsultaPacientes
            // 
            this._dtgConsultaPacientes.BackgroundColor = System.Drawing.Color.White;
            this._dtgConsultaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtgConsultaPacientes.Location = new System.Drawing.Point(6, 38);
            this._dtgConsultaPacientes.Name = "_dtgConsultaPacientes";
            this._dtgConsultaPacientes.Size = new System.Drawing.Size(777, 452);
            this._dtgConsultaPacientes.TabIndex = 0;
            this._dtgConsultaPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaPacientes_CellDoubleClick);
            // 
            // tbAntropometricos
            // 
            this.tbAntropometricos.Location = new System.Drawing.Point(4, 22);
            this.tbAntropometricos.Name = "tbAntropometricos";
            this.tbAntropometricos.Padding = new System.Windows.Forms.Padding(3);
            this.tbAntropometricos.Size = new System.Drawing.Size(790, 491);
            this.tbAntropometricos.TabIndex = 2;
            this.tbAntropometricos.Text = "Antropometria";
            this.tbAntropometricos.UseVisualStyleBackColor = true;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 523);
            this.Controls.Add(this.tbPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaciente";
            this.Text = "Pacientes";
            this.tbPaciente.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        internal TabControl tbPaciente;
        internal TabPage tbCadastro;
        internal Button Button1;
        internal TextBox TextBox18;
        public Button _btnProcurarPaciente;
        internal Label Label24;
        internal TextBox txtCodPaciente;
        internal TextBox TextBox17;
        internal Label Label6;
        internal Label Label23;
        internal Label Label22;
        internal TextBox TextBox16;
        internal Label Label21;
        internal Label Label20;
        public Button _btnExcluir;

        internal Button btnExcluir
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExcluir;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExcluir != null)
                {
                    _btnExcluir.Click -= btnExcluir_Click;
                }

                _btnExcluir = value;
                if (_btnExcluir != null)
                {
                    _btnExcluir.Click += btnExcluir_Click;
                }
            }
        }

        internal TextBox TextBox15;
        public Button _btnSalvar;

        internal Button btnSalvar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSalvar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSalvar != null)
                {
                    _btnSalvar.Click -= btnSalvar_Click;
                }

                _btnSalvar = value;
                if (_btnSalvar != null)
                {
                    _btnSalvar.Click += btnSalvar_Click;
                }
            }
        }

        internal Label Label19;
        internal TextBox txtNumero;
        internal TextBox TextBox14;
        internal Label lblNum;
        internal Label Label18;
        internal TextBox txtEmail;
        internal TextBox TextBox13;
        internal Label Label1;
        internal Label Label17;
        internal TextBox txtComplemento;
        internal TextBox TextBox12;
        internal Label lblComplemento;
        internal Label Label16;
        internal TextBox txtUF;
        internal TextBox TextBox11;
        internal Label lblUF;
        internal Label Label15;
        internal TextBox txtCelular;
        internal TextBox TextBox10;
        internal Label lblCelular;
        internal Label Label14;
        internal TextBox txtTelefone;
        internal TextBox TextBox7;
        internal Label lblTelefone;
        internal Label Label13;
        internal TextBox txtMunicipio;
        internal TextBox TextBox6;
        internal Label lblMunicipio;
        internal Label Label12;
        private TextBox _txtCEP;

        internal TextBox txtCEP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCEP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCEP != null)
                {
                    _txtCEP.Leave -= txtCEP_Leave;
                }

                _txtCEP = value;
                if (_txtCEP != null)
                {
                    _txtCEP.Leave += txtCEP_Leave;
                }
            }
        }

        internal TextBox TextBox5;
        internal Label lblCEP;
        internal Label Label11;
        internal TextBox txtBairro;
        internal TextBox TextBox4;
        internal Label lblBairro;
        internal Label Label10;
        internal TextBox txtEndereco;
        internal TextBox TextBox3;
        internal Label lblEndereco;
        internal Label Label9;
        internal TextBox txtDtNasc;
        internal TextBox TextBox2;
        internal Label lblDataNascimento;
        internal Label Label8;
        internal TextBox txtCPF;
        internal TextBox TextBox1;
        internal Label lblCPF;
        internal PictureBox PictureBox2;
        internal TextBox txtNome;
        internal Label Label7;
        internal PictureBox PictureBox1;
        internal Label lblNome;
        private TabPage tbConsulta;

       
        public DataGridView _dtgConsultaPacientes;

        internal DataGridView dtgConsultaPacientes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtgConsultaPacientes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtgConsultaPacientes != null)
                {
                    _dtgConsultaPacientes.CellDoubleClick -= dtgConsultaPacientes_CellDoubleClick;
                }

                _dtgConsultaPacientes = value;
                if (_dtgConsultaPacientes != null)
                {
                    _dtgConsultaPacientes.CellDoubleClick += dtgConsultaPacientes_CellDoubleClick;
                }
            }
        }

        public TextBox _txtNomePaciente;

        internal TextBox txtNomePaciente
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtNomePaciente;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtNomePaciente != null)
                {
                    _txtNomePaciente.Leave -= txtNomePaciente_Leave;
                }

                _txtNomePaciente = value;
                if (_txtNomePaciente != null)
                {
                    _txtNomePaciente.Leave += txtNomePaciente_Leave;
                }
            }
        }

        internal Label lblNomePaciente;
        internal TextBox txtPeso;
        internal Label Label5;
        internal Label Label4;
        internal TextBox txtAltura;
        internal Label Label3;
        internal Label Label2;
        private TabPage tbAntropometricos;
    }
}