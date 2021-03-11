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
            this._tbConsulta = new System.Windows.Forms.TabPage();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.lblAlimentoFiltro = new System.Windows.Forms.Label();
            this.lblTabelaSelecionada = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
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
            this.tbAlimento.Controls.Add(this._tbConsulta);
            this.tbAlimento.Controls.Add(this.tbImportarPlanilha);
            this.tbAlimento.Location = new System.Drawing.Point(3, 3);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.SelectedIndex = 0;
            this.tbAlimento.Size = new System.Drawing.Size(810, 544);
            this.tbAlimento.TabIndex = 0;
            // 
            // _tbConsulta
            // 
            this._tbConsulta.Controls.Add(this.btnRecalcular);
            this._tbConsulta.Controls.Add(this.lblAlimentoFiltro);
            this._tbConsulta.Controls.Add(this.lblTabelaSelecionada);
            this._tbConsulta.Controls.Add(this.btnExcluir);
            this._tbConsulta.Controls.Add(this.btnSalvar);
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
            this._tbConsulta.Text = "Cadastro/Consulta";
            this._tbConsulta.UseVisualStyleBackColor = true;
            this._tbConsulta.Enter += new System.EventHandler(this._tbConsulta_Enter);
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecalcular.Location = new System.Drawing.Point(6, 482);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(89, 30);
            this.btnRecalcular.TabIndex = 54;
            this.btnRecalcular.Text = "Recalcular";
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
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Image = global::ProjetoTCC.My.Resources.Resources.DeleteRed;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(707, 482);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Image = global::ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(612, 482);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // cbxTabela
            // 
            this.cbxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Location = new System.Drawing.Point(64, 6);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(732, 21);
            this.cbxTabela.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // _txtAlimentoFiltro
            // 
            this._txtAlimentoFiltro.Location = new System.Drawing.Point(64, 38);
            this._txtAlimentoFiltro.Name = "_txtAlimentoFiltro";
            this._txtAlimentoFiltro.Size = new System.Drawing.Size(732, 20);
            this._txtAlimentoFiltro.TabIndex = 3;
            this._txtAlimentoFiltro.Leave += new System.EventHandler(this._txtAlimentoFiltro_Leave);
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
            this.dtgConAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConAlimento.BackgroundColor = System.Drawing.Color.White;
            this.dtgConAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConAlimento.Location = new System.Drawing.Point(6, 64);
            this.dtgConAlimento.Name = "dtgConAlimento";
            this.dtgConAlimento.Size = new System.Drawing.Size(790, 412);
            this.dtgConAlimento.TabIndex = 0;
            this.dtgConAlimento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConAlimento_CellDoubleClick);
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
            this.tbImportarPlanilha.Text = "Importação tabela";
            this.tbImportarPlanilha.UseVisualStyleBackColor = true;
            // 
            // pbCarregando
            // 
            this.pbCarregando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbCarregando.Location = new System.Drawing.Point(6, 489);
            this.pbCarregando.Name = "pbCarregando";
            this.pbCarregando.Size = new System.Drawing.Size(697, 23);
            this.pbCarregando.TabIndex = 273;
            this.pbCarregando.Visible = false;
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeTabela.Location = new System.Drawing.Point(116, 452);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(503, 20);
            this.txtNomeTabela.TabIndex = 272;
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Location = new System.Drawing.Point(3, 455);
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
            this._cbxNomePlanilha.Location = new System.Drawing.Point(116, 420);
            this._cbxNomePlanilha.Name = "_cbxNomePlanilha";
            this._cbxNomePlanilha.Size = new System.Drawing.Size(503, 21);
            this._cbxNomePlanilha.TabIndex = 270;
            this._cbxNomePlanilha.SelectedIndexChanged += new System.EventHandler(this.cbxNomePlanilha_SelectedIndexChanged);
            // 
            // _btnImportar
            // 
            this._btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportar.Location = new System.Drawing.Point(712, 482);
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
            this.dtgDados.Location = new System.Drawing.Point(6, 6);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(790, 379);
            this.dtgDados.TabIndex = 268;
            // 
            // _btnBuscarPlanilha
            // 
            this._btnBuscarPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.txtCaminhoArquivoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCaminhoArquivoExcel.Location = new System.Drawing.Point(116, 391);
            this.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel";
            this.txtCaminhoArquivoExcel.ReadOnly = true;
            this.txtCaminhoArquivoExcel.Size = new System.Drawing.Size(629, 20);
            this.txtCaminhoArquivoExcel.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(3, 424);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 13);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Nome da planilha:";
            // 
            // lblCaminho
            // 
            this.lblCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(3, 394);
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
            this._tbConsulta.ResumeLayout(false);
            this._tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConAlimento)).EndInit();
            this.tbImportarPlanilha.ResumeLayout(false);
            this.tbImportarPlanilha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);

        }

        internal TabControl tbAlimento;



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
        private TabPage _tbConsulta;
        private Label lblAlimentoFiltro;
        private Label lblTabelaSelecionada;
        internal Button btnExcluir;
        internal Button btnSalvar;
        private ComboBox cbxTabela;
        internal Label label3;
        private TextBox _txtAlimentoFiltro;
        internal Label lblTabela;
        internal DataGridView dtgConAlimento;
        internal Button btnRecalcular;
    }
}