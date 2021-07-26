
namespace TCC2.Telas
{
    partial class frmEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueciSenha));
            this.mTxtEmailRecuperar = new MaterialSkin.Controls.MaterialTextBox();
            this.mBtnRecuperar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // mTxtEmailRecuperar
            // 
            this.mTxtEmailRecuperar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtEmailRecuperar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtEmailRecuperar.Depth = 0;
            this.mTxtEmailRecuperar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtEmailRecuperar.Hint = "Digite seu usuário";
            this.mTxtEmailRecuperar.LeadingIcon = null;
            this.mTxtEmailRecuperar.Location = new System.Drawing.Point(8, 174);
            this.mTxtEmailRecuperar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTxtEmailRecuperar.MaxLength = 50;
            this.mTxtEmailRecuperar.MouseState = MaterialSkin.MouseState.OUT;
            this.mTxtEmailRecuperar.Multiline = false;
            this.mTxtEmailRecuperar.Name = "mTxtEmailRecuperar";
            this.mTxtEmailRecuperar.Size = new System.Drawing.Size(504, 50);
            this.mTxtEmailRecuperar.TabIndex = 0;
            this.mTxtEmailRecuperar.Text = "";
            this.mTxtEmailRecuperar.TrailingIcon = null;
            // 
            // mBtnRecuperar
            // 
            this.mBtnRecuperar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnRecuperar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtnRecuperar.Depth = 0;
            this.mBtnRecuperar.HighEmphasis = true;
            this.mBtnRecuperar.Icon = null;
            this.mBtnRecuperar.Location = new System.Drawing.Point(183, 306);
            this.mBtnRecuperar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.mBtnRecuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnRecuperar.Name = "mBtnRecuperar";
            this.mBtnRecuperar.Size = new System.Drawing.Size(104, 36);
            this.mBtnRecuperar.TabIndex = 1;
            this.mBtnRecuperar.Text = "Recuperar";
            this.mBtnRecuperar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtnRecuperar.UseAccentColor = false;
            this.mBtnRecuperar.UseVisualStyleBackColor = true;
            this.mBtnRecuperar.Click += new System.EventHandler(this.mBtnRecuperar_Click);
            // 
            // frmEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 412);
            this.Controls.Add(this.mBtnRecuperar);
            this.Controls.Add(this.mTxtEmailRecuperar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEsqueciSenha";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci minha senha";
            this.Load += new System.EventHandler(this.frmEsqueciSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mTxtEmailRecuperar;
        private MaterialSkin.Controls.MaterialButton mBtnRecuperar;
    }
}