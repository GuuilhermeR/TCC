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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarRefeição));
            lblHora = new Label();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            txtHora = new TextBox();
            txtAlimento = new TextBox();
            lblAlimento = new Label();
            btnProcurarPaciente = new Button();
            _btnAdicionarRefeição = new MvtWindowsForms.ButtonInserir();
            _btnAdicionarRefeição.Click += new EventHandler(btnAdicionarRefeição_Click);
            TextBox1 = new TextBox();
            lblObs = new Label();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(13, 28);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(44, 13);
            lblHora.TabIndex = 1;
            lblHora.Text = "Horário:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(205, 28);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 13);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(269, 25);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(291, 20);
            txtDescricao.TabIndex = 3;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(63, 25);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(100, 20);
            txtHora.TabIndex = 4;
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(69, 74);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(370, 20);
            txtAlimento.TabIndex = 6;
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(13, 77);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(50, 13);
            lblAlimento.TabIndex = 5;
            lblAlimento.Text = "Alimento:";
            // 
            // btnProcurarPaciente
            // 
            btnProcurarPaciente.Image = My.Resources.Resources.consultar;
            btnProcurarPaciente.Location = new Point(445, 72);
            btnProcurarPaciente.Name = "btnProcurarPaciente";
            btnProcurarPaciente.Size = new Size(30, 23);
            btnProcurarPaciente.TabIndex = 266;
            btnProcurarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarRefeição
            // 
            _btnAdicionarRefeição.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnAdicionarRefeição.Image = (Image)resources.GetObject("btnAdicionarRefeição.Image");
            _btnAdicionarRefeição.Location = new Point(456, 123);
            _btnAdicionarRefeição.MaximumSize = new Size(100, 30);
            _btnAdicionarRefeição.MinimumSize = new Size(100, 30);
            _btnAdicionarRefeição.Name = "_btnAdicionarRefeição";
            _btnAdicionarRefeição.Size = new Size(100, 30);
            _btnAdicionarRefeição.TabIndex = 267;
            _btnAdicionarRefeição.Text = "Adicionar";
            _btnAdicionarRefeição.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnAdicionarRefeição.ToolTipHelp = null;
            _btnAdicionarRefeição.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(127, 120);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(72, 20);
            TextBox1.TabIndex = 269;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(13, 123);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(108, 13);
            lblObs.TabIndex = 268;
            lblObs.Text = "Quantidade (gramas):";
            // 
            // frmAdicionarRefeição
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 165);
            Controls.Add(TextBox1);
            Controls.Add(lblObs);
            Controls.Add(_btnAdicionarRefeição);
            Controls.Add(btnProcurarPaciente);
            Controls.Add(txtAlimento);
            Controls.Add(lblAlimento);
            Controls.Add(txtHora);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(lblHora);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdicionarRefeição";
            Text = "Adicionar Refeição";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label lblHora;
        internal Label lblDescricao;
        internal TextBox txtDescricao;
        internal TextBox txtHora;
        internal TextBox txtAlimento;
        internal Label lblAlimento;
        internal Button btnProcurarPaciente;
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