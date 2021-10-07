
namespace TCC2
{
    partial class frmTelaLogin
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.btnLogar = new MaterialSkin.Controls.MaterialButton();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAviso = new MaterialSkin.Controls.MaterialLabel();
            this.mLblCriarConta = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mLblEsqueciSenha = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogar.Depth = 0;
            this.btnLogar.HighEmphasis = true;
            this.btnLogar.Icon = null;
            this.btnLogar.Location = new System.Drawing.Point(176, 457);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(77, 36);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogar.UseAccentColor = false;
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Usuário";
            this.txtUsuario.LeadingIcon = global::TCC2.Properties.Resources._4105938_account_card_id_identification_identity_card_profile_user_profile_113929;
            this.txtUsuario.Location = new System.Drawing.Point(71, 316);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(303, 50);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Tag = "";
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Red;
            this.lblAviso.Depth = 0;
            this.lblAviso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAviso.Location = new System.Drawing.Point(164, 275);
            this.lblAviso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(107, 19);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "materialLabel1";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAviso.Visible = false;
            // 
            // mLblCriarConta
            // 
            this.mLblCriarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblCriarConta.AutoSize = true;
            this.mLblCriarConta.BackColor = System.Drawing.SystemColors.Desktop;
            this.mLblCriarConta.Depth = 0;
            this.mLblCriarConta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLblCriarConta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mLblCriarConta.Location = new System.Drawing.Point(300, 544);
            this.mLblCriarConta.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLblCriarConta.Name = "mLblCriarConta";
            this.mLblCriarConta.Size = new System.Drawing.Size(64, 19);
            this.mLblCriarConta.TabIndex = 4;
            this.mLblCriarConta.Text = "Registrar";
            this.mLblCriarConta.Click += new System.EventHandler(this.mLblCriarConta_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(27, 518);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(386, 1);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mLblEsqueciSenha
            // 
            this.mLblEsqueciSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblEsqueciSenha.AutoSize = true;
            this.mLblEsqueciSenha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mLblEsqueciSenha.Depth = 0;
            this.mLblEsqueciSenha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLblEsqueciSenha.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mLblEsqueciSenha.Location = new System.Drawing.Point(35, 544);
            this.mLblEsqueciSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLblEsqueciSenha.Name = "mLblEsqueciSenha";
            this.mLblEsqueciSenha.Size = new System.Drawing.Size(152, 19);
            this.mLblEsqueciSenha.TabIndex = 3;
            this.mLblEsqueciSenha.Text = "Esqueci minha senha";
            this.mLblEsqueciSenha.Click += new System.EventHandler(this.mLblEsqueciSenha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC2.Properties.Resources.iconTCC_removebg_preview__1____Copia;
            this.pictureBox1.Location = new System.Drawing.Point(113, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = global::TCC2.Properties.Resources._4105941_lock_login_password_security_sign_in_sign_out_113932;
            this.txtSenha.Location = new System.Drawing.Point(71, 387);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Password = true;
            this.txtSenha.Size = new System.Drawing.Size(303, 50);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 584);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.mLblEsqueciSenha);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mLblCriarConta);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.frmTelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLogar;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblAviso;
        private MaterialSkin.Controls.MaterialLabel mLblCriarConta;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel mLblEsqueciSenha;
        public MaterialSkin.Controls.MaterialTextBox txtSenha;
    }
}