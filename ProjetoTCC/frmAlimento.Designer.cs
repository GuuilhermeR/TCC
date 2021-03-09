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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimento));
            this.tbAlimento = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCalcio = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtVitC = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtFerro = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtProteina = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtLipidio = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCarboidrato = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtKCal = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtMedidaCaseira = new System.Windows.Forms.TextBox();
            this.lblMedidaCaseira = new System.Windows.Forms.Label();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.btnProcurarAlimento = new System.Windows.Forms.Button();
            this.txtCodAlimento = new System.Windows.Forms.TextBox();
            this.lblCodAlimento = new System.Windows.Forms.Label();
            this._tbConsulta = new System.Windows.Forms.TabPage();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtAlimentoFiltro = new System.Windows.Forms.TextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.dtgConAlimento = new System.Windows.Forms.DataGridView();
            this.tbImportarPlanilha = new System.Windows.Forms.TabPage();
            this.pbCarregando = new System.Windows.Forms.ProgressBar();
            this.txtNomeTabela = new System.Windows.Forms.TextBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this._cbxNomePlanilha = new System.Windows.Forms.ComboBox();
            this._btnImportar = new System.Windows.Forms.Button();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this._btnBuscarPlanilha = new System.Windows.Forms.Button();
            this.txtCaminhoArquivoExcel = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.tbAlimento.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this._tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).BeginInit();
            this.tbImportarPlanilha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAlimento
            // 
            this.tbAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlimento.Controls.Add(this.tbCadastro);
            this.tbAlimento.Controls.Add(this._tbConsulta);
            this.tbAlimento.Controls.Add(this.tbImportarPlanilha);
            this.tbAlimento.Location = new System.Drawing.Point(3, 3);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.SelectedIndex = 0;
            this.tbAlimento.Size = new System.Drawing.Size(810, 544);
            this.tbAlimento.TabIndex = 0;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.btnExcluir);
            this.tbCadastro.Controls.Add(this.btnSalvar);
            this.tbCadastro.Controls.Add(this.txtCalcio);
            this.tbCadastro.Controls.Add(this.Label7);
            this.tbCadastro.Controls.Add(this.txtVitC);
            this.tbCadastro.Controls.Add(this.Label8);
            this.tbCadastro.Controls.Add(this.txtFerro);
            this.tbCadastro.Controls.Add(this.Label9);
            this.tbCadastro.Controls.Add(this.txtProteina);
            this.tbCadastro.Controls.Add(this.Label4);
            this.tbCadastro.Controls.Add(this.txtLipidio);
            this.tbCadastro.Controls.Add(this.Label5);
            this.tbCadastro.Controls.Add(this.txtCarboidrato);
            this.tbCadastro.Controls.Add(this.Label6);
            this.tbCadastro.Controls.Add(this.txtQtde);
            this.tbCadastro.Controls.Add(this.lblQuantidade);
            this.tbCadastro.Controls.Add(this.txtKCal);
            this.tbCadastro.Controls.Add(this.Label2);
            this.tbCadastro.Controls.Add(this.txtMedidaCaseira);
            this.tbCadastro.Controls.Add(this.lblMedidaCaseira);
            this.tbCadastro.Controls.Add(this.txtAlimento);
            this.tbCadastro.Controls.Add(this.lblAlimento);
            this.tbCadastro.Controls.Add(this.btnProcurarAlimento);
            this.tbCadastro.Controls.Add(this.txtCodAlimento);
            this.tbCadastro.Controls.Add(this.lblCodAlimento);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(802, 518);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Image = global::ProjetoTCC.My.Resources.Resources.DeleteRed;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(707, 482);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Image = global::ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(612, 482);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCalcio
            // 
            this.txtCalcio.Location = new System.Drawing.Point(546, 246);
            this.txtCalcio.Name = "txtCalcio";
            this.txtCalcio.Size = new System.Drawing.Size(79, 20);
            this.txtCalcio.TabIndex = 47;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(450, 249);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(62, 13);
            this.Label7.TabIndex = 46;
            this.Label7.Text = "Cálcio (mg):";
            // 
            // txtVitC
            // 
            this.txtVitC.Location = new System.Drawing.Point(546, 317);
            this.txtVitC.Name = "txtVitC";
            this.txtVitC.Size = new System.Drawing.Size(79, 20);
            this.txtVitC.TabIndex = 45;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(450, 320);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 13);
            this.Label8.TabIndex = 44;
            this.Label8.Text = "Vitamina C:";
            // 
            // txtFerro
            // 
            this.txtFerro.Location = new System.Drawing.Point(546, 281);
            this.txtFerro.Name = "txtFerro";
            this.txtFerro.Size = new System.Drawing.Size(79, 20);
            this.txtFerro.TabIndex = 43;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(450, 284);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(57, 13);
            this.Label9.TabIndex = 42;
            this.Label9.Text = "Ferro (mg):";
            // 
            // txtProteina
            // 
            this.txtProteina.Location = new System.Drawing.Point(546, 143);
            this.txtProteina.Name = "txtProteina";
            this.txtProteina.Size = new System.Drawing.Size(79, 20);
            this.txtProteina.TabIndex = 41;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(450, 146);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 13);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Proteína (g):";
            // 
            // txtLipidio
            // 
            this.txtLipidio.Location = new System.Drawing.Point(546, 214);
            this.txtLipidio.Name = "txtLipidio";
            this.txtLipidio.Size = new System.Drawing.Size(79, 20);
            this.txtLipidio.TabIndex = 39;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(450, 217);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 13);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Lipídio (g):";
            // 
            // txtCarboidrato
            // 
            this.txtCarboidrato.Location = new System.Drawing.Point(546, 178);
            this.txtCarboidrato.Name = "txtCarboidrato";
            this.txtCarboidrato.Size = new System.Drawing.Size(79, 20);
            this.txtCarboidrato.TabIndex = 37;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(450, 181);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(79, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Carboidrato (g):";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(139, 175);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(79, 20);
            this.txtQtde.TabIndex = 35;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(43, 178);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 34;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtKCal
            // 
            this.txtKCal.Location = new System.Drawing.Point(139, 246);
            this.txtKCal.Name = "txtKCal";
            this.txtKCal.Size = new System.Drawing.Size(79, 20);
            this.txtKCal.TabIndex = 33;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(43, 249);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "KCal:";
            // 
            // txtMedidaCaseira
            // 
            this.txtMedidaCaseira.Location = new System.Drawing.Point(139, 210);
            this.txtMedidaCaseira.Name = "txtMedidaCaseira";
            this.txtMedidaCaseira.Size = new System.Drawing.Size(79, 20);
            this.txtMedidaCaseira.TabIndex = 31;
            // 
            // lblMedidaCaseira
            // 
            this.lblMedidaCaseira.AutoSize = true;
            this.lblMedidaCaseira.Location = new System.Drawing.Point(43, 213);
            this.lblMedidaCaseira.Name = "lblMedidaCaseira";
            this.lblMedidaCaseira.Size = new System.Drawing.Size(83, 13);
            this.lblMedidaCaseira.TabIndex = 30;
            this.lblMedidaCaseira.Text = "Medida Caseira:";
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(106, 72);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(242, 20);
            this.txtAlimento.TabIndex = 29;
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Location = new System.Drawing.Point(26, 75);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(50, 13);
            this.lblAlimento.TabIndex = 28;
            this.lblAlimento.Text = "Alimento:";
            // 
            // btnProcurarAlimento
            // 
            this.btnProcurarAlimento.Image = global::ProjetoTCC.My.Resources.Resources.consultar;
            this.btnProcurarAlimento.Location = new System.Drawing.Point(192, 25);
            this.btnProcurarAlimento.Name = "btnProcurarAlimento";
            this.btnProcurarAlimento.Size = new System.Drawing.Size(30, 23);
            this.btnProcurarAlimento.TabIndex = 27;
            this.btnProcurarAlimento.UseVisualStyleBackColor = true;
            this.btnProcurarAlimento.Click += new System.EventHandler(this.btnProcurarAlimento_Click);
            // 
            // txtCodAlimento
            // 
            this.txtCodAlimento.Location = new System.Drawing.Point(107, 27);
            this.txtCodAlimento.Name = "txtCodAlimento";
            this.txtCodAlimento.Size = new System.Drawing.Size(79, 20);
            this.txtCodAlimento.TabIndex = 26;
            // 
            // lblCodAlimento
            // 
            this.lblCodAlimento.AutoSize = true;
            this.lblCodAlimento.Location = new System.Drawing.Point(26, 30);
            this.lblCodAlimento.Name = "lblCodAlimento";
            this.lblCodAlimento.Size = new System.Drawing.Size(75, 13);
            this.lblCodAlimento.TabIndex = 25;
            this.lblCodAlimento.Text = "Cód. Alimento:";
            // 
            // _tbConsulta
            // 
            this._tbConsulta.Controls.Add(this.cbxTabela);
            this._tbConsulta.Controls.Add(this.label3);
            this._tbConsulta.Controls.Add(this._txtAlimentoFiltro);
            this._tbConsulta.Controls.Add(this.lblTabela);
            this._tbConsulta.Controls.Add(this.dtgConAlimento);
            this._tbConsulta.Location = new System.Drawing.Point(4, 22);
            this._tbConsulta.Name = "_tbConsulta";
            this._tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this._tbConsulta.Size = new System.Drawing.Size(802, 518);
            this._tbConsulta.TabIndex = 1;
            this._tbConsulta.Text = "Consulta";
            this._tbConsulta.UseVisualStyleBackColor = true;
            this._tbConsulta.Enter += new System.EventHandler(this._tbConsulta_Enter);
            // 
            // cbxTabela
            // 
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Location = new System.Drawing.Point(64, 6);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(717, 21);
            this.cbxTabela.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alimento:";
            // 
            // _txtAlimentoFiltro
            // 
            this._txtAlimentoFiltro.Location = new System.Drawing.Point(64, 38);
            this._txtAlimentoFiltro.Name = "_txtAlimentoFiltro";
            this._txtAlimentoFiltro.Size = new System.Drawing.Size(717, 20);
            this._txtAlimentoFiltro.TabIndex = 3;
            this._txtAlimentoFiltro.Leave += new System.EventHandler(this._txtAlimentoFiltro_Leave);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(6, 9);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(43, 13);
            this.lblTabela.TabIndex = 2;
            this.lblTabela.Text = "Tabela:";
            // 
            // dtgConAlimento
            // 
            this.dtgConAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConAlimento.BackgroundColor = System.Drawing.Color.White;
            this.dtgConAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConAlimento.Location = new System.Drawing.Point(6, 64);
            this.dtgConAlimento.Name = "dtgConAlimento";
            this.dtgConAlimento.Size = new System.Drawing.Size(775, 428);
            this.dtgConAlimento.TabIndex = 0;
            // 
            // tbImportarPlanilha
            // 
            this.tbImportarPlanilha.Controls.Add(this.pbCarregando);
            this.tbImportarPlanilha.Controls.Add(this.txtNomeTabela);
            this.tbImportarPlanilha.Controls.Add(this.lblNomeTabela);
            this.tbImportarPlanilha.Controls.Add(this._cbxNomePlanilha);
            this.tbImportarPlanilha.Controls.Add(this._btnImportar);
            this.tbImportarPlanilha.Controls.Add(this.dtgDados);
            this.tbImportarPlanilha.Controls.Add(this._btnBuscarPlanilha);
            this.tbImportarPlanilha.Controls.Add(this.txtCaminhoArquivoExcel);
            this.tbImportarPlanilha.Controls.Add(this.Label10);
            this.tbImportarPlanilha.Controls.Add(this.lblCaminho);
            this.tbImportarPlanilha.Location = new System.Drawing.Point(4, 22);
            this.tbImportarPlanilha.Name = "tbImportarPlanilha";
            this.tbImportarPlanilha.Padding = new System.Windows.Forms.Padding(3);
            this.tbImportarPlanilha.Size = new System.Drawing.Size(802, 518);
            this.tbImportarPlanilha.TabIndex = 2;
            this.tbImportarPlanilha.Text = "Importar";
            this.tbImportarPlanilha.UseVisualStyleBackColor = true;
            // 
            // pbCarregando
            // 
            this.pbCarregando.Location = new System.Drawing.Point(9, 482);
            this.pbCarregando.Name = "pbCarregando";
            this.pbCarregando.Size = new System.Drawing.Size(697, 23);
            this.pbCarregando.TabIndex = 273;
            this.pbCarregando.Visible = false;
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Location = new System.Drawing.Point(116, 452);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(503, 20);
            this.txtNomeTabela.TabIndex = 272;
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Location = new System.Drawing.Point(6, 454);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(74, 13);
            this.lblNomeTabela.TabIndex = 271;
            this.lblNomeTabela.Text = "Nome Tabela:";
            // 
            // _cbxNomePlanilha
            // 
            this._cbxNomePlanilha.FormattingEnabled = true;
            this._cbxNomePlanilha.Location = new System.Drawing.Point(116, 420);
            this._cbxNomePlanilha.Name = "_cbxNomePlanilha";
            this._cbxNomePlanilha.Size = new System.Drawing.Size(503, 21);
            this._cbxNomePlanilha.TabIndex = 270;
            this._cbxNomePlanilha.SelectedIndexChanged += new System.EventHandler(this.cbxNomePlanilha_SelectedIndexChanged);
            // 
            // _btnImportar
            // 
            this._btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportar.Location = new System.Drawing.Point(712, 475);
            this._btnImportar.Name = "_btnImportar";
            this._btnImportar.Size = new System.Drawing.Size(84, 30);
            this._btnImportar.TabIndex = 269;
            this._btnImportar.Text = "Importar";
            this._btnImportar.UseVisualStyleBackColor = true;
            this._btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDados.BackgroundColor = System.Drawing.Color.White;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(9, 6);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(787, 379);
            this.dtgDados.TabIndex = 268;
            // 
            // _btnBuscarPlanilha
            // 
            this._btnBuscarPlanilha.Image = global::ProjetoTCC.My.Resources.Resources.consultar;
            this._btnBuscarPlanilha.Location = new System.Drawing.Point(751, 390);
            this._btnBuscarPlanilha.Name = "_btnBuscarPlanilha";
            this._btnBuscarPlanilha.Size = new System.Drawing.Size(30, 23);
            this._btnBuscarPlanilha.TabIndex = 266;
            this._btnBuscarPlanilha.UseVisualStyleBackColor = true;
            this._btnBuscarPlanilha.Click += new System.EventHandler(this.btnBuscarPlanilha_Click);
            // 
            // txtCaminhoArquivoExcel
            // 
            this.txtCaminhoArquivoExcel.Location = new System.Drawing.Point(116, 391);
            this.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            this.txtCaminhoArquivoExcel.ReadOnly = true;
            this.txtCaminhoArquivoExcel.Size = new System.Drawing.Size(629, 20);
            this.txtCaminhoArquivoExcel.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 423);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 13);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Nome da planilha:";
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(6, 393);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(104, 13);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "Caminho do arquivo:";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // frmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 550);
            this.Controls.Add(this.tbAlimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlimento";
            this.Text = "Alimento";
            this.tbAlimento.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            this._tbConsulta.ResumeLayout(false);
            this._tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).EndInit();
            this.tbImportarPlanilha.ResumeLayout(false);
            this.tbImportarPlanilha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);

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

        internal DataGridView dtgConAlimento;
        internal Label lblTabela;



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
        private ProgressBar pbCarregando;
        internal Label label3;
        private TextBox _txtAlimentoFiltro;
        private ComboBox cbxTabela;
    }
}