
namespace TCC2.Telas
{
    partial class frmCadastro
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
            this.mLblNome = new MaterialSkin.Controls.MaterialTextBox();
            this.mLblUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.mLblSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.mLblEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.mBtnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // mLblNome
            // 
            this.mLblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblNome.Depth = 0;
            this.mLblNome.Font = new System.Drawing.Font("Roboto", 12F);
            this.mLblNome.Hint = "Nome Completo";
            this.mLblNome.Location = new System.Drawing.Point(95, 117);
            this.mLblNome.MaxLength = 50;
            this.mLblNome.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblNome.Multiline = false;
            this.mLblNome.Name = "mLblNome";
            this.mLblNome.Size = new System.Drawing.Size(409, 50);
            this.mLblNome.TabIndex = 0;
            this.mLblNome.Text = "";
            // 
            // mLblUsuario
            // 
            this.mLblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblUsuario.Depth = 0;
            this.mLblUsuario.Font = new System.Drawing.Font("Roboto", 12F);
            this.mLblUsuario.Hint = "Usuário";
            this.mLblUsuario.Location = new System.Drawing.Point(95, 227);
            this.mLblUsuario.MaxLength = 50;
            this.mLblUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblUsuario.Multiline = false;
            this.mLblUsuario.Name = "mLblUsuario";
            this.mLblUsuario.Size = new System.Drawing.Size(409, 50);
            this.mLblUsuario.TabIndex = 1;
            this.mLblUsuario.Text = "";
            // 
            // mLblSenha
            // 
            this.mLblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblSenha.Depth = 0;
            this.mLblSenha.Font = new System.Drawing.Font("Roboto", 12F);
            this.mLblSenha.Hint = "Senha";
            this.mLblSenha.Location = new System.Drawing.Point(95, 340);
            this.mLblSenha.MaxLength = 50;
            this.mLblSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblSenha.Multiline = false;
            this.mLblSenha.Name = "mLblSenha";
            this.mLblSenha.Password = true;
            this.mLblSenha.Size = new System.Drawing.Size(409, 50);
            this.mLblSenha.TabIndex = 2;
            this.mLblSenha.Text = "";
            // 
            // mLblEmail
            // 
            this.mLblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblEmail.Depth = 0;
            this.mLblEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.mLblEmail.Hint = "E-mail";
            this.mLblEmail.Location = new System.Drawing.Point(95, 461);
            this.mLblEmail.MaxLength = 50;
            this.mLblEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblEmail.Multiline = false;
            this.mLblEmail.Name = "mLblEmail";
            this.mLblEmail.Size = new System.Drawing.Size(409, 50);
            this.mLblEmail.TabIndex = 3;
            this.mLblEmail.Text = "";
            // 
            // mBtnCadastrar
            // 
            this.mBtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnCadastrar.Depth = 0;
            this.mBtnCadastrar.DrawShadows = true;
            this.mBtnCadastrar.HighEmphasis = true;
            this.mBtnCadastrar.Icon = null;
            this.mBtnCadastrar.Location = new System.Drawing.Point(227, 561);
            this.mBtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCadastrar.Name = "mBtnCadastrar";
            this.mBtnCadastrar.Size = new System.Drawing.Size(106, 36);
            this.mBtnCadastrar.TabIndex = 4;
            this.mBtnCadastrar.Text = "Cadastrar";
            this.mBtnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtnCadastrar.UseAccentColor = false;
            this.mBtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 642);
            this.Controls.Add(this.mBtnCadastrar);
            this.Controls.Add(this.mLblEmail);
            this.Controls.Add(this.mLblSenha);
            this.Controls.Add(this.mLblUsuario);
            this.Controls.Add(this.mLblNome);
            this.Name = "frmCadastro";
            this.Text = "Cadastro Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mLblNome;
        private MaterialSkin.Controls.MaterialTextBox mLblUsuario;
        private MaterialSkin.Controls.MaterialTextBox mLblSenha;
        private MaterialSkin.Controls.MaterialTextBox mLblEmail;
        private MaterialSkin.Controls.MaterialButton mBtnCadastrar;
    }
}