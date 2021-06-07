
using AdvancedDataGridView;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnamnese = new System.Windows.Forms.TabPage();
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
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabConfig.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.TabPage2.SuspendLayout();
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
            this.TabControlNutreasy.Location = new System.Drawing.Point(3, 3);
            this.TabControlNutreasy.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlNutreasy.Multiline = true;
            this.TabControlNutreasy.Name = "TabControlNutreasy";
            this.TabControlNutreasy.SelectedIndex = 0;
            this.TabControlNutreasy.Size = new System.Drawing.Size(1237, 807);
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
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMenu.Size = new System.Drawing.Size(1229, 764);
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
            this.mCardAtendimentoAtual.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.mCardAtendimentoAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoAtual.Name = "mCardAtendimentoAtual";
            this.mCardAtendimentoAtual.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.mCardAtendimentoAtual.Size = new System.Drawing.Size(337, 266);
            this.mCardAtendimentoAtual.TabIndex = 10;
            this.mCardAtendimentoAtual.Visible = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
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
            this.mCardAtendimentoFuturo.Location = new System.Drawing.Point(883, 36);
            this.mCardAtendimentoFuturo.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.mCardAtendimentoFuturo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardAtendimentoFuturo.Name = "mCardAtendimentoFuturo";
            this.mCardAtendimentoFuturo.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.mCardAtendimentoFuturo.Size = new System.Drawing.Size(337, 266);
            this.mCardAtendimentoFuturo.TabIndex = 18;
            this.mCardAtendimentoFuturo.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
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
            this.mlblNomeFuturo.Size = new System.Drawing.Size(73, 19);
            this.mlblNomeFuturo.TabIndex = 11;
            this.mlblNomeFuturo.Text = "Guilherme";
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(1178, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 19);
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
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAgenda.Size = new System.Drawing.Size(1229, 764);
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
            this.btnSalvarAgenda.Location = new System.Drawing.Point(1139, 735);
            this.btnSalvarAgenda.Name = "btnSalvarAgenda";
            this.btnSalvarAgenda.Size = new System.Drawing.Size(89, 30);
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
            this.lblDataAtual.Location = new System.Drawing.Point(501, 25);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(128, 25);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAgenda.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAgenda.Location = new System.Drawing.Point(6, 58);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.RowHeadersWidth = 51;
            this.dtgAgenda.Size = new System.Drawing.Size(1219, 671);
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
            this.btnAvançar.Location = new System.Drawing.Point(1150, 26);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(75, 27);
            this.btnAvançar.TabIndex = 51;
            this.btnAvançar.Text = "Avançar";
            this.btnAvançar.UseVisualStyleBackColor = true;
            this.btnAvançar.Click += new System.EventHandler(this.btnAvançar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Location = new System.Drawing.Point(6, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 27);
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
            this.tabAlimento.Name = "tabAlimento";
            this.tabAlimento.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAlimento.Size = new System.Drawing.Size(1229, 764);
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
            this.tbAlimento.Location = new System.Drawing.Point(3, 3);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.SelectedIndex = 0;
            this.tbAlimento.Size = new System.Drawing.Size(1219, 760);
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
            this._tbConsulta.Location = new System.Drawing.Point(4, 22);
            this._tbConsulta.Name = "_tbConsulta";
            this._tbConsulta.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._tbConsulta.Size = new System.Drawing.Size(1211, 734);
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
            this.btnCancelarEditAlimentos.Location = new System.Drawing.Point(1090, 692);
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
            this.btnRecalcular.Location = new System.Drawing.Point(6, 690);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(115, 38);
            this.btnRecalcular.TabIndex = 3;
            this.btnRecalcular.Text = "Recalcular";
            this.btnRecalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // lblAlimentoFiltro
            // 
            this.lblAlimentoFiltro.AutoSize = true;
            this.lblAlimentoFiltro.Location = new System.Drawing.Point(12, 41);
            this.lblAlimentoFiltro.Name = "lblAlimentoFiltro";
            this.lblAlimentoFiltro.Size = new System.Drawing.Size(50, 13);
            this.lblAlimentoFiltro.TabIndex = 53;
            this.lblAlimentoFiltro.Text = "Alimento:";
            // 
            // lblTabelaSelecionada
            // 
            this.lblTabelaSelecionada.AutoSize = true;
            this.lblTabelaSelecionada.Location = new System.Drawing.Point(12, 9);
            this.lblTabelaSelecionada.Name = "lblTabelaSelecionada";
            this.lblTabelaSelecionada.Size = new System.Drawing.Size(43, 13);
            this.lblTabelaSelecionada.TabIndex = 52;
            this.lblTabelaSelecionada.Text = "Tabela:";
            // 
            // btnSalvarAlimento
            // 
            this.btnSalvarAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAlimento.AutoSize = true;
            this.btnSalvarAlimento.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAlimento.Location = new System.Drawing.Point(969, 692);
            this.btnSalvarAlimento.Name = "btnSalvarAlimento";
            this.btnSalvarAlimento.Size = new System.Drawing.Size(115, 35);
            this.btnSalvarAlimento.TabIndex = 4;
            this.btnSalvarAlimento.Text = "Salvar";
            this.btnSalvarAlimento.UseVisualStyleBackColor = true;
            this.btnSalvarAlimento.Click += new System.EventHandler(this.btnSalvarAlimento_Click);
            // 
            // cbxTabela
            // 
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Location = new System.Drawing.Point(127, 6);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(438, 21);
            this.cbxTabela.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 4;
            // 
            // txtAlimentoFiltro
            // 
            this.txtAlimentoFiltro.Location = new System.Drawing.Point(127, 38);
            this.txtAlimentoFiltro.Name = "txtAlimentoFiltro";
            this.txtAlimentoFiltro.Size = new System.Drawing.Size(438, 20);
            this.txtAlimentoFiltro.TabIndex = 1;
            this.txtAlimentoFiltro.Leave += new System.EventHandler(this.txtAlimentoFiltro_Leave);
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
            this.dtgConAlimento.Location = new System.Drawing.Point(6, 64);
            this.dtgConAlimento.Name = "dtgConAlimento";
            this.dtgConAlimento.RowHeadersWidth = 51;
            this.dtgConAlimento.Size = new System.Drawing.Size(1201, 622);
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
            this.tbImportarPlanilha.Location = new System.Drawing.Point(4, 22);
            this.tbImportarPlanilha.Name = "tbImportarPlanilha";
            this.tbImportarPlanilha.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbImportarPlanilha.Size = new System.Drawing.Size(1211, 734);
            this.tbImportarPlanilha.TabIndex = 2;
            this.tbImportarPlanilha.Text = "Importação tabela";
            this.tbImportarPlanilha.UseVisualStyleBackColor = true;
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeTabela.Location = new System.Drawing.Point(194, 678);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(503, 20);
            this.txtNomeTabela.TabIndex = 272;
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Location = new System.Drawing.Point(3, 682);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(74, 13);
            this.lblNomeTabela.TabIndex = 271;
            this.lblNomeTabela.Text = "Nome Tabela:";
            // 
            // _cbxNomePlanilha
            // 
            this._cbxNomePlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbxNomePlanilha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxNomePlanilha.FormattingEnabled = true;
            this._cbxNomePlanilha.Location = new System.Drawing.Point(194, 648);
            this._cbxNomePlanilha.Name = "_cbxNomePlanilha";
            this._cbxNomePlanilha.Size = new System.Drawing.Size(503, 21);
            this._cbxNomePlanilha.TabIndex = 270;
            this._cbxNomePlanilha.SelectedIndexChanged += new System.EventHandler(this._cbxNomePlanilha_SelectedIndexChanged);
            // 
            // _btnImportar
            // 
            this._btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportar.AutoSize = true;
            this._btnImportar.Image = global::TCC2.Properties.Resources.database_import_icon_135719;
            this._btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnImportar.Location = new System.Drawing.Point(1090, 690);
            this._btnImportar.Name = "_btnImportar";
            this._btnImportar.Size = new System.Drawing.Size(115, 38);
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
            this.dtgDadosImportados.Location = new System.Drawing.Point(9, 3);
            this.dtgDadosImportados.Name = "dtgDadosImportados";
            this.dtgDadosImportados.RowHeadersWidth = 51;
            this.dtgDadosImportados.Size = new System.Drawing.Size(1201, 592);
            this.dtgDadosImportados.TabIndex = 268;
            this.dtgDadosImportados.DragDrop += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragDrop);
            this.dtgDadosImportados.DragEnter += new System.Windows.Forms.DragEventHandler(this.dtgDadosImportados_DragEnter);
            // 
            // txtCaminhoArquivoExcel
            // 
            this.txtCaminhoArquivoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCaminhoArquivoExcel.Location = new System.Drawing.Point(194, 618);
            this.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            this.txtCaminhoArquivoExcel.ReadOnly = true;
            this.txtCaminhoArquivoExcel.Size = new System.Drawing.Size(629, 20);
            this.txtCaminhoArquivoExcel.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(3, 652);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 13);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Nome da planilha:";
            // 
            // lblCaminho
            // 
            this.lblCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(3, 622);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(104, 13);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "Caminho do arquivo:";
            // 
            // _btnBuscarPlanilha
            // 
            this._btnBuscarPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBuscarPlanilha.Image = global::TCC2.Properties.Resources.consultar;
            this._btnBuscarPlanilha.Location = new System.Drawing.Point(827, 613);
            this._btnBuscarPlanilha.Name = "_btnBuscarPlanilha";
            this._btnBuscarPlanilha.Size = new System.Drawing.Size(27, 26);
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
            this.tbCadMedCaseira.Location = new System.Drawing.Point(4, 22);
            this.tbCadMedCaseira.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCadMedCaseira.Name = "tbCadMedCaseira";
            this.tbCadMedCaseira.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCadMedCaseira.Size = new System.Drawing.Size(1211, 734);
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
            this.txtCodAlimentoMedCas.Location = new System.Drawing.Point(361, 50);
            this.txtCodAlimentoMedCas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dtgSalvarMedCaseira.Size = new System.Drawing.Size(847, 492);
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
            this.txtQtdMedCas.Location = new System.Drawing.Point(941, 118);
            this.txtQtdMedCas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQtdMedCas.Name = "txtQtdMedCas";
            this.txtQtdMedCas.Size = new System.Drawing.Size(250, 20);
            this.txtQtdMedCas.TabIndex = 9;
            // 
            // lblQtd
            // 
            this.lblQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(854, 121);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(57, 13);
            this.lblQtd.TabIndex = 8;
            this.lblQtd.Text = "Qtd (g/ml):";
            // 
            // txtDescMedCaseira
            // 
            this.txtDescMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescMedCaseira.Location = new System.Drawing.Point(439, 118);
            this.txtDescMedCaseira.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescMedCaseira.Name = "txtDescMedCaseira";
            this.txtDescMedCaseira.Size = new System.Drawing.Size(368, 20);
            this.txtDescMedCaseira.TabIndex = 7;
            // 
            // lblDescMedCaseira
            // 
            this.lblDescMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescMedCaseira.AutoSize = true;
            this.lblDescMedCaseira.Location = new System.Drawing.Point(364, 120);
            this.lblDescMedCaseira.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescMedCaseira.Name = "lblDescMedCaseira";
            this.lblDescMedCaseira.Size = new System.Drawing.Size(58, 13);
            this.lblDescMedCaseira.TabIndex = 6;
            this.lblDescMedCaseira.Text = "Descrição:";
            // 
            // txtAlimentoMedCaseira
            // 
            this.txtAlimentoMedCaseira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlimentoMedCaseira.Enabled = false;
            this.txtAlimentoMedCaseira.Location = new System.Drawing.Point(432, 26);
            this.txtAlimentoMedCaseira.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlimentoMedCaseira.Name = "txtAlimentoMedCaseira";
            this.txtAlimentoMedCaseira.Size = new System.Drawing.Size(682, 20);
            this.txtAlimentoMedCaseira.TabIndex = 5;
            this.txtAlimentoMedCaseira.Leave += new System.EventHandler(this.txtAlimentoMedCaseira_Leave);
            // 
            // lblAlimentoMedCas
            // 
            this.lblAlimentoMedCas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlimentoMedCas.AutoSize = true;
            this.lblAlimentoMedCas.Location = new System.Drawing.Point(364, 28);
            this.lblAlimentoMedCas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlimentoMedCas.Name = "lblAlimentoMedCas";
            this.lblAlimentoMedCas.Size = new System.Drawing.Size(50, 13);
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
            this.dtgMedCaseiraAlimentos.Location = new System.Drawing.Point(7, 3);
            this.dtgMedCaseiraAlimentos.Name = "dtgMedCaseiraAlimentos";
            this.dtgMedCaseiraAlimentos.RowHeadersWidth = 51;
            this.dtgMedCaseiraAlimentos.Size = new System.Drawing.Size(348, 730);
            this.dtgMedCaseiraAlimentos.TabIndex = 3;
            this.dtgMedCaseiraAlimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedCaseiraAlimentos_CellDoubleClick);
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
            this.btnSalvarMedCas.Location = new System.Drawing.Point(1119, 703);
            this.btnSalvarMedCas.Name = "btnSalvarMedCas";
            this.btnSalvarMedCas.Size = new System.Drawing.Size(89, 30);
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
            this.tabCardapio.Name = "tabCardapio";
            this.tabCardapio.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCardapio.Size = new System.Drawing.Size(1229, 764);
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
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1222, 753);
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
            this.tbCadCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbCadCardapio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCadCardapio.Name = "tbCadCardapio";
            this.tbCadCardapio.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCadCardapio.Size = new System.Drawing.Size(1214, 727);
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
            this.btnCancelarCardapio.Location = new System.Drawing.Point(1094, 687);
            this.btnCancelarCardapio.Name = "btnCancelarCardapio";
            this.btnCancelarCardapio.Size = new System.Drawing.Size(115, 35);
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
            this.btnConfigGramasCard.Location = new System.Drawing.Point(1094, 40);
            this.btnConfigGramasCard.Name = "btnConfigGramasCard";
            this.btnConfigGramasCard.Size = new System.Drawing.Size(115, 35);
            this.btnConfigGramasCard.TabIndex = 315;
            this.btnConfigGramasCard.Text = "Configurar";
            this.btnConfigGramasCard.UseVisualStyleBackColor = true;
            this.btnConfigGramasCard.Click += new System.EventHandler(this.btnConfigGramasCard_Click);
            // 
            // txtFiltroAlimento
            // 
            this.txtFiltroAlimento.Location = new System.Drawing.Point(8, 54);
            this.txtFiltroAlimento.Name = "txtFiltroAlimento";
            this.txtFiltroAlimento.Size = new System.Drawing.Size(309, 20);
            this.txtFiltroAlimento.TabIndex = 314;
            this.txtFiltroAlimento.Tag = "Filtro...";
            this.txtFiltroAlimento.Leave += new System.EventHandler(this.txtFiltroAlimento_Leave);
            // 
            // graficoMacroNutri
            // 
            this.graficoMacroNutri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graficoMacroNutri.Location = new System.Drawing.Point(4, 549);
            this.graficoMacroNutri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graficoMacroNutri.Name = "graficoMacroNutri";
            this.graficoMacroNutri.Size = new System.Drawing.Size(360, 172);
            this.graficoMacroNutri.TabIndex = 313;
            this.graficoMacroNutri.Text = "Gráfico MacroNutrientes";
            // 
            // btnAddAliCard
            // 
            this.btnAddAliCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAliCard.Image = global::TCC2.Properties.Resources.arrow_icon_1___Copia;
            this.btnAddAliCard.Location = new System.Drawing.Point(568, 275);
            this.btnAddAliCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAliCard.Name = "btnAddAliCard";
            this.btnAddAliCard.Size = new System.Drawing.Size(56, 55);
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
            this.cbxRefeicao.Location = new System.Drawing.Point(404, 11);
            this.cbxRefeicao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxRefeicao.Name = "cbxRefeicao";
            this.cbxRefeicao.Size = new System.Drawing.Size(210, 21);
            this.cbxRefeicao.TabIndex = 306;
            this.cbxRefeicao.Leave += new System.EventHandler(this.cbxRefeicao_Leave);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(320, 15);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(53, 13);
            this.lblDescricao.TabIndex = 302;
            this.lblDescricao.Text = "Refeição:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(106, 13);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(122, 20);
            this.txtPaciente.TabIndex = 299;
            // 
            // btnPacienteCardapio
            // 
            this.btnPacienteCardapio.Image = global::TCC2.Properties.Resources.consultar;
            this.btnPacienteCardapio.Location = new System.Drawing.Point(253, 11);
            this.btnPacienteCardapio.Name = "btnPacienteCardapio";
            this.btnPacienteCardapio.Size = new System.Drawing.Size(30, 23);
            this.btnPacienteCardapio.TabIndex = 301;
            this.btnPacienteCardapio.UseVisualStyleBackColor = true;
            this.btnPacienteCardapio.Click += new System.EventHandler(this.btnPacienteCardapio_Click);
            // 
            // lblValorKcal
            // 
            this.lblValorKcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValorKcal.AutoSize = true;
            this.lblValorKcal.Location = new System.Drawing.Point(460, 570);
            this.lblValorKcal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorKcal.Name = "lblValorKcal";
            this.lblValorKcal.Size = new System.Drawing.Size(0, 13);
            this.lblValorKcal.TabIndex = 312;
            // 
            // lblVlrKcal
            // 
            this.lblVlrKcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVlrKcal.AutoSize = true;
            this.lblVlrKcal.Location = new System.Drawing.Point(368, 570);
            this.lblVlrKcal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVlrKcal.Name = "lblVlrKcal";
            this.lblVlrKcal.Size = new System.Drawing.Size(31, 13);
            this.lblVlrKcal.TabIndex = 311;
            this.lblVlrKcal.Text = "Kcal:";
            // 
            // lblTabelaCardapio
            // 
            this.lblTabelaCardapio.AutoSize = true;
            this.lblTabelaCardapio.Location = new System.Drawing.Point(656, 15);
            this.lblTabelaCardapio.Name = "lblTabelaCardapio";
            this.lblTabelaCardapio.Size = new System.Drawing.Size(43, 13);
            this.lblTabelaCardapio.TabIndex = 308;
            this.lblTabelaCardapio.Text = "Tabela:";
            // 
            // cbxTabelaAlimentoCardapio
            // 
            this.cbxTabelaAlimentoCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTabelaAlimentoCardapio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabelaAlimentoCardapio.FormattingEnabled = true;
            this.cbxTabelaAlimentoCardapio.Location = new System.Drawing.Point(749, 13);
            this.cbxTabelaAlimentoCardapio.Name = "cbxTabelaAlimentoCardapio";
            this.cbxTabelaAlimentoCardapio.Size = new System.Drawing.Size(402, 21);
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
            this.dtgCardapioAlimentos.Location = new System.Drawing.Point(5, 80);
            this.dtgCardapioAlimentos.Name = "dtgCardapioAlimentos";
            this.dtgCardapioAlimentos.RowHeadersWidth = 51;
            this.dtgCardapioAlimentos.Size = new System.Drawing.Size(531, 465);
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
            this.dtgRefeicoes.Location = new System.Drawing.Point(659, 80);
            this.dtgRefeicoes.Name = "dtgRefeicoes";
            this.dtgRefeicoes.RowHeadersWidth = 51;
            this.dtgRefeicoes.Size = new System.Drawing.Size(550, 465);
            this.dtgRefeicoes.TabIndex = 304;
            this.dtgRefeicoes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgRefeicoes_CellBeginEdit);
            this.dtgRefeicoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRefeicoes_CellEndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 300;
            this.label8.Text = "Paciente:";
            // 
            // btnSalvarCardapio
            // 
            this.btnSalvarCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCardapio.AutoSize = true;
            this.btnSalvarCardapio.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCardapio.Location = new System.Drawing.Point(973, 687);
            this.btnSalvarCardapio.Name = "btnSalvarCardapio";
            this.btnSalvarCardapio.Size = new System.Drawing.Size(115, 35);
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
            this.tbConsultaCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbConsultaCardapio.Name = "tbConsultaCardapio";
            this.tbConsultaCardapio.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbConsultaCardapio.Size = new System.Drawing.Size(1214, 727);
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
            this.trwDadosCard.Location = new System.Drawing.Point(3, 42);
            this.trwDadosCard.Name = "trwDadosCard";
            this.trwDadosCard.ReadOnly = true;
            this.trwDadosCard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.trwDadosCard.RowHeadersWidth = 51;
            this.trwDadosCard.Size = new System.Drawing.Size(1205, 678);
            this.trwDadosCard.TabIndex = 0;
            // 
            // txtPacienteConsultaCardapio
            // 
            this.txtPacienteConsultaCardapio.Enabled = false;
            this.txtPacienteConsultaCardapio.Location = new System.Drawing.Point(107, 15);
            this.txtPacienteConsultaCardapio.Name = "txtPacienteConsultaCardapio";
            this.txtPacienteConsultaCardapio.Size = new System.Drawing.Size(122, 20);
            this.txtPacienteConsultaCardapio.TabIndex = 302;
            this.txtPacienteConsultaCardapio.TextChanged += new System.EventHandler(this.txtPacienteConsultaCardapio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 303;
            this.label6.Text = "Paciente:";
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnApagar.Location = new System.Drawing.Point(271, 13);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(30, 23);
            this.btnApagar.TabIndex = 306;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Image = global::TCC2.Properties.Resources.consultar;
            this.btnBuscaPaciente.Location = new System.Drawing.Point(235, 13);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(30, 23);
            this.btnBuscaPaciente.TabIndex = 304;
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // tbCadastrarTiposCardapios
            // 
            this.tbCadastrarTiposCardapios.Location = new System.Drawing.Point(4, 22);
            this.tbCadastrarTiposCardapios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCadastrarTiposCardapios.Name = "tbCadastrarTiposCardapios";
            this.tbCadastrarTiposCardapios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCadastrarTiposCardapios.Size = new System.Drawing.Size(1214, 727);
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
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPaciente.Size = new System.Drawing.Size(1229, 764);
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
            this.tbPaciente.Size = new System.Drawing.Size(1217, 756);
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
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbCadastro.Size = new System.Drawing.Size(1209, 730);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            this.tbCadastro.Enter += new System.EventHandler(this.tbCadastro_Enter);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(283, 169);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(169, 20);
            this.txtCEP.TabIndex = 272;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
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
            this.txtDtNasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this._dtgConsultaPacientes.Size = new System.Drawing.Size(1199, 254);
            this._dtgConsultaPacientes.TabIndex = 266;
            this._dtgConsultaPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtgConsultaPacientes_CellDoubleClick);
            // 
            // _btnExcluir
            // 
            this._btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnExcluir.AutoSize = true;
            this._btnExcluir.Image = global::TCC2.Properties.Resources.DeleteRed;
            this._btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcluir.Location = new System.Drawing.Point(1088, 431);
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
            this._btnSalvar.Location = new System.Drawing.Point(967, 431);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(115, 35);
            this._btnSalvar.TabIndex = 241;
            this._btnSalvar.Text = "Salvar";
            this._btnSalvar.UseVisualStyleBackColor = true;
            this._btnSalvar.Click += new System.EventHandler(this._btnSalvar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(687, 231);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 20);
            this.txtNumero.TabIndex = 234;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(650, 234);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 13);
            this.lblNum.TabIndex = 256;
            this.lblNum.Text = "Nº:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(283, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 20);
            this.txtEmail.TabIndex = 229;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(201, 128);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 255;
            this.Label1.Text = "E-mail:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(148, 353);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(623, 20);
            this.txtComplemento.TabIndex = 238;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(13, 355);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 254;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(796, 293);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(49, 20);
            this.txtUF.TabIndex = 237;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(747, 294);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 253;
            this.lblUF.Text = "UF:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(366, 410);
            this.txtCelular.MaxLength = 16;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(165, 20);
            this.txtCelular.TabIndex = 240;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(299, 413);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 252;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(100, 411);
            this.txtTelefone.MaxLength = 16;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(166, 20);
            this.txtTelefone.TabIndex = 239;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 415);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 251;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(524, 292);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(181, 20);
            this.txtMunicipio.TabIndex = 236;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(435, 295);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 250;
            this.lblMunicipio.Text = "Município:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCEP.Location = new System.Drawing.Point(203, 172);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 249;
            this.lblCEP.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(77, 292);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(308, 20);
            this.txtBairro.TabIndex = 235;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(13, 294);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 248;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 235);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(502, 20);
            this.txtEndereco.TabIndex = 233;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(10, 238);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 247;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(201, 86);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.lblDataNascimento.TabIndex = 246;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(720, 36);
            this.txtCPF.MaxLength = 16;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(116, 20);
            this.txtCPF.TabIndex = 227;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(668, 38);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 245;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(269, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 20);
            this.txtNome.TabIndex = 226;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(201, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 243;
            this.lblNome.Text = "Nome:";
            // 
            // tbAntropometricos
            // 
            this.tbAntropometricos.Controls.Add(this.textBox5);
            this.tbAntropometricos.Controls.Add(this.label5);
            this.tbAntropometricos.Controls.Add(this.textBox4);
            this.tbAntropometricos.Controls.Add(this.label4);
            this.tbAntropometricos.Controls.Add(this.textBox3);
            this.tbAntropometricos.Controls.Add(this.label3);
            this.tbAntropometricos.Controls.Add(this.textBox2);
            this.tbAntropometricos.Controls.Add(this.label2);
            this.tbAntropometricos.Location = new System.Drawing.Point(4, 22);
            this.tbAntropometricos.Name = "tbAntropometricos";
            this.tbAntropometricos.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbAntropometricos.Size = new System.Drawing.Size(1209, 730);
            this.tbAntropometricos.TabIndex = 2;
            this.tbAntropometricos.Text = "Antropometria";
            this.tbAntropometricos.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 162);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 119);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 51);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 18);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // tbAnamnese
            // 
            this.tbAnamnese.Location = new System.Drawing.Point(4, 22);
            this.tbAnamnese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnamnese.Name = "tbAnamnese";
            this.tbAnamnese.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnamnese.Size = new System.Drawing.Size(1209, 730);
            this.tbAnamnese.TabIndex = 3;
            this.tbAnamnese.Text = "Anamnese";
            this.tbAnamnese.UseVisualStyleBackColor = true;
            // 
            // tabReceitas
            // 
            this.tabReceitas.ImageKey = "Receitas32px.png";
            this.tabReceitas.Location = new System.Drawing.Point(4, 39);
            this.tabReceitas.Name = "tabReceitas";
            this.tabReceitas.Size = new System.Drawing.Size(1229, 764);
            this.tabReceitas.TabIndex = 6;
            this.tabReceitas.Text = "Receitas";
            this.tabReceitas.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tbConfig);
            this.tabConfig.ImageKey = "settings32px.png";
            this.tabConfig.Location = new System.Drawing.Point(4, 39);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabConfig.Size = new System.Drawing.Size(1229, 764);
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
            this.tbConfig.Controls.Add(this.TabPage2);
            this.tbConfig.Location = new System.Drawing.Point(3, 6);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.SelectedIndex = 0;
            this.tbConfig.Size = new System.Drawing.Size(1220, 752);
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
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage1.Size = new System.Drawing.Size(1212, 726);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Usuários";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(461, 59);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(168, 20);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.Enter += new System.EventHandler(this.txtConfirmarSenha_Enter);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(78, 59);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtEmailConfig
            // 
            this.txtEmailConfig.Location = new System.Drawing.Point(78, 103);
            this.txtEmailConfig.Name = "txtEmailConfig";
            this.txtEmailConfig.Size = new System.Drawing.Size(469, 20);
            this.txtEmailConfig.TabIndex = 5;
            // 
            // txtNomeUsuarioConfig
            // 
            this.txtNomeUsuarioConfig.Location = new System.Drawing.Point(398, 14);
            this.txtNomeUsuarioConfig.Name = "txtNomeUsuarioConfig";
            this.txtNomeUsuarioConfig.Size = new System.Drawing.Size(425, 20);
            this.txtNomeUsuarioConfig.TabIndex = 1;
            // 
            // txtUsuarioConfig
            // 
            this.txtUsuarioConfig.Location = new System.Drawing.Point(78, 13);
            this.txtUsuarioConfig.Name = "txtUsuarioConfig";
            this.txtUsuarioConfig.Size = new System.Drawing.Size(168, 20);
            this.txtUsuarioConfig.TabIndex = 0;
            this.txtUsuarioConfig.Leave += new System.EventHandler(this.txtUsuarioConfig_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Confirmar senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(6, 62);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
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
            this.cbxSituacao.Location = new System.Drawing.Point(748, 59);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(117, 21);
            this.cbxSituacao.TabIndex = 4;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(662, 62);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 52;
            this.lblSituacao.Text = "Situação:";
            // 
            // btnExcluirConfigUsuario
            // 
            this.btnExcluirConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirConfigUsuario.Image = global::TCC2.Properties.Resources.DeleteRed;
            this.btnExcluirConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirConfigUsuario.Location = new System.Drawing.Point(1090, 129);
            this.btnExcluirConfigUsuario.Name = "btnExcluirConfigUsuario";
            this.btnExcluirConfigUsuario.Size = new System.Drawing.Size(115, 35);
            this.btnExcluirConfigUsuario.TabIndex = 8;
            this.btnExcluirConfigUsuario.Text = "Excluir";
            this.btnExcluirConfigUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSalvarConfigUsuario
            // 
            this.btnSalvarConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarConfigUsuario.Image = global::TCC2.Properties.Resources.mvtSaveGreen_16;
            this.btnSalvarConfigUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarConfigUsuario.Location = new System.Drawing.Point(969, 129);
            this.btnSalvarConfigUsuario.Name = "btnSalvarConfigUsuario";
            this.btnSalvarConfigUsuario.Size = new System.Drawing.Size(115, 35);
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
            this.cbxTipoUsuario.Location = new System.Drawing.Point(683, 101);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(165, 21);
            this.cbxTipoUsuario.TabIndex = 6;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(626, 103);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 9;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
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
            this.dtgUsuarios.Location = new System.Drawing.Point(6, 170);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.Size = new System.Drawing.Size(1199, 548);
            this.dtgUsuarios.TabIndex = 9;
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.textBox1);
            this.TabPage2.Controls.Add(this.label13);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage2.Size = new System.Drawing.Size(1212, 726);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Permissões";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Usuário:";
            // 
            // tbSobre
            // 
            this.tbSobre.ImageKey = "information.png";
            this.tbSobre.Location = new System.Drawing.Point(4, 39);
            this.tbSobre.Name = "tbSobre";
            this.tbSobre.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbSobre.Size = new System.Drawing.Size(1229, 764);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 813);
            this.Controls.Add(this.TabControlNutreasy);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlNutreasy;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
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
            this.tabConfig.ResumeLayout(false);
            this.tbConfig.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
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
        internal System.Windows.Forms.TabPage TabPage2;
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

