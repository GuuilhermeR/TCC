
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
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
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
            this.mLblNome.Location = new System.Drawing.Point(71, 95);
            this.mLblNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mLblNome.MaxLength = 50;
            this.mLblNome.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblNome.Multiline = false;
            this.mLblNome.Name = "mLblNome";
            this.mLblNome.Size = new System.Drawing.Size(307, 50);
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
            this.mLblUsuario.Location = new System.Drawing.Point(71, 167);
            this.mLblUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mLblUsuario.MaxLength = 50;
            this.mLblUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblUsuario.Multiline = false;
            this.mLblUsuario.Name = "mLblUsuario";
            this.mLblUsuario.Size = new System.Drawing.Size(307, 50);
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
            this.mLblSenha.Location = new System.Drawing.Point(71, 247);
            this.mLblSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mLblSenha.MaxLength = 50;
            this.mLblSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblSenha.Multiline = false;
            this.mLblSenha.Name = "mLblSenha";
            this.mLblSenha.Password = true;
            this.mLblSenha.Size = new System.Drawing.Size(307, 50);
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
            this.mLblEmail.Location = new System.Drawing.Point(71, 330);
            this.mLblEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mLblEmail.MaxLength = 50;
            this.mLblEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblEmail.Multiline = false;
            this.mLblEmail.Name = "mLblEmail";
            this.mLblEmail.Size = new System.Drawing.Size(307, 50);
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
            this.mBtnCadastrar.Location = new System.Drawing.Point(159, 542);
            this.mBtnCadastrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mBtnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCadastrar.Name = "mBtnCadastrar";
            this.mBtnCadastrar.Size = new System.Drawing.Size(106, 36);
            this.mBtnCadastrar.TabIndex = 4;
            this.mBtnCadastrar.Text = "Cadastrar";
            this.mBtnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtnCadastrar.UseAccentColor = false;
            this.mBtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(140, 389);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(125, 37);
            this.materialRadioButton1.TabIndex = 5;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Nutricionista";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(140, 435);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(106, 37);
            this.materialRadioButton2.TabIndex = 6;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Estudante";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Hint = "CRN";
            this.materialTextBox1.Location = new System.Drawing.Point(71, 477);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(307, 50);
            this.materialTextBox1.TabIndex = 7;
            this.materialTextBox1.Text = "";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 594);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.mBtnCadastrar);
            this.Controls.Add(this.mLblEmail);
            this.Controls.Add(this.mLblSenha);
            this.Controls.Add(this.mLblUsuario);
            this.Controls.Add(this.mLblNome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCadastro";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}