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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanilhaCardapio));
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this._btnAdicionar = new MvtWindowsForms.ButtonInserir();
            this._btnProcurarPaciente = new System.Windows.Forms.Button();
            this.dtgRefeicoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Enabled = false;
            this.txtCodPaciente.Location = new System.Drawing.Point(135, 6);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(75, 20);
            this.txtCodPaciente.TabIndex = 263;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 13);
            this.Label6.TabIndex = 264;
            this.Label6.Text = "Código Paciente:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(135, 44);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(362, 61);
            this.txtDescricao.TabIndex = 266;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 47);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(117, 13);
            this.lblDescricao.TabIndex = 267;
            this.lblDescricao.Text = "Descrição do cardápio:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Image = global::ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(788, 478);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 270;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // _btnAdicionar
            // 
            this._btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdicionar.Image")));
            this._btnAdicionar.Location = new System.Drawing.Point(777, 102);
            this._btnAdicionar.MaximumSize = new System.Drawing.Size(100, 30);
            this._btnAdicionar.MinimumSize = new System.Drawing.Size(100, 30);
            this._btnAdicionar.Name = "_btnAdicionar";
            this._btnAdicionar.Size = new System.Drawing.Size(100, 30);
            this._btnAdicionar.TabIndex = 269;
            this._btnAdicionar.Text = "Adicionar";
            this._btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnAdicionar.ToolTipHelp = null;
            this._btnAdicionar.UseVisualStyleBackColor = true;
            this._btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // _btnProcurarPaciente
            // 
            this._btnProcurarPaciente.Image = global::ProjetoTCC.My.Resources.Resources.consultar;
            this._btnProcurarPaciente.Location = new System.Drawing.Point(216, 4);
            this._btnProcurarPaciente.Name = "_btnProcurarPaciente";
            this._btnProcurarPaciente.Size = new System.Drawing.Size(30, 23);
            this._btnProcurarPaciente.TabIndex = 265;
            this._btnProcurarPaciente.UseVisualStyleBackColor = true;
            this._btnProcurarPaciente.Click += new System.EventHandler(this.btnProcurarPaciente_Click);
            // 
            // dtgRefeicoes
            // 
            this.dtgRefeicoes.AllowUserToAddRows = false;
            this.dtgRefeicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefeicoes.BackgroundColor = System.Drawing.Color.White;
            this.dtgRefeicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRefeicoes.Location = new System.Drawing.Point(12, 138);
            this.dtgRefeicoes.Name = "dtgRefeicoes";
            this.dtgRefeicoes.Size = new System.Drawing.Size(865, 334);
            this.dtgRefeicoes.TabIndex = 274;
            // 
            // frmPlanilhaCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 520);
            this.Controls.Add(this.dtgRefeicoes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this._btnAdicionar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this._btnProcurarPaciente);
            this.Controls.Add(this.txtCodPaciente);
            this.Controls.Add(this.Label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanilhaCardapio";
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.frmPlanilhaCardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefeicoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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