using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmAdicionarRefeição : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarRefeição));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.btnProcurarAlimento = new System.Windows.Forms.Button();
            this._btnAdicionarRefeição = new MvtWindowsForms.ButtonInserir();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(13, 28);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Horário:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(205, 28);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(269, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(291, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(63, 25);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 4;
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(69, 74);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(94, 20);
            this.txtAlimento.TabIndex = 6;
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Location = new System.Drawing.Point(13, 77);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(50, 13);
            this.lblAlimento.TabIndex = 5;
            this.lblAlimento.Text = "Alimento:";
            // 
            // btnProcurarAlimento
            // 
            this.btnProcurarAlimento.Image = global::ProjetoTCC.My.Resources.Resources.consultar;
            this.btnProcurarAlimento.Location = new System.Drawing.Point(169, 71);
            this.btnProcurarAlimento.Name = "btnProcurarAlimento";
            this.btnProcurarAlimento.Size = new System.Drawing.Size(30, 23);
            this.btnProcurarAlimento.TabIndex = 266;
            this.btnProcurarAlimento.UseVisualStyleBackColor = true;
            this.btnProcurarAlimento.Click += new System.EventHandler(this.btnProcurarPaciente_Click);
            // 
            // _btnAdicionarRefeição
            // 
            this._btnAdicionarRefeição.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdicionarRefeição.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdicionarRefeição.Image")));
            this._btnAdicionarRefeição.Location = new System.Drawing.Point(456, 123);
            this._btnAdicionarRefeição.MaximumSize = new System.Drawing.Size(100, 30);
            this._btnAdicionarRefeição.MinimumSize = new System.Drawing.Size(100, 30);
            this._btnAdicionarRefeição.Name = "_btnAdicionarRefeição";
            this._btnAdicionarRefeição.Size = new System.Drawing.Size(100, 30);
            this._btnAdicionarRefeição.TabIndex = 267;
            this._btnAdicionarRefeição.Text = "Adicionar";
            this._btnAdicionarRefeição.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnAdicionarRefeição.ToolTipHelp = null;
            this._btnAdicionarRefeição.UseVisualStyleBackColor = true;
            this._btnAdicionarRefeição.Click += new System.EventHandler(this.btnAdicionarRefeição_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(127, 120);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(72, 20);
            this.TextBox1.TabIndex = 269;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(13, 123);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(108, 13);
            this.lblObs.TabIndex = 268;
            this.lblObs.Text = "Quantidade (gramas):";
            // 
            // frmAdicionarRefeição
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 165);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this._btnAdicionarRefeição);
            this.Controls.Add(this.btnProcurarAlimento);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdicionarRefeição";
            this.Text = "Adicionar Refeição";
            this.Load += new System.EventHandler(this.frmAdicionarRefeição_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label lblHora;
        internal Label lblDescricao;
        internal TextBox txtDescricao;
        internal TextBox txtHora;
        internal TextBox txtAlimento;
        internal Label lblAlimento;
        internal Button btnProcurarAlimento;
        private MvtWindowsForms.ButtonInserir _btnAdicionarRefeição;

        internal MvtWindowsForms.ButtonInserir btnAdicionarRefeição
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdicionarRefeição;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdicionarRefeição != null)
                {
                    _btnAdicionarRefeição.Click -= btnAdicionarRefeição_Click;
                }

                _btnAdicionarRefeição = value;
                if (_btnAdicionarRefeição != null)
                {
                    _btnAdicionarRefeição.Click += btnAdicionarRefeição_Click;
                }
            }
        }

        internal TextBox TextBox1;
        internal Label lblObs;
    }
}