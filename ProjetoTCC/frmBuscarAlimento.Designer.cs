
namespace ProjetoTCC
{
    partial class frmBuscarAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAlimento));
            this.dtgCardápio = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTabelaDesejada = new System.Windows.Forms.Label();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.cbxTabelaAlimentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardápio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCardápio
            // 
            this.dtgCardápio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCardápio.BackgroundColor = System.Drawing.Color.White;
            this.dtgCardápio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCardápio.Location = new System.Drawing.Point(12, 58);
            this.dtgCardápio.Name = "dtgCardápio";
            this.dtgCardápio.Size = new System.Drawing.Size(680, 396);
            this.dtgCardápio.TabIndex = 33;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(596, 25);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(96, 28);
            this.btnProcurar.TabIndex = 32;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 20);
            this.textBox2.TabIndex = 34;
            // 
            // lblTabelaDesejada
            // 
            this.lblTabelaDesejada.AutoSize = true;
            this.lblTabelaDesejada.Location = new System.Drawing.Point(9, 9);
            this.lblTabelaDesejada.Name = "lblTabelaDesejada";
            this.lblTabelaDesejada.Size = new System.Drawing.Size(43, 13);
            this.lblTabelaDesejada.TabIndex = 35;
            this.lblTabelaDesejada.Text = "Tabela:";
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Location = new System.Drawing.Point(9, 35);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(50, 13);
            this.lblAlimento.TabIndex = 36;
            this.lblAlimento.Text = "Alimento:";
            // 
            // cbxTabelaAlimentos
            // 
            this.cbxTabelaAlimentos.FormattingEnabled = true;
            this.cbxTabelaAlimentos.Location = new System.Drawing.Point(85, 6);
            this.cbxTabelaAlimentos.Name = "cbxTabelaAlimentos";
            this.cbxTabelaAlimentos.Size = new System.Drawing.Size(397, 21);
            this.cbxTabelaAlimentos.TabIndex = 37;
            // 
            // frmBuscarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 466);
            this.Controls.Add(this.cbxTabelaAlimentos);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.lblTabelaDesejada);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtgCardápio);
            this.Controls.Add(this.btnProcurar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarAlimento";
            this.Text = "Buscar Alimento";
            this.Load += new System.EventHandler(this.frmBuscarAlimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardápio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgCardápio;
        internal System.Windows.Forms.Button btnProcurar;
        internal System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTabelaDesejada;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.ComboBox cbxTabelaAlimentos;
    }
}