﻿using AdvancedDataGridView;

namespace TCC2
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.TabControlNutreasy = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.mCardAtendimentoAtual = new MaterialSkin.Controls.MaterialCard();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.mcbxCancelar = new MaterialSkin.Controls.MaterialCheckbox();
            this.mcbxAtendido = new MaterialSkin.Controls.MaterialCheckbox();
            this.mlblObservação = new MaterialSkin.Controls.MaterialLabel();
            this.mlblHorario = new MaterialSkin.Controls.MaterialLabel();
            this.mlblNome = new MaterialSkin.Controls.MaterialLabel();
            this.mCardAtendimentoFuturo = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.mcbxCancelarFuturo = new MaterialSkin.Controls.MaterialCheckbox();
            this.mcbxAtendidoFuturo = new MaterialSkin.Controls.MaterialCheckbox();
            this.mlblObservacaoFuturo = new MaterialSkin.Controls.MaterialLabel();
            this.mlblHoraFutura = new MaterialSkin.Controls.MaterialLabel();
            this.mlblNomeFuturo = new MaterialSkin.Controls.MaterialLabel();
            this.pbxLogoGrande = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.btnSalvarAgenda = new System.Windows.Forms.Button();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retorno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAvançar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabAlimento = new System.Windows.Forms.TabPage();
            this.tbAlimento = new System.Windows.Forms.TabControl();
            this._tbConsulta = new System.Windows.Forms.TabPage();
            this.btnCancelarEditAlimentos = new System.Windows.Forms.Button();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.lblAlimentoFiltro = new System.Windows.Forms.Label();
            this.lblTabelaSelecionada = new System.Windows.Forms.Label();
            this.btnSalvarAlimento = new System.Windows.Forms.Button();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlimentoFiltro = new System.Windows.Forms.TextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.dtgConAlimento = new System.Windows.Forms.DataGridView();
            this.tbImportarPlanilha = new System.Windows.Forms.TabPage();
            this.txtNomeTabela = new System.Windows.Forms.TextBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this._cbxNomePlanilha = new System.Windows.Forms.ComboBox();
            this._btnImportar = new System.Windows.Forms.Button();
            this.dtgDadosImportados = new System.Windows.Forms.DataGridView();
            this.txtCaminhoArquivoExcel = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblCaminho = new System.Windows.Forms.Label();
            this._btnBuscarPlanilha = new System.Windows.Forms.Button();
            this.tbCadMedCaseira = new System.Windows.Forms.TabPage();
            this.txtCodAlimentoMedCas = new System.Windows.Forms.TextBox();
            this.dtgSalvarMedCaseira = new System.Windows.Forms.DataGridView();
            this.salvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtdMedCas = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtDescMedCaseira = new System.Windows.Forms.TextBox();
            this.lblDescMedCaseira = new System.Windows.Forms.Label();
            this.txtAlimentoMedCaseira = new System.Windows.Forms.TextBox();
            this.lblAlimentoMedCas = new System.Windows.Forms.Label();
            this.dtgMedCaseiraAlimentos = new System.Windows.Forms.DataGridView();
            this.btnAddMedCaseira = new System.Windows.Forms.Button();
            this.btnSalvarMedCas = new System.Windows.Forms.Button();
            this.tabCardapio = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCadCardapio = new System.Windows.Forms.TabPage();
            this.btnCancelarCardapio = new System.Windows.Forms.Button();
            this.btnConfigGramasCard = new System.Windows.Forms.Button();
            this.txtFiltroAlimento = new System.Windows.Forms.TextBox();
            this.graficoMacroNutri = new LiveCharts.WinForms.PieChart();
            this.btnAddAliCard = new System.Windows.Forms.PictureBox();
            this.cbxRefeicao = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.btnPacienteCardapio = new System.Windows.Forms.Button();
            this.lblValorKcal = new System.Windows.Forms.Label();
            this.lblVlrKcal = new System.Windows.Forms.Label();
            this.lblTabelaCardapio = new System.Windows.Forms.Label();
            this.cbxTabelaAlimentoCardapio = new System.Windows.Forms.ComboBox();
            this.dtgCardapioAlimentos = new System.Windows.Forms.DataGridView();
            this.dtgRefeicoes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvarCardapio = new System.Windows.Forms.Button();
            this.tbConsultaCardapio = new System.Windows.Forms.TabPage();
            this.trwDadosCard = new AdvancedDataGridView.TreeGridView();
            this.txtPacienteConsultaCardapio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this.tbCadastrarTiposCardapios = new System.Windows.Forms.TabPage();
            this.tabPaciente = new System.Windows.Forms.TabPage();
            this.tbPaciente = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCodPaciente = new System.Windows.Forms.Label();
            this.btnCapturarImagem = new System.Windows.Forms.Button();
            this.txtDtNasc = new System.Windows.Forms.DateTimePicker();
            this._dtgConsultaPacientes = new System.Windows.Forms.DataGridView();
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
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbAntropometricos = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnamnese = new System.Windows.Forms.TabPage();
            this.ritchTextBoxWithToolBar1 = new MvtWindowsForms.RitchTextBoxWithToolBar();
            this.tabReceitas = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tbConfig = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmailConfig = new System.Windows.Forms.TextBox();
            this.txtNomeUsuarioConfig = new System.Windows.Forms.TextBox();
            this.txtUsuarioConfig = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnExcluirConfigUsuario = new System.Windows.Forms.Button();
            this.btnSalvarConfigUsuario = new System.Windows.Forms.Button();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.tbPermissao = new System.Windows.Forms.TabPage();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvarPermissao = new System.Windows.Forms.Button();
            this.cbxTelaLiberar = new System.Windows.Forms.ComboBox();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSobre = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabControlNutreasy.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.mCardAtendimentoAtual.SuspendLayout();
            this.mCardAtendimentoFuturo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).BeginInit();
            this.tabAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.tabAlimento.SuspendLayout();
            this.tbAlimento.SuspendLayout();
            this._tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).BeginInit();
            this.tbImportarPlanilha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosImportados)).BeginInit();
            this.tbCadMedCaseira.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalvarMedCaseira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedCaseiraAlimentos)).BeginInit();
            this.tabCardapio.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbCadCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAliCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapioAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).BeginInit();
            this.tbConsultaCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trwDadosCard)).BeginInit();
            this.tabPaciente.SuspendLayout();
            this.tbPaciente.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.tbAntropometricos.SuspendLayout();
            this.tbAnamnese.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.tbPermissao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlNutreasy
            // 
            this.TabControlNutreasy.AllowDrop = true;
            this.TabControlNutreasy.Controls.Add(this.tabMenu);
            this.TabControlNutreasy.Controls.Add(this.tabAgenda);
            this.TabControlNutreasy.Controls.Add(this.tabAlimento);
            this.TabControlNutreasy.Controls.Add(this.tabCardapio);
            this.TabControlNutreasy.Controls.Add(this.tabPaciente);
            this.TabControlNutreasy.Controls.Add(this.tabReceitas);
            this.TabControlNutreasy.Controls.Add(this.tabConfig);
            this.TabControlNutreasy.Controls.Add(this.tbSobre);
            this.TabControlNutreasy.Depth = 0;
            this.TabControlNutreasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlNutreasy.ImageList = this.imageList1;
            this.TabControlNutreasy.Location = new System.Drawing.Point(4, 4);
            this.TabControlNutreasy.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlNutreasy.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlNutreasy.Multiline = true;
            this.TabControlNutreasy.Name = "TabControlNutreasy";
            this.TabControlNutreasy.SelectedIndex = 0;
            this.TabControlNutreasy.Size = new System.Drawing.Size(1649, 993);
            this.TabControlNutreasy.TabIndex = 13;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.mCardAtendimentoAtual);
            this.tabMenu.Controls.Add(this.mCardAtendimentoFuturo);
            this.tabMenu.Controls.Add(this.pbxLogoGrande);
            this.tabMenu.Controls.Add(this.lblUsuario);
            this.tabMenu.ImageKey = "menu32px.png";
            this.tabMenu.Location = new System.Drawing.Point(4, 39);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(4);
            this.tabMenu.Size = new System.Drawing.Size(1641, 950);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Home";
            this.tabMenu.UseVisualStyleBackColor = true;
            this.tabMenu.Click += new System.EventHandler(this.tabMenu_Click);
            this.tabMenu.Enter += new System.EventHandler(this.tabMenu_Enter);
            // 
            // mCardAtendimentoAtual
            // 
            this.mCardAtendimentoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardAtendimentoAtual.Controls.Add(this.materialButton2);
            this.mCardAtendimentoAtual.Controls.Add(this.mcbxCancelar);
            this.mCardAtendimentoAtual.Controls.Add(this.mcbxAtendido);
            this.mCardAtendimentoAtual.Controls.Add(this.mlblObservação);
            this.mCardAtendimentoAtual.Controls.Add(this.mlblHorario);
            this.mCardAtendimentoAtual.Controls.Add(this.mlblNome);
            this.mCardAtendimentoAtual.Depth = 0;
            this.mCardAtendimentoAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardAtendimentoAtual.Location = new System.Drawing.Point(23, 44);
            this.mCardAtendimentoAtual.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.mCardAtendimentoAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoAtual.Name = "mCardAtendimentoAtual";
            this.mCardAtendimentoAtual.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.mCardAtendimentoAtual.Size = new System.Drawing.Size(449, 327);
            this.mCardAtendimentoAtual.TabIndex = 10;
            this.mCardAtendimentoAtual.Visible = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(131, 267);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(167, 36);
            this.materialButton2.TabIndex = 17;
            this.materialButton2.Text = "Lembrar Consulta";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // mcbxCancelar
            // 
            this.mcbxCancelar.AutoSize = true;
            this.mcbxCancelar.Depth = 0;
            this.mcbxCancelar.Location = new System.Drawing.Point(19, 220);
            this.mcbxCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxCancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxCancelar.Name = "mcbxCancelar";
            this.mcbxCancelar.Ripple = true;
            this.mcbxCancelar.Size = new System.Drawing.Size(97, 37);
            this.mcbxCancelar.TabIndex = 14;
            this.mcbxCancelar.Text = "Cancelar";
            this.mcbxCancelar.UseVisualStyleBackColor = true;
            this.mcbxCancelar.CheckedChanged += new System.EventHandler(this.mcbxCancelar_CheckedChanged);
            // 
            // mcbxAtendido
            // 
            this.mcbxAtendido.AutoSize = true;
            this.mcbxAtendido.Depth = 0;
            this.mcbxAtendido.Location = new System.Drawing.Point(19, 155);
            this.mcbxAtendido.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxAtendido.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxAtendido.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxAtendido.Name = "mcbxAtendido";
            this.mcbxAtendido.Ripple = true;
            this.mcbxAtendido.Size = new System.Drawing.Size(98, 37);
            this.mcbxAtendido.TabIndex = 11;
            this.mcbxAtendido.Text = "Atendido";
            this.mcbxAtendido.UseVisualStyleBackColor = true;
            this.mcbxAtendido.CheckedChanged += new System.EventHandler(this.mcbxAtendido_CheckedChanged_1);
            // 
            // mlblObservação
            // 
            this.mlblObservação.AutoSize = true;
            this.mlblObservação.Depth = 0;
            this.mlblObservação.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblObservação.Location = new System.Drawing.Point(23, 119);
            this.mlblObservação.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblObservação.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblObservação.Name = "mlblObservação";
            this.mlblObservação.Size = new System.Drawing.Size(56, 19);
            this.mlblObservação.TabIndex = 13;
            this.mlblObservação.Text = "Retorno";
            // 
            // mlblHorario
            // 
            this.mlblHorario.AutoSize = true;
            this.mlblHorario.Depth = 0;
            this.mlblHorario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblHorario.Location = new System.Drawing.Point(23, 68);
            this.mlblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblHorario.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblHorario.Name = "mlblHorario";
            this.mlblHorario.Size = new System.Drawing.Size(41, 19);
            this.mlblHorario.TabIndex = 12;
            this.mlblHorario.Text = "18:00";
            // 
            // mlblNome
            // 
            this.mlblNome.AutoSize = true;
            this.mlblNome.Depth = 0;
            this.mlblNome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblNome.Location = new System.Drawing.Point(23, 17);
            this.mlblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNome.Name = "mlblNome";
            this.mlblNome.Size = new System.Drawing.Size(73, 19);
            this.mlblNome.TabIndex = 11;
            this.mlblNome.Text = "Guilherme";
            // 
            // mCardAtendimentoFuturo
            // 
            this.mCardAtendimentoFuturo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mCardAtendimentoFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardAtendimentoFuturo.Controls.Add(this.materialButton1);
            this.mCardAtendimentoFuturo.Controls.Add(this.mcbxCancelarFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mcbxAtendidoFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblObservacaoFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblHoraFutura);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblNomeFuturo);
            this.mCardAtendimentoFuturo.Depth = 0;
            this.mCardAtendimentoFuturo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardAtendimentoFuturo.Location = new System.Drawing.Point(1177, 44);
            this.mCardAtendimentoFuturo.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.mCardAtendimentoFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoFuturo.Name = "mCardAtendimentoFuturo";
            this.mCardAtendimentoFuturo.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.mCardAtendimentoFuturo.Size = new System.Drawing.Size(449, 327);
            this.mCardAtendimentoFuturo.TabIndex = 18;
            this.mCardAtendimentoFuturo.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(131, 267);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(167, 36);
            this.materialButton1.TabIndex = 17;
            this.materialButton1.Text = "Lembrar Consulta";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // mcbxCancelarFuturo
            // 
            this.mcbxCancelarFuturo.AutoSize = true;
            this.mcbxCancelarFuturo.Depth = 0;
            this.mcbxCancelarFuturo.Location = new System.Drawing.Point(19, 220);
            this.mcbxCancelarFuturo.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxCancelarFuturo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxCancelarFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxCancelarFuturo.Name = "mcbxCancelarFuturo";
            this.mcbxCancelarFuturo.Ripple = true;
            this.mcbxCancelarFuturo.Size = new System.Drawing.Size(97, 37);
            this.mcbxCancelarFuturo.TabIndex = 14;
            this.mcbxCancelarFuturo.Text = "Cancelar";
            this.mcbxCancelarFuturo.UseVisualStyleBackColor = true;
            this.mcbxCancelarFuturo.CheckedChanged += new System.EventHandler(this.mcbxCancelarFuturo_CheckedChanged);
            // 
            // mcbxAtendidoFuturo
            // 
            this.mcbxAtendidoFuturo.AutoSize = true;
            this.mcbxAtendidoFuturo.Depth = 0;
            this.mcbxAtendidoFuturo.Location = new System.Drawing.Point(19, 155);
            this.mcbxAtendidoFuturo.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxAtendidoFuturo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxAtendidoFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxAtendidoFuturo.Name = "mcbxAtendidoFuturo";
            this.mcbxAtendidoFuturo.Ripple = true;
            this.mcbxAtendidoFuturo.Size = new System.Drawing.Size(98, 37);
            this.mcbxAtendidoFuturo.TabIndex = 11;
            this.mcbxAtendidoFuturo.Text = "Atendido";
            this.mcbxAtendidoFuturo.UseVisualStyleBackColor = true;
            this.mcbxAtendidoFuturo.CheckedChanged += new System.EventHandler(this.mcbxAtendidoFuturo_CheckedChanged);
            // 
            // mlblObservacaoFuturo
            // 
            this.mlblObservacaoFuturo.AutoSize = true;
            this.mlblObservacaoFuturo.Depth = 0;
            this.mlblObservacaoFuturo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblObservacaoFuturo.Location = new System.Drawing.Point(23, 119);
            this.mlblObservacaoFuturo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblObservacaoFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblObservacaoFuturo.Name = "mlblObservacaoFuturo";
            this.mlblObservacaoFuturo.Size = new System.Drawing.Size(56, 19);
            this.mlblObservacaoFuturo.TabIndex = 13;
            this.mlblObservacaoFuturo.Text = "Retorno";
            // 
            // mlblHoraFutura
            // 
            this.mlblHoraFutura.AutoSize = true;
            this.mlblHoraFutura.Depth = 0;
            this.mlblHoraFutura.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblHoraFutura.Location = new System.Drawing.Point(23, 68);
            this.mlblHoraFutura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblHoraFutura.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblHoraFutura.Name = "mlblHoraFutura";
            this.mlblHoraFutura.Size = new System.Drawing.Size(41, 19);
            this.mlblHoraFutura.TabIndex = 12;
            this.mlblHoraFutura.Text = "18:00";
            // 
            // mlblNomeFuturo
            // 
            this.mlblNomeFuturo.AutoSize = true;
            this.mlblNomeFuturo.Depth = 0;
            this.mlblNomeFuturo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblNomeFuturo.Location = new System.Drawing.Point(23, 17);
            this.mlblNomeFuturo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblNomeFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNomeFuturo.Name = "mlblNomeFuturo";
            this.mlblNomeFuturo.Size = new System.Drawing.Size(73, 19);
            this.mlblNomeFuturo.TabIndex = 11;
            this.mlblNomeFuturo.Text = "Guilherme";
            // 
            // pbxLogoGrande
            // 
            this.pbxLogoGrande.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoGrande.Image = global::TCC2.Properties.Resources.iconTCC_removebg_preview__1____Copia;
            this.pbxLogoGrande.Location = new System.Drawing.Point(341, 176);
            this.pbxLogoGrande.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogoGrande.Name = "pbxLogoGrande";
            this.pbxLogoGrande.Size = new System.Drawing.Size(843, 574);
            this.pbxLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoGrande.TabIndex = 6;
            this.pbxLogoGrande.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(1580, 4);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 23);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Label1";
            // 
            // tabAgenda
            // 
            this.tabAgenda.Controls.Add(this.btnSalvarAgenda);
            this.tabAgenda.Controls.Add(this.lblDataAtual);
            this.tabAgenda.Controls.Add(this.dtgAgenda);
            this.tabAgenda.Controls.Add(this.btnAvançar);
            this.tabAgenda.Controls.Add(this.btnVoltar);
            this.tabAgenda.ImageKey = "agenda32px.png";
            this.tabAgenda.Location = new System.Drawing.Point(4, 39);
            this.tabAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(4);
            this.tabAgenda.Size = new System.Drawing.Size(1641, 950);
            this.tabAgenda.TabIndex = 1;
            this.tabAgenda.Text = "Agenda";
            this.tabAgenda.UseVisualStyleBackColor = true;
            this.tabAgenda.Enter += new System.EventHandler(this.tabAgenda_Enter);
            // 
            // btnSalvarAgenda
            // 
            this.btnSalvarAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAgenda.AutoSize = true;
            this.btnSalvarAgenda.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAgenda.Location = new System.Drawing.Point(1477, 890);
            this.btnSalvarAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarAgenda.Name = "btnSalvarAgenda";
            this.btnSalvarAgenda.Size = new System.Drawing.Size(153, 43);
            this.btnSalvarAgenda.TabIndex = 54;
            this.btnSalvarAgenda.Text = "Salvar";
            this.btnSalvarAgenda.UseVisualStyleBackColor = true;
            this.btnSalvarAgenda.Click += new System.EventHandler(this.btnSalvarAgenda_Click);
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtual.Location = new System.Drawing.Point(668, 31);
            this.lblDataAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(160, 31);
            this.lblDataAtual.TabIndex = 53;
            this.lblDataAtual.Text = "dd/MM/yyyy";
            this.lblDataAtual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dtgAgenda.ColumnHeadersHeight = 29;
            this.dtgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horario,
            this.nomePaciente,
            this.atendido,
            this.retorno,
            this.ID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAgenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgAgenda.Location = new System.Drawing.Point(8, 71);
            this.dtgAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.dtgAgenda.Name = "dtgAgenda";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAgenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAgenda.RowHeadersWidth = 51;
            this.dtgAgenda.Size = new System.Drawing.Size(1625, 811);
            this.dtgAgenda.TabIndex = 52;
            this.dtgAgenda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgenda_CellEndEdit);
            this.dtgAgenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgAgenda_KeyDown);
            // 
            // horario
            // 
            this.horario.HeaderText = "Horário";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            this.horario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.horario.Width = 223;
            // 
            // nomePaciente
            // 
            this.nomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePaciente.HeaderText = "Paciente";
            this.nomePaciente.MinimumWidth = 6;
            this.nomePaciente.Name = "nomePaciente";
            // 
            // atendido
            // 
            this.atendido.HeaderText = "Atendido?";
            this.atendido.MinimumWidth = 6;
            this.atendido.Name = "atendido";
            this.atendido.Width = 125;
            // 
            // retorno
            // 
            this.retorno.HeaderText = "Retorno?";
            this.retorno.MinimumWidth = 6;
            this.retorno.Name = "retorno";
            this.retorno.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // btnAvançar
            // 
            this.btnAvançar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvançar.AutoSize = true;
            this.btnAvançar.Location = new System.Drawing.Point(1477, 18);
            this.btnAvançar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(153, 43);
            this.btnAvançar.TabIndex = 51;
            this.btnAvançar.Text = "Avançar";
            this.btnAvançar.UseVisualStyleBackColor = true;
            this.btnAvançar.Click += new System.EventHandler(this.btnAvançar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Location = new System.Drawing.Point(8, 21);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(153, 43);
            this.btnVoltar.TabIndex = 50;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabAlimento
            // 
            this.tabAlimento.AllowDrop = true;
            this.tabAlimento.Controls.Add(this.tbAlimento);
            this.tabAlimento.ImageKey = "Alimento32px.png";
            this.tabAlimento.Location = new System.Drawing.Point(4, 39);
            this.tabAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.tabAlimento.Name = "tabAlimento";
            this.tabAlimento.Padding = new System.Windows.Forms.Padding(4);
            this.tabAlimento.Size = new System.Drawing.Size(1641, 950);
            this.tabAlimento.TabIndex = 2;
            this.tabAlimento.Text = "Alimento";
            this.tabAlimento.UseVisualStyleBackColor = true;
            this.tabAlimento.Enter += new System.EventHandler(this.tabAlimento_Enter);
            // 
            // tbAlimento
            // 
            this.tbAlimento.AllowDrop = true;
            this.tbAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlimento.Controls.Add(this._tbConsulta);
            this.tbAlimento.Controls.Add(this.tbImportarPlanilha);
            this.tbAlimento.Controls.Add(this.tbCadMedCaseira);
            this.tbAlimento.Location = new System.Drawing.Point(4, 4);
            this.tbAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.SelectedIndex = 0;
            this.tbAlimento.Size = new System.Drawing.Size(1625, 935);
            this.tbAlimento.TabIndex = 1;
            // 
            // _tbConsulta
            // 
            this._tbConsulta.Controls.Add(this.btnCancelarEditAlimentos);
            this._tbConsulta.Controls.Add(this.btnRecalcular);
            this._tbConsulta.Controls.Add(this.lblAlimentoFiltro);
            this._tbConsulta.Controls.Add(this.lblTabelaSelecionada);
            this._tbConsulta.Controls.Add(this.btnSalvarAlimento);
            this._tbConsulta.Controls.Add(this.cbxTabela);
            this._tbConsulta.Controls.Add(this.label7);
            this._tbConsulta.Controls.Add(this.txtAlimentoFiltro);
            this._tbConsulta.Controls.Add(this.lblTabela);
            this._tbConsulta.Controls.Add(this.dtgConAlimento);
            this._tbConsulta.Location = new System.Drawing.Point(4, 25);
            this._tbConsulta.Margin = new System.Windows.Forms.Padding(4);
            this._tbConsulta.Name = "_tbConsulta";
            this._tbConsulta.Padding = new System.Windows.Forms.Padding(4);
            this._tbConsulta.Size = new System.Drawing.Size(1617, 906);
            this._tbConsulta.TabIndex = 1;
            this._tbConsulta.Text = "Cadastro/Consulta";
            this._tbConsulta.UseVisualStyleBackColor = true;
            this._tbConsulta.Enter += new System.EventHandler(this._tbConsulta_Enter);
            // 
            // btnCancelarEditAlimentos
            // 
            this.btnCancelarEditAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEditAlimentos.AutoSize = true;
            this.btnCancelarEditAlimentos.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelarEditAlimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEditAlimentos.Location = new System.Drawing.Point(1453, 847);
            this.btnCancelarEditAlimentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarEditAlimentos.Name = "btnCancelarEditAlimentos";
            this.btnCancelarEditAlimentos.Size = new System.Drawing.Size(153, 43);
            this.btnCancelarEditAlimentos.TabIndex = 317;
            this.btnCancelarEditAlimentos.Text = "Cancelar";
            this.btnCancelarEditAlimentos.UseVisualStyleBackColor = true;
            this.btnCancelarEditAlimentos.Click += new System.EventHandler(this.btnCancelarEditAlimentos_Click);
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecalcular.AutoSize = true;
            this.btnRecalcular.Image = global::TCC2.Properties.Resources._1486564177_finance_finance_calculator_81497;
            this.btnRecalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecalcular.Location = new System.Drawing.Point(8, 846);
            this.btnRecalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(153, 47);
            this.btnRecalcular.TabIndex = 3;
            this.btnRecalcular.Text = "Calcular";
            this.btnRecalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // lblAlimentoFiltro
            // 
            this.lblAlimentoFiltro.AutoSize = true;
            this.lblAlimentoFiltro.Location = new System.Drawing.Point(16, 50);
            this.lblAlimentoFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimentoFiltro.Name = "lblAlimentoFiltro";
            this.lblAlimentoFiltro.Size = new System.Drawing.Size(66, 17);
            this.lblAlimentoFiltro.TabIndex = 53;
            this.lblAlimentoFiltro.Text = "Alimento:";
            // 
            // lblTabelaSelecionada
            // 
            this.lblTabelaSelecionada.AutoSize = true;
            this.lblTabelaSelecionada.Location = new System.Drawing.Point(16, 11);
            this.lblTabelaSelecionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabelaSelecionada.Name = "lblTabelaSelecionada";
            this.lblTabelaSelecionada.Size = new System.Drawing.Size(56, 17);
            this.lblTabelaSelecionada.TabIndex = 52;
            this.lblTabelaSelecionada.Text = "Tabela:";
            // 
            // btnSalvarAlimento
            // 
            this.btnSalvarAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAlimento.AutoSize = true;
            this.btnSalvarAlimento.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAlimento.Location = new System.Drawing.Point(1292, 847);
            this.btnSalvarAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarAlimento.Name = "btnSalvarAlimento";
            this.btnSalvarAlimento.Size = new System.Drawing.Size(153, 43);
            this.btnSalvarAlimento.TabIndex = 4;
            this.btnSalvarAlimento.Text = "Salvar";
            this.btnSalvarAlimento.UseVisualStyleBackColor = true;
            this.btnSalvarAlimento.Click += new System.EventHandler(this.btnSalvarAlimento_Click);
            // 
            // cbxTabela
            // 
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Location = new System.Drawing.Point(169, 7);
            this.cbxTabela.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(583, 24);
            this.cbxTabela.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 4;
            // 
            // txtAlimentoFiltro
            // 
            this.txtAlimentoFiltro.Location = new System.Drawing.Point(169, 47);
            this.txtAlimentoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlimentoFiltro.Name = "txtAlimentoFiltro";
            this.txtAlimentoFiltro.Size = new System.Drawing.Size(583, 22);
            this.txtAlimentoFiltro.TabIndex = 1;
            this.txtAlimentoFiltro.Leave += new System.EventHandler(this.txtAlimentoFiltro_Leave);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(8, 11);
            this.lblTabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(0, 17);
            this.lblTabela.TabIndex = 2;
            // 
            // dtgConAlimento
            // 
            this.dtgConAlimento.AllowDrop = true;
            this.dtgConAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConAlimento.BackgroundColor = System.Drawing.Color.White;
            this.dtgConAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConAlimento.Location = new System.Drawing.Point(8, 79);
            this.dtgConAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtgConAlimento.Name = "dtgConAlimento";
            this.dtgConAlimento.RowHeadersWidth = 51;
            this.dtgConAlimento.Size = new System.Drawing.Size(1601, 762);
            this.dtgConAlimento.TabIndex = 2;
            this.dtgConAlimento.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgConAlimento_CellBeginEdit);
            this.dtgConAlimento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConAlimento_CellEndEdit);
            this.dtgConAlimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgConAlimento_KeyDown);
            // 
            // tbImportarPlanilha
            // 
            this.tbImportarPlanilha.AllowDrop = true;
            this.tbImportarPlanilha.Controls.Add(this.txtNomeTabela);
            this.tbImportarPlanilha.Controls.Add(this.lblNomeTabela);
            this.tbImportarPlanilha.Controls.Add(this._cbxNomePlanilha);
            this.tbImportarPlanilha.Controls.Add(this._btnImportar);
            this.tbImportarPlanilha.Controls.Add(this.dtgDadosImportados);
            this.tbImportarPlanilha.Controls.Add(this.txtCaminhoArquivoExcel);
            this.tbImportarPlanilha.Controls.Add(this.Label10);
            this.tbImportarPlanilha.Controls.Add(this.lblCaminho);
            this.tbImportarPlanilha.Controls.Add(this._btnBuscarPlanilha);
            this.tbImportarPlanilha.Location = new System.Drawing.Point(4, 25);
            this.tbImportarPlanilha.Margin = new System.Windows.Forms.Padding(4);
            this.tbImportarPlanilha.Name = "tbImportarPlanilha";
            this.tbImportarPlanilha.Padding = new System.Windows.Forms.Padding(4);
            this.tbImportarPlanilha.Size = new System.Drawing.Size(1617, 906);
            this.tbImportarPlanilha.TabIndex = 2;
            this.tbImportarPlanilha.Text = "Importação tabela";
            this.tbImportarPlanilha.UseVisualStyleBackColor = true;
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeTabela.Location = new System.Drawing.Point(259, 831);
            this.txtNomeTabela.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(669, 22);
            this.txtNomeTabela.TabIndex = 272;
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Location = new System.Drawing.Point(4, 836);
            this.lblNomeTabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(97, 17);
            this.lblNomeTabela.TabIndex = 271;
            this.lblNomeTabela.Text = "Nome Tabela:";
            // 
            // _cbxNomePlanilha
            // 
            this._cbxNomePlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbxNomePlanilha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxNomePlanilha.FormattingEnabled = true;
            this._cbxNomePlanilha.Location = new System.Drawing.Point(259, 794);
            this._cbxNomePlanilha.Margin = new System.Windows.Forms.Padding(4);
            this._cbxNomePlanilha.Name = "_cbxNomePlanilha";
            this._cbxNomePlanilha.Size = new System.Drawing.Size(669, 24);
            this._cbxNomePlanilha.TabIndex = 270;
            this._cbxNomePlanilha.SelectedIndexChanged += new System.EventHandler(this._cbxNomePlanilha_SelectedIndexChanged);
            // 
            // _btnImportar
            // 
            this._btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportar.AutoSize = true;
            this._btnImportar.Image = global::TCC2.Properties.Resources.database_import_icon_135719;
            this._btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnImportar.Location = new System.Drawing.Point(1453, 846);
            this._btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this._btnImportar.Name = "_btnImportar";
            this._btnImportar.Size = new System.Drawing.Size(153, 47);
            this._btnImportar.TabIndex = 269;
            this._btnImportar.Text = "Importar";
            this._btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnImportar.UseVisualStyleBackColor = true;
            this._btnImportar.Click += new System.EventHandler(this._btnImportar_Click);
            // 
            // dtgDadosImportados
            // 
            this.dtgDadosImportados.AllowDrop = true;
            this.dtgDadosImportados.AllowUserToAddRows = false;
            this.dtgDadosImportados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosImportados.BackgroundColor = System.Drawing.Color.White;
            this.dtgDadosImportados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosImportados.Location = new System.Drawing.Point(12, 4);
            this.dtgDadosImportados.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDadosImportados.Name = "dtgDadosImportados";
            this.dtgDadosImportados.RowHeadersWidth = 51;
            this.dtgDadosImportados.Size = new System.Drawing.Size(1601, 725);
            this.dtgDadosImportados.TabIndex = 268;
            this.dtgDadosImportados.DragDrop += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragDrop);
            this.dtgDadosImportados.DragEnter += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragEnter);
            // 
            // txtCaminhoArquivoExcel
            // 
            this.txtCaminhoArquivoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCaminhoArquivoExcel.Location = new System.Drawing.Point(259, 757);
            this.txtCaminhoArquivoExcel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            this.txtCaminhoArquivoExcel.ReadOnly = true;
            this.txtCaminhoArquivoExcel.Size = new System.Drawing.Size(837, 22);
            this.txtCaminhoArquivoExcel.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(4, 799);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(122, 17);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Nome da planilha:";
            // 
            // lblCaminho
            // 
            this.lblCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(4, 762);
            this.lblCaminho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(138, 17);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "Caminho do arquivo:";
            // 
            // _btnBuscarPlanilha
            // 
            this._btnBuscarPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBuscarPlanilha.Image = global::TCC2.Properties.Resources.consultar;
            this._btnBuscarPlanilha.Location = new System.Drawing.Point(1103, 751);
            this._btnBuscarPlanilha.Margin = new System.Windows.Forms.Padding(4);
            this._btnBuscarPlanilha.Name = "_btnBuscarPlanilha";
            this._btnBuscarPlanilha.Size = new System.Drawing.Size(36, 32);
            this._btnBuscarPlanilha.TabIndex = 266;
            this._btnBuscarPlanilha.UseVisualStyleBackColor = true;
            this._btnBuscarPlanilha.Click += new System.EventHandler(this._btnBuscarPlanilha_Click);
            // 
            // tbCadMedCaseira
            // 
            this.tbCadMedCaseira.Controls.Add(this.txtCodAlimentoMedCas);
            this.tbCadMedCaseira.Controls.Add(this.dtgSalvarMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.txtQtdMedCas);
            this.tbCadMedCaseira.Controls.Add(this.lblQtd);
            this.tbCadMedCaseira.Controls.Add(this.txtDescMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.lblDescMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.txtAlimentoMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.lblAlimentoMedCas);
            this.tbCadMedCaseira.Controls.Add(this.dtgMedCaseiraAlimentos);
            this.tbCadMedCaseira.Controls.Add(this.btnAddMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.btnSalvarMedCas);
            this.tbCadMedCaseira.Location = new System.Drawing.Point(4, 25);
            this.tbCadMedCaseira.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadMedCaseira.Name = "tbCadMedCaseira";
            this.tbCadMedCaseira.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadMedCaseira.Size = new System.Drawing.Size(1617, 906);
            this.tbCadMedCaseira.TabIndex = 3;
            this.tbCadMedCaseira.Text = "Cadastrar Medida Caseira";
            this.tbCadMedCaseira.UseVisualStyleBackColor = true;
            this.tbCadMedCaseira.Enter += new System.EventHandler(this.tbCadMedCaseira_Enter);
            // 
            // txtCodAlimentoMedCas
            // 
            this.txtCodAlimentoMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodAlimentoMedCas.Enabled = false;
            this.txtCodAlimentoMedCas.Location = new System.Drawing.Point(481, 62);
            this.txtCodAlimentoMedCas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodAlimentoMedCas.Name = "txtCodAlimentoMedCas";
            this.txtCodAlimentoMedCas.Size = new System.Drawing.Size(232, 22);
            this.txtCodAlimentoMedCas.TabIndex = 285;
            this.txtCodAlimentoMedCas.Visible = false;
            // 
            // dtgSalvarMedCaseira
            // 
            this.dtgSalvarMedCaseira.AllowUserToAddRows = false;
            this.dtgSalvarMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSalvarMedCaseira.BackgroundColor = System.Drawing.Color.White;
            this.dtgSalvarMedCaseira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSalvarMedCaseira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salvo});
            this.dtgSalvarMedCaseira.Location = new System.Drawing.Point(481, 250);
            this.dtgSalvarMedCaseira.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSalvarMedCaseira.Name = "dtgSalvarMedCaseira";
            this.dtgSalvarMedCaseira.RowHeadersWidth = 51;
            this.dtgSalvarMedCaseira.Size = new System.Drawing.Size(1129, 602);
            this.dtgSalvarMedCaseira.TabIndex = 10;
            // 
            // salvo
            // 
            this.salvo.HeaderText = "salvo";
            this.salvo.MinimumWidth = 6;
            this.salvo.Name = "salvo";
            this.salvo.Visible = false;
            this.salvo.Width = 125;
            // 
            // txtQtdMedCas
            // 
            this.txtQtdMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdMedCas.Location = new System.Drawing.Point(1255, 145);
            this.txtQtdMedCas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdMedCas.Name = "txtQtdMedCas";
            this.txtQtdMedCas.Size = new System.Drawing.Size(332, 22);
            this.txtQtdMedCas.TabIndex = 9;
            // 
            // lblQtd
            // 
            this.lblQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(1139, 149);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(75, 17);
            this.lblQtd.TabIndex = 8;
            this.lblQtd.Text = "Qtd (g/ml):";
            // 
            // txtDescMedCaseira
            // 
            this.txtDescMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescMedCaseira.Location = new System.Drawing.Point(585, 145);
            this.txtDescMedCaseira.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescMedCaseira.Name = "txtDescMedCaseira";
            this.txtDescMedCaseira.Size = new System.Drawing.Size(489, 22);
            this.txtDescMedCaseira.TabIndex = 7;
            // 
            // lblDescMedCaseira
            // 
            this.lblDescMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescMedCaseira.AutoSize = true;
            this.lblDescMedCaseira.Location = new System.Drawing.Point(485, 148);
            this.lblDescMedCaseira.Name = "lblDescMedCaseira";
            this.lblDescMedCaseira.Size = new System.Drawing.Size(75, 17);
            this.lblDescMedCaseira.TabIndex = 6;
            this.lblDescMedCaseira.Text = "Descrição:";
            // 
            // txtAlimentoMedCaseira
            // 
            this.txtAlimentoMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlimentoMedCaseira.Enabled = false;
            this.txtAlimentoMedCaseira.Location = new System.Drawing.Point(576, 32);
            this.txtAlimentoMedCaseira.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlimentoMedCaseira.Name = "txtAlimentoMedCaseira";
            this.txtAlimentoMedCaseira.Size = new System.Drawing.Size(908, 22);
            this.txtAlimentoMedCaseira.TabIndex = 5;
            this.txtAlimentoMedCaseira.Leave += new System.EventHandler(this.txtAlimentoMedCaseira_Leave);
            // 
            // lblAlimentoMedCas
            // 
            this.lblAlimentoMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlimentoMedCas.AutoSize = true;
            this.lblAlimentoMedCas.Location = new System.Drawing.Point(485, 34);
            this.lblAlimentoMedCas.Name = "lblAlimentoMedCas";
            this.lblAlimentoMedCas.Size = new System.Drawing.Size(66, 17);
            this.lblAlimentoMedCas.TabIndex = 4;
            this.lblAlimentoMedCas.Text = "Alimento:";
            // 
            // dtgMedCaseiraAlimentos
            // 
            this.dtgMedCaseiraAlimentos.AllowUserToAddRows = false;
            this.dtgMedCaseiraAlimentos.AllowUserToDeleteRows = false;
            this.dtgMedCaseiraAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgMedCaseiraAlimentos.BackgroundColor = System.Drawing.Color.White;
            this.dtgMedCaseiraAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedCaseiraAlimentos.Location = new System.Drawing.Point(9, 4);
            this.dtgMedCaseiraAlimentos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMedCaseiraAlimentos.Name = "dtgMedCaseiraAlimentos";
            this.dtgMedCaseiraAlimentos.RowHeadersWidth = 51;
            this.dtgMedCaseiraAlimentos.Size = new System.Drawing.Size(464, 895);
            this.dtgMedCaseiraAlimentos.TabIndex = 3;
            this.dtgMedCaseiraAlimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedCaseiraAlimentos_CellDoubleClick);
            // 
            // btnAddMedCaseira
            // 
            this.btnAddMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMedCaseira.Image = global::TCC2.Properties.Resources.Adicionar;
            this.btnAddMedCaseira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedCaseira.Location = new System.Drawing.Point(1476, 206);
            this.btnAddMedCaseira.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMedCaseira.Name = "btnAddMedCaseira";
            this.btnAddMedCaseira.Size = new System.Drawing.Size(135, 37);
            this.btnAddMedCaseira.TabIndex = 284;
            this.btnAddMedCaseira.Text = "Adicionar";
            this.btnAddMedCaseira.UseVisualStyleBackColor = true;
            this.btnAddMedCaseira.Click += new System.EventHandler(this.btnAddMedCaseira_Click);
            // 
            // btnSalvarMedCas
            // 
            this.btnSalvarMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarMedCas.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarMedCas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarMedCas.Location = new System.Drawing.Point(1492, 862);
            this.btnSalvarMedCas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarMedCas.Name = "btnSalvarMedCas";
            this.btnSalvarMedCas.Size = new System.Drawing.Size(119, 37);
            this.btnSalvarMedCas.TabIndex = 11;
            this.btnSalvarMedCas.Text = "Salvar";
            this.btnSalvarMedCas.UseVisualStyleBackColor = true;
            this.btnSalvarMedCas.Click += new System.EventHandler(this.btnSalvarMedCas_Click);
            // 
            // tabCardapio
            // 
            this.tabCardapio.Controls.Add(this.tabControl1);
            this.tabCardapio.ImageKey = "Cardapio32px.png";
            this.tabCardapio.Location = new System.Drawing.Point(4, 39);
            this.tabCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.tabCardapio.Name = "tabCardapio";
            this.tabCardapio.Padding = new System.Windows.Forms.Padding(4);
            this.tabCardapio.Size = new System.Drawing.Size(1641, 950);
            this.tabCardapio.TabIndex = 3;
            this.tabCardapio.Text = "Cardápio";
            this.tabCardapio.UseVisualStyleBackColor = true;
            this.tabCardapio.Enter += new System.EventHandler(this.tabCardapio_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbCadCardapio);
            this.tabControl1.Controls.Add(this.tbConsultaCardapio);
            this.tabControl1.Controls.Add(this.tbCadastrarTiposCardapios);
            this.tabControl1.Location = new System.Drawing.Point(3, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1629, 927);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCadCardapio
            // 
            this.tbCadCardapio.Controls.Add(this.btnCancelarCardapio);
            this.tbCadCardapio.Controls.Add(this.btnConfigGramasCard);
            this.tbCadCardapio.Controls.Add(this.txtFiltroAlimento);
            this.tbCadCardapio.Controls.Add(this.graficoMacroNutri);
            this.tbCadCardapio.Controls.Add(this.btnAddAliCard);
            this.tbCadCardapio.Controls.Add(this.cbxRefeicao);
            this.tbCadCardapio.Controls.Add(this.lblDescricao);
            this.tbCadCardapio.Controls.Add(this.txtPaciente);
            this.tbCadCardapio.Controls.Add(this.btnPacienteCardapio);
            this.tbCadCardapio.Controls.Add(this.lblValorKcal);
            this.tbCadCardapio.Controls.Add(this.lblVlrKcal);
            this.tbCadCardapio.Controls.Add(this.lblTabelaCardapio);
            this.tbCadCardapio.Controls.Add(this.cbxTabelaAlimentoCardapio);
            this.tbCadCardapio.Controls.Add(this.dtgCardapioAlimentos);
            this.tbCadCardapio.Controls.Add(this.dtgRefeicoes);
            this.tbCadCardapio.Controls.Add(this.label8);
            this.tbCadCardapio.Controls.Add(this.btnSalvarCardapio);
            this.tbCadCardapio.Location = new System.Drawing.Point(4, 25);
            this.tbCadCardapio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadCardapio.Name = "tbCadCardapio";
            this.tbCadCardapio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadCardapio.Size = new System.Drawing.Size(1621, 898);
            this.tbCadCardapio.TabIndex = 0;
            this.tbCadCardapio.Text = "Criar Cardápio";
            this.tbCadCardapio.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCardapio
            // 
            this.btnCancelarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCardapio.AutoSize = true;
            this.btnCancelarCardapio.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCardapio.Location = new System.Drawing.Point(1459, 842);
            this.btnCancelarCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarCardapio.Name = "btnCancelarCardapio";
            this.btnCancelarCardapio.Size = new System.Drawing.Size(153, 43);
            this.btnCancelarCardapio.TabIndex = 316;
            this.btnCancelarCardapio.Text = "Cancelar";
            this.btnCancelarCardapio.UseVisualStyleBackColor = true;
            this.btnCancelarCardapio.Click += new System.EventHandler(this.btnCancelarCardapio_Click);
            // 
            // btnConfigGramasCard
            // 
            this.btnConfigGramasCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigGramasCard.AutoSize = true;
            this.btnConfigGramasCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigGramasCard.Location = new System.Drawing.Point(1459, 49);
            this.btnConfigGramasCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfigGramasCard.Name = "btnConfigGramasCard";
            this.btnConfigGramasCard.Size = new System.Drawing.Size(153, 43);
            this.btnConfigGramasCard.TabIndex = 315;
            this.btnConfigGramasCard.Text = "Configurar";
            this.btnConfigGramasCard.UseVisualStyleBackColor = true;
            this.btnConfigGramasCard.Click += new System.EventHandler(this.btnConfigGramasCard_Click);
            // 
            // txtFiltroAlimento
            // 
            this.txtFiltroAlimento.Location = new System.Drawing.Point(11, 66);
            this.txtFiltroAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAlimento.Name = "txtFiltroAlimento";
            this.txtFiltroAlimento.Size = new System.Drawing.Size(411, 22);
            this.txtFiltroAlimento.TabIndex = 314;
            this.txtFiltroAlimento.Tag = "Filtro...";
            this.txtFiltroAlimento.Leave += new System.EventHandler(this.txtFiltroAlimento_Leave);
            // 
            // graficoMacroNutri
            // 
            this.graficoMacroNutri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graficoMacroNutri.Location = new System.Drawing.Point(5, 671);
            this.graficoMacroNutri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graficoMacroNutri.Name = "graficoMacroNutri";
            this.graficoMacroNutri.Size = new System.Drawing.Size(480, 212);
            this.graficoMacroNutri.TabIndex = 313;
            this.graficoMacroNutri.Text = "Gráfico MacroNutrientes";
            // 
            // btnAddAliCard
            // 
            this.btnAddAliCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAliCard.Image = global::TCC2.Properties.Resources.arrow_icon_1___Copia;
            this.btnAddAliCard.Location = new System.Drawing.Point(757, 337);
            this.btnAddAliCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAliCard.Name = "btnAddAliCard";
            this.btnAddAliCard.Size = new System.Drawing.Size(75, 68);
            this.btnAddAliCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddAliCard.TabIndex = 309;
            this.btnAddAliCard.TabStop = false;
            this.btnAddAliCard.Click += new System.EventHandler(this.btnAddAliCard_Click);
            // 
            // cbxRefeicao
            // 
            this.cbxRefeicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRefeicao.FormattingEnabled = true;
            this.cbxRefeicao.Items.AddRange(new object[] {
            "Café da manhã",
            "Lanche",
            "Almoço",
            "Lanche da tarde",
            "Jantar",
            "Ceia"});
            this.cbxRefeicao.Location = new System.Drawing.Point(539, 14);
            this.cbxRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRefeicao.Name = "cbxRefeicao";
            this.cbxRefeicao.Size = new System.Drawing.Size(279, 24);
            this.cbxRefeicao.TabIndex = 306;
            this.cbxRefeicao.Leave += new System.EventHandler(this.cbxRefeicao_Leave);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(427, 18);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 17);
            this.lblDescricao.TabIndex = 302;
            this.lblDescricao.Text = "Refeição:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(141, 16);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(161, 22);
            this.txtPaciente.TabIndex = 299;
            // 
            // btnPacienteCardapio
            // 
            this.btnPacienteCardapio.Image = global::TCC2.Properties.Resources.consultar;
            this.btnPacienteCardapio.Location = new System.Drawing.Point(337, 14);
            this.btnPacienteCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacienteCardapio.Name = "btnPacienteCardapio";
            this.btnPacienteCardapio.Size = new System.Drawing.Size(40, 28);
            this.btnPacienteCardapio.TabIndex = 301;
            this.btnPacienteCardapio.UseVisualStyleBackColor = true;
            this.btnPacienteCardapio.Click += new System.EventHandler(this.btnPacienteCardapio_Click);
            // 
            // lblValorKcal
            // 
            this.lblValorKcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValorKcal.AutoSize = true;
            this.lblValorKcal.Location = new System.Drawing.Point(613, 698);
            this.lblValorKcal.Name = "lblValorKcal";
            this.lblValorKcal.Size = new System.Drawing.Size(0, 17);
            this.lblValorKcal.TabIndex = 312;
            // 
            // lblVlrKcal
            // 
            this.lblVlrKcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVlrKcal.AutoSize = true;
            this.lblVlrKcal.Location = new System.Drawing.Point(491, 698);
            this.lblVlrKcal.Name = "lblVlrKcal";
            this.lblVlrKcal.Size = new System.Drawing.Size(39, 17);
            this.lblVlrKcal.TabIndex = 311;
            this.lblVlrKcal.Text = "Kcal:";
            // 
            // lblTabelaCardapio
            // 
            this.lblTabelaCardapio.AutoSize = true;
            this.lblTabelaCardapio.Location = new System.Drawing.Point(875, 18);
            this.lblTabelaCardapio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabelaCardapio.Name = "lblTabelaCardapio";
            this.lblTabelaCardapio.Size = new System.Drawing.Size(56, 17);
            this.lblTabelaCardapio.TabIndex = 308;
            this.lblTabelaCardapio.Text = "Tabela:";
            // 
            // cbxTabelaAlimentoCardapio
            // 
            this.cbxTabelaAlimentoCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTabelaAlimentoCardapio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabelaAlimentoCardapio.FormattingEnabled = true;
            this.cbxTabelaAlimentoCardapio.Location = new System.Drawing.Point(999, 16);
            this.cbxTabelaAlimentoCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTabelaAlimentoCardapio.Name = "cbxTabelaAlimentoCardapio";
            this.cbxTabelaAlimentoCardapio.Size = new System.Drawing.Size(535, 24);
            this.cbxTabelaAlimentoCardapio.TabIndex = 307;
            this.cbxTabelaAlimentoCardapio.SelectedIndexChanged += new System.EventHandler(this.cbxTabelaAlimentoCardapio_SelectedIndexChanged_1);
            // 
            // dtgCardapioAlimentos
            // 
            this.dtgCardapioAlimentos.AllowUserToAddRows = false;
            this.dtgCardapioAlimentos.AllowUserToOrderColumns = true;
            this.dtgCardapioAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgCardapioAlimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCardapioAlimentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCardapioAlimentos.BackgroundColor = System.Drawing.Color.White;
            this.dtgCardapioAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCardapioAlimentos.Location = new System.Drawing.Point(7, 98);
            this.dtgCardapioAlimentos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCardapioAlimentos.Name = "dtgCardapioAlimentos";
            this.dtgCardapioAlimentos.RowHeadersWidth = 51;
            this.dtgCardapioAlimentos.Size = new System.Drawing.Size(708, 569);
            this.dtgCardapioAlimentos.TabIndex = 305;
            // 
            // dtgRefeicoes
            // 
            this.dtgRefeicoes.AllowUserToAddRows = false;
            this.dtgRefeicoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefeicoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRefeicoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRefeicoes.BackgroundColor = System.Drawing.Color.White;
            this.dtgRefeicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRefeicoes.Location = new System.Drawing.Point(879, 98);
            this.dtgRefeicoes.Margin = new System.Windows.Forms.Padding(4);
            this.dtgRefeicoes.Name = "dtgRefeicoes";
            this.dtgRefeicoes.RowHeadersWidth = 51;
            this.dtgRefeicoes.Size = new System.Drawing.Size(733, 569);
            this.dtgRefeicoes.TabIndex = 304;
            this.dtgRefeicoes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgRefeicoes_CellBeginEdit);
            this.dtgRefeicoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRefeicoes_CellEndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 300;
            this.label8.Text = "Paciente:";
            // 
            // btnSalvarCardapio
            // 
            this.btnSalvarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCardapio.AutoSize = true;
            this.btnSalvarCardapio.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCardapio.Location = new System.Drawing.Point(1297, 842);
            this.btnSalvarCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarCardapio.Name = "btnSalvarCardapio";
            this.btnSalvarCardapio.Size = new System.Drawing.Size(153, 43);
            this.btnSalvarCardapio.TabIndex = 303;
            this.btnSalvarCardapio.Text = "Salvar";
            this.btnSalvarCardapio.UseVisualStyleBackColor = true;
            this.btnSalvarCardapio.Click += new System.EventHandler(this.btnSalvarCardapio_Click);
            // 
            // tbConsultaCardapio
            // 
            this.tbConsultaCardapio.Controls.Add(this.trwDadosCard);
            this.tbConsultaCardapio.Controls.Add(this.txtPacienteConsultaCardapio);
            this.tbConsultaCardapio.Controls.Add(this.label6);
            this.tbConsultaCardapio.Controls.Add(this.btnApagar);
            this.tbConsultaCardapio.Controls.Add(this.btnBuscaPaciente);
            this.tbConsultaCardapio.Location = new System.Drawing.Point(4, 25);
            this.tbConsultaCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.tbConsultaCardapio.Name = "tbConsultaCardapio";
            this.tbConsultaCardapio.Padding = new System.Windows.Forms.Padding(4);
            this.tbConsultaCardapio.Size = new System.Drawing.Size(1621, 898);
            this.tbConsultaCardapio.TabIndex = 1;
            this.tbConsultaCardapio.Text = "Cardápios Salvos";
            this.tbConsultaCardapio.UseVisualStyleBackColor = true;
            this.tbConsultaCardapio.Click += new System.EventHandler(this.tbConsultaCardapio_Click);
            this.tbConsultaCardapio.Enter += new System.EventHandler(this.tbConsultaCardapio_Enter);
            // 
            // trwDadosCard
            // 
            this.trwDadosCard.AllowUserToAddRows = false;
            this.trwDadosCard.AllowUserToDeleteRows = false;
            this.trwDadosCard.AllowUserToOrderColumns = true;
            this.trwDadosCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trwDadosCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trwDadosCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.trwDadosCard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.trwDadosCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.trwDadosCard.ColumnHeadersHeight = 29;
            this.trwDadosCard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.trwDadosCard.GridColor = System.Drawing.SystemColors.Control;
            this.trwDadosCard.ImageList = null;
            this.trwDadosCard.Location = new System.Drawing.Point(4, 52);
            this.trwDadosCard.Margin = new System.Windows.Forms.Padding(4);
            this.trwDadosCard.Name = "trwDadosCard";
            this.trwDadosCard.ReadOnly = true;
            this.trwDadosCard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.trwDadosCard.RowHeadersWidth = 51;
            this.trwDadosCard.Size = new System.Drawing.Size(1607, 831);
            this.trwDadosCard.TabIndex = 0;
            // 
            // txtPacienteConsultaCardapio
            // 
            this.txtPacienteConsultaCardapio.Enabled = false;
            this.txtPacienteConsultaCardapio.Location = new System.Drawing.Point(143, 18);
            this.txtPacienteConsultaCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPacienteConsultaCardapio.Name = "txtPacienteConsultaCardapio";
            this.txtPacienteConsultaCardapio.Size = new System.Drawing.Size(161, 22);
            this.txtPacienteConsultaCardapio.TabIndex = 302;
            this.txtPacienteConsultaCardapio.TextChanged += new System.EventHandler(this.txtPacienteConsultaCardapio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 303;
            this.label6.Text = "Paciente:";
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnApagar.Location = new System.Drawing.Point(361, 16);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(40, 28);
            this.btnApagar.TabIndex = 306;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Image = global::TCC2.Properties.Resources.consultar;
            this.btnBuscaPaciente.Location = new System.Drawing.Point(313, 16);
            this.btnBuscaPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(40, 28);
            this.btnBuscaPaciente.TabIndex = 304;
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // tbCadastrarTiposCardapios
            // 
            this.tbCadastrarTiposCardapios.Location = new System.Drawing.Point(4, 25);
            this.tbCadastrarTiposCardapios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadastrarTiposCardapios.Name = "tbCadastrarTiposCardapios";
            this.tbCadastrarTiposCardapios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadastrarTiposCardapios.Size = new System.Drawing.Size(1621, 898);
            this.tbCadastrarTiposCardapios.TabIndex = 2;
            this.tbCadastrarTiposCardapios.Text = "Pré Definição Cardápios";
            this.tbCadastrarTiposCardapios.UseVisualStyleBackColor = true;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Controls.Add(this.tbPaciente);
            this.tabPaciente.ImageKey = "Paciente32px.png";
            this.tabPaciente.Location = new System.Drawing.Point(4, 39);
            this.tabPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(4);
            this.tabPaciente.Size = new System.Drawing.Size(1641, 950);
            this.tabPaciente.TabIndex = 4;
            this.tabPaciente.Text = "Paciente";
            this.tabPaciente.UseVisualStyleBackColor = true;
            // 
            // tbPaciente
            // 
            this.tbPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPaciente.Controls.Add(this.tbCadastro);
            this.tbPaciente.Controls.Add(this.tbAntropometricos);
            this.tbPaciente.Controls.Add(this.tbAnamnese);
            this.tbPaciente.Location = new System.Drawing.Point(8, 4);
            this.tbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.SelectedIndex = 0;
            this.tbPaciente.Size = new System.Drawing.Size(1623, 930);
            this.tbPaciente.TabIndex = 1;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.txtCEP);
            this.tbCadastro.Controls.Add(this.txtCodPaciente);
            this.tbCadastro.Controls.Add(this.btnCapturarImagem);
            this.tbCadastro.Controls.Add(this.txtDtNasc);
            this.tbCadastro.Controls.Add(this._dtgConsultaPacientes);
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
            this.tbCadastro.Controls.Add(this.lblCEP);
            this.tbCadastro.Controls.Add(this.txtBairro);
            this.tbCadastro.Controls.Add(this.lblBairro);
            this.tbCadastro.Controls.Add(this.txtEndereco);
            this.tbCadastro.Controls.Add(this.lblEndereco);
            this.tbCadastro.Controls.Add(this.lblDataNascimento);
            this.tbCadastro.Controls.Add(this.txtCPF);
            this.tbCadastro.Controls.Add(this.lblCPF);
            this.tbCadastro.Controls.Add(this.txtNome);
            this.tbCadastro.Controls.Add(this.pbImagem);
            this.tbCadastro.Controls.Add(this.lblNome);
            this.tbCadastro.Location = new System.Drawing.Point(4, 25);
            this.tbCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tbCadastro.Size = new System.Drawing.Size(1615, 901);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            this.tbCadastro.Enter += new System.EventHandler(this.tbCadastro_Enter);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(377, 208);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(224, 22);
            this.txtCEP.TabIndex = 272;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.AutoSize = true;
            this.txtCodPaciente.Location = new System.Drawing.Point(271, 16);
            this.txtCodPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(88, 17);
            this.txtCodPaciente.TabIndex = 271;
            this.txtCodPaciente.Text = "CodPaciente";
            this.txtCodPaciente.Visible = false;
            // 
            // btnCapturarImagem
            // 
            this.btnCapturarImagem.Location = new System.Drawing.Point(23, 230);
            this.btnCapturarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturarImagem.Name = "btnCapturarImagem";
            this.btnCapturarImagem.Size = new System.Drawing.Size(232, 28);
            this.btnCapturarImagem.TabIndex = 270;
            this.btnCapturarImagem.Text = "Capturar Imagem";
            this.btnCapturarImagem.UseVisualStyleBackColor = true;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtNasc.Location = new System.Drawing.Point(525, 101);
            this.txtDtNasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(209, 22);
            this.txtDtNasc.TabIndex = 269;
            this.txtDtNasc.Value = new System.DateTime(2021, 4, 5, 0, 0, 0, 0);
            // 
            // _dtgConsultaPacientes
            // 
            this._dtgConsultaPacientes.AllowUserToAddRows = false;
            this._dtgConsultaPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dtgConsultaPacientes.BackgroundColor = System.Drawing.Color.White;
            this._dtgConsultaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtgConsultaPacientes.Location = new System.Drawing.Point(8, 582);
            this._dtgConsultaPacientes.Margin = new System.Windows.Forms.Padding(4);
            this._dtgConsultaPacientes.Name = "_dtgConsultaPacientes";
            this._dtgConsultaPacientes.ReadOnly = true;
            this._dtgConsultaPacientes.RowHeadersWidth = 51;
            this._dtgConsultaPacientes.Size = new System.Drawing.Size(1599, 309);
            this._dtgConsultaPacientes.TabIndex = 266;
            this._dtgConsultaPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtgConsultaPacientes_CellDoubleClick);
            // 
            // _btnExcluir
            // 
            this._btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnExcluir.AutoSize = true;
            this._btnExcluir.Image = global::TCC2.Properties.Resources.DeleteRed;
            this._btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcluir.Location = new System.Drawing.Point(1451, 528);
            this._btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this._btnExcluir.Name = "_btnExcluir";
            this._btnExcluir.Size = new System.Drawing.Size(153, 43);
            this._btnExcluir.TabIndex = 242;
            this._btnExcluir.Text = "Excluir";
            this._btnExcluir.UseVisualStyleBackColor = true;
            this._btnExcluir.Click += new System.EventHandler(this._btnExcluir_Click);
            // 
            // _btnSalvar
            // 
            this._btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnSalvar.AutoSize = true;
            this._btnSalvar.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this._btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSalvar.Location = new System.Drawing.Point(1289, 528);
            this._btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(153, 43);
            this._btnSalvar.TabIndex = 241;
            this._btnSalvar.Text = "Salvar";
            this._btnSalvar.UseVisualStyleBackColor = true;
            this._btnSalvar.Click += new System.EventHandler(this._btnSalvar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(916, 284);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(79, 22);
            this.txtNumero.TabIndex = 234;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(867, 288);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(27, 17);
            this.lblNum.TabIndex = 256;
            this.lblNum.Text = "Nº:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(377, 154);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(428, 22);
            this.txtEmail.TabIndex = 229;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(268, 158);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 17);
            this.Label1.TabIndex = 255;
            this.Label1.Text = "E-mail:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(197, 434);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(829, 22);
            this.txtComplemento.TabIndex = 238;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(17, 437);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(98, 17);
            this.lblComplemento.TabIndex = 254;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(1061, 361);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(64, 22);
            this.txtUF.TabIndex = 237;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(996, 362);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(30, 17);
            this.lblUF.TabIndex = 253;
            this.lblUF.Text = "UF:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(488, 505);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.MaxLength = 16;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(219, 22);
            this.txtCelular.TabIndex = 240;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(399, 508);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(56, 17);
            this.lblCelular.TabIndex = 252;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(133, 506);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.MaxLength = 16;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(220, 22);
            this.txtTelefone.TabIndex = 239;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(16, 511);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 251;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(699, 359);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(240, 22);
            this.txtMunicipio.TabIndex = 236;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(580, 363);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(71, 17);
            this.lblMunicipio.TabIndex = 250;
            this.lblMunicipio.Text = "Município:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCEP.Location = new System.Drawing.Point(271, 212);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 17);
            this.lblCEP.TabIndex = 249;
            this.lblCEP.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(103, 359);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(409, 22);
            this.txtBairro.TabIndex = 235;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(17, 362);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 17);
            this.lblBairro.TabIndex = 248;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(136, 289);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(668, 22);
            this.txtEndereco.TabIndex = 233;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(13, 293);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 247;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(268, 106);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(138, 17);
            this.lblDataNascimento.TabIndex = 246;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(960, 44);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.MaxLength = 16;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(153, 22);
            this.txtCPF.TabIndex = 227;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(891, 47);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 245;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(359, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(461, 22);
            this.txtNome.TabIndex = 226;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::TCC2.Properties.Resources.no_icon_png_6;
            this.pbImagem.Location = new System.Drawing.Point(23, 16);
            this.pbImagem.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(232, 207);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 244;
            this.pbImagem.TabStop = false;
            this.pbImagem.Click += new System.EventHandler(this.pbImagem_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(268, 47);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 243;
            this.lblNome.Text = "Nome:";
            // 
            // tbAntropometricos
            // 
            this.tbAntropometricos.Controls.Add(this.label15);
            this.tbAntropometricos.Controls.Add(this.label14);
            this.tbAntropometricos.Controls.Add(this.textBox5);
            this.tbAntropometricos.Controls.Add(this.label5);
            this.tbAntropometricos.Controls.Add(this.textBox4);
            this.tbAntropometricos.Controls.Add(this.label4);
            this.tbAntropometricos.Controls.Add(this.textBox3);
            this.tbAntropometricos.Controls.Add(this.label3);
            this.tbAntropometricos.Controls.Add(this.textBox2);
            this.tbAntropometricos.Controls.Add(this.label2);
            this.tbAntropometricos.Location = new System.Drawing.Point(4, 25);
            this.tbAntropometricos.Margin = new System.Windows.Forms.Padding(4);
            this.tbAntropometricos.Name = "tbAntropometricos";
            this.tbAntropometricos.Padding = new System.Windows.Forms.Padding(4);
            this.tbAntropometricos.Size = new System.Drawing.Size(1615, 901);
            this.tbAntropometricos.TabIndex = 2;
            this.tbAntropometricos.Text = "Antropometria";
            this.tbAntropometricos.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "VALORIMC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "IMC:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 199);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 146);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 63);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peso:";
            // 
            // tbAnamnese
            // 
            this.tbAnamnese.Controls.Add(this.ritchTextBoxWithToolBar1);
            this.tbAnamnese.Location = new System.Drawing.Point(4, 25);
            this.tbAnamnese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnamnese.Name = "tbAnamnese";
            this.tbAnamnese.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnamnese.Size = new System.Drawing.Size(1615, 901);
            this.tbAnamnese.TabIndex = 3;
            this.tbAnamnese.Text = "Anamnese";
            this.tbAnamnese.UseVisualStyleBackColor = true;
            // 
            // ritchTextBoxWithToolBar1
            // 
            this.ritchTextBoxWithToolBar1.AcceptsTab = false;
            this.ritchTextBoxWithToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ritchTextBoxWithToolBar1.AutoWordSelection = true;
            this.ritchTextBoxWithToolBar1.DetectURLs = true;
            this.ritchTextBoxWithToolBar1.Location = new System.Drawing.Point(7, 6);
            this.ritchTextBoxWithToolBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ritchTextBoxWithToolBar1.Name = "ritchTextBoxWithToolBar1";
            this.ritchTextBoxWithToolBar1.PlainText = "";
            this.ritchTextBoxWithToolBar1.ReadOnly = false;
            // 
            // 
            // 
            this.ritchTextBoxWithToolBar1.RichTextBox.AutoWordSelection = true;
            this.ritchTextBoxWithToolBar1.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ritchTextBoxWithToolBar1.RichTextBox.Location = new System.Drawing.Point(0, 26);
            this.ritchTextBoxWithToolBar1.RichTextBox.Name = "rtb1";
            this.ritchTextBoxWithToolBar1.RichTextBox.Size = new System.Drawing.Size(1599, 856);
            this.ritchTextBoxWithToolBar1.RichTextBox.TabIndex = 1;
            this.ritchTextBoxWithToolBar1.ShowBold = true;
            this.ritchTextBoxWithToolBar1.ShowCenterJustify = true;
            this.ritchTextBoxWithToolBar1.ShowColors = true;
            this.ritchTextBoxWithToolBar1.ShowCopy = true;
            this.ritchTextBoxWithToolBar1.ShowCut = true;
            this.ritchTextBoxWithToolBar1.ShowFont = true;
            this.ritchTextBoxWithToolBar1.ShowFontSize = true;
            this.ritchTextBoxWithToolBar1.ShowItalic = true;
            this.ritchTextBoxWithToolBar1.ShowLeftJustify = true;
            this.ritchTextBoxWithToolBar1.ShowOpen = true;
            this.ritchTextBoxWithToolBar1.ShowPaste = true;
            this.ritchTextBoxWithToolBar1.ShowRedo = true;
            this.ritchTextBoxWithToolBar1.ShowRightJustify = true;
            this.ritchTextBoxWithToolBar1.ShowSave = true;
            this.ritchTextBoxWithToolBar1.ShowStamp = true;
            this.ritchTextBoxWithToolBar1.ShowStrikeout = true;
            this.ritchTextBoxWithToolBar1.ShowToolBarText = false;
            this.ritchTextBoxWithToolBar1.ShowUnderline = true;
            this.ritchTextBoxWithToolBar1.ShowUndo = true;
            this.ritchTextBoxWithToolBar1.Size = new System.Drawing.Size(1599, 882);
            this.ritchTextBoxWithToolBar1.StampAction = MvtWindowsForms.StampActions.EditedBy;
            this.ritchTextBoxWithToolBar1.StampColor = System.Drawing.Color.Blue;
            this.ritchTextBoxWithToolBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ritchTextBoxWithToolBar1.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.ritchTextBoxWithToolBar1.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.ritchTextBoxWithToolBar1.Toolbar.Divider = false;
            this.ritchTextBoxWithToolBar1.Toolbar.DropDownArrows = true;
            this.ritchTextBoxWithToolBar1.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.ritchTextBoxWithToolBar1.Toolbar.Name = "tb1";
            this.ritchTextBoxWithToolBar1.Toolbar.ShowToolTips = true;
            this.ritchTextBoxWithToolBar1.Toolbar.Size = new System.Drawing.Size(1599, 26);
            this.ritchTextBoxWithToolBar1.Toolbar.TabIndex = 0;
            // 
            // tabReceitas
            // 
            this.tabReceitas.ImageKey = "Receitas32px.png";
            this.tabReceitas.Location = new System.Drawing.Point(4, 39);
            this.tabReceitas.Margin = new System.Windows.Forms.Padding(4);
            this.tabReceitas.Name = "tabReceitas";
            this.tabReceitas.Size = new System.Drawing.Size(1641, 950);
            this.tabReceitas.TabIndex = 6;
            this.tabReceitas.Text = "Receitas";
            this.tabReceitas.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tbConfig);
            this.tabConfig.ImageKey = "settings32px.png";
            this.tabConfig.Location = new System.Drawing.Point(4, 39);
            this.tabConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(4);
            this.tabConfig.Size = new System.Drawing.Size(1641, 950);
            this.tabConfig.TabIndex = 5;
            this.tabConfig.Text = "Configurações";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tbConfig
            // 
            this.tbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConfig.Controls.Add(this.TabPage1);
            this.tbConfig.Controls.Add(this.tbPermissao);
            this.tbConfig.Location = new System.Drawing.Point(4, 7);
            this.tbConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.SelectedIndex = 0;
            this.tbConfig.Size = new System.Drawing.Size(1627, 926);
            this.tbConfig.TabIndex = 1;
            this.tbConfig.Enter += new System.EventHandler(this.tbConfig_Enter);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.txtConfirmarSenha);
            this.TabPage1.Controls.Add(this.txtSenha);
            this.TabPage1.Controls.Add(this.txtEmailConfig);
            this.TabPage1.Controls.Add(this.txtNomeUsuarioConfig);
            this.TabPage1.Controls.Add(this.txtUsuarioConfig);
            this.TabPage1.Controls.Add(this.label9);
            this.TabPage1.Controls.Add(this.lblSenha);
            this.TabPage1.Controls.Add(this.cbxSituacao);
            this.TabPage1.Controls.Add(this.lblSituacao);
            this.TabPage1.Controls.Add(this.btnExcluirConfigUsuario);
            this.TabPage1.Controls.Add(this.btnSalvarConfigUsuario);
            this.TabPage1.Controls.Add(this.cbxTipoUsuario);
            this.TabPage1.Controls.Add(this.lblPerfil);
            this.TabPage1.Controls.Add(this.lblEmail);
            this.TabPage1.Controls.Add(this.label11);
            this.TabPage1.Controls.Add(this.label12);
            this.TabPage1.Controls.Add(this.dtgUsuarios);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage1.Size = new System.Drawing.Size(1619, 897);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Usuários";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(615, 73);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(223, 22);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.Enter += new System.EventHandler(this.txtConfirmarSenha_Enter);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(104, 73);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(223, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtEmailConfig
            // 
            this.txtEmailConfig.Location = new System.Drawing.Point(104, 127);
            this.txtEmailConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailConfig.Name = "txtEmailConfig";
            this.txtEmailConfig.Size = new System.Drawing.Size(624, 22);
            this.txtEmailConfig.TabIndex = 5;
            // 
            // txtNomeUsuarioConfig
            // 
            this.txtNomeUsuarioConfig.Location = new System.Drawing.Point(531, 17);
            this.txtNomeUsuarioConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuarioConfig.Name = "txtNomeUsuarioConfig";
            this.txtNomeUsuarioConfig.Size = new System.Drawing.Size(565, 22);
            this.txtNomeUsuarioConfig.TabIndex = 1;
            // 
            // txtUsuarioConfig
            // 
            this.txtUsuarioConfig.Location = new System.Drawing.Point(104, 16);
            this.txtUsuarioConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioConfig.Name = "txtUsuarioConfig";
            this.txtUsuarioConfig.Size = new System.Drawing.Size(223, 22);
            this.txtUsuarioConfig.TabIndex = 0;
            this.txtUsuarioConfig.Leave += new System.EventHandler(this.txtUsuarioConfig_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Confirmar senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(8, 76);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 17);
            this.lblSenha.TabIndex = 54;
            this.lblSenha.Text = "Senha:";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbxSituacao.Location = new System.Drawing.Point(997, 73);
            this.cbxSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(155, 24);
            this.cbxSituacao.TabIndex = 4;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(883, 76);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(67, 17);
            this.lblSituacao.TabIndex = 52;
            this.lblSituacao.Text = "Situação:";
            // 
            // btnExcluirConfigUsuario
            // 
            this.btnExcluirConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirConfigUsuario.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnExcluirConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirConfigUsuario.Location = new System.Drawing.Point(1453, 159);
            this.btnExcluirConfigUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirConfigUsuario.Name = "btnExcluirConfigUsuario";
            this.btnExcluirConfigUsuario.Size = new System.Drawing.Size(153, 43);
            this.btnExcluirConfigUsuario.TabIndex = 8;
            this.btnExcluirConfigUsuario.Text = "Excluir";
            this.btnExcluirConfigUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSalvarConfigUsuario
            // 
            this.btnSalvarConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarConfigUsuario.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarConfigUsuario.Location = new System.Drawing.Point(1292, 159);
            this.btnSalvarConfigUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarConfigUsuario.Name = "btnSalvarConfigUsuario";
            this.btnSalvarConfigUsuario.Size = new System.Drawing.Size(153, 43);
            this.btnSalvarConfigUsuario.TabIndex = 7;
            this.btnSalvarConfigUsuario.Text = "Salvar";
            this.btnSalvarConfigUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarConfigUsuario.Click += new System.EventHandler(this.btnSalvarConfigUsuario_Click);
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Nutricionista",
            "Recepcionista"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(911, 124);
            this.cbxTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(219, 24);
            this.cbxTipoUsuario.TabIndex = 6;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(835, 127);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 17);
            this.lblPerfil.TabIndex = 9;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 130);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Usuário:";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(8, 209);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.Size = new System.Drawing.Size(1599, 671);
            this.dtgUsuarios.TabIndex = 9;
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            // 
            // tbPermissao
            // 
            this.tbPermissao.Controls.Add(this.cbxUsuario);
            this.tbPermissao.Controls.Add(this.dataGridView1);
            this.tbPermissao.Controls.Add(this.btnSalvarPermissao);
            this.tbPermissao.Controls.Add(this.cbxTelaLiberar);
            this.tbPermissao.Controls.Add(this.lblPrograma);
            this.tbPermissao.Controls.Add(this.label13);
            this.tbPermissao.Location = new System.Drawing.Point(4, 25);
            this.tbPermissao.Margin = new System.Windows.Forms.Padding(4);
            this.tbPermissao.Name = "tbPermissao";
            this.tbPermissao.Padding = new System.Windows.Forms.Padding(4);
            this.tbPermissao.Size = new System.Drawing.Size(1619, 897);
            this.tbPermissao.TabIndex = 1;
            this.tbPermissao.Text = "Permissões";
            this.tbPermissao.UseVisualStyleBackColor = true;
            this.tbPermissao.Enter += new System.EventHandler(this.tbPermissao_Enter);
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(160, 19);
            this.cbxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(219, 24);
            this.cbxUsuario.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1599, 675);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnSalvarPermissao
            // 
            this.btnSalvarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPermissao.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarPermissao.Location = new System.Drawing.Point(1456, 163);
            this.btnSalvarPermissao.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarPermissao.Name = "btnSalvarPermissao";
            this.btnSalvarPermissao.Size = new System.Drawing.Size(153, 43);
            this.btnSalvarPermissao.TabIndex = 12;
            this.btnSalvarPermissao.Text = "Salvar";
            this.btnSalvarPermissao.UseVisualStyleBackColor = true;
            this.btnSalvarPermissao.Click += new System.EventHandler(this.btnSalvarPermissao_Click);
            // 
            // cbxTelaLiberar
            // 
            this.cbxTelaLiberar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTelaLiberar.FormattingEnabled = true;
            this.cbxTelaLiberar.Items.AddRange(new object[] {
            "Agenda",
            "Alimento",
            "Cardápio",
            "Paciente",
            "Receitas",
            "Configurações",
            "Sobre"});
            this.cbxTelaLiberar.Location = new System.Drawing.Point(160, 91);
            this.cbxTelaLiberar.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTelaLiberar.Name = "cbxTelaLiberar";
            this.cbxTelaLiberar.Size = new System.Drawing.Size(219, 24);
            this.cbxTelaLiberar.TabIndex = 10;
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(8, 94);
            this.lblPrograma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(74, 17);
            this.lblPrograma.TabIndex = 11;
            this.lblPrograma.Text = "Programa:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Usuário:";
            // 
            // tbSobre
            // 
            this.tbSobre.ImageKey = "information.png";
            this.tbSobre.Location = new System.Drawing.Point(4, 39);
            this.tbSobre.Margin = new System.Windows.Forms.Padding(4);
            this.tbSobre.Name = "tbSobre";
            this.tbSobre.Padding = new System.Windows.Forms.Padding(4);
            this.tbSobre.Size = new System.Drawing.Size(1641, 950);
            this.tbSobre.TabIndex = 7;
            this.tbSobre.Text = "Sobre";
            this.tbSobre.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "settings32px.png");
            this.imageList1.Images.SetKeyName(1, "Paciente32px.png");
            this.imageList1.Images.SetKeyName(2, "menu32px.png");
            this.imageList1.Images.SetKeyName(3, "Cardapio32px.png");
            this.imageList1.Images.SetKeyName(4, "Alimento32px.png");
            this.imageList1.Images.SetKeyName(5, "agenda32px.png");
            this.imageList1.Images.SetKeyName(6, "Receitas32px.png");
            this.imageList1.Images.SetKeyName(7, "information.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMenuPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 1001);
            this.Controls.Add(this.TabControlNutreasy);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlNutreasy;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutreasy";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.TabControlNutreasy.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.mCardAtendimentoAtual.ResumeLayout(false);
            this.mCardAtendimentoAtual.PerformLayout();
            this.mCardAtendimentoFuturo.ResumeLayout(false);
            this.mCardAtendimentoFuturo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).EndInit();
            this.tabAgenda.ResumeLayout(false);
            this.tabAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.tabAlimento.ResumeLayout(false);
            this.tbAlimento.ResumeLayout(false);
            this._tbConsulta.ResumeLayout(false);
            this._tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).EndInit();
            this.tbImportarPlanilha.ResumeLayout(false);
            this.tbImportarPlanilha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosImportados)).EndInit();
            this.tbCadMedCaseira.ResumeLayout(false);
            this.tbCadMedCaseira.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalvarMedCaseira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedCaseiraAlimentos)).EndInit();
            this.tabCardapio.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbCadCardapio.ResumeLayout(false);
            this.tbCadCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAliCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapioAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).EndInit();
            this.tbConsultaCardapio.ResumeLayout(false);
            this.tbConsultaCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trwDadosCard)).EndInit();
            this.tabPaciente.ResumeLayout(false);
            this.tbPaciente.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.tbAntropometricos.ResumeLayout(false);
            this.tbAntropometricos.PerformLayout();
            this.tbAnamnese.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tbConfig.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.tbPermissao.ResumeLayout(false);
            this.tbPermissao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlNutreasy;
        private System.Windows.Forms.TabPage tabMenu;
        internal System.Windows.Forms.PictureBox pbxLogoGrande;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tabAgenda;
        internal System.Windows.Forms.Button btnSalvarAgenda;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.DataGridView dtgAgenda;
        internal System.Windows.Forms.Button btnAvançar;
        internal System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabPage tabAlimento;
        internal System.Windows.Forms.TabControl tbAlimento;
        private System.Windows.Forms.TabPage _tbConsulta;
        internal System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Label lblAlimentoFiltro;
        private System.Windows.Forms.Label lblTabelaSelecionada;
        internal System.Windows.Forms.Button btnSalvarAlimento;
        private System.Windows.Forms.ComboBox cbxTabela;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlimentoFiltro;
        internal System.Windows.Forms.Label lblTabela;
        internal System.Windows.Forms.DataGridView dtgConAlimento;
        internal System.Windows.Forms.TabPage tbImportarPlanilha;
        internal System.Windows.Forms.TextBox txtNomeTabela;
        internal System.Windows.Forms.Label lblNomeTabela;
        public System.Windows.Forms.ComboBox _cbxNomePlanilha;
        private System.Windows.Forms.Button _btnImportar;
        internal System.Windows.Forms.DataGridView dtgDadosImportados;
        private System.Windows.Forms.Button _btnBuscarPlanilha;
        internal System.Windows.Forms.TextBox txtCaminhoArquivoExcel;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TabPage tabPaciente;
        internal System.Windows.Forms.TabControl tbPaciente;
        internal System.Windows.Forms.TabPage tbCadastro;
        public System.Windows.Forms.Button _btnExcluir;
        public System.Windows.Forms.Button _btnSalvar;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.Label lblNum;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtComplemento;
        internal System.Windows.Forms.Label lblComplemento;
        internal System.Windows.Forms.TextBox txtUF;
        internal System.Windows.Forms.Label lblUF;
        internal System.Windows.Forms.TextBox txtCelular;
        internal System.Windows.Forms.Label lblCelular;
        internal System.Windows.Forms.TextBox txtTelefone;
        internal System.Windows.Forms.Label lblTelefone;
        internal System.Windows.Forms.TextBox txtMunicipio;
        internal System.Windows.Forms.Label lblMunicipio;
        internal System.Windows.Forms.Label lblCEP;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.Label lblBairro;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label lblEndereco;
        internal System.Windows.Forms.Label lblDataNascimento;
        internal System.Windows.Forms.TextBox txtCPF;
        internal System.Windows.Forms.Label lblCPF;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.PictureBox pbImagem;
        internal System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tbAntropometricos;
        private System.Windows.Forms.TabPage tabConfig;
        internal System.Windows.Forms.TabControl tbConfig;
        internal System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmailConfig;
        private System.Windows.Forms.TextBox txtNomeUsuarioConfig;
        private System.Windows.Forms.TextBox txtUsuarioConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label lblSituacao;
        internal System.Windows.Forms.Button btnExcluirConfigUsuario;
        internal System.Windows.Forms.Button btnSalvarConfigUsuario;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.DataGridView dtgUsuarios;
        internal System.Windows.Forms.TabPage tbPermissao;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePaciente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn atendido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TabPage tabReceitas;
        public System.Windows.Forms.DataGridView _dtgConsultaPacientes;
        private System.Windows.Forms.DateTimePicker txtDtNasc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbAnamnese;
        private System.Windows.Forms.TabPage tbCadMedCaseira;
        internal System.Windows.Forms.DataGridView dtgSalvarMedCaseira;
        private System.Windows.Forms.TextBox txtQtdMedCas;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtDescMedCaseira;
        private System.Windows.Forms.Label lblDescMedCaseira;
        private System.Windows.Forms.TextBox txtAlimentoMedCaseira;
        private System.Windows.Forms.Label lblAlimentoMedCas;
        internal System.Windows.Forms.DataGridView dtgMedCaseiraAlimentos;
        internal System.Windows.Forms.Button btnSalvarMedCas;
        internal System.Windows.Forms.Button btnAddMedCaseira;
        private System.Windows.Forms.TextBox txtCodAlimentoMedCas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvo;
        private System.Windows.Forms.TabPage tabCardapio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCadCardapio;
        private LiveCharts.WinForms.PieChart graficoMacroNutri;
        private System.Windows.Forms.PictureBox btnAddAliCard;
        private System.Windows.Forms.ComboBox cbxRefeicao;
        internal System.Windows.Forms.Label lblDescricao;
        internal System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Button btnPacienteCardapio;
        private System.Windows.Forms.Label lblValorKcal;
        private System.Windows.Forms.Label lblVlrKcal;
        internal System.Windows.Forms.Label lblTabelaCardapio;
        private System.Windows.Forms.ComboBox cbxTabelaAlimentoCardapio;
        internal System.Windows.Forms.DataGridView dtgCardapioAlimentos;
        internal System.Windows.Forms.DataGridView dtgRefeicoes;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button btnSalvarCardapio;
        internal System.Windows.Forms.TextBox txtFiltroAlimento;
        internal System.Windows.Forms.Button btnConfigGramasCard;
        private System.Windows.Forms.TabPage tbConsultaCardapio;
        internal System.Windows.Forms.TextBox txtPacienteConsultaCardapio;
        private System.Windows.Forms.Button btnBuscaPaciente;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnCancelarCardapio;
        private System.Windows.Forms.TabPage tbSobre;
        private System.Windows.Forms.Button btnCapturarImagem;
        internal System.Windows.Forms.Label txtCodPaciente;
        internal System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TabPage tbCadastrarTiposCardapios;
        private MaterialSkin.Controls.MaterialCard mCardAtendimentoAtual;
        private MaterialSkin.Controls.MaterialLabel mlblObservação;
        private MaterialSkin.Controls.MaterialLabel mlblHorario;
        private MaterialSkin.Controls.MaterialLabel mlblNome;
        private MaterialSkin.Controls.MaterialCheckbox mcbxCancelar;
        private MaterialSkin.Controls.MaterialCheckbox mcbxAtendido;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard mCardAtendimentoFuturo;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCheckbox mcbxCancelarFuturo;
        private MaterialSkin.Controls.MaterialCheckbox mcbxAtendidoFuturo;
        private MaterialSkin.Controls.MaterialLabel mlblObservacaoFuturo;
        private MaterialSkin.Controls.MaterialLabel mlblHoraFutura;
        private MaterialSkin.Controls.MaterialLabel mlblNomeFuturo;
        private TreeGridView trwDadosCard;
        public System.Windows.Forms.Button btnCancelarEditAlimentos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private MvtWindowsForms.RitchTextBoxWithToolBar ritchTextBoxWithToolBar1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnSalvarPermissao;
        private System.Windows.Forms.ComboBox cbxTelaLiberar;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.ComboBox cbxUsuario;
    }
}

