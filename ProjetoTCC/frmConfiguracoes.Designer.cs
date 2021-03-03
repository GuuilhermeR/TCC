using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmConfiguracoes : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            TabPage2 = new TabPage();
            DataGridView1 = new DataGridView();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Location = new Point(6, 4);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(777, 524);
            TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(DataGridView1);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(769, 498);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Usuários";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(769, 498);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Permissões";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            DataGridView1.BackgroundColor = SystemColors.Control;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(6, 207);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(757, 285);
            DataGridView1.TabIndex = 0;
            // 
            // frmConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(96.0f, 96.0f);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(787, 530);
            Controls.Add(TabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConfiguracoes";
            Text = "Configurações";
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
        }

        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal DataGridView DataGridView1;
        internal TabPage TabPage2;
    }
}