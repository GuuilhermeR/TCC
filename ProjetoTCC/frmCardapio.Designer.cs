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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardapio));
            Label1 = new Label();
            TextBox1 = new TextBox();
            dtgCardápio = new DataGridView();
            TextBox2 = new TextBox();
            Label2 = new Label();
            TextBox3 = new TextBox();
            Label3 = new Label();
            TextBox4 = new TextBox();
            Label4 = new Label();
            TextBox5 = new TextBox();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            dtgTotalizador = new DataGridView();
            Button1 = new Button();
            btnSalvar = new Button();
            btnProcurarAlimento = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCardápio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTotalizador).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(52, 13);
            Label1.TabIndex = 0;
            Label1.Text = "Paciente:";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(70, 19);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(41, 20);
            TextBox1.TabIndex = 1;
            // 
            // dtgCardápio
            // 
            dtgCardápio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtgCardápio.BackgroundColor = Color.White;
            dtgCardápio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCardápio.Location = new Point(12, 46);
            dtgCardápio.Name = "dtgCardápio";
            dtgCardápio.Size = new Size(961, 362);
            dtgCardápio.TabIndex = 2;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(424, 19);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(49, 20);
            TextBox2.TabIndex = 4;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(381, 22);
            Label2.Name = "Label2";
            Label2.Size = new Size(37, 13);
            Label2.TabIndex = 3;
            Label2.Text = "Idade:";
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(540, 19);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(59, 20);
            TextBox3.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(500, 22);
            Label3.Name = "Label3";
            Label3.Size = new Size(34, 13);
            Label3.TabIndex = 5;
            Label3.Text = "Peso:";
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(873, 19);
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.Size = new Size(100, 20);
            TextBox4.TabIndex = 8;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(838, 22);
            Label4.Name = "Label4";
            Label4.Size = new Size(29, 13);
            Label4.TabIndex = 7;
            Label4.Text = "IMC:";
            // 
            // TextBox5
            // 
            TextBox5.Location = new Point(710, 19);
            TextBox5.Name = "TextBox5";
            TextBox5.ReadOnly = true;
            TextBox5.Size = new Size(74, 20);
            TextBox5.TabIndex = 10;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(652, 22);
            Label5.Name = "Label5";
            Label5.Size = new Size(49, 13);
            Label5.TabIndex = 9;
            Label5.Text = "Estatura:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(605, 22);
            Label6.Name = "Label6";
            Label6.Size = new Size(20, 13);
            Label6.TabIndex = 11;
            Label6.Text = "Kg";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(790, 22);
            Label7.Name = "Label7";
            Label7.Size = new Size(21, 13);
            Label7.TabIndex = 12;
            Label7.Text = "cm";
            // 
            // dtgTotalizador
            // 
            dtgTotalizador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgTotalizador.BackgroundColor = Color.White;
            dtgTotalizador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTotalizador.Location = new Point(12, 414);
            dtgTotalizador.Name = "dtgTotalizador";
            dtgTotalizador.Size = new Size(961, 113);
            dtgTotalizador.TabIndex = 27;
            // 
            // Button1
            // 
            Button1.Location = new Point(12, 9);
            Button1.Name = "Button1";
            Button1.Size = new Size(15, 10);
            Button1.TabIndex = 50;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Image = My.Resources.Resources.mvtSaveGreen_16;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(884, 533);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(89, 30);
            btnSalvar.TabIndex = 49;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnProcurarAlimento
            // 
            btnProcurarAlimento.Image = My.Resources.Resources.consultar;
            btnProcurarAlimento.Location = new Point(117, 17);
            btnProcurarAlimento.Name = "btnProcurarAlimento";
            btnProcurarAlimento.Size = new Size(30, 23);
            btnProcurarAlimento.TabIndex = 26;
            btnProcurarAlimento.UseVisualStyleBackColor = true;
            // 
            // frmCardapio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 575);
            Controls.Add(Button1);
            Controls.Add(btnSalvar);
            Controls.Add(dtgTotalizador);
            Controls.Add(btnProcurarAlimento);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(TextBox5);
            Controls.Add(Label5);
            Controls.Add(TextBox4);
            Controls.Add(Label4);
            Controls.Add(TextBox3);
            Controls.Add(Label3);
            Controls.Add(TextBox2);
            Controls.Add(Label2);
            Controls.Add(dtgCardápio);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCardapio";
            Text = "Cardápio";
            ((System.ComponentModel.ISupportInitialize)dtgCardápio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTotalizador).EndInit();
            Load += new EventHandler(frmCardapio_Load);
            ResumeLayout(false);
            PerformLayout();
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
        internal Button Button1;
    }
}