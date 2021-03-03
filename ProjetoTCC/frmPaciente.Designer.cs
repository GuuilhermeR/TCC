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
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            tbPaciente = new TabControl();
            tbCadastro = new TabPage();
            _btnProcurarPaciente = new Button();
            _btnProcurarPaciente.Click += new EventHandler(btnProcurarPaciente_Click);
            txtCodPaciente = new TextBox();
            Label6 = new Label();
            txtPeso = new TextBox();
            Label5 = new Label();
            Label4 = new Label();
            txtAltura = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            _btnExcluir = new Button();
            _btnExcluir.Click += new EventHandler(btnExcluir_Click);
            _btnSalvar = new Button();
            _btnSalvar.Click += new EventHandler(btnSalvar_Click);
            txtNumero = new TextBox();
            lblNum = new Label();
            txtEmail = new TextBox();
            Label1 = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtUF = new TextBox();
            lblUF = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtMunicipio = new TextBox();
            lblMunicipio = new Label();
            _txtCEP = new TextBox();
            _txtCEP.Leave += new EventHandler(txtCEP_Leave);
            lblCEP = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtDtNasc = new TextBox();
            lblDataNascimento = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            PictureBox1 = new PictureBox();
            lblNome = new Label();
            _tbConsulta = new TabPage();
            _tbConsulta.Enter += new EventHandler(tbConsulta_Enter);
            _txtNomePaciente = new TextBox();
            _txtNomePaciente.Leave += new EventHandler(txtNomePaciente_Leave);
            lblNomePaciente = new Label();
            _dtgConsultaPacientes = new DataGridView();
            _dtgConsultaPacientes.CellDoubleClick += new DataGridViewCellEventHandler(dtgConsultaPacientes_CellDoubleClick);
            tbPaciente.SuspendLayout();
            tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            _tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dtgConsultaPacientes).BeginInit();
            SuspendLayout();
            // 
            // tbPaciente
            // 
            tbPaciente.Controls.Add(tbCadastro);
            tbPaciente.Controls.Add(_tbConsulta);
            tbPaciente.Location = new Point(2, 3);
            tbPaciente.Name = "tbPaciente";
            tbPaciente.SelectedIndex = 0;
            tbPaciente.Size = new Size(798, 517);
            tbPaciente.TabIndex = 0;
            // 
            // tbCadastro
            // 
            tbCadastro.Controls.Add(_btnProcurarPaciente);
            tbCadastro.Controls.Add(txtCodPaciente);
            tbCadastro.Controls.Add(Label6);
            tbCadastro.Controls.Add(txtPeso);
            tbCadastro.Controls.Add(Label5);
            tbCadastro.Controls.Add(Label4);
            tbCadastro.Controls.Add(txtAltura);
            tbCadastro.Controls.Add(Label3);
            tbCadastro.Controls.Add(Label2);
            tbCadastro.Controls.Add(_btnExcluir);
            tbCadastro.Controls.Add(_btnSalvar);
            tbCadastro.Controls.Add(txtNumero);
            tbCadastro.Controls.Add(lblNum);
            tbCadastro.Controls.Add(txtEmail);
            tbCadastro.Controls.Add(Label1);
            tbCadastro.Controls.Add(txtComplemento);
            tbCadastro.Controls.Add(lblComplemento);
            tbCadastro.Controls.Add(txtUF);
            tbCadastro.Controls.Add(lblUF);
            tbCadastro.Controls.Add(txtCelular);
            tbCadastro.Controls.Add(lblCelular);
            tbCadastro.Controls.Add(txtTelefone);
            tbCadastro.Controls.Add(lblTelefone);
            tbCadastro.Controls.Add(txtMunicipio);
            tbCadastro.Controls.Add(lblMunicipio);
            tbCadastro.Controls.Add(_txtCEP);
            tbCadastro.Controls.Add(lblCEP);
            tbCadastro.Controls.Add(txtBairro);
            tbCadastro.Controls.Add(lblBairro);
            tbCadastro.Controls.Add(txtEndereco);
            tbCadastro.Controls.Add(lblEndereco);
            tbCadastro.Controls.Add(txtDtNasc);
            tbCadastro.Controls.Add(lblDataNascimento);
            tbCadastro.Controls.Add(txtCPF);
            tbCadastro.Controls.Add(lblCPF);
            tbCadastro.Controls.Add(txtNome);
            tbCadastro.Controls.Add(PictureBox1);
            tbCadastro.Controls.Add(lblNome);
            tbCadastro.Location = new Point(4, 22);
            tbCadastro.Name = "tbCadastro";
            tbCadastro.Padding = new Padding(3);
            tbCadastro.Size = new Size(790, 491);
            tbCadastro.TabIndex = 0;
            tbCadastro.Text = "Cadastro";
            tbCadastro.UseVisualStyleBackColor = true;
            // 
            // btnProcurarPaciente
            // 
            _btnProcurarPaciente.Image = My.Resources.Resources.consultar;
            _btnProcurarPaciente.Location = new Point(388, 13);
            _btnProcurarPaciente.Name = "_btnProcurarPaciente";
            _btnProcurarPaciente.Size = new Size(30, 23);
            _btnProcurarPaciente.TabIndex = 262;
            _btnProcurarPaciente.UseVisualStyleBackColor = true;
            // 
            // txtCodPaciente
            // 
            txtCodPaciente.Enabled = false;
            txtCodPaciente.Location = new Point(324, 15);
            txtCodPaciente.Name = "txtCodPaciente";
            txtCodPaciente.Size = new Size(58, 20);
            txtCodPaciente.TabIndex = 225;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(213, 18);
            Label6.Name = "Label6";
            Label6.Size = new Size(88, 13);
            Label6.TabIndex = 261;
            Label6.Text = "Código Paciente:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(253, 190);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(60, 20);
            txtPeso.TabIndex = 230;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(471, 193);
            Label5.Name = "Label5";
            Label5.Size = new Size(21, 13);
            Label5.TabIndex = 260;
            Label5.Text = "cm";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(319, 193);
            Label4.Name = "Label4";
            Label4.Size = new Size(20, 13);
            Label4.TabIndex = 259;
            Label4.Text = "Kg";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(405, 190);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(60, 20);
            txtAltura.TabIndex = 231;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(362, 193);
            Label3.Name = "Label3";
            Label3.Size = new Size(37, 13);
            Label3.TabIndex = 258;
            Label3.Text = "Altura:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(213, 193);
            Label2.Name = "Label2";
            Label2.Size = new Size(34, 13);
            Label2.TabIndex = 257;
            Label2.Text = "Peso:";
            // 
            // btnExcluir
            // 
            _btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnExcluir.Image = My.Resources.Resources.DeleteRed;
            _btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            _btnExcluir.Location = new Point(695, 459);
            _btnExcluir.Name = "_btnExcluir";
            _btnExcluir.Size = new Size(89, 30);
            _btnExcluir.TabIndex = 242;
            _btnExcluir.Text = "Excluir";
            _btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            _btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnSalvar.Image = My.Resources.Resources.mvtSaveGreen_16;
            _btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            _btnSalvar.Location = new Point(600, 459);
            _btnSalvar.Name = "_btnSalvar";
            _btnSalvar.Size = new Size(89, 30);
            _btnSalvar.TabIndex = 241;
            _btnSalvar.Text = "Salvar";
            _btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(675, 246);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(60, 20);
            txtNumero.TabIndex = 234;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(645, 249);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(22, 13);
            lblNum.TabIndex = 256;
            lblNum.Text = "Nº:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(324, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 20);
            txtEmail.TabIndex = 229;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(213, 156);
            Label1.Name = "Label1";
            Label1.Size = new Size(38, 13);
            Label1.TabIndex = 255;
            Label1.Text = "E-mail:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(101, 344);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(634, 20);
            txtComplemento.TabIndex = 238;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(18, 347);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(74, 13);
            lblComplemento.TabIndex = 254;
            lblComplemento.Text = "Complemento:";
            // 
            // txtUF
            // 
            txtUF.Enabled = false;
            txtUF.Location = new Point(675, 296);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(60, 20);
            txtUF.TabIndex = 237;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(645, 299);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(24, 13);
            lblUF.TabIndex = 253;
            lblUF.Text = "UF:";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(332, 393);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(180, 20);
            txtCelular.TabIndex = 240;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(284, 396);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(42, 13);
            lblCelular.TabIndex = 252;
            lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(76, 393);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(180, 20);
            txtTelefone.TabIndex = 239;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(18, 396);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 13);
            lblTelefone.TabIndex = 251;
            lblTelefone.Text = "Telefone:";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Enabled = false;
            txtMunicipio.Location = new Point(447, 296);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(180, 20);
            txtMunicipio.TabIndex = 236;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(384, 299);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(57, 13);
            lblMunicipio.TabIndex = 250;
            lblMunicipio.Text = "Município:";
            // 
            // txtCEP
            // 
            _txtCEP.Location = new Point(61, 246);
            _txtCEP.Name = "_txtCEP";
            _txtCEP.Size = new Size(124, 20);
            _txtCEP.TabIndex = 232;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(18, 249);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 13);
            lblCEP.TabIndex = 249;
            lblCEP.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(61, 296);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(315, 20);
            txtBairro.TabIndex = 235;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(18, 299);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(37, 13);
            lblBairro.TabIndex = 248;
            lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            txtEndereco.Enabled = false;
            txtEndereco.Location = new Point(275, 246);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(352, 20);
            txtEndereco.TabIndex = 233;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(213, 249);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 13);
            lblEndereco.TabIndex = 247;
            lblEndereco.Text = "Endereço:";
            // 
            // txtDtNasc
            // 
            txtDtNasc.Location = new Point(324, 118);
            txtDtNasc.Name = "txtDtNasc";
            txtDtNasc.Size = new Size(100, 20);
            txtDtNasc.TabIndex = 228;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(213, 121);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(105, 13);
            lblDataNascimento.TabIndex = 246;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(324, 82);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 20);
            txtCPF.TabIndex = 227;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(213, 85);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(30, 13);
            lblCPF.TabIndex = 245;
            lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(324, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(328, 20);
            txtNome.TabIndex = 226;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.default_user;
            PictureBox1.Location = new Point(7, 2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(195, 208);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 244;
            PictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(213, 49);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 13);
            lblNome.TabIndex = 243;
            lblNome.Text = "Nome Completo:";
            // 
            // tbConsulta
            // 
            _tbConsulta.Controls.Add(_txtNomePaciente);
            _tbConsulta.Controls.Add(lblNomePaciente);
            _tbConsulta.Controls.Add(_dtgConsultaPacientes);
            _tbConsulta.Location = new Point(4, 22);
            _tbConsulta.Name = "_tbConsulta";
            _tbConsulta.Padding = new Padding(3);
            _tbConsulta.Size = new Size(790, 491);
            _tbConsulta.TabIndex = 1;
            _tbConsulta.Text = "Consulta";
            _tbConsulta.UseVisualStyleBackColor = true;
            // 
            // txtNomePaciente
            // 
            _txtNomePaciente.Location = new Point(50, 12);
            _txtNomePaciente.Name = "_txtNomePaciente";
            _txtNomePaciente.Size = new Size(734, 20);
            _txtNomePaciente.TabIndex = 2;
            // 
            // lblNomePaciente
            // 
            lblNomePaciente.AutoSize = true;
            lblNomePaciente.Location = new Point(6, 15);
            lblNomePaciente.Name = "lblNomePaciente";
            lblNomePaciente.Size = new Size(38, 13);
            lblNomePaciente.TabIndex = 1;
            lblNomePaciente.Text = "Nome:";
            // 
            // dtgConsultaPacientes
            // 
            _dtgConsultaPacientes.BackgroundColor = Color.White;
            _dtgConsultaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dtgConsultaPacientes.Location = new Point(6, 38);
            _dtgConsultaPacientes.Name = "_dtgConsultaPacientes";
            _dtgConsultaPacientes.Size = new Size(777, 452);
            _dtgConsultaPacientes.TabIndex = 0;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 523);
            Controls.Add(tbPaciente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPaciente";
            Text = "Pacientes";
            tbPaciente.ResumeLayout(false);
            tbCadastro.ResumeLayout(false);
            tbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            _tbConsulta.ResumeLayout(false);
            _tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dtgConsultaPacientes).EndInit();
            ResumeLayout(false);
        }

        internal TabControl tbPaciente;
        internal TabPage tbCadastro;
        internal Button Button1;
        internal TextBox TextBox18;
        private Button _btnProcurarPaciente;

        internal Button btnProcurarPaciente
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnProcurarPaciente;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnProcurarPaciente != null)
                {
                    _btnProcurarPaciente.Click -= btnProcurarPaciente_Click;
                }

                _btnProcurarPaciente = value;
                if (_btnProcurarPaciente != null)
                {
                    _btnProcurarPaciente.Click += btnProcurarPaciente_Click;
                }
            }
        }

        internal Label Label24;
        internal TextBox txtCodPaciente;
        internal TextBox TextBox17;
        internal Label Label6;
        internal Label Label23;
        internal TextBox txtPeso;
        internal Label Label22;
        internal Label Label5;
        internal TextBox TextBox16;
        internal Label Label4;
        internal Label Label21;
        internal TextBox txtAltura;
        internal Label Label20;
        internal Label Label3;
        internal Label Label2;
        private Button _btnExcluir;

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
        private Button _btnSalvar;

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
        private TabPage _tbConsulta;

        internal TabPage tbConsulta
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbConsulta;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbConsulta != null)
                {
                    _tbConsulta.Enter -= tbConsulta_Enter;
                }

                _tbConsulta = value;
                if (_tbConsulta != null)
                {
                    _tbConsulta.Enter += tbConsulta_Enter;
                }
            }
        }

        private DataGridView _dtgConsultaPacientes;

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

        private TextBox _txtNomePaciente;

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
    }
}