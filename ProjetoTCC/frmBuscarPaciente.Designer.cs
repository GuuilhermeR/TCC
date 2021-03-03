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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPaciente));
            TextBox1 = new TextBox();
            Button1 = new Button();
            dtgCardápio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgCardápio).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(12, 12);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(397, 20);
            TextBox1.TabIndex = 28;
            // 
            // Button1
            // 
            Button1.Location = new Point(415, 10);
            Button1.Name = "Button1";
            Button1.Size = new Size(95, 23);
            Button1.TabIndex = 29;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // dtgCardápio
            // 
            dtgCardápio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtgCardápio.BackgroundColor = Color.White;
            dtgCardápio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCardápio.Location = new Point(12, 39);
            dtgCardápio.Name = "dtgCardápio";
            dtgCardápio.Size = new Size(495, 399);
            dtgCardápio.TabIndex = 30;
            // 
            // frmBuscarPaciente
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(dtgCardápio);
            Controls.Add(Button1);
            Controls.Add(TextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBuscarPaciente";
            Text = "Buscar Pacientes";
            ((System.ComponentModel.ISupportInitialize)dtgCardápio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox TextBox1;
        internal Button Button1;
        internal DataGridView dtgCardápio;
    }
}