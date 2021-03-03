using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmPlanilhaCardapio : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanilhaCardapio));
            txtCodPaciente = new TextBox();
            Label6 = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            btnSalvar = new Button();
            _btnAdicionar = new MvtWindowsForms.ButtonInserir();
            _btnAdicionar.Click += new EventHandler(btnAdicionar_Click);
            _btnProcurarPaciente = new Button();
            _btnProcurarPaciente.Click += new EventHandler(btnProcurarPaciente_Click);
            dtgRefeicoes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgRefeicoes).BeginInit();
            SuspendLayout();
            // 
            // txtCodPaciente
            // 
            txtCodPaciente.Enabled = false;
            txtCodPaciente.Location = new Point(106, 6);
            txtCodPaciente.Name = "txtCodPaciente";
            txtCodPaciente.Size = new Size(75, 20);
            txtCodPaciente.TabIndex = 263;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(12, 9);
            Label6.Name = "Label6";
            Label6.Size = new Size(88, 13);
            Label6.TabIndex = 264;
            Label6.Text = "Código Paciente:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(106, 44);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(362, 61);
            txtDescricao.TabIndex = 266;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 47);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 13);
            lblDescricao.TabIndex = 267;
            lblDescricao.Text = "Descrição:";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Image = My.Resources.Resources.mvtSaveGreen_16;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(788, 478);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(89, 30);
            btnSalvar.TabIndex = 270;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            _btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            _btnAdicionar.Location = new Point(777, 102);
            _btnAdicionar.MaximumSize = new Size(100, 30);
            _btnAdicionar.MinimumSize = new Size(100, 30);
            _btnAdicionar.Name = "_btnAdicionar";
            _btnAdicionar.Size = new Size(100, 30);
            _btnAdicionar.TabIndex = 269;
            _btnAdicionar.Text = "Adicionar";
            _btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnAdicionar.ToolTipHelp = null;
            _btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnProcurarPaciente
            // 
            _btnProcurarPaciente.Image = My.Resources.Resources.consultar;
            _btnProcurarPaciente.Location = new Point(187, 4);
            _btnProcurarPaciente.Name = "_btnProcurarPaciente";
            _btnProcurarPaciente.Size = new Size(30, 23);
            _btnProcurarPaciente.TabIndex = 265;
            _btnProcurarPaciente.UseVisualStyleBackColor = true;
            // 
            // dtgRefeicoes
            // 
            dtgRefeicoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtgRefeicoes.BackgroundColor = Color.White;
            dtgRefeicoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRefeicoes.Location = new Point(12, 138);
            dtgRefeicoes.Name = "dtgRefeicoes";
            dtgRefeicoes.Size = new Size(865, 334);
            dtgRefeicoes.TabIndex = 274;
            // 
            // frmPlanilhaCardapio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 520);
            Controls.Add(dtgRefeicoes);
            Controls.Add(btnSalvar);
            Controls.Add(_btnAdicionar);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(_btnProcurarPaciente);
            Controls.Add(txtCodPaciente);
            Controls.Add(Label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPlanilhaCardapio";
            Text = "Cardápio";
            ((System.ComponentModel.ISupportInitialize)dtgRefeicoes).EndInit();
            Load += new EventHandler(frmPlanilhaCardapio_Load);
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal TextBox txtCodPaciente;
        internal Label Label6;
        internal TextBox txtDescricao;
        internal Label lblDescricao;
        private MvtWindowsForms.ButtonInserir _btnAdicionar;

        internal MvtWindowsForms.ButtonInserir btnAdicionar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdicionar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdicionar != null)
                {
                    _btnAdicionar.Click -= btnAdicionar_Click;
                }

                _btnAdicionar = value;
                if (_btnAdicionar != null)
                {
                    _btnAdicionar.Click += btnAdicionar_Click;
                }
            }
        }

        internal Button btnSalvar;
        internal DataGridView dtgRefeicoes;
    }
}