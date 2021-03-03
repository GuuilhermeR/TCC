using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmBuscarPaciente : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPaciente));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgCardápio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardápio)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 12);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(397, 20);
            this.TextBox1.TabIndex = 28;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(415, 10);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 23);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dtgCardápio
            // 
            this.dtgCardápio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCardápio.BackgroundColor = System.Drawing.Color.White;
            this.dtgCardápio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCardápio.Location = new System.Drawing.Point(12, 39);
            this.dtgCardápio.Name = "dtgCardápio";
            this.dtgCardápio.Size = new System.Drawing.Size(495, 399);
            this.dtgCardápio.TabIndex = 30;
            // 
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.dtgCardápio);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.TextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarPaciente";
            this.Text = "Buscar Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardápio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal TextBox TextBox1;
        internal Button btnConsultar;
        internal DataGridView dtgCardápio;
    }
}