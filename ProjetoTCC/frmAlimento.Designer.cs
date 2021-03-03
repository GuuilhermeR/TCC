using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmAlimento : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimento));
            tbAlimento = new TabControl();
            tbCadastro = new TabPage();
            btnExcluir = new Button();
            btnSalvar = new Button();
            txtCalcio = new TextBox();
            Label7 = new Label();
            txtVitC = new TextBox();
            Label8 = new Label();
            txtFerro = new TextBox();
            Label9 = new Label();
            txtProteina = new TextBox();
            Label4 = new Label();
            txtLipidio = new TextBox();
            Label5 = new Label();
            txtCarboidrato = new TextBox();
            Label6 = new Label();
            txtQtde = new TextBox();
            lblQuantidade = new Label();
            txtKCal = new TextBox();
            Label2 = new Label();
            txtMedidaCaseira = new TextBox();
            lblMedidaCaseira = new Label();
            txtAlimento = new TextBox();
            lblAlimento = new Label();
            btnProcurarAlimento = new Button();
            txtCodAlimento = new TextBox();
            lblCodAlimento = new Label();
            _tbConsulta = new TabPage();
            _tbConsulta.Click += new EventHandler(tbConsulta_Click);
            Label1 = new Label();
            _txtAlimentoFiltro = new TextBox();
            _txtAlimentoFiltro.Leave += new EventHandler(txtAlimentoFiltro_Leave);
            dtgConAlimento = new DataGridView();
            tbImportarPlanilha = new TabPage();
            _cbxNomePlanilha = new ComboBox();
            _cbxNomePlanilha.SelectedIndexChanged += new EventHandler(cbxNomePlanilha_SelectedIndexChanged);
            _btnImportar = new Button();
            _btnImportar.Click += new EventHandler(btnImportar_Click);
            dtgDados = new DataGridView();
            _btnBuscarPlanilha = new Button();
            _btnBuscarPlanilha.Click += new EventHandler(btnBuscarPlanilha_Click);
            txtCaminhoArquivoExcel = new TextBox();
            Label10 = new Label();
            lblCaminho = new Label();
            ofd1 = new OpenFileDialog();
            txtNomeTabela = new TextBox();
            lblNomeTabela = new Label();
            tbAlimento.SuspendLayout();
            tbCadastro.SuspendLayout();
            _tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgConAlimento).BeginInit();
            tbImportarPlanilha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDados).BeginInit();
            SuspendLayout();
            // 
            // tbAlimento
            // 
            tbAlimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            tbAlimento.Controls.Add(tbCadastro);
            tbAlimento.Controls.Add(_tbConsulta);
            tbAlimento.Controls.Add(tbImportarPlanilha);
            tbAlimento.Location = new Point(3, 3);
            tbAlimento.Name = "tbAlimento";
            tbAlimento.SelectedIndex = 0;
            tbAlimento.Size = new Size(795, 524);
            tbAlimento.TabIndex = 0;
            // 
            // tbCadastro
            // 
            tbCadastro.Controls.Add(btnExcluir);
            tbCadastro.Controls.Add(btnSalvar);
            tbCadastro.Controls.Add(txtCalcio);
            tbCadastro.Controls.Add(Label7);
            tbCadastro.Controls.Add(txtVitC);
            tbCadastro.Controls.Add(Label8);
            tbCadastro.Controls.Add(txtFerro);
            tbCadastro.Controls.Add(Label9);
            tbCadastro.Controls.Add(txtProteina);
            tbCadastro.Controls.Add(Label4);
            tbCadastro.Controls.Add(txtLipidio);
            tbCadastro.Controls.Add(Label5);
            tbCadastro.Controls.Add(txtCarboidrato);
            tbCadastro.Controls.Add(Label6);
            tbCadastro.Controls.Add(txtQtde);
            tbCadastro.Controls.Add(lblQuantidade);
            tbCadastro.Controls.Add(txtKCal);
            tbCadastro.Controls.Add(Label2);
            tbCadastro.Controls.Add(txtMedidaCaseira);
            tbCadastro.Controls.Add(lblMedidaCaseira);
            tbCadastro.Controls.Add(txtAlimento);
            tbCadastro.Controls.Add(lblAlimento);
            tbCadastro.Controls.Add(btnProcurarAlimento);
            tbCadastro.Controls.Add(txtCodAlimento);
            tbCadastro.Controls.Add(lblCodAlimento);
            tbCadastro.Location = new Point(4, 22);
            tbCadastro.Name = "tbCadastro";
            tbCadastro.Padding = new Padding(3);
            tbCadastro.Size = new Size(787, 498);
            tbCadastro.TabIndex = 0;
            tbCadastro.Text = "Cadastro";
            tbCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Image = My.Resources.Resources.DeleteRed;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(692, 462);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(89, 30);
            btnExcluir.TabIndex = 49;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Image = My.Resources.Resources.mvtSaveGreen_16;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(597, 462);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(89, 30);
            btnSalvar.TabIndex = 48;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtCalcio
            // 
            txtCalcio.Location = new Point(546, 246);
            txtCalcio.Name = "txtCalcio";
            txtCalcio.Size = new Size(79, 20);
            txtCalcio.TabIndex = 47;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(450, 249);
            Label7.Name = "Label7";
            Label7.Size = new Size(62, 13);
            Label7.TabIndex = 46;
            Label7.Text = "Cálcio (mg):";
            // 
            // txtVitC
            // 
            txtVitC.Location = new Point(546, 317);
            txtVitC.Name = "txtVitC";
            txtVitC.Size = new Size(79, 20);
            txtVitC.TabIndex = 45;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(450, 320);
            Label8.Name = "Label8";
            Label8.Size = new Size(60, 13);
            Label8.TabIndex = 44;
            Label8.Text = "Vitamina C:";
            // 
            // txtFerro
            // 
            txtFerro.Location = new Point(546, 281);
            txtFerro.Name = "txtFerro";
            txtFerro.Size = new Size(79, 20);
            txtFerro.TabIndex = 43;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(450, 284);
            Label9.Name = "Label9";
            Label9.Size = new Size(57, 13);
            Label9.TabIndex = 42;
            Label9.Text = "Ferro (mg):";
            // 
            // txtProteina
            // 
            txtProteina.Location = new Point(546, 143);
            txtProteina.Name = "txtProteina";
            txtProteina.Size = new Size(79, 20);
            txtProteina.TabIndex = 41;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(450, 146);
            Label4.Name = "Label4";
            Label4.Size = new Size(66, 13);
            Label4.TabIndex = 40;
            Label4.Text = "Proteína (g):";
            // 
            // txtLipidio
            // 
            txtLipidio.Location = new Point(546, 214);
            txtLipidio.Name = "txtLipidio";
            txtLipidio.Size = new Size(79, 20);
            txtLipidio.TabIndex = 39;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(450, 217);
            Label5.Name = "Label5";
            Label5.Size = new Size(57, 13);
            Label5.TabIndex = 38;
            Label5.Text = "Lipídio (g):";
            // 
            // txtCarboidrato
            // 
            txtCarboidrato.Location = new Point(546, 178);
            txtCarboidrato.Name = "txtCarboidrato";
            txtCarboidrato.Size = new Size(79, 20);
            txtCarboidrato.TabIndex = 37;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(450, 181);
            Label6.Name = "Label6";
            Label6.Size = new Size(79, 13);
            Label6.TabIndex = 36;
            Label6.Text = "Carboidrato (g):";
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(139, 175);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(79, 20);
            txtQtde.TabIndex = 35;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(43, 178);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(62, 13);
            lblQuantidade.TabIndex = 34;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtKCal
            // 
            txtKCal.Location = new Point(139, 246);
            txtKCal.Name = "txtKCal";
            txtKCal.Size = new Size(79, 20);
            txtKCal.TabIndex = 33;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(43, 249);
            Label2.Name = "Label2";
            Label2.Size = new Size(32, 13);
            Label2.TabIndex = 32;
            Label2.Text = "KCal:";
            // 
            // txtMedidaCaseira
            // 
            txtMedidaCaseira.Location = new Point(139, 210);
            txtMedidaCaseira.Name = "txtMedidaCaseira";
            txtMedidaCaseira.Size = new Size(79, 20);
            txtMedidaCaseira.TabIndex = 31;
            // 
            // lblMedidaCaseira
            // 
            lblMedidaCaseira.AutoSize = true;
            lblMedidaCaseira.Location = new Point(43, 213);
            lblMedidaCaseira.Name = "lblMedidaCaseira";
            lblMedidaCaseira.Size = new Size(83, 13);
            lblMedidaCaseira.TabIndex = 30;
            lblMedidaCaseira.Text = "Medida Caseira:";
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(106, 72);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(242, 20);
            txtAlimento.TabIndex = 29;
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(26, 75);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(50, 13);
            lblAlimento.TabIndex = 28;
            lblAlimento.Text = "Alimento:";
            // 
            // btnProcurarAlimento
            // 
            btnProcurarAlimento.Image = My.Resources.Resources.consultar;
            btnProcurarAlimento.Location = new Point(192, 25);
            btnProcurarAlimento.Name = "btnProcurarAlimento";
            btnProcurarAlimento.Size = new Size(30, 23);
            btnProcurarAlimento.TabIndex = 27;
            btnProcurarAlimento.UseVisualStyleBackColor = true;
            // 
            // txtCodAlimento
            // 
            txtCodAlimento.Location = new Point(107, 27);
            txtCodAlimento.Name = "txtCodAlimento";
            txtCodAlimento.Size = new Size(79, 20);
            txtCodAlimento.TabIndex = 26;
            // 
            // lblCodAlimento
            // 
            lblCodAlimento.AutoSize = true;
            lblCodAlimento.Location = new Point(26, 30);
            lblCodAlimento.Name = "lblCodAlimento";
            lblCodAlimento.Size = new Size(75, 13);
            lblCodAlimento.TabIndex = 25;
            lblCodAlimento.Text = "Cód. Alimento:";
            // 
            // tbConsulta
            // 
            _tbConsulta.Controls.Add(Label1);
            _tbConsulta.Controls.Add(_txtAlimentoFiltro);
            _tbConsulta.Controls.Add(dtgConAlimento);
            _tbConsulta.Location = new Point(4, 22);
            _tbConsulta.Name = "_tbConsulta";
            _tbConsulta.Padding = new Padding(3);
            _tbConsulta.Size = new Size(787, 498);
            _tbConsulta.TabIndex = 1;
            _tbConsulta.Text = "Consulta";
            _tbConsulta.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(50, 13);
            Label1.TabIndex = 2;
            Label1.Text = "Alimento:";
            // 
            // txtAlimentoFiltro
            // 
            _txtAlimentoFiltro.Location = new Point(64, 6);
            _txtAlimentoFiltro.Name = "_txtAlimentoFiltro";
            _txtAlimentoFiltro.Size = new Size(717, 20);
            _txtAlimentoFiltro.TabIndex = 1;
            // 
            // dtgConAlimento
            // 
            dtgConAlimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtgConAlimento.BackgroundColor = Color.White;
            dtgConAlimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgConAlimento.Location = new Point(6, 32);
            dtgConAlimento.Name = "dtgConAlimento";
            dtgConAlimento.Size = new Size(775, 460);
            dtgConAlimento.TabIndex = 0;
            // 
            // tbImportarPlanilha
            // 
            tbImportarPlanilha.Controls.Add(txtNomeTabela);
            tbImportarPlanilha.Controls.Add(lblNomeTabela);
            tbImportarPlanilha.Controls.Add(_cbxNomePlanilha);
            tbImportarPlanilha.Controls.Add(_btnImportar);
            tbImportarPlanilha.Controls.Add(dtgDados);
            tbImportarPlanilha.Controls.Add(_btnBuscarPlanilha);
            tbImportarPlanilha.Controls.Add(txtCaminhoArquivoExcel);
            tbImportarPlanilha.Controls.Add(Label10);
            tbImportarPlanilha.Controls.Add(lblCaminho);
            tbImportarPlanilha.Location = new Point(4, 22);
            tbImportarPlanilha.Name = "tbImportarPlanilha";
            tbImportarPlanilha.Padding = new Padding(3);
            tbImportarPlanilha.Size = new Size(787, 498);
            tbImportarPlanilha.TabIndex = 2;
            tbImportarPlanilha.Text = "Importar";
            tbImportarPlanilha.UseVisualStyleBackColor = true;
            // 
            // cbxNomePlanilha
            // 
            _cbxNomePlanilha.FormattingEnabled = true;
            _cbxNomePlanilha.Location = new Point(116, 459);
            _cbxNomePlanilha.Name = "_cbxNomePlanilha";
            _cbxNomePlanilha.Size = new Size(315, 21);
            _cbxNomePlanilha.TabIndex = 270;
            // 
            // btnImportar
            // 
            _btnImportar.Location = new Point(697, 462);
            _btnImportar.Name = "_btnImportar";
            _btnImportar.Size = new Size(84, 30);
            _btnImportar.TabIndex = 269;
            _btnImportar.Text = "Importar";
            _btnImportar.UseVisualStyleBackColor = true;
            // 
            // dtgDados
            // 
            dtgDados.AllowUserToAddRows = false;
            dtgDados.BackgroundColor = Color.White;
            dtgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDados.Location = new Point(9, 6);
            dtgDados.Name = "dtgDados";
            dtgDados.Size = new Size(772, 377);
            dtgDados.TabIndex = 268;
            // 
            // btnBuscarPlanilha
            // 
            _btnBuscarPlanilha.Image = My.Resources.Resources.consultar;
            _btnBuscarPlanilha.Location = new Point(751, 390);
            _btnBuscarPlanilha.Name = "_btnBuscarPlanilha";
            _btnBuscarPlanilha.Size = new Size(30, 23);
            _btnBuscarPlanilha.TabIndex = 266;
            _btnBuscarPlanilha.UseVisualStyleBackColor = true;
            // 
            // txtCaminhoArquivoExcel
            // 
            txtCaminhoArquivoExcel.Location = new Point(116, 391);
            txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            txtCaminhoArquivoExcel.Size = new Size(629, 20);
            txtCaminhoArquivoExcel.TabIndex = 2;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(6, 462);
            Label10.Name = "Label10";
            Label10.Size = new Size(92, 13);
            Label10.TabIndex = 1;
            Label10.Text = "Nome da planilha:";
            // 
            // lblCaminho
            // 
            lblCaminho.AutoSize = true;
            lblCaminho.Location = new Point(6, 393);
            lblCaminho.Name = "lblCaminho";
            lblCaminho.Size = new Size(104, 13);
            lblCaminho.TabIndex = 0;
            lblCaminho.Text = "Caminho do arquivo:";
            // 
            // ofd1
            // 
            ofd1.FileName = "ofd1";
            // 
            // txtNomeTabela
            // 
            txtNomeTabela.Location = new Point(116, 425);
            txtNomeTabela.Name = "txtNomeTabela";
            txtNomeTabela.Size = new Size(503, 20);
            txtNomeTabela.TabIndex = 272;
            // 
            // lblNomeTabela
            // 
            lblNomeTabela.AutoSize = true;
            lblNomeTabela.Location = new Point(6, 427);
            lblNomeTabela.Name = "lblNomeTabela";
            lblNomeTabela.Size = new Size(74, 13);
            lblNomeTabela.TabIndex = 271;
            lblNomeTabela.Text = "Nome Tabela:";
            // 
            // frmAlimento
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 530);
            Controls.Add(tbAlimento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAlimento";
            Text = "Alimento";
            tbAlimento.ResumeLayout(false);
            tbCadastro.ResumeLayout(false);
            tbCadastro.PerformLayout();
            _tbConsulta.ResumeLayout(false);
            _tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgConAlimento).EndInit();
            tbImportarPlanilha.ResumeLayout(false);
            tbImportarPlanilha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDados).EndInit();
            ResumeLayout(false);
        }

        internal TabControl tbAlimento;
        internal TabPage tbCadastro;
        internal Button btnExcluir;
        internal Button btnSalvar;
        internal TextBox txtCalcio;
        internal Label Label7;
        internal TextBox txtVitC;
        internal Label Label8;
        internal TextBox txtFerro;
        internal Label Label9;
        internal TextBox txtProteina;
        internal Label Label4;
        internal TextBox txtLipidio;
        internal Label Label5;
        internal TextBox txtCarboidrato;
        internal Label Label6;
        internal TextBox txtQtde;
        internal Label lblQuantidade;
        internal TextBox txtKCal;
        internal Label Label2;
        internal TextBox txtMedidaCaseira;
        internal Label lblMedidaCaseira;
        internal TextBox txtAlimento;
        internal Label lblAlimento;
        internal Button btnProcurarAlimento;
        internal TextBox txtCodAlimento;
        internal Label lblCodAlimento;
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
                    _tbConsulta.Click -= tbConsulta_Click;
                }

                _tbConsulta = value;
                if (_tbConsulta != null)
                {
                    _tbConsulta.Click += tbConsulta_Click;
                }
            }
        }

        internal DataGridView dtgConAlimento;
        internal Label Label1;
        private TextBox _txtAlimentoFiltro;

        internal TextBox txtAlimentoFiltro
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtAlimentoFiltro;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtAlimentoFiltro != null)
                {
                    _txtAlimentoFiltro.Leave -= txtAlimentoFiltro_Leave;
                }

                _txtAlimentoFiltro = value;
                if (_txtAlimentoFiltro != null)
                {
                    _txtAlimentoFiltro.Leave += txtAlimentoFiltro_Leave;
                }
            }
        }

        internal TabPage tbImportarPlanilha;
        internal TextBox txtCaminhoArquivoExcel;
        internal Label Label10;
        internal Label lblCaminho;
        private Button _btnBuscarPlanilha;

        internal Button btnBuscarPlanilha
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnBuscarPlanilha;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnBuscarPlanilha != null)
                {
                    _btnBuscarPlanilha.Click -= btnBuscarPlanilha_Click;
                }

                _btnBuscarPlanilha = value;
                if (_btnBuscarPlanilha != null)
                {
                    _btnBuscarPlanilha.Click += btnBuscarPlanilha_Click;
                }
            }
        }

        internal OpenFileDialog ofd1;
        internal DataGridView dtgDados;
        private Button _btnImportar;

        internal Button btnImportar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnImportar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnImportar != null)
                {
                    _btnImportar.Click -= btnImportar_Click;
                }

                _btnImportar = value;
                if (_btnImportar != null)
                {
                    _btnImportar.Click += btnImportar_Click;
                }
            }
        }

        private ComboBox _cbxNomePlanilha;

        internal ComboBox cbxNomePlanilha
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxNomePlanilha;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxNomePlanilha != null)
                {
                    _cbxNomePlanilha.SelectedIndexChanged -= cbxNomePlanilha_SelectedIndexChanged;
                }

                _cbxNomePlanilha = value;
                if (_cbxNomePlanilha != null)
                {
                    _cbxNomePlanilha.SelectedIndexChanged += cbxNomePlanilha_SelectedIndexChanged;
                }
            }
        }

        internal TextBox txtNomeTabela;
        internal Label lblNomeTabela;
    }
}