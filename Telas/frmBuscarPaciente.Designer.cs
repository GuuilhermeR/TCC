
namespace NutriEz
{
    partial class frmBuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPaciente));
            this.dtgPacientes = new System.Windows.Forms.DataGridView();
            this.colCodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPacientes
            // 
            this.dtgPacientes.AllowUserToAddRows = false;
            this.dtgPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPaciente,
            this.colNome,
            this.colIdade});
            this.dtgPacientes.Location = new System.Drawing.Point(4, 65);
            this.dtgPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.dtgPacientes.Name = "dtgPacientes";
            this.dtgPacientes.ReadOnly = true;
            this.dtgPacientes.RowHeadersWidth = 51;
            this.dtgPacientes.RowTemplate.Height = 24;
            this.dtgPacientes.Size = new System.Drawing.Size(467, 359);
            this.dtgPacientes.TabIndex = 0;
            this.dtgPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPacientes_CellDoubleClick);
            // 
            // colCodPaciente
            // 
            this.colCodPaciente.HeaderText = "codPaciente";
            this.colCodPaciente.Name = "colCodPaciente";
            this.colCodPaciente.ReadOnly = true;
            this.colCodPaciente.Visible = false;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colIdade
            // 
            this.colIdade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIdade.HeaderText = "Idade";
            this.colIdade.Name = "colIdade";
            this.colIdade.ReadOnly = true;
            // 
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 426);
            this.Controls.Add(this.dtgPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBuscarPaciente";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes Cadastrados";
            this.Load += new System.EventHandler(this.frmBuscarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdade;
    }
}