﻿
namespace TCC2.Telas
{
    partial class frmWait
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWait));
            this.pgbProgresso = new System.Windows.Forms.ProgressBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbProgresso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pgbProgresso.Location = new System.Drawing.Point(12, 16);
            this.pgbProgresso.MarqueeAnimationSpeed = 25;
            this.pgbProgresso.Maximum = 10;
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Size = new System.Drawing.Size(226, 17);
            this.pgbProgresso.Step = 5;
            this.pgbProgresso.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(50, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(155, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Aguarde... Carregando dados...";
            // 
            // frmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 76);
            this.Controls.Add(this.pgbProgresso);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar pgbProgresso;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
    }
}