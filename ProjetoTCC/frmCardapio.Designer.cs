using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmCardapio : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardapio));
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.dtgCardápio = new System.Windows.Forms.DataGridView();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.dtgTotalizador = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnProcurarAlimento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardápio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTotalizador)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Paciente:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(70, 19);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(41, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // dtgCardápio
            // 
            this.dtgCardápio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCardápio.BackgroundColor = System.Drawing.Color.White;
            this.dtgCardápio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCardápio.Location = new System.Drawing.Point(12, 46);
            this.dtgCardápio.Name = "dtgCardápio";
            this.dtgCardápio.Size = new System.Drawing.Size(961, 362);
            this.dtgCardápio.TabIndex = 2;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(424, 19);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(49, 20);
            this.TextBox2.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(381, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Idade:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(540, 19);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(59, 20);
            this.TextBox3.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(500, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Peso:";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(873, 19);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(100, 20);
            this.TextBox4.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(838, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "IMC:";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(710, 19);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new System.Drawing.Size(74, 20);
            this.TextBox5.TabIndex = 10;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(652, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Estatura:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(605, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(20, 13);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Kg";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(790, 22);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(21, 13);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "cm";
            // 
            // dtgTotalizador
            // 
            this.dtgTotalizador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTotalizador.BackgroundColor = System.Drawing.Color.White;
            this.dtgTotalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTotalizador.Location = new System.Drawing.Point(12, 414);
            this.dtgTotalizador.Name = "dtgTotalizador";
            this.dtgTotalizador.Size = new System.Drawing.Size(961, 113);
            this.dtgTotalizador.TabIndex = 27;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Image = global::ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(884, 533);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnProcurarAlimento
            // 
            this.btnProcurarAlimento.Image = global::ProjetoTCC.My.Resources.Resources.consultar;
            this.btnProcurarAlimento.Location = new System.Drawing.Point(117, 17);
            this.btnProcurarAlimento.Name = "btnProcurarAlimento";
            this.btnProcurarAlimento.Size = new System.Drawing.Size(30, 23);
            this.btnProcurarAlimento.TabIndex = 26;
            this.btnProcurarAlimento.UseVisualStyleBackColor = true;
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 575);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgTotalizador);
            this.Controls.Add(this.btnProcurarAlimento);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtgCardápio);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCardapio";
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardápio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTotalizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal TextBox TextBox1;
        internal DataGridView dtgCardápio;
        internal TextBox TextBox2;
        internal Label Label2;
        internal TextBox TextBox3;
        internal Label Label3;
        internal TextBox TextBox4;
        internal Label Label4;
        internal TextBox TextBox5;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Button btnProcurarAlimento;
        internal DataGridView dtgTotalizador;
        internal Button btnSalvar;
    }
}