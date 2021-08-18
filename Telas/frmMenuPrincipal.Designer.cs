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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.CalendarioMes = new System.Windows.Forms.Calendar.MonthView();
            this.txtHoraAgenda = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataAgendamento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPacienteAgenda = new MaterialSkin.Controls.MaterialTextBox();
            this.calAgendamento = new System.Windows.Forms.Calendar.Calendar();
            this.tabAlimento = new System.Windows.Forms.TabPage();
            this.tbAlimento = new System.Windows.Forms.TabControl();
            this._tbConsulta = new System.Windows.Forms.TabPage();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtAlimentoFiltro = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTabela = new MaterialSkin.Controls.MaterialComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.dtgConAlimento = new System.Windows.Forms.DataGridView();
            this.tbImportarPlanilha = new System.Windows.Forms.TabPage();
            this.txtNomeTabela = new MaterialSkin.Controls.MaterialTextBox();
            this._cbxNomePlanilha = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCaminhoArquivoExcel = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgDadosImportados = new System.Windows.Forms.DataGridView();
            this.tbCadMedCaseira = new System.Windows.Forms.TabPage();
            this.mTxtFiltroAlimentoMedCas = new MaterialSkin.Controls.MaterialTextBox();
            this.mCbxTabelasMedCas = new MaterialSkin.Controls.MaterialComboBox();
            this.txtQtdMedCas = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescMedCaseira = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAlimentoMedCaseira = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodAlimentoMedCas = new System.Windows.Forms.TextBox();
            this.dtgSalvarMedCaseira = new System.Windows.Forms.DataGridView();
            this.salvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgMedCaseiraAlimentos = new System.Windows.Forms.DataGridView();
            this.tabCardapio = new System.Windows.Forms.TabPage();
            this.tbCardapio = new System.Windows.Forms.TabControl();
            this.tbCadCardapio = new System.Windows.Forms.TabPage();
            this.txtLipidio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCarboidrato = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProteina = new MaterialSkin.Controls.MaterialTextBox();
            this.lblValorKcal = new MaterialSkin.Controls.MaterialLabel();
            this.lblVlrKcal = new MaterialSkin.Controls.MaterialLabel();
            this.txtFiltroAlimento = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTabelaAlimentoCardapio = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxRefeicao = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPaciente = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConfigGramasCard = new System.Windows.Forms.Button();
            this.graficoMacroNutri = new LiveCharts.WinForms.PieChart();
            this.dtgCardapioAlimentos = new System.Windows.Forms.DataGridView();
            this.dtgRefeicoes = new System.Windows.Forms.DataGridView();
            this.tbConsultaCardapio = new System.Windows.Forms.TabPage();
            this.txtPacienteConsultaCardapio = new MaterialSkin.Controls.MaterialTextBox();
            this.trwDadosCard = new AdvancedDataGridView.TreeGridView();
            this.tbCadastrarTiposCardapios = new System.Windows.Forms.TabPage();
            this.tabPaciente = new System.Windows.Forms.TabPage();
            this.tbPaciente = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
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
            this.txtDtNasc = new System.Windows.Forms.DateTimePicker();
            this._dtgConsultaPacientes = new System.Windows.Forms.DataGridView();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.tbAntropometricos = new System.Windows.Forms.TabPage();
            this.gbxCircunferencias = new System.Windows.Forms.GroupBox();
            this.txtTorax = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPunho = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCoxa = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPanturrilha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuadril = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAntebraco = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCintura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBraco = new MaterialSkin.Controls.MaterialTextBox();
            this.gbxEstatura = new System.Windows.Forms.GroupBox();
            this.txtPeso = new MaterialSkin.Controls.MaterialTextBox();
            this.lblIMC = new MaterialSkin.Controls.MaterialLabel();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPacienteAntro = new MaterialSkin.Controls.MaterialTextBox();
            this.tbAnamnese = new System.Windows.Forms.TabPage();
            this.txtPacienteAnamnese = new MaterialSkin.Controls.MaterialTextBox();
            this.rtxtAnamnese = new MvtWindowsForms.RitchTextBoxWithToolBar();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tbConfig = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtCRN = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmailConfig = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxSituacao = new MaterialSkin.Controls.MaterialComboBox();
            this.txtConfirmarSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNomeUsuarioConfig = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsuarioConfig = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.tbPermissao = new System.Windows.Forms.TabPage();
            this.cbxTelaLiberarPerm = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxUsuarioPerm = new MaterialSkin.Controls.MaterialComboBox();
            this.dtgPermUsuarios = new System.Windows.Forms.DataGridView();
            this.tabHorarioAtendimento = new System.Windows.Forms.TabPage();
            this.dtgConfigHorario = new System.Windows.Forms.DataGridView();
            this.txtHoraFim = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxDiaSemana = new MaterialSkin.Controls.MaterialComboBox();
            this.txtHoraInicio = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxUsuNutri = new MaterialSkin.Controls.MaterialComboBox();
            this.tbSobre = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NutreasyIconNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbxLogoGrande = new System.Windows.Forms.PictureBox();
            this.btnSalvarAgenda = new System.Windows.Forms.Button();
            this.btnBuscarPacienteAgendamento = new System.Windows.Forms.Button();
            this.btnCancelarEditAlimentos = new System.Windows.Forms.Button();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.btnSalvarAlimento = new System.Windows.Forms.Button();
            this._btnImportar = new System.Windows.Forms.Button();
            this._btnBuscarPlanilha = new System.Windows.Forms.Button();
            this.btnAddMedCaseira = new System.Windows.Forms.Button();
            this.btnSalvarMedCas = new System.Windows.Forms.Button();
            this.btnCancelarCardapio = new System.Windows.Forms.Button();
            this.btnAddAliCard = new System.Windows.Forms.PictureBox();
            this.btnPacienteCardapio = new System.Windows.Forms.Button();
            this.btnSalvarCardapio = new System.Windows.Forms.Button();
            this.btnApagarCardapio = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this._btnExcluir = new System.Windows.Forms.Button();
            this._btnSalvar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnSalvarAntro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPacAnt = new System.Windows.Forms.Button();
            this.btnFindPacienteAnamnese = new System.Windows.Forms.Button();
            this.btnSalvarAnamnese = new System.Windows.Forms.Button();
            this.btnExcluirConfigUsuario = new System.Windows.Forms.Button();
            this.btnSalvarConfigUsuario = new System.Windows.Forms.Button();
            this.btnSalvarPermissao = new System.Windows.Forms.Button();
            this.btnSalvarHoraAtend = new System.Windows.Forms.Button();
            this.TabControlNutreasy.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.mCardAtendimentoAtual.SuspendLayout();
            this.mCardAtendimentoFuturo.SuspendLayout();
            this.tabAgenda.SuspendLayout();
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
            this.tbCardapio.SuspendLayout();
            this.tbCadCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapioAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).BeginInit();
            this.tbConsultaCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trwDadosCard)).BeginInit();
            this.tabPaciente.SuspendLayout();
            this.tbPaciente.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgConsultaPacientes)).BeginInit();
            this.tbAntropometricos.SuspendLayout();
            this.gbxCircunferencias.SuspendLayout();
            this.gbxEstatura.SuspendLayout();
            this.tbAnamnese.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.tbPermissao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermUsuarios)).BeginInit();
            this.tabHorarioAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfigHorario)).BeginInit();
            this.tbSobre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAliCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
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
            this.TabControlNutreasy.Size = new System.Drawing.Size(1240, 746);
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
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1232, 703);
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
            this.mCardAtendimentoAtual.Location = new System.Drawing.Point(17, 36);
            this.mCardAtendimentoAtual.Margin = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoAtual.Name = "mCardAtendimentoAtual";
            this.mCardAtendimentoAtual.Padding = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoAtual.Size = new System.Drawing.Size(337, 266);
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
            this.materialButton2.Location = new System.Drawing.Point(98, 217);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.mCardAtendimentoFuturo.Controls.Add(this.materialButton1);
            this.mCardAtendimentoFuturo.Controls.Add(this.mcbxCancelarFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mcbxAtendidoFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblObservacaoFuturo);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblHoraFutura);
            this.mCardAtendimentoFuturo.Controls.Add(this.mlblNomeFuturo);
            this.mCardAtendimentoFuturo.Depth = 0;
            this.mCardAtendimentoFuturo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardAtendimentoFuturo.Location = new System.Drawing.Point(886, 36);
            this.mCardAtendimentoFuturo.Margin = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoFuturo.Name = "mCardAtendimentoFuturo";
            this.mCardAtendimentoFuturo.Padding = new System.Windows.Forms.Padding(14);
            this.mCardAtendimentoFuturo.Size = new System.Drawing.Size(337, 266);
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
            this.materialButton1.Location = new System.Drawing.Point(98, 217);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(1181, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 19);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Label1";
            // 
            // tabAgenda
            // 
            this.tabAgenda.Controls.Add(this.CalendarioMes);
            this.tabAgenda.Controls.Add(this.txtHoraAgenda);
            this.tabAgenda.Controls.Add(this.txtDataAgendamento);
            this.tabAgenda.Controls.Add(this.txtPacienteAgenda);
            this.tabAgenda.Controls.Add(this.calAgendamento);
            this.tabAgenda.Controls.Add(this.btnSalvarAgenda);
            this.tabAgenda.Controls.Add(this.btnBuscarPacienteAgendamento);
            this.tabAgenda.ImageKey = "agenda32px.png";
            this.tabAgenda.Location = new System.Drawing.Point(4, 39);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(1232, 703);
            this.tabAgenda.TabIndex = 1;
            this.tabAgenda.Text = "Agenda";
            this.tabAgenda.UseVisualStyleBackColor = true;
            this.tabAgenda.Enter += new System.EventHandler(this.tabAgenda_Enter);
            // 
            // CalendarioMes
            // 
            this.CalendarioMes.ArrowsColor = System.Drawing.SystemColors.Window;
            this.CalendarioMes.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.CalendarioMes.DayBackgroundColor = System.Drawing.Color.Empty;
            this.CalendarioMes.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.CalendarioMes.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.CalendarioMes.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.CalendarioMes.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.CalendarioMes.ItemPadding = new System.Windows.Forms.Padding(2);
            this.CalendarioMes.Location = new System.Drawing.Point(346, 6);
            this.CalendarioMes.Margin = new System.Windows.Forms.Padding(2);
            this.CalendarioMes.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalendarioMes.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.CalendarioMes.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalendarioMes.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.CalendarioMes.Name = "CalendarioMes";
            this.CalendarioMes.Size = new System.Drawing.Size(189, 157);
            this.CalendarioMes.TabIndex = 307;
            this.CalendarioMes.Text = "monthView1";
            this.CalendarioMes.TodayBorderColor = System.Drawing.Color.Maroon;
            this.CalendarioMes.Click += new System.EventHandler(this.CalendarioMes_Click);
            // 
            // txtHoraAgenda
            // 
            this.txtHoraAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraAgenda.Depth = 0;
            this.txtHoraAgenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoraAgenda.Hint = "Hora";
            this.txtHoraAgenda.LeadingIcon = null;
            this.txtHoraAgenda.Location = new System.Drawing.Point(5, 114);
            this.txtHoraAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraAgenda.MaxLength = 50;
            this.txtHoraAgenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoraAgenda.Multiline = false;
            this.txtHoraAgenda.Name = "txtHoraAgenda";
            this.txtHoraAgenda.Size = new System.Drawing.Size(248, 50);
            this.txtHoraAgenda.TabIndex = 304;
            this.txtHoraAgenda.Text = "";
            this.txtHoraAgenda.TrailingIcon = null;
            // 
            // txtDataAgendamento
            // 
            this.txtDataAgendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataAgendamento.Depth = 0;
            this.txtDataAgendamento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataAgendamento.Hint = "Data";
            this.txtDataAgendamento.LeadingIcon = null;
            this.txtDataAgendamento.Location = new System.Drawing.Point(5, 60);
            this.txtDataAgendamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataAgendamento.MaxLength = 50;
            this.txtDataAgendamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataAgendamento.Multiline = false;
            this.txtDataAgendamento.Name = "txtDataAgendamento";
            this.txtDataAgendamento.Size = new System.Drawing.Size(248, 50);
            this.txtDataAgendamento.TabIndex = 303;
            this.txtDataAgendamento.Text = "";
            this.txtDataAgendamento.TrailingIcon = null;
            this.txtDataAgendamento.Leave += new System.EventHandler(this.txtDataAgendamento_Leave);
            // 
            // txtPacienteAgenda
            // 
            this.txtPacienteAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteAgenda.Depth = 0;
            this.txtPacienteAgenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteAgenda.Hint = "Paciente";
            this.txtPacienteAgenda.LeadingIcon = null;
            this.txtPacienteAgenda.Location = new System.Drawing.Point(5, 6);
            this.txtPacienteAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtPacienteAgenda.MaxLength = 50;
            this.txtPacienteAgenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteAgenda.Multiline = false;
            this.txtPacienteAgenda.Name = "txtPacienteAgenda";
            this.txtPacienteAgenda.Size = new System.Drawing.Size(248, 50);
            this.txtPacienteAgenda.TabIndex = 56;
            this.txtPacienteAgenda.Text = "";
            this.txtPacienteAgenda.TrailingIcon = null;
            // 
            // calAgendamento
            // 
            this.calAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calAgendamento.BackColor = System.Drawing.SystemColors.Control;
            this.calAgendamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Saturday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Sunday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("00:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("00:00:00");
            this.calAgendamento.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5,
        calendarHighlightRange6,
        calendarHighlightRange7};
            this.calAgendamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calAgendamento.ItemsTimeFormat = "hh:mm";
            this.calAgendamento.Location = new System.Drawing.Point(3, 169);
            this.calAgendamento.MaximumFullDays = 360;
            this.calAgendamento.Name = "calAgendamento";
            this.calAgendamento.Size = new System.Drawing.Size(1223, 528);
            this.calAgendamento.TabIndex = 55;
            this.calAgendamento.Text = "Agendamento";
            this.calAgendamento.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            this.calAgendamento.ItemCreating += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calAgendamento_ItemCreating);
            this.calAgendamento.ItemCreated += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calAgendamento_ItemCreated);
            this.calAgendamento.ItemDeleted += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calAgendamento_ItemDeleted);
            this.calAgendamento.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calAgendamento_ItemDatesChanged);
            // 
            // tabAlimento
            // 
            this.tabAlimento.AllowDrop = true;
            this.tabAlimento.Controls.Add(this.tbAlimento);
            this.tabAlimento.ImageKey = "Alimento32px.png";
            this.tabAlimento.Location = new System.Drawing.Point(4, 39);
            this.tabAlimento.Name = "tabAlimento";
            this.tabAlimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlimento.Size = new System.Drawing.Size(1232, 703);
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
            this.tbAlimento.Location = new System.Drawing.Point(6, 3);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.SelectedIndex = 0;
            this.tbAlimento.Size = new System.Drawing.Size(1219, 699);
            this.tbAlimento.TabIndex = 1;
            // 
            // _tbConsulta
            // 
            this._tbConsulta.Controls.Add(this.materialCheckbox1);
            this._tbConsulta.Controls.Add(this.txtAlimentoFiltro);
            this._tbConsulta.Controls.Add(this.cbxTabela);
            this._tbConsulta.Controls.Add(this.btnCancelarEditAlimentos);
            this._tbConsulta.Controls.Add(this.btnRecalcular);
            this._tbConsulta.Controls.Add(this.btnSalvarAlimento);
            this._tbConsulta.Controls.Add(this.label7);
            this._tbConsulta.Controls.Add(this.lblTabela);
            this._tbConsulta.Controls.Add(this.dtgConAlimento);
            this._tbConsulta.Location = new System.Drawing.Point(4, 22);
            this._tbConsulta.Name = "_tbConsulta";
            this._tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this._tbConsulta.Size = new System.Drawing.Size(1211, 673);
            this._tbConsulta.TabIndex = 1;
            this._tbConsulta.Text = "Cadastro/Consulta";
            this._tbConsulta.UseVisualStyleBackColor = true;
            this._tbConsulta.Enter += new System.EventHandler(this._tbConsulta_Enter);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(1050, 87);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(155, 37);
            this.materialCheckbox1.TabIndex = 323;
            this.materialCheckbox1.Text = "Criar nova tabela";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
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
            this.txtAlimentoFiltro.TabIndex = 322;
            this.txtAlimentoFiltro.Text = "";
            this.txtAlimentoFiltro.TrailingIcon = null;
            this.txtAlimentoFiltro.Leave += new System.EventHandler(this.txtAlimentoFiltro_Leave);
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
            this.cbxTabela.TabIndex = 320;
            this.cbxTabela.SelectedIndexChanged += new System.EventHandler(this.cbxTabela_SelectedIndexChanged);
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
            this.dtgConAlimento.Size = new System.Drawing.Size(1201, 496);
            this.dtgConAlimento.TabIndex = 2;
            this.dtgConAlimento.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgConAlimento_CellBeginEdit);
            this.dtgConAlimento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConAlimento_CellEndEdit);
            this.dtgConAlimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgConAlimento_KeyDown);
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
            this.tbImportarPlanilha.Size = new System.Drawing.Size(1211, 673);
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
            this.txtNomeTabela.Location = new System.Drawing.Point(9, 617);
            this.txtNomeTabela.MaxLength = 50;
            this.txtNomeTabela.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeTabela.Multiline = false;
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(659, 50);
            this.txtNomeTabela.TabIndex = 325;
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
            this._cbxNomePlanilha.Location = new System.Drawing.Point(9, 561);
            this._cbxNomePlanilha.MaxDropDownItems = 4;
            this._cbxNomePlanilha.MouseState = MaterialSkin.MouseState.OUT;
            this._cbxNomePlanilha.Name = "_cbxNomePlanilha";
            this._cbxNomePlanilha.Size = new System.Drawing.Size(659, 49);
            this._cbxNomePlanilha.StartIndex = 0;
            this._cbxNomePlanilha.TabIndex = 324;
            this._cbxNomePlanilha.SelectedIndexChanged += new System.EventHandler(this._cbxNomePlanilha_SelectedIndexChanged_1);
            // 
            // txtCaminhoArquivoExcel
            // 
            this.txtCaminhoArquivoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCaminhoArquivoExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminhoArquivoExcel.Depth = 0;
            this.txtCaminhoArquivoExcel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaminhoArquivoExcel.Hint = "Caminho do Arquivo";
            this.txtCaminhoArquivoExcel.LeadingIcon = null;
            this.txtCaminhoArquivoExcel.Location = new System.Drawing.Point(9, 505);
            this.txtCaminhoArquivoExcel.MaxLength = 50;
            this.txtCaminhoArquivoExcel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCaminhoArquivoExcel.Multiline = false;
            this.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            this.txtCaminhoArquivoExcel.ReadOnly = true;
            this.txtCaminhoArquivoExcel.Size = new System.Drawing.Size(659, 50);
            this.txtCaminhoArquivoExcel.TabIndex = 323;
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
            this.dtgDadosImportados.Location = new System.Drawing.Point(9, 3);
            this.dtgDadosImportados.Name = "dtgDadosImportados";
            this.dtgDadosImportados.RowHeadersWidth = 51;
            this.dtgDadosImportados.Size = new System.Drawing.Size(1201, 496);
            this.dtgDadosImportados.TabIndex = 268;
            this.dtgDadosImportados.DragDrop += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragDrop);
            this.dtgDadosImportados.DragEnter += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragEnter);
            // 
            // tbCadMedCaseira
            // 
            this.tbCadMedCaseira.Controls.Add(this.mTxtFiltroAlimentoMedCas);
            this.tbCadMedCaseira.Controls.Add(this.mCbxTabelasMedCas);
            this.tbCadMedCaseira.Controls.Add(this.txtQtdMedCas);
            this.tbCadMedCaseira.Controls.Add(this.txtDescMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.txtAlimentoMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.txtCodAlimentoMedCas);
            this.tbCadMedCaseira.Controls.Add(this.dtgSalvarMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.dtgMedCaseiraAlimentos);
            this.tbCadMedCaseira.Controls.Add(this.btnAddMedCaseira);
            this.tbCadMedCaseira.Controls.Add(this.btnSalvarMedCas);
            this.tbCadMedCaseira.Location = new System.Drawing.Point(4, 22);
            this.tbCadMedCaseira.Margin = new System.Windows.Forms.Padding(2);
            this.tbCadMedCaseira.Name = "tbCadMedCaseira";
            this.tbCadMedCaseira.Padding = new System.Windows.Forms.Padding(2);
            this.tbCadMedCaseira.Size = new System.Drawing.Size(1211, 673);
            this.tbCadMedCaseira.TabIndex = 3;
            this.tbCadMedCaseira.Text = "Cadastrar Medida Caseira";
            this.tbCadMedCaseira.UseVisualStyleBackColor = true;
            this.tbCadMedCaseira.Enter += new System.EventHandler(this.tbCadMedCaseira_Enter);
            // 
            // mTxtFiltroAlimentoMedCas
            // 
            this.mTxtFiltroAlimentoMedCas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtFiltroAlimentoMedCas.Depth = 0;
            this.mTxtFiltroAlimentoMedCas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtFiltroAlimentoMedCas.Hint = "Filtro Alimento";
            this.mTxtFiltroAlimentoMedCas.LeadingIcon = null;
            this.mTxtFiltroAlimentoMedCas.Location = new System.Drawing.Point(8, 73);
            this.mTxtFiltroAlimentoMedCas.MaxLength = 50;
            this.mTxtFiltroAlimentoMedCas.MouseState = MaterialSkin.MouseState.OUT;
            this.mTxtFiltroAlimentoMedCas.Multiline = false;
            this.mTxtFiltroAlimentoMedCas.Name = "mTxtFiltroAlimentoMedCas";
            this.mTxtFiltroAlimentoMedCas.Size = new System.Drawing.Size(348, 50);
            this.mTxtFiltroAlimentoMedCas.TabIndex = 330;
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
            this.mCbxTabelasMedCas.Location = new System.Drawing.Point(7, 18);
            this.mCbxTabelasMedCas.MaxDropDownItems = 4;
            this.mCbxTabelasMedCas.MouseState = MaterialSkin.MouseState.OUT;
            this.mCbxTabelasMedCas.Name = "mCbxTabelasMedCas";
            this.mCbxTabelasMedCas.Size = new System.Drawing.Size(348, 49);
            this.mCbxTabelasMedCas.StartIndex = 0;
            this.mCbxTabelasMedCas.TabIndex = 329;
            this.mCbxTabelasMedCas.SelectedValueChanged += new System.EventHandler(this.mCbxTabelasMedCas_SelectedValueChanged);
            // 
            // txtQtdMedCas
            // 
            this.txtQtdMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdMedCas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdMedCas.Depth = 0;
            this.txtQtdMedCas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtdMedCas.Hint = "Qtd (g/ml)";
            this.txtQtdMedCas.LeadingIcon = null;
            this.txtQtdMedCas.Location = new System.Drawing.Point(897, 106);
            this.txtQtdMedCas.MaxLength = 50;
            this.txtQtdMedCas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtdMedCas.Multiline = false;
            this.txtQtdMedCas.Name = "txtQtdMedCas";
            this.txtQtdMedCas.Size = new System.Drawing.Size(309, 50);
            this.txtQtdMedCas.TabIndex = 328;
            this.txtQtdMedCas.Text = "";
            this.txtQtdMedCas.TrailingIcon = null;
            // 
            // txtDescMedCaseira
            // 
            this.txtDescMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescMedCaseira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescMedCaseira.Depth = 0;
            this.txtDescMedCaseira.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescMedCaseira.Hint = "Descrição";
            this.txtDescMedCaseira.LeadingIcon = null;
            this.txtDescMedCaseira.Location = new System.Drawing.Point(361, 106);
            this.txtDescMedCaseira.MaxLength = 50;
            this.txtDescMedCaseira.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescMedCaseira.Multiline = false;
            this.txtDescMedCaseira.Name = "txtDescMedCaseira";
            this.txtDescMedCaseira.Size = new System.Drawing.Size(511, 50);
            this.txtDescMedCaseira.TabIndex = 327;
            this.txtDescMedCaseira.Text = "";
            this.txtDescMedCaseira.TrailingIcon = null;
            // 
            // txtAlimentoMedCaseira
            // 
            this.txtAlimentoMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlimentoMedCaseira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlimentoMedCaseira.Depth = 0;
            this.txtAlimentoMedCaseira.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlimentoMedCaseira.Hint = "Alimento";
            this.txtAlimentoMedCaseira.LeadingIcon = null;
            this.txtAlimentoMedCaseira.Location = new System.Drawing.Point(361, 20);
            this.txtAlimentoMedCaseira.MaxLength = 50;
            this.txtAlimentoMedCaseira.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlimentoMedCaseira.Multiline = false;
            this.txtAlimentoMedCaseira.Name = "txtAlimentoMedCaseira";
            this.txtAlimentoMedCaseira.ReadOnly = true;
            this.txtAlimentoMedCaseira.Size = new System.Drawing.Size(659, 50);
            this.txtAlimentoMedCaseira.TabIndex = 326;
            this.txtAlimentoMedCaseira.Text = "";
            this.txtAlimentoMedCaseira.TrailingIcon = null;
            this.txtAlimentoMedCaseira.Leave += new System.EventHandler(this.txtAlimentoMedCaseira_Leave);
            // 
            // txtCodAlimentoMedCas
            // 
            this.txtCodAlimentoMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodAlimentoMedCas.Enabled = false;
            this.txtCodAlimentoMedCas.Location = new System.Drawing.Point(361, 66);
            this.txtCodAlimentoMedCas.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodAlimentoMedCas.Name = "txtCodAlimentoMedCas";
            this.txtCodAlimentoMedCas.Size = new System.Drawing.Size(175, 20);
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
            this.dtgSalvarMedCaseira.Location = new System.Drawing.Point(361, 203);
            this.dtgSalvarMedCaseira.Name = "dtgSalvarMedCaseira";
            this.dtgSalvarMedCaseira.RowHeadersWidth = 51;
            this.dtgSalvarMedCaseira.Size = new System.Drawing.Size(847, 431);
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
            // dtgMedCaseiraAlimentos
            // 
            this.dtgMedCaseiraAlimentos.AllowUserToAddRows = false;
            this.dtgMedCaseiraAlimentos.AllowUserToDeleteRows = false;
            this.dtgMedCaseiraAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgMedCaseiraAlimentos.BackgroundColor = System.Drawing.Color.White;
            this.dtgMedCaseiraAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedCaseiraAlimentos.Location = new System.Drawing.Point(7, 114);
            this.dtgMedCaseiraAlimentos.Name = "dtgMedCaseiraAlimentos";
            this.dtgMedCaseiraAlimentos.ReadOnly = true;
            this.dtgMedCaseiraAlimentos.RowHeadersWidth = 51;
            this.dtgMedCaseiraAlimentos.Size = new System.Drawing.Size(348, 520);
            this.dtgMedCaseiraAlimentos.TabIndex = 3;
            this.dtgMedCaseiraAlimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedCaseiraAlimentos_CellDoubleClick);
            // 
            // tabCardapio
            // 
            this.tabCardapio.Controls.Add(this.tbCardapio);
            this.tabCardapio.ImageKey = "Cardapio32px.png";
            this.tabCardapio.Location = new System.Drawing.Point(4, 39);
            this.tabCardapio.Name = "tabCardapio";
            this.tabCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCardapio.Size = new System.Drawing.Size(1232, 703);
            this.tabCardapio.TabIndex = 3;
            this.tabCardapio.Text = "Cardápio";
            this.tabCardapio.UseVisualStyleBackColor = true;
            this.tabCardapio.Enter += new System.EventHandler(this.tabCardapio_Enter);
            // 
            // tbCardapio
            // 
            this.tbCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardapio.Controls.Add(this.tbCadCardapio);
            this.tbCardapio.Controls.Add(this.tbConsultaCardapio);
            this.tbCardapio.Controls.Add(this.tbCadastrarTiposCardapios);
            this.tbCardapio.Location = new System.Drawing.Point(2, 6);
            this.tbCardapio.Margin = new System.Windows.Forms.Padding(2);
            this.tbCardapio.Name = "tbCardapio";
            this.tbCardapio.SelectedIndex = 0;
            this.tbCardapio.Size = new System.Drawing.Size(1225, 692);
            this.tbCardapio.TabIndex = 0;
            this.tbCardapio.Enter += new System.EventHandler(this.tbCardapio_Enter);
            // 
            // tbCadCardapio
            // 
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
            this.tbCadCardapio.Controls.Add(this.btnConfigGramasCard);
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
            this.tbCadCardapio.Size = new System.Drawing.Size(1217, 666);
            this.tbCadCardapio.TabIndex = 0;
            this.tbCadCardapio.Text = "Criar Cardápio";
            this.tbCadCardapio.UseVisualStyleBackColor = true;
            // 
            // txtLipidio
            // 
            this.txtLipidio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLipidio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLipidio.Depth = 0;
            this.txtLipidio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLipidio.Hint = "Lipídio";
            this.txtLipidio.LeadingIcon = null;
            this.txtLipidio.Location = new System.Drawing.Point(1087, 509);
            this.txtLipidio.MaxLength = 50;
            this.txtLipidio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLipidio.Multiline = false;
            this.txtLipidio.Name = "txtLipidio";
            this.txtLipidio.Size = new System.Drawing.Size(125, 50);
            this.txtLipidio.TabIndex = 326;
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
            this.txtCarboidrato.Location = new System.Drawing.Point(956, 509);
            this.txtCarboidrato.MaxLength = 50;
            this.txtCarboidrato.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCarboidrato.Multiline = false;
            this.txtCarboidrato.Name = "txtCarboidrato";
            this.txtCarboidrato.Size = new System.Drawing.Size(125, 50);
            this.txtCarboidrato.TabIndex = 325;
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
            this.txtProteina.Location = new System.Drawing.Point(825, 508);
            this.txtProteina.MaxLength = 50;
            this.txtProteina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProteina.Multiline = false;
            this.txtProteina.Name = "txtProteina";
            this.txtProteina.Size = new System.Drawing.Size(125, 50);
            this.txtProteina.TabIndex = 324;
            this.txtProteina.Text = "";
            this.txtProteina.TrailingIcon = null;
            // 
            // lblValorKcal
            // 
            this.lblValorKcal.AutoSize = true;
            this.lblValorKcal.Depth = 0;
            this.lblValorKcal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblValorKcal.Location = new System.Drawing.Point(421, 580);
            this.lblValorKcal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorKcal.Name = "lblValorKcal";
            this.lblValorKcal.Size = new System.Drawing.Size(1, 0);
            this.lblValorKcal.TabIndex = 323;
            // 
            // lblVlrKcal
            // 
            this.lblVlrKcal.AutoSize = true;
            this.lblVlrKcal.Depth = 0;
            this.lblVlrKcal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVlrKcal.Location = new System.Drawing.Point(366, 580);
            this.lblVlrKcal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVlrKcal.Name = "lblVlrKcal";
            this.lblVlrKcal.Size = new System.Drawing.Size(38, 19);
            this.lblVlrKcal.TabIndex = 322;
            this.lblVlrKcal.Text = "KCal:";
            this.lblVlrKcal.Visible = false;
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
            this.txtFiltroAlimento.TabIndex = 321;
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
            this.cbxTabelaAlimentoCardapio.Location = new System.Drawing.Point(808, 6);
            this.cbxTabelaAlimentoCardapio.MaxDropDownItems = 4;
            this.cbxTabelaAlimentoCardapio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTabelaAlimentoCardapio.Name = "cbxTabelaAlimentoCardapio";
            this.cbxTabelaAlimentoCardapio.Size = new System.Drawing.Size(261, 49);
            this.cbxTabelaAlimentoCardapio.StartIndex = 0;
            this.cbxTabelaAlimentoCardapio.TabIndex = 319;
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
            this.cbxRefeicao.Location = new System.Drawing.Point(407, 6);
            this.cbxRefeicao.MaxDropDownItems = 4;
            this.cbxRefeicao.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxRefeicao.Name = "cbxRefeicao";
            this.cbxRefeicao.Size = new System.Drawing.Size(261, 49);
            this.cbxRefeicao.StartIndex = 0;
            this.cbxRefeicao.TabIndex = 318;
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
            this.txtPaciente.TabIndex = 317;
            this.txtPaciente.Text = "";
            this.txtPaciente.TrailingIcon = null;
            // 
            // btnConfigGramasCard
            // 
            this.btnConfigGramasCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigGramasCard.AutoSize = true;
            this.btnConfigGramasCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigGramasCard.Location = new System.Drawing.Point(1097, 76);
            this.btnConfigGramasCard.Name = "btnConfigGramasCard";
            this.btnConfigGramasCard.Size = new System.Drawing.Size(115, 35);
            this.btnConfigGramasCard.TabIndex = 315;
            this.btnConfigGramasCard.Text = "Configurar";
            this.btnConfigGramasCard.UseVisualStyleBackColor = true;
            this.btnConfigGramasCard.Click += new System.EventHandler(this.btnConfigGramasCard_Click);
            // 
            // graficoMacroNutri
            // 
            this.graficoMacroNutri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graficoMacroNutri.BackColorTransparent = true;
            this.graficoMacroNutri.Location = new System.Drawing.Point(4, 509);
            this.graficoMacroNutri.Margin = new System.Windows.Forms.Padding(2);
            this.graficoMacroNutri.Name = "graficoMacroNutri";
            this.graficoMacroNutri.Size = new System.Drawing.Size(360, 150);
            this.graficoMacroNutri.TabIndex = 313;
            this.graficoMacroNutri.Text = "Gráfico MacroNutrientes";
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
            this.dtgCardapioAlimentos.Size = new System.Drawing.Size(531, 387);
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
            this.dtgRefeicoes.Location = new System.Drawing.Point(662, 117);
            this.dtgRefeicoes.Name = "dtgRefeicoes";
            this.dtgRefeicoes.RowHeadersWidth = 51;
            this.dtgRefeicoes.Size = new System.Drawing.Size(550, 387);
            this.dtgRefeicoes.TabIndex = 304;
            this.dtgRefeicoes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgRefeicoes_CellBeginEdit);
            this.dtgRefeicoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRefeicoes_CellEndEdit);
            // 
            // tbConsultaCardapio
            // 
            this.tbConsultaCardapio.Controls.Add(this.btnApagarCardapio);
            this.tbConsultaCardapio.Controls.Add(this.txtPacienteConsultaCardapio);
            this.tbConsultaCardapio.Controls.Add(this.trwDadosCard);
            this.tbConsultaCardapio.Controls.Add(this.btnApagar);
            this.tbConsultaCardapio.Controls.Add(this.btnBuscaPaciente);
            this.tbConsultaCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbConsultaCardapio.Name = "tbConsultaCardapio";
            this.tbConsultaCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultaCardapio.Size = new System.Drawing.Size(1217, 666);
            this.tbConsultaCardapio.TabIndex = 1;
            this.tbConsultaCardapio.Text = "Cardápios Salvos";
            this.tbConsultaCardapio.UseVisualStyleBackColor = true;
            this.tbConsultaCardapio.Click += new System.EventHandler(this.tbConsultaCardapio_Click);
            this.tbConsultaCardapio.Enter += new System.EventHandler(this.tbConsultaCardapio_Enter);
            // 
            // txtPacienteConsultaCardapio
            // 
            this.txtPacienteConsultaCardapio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteConsultaCardapio.Depth = 0;
            this.txtPacienteConsultaCardapio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteConsultaCardapio.Hint = "Paciente";
            this.txtPacienteConsultaCardapio.LeadingIcon = null;
            this.txtPacienteConsultaCardapio.Location = new System.Drawing.Point(6, 6);
            this.txtPacienteConsultaCardapio.MaxLength = 50;
            this.txtPacienteConsultaCardapio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteConsultaCardapio.Multiline = false;
            this.txtPacienteConsultaCardapio.Name = "txtPacienteConsultaCardapio";
            this.txtPacienteConsultaCardapio.Size = new System.Drawing.Size(347, 50);
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
            this.trwDadosCard.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.trwDadosCard.Size = new System.Drawing.Size(1208, 596);
            this.trwDadosCard.TabIndex = 0;
            // 
            // tbCadastrarTiposCardapios
            // 
            this.tbCadastrarTiposCardapios.Location = new System.Drawing.Point(4, 22);
            this.tbCadastrarTiposCardapios.Margin = new System.Windows.Forms.Padding(2);
            this.tbCadastrarTiposCardapios.Name = "tbCadastrarTiposCardapios";
            this.tbCadastrarTiposCardapios.Padding = new System.Windows.Forms.Padding(2);
            this.tbCadastrarTiposCardapios.Size = new System.Drawing.Size(1217, 666);
            this.tbCadastrarTiposCardapios.TabIndex = 2;
            this.tbCadastrarTiposCardapios.Text = "Pré Definição Cardápios";
            this.tbCadastrarTiposCardapios.UseVisualStyleBackColor = true;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Controls.Add(this.tbPaciente);
            this.tabPaciente.ImageKey = "Paciente32px.png";
            this.tabPaciente.Location = new System.Drawing.Point(4, 39);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaciente.Size = new System.Drawing.Size(1232, 703);
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
            this.tbPaciente.Location = new System.Drawing.Point(6, 3);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.SelectedIndex = 0;
            this.tbPaciente.Size = new System.Drawing.Size(1220, 694);
            this.tbPaciente.TabIndex = 1;
            this.tbPaciente.Enter += new System.EventHandler(this.tbPaciente_Enter);
            // 
            // tbCadastro
            // 
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
            this.tbCadastro.Controls.Add(this.txtDtNasc);
            this.tbCadastro.Controls.Add(this._dtgConsultaPacientes);
            this.tbCadastro.Controls.Add(this._btnExcluir);
            this.tbCadastro.Controls.Add(this._btnSalvar);
            this.tbCadastro.Controls.Add(this.lblDataNascimento);
            this.tbCadastro.Controls.Add(this.pbImagem);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(1212, 668);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            this.tbCadastro.Enter += new System.EventHandler(this.tbCadastro_Enter);
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
            this.txtCelular.TabIndex = 284;
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
            this.txtTelefone.TabIndex = 283;
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
            this.txtComplemento.Size = new System.Drawing.Size(1110, 50);
            this.txtComplemento.TabIndex = 282;
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
            this.txtUF.Location = new System.Drawing.Point(868, 233);
            this.txtUF.MaxLength = 50;
            this.txtUF.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUF.Multiline = false;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(102, 50);
            this.txtUF.TabIndex = 281;
            this.txtUF.Text = "";
            this.txtUF.TrailingIcon = null;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMunicipio.Depth = 0;
            this.txtMunicipio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMunicipio.Hint = "Município";
            this.txtMunicipio.LeadingIcon = null;
            this.txtMunicipio.Location = new System.Drawing.Point(528, 233);
            this.txtMunicipio.MaxLength = 50;
            this.txtMunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMunicipio.Multiline = false;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(272, 50);
            this.txtMunicipio.TabIndex = 280;
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
            this.txtBairro.Location = new System.Drawing.Point(188, 233);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(272, 50);
            this.txtBairro.TabIndex = 279;
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
            this.txtNumero.TabIndex = 278;
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
            this.txtEndereco.Location = new System.Drawing.Point(531, 131);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEndereco.Multiline = false;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(597, 50);
            this.txtEndereco.TabIndex = 277;
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
            this.txtCEP.Location = new System.Drawing.Point(204, 131);
            this.txtCEP.MaxLength = 50;
            this.txtCEP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCEP.Multiline = false;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(259, 50);
            this.txtCEP.TabIndex = 276;
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
            this.txtEmail.Location = new System.Drawing.Point(853, 27);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 50);
            this.txtEmail.TabIndex = 275;
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
            this.txtCPF.Location = new System.Drawing.Point(619, 27);
            this.txtCPF.MaxLength = 50;
            this.txtCPF.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(166, 50);
            this.txtCPF.TabIndex = 274;
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
            this.txtNome.Location = new System.Drawing.Point(204, 27);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 50);
            this.txtNome.TabIndex = 273;
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
            // txtDtNasc
            // 
            this.txtDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtNasc.Location = new System.Drawing.Point(394, 82);
            this.txtDtNasc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(158, 20);
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
            this._dtgConsultaPacientes.Location = new System.Drawing.Point(6, 473);
            this._dtgConsultaPacientes.Name = "_dtgConsultaPacientes";
            this._dtgConsultaPacientes.ReadOnly = true;
            this._dtgConsultaPacientes.RowHeadersWidth = 51;
            this._dtgConsultaPacientes.Size = new System.Drawing.Size(1202, 190);
            this._dtgConsultaPacientes.TabIndex = 266;
            this._dtgConsultaPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtgConsultaPacientes_CellDoubleClick);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(203, 88);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.lblDataNascimento.TabIndex = 246;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // tbAntropometricos
            // 
            this.tbAntropometricos.Controls.Add(this.gbxCircunferencias);
            this.tbAntropometricos.Controls.Add(this.gbxEstatura);
            this.tbAntropometricos.Controls.Add(this.txtPacienteAntro);
            this.tbAntropometricos.Controls.Add(this.button1);
            this.tbAntropometricos.Controls.Add(this.btnPacAnt);
            this.tbAntropometricos.Location = new System.Drawing.Point(4, 22);
            this.tbAntropometricos.Name = "tbAntropometricos";
            this.tbAntropometricos.Padding = new System.Windows.Forms.Padding(3);
            this.tbAntropometricos.Size = new System.Drawing.Size(1212, 668);
            this.tbAntropometricos.TabIndex = 2;
            this.tbAntropometricos.Text = "Antropometria";
            this.tbAntropometricos.UseVisualStyleBackColor = true;
            // 
            // gbxCircunferencias
            // 
            this.gbxCircunferencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCircunferencias.Controls.Add(this.btnSalvarAntro);
            this.gbxCircunferencias.Controls.Add(this.txtTorax);
            this.gbxCircunferencias.Controls.Add(this.txtPunho);
            this.gbxCircunferencias.Controls.Add(this.txtCoxa);
            this.gbxCircunferencias.Controls.Add(this.txtPanturrilha);
            this.gbxCircunferencias.Controls.Add(this.txtQuadril);
            this.gbxCircunferencias.Controls.Add(this.txtAntebraco);
            this.gbxCircunferencias.Controls.Add(this.txtCintura);
            this.gbxCircunferencias.Controls.Add(this.txtBraco);
            this.gbxCircunferencias.Location = new System.Drawing.Point(406, 65);
            this.gbxCircunferencias.Name = "gbxCircunferencias";
            this.gbxCircunferencias.Size = new System.Drawing.Size(800, 597);
            this.gbxCircunferencias.TabIndex = 324;
            this.gbxCircunferencias.TabStop = false;
            this.gbxCircunferencias.Text = "Circunferências";
            // 
            // txtTorax
            // 
            this.txtTorax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTorax.Depth = 0;
            this.txtTorax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTorax.Hint = "Tórax (cm)";
            this.txtTorax.LeadingIcon = null;
            this.txtTorax.Location = new System.Drawing.Point(461, 227);
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
            this.txtPunho.Location = new System.Drawing.Point(461, 128);
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
            this.txtCoxa.Location = new System.Drawing.Point(461, 425);
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
            this.txtPanturrilha.Location = new System.Drawing.Point(461, 326);
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
            this.txtQuadril.Location = new System.Drawing.Point(80, 326);
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
            this.txtAntebraco.Location = new System.Drawing.Point(80, 425);
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
            this.txtCintura.Location = new System.Drawing.Point(80, 227);
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
            this.txtBraco.Location = new System.Drawing.Point(80, 128);
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
            this.gbxEstatura.Controls.Add(this.txtPeso);
            this.gbxEstatura.Controls.Add(this.lblIMC);
            this.gbxEstatura.Controls.Add(this.txtAltura);
            this.gbxEstatura.Location = new System.Drawing.Point(16, 65);
            this.gbxEstatura.Name = "gbxEstatura";
            this.gbxEstatura.Size = new System.Drawing.Size(370, 597);
            this.gbxEstatura.TabIndex = 323;
            this.gbxEstatura.TabStop = false;
            this.gbxEstatura.Text = "Estatura";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Depth = 0;
            this.txtPeso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPeso.Hint = "Peso (kg)";
            this.txtPeso.LeadingIcon = null;
            this.txtPeso.Location = new System.Drawing.Point(54, 128);
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
            this.lblIMC.Location = new System.Drawing.Point(54, 328);
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
            this.txtAltura.Hint = "Altura (cm)";
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(54, 227);
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
            this.txtPacienteAntro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteAntro.Hint = "Paciente";
            this.txtPacienteAntro.LeadingIcon = null;
            this.txtPacienteAntro.Location = new System.Drawing.Point(6, 6);
            this.txtPacienteAntro.MaxLength = 50;
            this.txtPacienteAntro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteAntro.Multiline = false;
            this.txtPacienteAntro.Name = "txtPacienteAntro";
            this.txtPacienteAntro.Size = new System.Drawing.Size(347, 50);
            this.txtPacienteAntro.TabIndex = 0;
            this.txtPacienteAntro.Text = "";
            this.txtPacienteAntro.TrailingIcon = null;
            // 
            // tbAnamnese
            // 
            this.tbAnamnese.Controls.Add(this.txtPacienteAnamnese);
            this.tbAnamnese.Controls.Add(this.rtxtAnamnese);
            this.tbAnamnese.Controls.Add(this.btnFindPacienteAnamnese);
            this.tbAnamnese.Controls.Add(this.btnSalvarAnamnese);
            this.tbAnamnese.Location = new System.Drawing.Point(4, 22);
            this.tbAnamnese.Margin = new System.Windows.Forms.Padding(2);
            this.tbAnamnese.Name = "tbAnamnese";
            this.tbAnamnese.Padding = new System.Windows.Forms.Padding(2);
            this.tbAnamnese.Size = new System.Drawing.Size(1212, 668);
            this.tbAnamnese.TabIndex = 3;
            this.tbAnamnese.Text = "Anamnese";
            this.tbAnamnese.UseVisualStyleBackColor = true;
            // 
            // txtPacienteAnamnese
            // 
            this.txtPacienteAnamnese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPacienteAnamnese.Depth = 0;
            this.txtPacienteAnamnese.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPacienteAnamnese.Hint = "Paciente";
            this.txtPacienteAnamnese.LeadingIcon = null;
            this.txtPacienteAnamnese.Location = new System.Drawing.Point(5, 5);
            this.txtPacienteAnamnese.MaxLength = 50;
            this.txtPacienteAnamnese.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPacienteAnamnese.Multiline = false;
            this.txtPacienteAnamnese.Name = "txtPacienteAnamnese";
            this.txtPacienteAnamnese.Size = new System.Drawing.Size(347, 50);
            this.txtPacienteAnamnese.TabIndex = 319;
            this.txtPacienteAnamnese.Text = "";
            this.txtPacienteAnamnese.TrailingIcon = null;
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
            this.rtxtAnamnese.RichTextBox.Size = new System.Drawing.Size(1202, 534);
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
            this.rtxtAnamnese.Size = new System.Drawing.Size(1202, 560);
            this.rtxtAnamnese.StampAction = MvtWindowsForms.StampActions.EditedBy;
            this.rtxtAnamnese.StampColor = System.Drawing.Color.Blue;
            this.rtxtAnamnese.TabIndex = 0;
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
            this.rtxtAnamnese.Toolbar.Size = new System.Drawing.Size(1202, 26);
            this.rtxtAnamnese.Toolbar.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tbConfig);
            this.tabConfig.ImageKey = "settings32px.png";
            this.tabConfig.Location = new System.Drawing.Point(4, 39);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1232, 703);
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
            this.tbConfig.Controls.Add(this.tabHorarioAtendimento);
            this.tbConfig.Location = new System.Drawing.Point(3, 6);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.SelectedIndex = 0;
            this.tbConfig.Size = new System.Drawing.Size(1223, 691);
            this.tbConfig.TabIndex = 1;
            this.tbConfig.Enter += new System.EventHandler(this.tbConfig_Enter);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.txtCRN);
            this.TabPage1.Controls.Add(this.txtEmailConfig);
            this.TabPage1.Controls.Add(this.cbxTipoUsuario);
            this.TabPage1.Controls.Add(this.cbxSituacao);
            this.TabPage1.Controls.Add(this.txtConfirmarSenha);
            this.TabPage1.Controls.Add(this.txtSenha);
            this.TabPage1.Controls.Add(this.txtNomeUsuarioConfig);
            this.TabPage1.Controls.Add(this.txtUsuarioConfig);
            this.TabPage1.Controls.Add(this.btnExcluirConfigUsuario);
            this.TabPage1.Controls.Add(this.btnSalvarConfigUsuario);
            this.TabPage1.Controls.Add(this.dtgUsuarios);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1215, 665);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Usuários";
            this.TabPage1.UseVisualStyleBackColor = true;
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
            this.txtCRN.TabIndex = 10;
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
            "Estudante"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(667, 83);
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
            this.cbxSituacao.Location = new System.Drawing.Point(848, 5);
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
            this.dtgUsuarios.Size = new System.Drawing.Size(1202, 436);
            this.dtgUsuarios.TabIndex = 8;
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            this.dtgUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgUsuarios_KeyDown);
            // 
            // tbPermissao
            // 
            this.tbPermissao.Controls.Add(this.cbxTelaLiberarPerm);
            this.tbPermissao.Controls.Add(this.cbxUsuarioPerm);
            this.tbPermissao.Controls.Add(this.dtgPermUsuarios);
            this.tbPermissao.Controls.Add(this.btnSalvarPermissao);
            this.tbPermissao.Location = new System.Drawing.Point(4, 22);
            this.tbPermissao.Name = "tbPermissao";
            this.tbPermissao.Padding = new System.Windows.Forms.Padding(3);
            this.tbPermissao.Size = new System.Drawing.Size(1215, 665);
            this.tbPermissao.TabIndex = 1;
            this.tbPermissao.Text = "Permissões";
            this.tbPermissao.UseVisualStyleBackColor = true;
            this.tbPermissao.Enter += new System.EventHandler(this.tbPermissao_Enter);
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
            this.cbxTelaLiberarPerm.TabIndex = 17;
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
            this.cbxUsuarioPerm.TabIndex = 16;
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
            this.dtgPermUsuarios.Size = new System.Drawing.Size(1202, 488);
            this.dtgPermUsuarios.TabIndex = 14;
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
            this.tabHorarioAtendimento.Size = new System.Drawing.Size(1215, 665);
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
            this.dtgConfigHorario.Size = new System.Drawing.Size(1203, 432);
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
            this.txtHoraFim.MaxLength = 50;
            this.txtHoraFim.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoraFim.Multiline = false;
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Size = new System.Drawing.Size(280, 50);
            this.txtHoraFim.TabIndex = 3;
            this.txtHoraFim.Text = "";
            this.txtHoraFim.TrailingIcon = null;
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
            this.txtHoraInicio.MaxLength = 50;
            this.txtHoraInicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoraInicio.Multiline = false;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(280, 50);
            this.txtHoraInicio.TabIndex = 2;
            this.txtHoraInicio.Text = "";
            this.txtHoraInicio.TrailingIcon = null;
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
            // tbSobre
            // 
            this.tbSobre.Controls.Add(this.materialLabel4);
            this.tbSobre.Controls.Add(this.materialLabel3);
            this.tbSobre.Controls.Add(this.materialLabel2);
            this.tbSobre.Controls.Add(this.materialLabel1);
            this.tbSobre.ImageKey = "information.png";
            this.tbSobre.Location = new System.Drawing.Point(4, 39);
            this.tbSobre.Name = "tbSobre";
            this.tbSobre.Padding = new System.Windows.Forms.Padding(3);
            this.tbSobre.Size = new System.Drawing.Size(1232, 703);
            this.tbSobre.TabIndex = 7;
            this.tbSobre.Text = "Sobre";
            this.tbSobre.UseVisualStyleBackColor = true;
            this.tbSobre.Enter += new System.EventHandler(this.tbSobre_Enter);
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
            // NutreasyIconNotify
            // 
            this.NutreasyIconNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("NutreasyIconNotify.Icon")));
            this.NutreasyIconNotify.Text = "Nutreasy";
            this.NutreasyIconNotify.Visible = true;
            // 
            // pbxLogoGrande
            // 
            this.pbxLogoGrande.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoGrande.Image = global::TCC2.Properties.Resources.iconTCC_removebg_preview__1____Copia;
            this.pbxLogoGrande.Location = new System.Drawing.Point(256, 143);
            this.pbxLogoGrande.Name = "pbxLogoGrande";
            this.pbxLogoGrande.Size = new System.Drawing.Size(632, 466);
            this.pbxLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoGrande.TabIndex = 6;
            this.pbxLogoGrande.TabStop = false;
            // 
            // btnSalvarAgenda
            // 
            this.btnSalvarAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAgenda.AutoSize = true;
            this.btnSalvarAgenda.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAgenda.Location = new System.Drawing.Point(1111, 128);
            this.btnSalvarAgenda.Name = "btnSalvarAgenda";
            this.btnSalvarAgenda.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAgenda.TabIndex = 305;
            this.btnSalvarAgenda.Text = "Salvar";
            this.btnSalvarAgenda.UseVisualStyleBackColor = true;
            this.btnSalvarAgenda.Click += new System.EventHandler(this.btnSalvarAgenda_Click);
            // 
            // btnBuscarPacienteAgendamento
            // 
            this.btnBuscarPacienteAgendamento.Image = global::TCC2.Properties.Resources.consultar;
            this.btnBuscarPacienteAgendamento.Location = new System.Drawing.Point(259, 15);
            this.btnBuscarPacienteAgendamento.Name = "btnBuscarPacienteAgendamento";
            this.btnBuscarPacienteAgendamento.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarPacienteAgendamento.TabIndex = 302;
            this.btnBuscarPacienteAgendamento.UseVisualStyleBackColor = true;
            this.btnBuscarPacienteAgendamento.Click += new System.EventHandler(this.btnBuscarPacienteAgendamento_Click);
            // 
            // btnCancelarEditAlimentos
            // 
            this.btnCancelarEditAlimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEditAlimentos.AutoSize = true;
            this.btnCancelarEditAlimentos.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelarEditAlimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEditAlimentos.Location = new System.Drawing.Point(1090, 630);
            this.btnCancelarEditAlimentos.Name = "btnCancelarEditAlimentos";
            this.btnCancelarEditAlimentos.Size = new System.Drawing.Size(115, 35);
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
            this.btnRecalcular.Location = new System.Drawing.Point(6, 627);
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
            this.btnSalvarAlimento.Location = new System.Drawing.Point(969, 630);
            this.btnSalvarAlimento.Name = "btnSalvarAlimento";
            this.btnSalvarAlimento.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAlimento.TabIndex = 4;
            this.btnSalvarAlimento.Text = "Salvar";
            this.btnSalvarAlimento.UseVisualStyleBackColor = true;
            this.btnSalvarAlimento.Click += new System.EventHandler(this.btnSalvarAlimento_Click);
            // 
            // _btnImportar
            // 
            this._btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportar.AutoSize = true;
            this._btnImportar.Image = global::TCC2.Properties.Resources.database_import_icon_135719;
            this._btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnImportar.Location = new System.Drawing.Point(1090, 627);
            this._btnImportar.Name = "_btnImportar";
            this._btnImportar.Size = new System.Drawing.Size(115, 38);
            this._btnImportar.TabIndex = 269;
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
            this._btnBuscarPlanilha.TabIndex = 266;
            this._btnBuscarPlanilha.UseVisualStyleBackColor = true;
            this._btnBuscarPlanilha.Click += new System.EventHandler(this._btnBuscarPlanilha_Click);
            // 
            // btnAddMedCaseira
            // 
            this.btnAddMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMedCaseira.Image = global::TCC2.Properties.Resources.Adicionar;
            this.btnAddMedCaseira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedCaseira.Location = new System.Drawing.Point(1107, 167);
            this.btnAddMedCaseira.Name = "btnAddMedCaseira";
            this.btnAddMedCaseira.Size = new System.Drawing.Size(101, 30);
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
            this.btnSalvarMedCas.Location = new System.Drawing.Point(1119, 640);
            this.btnSalvarMedCas.Name = "btnSalvarMedCas";
            this.btnSalvarMedCas.Size = new System.Drawing.Size(89, 30);
            this.btnSalvarMedCas.TabIndex = 11;
            this.btnSalvarMedCas.Text = "Salvar";
            this.btnSalvarMedCas.UseVisualStyleBackColor = true;
            this.btnSalvarMedCas.Click += new System.EventHandler(this.btnSalvarMedCas_Click);
            // 
            // btnCancelarCardapio
            // 
            this.btnCancelarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCardapio.AutoSize = true;
            this.btnCancelarCardapio.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnCancelarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCardapio.Location = new System.Drawing.Point(1097, 626);
            this.btnCancelarCardapio.Name = "btnCancelarCardapio";
            this.btnCancelarCardapio.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarCardapio.TabIndex = 316;
            this.btnCancelarCardapio.Text = "Cancelar";
            this.btnCancelarCardapio.UseVisualStyleBackColor = true;
            this.btnCancelarCardapio.Click += new System.EventHandler(this.btnCancelarCardapio_Click);
            // 
            // btnAddAliCard
            // 
            this.btnAddAliCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAliCard.Image = global::TCC2.Properties.Resources.arrow_icon_1___Copia;
            this.btnAddAliCard.Location = new System.Drawing.Point(571, 271);
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
            this.btnPacienteCardapio.TabIndex = 301;
            this.btnPacienteCardapio.UseVisualStyleBackColor = true;
            this.btnPacienteCardapio.Click += new System.EventHandler(this.btnPacienteCardapio_Click);
            // 
            // btnSalvarCardapio
            // 
            this.btnSalvarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCardapio.AutoSize = true;
            this.btnSalvarCardapio.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCardapio.Location = new System.Drawing.Point(976, 626);
            this.btnSalvarCardapio.Name = "btnSalvarCardapio";
            this.btnSalvarCardapio.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarCardapio.TabIndex = 303;
            this.btnSalvarCardapio.Text = "Salvar";
            this.btnSalvarCardapio.UseVisualStyleBackColor = true;
            this.btnSalvarCardapio.Click += new System.EventHandler(this.btnSalvarCardapio_Click);
            // 
            // btnApagarCardapio
            // 
            this.btnApagarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagarCardapio.AutoSize = true;
            this.btnApagarCardapio.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnApagarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarCardapio.Location = new System.Drawing.Point(1096, 21);
            this.btnApagarCardapio.Name = "btnApagarCardapio";
            this.btnApagarCardapio.Size = new System.Drawing.Size(115, 35);
            this.btnApagarCardapio.TabIndex = 319;
            this.btnApagarCardapio.Text = "Apagar Cardápio";
            this.btnApagarCardapio.UseVisualStyleBackColor = true;
            this.btnApagarCardapio.Click += new System.EventHandler(this.btnApagarCardapio_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnApagar.Location = new System.Drawing.Point(406, 21);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(30, 23);
            this.btnApagar.TabIndex = 306;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Image = global::TCC2.Properties.Resources.consultar;
            this.btnBuscaPaciente.Location = new System.Drawing.Point(370, 21);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(30, 23);
            this.btnBuscaPaciente.TabIndex = 304;
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // _btnExcluir
            // 
            this._btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnExcluir.AutoSize = true;
            this._btnExcluir.Image = global::TCC2.Properties.Resources.DeleteRed;
            this._btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcluir.Location = new System.Drawing.Point(1091, 413);
            this._btnExcluir.Name = "_btnExcluir";
            this._btnExcluir.Size = new System.Drawing.Size(115, 35);
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
            this._btnSalvar.Location = new System.Drawing.Point(970, 413);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(115, 35);
            this._btnSalvar.TabIndex = 241;
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
            // btnSalvarAntro
            // 
            this.btnSalvarAntro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalvarAntro.AutoSize = true;
            this.btnSalvarAntro.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAntro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAntro.Location = new System.Drawing.Point(679, 556);
            this.btnSalvarAntro.Name = "btnSalvarAntro";
            this.btnSalvarAntro.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAntro.TabIndex = 242;
            this.btnSalvarAntro.Text = "Salvar";
            this.btnSalvarAntro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.button1.Location = new System.Drawing.Point(406, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 320;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPacAnt
            // 
            this.btnPacAnt.Image = global::TCC2.Properties.Resources.consultar;
            this.btnPacAnt.Location = new System.Drawing.Point(370, 21);
            this.btnPacAnt.Name = "btnPacAnt";
            this.btnPacAnt.Size = new System.Drawing.Size(30, 23);
            this.btnPacAnt.TabIndex = 319;
            this.btnPacAnt.UseVisualStyleBackColor = true;
            this.btnPacAnt.Click += new System.EventHandler(this.btnPacAnt_Click);
            // 
            // btnFindPacienteAnamnese
            // 
            this.btnFindPacienteAnamnese.Image = global::TCC2.Properties.Resources.consultar;
            this.btnFindPacienteAnamnese.Location = new System.Drawing.Point(366, 17);
            this.btnFindPacienteAnamnese.Name = "btnFindPacienteAnamnese";
            this.btnFindPacienteAnamnese.Size = new System.Drawing.Size(30, 23);
            this.btnFindPacienteAnamnese.TabIndex = 318;
            this.btnFindPacienteAnamnese.UseVisualStyleBackColor = true;
            this.btnFindPacienteAnamnese.Click += new System.EventHandler(this.btnFindPacienteAnamnese_Click);
            // 
            // btnSalvarAnamnese
            // 
            this.btnSalvarAnamnese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAnamnese.AutoSize = true;
            this.btnSalvarAnamnese.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAnamnese.Location = new System.Drawing.Point(1092, 627);
            this.btnSalvarAnamnese.Name = "btnSalvarAnamnese";
            this.btnSalvarAnamnese.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAnamnese.TabIndex = 304;
            this.btnSalvarAnamnese.Text = "Salvar";
            this.btnSalvarAnamnese.UseVisualStyleBackColor = true;
            this.btnSalvarAnamnese.Click += new System.EventHandler(this.btnSalvarAnamnese_Click);
            // 
            // btnExcluirConfigUsuario
            // 
            this.btnExcluirConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirConfigUsuario.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnExcluirConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirConfigUsuario.Location = new System.Drawing.Point(1092, 178);
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
            this.btnSalvarConfigUsuario.Location = new System.Drawing.Point(971, 178);
            this.btnSalvarConfigUsuario.Name = "btnSalvarConfigUsuario";
            this.btnSalvarConfigUsuario.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarConfigUsuario.TabIndex = 7;
            this.btnSalvarConfigUsuario.Text = "Salvar";
            this.btnSalvarConfigUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarConfigUsuario.Click += new System.EventHandler(this.btnSalvarConfigUsuario_Click);
            // 
            // btnSalvarPermissao
            // 
            this.btnSalvarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPermissao.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarPermissao.Location = new System.Drawing.Point(1095, 132);
            this.btnSalvarPermissao.Name = "btnSalvarPermissao";
            this.btnSalvarPermissao.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarPermissao.TabIndex = 12;
            this.btnSalvarPermissao.Text = "Salvar";
            this.btnSalvarPermissao.UseVisualStyleBackColor = true;
            this.btnSalvarPermissao.Click += new System.EventHandler(this.btnSalvarPermissao_Click);
            // 
            // btnSalvarHoraAtend
            // 
            this.btnSalvarHoraAtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarHoraAtend.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarHoraAtend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarHoraAtend.Location = new System.Drawing.Point(1093, 187);
            this.btnSalvarHoraAtend.Name = "btnSalvarHoraAtend";
            this.btnSalvarHoraAtend.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarHoraAtend.TabIndex = 4;
            this.btnSalvarHoraAtend.Text = "Salvar";
            this.btnSalvarHoraAtend.UseVisualStyleBackColor = true;
            this.btnSalvarHoraAtend.Click += new System.EventHandler(this.btnSalvarHoraAtend_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 813);
            this.Controls.Add(this.TabControlNutreasy);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlNutreasy;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutreasy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.TabControlNutreasy.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.mCardAtendimentoAtual.ResumeLayout(false);
            this.mCardAtendimentoAtual.PerformLayout();
            this.mCardAtendimentoFuturo.ResumeLayout(false);
            this.mCardAtendimentoFuturo.PerformLayout();
            this.tabAgenda.ResumeLayout(false);
            this.tabAgenda.PerformLayout();
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
            this.tbCardapio.ResumeLayout(false);
            this.tbCadCardapio.ResumeLayout(false);
            this.tbCadCardapio.PerformLayout();
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
            this.tbAntropometricos.ResumeLayout(false);
            this.gbxCircunferencias.ResumeLayout(false);
            this.gbxCircunferencias.PerformLayout();
            this.gbxEstatura.ResumeLayout(false);
            this.gbxEstatura.PerformLayout();
            this.tbAnamnese.ResumeLayout(false);
            this.tbAnamnese.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tbConfig.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.tbPermissao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermUsuarios)).EndInit();
            this.tabHorarioAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfigHorario)).EndInit();
            this.tbSobre.ResumeLayout(false);
            this.tbSobre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAliCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlNutreasy;
        private System.Windows.Forms.TabPage tabMenu;
        internal System.Windows.Forms.PictureBox pbxLogoGrande;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.TabPage tabAlimento;
        internal System.Windows.Forms.TabControl tbAlimento;
        private System.Windows.Forms.TabPage _tbConsulta;
        internal System.Windows.Forms.Button btnRecalcular;
        internal System.Windows.Forms.Button btnSalvarAlimento;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lblTabela;
        internal System.Windows.Forms.DataGridView dtgConAlimento;
        internal System.Windows.Forms.TabPage tbImportarPlanilha;
        private System.Windows.Forms.Button _btnImportar;
        internal System.Windows.Forms.DataGridView dtgDadosImportados;
        private System.Windows.Forms.Button _btnBuscarPlanilha;
        private System.Windows.Forms.TabPage tabPaciente;
        internal System.Windows.Forms.TabControl tbPaciente;
        internal System.Windows.Forms.TabPage tbCadastro;
        public System.Windows.Forms.Button _btnExcluir;
        public System.Windows.Forms.Button _btnSalvar;
        internal System.Windows.Forms.Label lblDataNascimento;
        internal System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.TabPage tbAntropometricos;
        private System.Windows.Forms.TabPage tabConfig;
        internal System.Windows.Forms.TabControl tbConfig;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button btnExcluirConfigUsuario;
        internal System.Windows.Forms.Button btnSalvarConfigUsuario;
        internal System.Windows.Forms.DataGridView dtgUsuarios;
        internal System.Windows.Forms.TabPage tbPermissao;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.DataGridView _dtgConsultaPacientes;
        private System.Windows.Forms.DateTimePicker txtDtNasc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tbAnamnese;
        private System.Windows.Forms.TabPage tbCadMedCaseira;
        internal System.Windows.Forms.DataGridView dtgSalvarMedCaseira;
        internal System.Windows.Forms.DataGridView dtgMedCaseiraAlimentos;
        internal System.Windows.Forms.Button btnSalvarMedCas;
        internal System.Windows.Forms.Button btnAddMedCaseira;
        private System.Windows.Forms.TextBox txtCodAlimentoMedCas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvo;
        private System.Windows.Forms.TabPage tabCardapio;
        private System.Windows.Forms.TabControl tbCardapio;
        private System.Windows.Forms.TabPage tbCadCardapio;
        private LiveCharts.WinForms.PieChart graficoMacroNutri;
        private System.Windows.Forms.PictureBox btnAddAliCard;
        private System.Windows.Forms.Button btnPacienteCardapio;
        internal System.Windows.Forms.DataGridView dtgCardapioAlimentos;
        internal System.Windows.Forms.DataGridView dtgRefeicoes;
        internal System.Windows.Forms.Button btnSalvarCardapio;
        internal System.Windows.Forms.Button btnConfigGramasCard;
        private System.Windows.Forms.TabPage tbConsultaCardapio;
        private System.Windows.Forms.Button btnBuscaPaciente;
        private System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnCancelarCardapio;
        private System.Windows.Forms.TabPage tbSobre;
        private System.Windows.Forms.Button btnCapturarImagem;
        internal System.Windows.Forms.Label txtCodPaciente;
        private System.Windows.Forms.TabPage tbCadastrarTiposCardapios;
        private MaterialSkin.Controls.MaterialCard mCardAtendimentoAtual;
        private MaterialSkin.Controls.MaterialLabel mlblObservação;
        private MaterialSkin.Controls.MaterialLabel mlblHorario;
        private MaterialSkin.Controls.MaterialLabel mlblNome;
        private MaterialSkin.Controls.MaterialCheckbox mcbxCancelar;
        private MaterialSkin.Controls.MaterialCheckbox mcbxAtendido;
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
        private MaterialSkin.Controls.MaterialComboBox cbxTabela;
        public MaterialSkin.Controls.MaterialTextBox txtAlimentoFiltro;
        public MaterialSkin.Controls.MaterialTextBox txtUsuarioConfig;
        public MaterialSkin.Controls.MaterialTextBox txtEmailConfig;
        private MaterialSkin.Controls.MaterialComboBox cbxTipoUsuario;
        private MaterialSkin.Controls.MaterialComboBox cbxSituacao;
        public MaterialSkin.Controls.MaterialTextBox txtConfirmarSenha;
        public MaterialSkin.Controls.MaterialTextBox txtSenha;
        public MaterialSkin.Controls.MaterialTextBox txtNomeUsuarioConfig;
        private MaterialSkin.Controls.MaterialComboBox cbxTelaLiberarPerm;
        private MaterialSkin.Controls.MaterialComboBox cbxUsuarioPerm;
        public MaterialSkin.Controls.MaterialTextBox txtCaminhoArquivoExcel;
        private MaterialSkin.Controls.MaterialComboBox _cbxNomePlanilha;
        public MaterialSkin.Controls.MaterialTextBox txtNomeTabela;
        private System.Windows.Forms.Calendar.Calendar calAgendamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        public MaterialSkin.Controls.MaterialTextBox txtCRN;
        internal System.Windows.Forms.Button btnSalvarAnamnese;
        public MaterialSkin.Controls.MaterialTextBox txtAlimentoMedCaseira;
        public MaterialSkin.Controls.MaterialTextBox txtQtdMedCas;
        public MaterialSkin.Controls.MaterialTextBox txtDescMedCaseira;
        public MaterialSkin.Controls.MaterialTextBox txtPacienteAnamnese;
        private System.Windows.Forms.Button btnFindPacienteAnamnese;
        private MaterialSkin.Controls.MaterialComboBox mCbxTabelasMedCas;
        public MaterialSkin.Controls.MaterialTextBox mTxtFiltroAlimentoMedCas;
        private System.Windows.Forms.TabPage tabHorarioAtendimento;
        private MaterialSkin.Controls.MaterialComboBox cbxUsuNutri;
        public MaterialSkin.Controls.MaterialTextBox txtHoraFim;
        private MaterialSkin.Controls.MaterialComboBox cbxDiaSemana;
        public MaterialSkin.Controls.MaterialTextBox txtHoraInicio;
        private MaterialSkin.Controls.MaterialTextBox txtPacienteAgenda;
        private System.Windows.Forms.Button btnBuscarPacienteAgendamento;
        private MaterialSkin.Controls.MaterialTextBox txtHoraAgenda;
        private MaterialSkin.Controls.MaterialTextBox txtDataAgendamento;
        internal System.Windows.Forms.Button btnSalvarAgenda;
        private System.Windows.Forms.Calendar.MonthView CalendarioMes;
        public System.Windows.Forms.Button btnApagarCardapio;
        private System.Windows.Forms.NotifyIcon NutreasyIconNotify;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPacAnt;
        public MaterialSkin.Controls.MaterialTextBox txtLipidio;
        public MaterialSkin.Controls.MaterialTextBox txtCarboidrato;
        public MaterialSkin.Controls.MaterialTextBox txtProteina;
    }
}

