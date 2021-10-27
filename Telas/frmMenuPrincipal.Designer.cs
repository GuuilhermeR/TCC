using AdvancedDataGridView;

namespace TCC2
{
    partial class FrmMenuPrincipal
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange8 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange9 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange10 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange11 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange12 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange13 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange14 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.TabControlNutreasy = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.mCardAtendimentoAtual = new MaterialSkin.Controls.MaterialCard();
            this.mcbxCancelar = new MaterialSkin.Controls.MaterialCheckbox();
            this.mcbxAtendido = new MaterialSkin.Controls.MaterialCheckbox();
            this.mlblObservação = new MaterialSkin.Controls.MaterialLabel();
            this.mlblHorario = new MaterialSkin.Controls.MaterialLabel();
            this.mlblNome = new MaterialSkin.Controls.MaterialLabel();
            this.mCardAtendimentoFuturo = new MaterialSkin.Controls.MaterialCard();
            this.mcbxCancelarFuturo = new MaterialSkin.Controls.MaterialCheckbox();
            this.mcbxAtendidoFuturo = new MaterialSkin.Controls.MaterialCheckbox();
            this.mlblObservacaoFuturo = new MaterialSkin.Controls.MaterialLabel();
            this.mlblHoraFutura = new MaterialSkin.Controls.MaterialLabel();
            this.mlblNomeFuturo = new MaterialSkin.Controls.MaterialLabel();
            this.pbxLogoGrande = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPacNew = new MaterialSkin.Controls.MaterialCheckbox();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.cbxRetorno = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtPacienteAgenda = new MaterialSkin.Controls.MaterialTextBox();
            this.txtHoraAgenda = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataAgendamento = new MaterialSkin.Controls.MaterialTextBox();
            this.calAgendamento = new System.Windows.Forms.Calendar.Calendar();
            this.btnSalvarAgenda = new System.Windows.Forms.Button();
            this.btnBuscarPacienteAgendamento = new System.Windows.Forms.Button();
            this.tabAlimento = new System.Windows.Forms.TabPage();
            this.tbAlimento = new System.Windows.Forms.TabControl();
            this._tbConsulta = new System.Windows.Forms.TabPage();
            this.txtAlimentoFiltro = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.cbxTabela = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCancelarEditAlimentos = new System.Windows.Forms.Button();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.btnSalvarAlimento = new System.Windows.Forms.Button();
            this.dtgConAlimento = new System.Windows.Forms.DataGridView();
            this.tbImportarPlanilha = new System.Windows.Forms.TabPage();
            this.txtNomeTabela = new MaterialSkin.Controls.MaterialTextBox();
            this._cbxNomePlanilha = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCaminhoArquivoExcel = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgDadosImportados = new System.Windows.Forms.DataGridView();
            this._btnImportar = new System.Windows.Forms.Button();
            this._btnBuscarPlanilha = new System.Windows.Forms.Button();
            this.tbCadMedCaseira = new System.Windows.Forms.TabPage();
            this.pbAddMedCaseira = new System.Windows.Forms.PictureBox();
            this.mTxtFiltroAlimentoMedCas = new MaterialSkin.Controls.MaterialTextBox();
            this.mCbxTabelasMedCas = new MaterialSkin.Controls.MaterialComboBox();
            this.dtgSalvarMedCaseira = new System.Windows.Forms.DataGridView();
            this.colCodAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgMedCaseiraAlimentos = new System.Windows.Forms.DataGridView();
            this.btnSalvarMedCas = new System.Windows.Forms.Button();
            this.tabCardapio = new System.Windows.Forms.TabPage();
            this.tbCardapio = new System.Windows.Forms.TabControl();
            this.tbCadCardapio = new System.Windows.Forms.TabPage();
            this.datalbl = new MaterialSkin.Controls.MaterialLabel();
            this.lblVET = new MaterialSkin.Controls.MaterialLabel();
            this.lblTMB = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.rbDRI = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFAOOMS = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbHarrisBenedict = new MaterialSkin.Controls.MaterialRadioButton();
            this.chkTMB = new MaterialSkin.Controls.MaterialCheckbox();
            this.mlblVET = new MaterialSkin.Controls.MaterialLabel();
            this.mlblTMB = new MaterialSkin.Controls.MaterialLabel();
            this.chkDataExisteCardapio = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxDataCardSalvo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDataCardapio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLipidio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCarboidrato = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProteina = new MaterialSkin.Controls.MaterialTextBox();
            this.lblValorKcal = new MaterialSkin.Controls.MaterialLabel();
            this.lblVlrKcal = new MaterialSkin.Controls.MaterialLabel();
            this.txtFiltroAlimento = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTabelaAlimentoCardapio = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxRefeicao = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPaciente = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelarCardapio = new System.Windows.Forms.Button();
            this.graficoMacroNutri = new LiveCharts.WinForms.PieChart();
            this.btnAddAliCard = new System.Windows.Forms.PictureBox();
            this.btnPacienteCardapio = new System.Windows.Forms.Button();
            this.dtgCardapioAlimentos = new System.Windows.Forms.DataGridView();
            this.dtgRefeicoes = new System.Windows.Forms.DataGridView();
            this.codAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lipidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMedCaseira = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvarCardapio = new System.Windows.Forms.Button();
            this.tbConsultaCardapio = new System.Windows.Forms.TabPage();
            this.btnEnviarCardEmail = new System.Windows.Forms.Button();
            this.btnConsultarCardapio = new System.Windows.Forms.Button();
            this.dtgCardGrid = new MvtWindowsForms.MvtDataGridView();
            this.refeicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidacaseiraqtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDataConsulta = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPacienteConsultaCardapio = new MaterialSkin.Controls.MaterialTextBox();
            this.trwDadosCard = new AdvancedDataGridView.TreeGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnApagarCardapio = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this.tabPaciente = new System.Windows.Forms.TabPage();
            this.tbPaciente = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.rbFeminino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtDtNasc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCelular = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtComplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUF = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMunicipio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBairro = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEndereco = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCEP = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCPF = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodPaciente = new System.Windows.Forms.Label();
            this.btnCapturarImagem = new System.Windows.Forms.Button();
            this._dtgConsultaPacientes = new System.Windows.Forms.DataGridView();
            this._btnExcluir = new System.Windows.Forms.Button();
            this._btnSalvar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.tbAntropometricos = new System.Windows.Forms.TabPage();
            this.cbxDataExisteAntro = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtDataAntro = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxDataAntrop = new MaterialSkin.Controls.MaterialComboBox();
            this.gbxCircunferencias = new System.Windows.Forms.GroupBox();
            this.txtAbdome = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPescoco = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvarAntro = new System.Windows.Forms.Button();
            this.txtTorax = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPunho = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCoxa = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPanturrilha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuadril = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAntebraco = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCintura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBraco = new MaterialSkin.Controls.MaterialTextBox();
            this.gbxEstatura = new System.Windows.Forms.GroupBox();
            this.tabCalculo = new System.Windows.Forms.TabControl();
            this.tbDRI = new System.Windows.Forms.TabPage();
            this.rbDRIMuitoAtivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDRIAtivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDRIPoucoAtivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDRISedentario = new MaterialSkin.Controls.MaterialRadioButton();
            this.tbHarrisBenedict = new System.Windows.Forms.TabPage();
            this.rbCAFMuitoPesado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCAFPesado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCAFModerado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCAFLeve = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCAFSedentario = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtPeso = new MaterialSkin.Controls.MaterialTextBox();
            this.lblIMC = new MaterialSkin.Controls.MaterialLabel();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPacienteAntro = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnClearAntro = new System.Windows.Forms.Button();
            this.btnPacAnt = new System.Windows.Forms.Button();
            this.tbAnamnese = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxCarregarTemplate = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxDataAnamnese = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPacienteAnamnese = new MaterialSkin.Controls.MaterialTextBox();
            this.rtxtAnamnese = new MvtWindowsForms.RitchTextBoxWithToolBar();
            this.btnConfigAnamnese = new System.Windows.Forms.Button();
            this.btnFindPacienteAnamnese = new System.Windows.Forms.Button();
            this.btnSalvarAnamnese = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tbConfig = new System.Windows.Forms.TabControl();
            this.tbUsuarios = new System.Windows.Forms.TabPage();
            this.txtCRN = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmailConfig = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxSituacao = new MaterialSkin.Controls.MaterialComboBox();
            this.txtConfirmarSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNomeUsuarioConfig = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsuarioConfig = new MaterialSkin.Controls.MaterialTextBox();
            this.btnExcluirConfigUsuario = new System.Windows.Forms.Button();
            this.btnSalvarConfigUsuario = new System.Windows.Forms.Button();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.tbPermissao = new System.Windows.Forms.TabPage();
            this.btnExcluirPerm = new System.Windows.Forms.Button();
            this.cbxTelaLiberarPerm = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxUsuarioPerm = new MaterialSkin.Controls.MaterialComboBox();
            this.dtgPermUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalvarPermissao = new System.Windows.Forms.Button();
            this.tabHorarioAtendimento = new System.Windows.Forms.TabPage();
            this.dtgConfigHorario = new System.Windows.Forms.DataGridView();
            this.txtHoraFim = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxDiaSemana = new MaterialSkin.Controls.MaterialComboBox();
            this.txtHoraInicio = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxUsuNutri = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSalvarHoraAtend = new System.Windows.Forms.Button();
            this.tbSobre = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NutriEzIconNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabControlNutreasy.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.mCardAtendimentoAtual.SuspendLayout();
            this.mCardAtendimentoFuturo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).BeginInit();
            this.tabAgenda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAlimento.SuspendLayout();
            this.tbAlimento.SuspendLayout();
            this._tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).BeginInit();
            this.tbImportarPlanilha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosImportados)).BeginInit();
            this.tbCadMedCaseira.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddMedCaseira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalvarMedCaseira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedCaseiraAlimentos)).BeginInit();
            this.tabCardapio.SuspendLayout();
            this.tbCardapio.SuspendLayout();
            this.tbCadCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAliCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapioAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).BeginInit();
            this.tbConsultaCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trwDadosCard)).BeginInit();
            this.tabPaciente.SuspendLayout();
            this.tbPaciente.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.tbAntropometricos.SuspendLayout();
            this.gbxCircunferencias.SuspendLayout();
            this.gbxEstatura.SuspendLayout();
            this.tabCalculo.SuspendLayout();
            this.tbDRI.SuspendLayout();
            this.tbHarrisBenedict.SuspendLayout();
            this.tbAnamnese.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.tbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.tbPermissao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermUsuarios)).BeginInit();
            this.tabHorarioAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfigHorario)).BeginInit();
            this.tbSobre.SuspendLayout();
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
            this.TabControlNutreasy.Controls.Add(this.tabConfig);
            this.TabControlNutreasy.Controls.Add(this.tbSobre);
            this.TabControlNutreasy.Depth = 0;
            this.TabControlNutreasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlNutreasy.HotTrack = true;
            this.TabControlNutreasy.ImageList = this.imageList1;
            this.TabControlNutreasy.Location = new System.Drawing.Point(0, 64);
            this.TabControlNutreasy.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlNutreasy.Multiline = true;
            this.TabControlNutreasy.Name = "TabControlNutreasy";
            this.TabControlNutreasy.SelectedIndex = 0;
            this.TabControlNutreasy.Size = new System.Drawing.Size(1230, 760);
            this.TabControlNutreasy.TabIndex = 13;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.White;
            this.tabMenu.Controls.Add(this.mCardAtendimentoAtual);
            this.tabMenu.Controls.Add(this.mCardAtendimentoFuturo);
            this.tabMenu.Controls.Add(this.pbxLogoGrande);
            this.tabMenu.Controls.Add(this.lblUsuario);
            this.tabMenu.ImageKey = "menu32px.png";
            this.tabMenu.Location = new System.Drawing.Point(4, 39);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1222, 717);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Home";
            this.tabMenu.Enter += new System.EventHandler(this.tabMenu_Enter);
            // 
            // mCardAtendimentoAtual
            // 
            this.mCardAtendimentoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardAtendimentoAtual.Controls.Add(this.mcbxCancelar);
            this.mCardAtendimentoAtual.Controls.Add(this.mcbxAtendido);
            this.mCardAtendimentoAtual.Controls.Add(this.mlblObservação);
            this.mCardAtendimentoAtual.Controls.Add(this.mlblHorario);
            this.mCardAtendimentoAtual.Controls.Add(this.mlblNome);
            this.mCardAtendimentoAtual.Depth = 0;
            this.mCardAtendimentoAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardAtendimentoAtual.Location = new System.Drawing.Point(17, 68);
            this.mCardAtendimentoAtual.Margin = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoAtual.Name = "mCardAtendimentoAtual";
            this.mCardAtendimentoAtual.Padding = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoAtual.Size = new System.Drawing.Size(337, 231);
            this.mCardAtendimentoAtual.TabIndex = 10;
            this.mCardAtendimentoAtual.Visible = false;
            // 
            // mcbxCancelar
            // 
            this.mcbxCancelar.AutoSize = true;
            this.mcbxCancelar.Depth = 0;
            this.mcbxCancelar.Location = new System.Drawing.Point(14, 179);
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
            this.mcbxAtendido.Location = new System.Drawing.Point(14, 126);
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
            this.mlblObservação.Location = new System.Drawing.Point(17, 97);
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
            this.mlblHorario.Location = new System.Drawing.Point(17, 55);
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
            this.mlblNome.Location = new System.Drawing.Point(17, 14);
            this.mlblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNome.Name = "mlblNome";
            this.mlblNome.Size = new System.Drawing.Size(43, 19);
            this.mlblNome.TabIndex = 11;
            this.mlblNome.Text = "Nome";
            // 
            // mCardAtendimentoFuturo
            // 
            this.mCardAtendimentoFuturo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mCardAtendimentoFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardAtendimentoFuturo.Controls.Add(this.mcbxCancelarFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mcbxAtendidoFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblObservacaoFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblHoraFutura);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblNomeFuturo);
            this.mCardAtendimentoFuturo.Depth = 0;
            this.mCardAtendimentoFuturo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardAtendimentoFuturo.Location = new System.Drawing.Point(868, 68);
            this.mCardAtendimentoFuturo.Margin = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoFuturo.Name = "mCardAtendimentoFuturo";
            this.mCardAtendimentoFuturo.Padding = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoFuturo.Size = new System.Drawing.Size(337, 231);
            this.mCardAtendimentoFuturo.TabIndex = 18;
            this.mCardAtendimentoFuturo.Visible = false;
            // 
            // mcbxCancelarFuturo
            // 
            this.mcbxCancelarFuturo.AutoSize = true;
            this.mcbxCancelarFuturo.Depth = 0;
            this.mcbxCancelarFuturo.Location = new System.Drawing.Point(14, 179);
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
            this.mcbxAtendidoFuturo.Location = new System.Drawing.Point(14, 126);
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
            this.mlblObservacaoFuturo.Location = new System.Drawing.Point(17, 97);
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
            this.mlblHoraFutura.Location = new System.Drawing.Point(17, 55);
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
            this.mlblNomeFuturo.Location = new System.Drawing.Point(17, 14);
            this.mlblNomeFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNomeFuturo.Name = "mlblNomeFuturo";
            this.mlblNomeFuturo.Size = new System.Drawing.Size(43, 19);
            this.mlblNomeFuturo.TabIndex = 11;
            this.mlblNomeFuturo.Text = "Nome";
            // 
            // pbxLogoGrande
            // 
            this.pbxLogoGrande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogoGrande.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoGrande.Image = global::TCC2.Properties.Resources.iconTCC_removebg_preview__1____Copia;
            this.pbxLogoGrande.Location = new System.Drawing.Point(181, 81);
            this.pbxLogoGrande.Name = "pbxLogoGrande";
            this.pbxLogoGrande.Size = new System.Drawing.Size(768, 520);
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
            this.lblUsuario.Location = new System.Drawing.Point(1171, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 19);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // tabAgenda
            // 
            this.tabAgenda.BackColor = System.Drawing.Color.White;
            this.tabAgenda.Controls.Add(this.groupBox1);
            this.tabAgenda.Controls.Add(this.chkPacNew);
            this.tabAgenda.Controls.Add(this.mCalendar);
            this.tabAgenda.Controls.Add(this.cbxRetorno);
            this.tabAgenda.Controls.Add(this.txtPacienteAgenda);
            this.tabAgenda.Controls.Add(this.txtHoraAgenda);
            this.tabAgenda.Controls.Add(this.txtDataAgendamento);
            this.tabAgenda.Controls.Add(this.calAgendamento);
            this.tabAgenda.Controls.Add(this.btnSalvarAgenda);
            this.tabAgenda.Controls.Add(this.btnBuscarPacienteAgendamento);
            this.tabAgenda.ImageKey = "agenda32px.png";
            this.tabAgenda.Location = new System.Drawing.Point(4, 39);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(1222, 717);
            this.tabAgenda.TabIndex = 1;
            this.tabAgenda.Text = "Agenda";
            this.tabAgenda.Enter += new System.EventHandler(this.tabAgenda_Enter);
            this.tabAgenda.Leave += new System.EventHandler(this.tabAgenda_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1109, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 100);
            this.groupBox1.TabIndex = 312;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legenda";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 319;
            this.label9.Text = "Pendente";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 318;
            this.label8.Text = "Atendido";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 317;
            this.label6.Text = "Retorno";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 316;
            this.label5.Text = "Cancelado";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightYellow;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 315;
            this.label4.Text = "   ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 314;
            this.label3.Text = "   ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 313;
            this.label2.Text = "   ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 312;
            this.label1.Text = "   ";
            // 
            // chkPacNew
            // 
            this.chkPacNew.AutoSize = true;
            this.chkPacNew.Depth = 0;
            this.chkPacNew.Location = new System.Drawing.Point(233, 12);
            this.chkPacNew.Margin = new System.Windows.Forms.Padding(0);
            this.chkPacNew.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPacNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPacNew.Name = "chkPacNew";
            this.chkPacNew.Ripple = true;
            this.chkPacNew.Size = new System.Drawing.Size(157, 37);
            this.chkPacNew.TabIndex = 303;
            this.chkPacNew.Text = "Novo S/Cadastro";
            this.chkPacNew.UseVisualStyleBackColor = true;
            this.chkPacNew.CheckedChanged += new System.EventHandler(this.chkPacNew_CheckedChanged);
            // 
            // mCalendar
            // 
            this.mCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.mCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.mCalendar.Location = new System.Drawing.Point(399, 12);
            this.mCalendar.MaxSelectionCount = 360;
            this.mCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 0;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendar_DateChanged);
            // 
            // cbxRetorno
            // 
            this.cbxRetorno.AutoSize = true;
            this.cbxRetorno.Depth = 0;
            this.cbxRetorno.Location = new System.Drawing.Point(199, 128);
            this.cbxRetorno.Margin = new System.Windows.Forms.Padding(0);
            this.cbxRetorno.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxRetorno.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxRetorno.Name = "cbxRetorno";
            this.cbxRetorno.Ripple = true;
            this.cbxRetorno.Size = new System.Drawing.Size(90, 37);
            this.cbxRetorno.TabIndex = 4;
            this.cbxRetorno.Text = "Retorno";
            this.cbxRetorno.UseVisualStyleBackColor = true;
            // 
            // txtPacienteAgenda
            // 
            this.txtPacienteAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteAgenda.Depth = 0;
            this.txtPacienteAgenda.Enabled = false;
            this.txtPacienteAgenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteAgenda.Hint = "Paciente";
            this.txtPacienteAgenda.LeadingIcon = null;
            this.txtPacienteAgenda.Location = new System.Drawing.Point(6, 6);
            this.txtPacienteAgenda.MaxLength = 50;
            this.txtPacienteAgenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteAgenda.Multiline = false;
            this.txtPacienteAgenda.Name = "txtPacienteAgenda";
            this.txtPacienteAgenda.Size = new System.Drawing.Size(188, 50);
            this.txtPacienteAgenda.TabIndex = 0;
            this.txtPacienteAgenda.Text = "";
            this.txtPacienteAgenda.TrailingIcon = null;
            // 
            // txtHoraAgenda
            // 
            this.txtHoraAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraAgenda.Depth = 0;
            this.txtHoraAgenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoraAgenda.Hint = "Hora";
            this.txtHoraAgenda.LeadingIcon = null;
            this.txtHoraAgenda.Location = new System.Drawing.Point(4, 115);
            this.txtHoraAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraAgenda.MaxLength = 5;
            this.txtHoraAgenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoraAgenda.Multiline = false;
            this.txtHoraAgenda.Name = "txtHoraAgenda";
            this.txtHoraAgenda.Size = new System.Drawing.Size(188, 50);
            this.txtHoraAgenda.TabIndex = 3;
            this.txtHoraAgenda.Text = "";
            this.txtHoraAgenda.TrailingIcon = null;
            this.txtHoraAgenda.Validated += new System.EventHandler(this.txtHoraAgenda_Validated);
            // 
            // txtDataAgendamento
            // 
            this.txtDataAgendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataAgendamento.Depth = 0;
            this.txtDataAgendamento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataAgendamento.Hint = "Data";
            this.txtDataAgendamento.LeadingIcon = null;
            this.txtDataAgendamento.Location = new System.Drawing.Point(5, 61);
            this.txtDataAgendamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataAgendamento.MaxLength = 10;
            this.txtDataAgendamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataAgendamento.Multiline = false;
            this.txtDataAgendamento.Name = "txtDataAgendamento";
            this.txtDataAgendamento.Size = new System.Drawing.Size(188, 50);
            this.txtDataAgendamento.TabIndex = 2;
            this.txtDataAgendamento.Text = "";
            this.txtDataAgendamento.TrailingIcon = null;
            this.txtDataAgendamento.Leave += new System.EventHandler(this.txtDataAgendamento_Leave);
            // 
            // calAgendamento
            // 
            this.calAgendamento.AllowItemResize = false;
            this.calAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calAgendamento.BackColor = System.Drawing.SystemColors.Control;
            this.calAgendamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange11.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange11.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange11.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange12.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange12.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange12.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange13.DayOfWeek = System.DayOfWeek.Saturday;
            calendarHighlightRange13.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange13.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange14.DayOfWeek = System.DayOfWeek.Sunday;
            calendarHighlightRange14.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange14.StartTime = System.TimeSpan.Parse("00:00:00");
            this.calAgendamento.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10,
        calendarHighlightRange11,
        calendarHighlightRange12,
        calendarHighlightRange13,
        calendarHighlightRange14};
            this.calAgendamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calAgendamento.ItemsTimeFormat = "hh:mm";
            this.calAgendamento.Location = new System.Drawing.Point(3, 195);
            this.calAgendamento.MaximumFullDays = 360;
            this.calAgendamento.Name = "calAgendamento";
            this.calAgendamento.Size = new System.Drawing.Size(1207, 510);
            this.calAgendamento.TabIndex = 55;
            this.calAgendamento.Text = "Agendamento";
            this.calAgendamento.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            this.calAgendamento.ItemCreating += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calAgendamento_ItemCreating);
            this.calAgendamento.ItemCreated += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calAgendamento_ItemCreated);
            this.calAgendamento.ItemDeleted += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calAgendamento_ItemDeleted);
            this.calAgendamento.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calAgendamento_ItemDatesChanged);
            this.calAgendamento.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calAgendamento_ItemDoubleClick);
            this.calAgendamento.ItemSelected += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calAgendamento_ItemSelected);
            // 
            // btnSalvarAgenda
            // 
            this.btnSalvarAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAgenda.AutoSize = true;
            this.btnSalvarAgenda.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAgenda.Location = new System.Drawing.Point(1095, 154);
            this.btnSalvarAgenda.Name = "btnSalvarAgenda";
            this.btnSalvarAgenda.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAgenda.TabIndex = 5;
            this.btnSalvarAgenda.Text = "Salvar";
            this.btnSalvarAgenda.UseVisualStyleBackColor = true;
            this.btnSalvarAgenda.Click += new System.EventHandler(this.btnSalvarAgenda_Click);
            // 
            // btnBuscarPacienteAgendamento
            // 
            this.btnBuscarPacienteAgendamento.Image = global::TCC2.Properties.Resources.consultar;
            this.btnBuscarPacienteAgendamento.Location = new System.Drawing.Point(200, 18);
            this.btnBuscarPacienteAgendamento.Name = "btnBuscarPacienteAgendamento";
            this.btnBuscarPacienteAgendamento.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarPacienteAgendamento.TabIndex = 302;
            this.btnBuscarPacienteAgendamento.UseVisualStyleBackColor = true;
            this.btnBuscarPacienteAgendamento.Click += new System.EventHandler(this.btnBuscarPacienteAgendamento_Click);
            // 
            // tabAlimento
            // 
            this.tabAlimento.AllowDrop = true;
            this.tabAlimento.BackColor = System.Drawing.Color.White;
            this.tabAlimento.Controls.Add(this.tbAlimento);
            this.tabAlimento.ImageKey = "Alimento32px.png";
            this.tabAlimento.Location = new System.Drawing.Point(4, 39);
            this.tabAlimento.Name = "tabAlimento";
            this.tabAlimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlimento.Size = new System.Drawing.Size(1222, 717);
            this.tabAlimento.TabIndex = 2;
            this.tabAlimento.Text = "Alimento";
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
            this.tbAlimento.Location = new System.Drawing.Point(6, 4);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.SelectedIndex = 0;
            this.tbAlimento.Size = new System.Drawing.Size(1203, 702);
            this.tbAlimento.TabIndex = 3;
            this.tbAlimento.Enter += new System.EventHandler(this.tbAlimento_Enter);
            // 
            // _tbConsulta
            // 
            this._tbConsulta.Controls.Add(this.txtAlimentoFiltro);
            this._tbConsulta.Controls.Add(this.label7);
            this._tbConsulta.Controls.Add(this.lblTabela);
            this._tbConsulta.Controls.Add(this.cbxTabela);
            this._tbConsulta.Controls.Add(this.btnCancelarEditAlimentos);
            this._tbConsulta.Controls.Add(this.btnRecalcular);
            this._tbConsulta.Controls.Add(this.btnSalvarAlimento);
            this._tbConsulta.Controls.Add(this.dtgConAlimento);
            this._tbConsulta.Location = new System.Drawing.Point(4, 22);
            this._tbConsulta.Name = "_tbConsulta";
            this._tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this._tbConsulta.Size = new System.Drawing.Size(1195, 676);
            this._tbConsulta.TabIndex = 1;
            this._tbConsulta.Text = "Cadastro/Consulta";
            this._tbConsulta.UseVisualStyleBackColor = true;
            // 
            // txtAlimentoFiltro
            // 
            this.txtAlimentoFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlimentoFiltro.Depth = 0;
            this.txtAlimentoFiltro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlimentoFiltro.Hint = "Alimento";
            this.txtAlimentoFiltro.LeadingIcon = null;
            this.txtAlimentoFiltro.Location = new System.Drawing.Point(6, 74);
            this.txtAlimentoFiltro.MaxLength = 50;
            this.txtAlimentoFiltro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlimentoFiltro.Multiline = false;
            this.txtAlimentoFiltro.Name = "txtAlimentoFiltro";
            this.txtAlimentoFiltro.Size = new System.Drawing.Size(659, 50);
            this.txtAlimentoFiltro.TabIndex = 1;
            this.txtAlimentoFiltro.Text = "";
            this.txtAlimentoFiltro.TrailingIcon = null;
            this.txtAlimentoFiltro.Leave += new System.EventHandler(this.txtAlimentoFiltro_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 4;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(6, 9);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(0, 13);
            this.lblTabela.TabIndex = 2;
            // 
            // cbxTabela
            // 
            this.cbxTabela.AutoResize = false;
            this.cbxTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTabela.Depth = 0;
            this.cbxTabela.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTabela.DropDownHeight = 174;
            this.cbxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabela.DropDownWidth = 121;
            this.cbxTabela.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTabela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Hint = "Tabela";
            this.cbxTabela.IntegralHeight = false;
            this.cbxTabela.ItemHeight = 43;
            this.cbxTabela.Location = new System.Drawing.Point(6, 13);
            this.cbxTabela.MaxDropDownItems = 4;
            this.cbxTabela.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(659, 49);
            this.cbxTabela.StartIndex = 0;
            this.cbxTabela.TabIndex = 0;
            this.cbxTabela.SelectedValueChanged += new System.EventHandler(this.cbxTabela_SelectedValueChanged);
            // 
            // btnCancelarEditAlimentos
            // 
            this.btnCancelarEditAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEditAlimentos.AutoSize = true;
            this.btnCancelarEditAlimentos.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelarEditAlimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEditAlimentos.Location = new System.Drawing.Point(1074, 635);
            this.btnCancelarEditAlimentos.Name = "btnCancelarEditAlimentos";
            this.btnCancelarEditAlimentos.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarEditAlimentos.TabIndex = 5;
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
            this.btnRecalcular.Location = new System.Drawing.Point(6, 630);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(115, 38);
            this.btnRecalcular.TabIndex = 3;
            this.btnRecalcular.Text = "Calcular";
            this.btnRecalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // btnSalvarAlimento
            // 
            this.btnSalvarAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAlimento.AutoSize = true;
            this.btnSalvarAlimento.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAlimento.Location = new System.Drawing.Point(953, 635);
            this.btnSalvarAlimento.Name = "btnSalvarAlimento";
            this.btnSalvarAlimento.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAlimento.TabIndex = 4;
            this.btnSalvarAlimento.Text = "Salvar";
            this.btnSalvarAlimento.UseVisualStyleBackColor = true;
            this.btnSalvarAlimento.Click += new System.EventHandler(this.btnSalvarAlimento_Click);
            // 
            // dtgConAlimento
            // 
            this.dtgConAlimento.AllowDrop = true;
            this.dtgConAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConAlimento.BackgroundColor = System.Drawing.Color.White;
            this.dtgConAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConAlimento.Location = new System.Drawing.Point(6, 129);
            this.dtgConAlimento.Name = "dtgConAlimento";
            this.dtgConAlimento.RowHeadersWidth = 51;
            this.dtgConAlimento.Size = new System.Drawing.Size(1185, 496);
            this.dtgConAlimento.TabIndex = 2;
            this.dtgConAlimento.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgConAlimento_CellBeginEdit);
            this.dtgConAlimento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConAlimento_CellEndEdit);
            // 
            // tbImportarPlanilha
            // 
            this.tbImportarPlanilha.AllowDrop = true;
            this.tbImportarPlanilha.Controls.Add(this.txtNomeTabela);
            this.tbImportarPlanilha.Controls.Add(this._cbxNomePlanilha);
            this.tbImportarPlanilha.Controls.Add(this.txtCaminhoArquivoExcel);
            this.tbImportarPlanilha.Controls.Add(this.dtgDadosImportados);
            this.tbImportarPlanilha.Controls.Add(this._btnImportar);
            this.tbImportarPlanilha.Controls.Add(this._btnBuscarPlanilha);
            this.tbImportarPlanilha.Location = new System.Drawing.Point(4, 22);
            this.tbImportarPlanilha.Name = "tbImportarPlanilha";
            this.tbImportarPlanilha.Padding = new System.Windows.Forms.Padding(3);
            this.tbImportarPlanilha.Size = new System.Drawing.Size(1195, 676);
            this.tbImportarPlanilha.TabIndex = 2;
            this.tbImportarPlanilha.Text = "Importação tabela";
            this.tbImportarPlanilha.UseVisualStyleBackColor = true;
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeTabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeTabela.Depth = 0;
            this.txtNomeTabela.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeTabela.Hint = "Nome Tabela";
            this.txtNomeTabela.LeadingIcon = null;
            this.txtNomeTabela.Location = new System.Drawing.Point(9, 618);
            this.txtNomeTabela.MaxLength = 50;
            this.txtNomeTabela.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeTabela.Multiline = false;
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(659, 50);
            this.txtNomeTabela.TabIndex = 3;
            this.txtNomeTabela.Text = "";
            this.txtNomeTabela.TrailingIcon = null;
            // 
            // _cbxNomePlanilha
            // 
            this._cbxNomePlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbxNomePlanilha.AutoResize = false;
            this._cbxNomePlanilha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._cbxNomePlanilha.Depth = 0;
            this._cbxNomePlanilha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._cbxNomePlanilha.DropDownHeight = 174;
            this._cbxNomePlanilha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxNomePlanilha.DropDownWidth = 121;
            this._cbxNomePlanilha.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._cbxNomePlanilha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._cbxNomePlanilha.FormattingEnabled = true;
            this._cbxNomePlanilha.Hint = "Nome da Planilha";
            this._cbxNomePlanilha.IntegralHeight = false;
            this._cbxNomePlanilha.ItemHeight = 43;
            this._cbxNomePlanilha.Location = new System.Drawing.Point(9, 565);
            this._cbxNomePlanilha.MaxDropDownItems = 4;
            this._cbxNomePlanilha.MouseState = MaterialSkin.MouseState.OUT;
            this._cbxNomePlanilha.Name = "_cbxNomePlanilha";
            this._cbxNomePlanilha.Size = new System.Drawing.Size(659, 49);
            this._cbxNomePlanilha.StartIndex = 0;
            this._cbxNomePlanilha.TabIndex = 2;
            this._cbxNomePlanilha.SelectedIndexChanged += new System.EventHandler(this._cbxNomePlanilha_SelectedIndexChanged);
            // 
            // txtCaminhoArquivoExcel
            // 
            this.txtCaminhoArquivoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCaminhoArquivoExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminhoArquivoExcel.Depth = 0;
            this.txtCaminhoArquivoExcel.Enabled = false;
            this.txtCaminhoArquivoExcel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaminhoArquivoExcel.Hint = "Caminho do Arquivo";
            this.txtCaminhoArquivoExcel.LeadingIcon = null;
            this.txtCaminhoArquivoExcel.Location = new System.Drawing.Point(9, 509);
            this.txtCaminhoArquivoExcel.MaxLength = 50;
            this.txtCaminhoArquivoExcel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCaminhoArquivoExcel.Multiline = false;
            this.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            this.txtCaminhoArquivoExcel.ReadOnly = true;
            this.txtCaminhoArquivoExcel.Size = new System.Drawing.Size(659, 50);
            this.txtCaminhoArquivoExcel.TabIndex = 0;
            this.txtCaminhoArquivoExcel.Text = "";
            this.txtCaminhoArquivoExcel.TrailingIcon = null;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDadosImportados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDadosImportados.Location = new System.Drawing.Point(9, 2);
            this.dtgDadosImportados.Name = "dtgDadosImportados";
            this.dtgDadosImportados.RowHeadersWidth = 51;
            this.dtgDadosImportados.Size = new System.Drawing.Size(1185, 496);
            this.dtgDadosImportados.TabIndex = 268;
            this.dtgDadosImportados.DragDrop += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragDrop);
            this.dtgDadosImportados.DragEnter += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragEnter);
            // 
            // _btnImportar
            // 
            this._btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportar.AutoSize = true;
            this._btnImportar.Image = global::TCC2.Properties.Resources.database_import_icon_135719;
            this._btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnImportar.Location = new System.Drawing.Point(1074, 630);
            this._btnImportar.Name = "_btnImportar";
            this._btnImportar.Size = new System.Drawing.Size(115, 38);
            this._btnImportar.TabIndex = 4;
            this._btnImportar.Text = "Importar";
            this._btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnImportar.UseVisualStyleBackColor = true;
            this._btnImportar.Click += new System.EventHandler(this._btnImportar_Click);
            // 
            // _btnBuscarPlanilha
            // 
            this._btnBuscarPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBuscarPlanilha.Image = global::TCC2.Properties.Resources.consultar;
            this._btnBuscarPlanilha.Location = new System.Drawing.Point(674, 518);
            this._btnBuscarPlanilha.Name = "_btnBuscarPlanilha";
            this._btnBuscarPlanilha.Size = new System.Drawing.Size(27, 26);
            this._btnBuscarPlanilha.TabIndex = 1;
            this._btnBuscarPlanilha.UseVisualStyleBackColor = true;
            this._btnBuscarPlanilha.Click += new System.EventHandler(this._btnBuscarPlanilha_Click);
            // 
            // tbCadMedCaseira
            // 
            this.tbCadMedCaseira.Controls.Add(this.pbAddMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.mTxtFiltroAlimentoMedCas);
            this.tbCadMedCaseira.Controls.Add(this.mCbxTabelasMedCas);
            this.tbCadMedCaseira.Controls.Add(this.dtgSalvarMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.dtgMedCaseiraAlimentos);
            this.tbCadMedCaseira.Controls.Add(this.btnSalvarMedCas);
            this.tbCadMedCaseira.Location = new System.Drawing.Point(4, 22);
            this.tbCadMedCaseira.Margin = new System.Windows.Forms.Padding(2);
            this.tbCadMedCaseira.Name = "tbCadMedCaseira";
            this.tbCadMedCaseira.Padding = new System.Windows.Forms.Padding(2);
            this.tbCadMedCaseira.Size = new System.Drawing.Size(1195, 676);
            this.tbCadMedCaseira.TabIndex = 3;
            this.tbCadMedCaseira.Text = "Cadastrar Medida Caseira";
            this.tbCadMedCaseira.UseVisualStyleBackColor = true;
            this.tbCadMedCaseira.Enter += new System.EventHandler(this.tbCadMedCaseira_Enter);
            // 
            // pbAddMedCaseira
            // 
            this.pbAddMedCaseira.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAddMedCaseira.Image = global::TCC2.Properties.Resources.arrow_icon_1___Copia;
            this.pbAddMedCaseira.Location = new System.Drawing.Point(423, 358);
            this.pbAddMedCaseira.Margin = new System.Windows.Forms.Padding(2);
            this.pbAddMedCaseira.Name = "pbAddMedCaseira";
            this.pbAddMedCaseira.Size = new System.Drawing.Size(56, 55);
            this.pbAddMedCaseira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddMedCaseira.TabIndex = 310;
            this.pbAddMedCaseira.TabStop = false;
            this.pbAddMedCaseira.Click += new System.EventHandler(this.pbAddMedCaseira_Click);
            // 
            // mTxtFiltroAlimentoMedCas
            // 
            this.mTxtFiltroAlimentoMedCas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtFiltroAlimentoMedCas.Depth = 0;
            this.mTxtFiltroAlimentoMedCas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtFiltroAlimentoMedCas.Hint = "Filtro Alimento";
            this.mTxtFiltroAlimentoMedCas.LeadingIcon = null;
            this.mTxtFiltroAlimentoMedCas.Location = new System.Drawing.Point(8, 60);
            this.mTxtFiltroAlimentoMedCas.MaxLength = 50;
            this.mTxtFiltroAlimentoMedCas.MouseState = MaterialSkin.MouseState.OUT;
            this.mTxtFiltroAlimentoMedCas.Multiline = false;
            this.mTxtFiltroAlimentoMedCas.Name = "mTxtFiltroAlimentoMedCas";
            this.mTxtFiltroAlimentoMedCas.Size = new System.Drawing.Size(348, 50);
            this.mTxtFiltroAlimentoMedCas.TabIndex = 1;
            this.mTxtFiltroAlimentoMedCas.Text = "";
            this.mTxtFiltroAlimentoMedCas.TrailingIcon = null;
            this.mTxtFiltroAlimentoMedCas.Leave += new System.EventHandler(this.mTxtFiltroAlimentoMedCas_Leave);
            // 
            // mCbxTabelasMedCas
            // 
            this.mCbxTabelasMedCas.AutoResize = false;
            this.mCbxTabelasMedCas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCbxTabelasMedCas.Depth = 0;
            this.mCbxTabelasMedCas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCbxTabelasMedCas.DropDownHeight = 174;
            this.mCbxTabelasMedCas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCbxTabelasMedCas.DropDownWidth = 121;
            this.mCbxTabelasMedCas.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mCbxTabelasMedCas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCbxTabelasMedCas.FormattingEnabled = true;
            this.mCbxTabelasMedCas.Hint = "Tabela";
            this.mCbxTabelasMedCas.IntegralHeight = false;
            this.mCbxTabelasMedCas.ItemHeight = 43;
            this.mCbxTabelasMedCas.Location = new System.Drawing.Point(7, 5);
            this.mCbxTabelasMedCas.MaxDropDownItems = 4;
            this.mCbxTabelasMedCas.MouseState = MaterialSkin.MouseState.OUT;
            this.mCbxTabelasMedCas.Name = "mCbxTabelasMedCas";
            this.mCbxTabelasMedCas.Size = new System.Drawing.Size(348, 49);
            this.mCbxTabelasMedCas.StartIndex = 0;
            this.mCbxTabelasMedCas.TabIndex = 0;
            this.mCbxTabelasMedCas.SelectedValueChanged += new System.EventHandler(this.mCbxTabelasMedCas_SelectedValueChanged);
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
            this.colCodAlimento,
            this.colAlimento,
            this.colDescricao,
            this.colQtd,
            this.colTabela});
            this.dtgSalvarMedCaseira.Location = new System.Drawing.Point(495, 18);
            this.dtgSalvarMedCaseira.Name = "dtgSalvarMedCaseira";
            this.dtgSalvarMedCaseira.RowHeadersWidth = 51;
            this.dtgSalvarMedCaseira.Size = new System.Drawing.Size(697, 612);
            this.dtgSalvarMedCaseira.TabIndex = 2;
            // 
            // colCodAlimento
            // 
            this.colCodAlimento.HeaderText = "Código Alimento";
            this.colCodAlimento.MinimumWidth = 6;
            this.colCodAlimento.Name = "colCodAlimento";
            this.colCodAlimento.ReadOnly = true;
            this.colCodAlimento.Visible = false;
            this.colCodAlimento.Width = 125;
            // 
            // colAlimento
            // 
            this.colAlimento.HeaderText = "Alimento";
            this.colAlimento.MinimumWidth = 6;
            this.colAlimento.Name = "colAlimento";
            this.colAlimento.ReadOnly = true;
            this.colAlimento.Width = 125;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 6;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 125;
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.MinimumWidth = 6;
            this.colQtd.Name = "colQtd";
            this.colQtd.Width = 125;
            // 
            // colTabela
            // 
            this.colTabela.HeaderText = "Tabela";
            this.colTabela.MinimumWidth = 6;
            this.colTabela.Name = "colTabela";
            this.colTabela.ReadOnly = true;
            this.colTabela.Width = 125;
            // 
            // dtgMedCaseiraAlimentos
            // 
            this.dtgMedCaseiraAlimentos.AllowUserToAddRows = false;
            this.dtgMedCaseiraAlimentos.AllowUserToDeleteRows = false;
            this.dtgMedCaseiraAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgMedCaseiraAlimentos.BackgroundColor = System.Drawing.Color.White;
            this.dtgMedCaseiraAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedCaseiraAlimentos.Location = new System.Drawing.Point(7, 115);
            this.dtgMedCaseiraAlimentos.Name = "dtgMedCaseiraAlimentos";
            this.dtgMedCaseiraAlimentos.ReadOnly = true;
            this.dtgMedCaseiraAlimentos.RowHeadersWidth = 51;
            this.dtgMedCaseiraAlimentos.Size = new System.Drawing.Size(394, 552);
            this.dtgMedCaseiraAlimentos.TabIndex = 3;
            // 
            // btnSalvarMedCas
            // 
            this.btnSalvarMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarMedCas.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarMedCas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarMedCas.Location = new System.Drawing.Point(1075, 635);
            this.btnSalvarMedCas.Name = "btnSalvarMedCas";
            this.btnSalvarMedCas.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarMedCas.TabIndex = 3;
            this.btnSalvarMedCas.Text = "Salvar";
            this.btnSalvarMedCas.UseVisualStyleBackColor = true;
            this.btnSalvarMedCas.Click += new System.EventHandler(this.btnSalvarMedCas_Click);
            // 
            // tabCardapio
            // 
            this.tabCardapio.BackColor = System.Drawing.Color.White;
            this.tabCardapio.Controls.Add(this.tbCardapio);
            this.tabCardapio.ImageKey = "Cardapio32px.png";
            this.tabCardapio.Location = new System.Drawing.Point(4, 39);
            this.tabCardapio.Name = "tabCardapio";
            this.tabCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCardapio.Size = new System.Drawing.Size(1222, 717);
            this.tabCardapio.TabIndex = 3;
            this.tabCardapio.Text = "Cardápio";
            this.tabCardapio.Enter += new System.EventHandler(this.tabCardapio_Enter);
            // 
            // tbCardapio
            // 
            this.tbCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardapio.Controls.Add(this.tbCadCardapio);
            this.tbCardapio.Controls.Add(this.tbConsultaCardapio);
            this.tbCardapio.Location = new System.Drawing.Point(5, 5);
            this.tbCardapio.Margin = new System.Windows.Forms.Padding(2);
            this.tbCardapio.Name = "tbCardapio";
            this.tbCardapio.SelectedIndex = 0;
            this.tbCardapio.Size = new System.Drawing.Size(1208, 701);
            this.tbCardapio.TabIndex = 0;
            this.tbCardapio.Enter += new System.EventHandler(this.tbCardapio_Enter);
            // 
            // tbCadCardapio
            // 
            this.tbCadCardapio.Controls.Add(this.datalbl);
            this.tbCadCardapio.Controls.Add(this.lblVET);
            this.tbCadCardapio.Controls.Add(this.lblTMB);
            this.tbCadCardapio.Controls.Add(this.materialLabel7);
            this.tbCadCardapio.Controls.Add(this.rbDRI);
            this.tbCadCardapio.Controls.Add(this.rbFAOOMS);
            this.tbCadCardapio.Controls.Add(this.rbHarrisBenedict);
            this.tbCadCardapio.Controls.Add(this.chkTMB);
            this.tbCadCardapio.Controls.Add(this.mlblVET);
            this.tbCadCardapio.Controls.Add(this.mlblTMB);
            this.tbCadCardapio.Controls.Add(this.chkDataExisteCardapio);
            this.tbCadCardapio.Controls.Add(this.cbxDataCardSalvo);
            this.tbCadCardapio.Controls.Add(this.txtDataCardapio);
            this.tbCadCardapio.Controls.Add(this.txtLipidio);
            this.tbCadCardapio.Controls.Add(this.txtCarboidrato);
            this.tbCadCardapio.Controls.Add(this.txtProteina);
            this.tbCadCardapio.Controls.Add(this.lblValorKcal);
            this.tbCadCardapio.Controls.Add(this.lblVlrKcal);
            this.tbCadCardapio.Controls.Add(this.txtFiltroAlimento);
            this.tbCadCardapio.Controls.Add(this.cbxTabelaAlimentoCardapio);
            this.tbCadCardapio.Controls.Add(this.cbxRefeicao);
            this.tbCadCardapio.Controls.Add(this.txtPaciente);
            this.tbCadCardapio.Controls.Add(this.btnCancelarCardapio);
            this.tbCadCardapio.Controls.Add(this.graficoMacroNutri);
            this.tbCadCardapio.Controls.Add(this.btnAddAliCard);
            this.tbCadCardapio.Controls.Add(this.btnPacienteCardapio);
            this.tbCadCardapio.Controls.Add(this.dtgCardapioAlimentos);
            this.tbCadCardapio.Controls.Add(this.dtgRefeicoes);
            this.tbCadCardapio.Controls.Add(this.btnSalvarCardapio);
            this.tbCadCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbCadCardapio.Margin = new System.Windows.Forms.Padding(2);
            this.tbCadCardapio.Name = "tbCadCardapio";
            this.tbCadCardapio.Padding = new System.Windows.Forms.Padding(2);
            this.tbCadCardapio.Size = new System.Drawing.Size(1200, 675);
            this.tbCadCardapio.TabIndex = 0;
            this.tbCadCardapio.Text = "Criar Cardápio";
            this.tbCadCardapio.UseVisualStyleBackColor = true;
            // 
            // datalbl
            // 
            this.datalbl.AutoSize = true;
            this.datalbl.Depth = 0;
            this.datalbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.datalbl.Location = new System.Drawing.Point(1056, 166);
            this.datalbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.datalbl.Name = "datalbl";
            this.datalbl.Size = new System.Drawing.Size(17, 19);
            this.datalbl.TabIndex = 346;
            this.datalbl.Text = "....";
            this.datalbl.Visible = false;
            // 
            // lblVET
            // 
            this.lblVET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVET.AutoSize = true;
            this.lblVET.Depth = 0;
            this.lblVET.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVET.Location = new System.Drawing.Point(425, 573);
            this.lblVET.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVET.Name = "lblVET";
            this.lblVET.Size = new System.Drawing.Size(1, 0);
            this.lblVET.TabIndex = 345;
            // 
            // lblTMB
            // 
            this.lblTMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTMB.AutoSize = true;
            this.lblTMB.Depth = 0;
            this.lblTMB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTMB.Location = new System.Drawing.Point(429, 605);
            this.lblTMB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTMB.Name = "lblTMB";
            this.lblTMB.Size = new System.Drawing.Size(1, 0);
            this.lblTMB.TabIndex = 344;
            this.lblTMB.Visible = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(361, 75);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(113, 19);
            this.materialLabel7.TabIndex = 343;
            this.materialLabel7.Text = "Tipo de cálculo:";
            // 
            // rbDRI
            // 
            this.rbDRI.AutoSize = true;
            this.rbDRI.Depth = 0;
            this.rbDRI.Location = new System.Drawing.Point(728, 65);
            this.rbDRI.Margin = new System.Windows.Forms.Padding(0);
            this.rbDRI.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDRI.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDRI.Name = "rbDRI";
            this.rbDRI.Ripple = true;
            this.rbDRI.Size = new System.Drawing.Size(60, 37);
            this.rbDRI.TabIndex = 342;
            this.rbDRI.TabStop = true;
            this.rbDRI.Text = "DRI";
            this.rbDRI.UseVisualStyleBackColor = true;
            this.rbDRI.CheckedChanged += new System.EventHandler(this.rbDRI_CheckedChanged);
            // 
            // rbFAOOMS
            // 
            this.rbFAOOMS.AutoSize = true;
            this.rbFAOOMS.Depth = 0;
            this.rbFAOOMS.Location = new System.Drawing.Point(621, 65);
            this.rbFAOOMS.Margin = new System.Windows.Forms.Padding(0);
            this.rbFAOOMS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFAOOMS.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFAOOMS.Name = "rbFAOOMS";
            this.rbFAOOMS.Ripple = true;
            this.rbFAOOMS.Size = new System.Drawing.Size(107, 37);
            this.rbFAOOMS.TabIndex = 341;
            this.rbFAOOMS.TabStop = true;
            this.rbFAOOMS.Text = "FAO/OMS";
            this.rbFAOOMS.UseVisualStyleBackColor = true;
            this.rbFAOOMS.CheckedChanged += new System.EventHandler(this.rbFAOOMS_CheckedChanged);
            // 
            // rbHarrisBenedict
            // 
            this.rbHarrisBenedict.AutoSize = true;
            this.rbHarrisBenedict.Checked = true;
            this.rbHarrisBenedict.Depth = 0;
            this.rbHarrisBenedict.Location = new System.Drawing.Point(479, 65);
            this.rbHarrisBenedict.Margin = new System.Windows.Forms.Padding(0);
            this.rbHarrisBenedict.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHarrisBenedict.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHarrisBenedict.Name = "rbHarrisBenedict";
            this.rbHarrisBenedict.Ripple = true;
            this.rbHarrisBenedict.Size = new System.Drawing.Size(142, 37);
            this.rbHarrisBenedict.TabIndex = 340;
            this.rbHarrisBenedict.TabStop = true;
            this.rbHarrisBenedict.Text = "Harris Benedict";
            this.rbHarrisBenedict.UseVisualStyleBackColor = true;
            this.rbHarrisBenedict.CheckedChanged += new System.EventHandler(this.rbHarrisBenedict_CheckedChanged);
            // 
            // chkTMB
            // 
            this.chkTMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTMB.AutoSize = true;
            this.chkTMB.Depth = 0;
            this.chkTMB.Location = new System.Drawing.Point(638, 519);
            this.chkTMB.Margin = new System.Windows.Forms.Padding(0);
            this.chkTMB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTMB.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTMB.Name = "chkTMB";
            this.chkTMB.Ripple = true;
            this.chkTMB.Size = new System.Drawing.Size(112, 37);
            this.chkTMB.TabIndex = 335;
            this.chkTMB.Text = "Exibir TMB";
            this.chkTMB.UseVisualStyleBackColor = true;
            this.chkTMB.CheckedChanged += new System.EventHandler(this.chkTMB_CheckedChanged);
            // 
            // mlblVET
            // 
            this.mlblVET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlblVET.AutoSize = true;
            this.mlblVET.Depth = 0;
            this.mlblVET.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblVET.Location = new System.Drawing.Point(385, 573);
            this.mlblVET.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblVET.Name = "mlblVET";
            this.mlblVET.Size = new System.Drawing.Size(34, 19);
            this.mlblVET.TabIndex = 334;
            this.mlblVET.Text = "VET:";
            // 
            // mlblTMB
            // 
            this.mlblTMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlblTMB.AutoSize = true;
            this.mlblTMB.Depth = 0;
            this.mlblTMB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblTMB.Location = new System.Drawing.Point(385, 605);
            this.mlblTMB.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTMB.Name = "mlblTMB";
            this.mlblTMB.Size = new System.Drawing.Size(39, 19);
            this.mlblTMB.TabIndex = 333;
            this.mlblTMB.Text = "TMB:";
            this.mlblTMB.Visible = false;
            // 
            // chkDataExisteCardapio
            // 
            this.chkDataExisteCardapio.AutoSize = true;
            this.chkDataExisteCardapio.Depth = 0;
            this.chkDataExisteCardapio.Location = new System.Drawing.Point(922, 61);
            this.chkDataExisteCardapio.Margin = new System.Windows.Forms.Padding(0);
            this.chkDataExisteCardapio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDataExisteCardapio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDataExisteCardapio.Name = "chkDataExisteCardapio";
            this.chkDataExisteCardapio.Ripple = true;
            this.chkDataExisteCardapio.Size = new System.Drawing.Size(163, 37);
            this.chkDataExisteCardapio.TabIndex = 330;
            this.chkDataExisteCardapio.Text = "Utilizar Nova Data";
            this.chkDataExisteCardapio.UseVisualStyleBackColor = true;
            this.chkDataExisteCardapio.CheckedChanged += new System.EventHandler(this.chkDataExisteCardapio_CheckedChanged);
            // 
            // cbxDataCardSalvo
            // 
            this.cbxDataCardSalvo.AutoResize = false;
            this.cbxDataCardSalvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDataCardSalvo.Depth = 0;
            this.cbxDataCardSalvo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxDataCardSalvo.DropDownHeight = 174;
            this.cbxDataCardSalvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataCardSalvo.DropDownWidth = 121;
            this.cbxDataCardSalvo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxDataCardSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxDataCardSalvo.FormattingEnabled = true;
            this.cbxDataCardSalvo.Hint = "Data Consulta";
            this.cbxDataCardSalvo.IntegralHeight = false;
            this.cbxDataCardSalvo.ItemHeight = 43;
            this.cbxDataCardSalvo.Location = new System.Drawing.Point(922, 9);
            this.cbxDataCardSalvo.MaxDropDownItems = 4;
            this.cbxDataCardSalvo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxDataCardSalvo.Name = "cbxDataCardSalvo";
            this.cbxDataCardSalvo.Size = new System.Drawing.Size(187, 49);
            this.cbxDataCardSalvo.StartIndex = 0;
            this.cbxDataCardSalvo.TabIndex = 329;
            this.cbxDataCardSalvo.SelectedIndexChanged += new System.EventHandler(this.cbxDataCardSalvo_SelectedIndexChanged);
            this.cbxDataCardSalvo.SelectedValueChanged += new System.EventHandler(this.cbxDataCardSalvo_SelectedValueChanged);
            // 
            // txtDataCardapio
            // 
            this.txtDataCardapio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataCardapio.Depth = 0;
            this.txtDataCardapio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataCardapio.Hint = "Data";
            this.txtDataCardapio.LeadingIcon = null;
            this.txtDataCardapio.Location = new System.Drawing.Point(922, 7);
            this.txtDataCardapio.MaxLength = 10;
            this.txtDataCardapio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataCardapio.Multiline = false;
            this.txtDataCardapio.Name = "txtDataCardapio";
            this.txtDataCardapio.Size = new System.Drawing.Size(187, 50);
            this.txtDataCardapio.TabIndex = 4;
            this.txtDataCardapio.Text = "";
            this.txtDataCardapio.TrailingIcon = null;
            this.txtDataCardapio.Visible = false;
            this.txtDataCardapio.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtDataCardapio_LinkClicked);
            this.txtDataCardapio.Leave += new System.EventHandler(this.txtDataCardapio_Leave);
            // 
            // txtLipidio
            // 
            this.txtLipidio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLipidio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLipidio.Depth = 0;
            this.txtLipidio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLipidio.Hint = "Lipídio";
            this.txtLipidio.LeadingIcon = null;
            this.txtLipidio.Location = new System.Drawing.Point(1049, 518);
            this.txtLipidio.MaxLength = 50;
            this.txtLipidio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLipidio.Multiline = false;
            this.txtLipidio.Name = "txtLipidio";
            this.txtLipidio.Size = new System.Drawing.Size(125, 50);
            this.txtLipidio.TabIndex = 10;
            this.txtLipidio.Text = "";
            this.txtLipidio.TrailingIcon = null;
            // 
            // txtCarboidrato
            // 
            this.txtCarboidrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarboidrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarboidrato.Depth = 0;
            this.txtCarboidrato.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarboidrato.Hint = "Carboidrato";
            this.txtCarboidrato.LeadingIcon = null;
            this.txtCarboidrato.Location = new System.Drawing.Point(918, 518);
            this.txtCarboidrato.MaxLength = 50;
            this.txtCarboidrato.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCarboidrato.Multiline = false;
            this.txtCarboidrato.Name = "txtCarboidrato";
            this.txtCarboidrato.Size = new System.Drawing.Size(125, 50);
            this.txtCarboidrato.TabIndex = 9;
            this.txtCarboidrato.Text = "";
            this.txtCarboidrato.TrailingIcon = null;
            // 
            // txtProteina
            // 
            this.txtProteina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProteina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProteina.Depth = 0;
            this.txtProteina.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProteina.Hint = "Proteína";
            this.txtProteina.LeadingIcon = null;
            this.txtProteina.Location = new System.Drawing.Point(787, 518);
            this.txtProteina.MaxLength = 50;
            this.txtProteina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProteina.Multiline = false;
            this.txtProteina.Name = "txtProteina";
            this.txtProteina.Size = new System.Drawing.Size(125, 50);
            this.txtProteina.TabIndex = 8;
            this.txtProteina.Text = "";
            this.txtProteina.TrailingIcon = null;
            // 
            // lblValorKcal
            // 
            this.lblValorKcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValorKcal.AutoSize = true;
            this.lblValorKcal.Depth = 0;
            this.lblValorKcal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblValorKcal.Location = new System.Drawing.Point(429, 539);
            this.lblValorKcal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorKcal.Name = "lblValorKcal";
            this.lblValorKcal.Size = new System.Drawing.Size(1, 0);
            this.lblValorKcal.TabIndex = 323;
            // 
            // lblVlrKcal
            // 
            this.lblVlrKcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVlrKcal.AutoSize = true;
            this.lblVlrKcal.Depth = 0;
            this.lblVlrKcal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVlrKcal.Location = new System.Drawing.Point(385, 539);
            this.lblVlrKcal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVlrKcal.Name = "lblVlrKcal";
            this.lblVlrKcal.Size = new System.Drawing.Size(38, 19);
            this.lblVlrKcal.TabIndex = 322;
            this.lblVlrKcal.Text = "KCal:";
            // 
            // txtFiltroAlimento
            // 
            this.txtFiltroAlimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltroAlimento.Depth = 0;
            this.txtFiltroAlimento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltroAlimento.Hint = "Filtro Alimento";
            this.txtFiltroAlimento.LeadingIcon = null;
            this.txtFiltroAlimento.Location = new System.Drawing.Point(8, 61);
            this.txtFiltroAlimento.MaxLength = 50;
            this.txtFiltroAlimento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFiltroAlimento.Multiline = false;
            this.txtFiltroAlimento.Name = "txtFiltroAlimento";
            this.txtFiltroAlimento.Size = new System.Drawing.Size(347, 50);
            this.txtFiltroAlimento.TabIndex = 5;
            this.txtFiltroAlimento.Text = "";
            this.txtFiltroAlimento.TrailingIcon = null;
            this.txtFiltroAlimento.Leave += new System.EventHandler(this.txtFiltroAlimento_Leave);
            // 
            // cbxTabelaAlimentoCardapio
            // 
            this.cbxTabelaAlimentoCardapio.AutoResize = false;
            this.cbxTabelaAlimentoCardapio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTabelaAlimentoCardapio.Depth = 0;
            this.cbxTabelaAlimentoCardapio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTabelaAlimentoCardapio.DropDownHeight = 174;
            this.cbxTabelaAlimentoCardapio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabelaAlimentoCardapio.DropDownWidth = 121;
            this.cbxTabelaAlimentoCardapio.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTabelaAlimentoCardapio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTabelaAlimentoCardapio.FormattingEnabled = true;
            this.cbxTabelaAlimentoCardapio.Hint = "Tabela";
            this.cbxTabelaAlimentoCardapio.IntegralHeight = false;
            this.cbxTabelaAlimentoCardapio.ItemHeight = 43;
            this.cbxTabelaAlimentoCardapio.Location = new System.Drawing.Point(617, 6);
            this.cbxTabelaAlimentoCardapio.MaxDropDownItems = 4;
            this.cbxTabelaAlimentoCardapio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTabelaAlimentoCardapio.Name = "cbxTabelaAlimentoCardapio";
            this.cbxTabelaAlimentoCardapio.Size = new System.Drawing.Size(261, 49);
            this.cbxTabelaAlimentoCardapio.StartIndex = 0;
            this.cbxTabelaAlimentoCardapio.TabIndex = 3;
            this.cbxTabelaAlimentoCardapio.SelectedIndexChanged += new System.EventHandler(this.cbxTabelaAlimentoCardapio_SelectedIndexChanged);
            // 
            // cbxRefeicao
            // 
            this.cbxRefeicao.AutoResize = false;
            this.cbxRefeicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxRefeicao.Depth = 0;
            this.cbxRefeicao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxRefeicao.DropDownHeight = 174;
            this.cbxRefeicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRefeicao.DropDownWidth = 121;
            this.cbxRefeicao.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxRefeicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxRefeicao.FormattingEnabled = true;
            this.cbxRefeicao.Hint = "Refeição";
            this.cbxRefeicao.IntegralHeight = false;
            this.cbxRefeicao.ItemHeight = 43;
            this.cbxRefeicao.Items.AddRange(new object[] {
            "Café da manhã",
            "Lanche",
            "Almoço",
            "Lanche da tarde",
            "Jantar",
            "Ceia"});
            this.cbxRefeicao.Location = new System.Drawing.Point(309, 6);
            this.cbxRefeicao.MaxDropDownItems = 4;
            this.cbxRefeicao.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxRefeicao.Name = "cbxRefeicao";
            this.cbxRefeicao.Size = new System.Drawing.Size(261, 49);
            this.cbxRefeicao.StartIndex = 0;
            this.cbxRefeicao.TabIndex = 2;
            this.cbxRefeicao.SelectedValueChanged += new System.EventHandler(this.cbxRefeicao_SelectedValueChanged);
            // 
            // txtPaciente
            // 
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaciente.Depth = 0;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaciente.Hint = "Paciente";
            this.txtPaciente.LeadingIcon = null;
            this.txtPaciente.Location = new System.Drawing.Point(8, 5);
            this.txtPaciente.MaxLength = 50;
            this.txtPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPaciente.Multiline = false;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(188, 50);
            this.txtPaciente.TabIndex = 0;
            this.txtPaciente.Text = "";
            this.txtPaciente.TrailingIcon = null;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            // 
            // btnCancelarCardapio
            // 
            this.btnCancelarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCardapio.AutoSize = true;
            this.btnCancelarCardapio.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCardapio.Location = new System.Drawing.Point(1080, 635);
            this.btnCancelarCardapio.Name = "btnCancelarCardapio";
            this.btnCancelarCardapio.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarCardapio.TabIndex = 12;
            this.btnCancelarCardapio.Text = "Cancelar";
            this.btnCancelarCardapio.UseVisualStyleBackColor = true;
            this.btnCancelarCardapio.Click += new System.EventHandler(this.btnCancelarCardapio_Click);
            // 
            // graficoMacroNutri
            // 
            this.graficoMacroNutri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graficoMacroNutri.BackColorTransparent = true;
            this.graficoMacroNutri.Location = new System.Drawing.Point(8, 518);
            this.graficoMacroNutri.Margin = new System.Windows.Forms.Padding(2);
            this.graficoMacroNutri.Name = "graficoMacroNutri";
            this.graficoMacroNutri.Size = new System.Drawing.Size(360, 150);
            this.graficoMacroNutri.TabIndex = 313;
            this.graficoMacroNutri.Text = "Gráfico MacroNutrientes";
            // 
            // btnAddAliCard
            // 
            this.btnAddAliCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddAliCard.Image = global::TCC2.Properties.Resources.arrow_icon_1___Copia;
            this.btnAddAliCard.Location = new System.Drawing.Point(505, 296);
            this.btnAddAliCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAliCard.Name = "btnAddAliCard";
            this.btnAddAliCard.Size = new System.Drawing.Size(56, 55);
            this.btnAddAliCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddAliCard.TabIndex = 309;
            this.btnAddAliCard.TabStop = false;
            this.btnAddAliCard.Click += new System.EventHandler(this.btnAddAliCard_Click);
            // 
            // btnPacienteCardapio
            // 
            this.btnPacienteCardapio.Image = global::TCC2.Properties.Resources.consultar;
            this.btnPacienteCardapio.Location = new System.Drawing.Point(202, 16);
            this.btnPacienteCardapio.Name = "btnPacienteCardapio";
            this.btnPacienteCardapio.Size = new System.Drawing.Size(30, 23);
            this.btnPacienteCardapio.TabIndex = 1;
            this.btnPacienteCardapio.UseVisualStyleBackColor = true;
            this.btnPacienteCardapio.Click += new System.EventHandler(this.btnPacienteCardapio_Click);
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
            this.dtgCardapioAlimentos.Location = new System.Drawing.Point(8, 117);
            this.dtgCardapioAlimentos.Name = "dtgCardapioAlimentos";
            this.dtgCardapioAlimentos.RowHeadersWidth = 51;
            this.dtgCardapioAlimentos.Size = new System.Drawing.Size(470, 396);
            this.dtgCardapioAlimentos.TabIndex = 6;
            // 
            // dtgRefeicoes
            // 
            this.dtgRefeicoes.AllowUserToAddRows = false;
            this.dtgRefeicoes.AllowUserToOrderColumns = true;
            this.dtgRefeicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefeicoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRefeicoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRefeicoes.BackgroundColor = System.Drawing.Color.White;
            this.dtgRefeicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRefeicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlimento,
            this.nomeAlimento,
            this.qtd,
            this.kcal,
            this.prot,
            this.carbo,
            this.lipidio,
            this.cbxMedCaseira,
            this.obs});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRefeicoes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgRefeicoes.Location = new System.Drawing.Point(590, 117);
            this.dtgRefeicoes.Name = "dtgRefeicoes";
            this.dtgRefeicoes.RowHeadersWidth = 51;
            this.dtgRefeicoes.Size = new System.Drawing.Size(605, 396);
            this.dtgRefeicoes.TabIndex = 7;
            this.dtgRefeicoes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgRefeicoes_CellBeginEdit);
            this.dtgRefeicoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRefeicoes_CellEndEdit);
            this.dtgRefeicoes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgRefeicoes_DataError);
            this.dtgRefeicoes.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgRefeicoes_UserDeletedRow);
            // 
            // codAlimento
            // 
            this.codAlimento.HeaderText = "Cód Alimento";
            this.codAlimento.MinimumWidth = 6;
            this.codAlimento.Name = "codAlimento";
            this.codAlimento.Visible = false;
            this.codAlimento.Width = 94;
            // 
            // nomeAlimento
            // 
            this.nomeAlimento.HeaderText = "Alimento";
            this.nomeAlimento.MinimumWidth = 6;
            this.nomeAlimento.Name = "nomeAlimento";
            this.nomeAlimento.Width = 72;
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Quantidade";
            this.qtd.MinimumWidth = 6;
            this.qtd.Name = "qtd";
            this.qtd.Width = 87;
            // 
            // kcal
            // 
            this.kcal.HeaderText = "Kcal";
            this.kcal.MinimumWidth = 6;
            this.kcal.Name = "kcal";
            this.kcal.Visible = false;
            this.kcal.Width = 53;
            // 
            // prot
            // 
            this.prot.HeaderText = "Proteína";
            this.prot.MinimumWidth = 6;
            this.prot.Name = "prot";
            this.prot.Visible = false;
            this.prot.Width = 73;
            // 
            // carbo
            // 
            this.carbo.HeaderText = "Carboidrato";
            this.carbo.MinimumWidth = 6;
            this.carbo.Name = "carbo";
            this.carbo.Visible = false;
            this.carbo.Width = 86;
            // 
            // lipidio
            // 
            this.lipidio.HeaderText = "Lipídio";
            this.lipidio.MinimumWidth = 6;
            this.lipidio.Name = "lipidio";
            this.lipidio.Visible = false;
            this.lipidio.Width = 64;
            // 
            // cbxMedCaseira
            // 
            this.cbxMedCaseira.HeaderText = "Medida Caseira";
            this.cbxMedCaseira.MinimumWidth = 6;
            this.cbxMedCaseira.Name = "cbxMedCaseira";
            this.cbxMedCaseira.Width = 77;
            // 
            // obs
            // 
            this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obs.HeaderText = "Observação";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            // 
            // btnSalvarCardapio
            // 
            this.btnSalvarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCardapio.AutoSize = true;
            this.btnSalvarCardapio.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCardapio.Location = new System.Drawing.Point(958, 635);
            this.btnSalvarCardapio.Name = "btnSalvarCardapio";
            this.btnSalvarCardapio.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarCardapio.TabIndex = 11;
            this.btnSalvarCardapio.Text = "Salvar";
            this.btnSalvarCardapio.UseVisualStyleBackColor = true;
            this.btnSalvarCardapio.Click += new System.EventHandler(this.btnSalvarCardapio_Click);
            // 
            // tbConsultaCardapio
            // 
            this.tbConsultaCardapio.Controls.Add(this.btnEnviarCardEmail);
            this.tbConsultaCardapio.Controls.Add(this.btnConsultarCardapio);
            this.tbConsultaCardapio.Controls.Add(this.dtgCardGrid);
            this.tbConsultaCardapio.Controls.Add(this.cbxDataConsulta);
            this.tbConsultaCardapio.Controls.Add(this.txtPacienteConsultaCardapio);
            this.tbConsultaCardapio.Controls.Add(this.trwDadosCard);
            this.tbConsultaCardapio.Controls.Add(this.btnExportar);
            this.tbConsultaCardapio.Controls.Add(this.btnApagarCardapio);
            this.tbConsultaCardapio.Controls.Add(this.btnApagar);
            this.tbConsultaCardapio.Controls.Add(this.btnBuscaPaciente);
            this.tbConsultaCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbConsultaCardapio.Name = "tbConsultaCardapio";
            this.tbConsultaCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultaCardapio.Size = new System.Drawing.Size(1200, 675);
            this.tbConsultaCardapio.TabIndex = 1;
            this.tbConsultaCardapio.Text = "Consulta";
            this.tbConsultaCardapio.UseVisualStyleBackColor = true;
            this.tbConsultaCardapio.Click += new System.EventHandler(this.tbConsultaCardapio_Click);
            this.tbConsultaCardapio.Enter += new System.EventHandler(this.tbConsultaCardapio_Enter);
            // 
            // btnEnviarCardEmail
            // 
            this.btnEnviarCardEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarCardEmail.AutoSize = true;
            this.btnEnviarCardEmail.Image = global::TCC2.Properties.Resources.email_envelope_outline_shape_with_rounded_corners_icon_icons_com_56530__2_;
            this.btnEnviarCardEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarCardEmail.Location = new System.Drawing.Point(958, 18);
            this.btnEnviarCardEmail.Name = "btnEnviarCardEmail";
            this.btnEnviarCardEmail.Size = new System.Drawing.Size(115, 38);
            this.btnEnviarCardEmail.TabIndex = 324;
            this.btnEnviarCardEmail.Text = "Enviar";
            this.btnEnviarCardEmail.UseVisualStyleBackColor = true;
            this.btnEnviarCardEmail.Click += new System.EventHandler(this.btnEnviarCardEmail_Click);
            // 
            // btnConsultarCardapio
            // 
            this.btnConsultarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarCardapio.Image = global::TCC2.Properties.Resources.consultar;
            this.btnConsultarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCardapio.Location = new System.Drawing.Point(837, 18);
            this.btnConsultarCardapio.Name = "btnConsultarCardapio";
            this.btnConsultarCardapio.Size = new System.Drawing.Size(115, 38);
            this.btnConsultarCardapio.TabIndex = 323;
            this.btnConsultarCardapio.Text = "Consultar";
            this.btnConsultarCardapio.UseVisualStyleBackColor = true;
            this.btnConsultarCardapio.Click += new System.EventHandler(this.btnConsultarCardapio_Click);
            // 
            // dtgCardGrid
            // 
            this.dtgCardGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgCardGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refeicao,
            this.alimento,
            this.medidacaseiraqtd,
            this.observ});
            this.dtgCardGrid.Location = new System.Drawing.Point(849, 62);
            this.dtgCardGrid.Name = "dtgCardGrid";
            this.dtgCardGrid.RowHeadersWidth = 20;
            this.dtgCardGrid.RowsLevel = ((Microsoft.VisualBasic.Collection)(resources.GetObject("dtgCardGrid.RowsLevel")));
            this.dtgCardGrid.RowsName = ((Microsoft.VisualBasic.Collection)(resources.GetObject("dtgCardGrid.RowsName")));
            this.dtgCardGrid.ShowHideMenuItemDiferente = false;
            this.dtgCardGrid.ShowHideRowMenuItem = false;
            this.dtgCardGrid.Size = new System.Drawing.Size(324, 47);
            this.dtgCardGrid.TabIndex = 322;
            this.dtgCardGrid.ValidateFormattedColumns = false;
            this.dtgCardGrid.Visible = false;
            // 
            // refeicao
            // 
            this.refeicao.HeaderText = "refeicao";
            this.refeicao.MinimumWidth = 6;
            this.refeicao.Name = "refeicao";
            this.refeicao.Width = 125;
            // 
            // alimento
            // 
            this.alimento.HeaderText = "alimento";
            this.alimento.MinimumWidth = 6;
            this.alimento.Name = "alimento";
            this.alimento.Width = 125;
            // 
            // medidacaseiraqtd
            // 
            this.medidacaseiraqtd.HeaderText = "medidacaseiraqtd";
            this.medidacaseiraqtd.MinimumWidth = 6;
            this.medidacaseiraqtd.Name = "medidacaseiraqtd";
            this.medidacaseiraqtd.Width = 125;
            // 
            // observ
            // 
            this.observ.HeaderText = "observ";
            this.observ.MinimumWidth = 6;
            this.observ.Name = "observ";
            this.observ.Width = 125;
            // 
            // cbxDataConsulta
            // 
            this.cbxDataConsulta.AutoResize = false;
            this.cbxDataConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDataConsulta.Depth = 0;
            this.cbxDataConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxDataConsulta.DropDownHeight = 174;
            this.cbxDataConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataConsulta.DropDownWidth = 121;
            this.cbxDataConsulta.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxDataConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxDataConsulta.FormattingEnabled = true;
            this.cbxDataConsulta.Hint = "Data Consulta";
            this.cbxDataConsulta.IntegralHeight = false;
            this.cbxDataConsulta.ItemHeight = 43;
            this.cbxDataConsulta.Location = new System.Drawing.Point(272, 4);
            this.cbxDataConsulta.MaxDropDownItems = 4;
            this.cbxDataConsulta.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxDataConsulta.Name = "cbxDataConsulta";
            this.cbxDataConsulta.Size = new System.Drawing.Size(260, 49);
            this.cbxDataConsulta.StartIndex = 0;
            this.cbxDataConsulta.TabIndex = 321;
            this.cbxDataConsulta.Visible = false;
            this.cbxDataConsulta.SelectedValueChanged += new System.EventHandler(this.cbxDataConsulta_SelectedValueChanged);
            // 
            // txtPacienteConsultaCardapio
            // 
            this.txtPacienteConsultaCardapio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteConsultaCardapio.Depth = 0;
            this.txtPacienteConsultaCardapio.Enabled = false;
            this.txtPacienteConsultaCardapio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteConsultaCardapio.Hint = "Paciente";
            this.txtPacienteConsultaCardapio.LeadingIcon = null;
            this.txtPacienteConsultaCardapio.Location = new System.Drawing.Point(6, 6);
            this.txtPacienteConsultaCardapio.MaxLength = 50;
            this.txtPacienteConsultaCardapio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteConsultaCardapio.Multiline = false;
            this.txtPacienteConsultaCardapio.Name = "txtPacienteConsultaCardapio";
            this.txtPacienteConsultaCardapio.Size = new System.Drawing.Size(188, 50);
            this.txtPacienteConsultaCardapio.TabIndex = 318;
            this.txtPacienteConsultaCardapio.Text = "";
            this.txtPacienteConsultaCardapio.TrailingIcon = null;
            this.txtPacienteConsultaCardapio.TextChanged += new System.EventHandler(this.txtPacienteConsultaCardapio_TextChanged);
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
            this.trwDadosCard.BackgroundColor = System.Drawing.Color.White;
            this.trwDadosCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.trwDadosCard.ColumnHeadersHeight = 29;
            this.trwDadosCard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.trwDadosCard.GridColor = System.Drawing.SystemColors.Control;
            this.trwDadosCard.ImageList = null;
            this.trwDadosCard.Location = new System.Drawing.Point(3, 62);
            this.trwDadosCard.Name = "trwDadosCard";
            this.trwDadosCard.ReadOnly = true;
            this.trwDadosCard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.trwDadosCard.RowHeadersWidth = 51;
            this.trwDadosCard.Size = new System.Drawing.Size(1191, 604);
            this.trwDadosCard.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = true;
            this.btnExportar.Image = global::TCC2.Properties.Resources.msexcel_93695__3_;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(958, 18);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(115, 38);
            this.btnExportar.TabIndex = 320;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnApagarCardapio
            // 
            this.btnApagarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagarCardapio.AutoSize = true;
            this.btnApagarCardapio.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnApagarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarCardapio.Location = new System.Drawing.Point(1079, 18);
            this.btnApagarCardapio.Name = "btnApagarCardapio";
            this.btnApagarCardapio.Size = new System.Drawing.Size(115, 38);
            this.btnApagarCardapio.TabIndex = 319;
            this.btnApagarCardapio.Text = "Deletar";
            this.btnApagarCardapio.UseVisualStyleBackColor = true;
            this.btnApagarCardapio.Click += new System.EventHandler(this.btnApagarCardapio_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnApagar.Location = new System.Drawing.Point(236, 18);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(30, 23);
            this.btnApagar.TabIndex = 306;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Image = global::TCC2.Properties.Resources.consultar;
            this.btnBuscaPaciente.Location = new System.Drawing.Point(200, 18);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(30, 23);
            this.btnBuscaPaciente.TabIndex = 304;
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // tabPaciente
            // 
            this.tabPaciente.BackColor = System.Drawing.Color.White;
            this.tabPaciente.Controls.Add(this.tbPaciente);
            this.tabPaciente.ImageKey = "Paciente32px.png";
            this.tabPaciente.Location = new System.Drawing.Point(4, 39);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaciente.Size = new System.Drawing.Size(1222, 717);
            this.tabPaciente.TabIndex = 4;
            this.tabPaciente.Text = "Paciente";
            // 
            // tbPaciente
            // 
            this.tbPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPaciente.Controls.Add(this.tbCadastro);
            this.tbPaciente.Controls.Add(this.tbAntropometricos);
            this.tbPaciente.Controls.Add(this.tbAnamnese);
            this.tbPaciente.Location = new System.Drawing.Point(7, 6);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.SelectedIndex = 0;
            this.tbPaciente.Size = new System.Drawing.Size(1206, 699);
            this.tbPaciente.TabIndex = 0;
            this.tbPaciente.Enter += new System.EventHandler(this.tbPaciente_Enter);
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.rbFeminino);
            this.tbCadastro.Controls.Add(this.rbMasculino);
            this.tbCadastro.Controls.Add(this.txtDtNasc);
            this.tbCadastro.Controls.Add(this.txtCelular);
            this.tbCadastro.Controls.Add(this.txtTelefone);
            this.tbCadastro.Controls.Add(this.txtComplemento);
            this.tbCadastro.Controls.Add(this.txtUF);
            this.tbCadastro.Controls.Add(this.txtMunicipio);
            this.tbCadastro.Controls.Add(this.txtBairro);
            this.tbCadastro.Controls.Add(this.txtNumero);
            this.tbCadastro.Controls.Add(this.txtEndereco);
            this.tbCadastro.Controls.Add(this.txtCEP);
            this.tbCadastro.Controls.Add(this.txtEmail);
            this.tbCadastro.Controls.Add(this.txtCPF);
            this.tbCadastro.Controls.Add(this.txtNome);
            this.tbCadastro.Controls.Add(this.txtCodPaciente);
            this.tbCadastro.Controls.Add(this.btnCapturarImagem);
            this.tbCadastro.Controls.Add(this._dtgConsultaPacientes);
            this.tbCadastro.Controls.Add(this._btnExcluir);
            this.tbCadastro.Controls.Add(this._btnSalvar);
            this.tbCadastro.Controls.Add(this.pbImagem);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(1198, 673);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            this.tbCadastro.Enter += new System.EventHandler(this.tbCadastro_Enter);
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Depth = 0;
            this.rbFeminino.Location = new System.Drawing.Point(655, 428);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(0);
            this.rbFeminino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFeminino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Ripple = true;
            this.rbFeminino.Size = new System.Drawing.Size(101, 37);
            this.rbFeminino.TabIndex = 273;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Depth = 0;
            this.rbMasculino.Location = new System.Drawing.Point(655, 387);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Ripple = true;
            this.rbMasculino.Size = new System.Drawing.Size(109, 37);
            this.rbMasculino.TabIndex = 272;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDtNasc.Depth = 0;
            this.txtDtNasc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDtNasc.Hint = "Data de Nascimento";
            this.txtDtNasc.LeadingIcon = null;
            this.txtDtNasc.Location = new System.Drawing.Point(204, 134);
            this.txtDtNasc.MaxLength = 50;
            this.txtDtNasc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDtNasc.Multiline = false;
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(187, 50);
            this.txtDtNasc.TabIndex = 3;
            this.txtDtNasc.Text = "";
            this.txtDtNasc.TrailingIcon = null;
            this.txtDtNasc.Leave += new System.EventHandler(this.txtDtNasc_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Depth = 0;
            this.txtCelular.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular.Hint = "Celular";
            this.txtCelular.LeadingIcon = null;
            this.txtCelular.Location = new System.Drawing.Point(357, 415);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(271, 50);
            this.txtCelular.TabIndex = 12;
            this.txtCelular.Text = "";
            this.txtCelular.TrailingIcon = null;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave_1);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.LeadingIcon = null;
            this.txtTelefone.Location = new System.Drawing.Point(18, 415);
            this.txtTelefone.MaxLength = 50;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(271, 50);
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.Text = "";
            this.txtTelefone.TrailingIcon = null;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave_1);
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComplemento.Hint = "Complemento";
            this.txtComplemento.LeadingIcon = null;
            this.txtComplemento.Location = new System.Drawing.Point(18, 322);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(1131, 50);
            this.txtComplemento.TabIndex = 10;
            this.txtComplemento.Text = "";
            this.txtComplemento.TrailingIcon = null;
            // 
            // txtUF
            // 
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUF.Depth = 0;
            this.txtUF.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUF.Hint = "UF";
            this.txtUF.LeadingIcon = null;
            this.txtUF.Location = new System.Drawing.Point(1034, 233);
            this.txtUF.MaxLength = 2;
            this.txtUF.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUF.Multiline = false;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(102, 50);
            this.txtUF.TabIndex = 9;
            this.txtUF.Text = "";
            this.txtUF.TrailingIcon = null;
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMunicipio.Depth = 0;
            this.txtMunicipio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMunicipio.Hint = "Município";
            this.txtMunicipio.LeadingIcon = null;
            this.txtMunicipio.Location = new System.Drawing.Point(511, 233);
            this.txtMunicipio.MaxLength = 50;
            this.txtMunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMunicipio.Multiline = false;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(477, 50);
            this.txtMunicipio.TabIndex = 8;
            this.txtMunicipio.Text = "";
            this.txtMunicipio.TrailingIcon = null;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.Location = new System.Drawing.Point(148, 233);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(329, 50);
            this.txtBairro.TabIndex = 7;
            this.txtBairro.Text = "";
            this.txtBairro.TrailingIcon = null;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.Hint = "Número";
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.Location = new System.Drawing.Point(18, 233);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(102, 50);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(680, 134);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEndereco.Multiline = false;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(456, 50);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.Text = "";
            this.txtEndereco.TrailingIcon = null;
            // 
            // txtCEP
            // 
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCEP.Depth = 0;
            this.txtCEP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCEP.Hint = "CEP";
            this.txtCEP.LeadingIcon = null;
            this.txtCEP.Location = new System.Drawing.Point(412, 134);
            this.txtCEP.MaxLength = 50;
            this.txtCEP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCEP.Multiline = false;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(237, 50);
            this.txtCEP.TabIndex = 4;
            this.txtCEP.Text = "";
            this.txtCEP.TrailingIcon = null;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress_1);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "E-mail";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(721, 50);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(428, 50);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Depth = 0;
            this.txtCPF.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Hint = "CPF";
            this.txtCPF.LeadingIcon = null;
            this.txtCPF.Location = new System.Drawing.Point(538, 50);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(161, 50);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Text = "";
            this.txtCPF.TrailingIcon = null;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(204, 50);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 50);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.AutoSize = true;
            this.txtCodPaciente.Location = new System.Drawing.Point(203, 13);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(68, 13);
            this.txtCodPaciente.TabIndex = 271;
            this.txtCodPaciente.Text = "CodPaciente";
            this.txtCodPaciente.Visible = false;
            // 
            // btnCapturarImagem
            // 
            this.btnCapturarImagem.Location = new System.Drawing.Point(17, 187);
            this.btnCapturarImagem.Name = "btnCapturarImagem";
            this.btnCapturarImagem.Size = new System.Drawing.Size(174, 23);
            this.btnCapturarImagem.TabIndex = 270;
            this.btnCapturarImagem.Text = "Capturar Imagem";
            this.btnCapturarImagem.UseVisualStyleBackColor = true;
            // 
            // _dtgConsultaPacientes
            // 
            this._dtgConsultaPacientes.AllowUserToAddRows = false;
            this._dtgConsultaPacientes.AllowUserToOrderColumns = true;
            this._dtgConsultaPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dtgConsultaPacientes.BackgroundColor = System.Drawing.Color.White;
            this._dtgConsultaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtgConsultaPacientes.Location = new System.Drawing.Point(6, 474);
            this._dtgConsultaPacientes.Name = "_dtgConsultaPacientes";
            this._dtgConsultaPacientes.ReadOnly = true;
            this._dtgConsultaPacientes.RowHeadersWidth = 51;
            this._dtgConsultaPacientes.Size = new System.Drawing.Size(1188, 192);
            this._dtgConsultaPacientes.TabIndex = 15;
            this._dtgConsultaPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtgConsultaPacientes_CellDoubleClick);
            // 
            // _btnExcluir
            // 
            this._btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExcluir.AutoSize = true;
            this._btnExcluir.Image = global::TCC2.Properties.Resources.DeleteRed;
            this._btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcluir.Location = new System.Drawing.Point(1077, 430);
            this._btnExcluir.Name = "_btnExcluir";
            this._btnExcluir.Size = new System.Drawing.Size(115, 35);
            this._btnExcluir.TabIndex = 14;
            this._btnExcluir.Text = "Excluir";
            this._btnExcluir.UseVisualStyleBackColor = true;
            this._btnExcluir.Click += new System.EventHandler(this._btnExcluir_Click);
            // 
            // _btnSalvar
            // 
            this._btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSalvar.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this._btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSalvar.Location = new System.Drawing.Point(956, 430);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(115, 35);
            this._btnSalvar.TabIndex = 13;
            this._btnSalvar.Text = "Salvar";
            this._btnSalvar.UseVisualStyleBackColor = true;
            this._btnSalvar.Click += new System.EventHandler(this._btnSalvar_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::TCC2.Properties.Resources.no_icon_png_6;
            this.pbImagem.Location = new System.Drawing.Point(17, 13);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(174, 168);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 244;
            this.pbImagem.TabStop = false;
            this.pbImagem.Click += new System.EventHandler(this.pbImagem_Click);
            // 
            // tbAntropometricos
            // 
            this.tbAntropometricos.Controls.Add(this.cbxDataExisteAntro);
            this.tbAntropometricos.Controls.Add(this.txtDataAntro);
            this.tbAntropometricos.Controls.Add(this.cbxDataAntrop);
            this.tbAntropometricos.Controls.Add(this.gbxCircunferencias);
            this.tbAntropometricos.Controls.Add(this.gbxEstatura);
            this.tbAntropometricos.Controls.Add(this.txtPacienteAntro);
            this.tbAntropometricos.Controls.Add(this.btnAnalytics);
            this.tbAntropometricos.Controls.Add(this.btnClearAntro);
            this.tbAntropometricos.Controls.Add(this.btnPacAnt);
            this.tbAntropometricos.Location = new System.Drawing.Point(4, 22);
            this.tbAntropometricos.Name = "tbAntropometricos";
            this.tbAntropometricos.Padding = new System.Windows.Forms.Padding(3);
            this.tbAntropometricos.Size = new System.Drawing.Size(1198, 673);
            this.tbAntropometricos.TabIndex = 2;
            this.tbAntropometricos.Text = "Antropometria";
            this.tbAntropometricos.UseVisualStyleBackColor = true;
            // 
            // cbxDataExisteAntro
            // 
            this.cbxDataExisteAntro.AutoSize = true;
            this.cbxDataExisteAntro.Depth = 0;
            this.cbxDataExisteAntro.Location = new System.Drawing.Point(473, 15);
            this.cbxDataExisteAntro.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDataExisteAntro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxDataExisteAntro.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxDataExisteAntro.Name = "cbxDataExisteAntro";
            this.cbxDataExisteAntro.Ripple = true;
            this.cbxDataExisteAntro.Size = new System.Drawing.Size(163, 37);
            this.cbxDataExisteAntro.TabIndex = 328;
            this.cbxDataExisteAntro.Text = "Utilizar Nova Data";
            this.cbxDataExisteAntro.UseVisualStyleBackColor = true;
            this.cbxDataExisteAntro.CheckedChanged += new System.EventHandler(this.cbxDataExisteAntro_CheckedChanged);
            // 
            // txtDataAntro
            // 
            this.txtDataAntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataAntro.Depth = 0;
            this.txtDataAntro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataAntro.Hint = "Data";
            this.txtDataAntro.LeadingIcon = null;
            this.txtDataAntro.Location = new System.Drawing.Point(272, 6);
            this.txtDataAntro.MaxLength = 10;
            this.txtDataAntro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataAntro.Multiline = false;
            this.txtDataAntro.Name = "txtDataAntro";
            this.txtDataAntro.Size = new System.Drawing.Size(187, 50);
            this.txtDataAntro.TabIndex = 327;
            this.txtDataAntro.Text = "";
            this.txtDataAntro.TrailingIcon = null;
            this.txtDataAntro.Visible = false;
            this.txtDataAntro.Leave += new System.EventHandler(this.txtDataAntro_Leave);
            // 
            // cbxDataAntrop
            // 
            this.cbxDataAntrop.AutoResize = false;
            this.cbxDataAntrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDataAntrop.Depth = 0;
            this.cbxDataAntrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxDataAntrop.DropDownHeight = 174;
            this.cbxDataAntrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataAntrop.DropDownWidth = 121;
            this.cbxDataAntrop.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxDataAntrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxDataAntrop.FormattingEnabled = true;
            this.cbxDataAntrop.Hint = "Data Consulta";
            this.cbxDataAntrop.IntegralHeight = false;
            this.cbxDataAntrop.ItemHeight = 43;
            this.cbxDataAntrop.Location = new System.Drawing.Point(272, 6);
            this.cbxDataAntrop.MaxDropDownItems = 4;
            this.cbxDataAntrop.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxDataAntrop.Name = "cbxDataAntrop";
            this.cbxDataAntrop.Size = new System.Drawing.Size(187, 49);
            this.cbxDataAntrop.StartIndex = 0;
            this.cbxDataAntrop.TabIndex = 326;
            this.cbxDataAntrop.Visible = false;
            this.cbxDataAntrop.SelectedValueChanged += new System.EventHandler(this.cbxDataAntrop_SelectedValueChanged);
            // 
            // gbxCircunferencias
            // 
            this.gbxCircunferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCircunferencias.Controls.Add(this.txtAbdome);
            this.gbxCircunferencias.Controls.Add(this.txtPescoco);
            this.gbxCircunferencias.Controls.Add(this.btnCancelar);
            this.gbxCircunferencias.Controls.Add(this.btnSalvarAntro);
            this.gbxCircunferencias.Controls.Add(this.txtTorax);
            this.gbxCircunferencias.Controls.Add(this.txtPunho);
            this.gbxCircunferencias.Controls.Add(this.txtCoxa);
            this.gbxCircunferencias.Controls.Add(this.txtPanturrilha);
            this.gbxCircunferencias.Controls.Add(this.txtQuadril);
            this.gbxCircunferencias.Controls.Add(this.txtAntebraco);
            this.gbxCircunferencias.Controls.Add(this.txtCintura);
            this.gbxCircunferencias.Controls.Add(this.txtBraco);
            this.gbxCircunferencias.Location = new System.Drawing.Point(332, 65);
            this.gbxCircunferencias.Name = "gbxCircunferencias";
            this.gbxCircunferencias.Size = new System.Drawing.Size(860, 600);
            this.gbxCircunferencias.TabIndex = 324;
            this.gbxCircunferencias.TabStop = false;
            this.gbxCircunferencias.Text = "Circunferências";
            // 
            // txtAbdome
            // 
            this.txtAbdome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbdome.Depth = 0;
            this.txtAbdome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAbdome.Hint = "Abdome (cm)";
            this.txtAbdome.LeadingIcon = null;
            this.txtAbdome.Location = new System.Drawing.Point(469, 420);
            this.txtAbdome.MaxLength = 50;
            this.txtAbdome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAbdome.Multiline = false;
            this.txtAbdome.Name = "txtAbdome";
            this.txtAbdome.Size = new System.Drawing.Size(225, 50);
            this.txtAbdome.TabIndex = 9;
            this.txtAbdome.Text = "";
            this.txtAbdome.TrailingIcon = null;
            // 
            // txtPescoco
            // 
            this.txtPescoco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPescoco.Depth = 0;
            this.txtPescoco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPescoco.Hint = "Pescoço (cm)";
            this.txtPescoco.LeadingIcon = null;
            this.txtPescoco.Location = new System.Drawing.Point(88, 420);
            this.txtPescoco.MaxLength = 50;
            this.txtPescoco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPescoco.Multiline = false;
            this.txtPescoco.Name = "txtPescoco";
            this.txtPescoco.Size = new System.Drawing.Size(225, 50);
            this.txtPescoco.TabIndex = 8;
            this.txtPescoco.Text = "";
            this.txtPescoco.TrailingIcon = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(739, 557);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvarAntro
            // 
            this.btnSalvarAntro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAntro.AutoSize = true;
            this.btnSalvarAntro.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAntro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAntro.Location = new System.Drawing.Point(618, 557);
            this.btnSalvarAntro.Name = "btnSalvarAntro";
            this.btnSalvarAntro.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAntro.TabIndex = 10;
            this.btnSalvarAntro.Text = "Salvar";
            this.btnSalvarAntro.UseVisualStyleBackColor = true;
            this.btnSalvarAntro.Click += new System.EventHandler(this.btnSalvarAntro_Click);
            // 
            // txtTorax
            // 
            this.txtTorax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTorax.Depth = 0;
            this.txtTorax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTorax.Hint = "Tórax (cm)";
            this.txtTorax.LeadingIcon = null;
            this.txtTorax.Location = new System.Drawing.Point(469, 144);
            this.txtTorax.MaxLength = 50;
            this.txtTorax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTorax.Multiline = false;
            this.txtTorax.Name = "txtTorax";
            this.txtTorax.Size = new System.Drawing.Size(225, 50);
            this.txtTorax.TabIndex = 3;
            this.txtTorax.Text = "";
            this.txtTorax.TrailingIcon = null;
            // 
            // txtPunho
            // 
            this.txtPunho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPunho.Depth = 0;
            this.txtPunho.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPunho.Hint = "Punho (cm)";
            this.txtPunho.LeadingIcon = null;
            this.txtPunho.Location = new System.Drawing.Point(469, 45);
            this.txtPunho.MaxLength = 50;
            this.txtPunho.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPunho.Multiline = false;
            this.txtPunho.Name = "txtPunho";
            this.txtPunho.Size = new System.Drawing.Size(225, 50);
            this.txtPunho.TabIndex = 1;
            this.txtPunho.Text = "";
            this.txtPunho.TrailingIcon = null;
            // 
            // txtCoxa
            // 
            this.txtCoxa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoxa.Depth = 0;
            this.txtCoxa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCoxa.Hint = "Coxa (cm)";
            this.txtCoxa.LeadingIcon = null;
            this.txtCoxa.Location = new System.Drawing.Point(469, 331);
            this.txtCoxa.MaxLength = 50;
            this.txtCoxa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCoxa.Multiline = false;
            this.txtCoxa.Name = "txtCoxa";
            this.txtCoxa.Size = new System.Drawing.Size(225, 50);
            this.txtCoxa.TabIndex = 7;
            this.txtCoxa.Text = "";
            this.txtCoxa.TrailingIcon = null;
            // 
            // txtPanturrilha
            // 
            this.txtPanturrilha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPanturrilha.Depth = 0;
            this.txtPanturrilha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPanturrilha.Hint = "Panturrilha (cm)";
            this.txtPanturrilha.LeadingIcon = null;
            this.txtPanturrilha.Location = new System.Drawing.Point(469, 243);
            this.txtPanturrilha.MaxLength = 50;
            this.txtPanturrilha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPanturrilha.Multiline = false;
            this.txtPanturrilha.Name = "txtPanturrilha";
            this.txtPanturrilha.Size = new System.Drawing.Size(225, 50);
            this.txtPanturrilha.TabIndex = 5;
            this.txtPanturrilha.Text = "";
            this.txtPanturrilha.TrailingIcon = null;
            // 
            // txtQuadril
            // 
            this.txtQuadril.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuadril.Depth = 0;
            this.txtQuadril.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuadril.Hint = "Quadril (cm)";
            this.txtQuadril.LeadingIcon = null;
            this.txtQuadril.Location = new System.Drawing.Point(88, 243);
            this.txtQuadril.MaxLength = 50;
            this.txtQuadril.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuadril.Multiline = false;
            this.txtQuadril.Name = "txtQuadril";
            this.txtQuadril.Size = new System.Drawing.Size(225, 50);
            this.txtQuadril.TabIndex = 4;
            this.txtQuadril.Text = "";
            this.txtQuadril.TrailingIcon = null;
            // 
            // txtAntebraco
            // 
            this.txtAntebraco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAntebraco.Depth = 0;
            this.txtAntebraco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAntebraco.Hint = "Antebraço (cm)";
            this.txtAntebraco.LeadingIcon = null;
            this.txtAntebraco.Location = new System.Drawing.Point(88, 331);
            this.txtAntebraco.MaxLength = 50;
            this.txtAntebraco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAntebraco.Multiline = false;
            this.txtAntebraco.Name = "txtAntebraco";
            this.txtAntebraco.Size = new System.Drawing.Size(225, 50);
            this.txtAntebraco.TabIndex = 6;
            this.txtAntebraco.Text = "";
            this.txtAntebraco.TrailingIcon = null;
            // 
            // txtCintura
            // 
            this.txtCintura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCintura.Depth = 0;
            this.txtCintura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCintura.Hint = "Cintura (cm)";
            this.txtCintura.LeadingIcon = null;
            this.txtCintura.Location = new System.Drawing.Point(88, 144);
            this.txtCintura.MaxLength = 50;
            this.txtCintura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCintura.Multiline = false;
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(225, 50);
            this.txtCintura.TabIndex = 2;
            this.txtCintura.Text = "";
            this.txtCintura.TrailingIcon = null;
            // 
            // txtBraco
            // 
            this.txtBraco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBraco.Depth = 0;
            this.txtBraco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBraco.Hint = "Braço (cm)";
            this.txtBraco.LeadingIcon = null;
            this.txtBraco.Location = new System.Drawing.Point(88, 45);
            this.txtBraco.MaxLength = 50;
            this.txtBraco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBraco.Multiline = false;
            this.txtBraco.Name = "txtBraco";
            this.txtBraco.Size = new System.Drawing.Size(225, 50);
            this.txtBraco.TabIndex = 0;
            this.txtBraco.Text = "";
            this.txtBraco.TrailingIcon = null;
            // 
            // gbxEstatura
            // 
            this.gbxEstatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxEstatura.Controls.Add(this.tabCalculo);
            this.gbxEstatura.Controls.Add(this.txtPeso);
            this.gbxEstatura.Controls.Add(this.lblIMC);
            this.gbxEstatura.Controls.Add(this.txtAltura);
            this.gbxEstatura.Location = new System.Drawing.Point(16, 65);
            this.gbxEstatura.Name = "gbxEstatura";
            this.gbxEstatura.Size = new System.Drawing.Size(310, 600);
            this.gbxEstatura.TabIndex = 323;
            this.gbxEstatura.TabStop = false;
            this.gbxEstatura.Text = "Estatura";
            // 
            // tabCalculo
            // 
            this.tabCalculo.Controls.Add(this.tbDRI);
            this.tabCalculo.Controls.Add(this.tbHarrisBenedict);
            this.tabCalculo.Location = new System.Drawing.Point(25, 254);
            this.tabCalculo.Name = "tabCalculo";
            this.tabCalculo.SelectedIndex = 0;
            this.tabCalculo.Size = new System.Drawing.Size(200, 319);
            this.tabCalculo.TabIndex = 12;
            // 
            // tbDRI
            // 
            this.tbDRI.Controls.Add(this.rbDRIMuitoAtivo);
            this.tbDRI.Controls.Add(this.rbDRIAtivo);
            this.tbDRI.Controls.Add(this.rbDRIPoucoAtivo);
            this.tbDRI.Controls.Add(this.rbDRISedentario);
            this.tbDRI.Location = new System.Drawing.Point(4, 22);
            this.tbDRI.Name = "tbDRI";
            this.tbDRI.Padding = new System.Windows.Forms.Padding(3);
            this.tbDRI.Size = new System.Drawing.Size(192, 293);
            this.tbDRI.TabIndex = 0;
            this.tbDRI.Text = "DRI";
            this.tbDRI.UseVisualStyleBackColor = true;
            // 
            // rbDRIMuitoAtivo
            // 
            this.rbDRIMuitoAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDRIMuitoAtivo.AutoSize = true;
            this.rbDRIMuitoAtivo.Depth = 0;
            this.rbDRIMuitoAtivo.Location = new System.Drawing.Point(38, 170);
            this.rbDRIMuitoAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbDRIMuitoAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDRIMuitoAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDRIMuitoAtivo.Name = "rbDRIMuitoAtivo";
            this.rbDRIMuitoAtivo.Ripple = true;
            this.rbDRIMuitoAtivo.Size = new System.Drawing.Size(116, 37);
            this.rbDRIMuitoAtivo.TabIndex = 330;
            this.rbDRIMuitoAtivo.TabStop = true;
            this.rbDRIMuitoAtivo.Text = "Muito Ativo";
            this.rbDRIMuitoAtivo.UseVisualStyleBackColor = true;
            // 
            // rbDRIAtivo
            // 
            this.rbDRIAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDRIAtivo.AutoSize = true;
            this.rbDRIAtivo.Depth = 0;
            this.rbDRIAtivo.Location = new System.Drawing.Point(38, 122);
            this.rbDRIAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbDRIAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDRIAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDRIAtivo.Name = "rbDRIAtivo";
            this.rbDRIAtivo.Ripple = true;
            this.rbDRIAtivo.Size = new System.Drawing.Size(71, 37);
            this.rbDRIAtivo.TabIndex = 329;
            this.rbDRIAtivo.TabStop = true;
            this.rbDRIAtivo.Text = "Ativo";
            this.rbDRIAtivo.UseVisualStyleBackColor = true;
            // 
            // rbDRIPoucoAtivo
            // 
            this.rbDRIPoucoAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDRIPoucoAtivo.AutoSize = true;
            this.rbDRIPoucoAtivo.Depth = 0;
            this.rbDRIPoucoAtivo.Location = new System.Drawing.Point(38, 76);
            this.rbDRIPoucoAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbDRIPoucoAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDRIPoucoAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDRIPoucoAtivo.Name = "rbDRIPoucoAtivo";
            this.rbDRIPoucoAtivo.Ripple = true;
            this.rbDRIPoucoAtivo.Size = new System.Drawing.Size(120, 37);
            this.rbDRIPoucoAtivo.TabIndex = 328;
            this.rbDRIPoucoAtivo.TabStop = true;
            this.rbDRIPoucoAtivo.Text = "Pouco Ativo";
            this.rbDRIPoucoAtivo.UseVisualStyleBackColor = true;
            // 
            // rbDRISedentario
            // 
            this.rbDRISedentario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDRISedentario.AutoSize = true;
            this.rbDRISedentario.Depth = 0;
            this.rbDRISedentario.Location = new System.Drawing.Point(38, 29);
            this.rbDRISedentario.Margin = new System.Windows.Forms.Padding(0);
            this.rbDRISedentario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDRISedentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDRISedentario.Name = "rbDRISedentario";
            this.rbDRISedentario.Ripple = true;
            this.rbDRISedentario.Size = new System.Drawing.Size(111, 37);
            this.rbDRISedentario.TabIndex = 327;
            this.rbDRISedentario.TabStop = true;
            this.rbDRISedentario.Text = "Sedentário";
            this.rbDRISedentario.UseVisualStyleBackColor = true;
            // 
            // tbHarrisBenedict
            // 
            this.tbHarrisBenedict.Controls.Add(this.rbCAFMuitoPesado);
            this.tbHarrisBenedict.Controls.Add(this.rbCAFPesado);
            this.tbHarrisBenedict.Controls.Add(this.rbCAFModerado);
            this.tbHarrisBenedict.Controls.Add(this.rbCAFLeve);
            this.tbHarrisBenedict.Controls.Add(this.rbCAFSedentario);
            this.tbHarrisBenedict.Location = new System.Drawing.Point(4, 22);
            this.tbHarrisBenedict.Name = "tbHarrisBenedict";
            this.tbHarrisBenedict.Padding = new System.Windows.Forms.Padding(3);
            this.tbHarrisBenedict.Size = new System.Drawing.Size(192, 293);
            this.tbHarrisBenedict.TabIndex = 1;
            this.tbHarrisBenedict.Text = "Harris Benedict";
            this.tbHarrisBenedict.UseVisualStyleBackColor = true;
            // 
            // rbCAFMuitoPesado
            // 
            this.rbCAFMuitoPesado.AutoSize = true;
            this.rbCAFMuitoPesado.Depth = 0;
            this.rbCAFMuitoPesado.Location = new System.Drawing.Point(38, 217);
            this.rbCAFMuitoPesado.Margin = new System.Windows.Forms.Padding(0);
            this.rbCAFMuitoPesado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCAFMuitoPesado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCAFMuitoPesado.Name = "rbCAFMuitoPesado";
            this.rbCAFMuitoPesado.Ripple = true;
            this.rbCAFMuitoPesado.Size = new System.Drawing.Size(133, 37);
            this.rbCAFMuitoPesado.TabIndex = 336;
            this.rbCAFMuitoPesado.TabStop = true;
            this.rbCAFMuitoPesado.Text = "Muito Pesado";
            this.rbCAFMuitoPesado.UseVisualStyleBackColor = true;
            // 
            // rbCAFPesado
            // 
            this.rbCAFPesado.AutoSize = true;
            this.rbCAFPesado.Depth = 0;
            this.rbCAFPesado.Location = new System.Drawing.Point(38, 168);
            this.rbCAFPesado.Margin = new System.Windows.Forms.Padding(0);
            this.rbCAFPesado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCAFPesado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCAFPesado.Name = "rbCAFPesado";
            this.rbCAFPesado.Ripple = true;
            this.rbCAFPesado.Size = new System.Drawing.Size(88, 37);
            this.rbCAFPesado.TabIndex = 335;
            this.rbCAFPesado.TabStop = true;
            this.rbCAFPesado.Text = "Pesado";
            this.rbCAFPesado.UseVisualStyleBackColor = true;
            // 
            // rbCAFModerado
            // 
            this.rbCAFModerado.AutoSize = true;
            this.rbCAFModerado.Depth = 0;
            this.rbCAFModerado.Location = new System.Drawing.Point(38, 120);
            this.rbCAFModerado.Margin = new System.Windows.Forms.Padding(0);
            this.rbCAFModerado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCAFModerado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCAFModerado.Name = "rbCAFModerado";
            this.rbCAFModerado.Ripple = true;
            this.rbCAFModerado.Size = new System.Drawing.Size(107, 37);
            this.rbCAFModerado.TabIndex = 334;
            this.rbCAFModerado.TabStop = true;
            this.rbCAFModerado.Text = "Moderado";
            this.rbCAFModerado.UseVisualStyleBackColor = true;
            // 
            // rbCAFLeve
            // 
            this.rbCAFLeve.AutoSize = true;
            this.rbCAFLeve.Depth = 0;
            this.rbCAFLeve.Location = new System.Drawing.Point(38, 74);
            this.rbCAFLeve.Margin = new System.Windows.Forms.Padding(0);
            this.rbCAFLeve.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCAFLeve.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCAFLeve.Name = "rbCAFLeve";
            this.rbCAFLeve.Ripple = true;
            this.rbCAFLeve.Size = new System.Drawing.Size(68, 37);
            this.rbCAFLeve.TabIndex = 333;
            this.rbCAFLeve.TabStop = true;
            this.rbCAFLeve.Text = "Leve";
            this.rbCAFLeve.UseVisualStyleBackColor = true;
            // 
            // rbCAFSedentario
            // 
            this.rbCAFSedentario.AutoSize = true;
            this.rbCAFSedentario.Depth = 0;
            this.rbCAFSedentario.Location = new System.Drawing.Point(38, 27);
            this.rbCAFSedentario.Margin = new System.Windows.Forms.Padding(0);
            this.rbCAFSedentario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCAFSedentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCAFSedentario.Name = "rbCAFSedentario";
            this.rbCAFSedentario.Ripple = true;
            this.rbCAFSedentario.Size = new System.Drawing.Size(111, 37);
            this.rbCAFSedentario.TabIndex = 332;
            this.rbCAFSedentario.TabStop = true;
            this.rbCAFSedentario.Text = "Sedentário";
            this.rbCAFSedentario.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Depth = 0;
            this.txtPeso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPeso.Hint = "Peso (kg)";
            this.txtPeso.LeadingIcon = null;
            this.txtPeso.Location = new System.Drawing.Point(25, 45);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(225, 50);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.Text = "";
            this.txtPeso.TrailingIcon = null;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Depth = 0;
            this.lblIMC.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIMC.Location = new System.Drawing.Point(22, 219);
            this.lblIMC.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(1, 0);
            this.lblIMC.TabIndex = 322;
            // 
            // txtAltura
            // 
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAltura.Hint = "Altura (m)";
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(25, 144);
            this.txtAltura.MaxLength = 50;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(225, 50);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Text = "";
            this.txtAltura.TrailingIcon = null;
            this.txtAltura.Leave += new System.EventHandler(this.txtAltura_Leave);
            // 
            // txtPacienteAntro
            // 
            this.txtPacienteAntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteAntro.Depth = 0;
            this.txtPacienteAntro.Enabled = false;
            this.txtPacienteAntro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteAntro.Hint = "Paciente";
            this.txtPacienteAntro.LeadingIcon = null;
            this.txtPacienteAntro.Location = new System.Drawing.Point(6, 6);
            this.txtPacienteAntro.MaxLength = 50;
            this.txtPacienteAntro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteAntro.Multiline = false;
            this.txtPacienteAntro.Name = "txtPacienteAntro";
            this.txtPacienteAntro.ReadOnly = true;
            this.txtPacienteAntro.Size = new System.Drawing.Size(188, 50);
            this.txtPacienteAntro.TabIndex = 0;
            this.txtPacienteAntro.Text = "";
            this.txtPacienteAntro.TrailingIcon = null;
            this.txtPacienteAntro.TextChanged += new System.EventHandler(this.txtPacienteAntro_TextChanged);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalytics.Image = global::TCC2.Properties.Resources._4230540_analysis_graph_report_115003;
            this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.Location = new System.Drawing.Point(1078, 24);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(114, 35);
            this.btnAnalytics.TabIndex = 325;
            this.btnAnalytics.Text = "Gráfico";
            this.btnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnClearAntro
            // 
            this.btnClearAntro.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnClearAntro.Location = new System.Drawing.Point(236, 21);
            this.btnClearAntro.Name = "btnClearAntro";
            this.btnClearAntro.Size = new System.Drawing.Size(30, 23);
            this.btnClearAntro.TabIndex = 320;
            this.btnClearAntro.UseVisualStyleBackColor = true;
            this.btnClearAntro.Click += new System.EventHandler(this.btnClearAntro_Click);
            // 
            // btnPacAnt
            // 
            this.btnPacAnt.Image = global::TCC2.Properties.Resources.consultar;
            this.btnPacAnt.Location = new System.Drawing.Point(200, 21);
            this.btnPacAnt.Name = "btnPacAnt";
            this.btnPacAnt.Size = new System.Drawing.Size(30, 23);
            this.btnPacAnt.TabIndex = 319;
            this.btnPacAnt.UseVisualStyleBackColor = true;
            this.btnPacAnt.Click += new System.EventHandler(this.btnPacAnt_Click);
            // 
            // tbAnamnese
            // 
            this.tbAnamnese.Controls.Add(this.btnLimpar);
            this.tbAnamnese.Controls.Add(this.cbxCarregarTemplate);
            this.tbAnamnese.Controls.Add(this.cbxDataAnamnese);
            this.tbAnamnese.Controls.Add(this.txtPacienteAnamnese);
            this.tbAnamnese.Controls.Add(this.rtxtAnamnese);
            this.tbAnamnese.Controls.Add(this.btnConfigAnamnese);
            this.tbAnamnese.Controls.Add(this.btnFindPacienteAnamnese);
            this.tbAnamnese.Controls.Add(this.btnSalvarAnamnese);
            this.tbAnamnese.Location = new System.Drawing.Point(4, 22);
            this.tbAnamnese.Margin = new System.Windows.Forms.Padding(2);
            this.tbAnamnese.Name = "tbAnamnese";
            this.tbAnamnese.Padding = new System.Windows.Forms.Padding(2);
            this.tbAnamnese.Size = new System.Drawing.Size(1198, 673);
            this.tbAnamnese.TabIndex = 3;
            this.tbAnamnese.Text = "Anamnese";
            this.tbAnamnese.UseVisualStyleBackColor = true;
            this.tbAnamnese.Enter += new System.EventHandler(this.tbAnamnese_Enter);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnLimpar.Location = new System.Drawing.Point(865, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(30, 23);
            this.btnLimpar.TabIndex = 325;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxCarregarTemplate
            // 
            this.cbxCarregarTemplate.AutoResize = false;
            this.cbxCarregarTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCarregarTemplate.Depth = 0;
            this.cbxCarregarTemplate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCarregarTemplate.DropDownHeight = 174;
            this.cbxCarregarTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCarregarTemplate.DropDownWidth = 121;
            this.cbxCarregarTemplate.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCarregarTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCarregarTemplate.FormattingEnabled = true;
            this.cbxCarregarTemplate.Hint = "Carregar Template";
            this.cbxCarregarTemplate.IntegralHeight = false;
            this.cbxCarregarTemplate.ItemHeight = 43;
            this.cbxCarregarTemplate.Items.AddRange(new object[] {
            ""});
            this.cbxCarregarTemplate.Location = new System.Drawing.Point(557, 6);
            this.cbxCarregarTemplate.MaxDropDownItems = 4;
            this.cbxCarregarTemplate.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCarregarTemplate.Name = "cbxCarregarTemplate";
            this.cbxCarregarTemplate.Size = new System.Drawing.Size(302, 49);
            this.cbxCarregarTemplate.StartIndex = 0;
            this.cbxCarregarTemplate.TabIndex = 324;
            this.cbxCarregarTemplate.SelectedIndexChanged += new System.EventHandler(this.cbxCarregarTemplate_SelectedIndexChanged);
            // 
            // cbxDataAnamnese
            // 
            this.cbxDataAnamnese.AutoResize = false;
            this.cbxDataAnamnese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDataAnamnese.Depth = 0;
            this.cbxDataAnamnese.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxDataAnamnese.DropDownHeight = 174;
            this.cbxDataAnamnese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataAnamnese.DropDownWidth = 121;
            this.cbxDataAnamnese.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxDataAnamnese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxDataAnamnese.FormattingEnabled = true;
            this.cbxDataAnamnese.Hint = "Data Consulta";
            this.cbxDataAnamnese.IntegralHeight = false;
            this.cbxDataAnamnese.ItemHeight = 43;
            this.cbxDataAnamnese.Items.AddRange(new object[] {
            ""});
            this.cbxDataAnamnese.Location = new System.Drawing.Point(235, 6);
            this.cbxDataAnamnese.MaxDropDownItems = 4;
            this.cbxDataAnamnese.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxDataAnamnese.Name = "cbxDataAnamnese";
            this.cbxDataAnamnese.Size = new System.Drawing.Size(302, 49);
            this.cbxDataAnamnese.StartIndex = 0;
            this.cbxDataAnamnese.TabIndex = 322;
            this.cbxDataAnamnese.Visible = false;
            this.cbxDataAnamnese.SelectedIndexChanged += new System.EventHandler(this.cbxDataAnamnese_SelectedIndexChanged);
            // 
            // txtPacienteAnamnese
            // 
            this.txtPacienteAnamnese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteAnamnese.Depth = 0;
            this.txtPacienteAnamnese.Enabled = false;
            this.txtPacienteAnamnese.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteAnamnese.Hint = "Paciente";
            this.txtPacienteAnamnese.LeadingIcon = null;
            this.txtPacienteAnamnese.Location = new System.Drawing.Point(5, 5);
            this.txtPacienteAnamnese.MaxLength = 50;
            this.txtPacienteAnamnese.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteAnamnese.Multiline = false;
            this.txtPacienteAnamnese.Name = "txtPacienteAnamnese";
            this.txtPacienteAnamnese.ReadOnly = true;
            this.txtPacienteAnamnese.Size = new System.Drawing.Size(188, 50);
            this.txtPacienteAnamnese.TabIndex = 0;
            this.txtPacienteAnamnese.Text = "";
            this.txtPacienteAnamnese.TrailingIcon = null;
            this.txtPacienteAnamnese.TextChanged += new System.EventHandler(this.txtPacienteAnamnese_TextChanged);
            // 
            // rtxtAnamnese
            // 
            this.rtxtAnamnese.AcceptsTab = false;
            this.rtxtAnamnese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtAnamnese.AutoWordSelection = true;
            this.rtxtAnamnese.DetectURLs = true;
            this.rtxtAnamnese.Location = new System.Drawing.Point(5, 61);
            this.rtxtAnamnese.Name = "rtxtAnamnese";
            this.rtxtAnamnese.PlainText = "";
            this.rtxtAnamnese.ReadOnly = false;
            // 
            // 
            // 
            this.rtxtAnamnese.RichTextBox.AutoWordSelection = true;
            this.rtxtAnamnese.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtAnamnese.RichTextBox.Location = new System.Drawing.Point(0, 26);
            this.rtxtAnamnese.RichTextBox.Name = "rtb1";
            this.rtxtAnamnese.RichTextBox.Size = new System.Drawing.Size(1188, 539);
            this.rtxtAnamnese.RichTextBox.TabIndex = 1;
            this.rtxtAnamnese.ShowBold = true;
            this.rtxtAnamnese.ShowCenterJustify = true;
            this.rtxtAnamnese.ShowColors = true;
            this.rtxtAnamnese.ShowCopy = true;
            this.rtxtAnamnese.ShowCut = true;
            this.rtxtAnamnese.ShowFont = true;
            this.rtxtAnamnese.ShowFontSize = true;
            this.rtxtAnamnese.ShowItalic = true;
            this.rtxtAnamnese.ShowLeftJustify = true;
            this.rtxtAnamnese.ShowOpen = true;
            this.rtxtAnamnese.ShowPaste = true;
            this.rtxtAnamnese.ShowRedo = true;
            this.rtxtAnamnese.ShowRightJustify = true;
            this.rtxtAnamnese.ShowSave = true;
            this.rtxtAnamnese.ShowStamp = true;
            this.rtxtAnamnese.ShowStrikeout = true;
            this.rtxtAnamnese.ShowToolBarText = false;
            this.rtxtAnamnese.ShowUnderline = true;
            this.rtxtAnamnese.ShowUndo = true;
            this.rtxtAnamnese.Size = new System.Drawing.Size(1188, 565);
            this.rtxtAnamnese.StampAction = MvtWindowsForms.StampActions.EditedBy;
            this.rtxtAnamnese.StampColor = System.Drawing.Color.Blue;
            this.rtxtAnamnese.TabIndex = 2;
            // 
            // 
            // 
            this.rtxtAnamnese.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.rtxtAnamnese.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.rtxtAnamnese.Toolbar.Divider = false;
            this.rtxtAnamnese.Toolbar.DropDownArrows = true;
            this.rtxtAnamnese.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.rtxtAnamnese.Toolbar.Name = "tb1";
            this.rtxtAnamnese.Toolbar.ShowToolTips = true;
            this.rtxtAnamnese.Toolbar.Size = new System.Drawing.Size(1188, 26);
            this.rtxtAnamnese.Toolbar.TabIndex = 0;
            // 
            // btnConfigAnamnese
            // 
            this.btnConfigAnamnese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfigAnamnese.AutoSize = true;
            this.btnConfigAnamnese.Image = global::TCC2.Properties.Resources.diagram_43_24474__1_;
            this.btnConfigAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigAnamnese.Location = new System.Drawing.Point(5, 630);
            this.btnConfigAnamnese.Name = "btnConfigAnamnese";
            this.btnConfigAnamnese.Size = new System.Drawing.Size(133, 35);
            this.btnConfigAnamnese.TabIndex = 323;
            this.btnConfigAnamnese.Text = "Configuração";
            this.btnConfigAnamnese.UseVisualStyleBackColor = true;
            this.btnConfigAnamnese.Click += new System.EventHandler(this.btnConfigAnamnese_Click);
            // 
            // btnFindPacienteAnamnese
            // 
            this.btnFindPacienteAnamnese.Image = global::TCC2.Properties.Resources.consultar;
            this.btnFindPacienteAnamnese.Location = new System.Drawing.Point(199, 21);
            this.btnFindPacienteAnamnese.Name = "btnFindPacienteAnamnese";
            this.btnFindPacienteAnamnese.Size = new System.Drawing.Size(30, 23);
            this.btnFindPacienteAnamnese.TabIndex = 1;
            this.btnFindPacienteAnamnese.UseVisualStyleBackColor = true;
            this.btnFindPacienteAnamnese.Click += new System.EventHandler(this.btnFindPacienteAnamnese_Click);
            // 
            // btnSalvarAnamnese
            // 
            this.btnSalvarAnamnese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAnamnese.AutoSize = true;
            this.btnSalvarAnamnese.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAnamnese.Location = new System.Drawing.Point(1078, 630);
            this.btnSalvarAnamnese.Name = "btnSalvarAnamnese";
            this.btnSalvarAnamnese.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAnamnese.TabIndex = 3;
            this.btnSalvarAnamnese.Text = "Salvar";
            this.btnSalvarAnamnese.UseVisualStyleBackColor = true;
            this.btnSalvarAnamnese.Click += new System.EventHandler(this.btnSalvarAnamnese_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.White;
            this.tabConfig.Controls.Add(this.tbConfig);
            this.tabConfig.ImageKey = "settings32px.png";
            this.tabConfig.Location = new System.Drawing.Point(4, 39);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1222, 717);
            this.tabConfig.TabIndex = 5;
            this.tabConfig.Text = "Configurações";
            // 
            // tbConfig
            // 
            this.tbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConfig.Controls.Add(this.tbUsuarios);
            this.tbConfig.Controls.Add(this.tbPermissao);
            this.tbConfig.Controls.Add(this.tabHorarioAtendimento);
            this.tbConfig.Location = new System.Drawing.Point(6, 6);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.SelectedIndex = 0;
            this.tbConfig.Size = new System.Drawing.Size(1212, 702);
            this.tbConfig.TabIndex = 1;
            this.tbConfig.Enter += new System.EventHandler(this.tbConfig_Enter);
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.Controls.Add(this.txtCRN);
            this.tbUsuarios.Controls.Add(this.txtEmailConfig);
            this.tbUsuarios.Controls.Add(this.cbxTipoUsuario);
            this.tbUsuarios.Controls.Add(this.cbxSituacao);
            this.tbUsuarios.Controls.Add(this.txtConfirmarSenha);
            this.tbUsuarios.Controls.Add(this.txtSenha);
            this.tbUsuarios.Controls.Add(this.txtNomeUsuarioConfig);
            this.tbUsuarios.Controls.Add(this.txtUsuarioConfig);
            this.tbUsuarios.Controls.Add(this.btnExcluirConfigUsuario);
            this.tbUsuarios.Controls.Add(this.btnSalvarConfigUsuario);
            this.tbUsuarios.Controls.Add(this.dtgUsuarios);
            this.tbUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuarios.Size = new System.Drawing.Size(1204, 676);
            this.tbUsuarios.TabIndex = 0;
            this.tbUsuarios.Text = "Usuários";
            this.tbUsuarios.UseVisualStyleBackColor = true;
            // 
            // txtCRN
            // 
            this.txtCRN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCRN.Depth = 0;
            this.txtCRN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCRN.Hint = "CRN";
            this.txtCRN.LeadingIcon = null;
            this.txtCRN.Location = new System.Drawing.Point(608, 163);
            this.txtCRN.MaxLength = 50;
            this.txtCRN.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCRN.Multiline = false;
            this.txtCRN.Name = "txtCRN";
            this.txtCRN.Size = new System.Drawing.Size(219, 50);
            this.txtCRN.TabIndex = 7;
            this.txtCRN.Text = "";
            this.txtCRN.TrailingIcon = null;
            // 
            // txtEmailConfig
            // 
            this.txtEmailConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailConfig.Depth = 0;
            this.txtEmailConfig.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailConfig.Hint = "E-mail";
            this.txtEmailConfig.LeadingIcon = null;
            this.txtEmailConfig.Location = new System.Drawing.Point(9, 163);
            this.txtEmailConfig.MaxLength = 50;
            this.txtEmailConfig.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmailConfig.Multiline = false;
            this.txtEmailConfig.Name = "txtEmailConfig";
            this.txtEmailConfig.Size = new System.Drawing.Size(567, 50);
            this.txtEmailConfig.TabIndex = 6;
            this.txtEmailConfig.Text = "";
            this.txtEmailConfig.TrailingIcon = null;
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.AutoResize = false;
            this.cbxTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTipoUsuario.Depth = 0;
            this.cbxTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTipoUsuario.DropDownHeight = 174;
            this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoUsuario.DropDownWidth = 121;
            this.cbxTipoUsuario.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Hint = "Tipo Usuário";
            this.cbxTipoUsuario.IntegralHeight = false;
            this.cbxTipoUsuario.ItemHeight = 43;
            this.cbxTipoUsuario.Items.AddRange(new object[] {
            "Nutricionista",
            "Recepcionista",
            "Auxíliar"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(658, 84);
            this.cbxTipoUsuario.MaxDropDownItems = 4;
            this.cbxTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(302, 49);
            this.cbxTipoUsuario.StartIndex = 0;
            this.cbxTipoUsuario.TabIndex = 5;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.AutoResize = false;
            this.cbxSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxSituacao.Depth = 0;
            this.cbxSituacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxSituacao.DropDownHeight = 174;
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.DropDownWidth = 121;
            this.cbxSituacao.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Hint = "Situação";
            this.cbxSituacao.IntegralHeight = false;
            this.cbxSituacao.ItemHeight = 43;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbxSituacao.Location = new System.Drawing.Point(839, 6);
            this.cbxSituacao.MaxDropDownItems = 4;
            this.cbxSituacao.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(261, 49);
            this.cbxSituacao.StartIndex = 0;
            this.cbxSituacao.TabIndex = 2;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Depth = 0;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmarSenha.Hint = "Confirmar Senha";
            this.txtConfirmarSenha.LeadingIcon = null;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(338, 84);
            this.txtConfirmarSenha.MaxLength = 50;
            this.txtConfirmarSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmarSenha.Multiline = false;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Password = true;
            this.txtConfirmarSenha.Size = new System.Drawing.Size(280, 50);
            this.txtConfirmarSenha.TabIndex = 4;
            this.txtConfirmarSenha.Text = "";
            this.txtConfirmarSenha.TrailingIcon = null;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(9, 84);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Password = true;
            this.txtSenha.Size = new System.Drawing.Size(280, 50);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            // 
            // txtNomeUsuarioConfig
            // 
            this.txtNomeUsuarioConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUsuarioConfig.Depth = 0;
            this.txtNomeUsuarioConfig.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeUsuarioConfig.Hint = "Nome";
            this.txtNomeUsuarioConfig.LeadingIcon = null;
            this.txtNomeUsuarioConfig.Location = new System.Drawing.Point(338, 6);
            this.txtNomeUsuarioConfig.MaxLength = 50;
            this.txtNomeUsuarioConfig.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeUsuarioConfig.Multiline = false;
            this.txtNomeUsuarioConfig.Name = "txtNomeUsuarioConfig";
            this.txtNomeUsuarioConfig.Size = new System.Drawing.Size(461, 50);
            this.txtNomeUsuarioConfig.TabIndex = 1;
            this.txtNomeUsuarioConfig.Text = "";
            this.txtNomeUsuarioConfig.TrailingIcon = null;
            // 
            // txtUsuarioConfig
            // 
            this.txtUsuarioConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioConfig.Depth = 0;
            this.txtUsuarioConfig.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioConfig.Hint = "Usuário";
            this.txtUsuarioConfig.LeadingIcon = null;
            this.txtUsuarioConfig.Location = new System.Drawing.Point(9, 6);
            this.txtUsuarioConfig.MaxLength = 50;
            this.txtUsuarioConfig.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuarioConfig.Multiline = false;
            this.txtUsuarioConfig.Name = "txtUsuarioConfig";
            this.txtUsuarioConfig.Size = new System.Drawing.Size(280, 50);
            this.txtUsuarioConfig.TabIndex = 0;
            this.txtUsuarioConfig.Text = "";
            this.txtUsuarioConfig.TrailingIcon = null;
            this.txtUsuarioConfig.Leave += new System.EventHandler(this.txtUsuarioConfig_Leave);
            // 
            // btnExcluirConfigUsuario
            // 
            this.btnExcluirConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirConfigUsuario.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnExcluirConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirConfigUsuario.Location = new System.Drawing.Point(1081, 178);
            this.btnExcluirConfigUsuario.Name = "btnExcluirConfigUsuario";
            this.btnExcluirConfigUsuario.Size = new System.Drawing.Size(115, 35);
            this.btnExcluirConfigUsuario.TabIndex = 9;
            this.btnExcluirConfigUsuario.Text = "Excluir";
            this.btnExcluirConfigUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirConfigUsuario.Click += new System.EventHandler(this.btnExcluirConfigUsuario_Click);
            // 
            // btnSalvarConfigUsuario
            // 
            this.btnSalvarConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarConfigUsuario.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarConfigUsuario.Location = new System.Drawing.Point(960, 178);
            this.btnSalvarConfigUsuario.Name = "btnSalvarConfigUsuario";
            this.btnSalvarConfigUsuario.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarConfigUsuario.TabIndex = 8;
            this.btnSalvarConfigUsuario.Text = "Salvar";
            this.btnSalvarConfigUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarConfigUsuario.Click += new System.EventHandler(this.btnSalvarConfigUsuario_Click);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(6, 219);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.Size = new System.Drawing.Size(1191, 444);
            this.dtgUsuarios.TabIndex = 10;
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            this.dtgUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgUsuarios_KeyDown);
            // 
            // tbPermissao
            // 
            this.tbPermissao.Controls.Add(this.btnExcluirPerm);
            this.tbPermissao.Controls.Add(this.cbxTelaLiberarPerm);
            this.tbPermissao.Controls.Add(this.cbxUsuarioPerm);
            this.tbPermissao.Controls.Add(this.dtgPermUsuarios);
            this.tbPermissao.Controls.Add(this.btnSalvarPermissao);
            this.tbPermissao.Location = new System.Drawing.Point(4, 22);
            this.tbPermissao.Name = "tbPermissao";
            this.tbPermissao.Padding = new System.Windows.Forms.Padding(3);
            this.tbPermissao.Size = new System.Drawing.Size(1204, 676);
            this.tbPermissao.TabIndex = 1;
            this.tbPermissao.Text = "Permissões";
            this.tbPermissao.UseVisualStyleBackColor = true;
            this.tbPermissao.Enter += new System.EventHandler(this.tbPermissao_Enter);
            // 
            // btnExcluirPerm
            // 
            this.btnExcluirPerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirPerm.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnExcluirPerm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirPerm.Location = new System.Drawing.Point(1083, 133);
            this.btnExcluirPerm.Name = "btnExcluirPerm";
            this.btnExcluirPerm.Size = new System.Drawing.Size(115, 35);
            this.btnExcluirPerm.TabIndex = 10;
            this.btnExcluirPerm.Text = "Excluir";
            this.btnExcluirPerm.UseVisualStyleBackColor = true;
            this.btnExcluirPerm.Click += new System.EventHandler(this.btnExcluirPerm_Click);
            // 
            // cbxTelaLiberarPerm
            // 
            this.cbxTelaLiberarPerm.AutoResize = false;
            this.cbxTelaLiberarPerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTelaLiberarPerm.Depth = 0;
            this.cbxTelaLiberarPerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTelaLiberarPerm.DropDownHeight = 174;
            this.cbxTelaLiberarPerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTelaLiberarPerm.DropDownWidth = 121;
            this.cbxTelaLiberarPerm.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTelaLiberarPerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTelaLiberarPerm.FormattingEnabled = true;
            this.cbxTelaLiberarPerm.Hint = "Programa";
            this.cbxTelaLiberarPerm.IntegralHeight = false;
            this.cbxTelaLiberarPerm.ItemHeight = 43;
            this.cbxTelaLiberarPerm.Items.AddRange(new object[] {
            "Home",
            "Agenda",
            "Alimento",
            "Cardápio",
            "Paciente",
            "Configurações",
            "Sobre"});
            this.cbxTelaLiberarPerm.Location = new System.Drawing.Point(8, 91);
            this.cbxTelaLiberarPerm.MaxDropDownItems = 4;
            this.cbxTelaLiberarPerm.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTelaLiberarPerm.Name = "cbxTelaLiberarPerm";
            this.cbxTelaLiberarPerm.Size = new System.Drawing.Size(522, 49);
            this.cbxTelaLiberarPerm.StartIndex = 0;
            this.cbxTelaLiberarPerm.TabIndex = 1;
            // 
            // cbxUsuarioPerm
            // 
            this.cbxUsuarioPerm.AutoResize = false;
            this.cbxUsuarioPerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxUsuarioPerm.Depth = 0;
            this.cbxUsuarioPerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxUsuarioPerm.DropDownHeight = 174;
            this.cbxUsuarioPerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuarioPerm.DropDownWidth = 121;
            this.cbxUsuarioPerm.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxUsuarioPerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxUsuarioPerm.FormattingEnabled = true;
            this.cbxUsuarioPerm.Hint = "Usuário";
            this.cbxUsuarioPerm.IntegralHeight = false;
            this.cbxUsuarioPerm.ItemHeight = 43;
            this.cbxUsuarioPerm.Location = new System.Drawing.Point(8, 16);
            this.cbxUsuarioPerm.MaxDropDownItems = 4;
            this.cbxUsuarioPerm.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxUsuarioPerm.Name = "cbxUsuarioPerm";
            this.cbxUsuarioPerm.Size = new System.Drawing.Size(522, 49);
            this.cbxUsuarioPerm.StartIndex = 0;
            this.cbxUsuarioPerm.TabIndex = 0;
            // 
            // dtgPermUsuarios
            // 
            this.dtgPermUsuarios.AllowUserToAddRows = false;
            this.dtgPermUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPermUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgPermUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermUsuarios.Location = new System.Drawing.Point(8, 174);
            this.dtgPermUsuarios.Name = "dtgPermUsuarios";
            this.dtgPermUsuarios.ReadOnly = true;
            this.dtgPermUsuarios.RowHeadersWidth = 51;
            this.dtgPermUsuarios.Size = new System.Drawing.Size(1191, 496);
            this.dtgPermUsuarios.TabIndex = 3;
            this.dtgPermUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermUsuarios_CellDoubleClick);
            // 
            // btnSalvarPermissao
            // 
            this.btnSalvarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPermissao.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarPermissao.Location = new System.Drawing.Point(962, 133);
            this.btnSalvarPermissao.Name = "btnSalvarPermissao";
            this.btnSalvarPermissao.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarPermissao.TabIndex = 2;
            this.btnSalvarPermissao.Text = "Salvar";
            this.btnSalvarPermissao.UseVisualStyleBackColor = true;
            this.btnSalvarPermissao.Click += new System.EventHandler(this.btnSalvarPermissao_Click);
            // 
            // tabHorarioAtendimento
            // 
            this.tabHorarioAtendimento.Controls.Add(this.dtgConfigHorario);
            this.tabHorarioAtendimento.Controls.Add(this.txtHoraFim);
            this.tabHorarioAtendimento.Controls.Add(this.cbxDiaSemana);
            this.tabHorarioAtendimento.Controls.Add(this.txtHoraInicio);
            this.tabHorarioAtendimento.Controls.Add(this.cbxUsuNutri);
            this.tabHorarioAtendimento.Controls.Add(this.btnSalvarHoraAtend);
            this.tabHorarioAtendimento.Location = new System.Drawing.Point(4, 22);
            this.tabHorarioAtendimento.Margin = new System.Windows.Forms.Padding(2);
            this.tabHorarioAtendimento.Name = "tabHorarioAtendimento";
            this.tabHorarioAtendimento.Padding = new System.Windows.Forms.Padding(2);
            this.tabHorarioAtendimento.Size = new System.Drawing.Size(1204, 676);
            this.tabHorarioAtendimento.TabIndex = 2;
            this.tabHorarioAtendimento.Text = "Horário Atendimento";
            this.tabHorarioAtendimento.UseVisualStyleBackColor = true;
            this.tabHorarioAtendimento.Enter += new System.EventHandler(this.tabHorarioAtendimento_Enter);
            // 
            // dtgConfigHorario
            // 
            this.dtgConfigHorario.AllowUserToAddRows = false;
            this.dtgConfigHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConfigHorario.BackgroundColor = System.Drawing.Color.White;
            this.dtgConfigHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConfigHorario.Location = new System.Drawing.Point(5, 228);
            this.dtgConfigHorario.Name = "dtgConfigHorario";
            this.dtgConfigHorario.ReadOnly = true;
            this.dtgConfigHorario.RowHeadersWidth = 51;
            this.dtgConfigHorario.Size = new System.Drawing.Size(1192, 440);
            this.dtgConfigHorario.TabIndex = 5;
            this.dtgConfigHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConfigHorario_CellDoubleClick);
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraFim.Depth = 0;
            this.txtHoraFim.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoraFim.Hint = "Hora Fim";
            this.txtHoraFim.LeadingIcon = null;
            this.txtHoraFim.Location = new System.Drawing.Point(5, 172);
            this.txtHoraFim.MaxLength = 5;
            this.txtHoraFim.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoraFim.Multiline = false;
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Size = new System.Drawing.Size(280, 50);
            this.txtHoraFim.TabIndex = 3;
            this.txtHoraFim.Text = "";
            this.txtHoraFim.TrailingIcon = null;
            this.txtHoraFim.Validated += new System.EventHandler(this.txtHoraFim_Validated);
            // 
            // cbxDiaSemana
            // 
            this.cbxDiaSemana.AutoResize = false;
            this.cbxDiaSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDiaSemana.Depth = 0;
            this.cbxDiaSemana.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxDiaSemana.DropDownHeight = 174;
            this.cbxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiaSemana.DropDownWidth = 121;
            this.cbxDiaSemana.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxDiaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxDiaSemana.FormattingEnabled = true;
            this.cbxDiaSemana.Hint = "Usuário";
            this.cbxDiaSemana.IntegralHeight = false;
            this.cbxDiaSemana.ItemHeight = 43;
            this.cbxDiaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cbxDiaSemana.Location = new System.Drawing.Point(5, 61);
            this.cbxDiaSemana.MaxDropDownItems = 4;
            this.cbxDiaSemana.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxDiaSemana.Name = "cbxDiaSemana";
            this.cbxDiaSemana.Size = new System.Drawing.Size(522, 49);
            this.cbxDiaSemana.StartIndex = 0;
            this.cbxDiaSemana.TabIndex = 1;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraInicio.Depth = 0;
            this.txtHoraInicio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoraInicio.Hint = "Hora Inicio";
            this.txtHoraInicio.LeadingIcon = null;
            this.txtHoraInicio.Location = new System.Drawing.Point(5, 116);
            this.txtHoraInicio.MaxLength = 5;
            this.txtHoraInicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoraInicio.Multiline = false;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(280, 50);
            this.txtHoraInicio.TabIndex = 2;
            this.txtHoraInicio.Text = "";
            this.txtHoraInicio.TrailingIcon = null;
            this.txtHoraInicio.Validated += new System.EventHandler(this.txtHoraInicio_Validated);
            // 
            // cbxUsuNutri
            // 
            this.cbxUsuNutri.AutoResize = false;
            this.cbxUsuNutri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxUsuNutri.Depth = 0;
            this.cbxUsuNutri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxUsuNutri.DropDownHeight = 174;
            this.cbxUsuNutri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuNutri.DropDownWidth = 121;
            this.cbxUsuNutri.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxUsuNutri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxUsuNutri.FormattingEnabled = true;
            this.cbxUsuNutri.Hint = "Usuário";
            this.cbxUsuNutri.IntegralHeight = false;
            this.cbxUsuNutri.ItemHeight = 43;
            this.cbxUsuNutri.Location = new System.Drawing.Point(5, 6);
            this.cbxUsuNutri.MaxDropDownItems = 4;
            this.cbxUsuNutri.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxUsuNutri.Name = "cbxUsuNutri";
            this.cbxUsuNutri.Size = new System.Drawing.Size(522, 49);
            this.cbxUsuNutri.StartIndex = 0;
            this.cbxUsuNutri.TabIndex = 0;
            // 
            // btnSalvarHoraAtend
            // 
            this.btnSalvarHoraAtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarHoraAtend.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarHoraAtend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarHoraAtend.Location = new System.Drawing.Point(1082, 187);
            this.btnSalvarHoraAtend.Name = "btnSalvarHoraAtend";
            this.btnSalvarHoraAtend.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarHoraAtend.TabIndex = 4;
            this.btnSalvarHoraAtend.Text = "Salvar";
            this.btnSalvarHoraAtend.UseVisualStyleBackColor = true;
            this.btnSalvarHoraAtend.Click += new System.EventHandler(this.btnSalvarHoraAtend_Click);
            // 
            // tbSobre
            // 
            this.tbSobre.BackColor = System.Drawing.Color.White;
            this.tbSobre.Controls.Add(this.linkLabel1);
            this.tbSobre.Controls.Add(this.materialLabel14);
            this.tbSobre.Controls.Add(this.materialLabel13);
            this.tbSobre.Controls.Add(this.materialLabel12);
            this.tbSobre.Controls.Add(this.materialLabel11);
            this.tbSobre.Controls.Add(this.materialLabel10);
            this.tbSobre.Controls.Add(this.materialLabel9);
            this.tbSobre.Controls.Add(this.materialLabel8);
            this.tbSobre.Controls.Add(this.materialLabel6);
            this.tbSobre.Controls.Add(this.materialLabel4);
            this.tbSobre.Controls.Add(this.materialLabel3);
            this.tbSobre.Controls.Add(this.materialLabel2);
            this.tbSobre.Controls.Add(this.materialLabel1);
            this.tbSobre.ImageKey = "information.png";
            this.tbSobre.Location = new System.Drawing.Point(4, 39);
            this.tbSobre.Name = "tbSobre";
            this.tbSobre.Padding = new System.Windows.Forms.Padding(3);
            this.tbSobre.Size = new System.Drawing.Size(1222, 717);
            this.tbSobre.TabIndex = 7;
            this.tbSobre.Text = "Sobre";
            this.tbSobre.Enter += new System.EventHandler(this.tbSobre_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 494);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui para abrir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(6, 462);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(828, 19);
            this.materialLabel14.TabIndex = 11;
            this.materialLabel14.Text = "Após ter utilizado e avaliado o projeto, você, por favor, poderia responder o meu" +
    " questionário a respeito do aplicativo?";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(20, 330);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(818, 19);
            this.materialLabel13.TabIndex = 10;
            this.materialLabel13.Text = "-> Implementação LGPD (Caso utilize dados reais, qualquer infração a lei, o desen" +
    "volvedor não se responsabilizará.)";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(20, 311);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(367, 19);
            this.materialLabel12.TabIndex = 9;
            this.materialLabel12.Text = "-> Ajustes gerais no programa, como correções e etc";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(20, 292);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(252, 19);
            this.materialLabel11.TabIndex = 8;
            this.materialLabel11.Text = "-> Aplicativo celular para o Paciente";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(6, 263);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(180, 19);
            this.materialLabel10.TabIndex = 7;
            this.materialLabel10.Text = "Futuras implementações:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(6, 244);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(1146, 19);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "Você que obteve o aplicativo para testar, você poderá manter o uso do mesmo até 3" +
    "1/12/2021! Lembrando que se trata de um protótipo e que haverão mudanças!";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(6, 161);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(508, 19);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "designs mais intuítivos e fazendo o atendimento ser mais fácil e rápido!";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 132);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(1078, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Este aplicativo, foi desenvolvido como TCC para buscar melhorar a consulta da Nut" +
    "ricionista com seu Paciente, trazendo valores/cálculos mais precisos,";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(89, 66);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(170, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Engenharia de Software";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 66);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Formação:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(55, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Guilherme Rüdiger";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Autor:";
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
            // NutriEzIconNotify
            // 
            this.NutriEzIconNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("NutriEzIconNotify.Icon")));
            this.NutriEzIconNotify.Text = "NutriEz";
            this.NutriEzIconNotify.Visible = true;
            // 
            // FrmMenuPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 827);
            this.Controls.Add(this.TabControlNutreasy);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlNutreasy;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NutriEz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAlimento.ResumeLayout(false);
            this.tbAlimento.ResumeLayout(false);
            this._tbConsulta.ResumeLayout(false);
            this._tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).EndInit();
            this.tbImportarPlanilha.ResumeLayout(false);
            this.tbImportarPlanilha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosImportados)).EndInit();
            this.tbCadMedCaseira.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddMedCaseira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalvarMedCaseira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedCaseiraAlimentos)).EndInit();
            this.tabCardapio.ResumeLayout(false);
            this.tbCardapio.ResumeLayout(false);
            this.tbCadCardapio.ResumeLayout(false);
            this.tbCadCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAliCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapioAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).EndInit();
            this.tbConsultaCardapio.ResumeLayout(false);
            this.tbConsultaCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trwDadosCard)).EndInit();
            this.tabPaciente.ResumeLayout(false);
            this.tbPaciente.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.tbAntropometricos.ResumeLayout(false);
            this.tbAntropometricos.PerformLayout();
            this.gbxCircunferencias.ResumeLayout(false);
            this.gbxCircunferencias.PerformLayout();
            this.gbxEstatura.ResumeLayout(false);
            this.gbxEstatura.PerformLayout();
            this.tabCalculo.ResumeLayout(false);
            this.tbDRI.ResumeLayout(false);
            this.tbDRI.PerformLayout();
            this.tbHarrisBenedict.ResumeLayout(false);
            this.tbHarrisBenedict.PerformLayout();
            this.tbAnamnese.ResumeLayout(false);
            this.tbAnamnese.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tbConfig.ResumeLayout(false);
            this.tbUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.tbPermissao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermUsuarios)).EndInit();
            this.tabHorarioAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfigHorario)).EndInit();
            this.tbSobre.ResumeLayout(false);
            this.tbSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlNutreasy;
        private System.Windows.Forms.TabPage tabMenu;
        internal System.Windows.Forms.PictureBox pbxLogoGrande;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.TabPage tabAlimento;
        private System.Windows.Forms.TabPage tabPaciente;
        internal System.Windows.Forms.TabControl tbPaciente;
        internal System.Windows.Forms.TabPage tbCadastro;
        public System.Windows.Forms.Button _btnExcluir;
        public System.Windows.Forms.Button _btnSalvar;
        internal System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.TabPage tbAntropometricos;
        private System.Windows.Forms.TabPage tabConfig;
        internal System.Windows.Forms.TabControl tbConfig;
        internal System.Windows.Forms.TabPage tbUsuarios;
        internal System.Windows.Forms.Button btnExcluirConfigUsuario;
        internal System.Windows.Forms.Button btnSalvarConfigUsuario;
        internal System.Windows.Forms.DataGridView dtgUsuarios;
        internal System.Windows.Forms.TabPage tbPermissao;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.DataGridView _dtgConsultaPacientes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tbAnamnese;
        private System.Windows.Forms.TabPage tabCardapio;
        private System.Windows.Forms.TabControl tbCardapio;
        private System.Windows.Forms.TabPage tbCadCardapio;
        private LiveCharts.WinForms.PieChart graficoMacroNutri;
        private System.Windows.Forms.PictureBox btnAddAliCard;
        private System.Windows.Forms.Button btnPacienteCardapio;
        internal System.Windows.Forms.DataGridView dtgCardapioAlimentos;
        internal System.Windows.Forms.DataGridView dtgRefeicoes;
        internal System.Windows.Forms.Button btnSalvarCardapio;
        private System.Windows.Forms.TabPage tbConsultaCardapio;
        private System.Windows.Forms.Button btnBuscaPaciente;
        private System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnCancelarCardapio;
        private System.Windows.Forms.TabPage tbSobre;
        private System.Windows.Forms.Button btnCapturarImagem;
        internal System.Windows.Forms.Label txtCodPaciente;
        private MaterialSkin.Controls.MaterialCard mCardAtendimentoAtual;
        private MaterialSkin.Controls.MaterialLabel mlblObservação;
        private MaterialSkin.Controls.MaterialLabel mlblHorario;
        private MaterialSkin.Controls.MaterialLabel mlblNome;
        private MaterialSkin.Controls.MaterialCheckbox mcbxCancelar;
        private MaterialSkin.Controls.MaterialCheckbox mcbxAtendido;
        private MaterialSkin.Controls.MaterialCard mCardAtendimentoFuturo;
        private MaterialSkin.Controls.MaterialCheckbox mcbxCancelarFuturo;
        private MaterialSkin.Controls.MaterialCheckbox mcbxAtendidoFuturo;
        private MaterialSkin.Controls.MaterialLabel mlblObservacaoFuturo;
        private MaterialSkin.Controls.MaterialLabel mlblHoraFutura;
        private MaterialSkin.Controls.MaterialLabel mlblNomeFuturo;
        private TreeGridView trwDadosCard;
        private MvtWindowsForms.RitchTextBoxWithToolBar rtxtAnamnese;
        internal System.Windows.Forms.DataGridView dtgPermUsuarios;
        internal System.Windows.Forms.Button btnSalvarPermissao;
        public MaterialSkin.Controls.MaterialTextBox txtNome;
        public MaterialSkin.Controls.MaterialTextBox txtCPF;
        public MaterialSkin.Controls.MaterialTextBox txtComplemento;
        public MaterialSkin.Controls.MaterialTextBox txtUF;
        public MaterialSkin.Controls.MaterialTextBox txtMunicipio;
        public MaterialSkin.Controls.MaterialTextBox txtBairro;
        public MaterialSkin.Controls.MaterialTextBox txtNumero;
        public MaterialSkin.Controls.MaterialTextBox txtEndereco;
        public MaterialSkin.Controls.MaterialTextBox txtCEP;
        public MaterialSkin.Controls.MaterialTextBox txtEmail;
        public MaterialSkin.Controls.MaterialTextBox txtTelefone;
        public MaterialSkin.Controls.MaterialTextBox txtCelular;
        public MaterialSkin.Controls.MaterialTextBox txtPaciente;
        public MaterialSkin.Controls.MaterialTextBox txtPacienteConsultaCardapio;
        private MaterialSkin.Controls.MaterialComboBox cbxTabelaAlimentoCardapio;
        private MaterialSkin.Controls.MaterialComboBox cbxRefeicao;
        public MaterialSkin.Controls.MaterialTextBox txtFiltroAlimento;
        private MaterialSkin.Controls.MaterialLabel lblValorKcal;
        private MaterialSkin.Controls.MaterialLabel lblVlrKcal;
        public MaterialSkin.Controls.MaterialTextBox txtUsuarioConfig;
        public MaterialSkin.Controls.MaterialTextBox txtEmailConfig;
        private MaterialSkin.Controls.MaterialComboBox cbxTipoUsuario;
        private MaterialSkin.Controls.MaterialComboBox cbxSituacao;
        public MaterialSkin.Controls.MaterialTextBox txtConfirmarSenha;
        public MaterialSkin.Controls.MaterialTextBox txtSenha;
        public MaterialSkin.Controls.MaterialTextBox txtNomeUsuarioConfig;
        private MaterialSkin.Controls.MaterialComboBox cbxTelaLiberarPerm;
        private MaterialSkin.Controls.MaterialComboBox cbxUsuarioPerm;
        private System.Windows.Forms.Calendar.Calendar calAgendamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox txtCRN;
        internal System.Windows.Forms.Button btnSalvarAnamnese;
        public MaterialSkin.Controls.MaterialTextBox txtPacienteAnamnese;
        private System.Windows.Forms.Button btnFindPacienteAnamnese;
        private System.Windows.Forms.TabPage tabHorarioAtendimento;
        private MaterialSkin.Controls.MaterialComboBox cbxUsuNutri;
        public MaterialSkin.Controls.MaterialTextBox txtHoraFim;
        private MaterialSkin.Controls.MaterialComboBox cbxDiaSemana;
        public MaterialSkin.Controls.MaterialTextBox txtHoraInicio;
        private System.Windows.Forms.Button btnBuscarPacienteAgendamento;
        private MaterialSkin.Controls.MaterialTextBox txtHoraAgenda;
        private MaterialSkin.Controls.MaterialTextBox txtDataAgendamento;
        internal System.Windows.Forms.Button btnSalvarAgenda;
        public System.Windows.Forms.Button btnApagarCardapio;
        private System.Windows.Forms.NotifyIcon NutriEzIconNotify;
        internal System.Windows.Forms.DataGridView dtgConfigHorario;
        internal System.Windows.Forms.Button btnSalvarHoraAtend;
        private System.Windows.Forms.GroupBox gbxCircunferencias;
        public System.Windows.Forms.Button btnSalvarAntro;
        public MaterialSkin.Controls.MaterialTextBox txtTorax;
        public MaterialSkin.Controls.MaterialTextBox txtPunho;
        public MaterialSkin.Controls.MaterialTextBox txtCoxa;
        public MaterialSkin.Controls.MaterialTextBox txtPanturrilha;
        public MaterialSkin.Controls.MaterialTextBox txtQuadril;
        public MaterialSkin.Controls.MaterialTextBox txtAntebraco;
        public MaterialSkin.Controls.MaterialTextBox txtCintura;
        public MaterialSkin.Controls.MaterialTextBox txtBraco;
        private System.Windows.Forms.GroupBox gbxEstatura;
        public MaterialSkin.Controls.MaterialTextBox txtPeso;
        private MaterialSkin.Controls.MaterialLabel lblIMC;
        public MaterialSkin.Controls.MaterialTextBox txtAltura;
        public MaterialSkin.Controls.MaterialTextBox txtPacienteAntro;
        private System.Windows.Forms.Button btnClearAntro;
        private System.Windows.Forms.Button btnPacAnt;
        public MaterialSkin.Controls.MaterialTextBox txtLipidio;
        public MaterialSkin.Controls.MaterialTextBox txtCarboidrato;
        public MaterialSkin.Controls.MaterialTextBox txtProteina;
        public MaterialSkin.Controls.MaterialTextBox txtDtNasc;
        public MaterialSkin.Controls.MaterialTextBox txtPacienteAgenda;
        private MaterialSkin.Controls.MaterialCheckbox cbxRetorno;
        private System.Windows.Forms.Button btnAnalytics;
        internal System.Windows.Forms.TabControl tbAlimento;
        private System.Windows.Forms.TabPage _tbConsulta;
        public MaterialSkin.Controls.MaterialTextBox txtAlimentoFiltro;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lblTabela;
        private MaterialSkin.Controls.MaterialComboBox cbxTabela;
        public System.Windows.Forms.Button btnCancelarEditAlimentos;
        internal System.Windows.Forms.Button btnRecalcular;
        internal System.Windows.Forms.Button btnSalvarAlimento;
        internal System.Windows.Forms.DataGridView dtgConAlimento;
        internal System.Windows.Forms.TabPage tbImportarPlanilha;
        public MaterialSkin.Controls.MaterialTextBox txtNomeTabela;
        private MaterialSkin.Controls.MaterialComboBox _cbxNomePlanilha;
        public MaterialSkin.Controls.MaterialTextBox txtCaminhoArquivoExcel;
        internal System.Windows.Forms.DataGridView dtgDadosImportados;
        private System.Windows.Forms.Button _btnImportar;
        private System.Windows.Forms.Button _btnBuscarPlanilha;
        private System.Windows.Forms.TabPage tbCadMedCaseira;
        public MaterialSkin.Controls.MaterialTextBox mTxtFiltroAlimentoMedCas;
        private MaterialSkin.Controls.MaterialComboBox mCbxTabelasMedCas;
        internal System.Windows.Forms.DataGridView dtgSalvarMedCaseira;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTabela;
        internal System.Windows.Forms.DataGridView dtgMedCaseiraAlimentos;
        internal System.Windows.Forms.Button btnSalvarMedCas;
        public System.Windows.Forms.Button btnExportar;
        private MaterialSkin.Controls.MaterialComboBox cbxDataConsulta;
        private System.Windows.Forms.MonthCalendar mCalendar;
        public MaterialSkin.Controls.MaterialTextBox txtDataCardapio;
        private MvtWindowsForms.MvtDataGridView dtgCardGrid;
        private MaterialSkin.Controls.MaterialComboBox cbxDataAnamnese;
        internal System.Windows.Forms.Button btnConfigAnamnese;
        private MaterialSkin.Controls.MaterialComboBox cbxCarregarTemplate;
        private System.Windows.Forms.Button btnLimpar;
        private MaterialSkin.Controls.MaterialCheckbox chkPacNew;
        internal System.Windows.Forms.Button btnExcluirPerm;
        private System.Windows.Forms.Button btnConsultarCardapio;
        private System.Windows.Forms.PictureBox pbAddMedCaseira;
        private System.Windows.Forms.DataGridViewTextBoxColumn refeicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidacaseiraqtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn observ;
        private MaterialSkin.Controls.MaterialComboBox cbxDataAntrop;
        private MaterialSkin.Controls.MaterialCheckbox cbxDataExisteAntro;
        public MaterialSkin.Controls.MaterialTextBox txtDataAntro;
        private MaterialSkin.Controls.MaterialCheckbox chkDataExisteCardapio;
        private MaterialSkin.Controls.MaterialComboBox cbxDataCardSalvo;
        public System.Windows.Forms.Button btnCancelar;
        public MaterialSkin.Controls.MaterialTextBox txtAbdome;
        public MaterialSkin.Controls.MaterialTextBox txtPescoco;
        private MaterialSkin.Controls.MaterialLabel mlblVET;
        private MaterialSkin.Controls.MaterialLabel mlblTMB;
        private MaterialSkin.Controls.MaterialCheckbox chkTMB;
        private MaterialSkin.Controls.MaterialRadioButton rbDRI;
        private MaterialSkin.Controls.MaterialRadioButton rbFAOOMS;
        private MaterialSkin.Controls.MaterialRadioButton rbHarrisBenedict;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblVET;
        private MaterialSkin.Controls.MaterialLabel lblTMB;
        private MaterialSkin.Controls.MaterialLabel datalbl;
        private MaterialSkin.Controls.MaterialRadioButton rbFeminino;
        private MaterialSkin.Controls.MaterialRadioButton rbMasculino;
        private System.Windows.Forms.TabControl tabCalculo;
        private System.Windows.Forms.TabPage tbDRI;
        private MaterialSkin.Controls.MaterialRadioButton rbDRIMuitoAtivo;
        private MaterialSkin.Controls.MaterialRadioButton rbDRIAtivo;
        private MaterialSkin.Controls.MaterialRadioButton rbDRIPoucoAtivo;
        private MaterialSkin.Controls.MaterialRadioButton rbDRISedentario;
        private System.Windows.Forms.TabPage tbHarrisBenedict;
        private MaterialSkin.Controls.MaterialRadioButton rbCAFMuitoPesado;
        private MaterialSkin.Controls.MaterialRadioButton rbCAFPesado;
        private MaterialSkin.Controls.MaterialRadioButton rbCAFModerado;
        private MaterialSkin.Controls.MaterialRadioButton rbCAFLeve;
        private MaterialSkin.Controls.MaterialRadioButton rbCAFSedentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn prot;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lipidio;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxMedCaseira;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        public System.Windows.Forms.Button btnEnviarCardEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

