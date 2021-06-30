
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.btnLogar = new MaterialSkin.Controls.MaterialButton();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAviso = new MaterialSkin.Controls.MaterialLabel();
            this.mLblCriarConta = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.btnLogar.Location = new System.Drawing.Point(179, 467);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(77, 36);
            this.btnLogar.TabIndex = 0;
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
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(71, 284);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(303, 50);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Tag = "";
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(71, 353);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Password = true;
            this.txtSenha.Size = new System.Drawing.Size(303, 50);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
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
            // lblAviso
            // 
            this.lblAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Red;
            this.lblAviso.Depth = 0;
            this.lblAviso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAviso.Location = new System.Drawing.Point(149, 418);
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
            this.mLblCriarConta.TabIndex = 5;
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
            this.materialDivider1.Size = new System.Drawing.Size(386, 3);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 544);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Esqueci minha senha";
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 584);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mLblCriarConta);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLogin";
            this.Padding = new System.Windows.Forms.Padding(3);
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
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblAviso;
        private MaterialSkin.Controls.MaterialLabel mLblCriarConta;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}