using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmAgenda : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            lvAgendamento = new ListView();
            btnVoltar = new Button();
            btnAvançar = new Button();
            SuspendLayout();
            // 
            // lvAgendamento
            // 
            lvAgendamento.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lvAgendamento.HideSelection = false;
            lvAgendamento.Location = new Point(12, 35);
            lvAgendamento.Name = "lvAgendamento";
            lvAgendamento.Size = new Size(488, 613);
            lvAgendamento.TabIndex = 0;
            lvAgendamento.UseCompatibleStateImageBehavior = false;
            lvAgendamento.View = View.Details;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 6);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAvançar
            // 
            btnAvançar.Location = new Point(425, 6);
            btnAvançar.Name = "btnAvançar";
            btnAvançar.Size = new Size(75, 23);
            btnAvançar.TabIndex = 2;
            btnAvançar.Text = "Avançar";
            btnAvançar.UseVisualStyleBackColor = true;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 660);
            Controls.Add(btnAvançar);
            Controls.Add(btnVoltar);
            Controls.Add(lvAgendamento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgenda";
            Text = "frmAgenda";
            Load += new EventHandler(frmAgenda_Load);
            ResumeLayout(false);
        }

        internal ListView lvAgendamento;
        internal Button btnVoltar;
        internal Button btnAvançar;
    }
}