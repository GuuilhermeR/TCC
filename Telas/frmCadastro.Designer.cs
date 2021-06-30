
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
            this.mTxtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.mLblUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.mLblSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.mLblEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.mBtnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.mchkNutricionista = new MaterialSkin.Controls.MaterialRadioButton();
            this.mchkEstudante = new MaterialSkin.Controls.MaterialRadioButton();
            this.mtxtCRN = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // mTxtNome
            // 
            this.mTxtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtNome.Depth = 0;
            this.mTxtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtNome.Hint = "Nome Completo";
            this.mTxtNome.LeadingIcon = null;
            this.mTxtNome.Location = new System.Drawing.Point(71, 95);
            this.mTxtNome.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtNome.MaxLength = 50;
            this.mTxtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.mTxtNome.Multiline = false;
            this.mTxtNome.Name = "mTxtNome";
            this.mTxtNome.Size = new System.Drawing.Size(307, 50);
            this.mTxtNome.TabIndex = 0;
            this.mTxtNome.Text = "";
            this.mTxtNome.TrailingIcon = null;
            // 
            // mLblUsuario
            // 
            this.mLblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblUsuario.Depth = 0;
            this.mLblUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLblUsuario.Hint = "Usuário";
            this.mLblUsuario.LeadingIcon = null;
            this.mLblUsuario.Location = new System.Drawing.Point(71, 167);
            this.mLblUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.mLblUsuario.MaxLength = 50;
            this.mLblUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblUsuario.Multiline = false;
            this.mLblUsuario.Name = "mLblUsuario";
            this.mLblUsuario.Size = new System.Drawing.Size(307, 50);
            this.mLblUsuario.TabIndex = 1;
            this.mLblUsuario.Text = "";
            this.mLblUsuario.TrailingIcon = null;
            this.mLblUsuario.Leave += new System.EventHandler(this.mLblUsuario_Leave);
            // 
            // mLblSenha
            // 
            this.mLblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblSenha.Depth = 0;
            this.mLblSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLblSenha.Hint = "Senha";
            this.mLblSenha.LeadingIcon = null;
            this.mLblSenha.Location = new System.Drawing.Point(71, 247);
            this.mLblSenha.Margin = new System.Windows.Forms.Padding(2);
            this.mLblSenha.MaxLength = 50;
            this.mLblSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblSenha.Multiline = false;
            this.mLblSenha.Name = "mLblSenha";
            this.mLblSenha.Password = true;
            this.mLblSenha.Size = new System.Drawing.Size(307, 50);
            this.mLblSenha.TabIndex = 2;
            this.mLblSenha.Text = "";
            this.mLblSenha.TrailingIcon = null;
            // 
            // mLblEmail
            // 
            this.mLblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mLblEmail.Depth = 0;
            this.mLblEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLblEmail.Hint = "E-mail";
            this.mLblEmail.LeadingIcon = null;
            this.mLblEmail.Location = new System.Drawing.Point(71, 330);
            this.mLblEmail.Margin = new System.Windows.Forms.Padding(2);
            this.mLblEmail.MaxLength = 50;
            this.mLblEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.mLblEmail.Multiline = false;
            this.mLblEmail.Name = "mLblEmail";
            this.mLblEmail.Size = new System.Drawing.Size(307, 50);
            this.mLblEmail.TabIndex = 3;
            this.mLblEmail.Text = "";
            this.mLblEmail.TrailingIcon = null;
            // 
            // mBtnCadastrar
            // 
            this.mBtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtnCadastrar.Depth = 0;
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
            this.mBtnCadastrar.Click += new System.EventHandler(this.mBtnCadastrar_Click);
            // 
            // mchkNutricionista
            // 
            this.mchkNutricionista.AutoSize = true;
            this.mchkNutricionista.Depth = 0;
            this.mchkNutricionista.Location = new System.Drawing.Point(140, 389);
            this.mchkNutricionista.Margin = new System.Windows.Forms.Padding(0);
            this.mchkNutricionista.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkNutricionista.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkNutricionista.Name = "mchkNutricionista";
            this.mchkNutricionista.Ripple = true;
            this.mchkNutricionista.Size = new System.Drawing.Size(125, 37);
            this.mchkNutricionista.TabIndex = 5;
            this.mchkNutricionista.TabStop = true;
            this.mchkNutricionista.Text = "Nutricionista";
            this.mchkNutricionista.UseVisualStyleBackColor = true;
            this.mchkNutricionista.CheckedChanged += new System.EventHandler(this.mchkNutricionista_CheckedChanged);
            // 
            // mchkEstudante
            // 
            this.mchkEstudante.AutoSize = true;
            this.mchkEstudante.Depth = 0;
            this.mchkEstudante.Location = new System.Drawing.Point(140, 435);
            this.mchkEstudante.Margin = new System.Windows.Forms.Padding(0);
            this.mchkEstudante.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkEstudante.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkEstudante.Name = "mchkEstudante";
            this.mchkEstudante.Ripple = true;
            this.mchkEstudante.Size = new System.Drawing.Size(106, 37);
            this.mchkEstudante.TabIndex = 6;
            this.mchkEstudante.TabStop = true;
            this.mchkEstudante.Text = "Estudante";
            this.mchkEstudante.UseVisualStyleBackColor = true;
            this.mchkEstudante.CheckedChanged += new System.EventHandler(this.mchkEstudante_CheckedChanged);
            // 
            // mtxtCRN
            // 
            this.mtxtCRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtCRN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCRN.Depth = 0;
            this.mtxtCRN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtCRN.Hint = "CRN";
            this.mtxtCRN.LeadingIcon = null;
            this.mtxtCRN.Location = new System.Drawing.Point(71, 477);
            this.mtxtCRN.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCRN.MaxLength = 50;
            this.mtxtCRN.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtCRN.Multiline = false;
            this.mtxtCRN.Name = "mtxtCRN";
            this.mtxtCRN.Size = new System.Drawing.Size(307, 50);
            this.mtxtCRN.TabIndex = 7;
            this.mtxtCRN.Text = "";
            this.mtxtCRN.TrailingIcon = null;
            this.mtxtCRN.Visible = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 594);
            this.Controls.Add(this.mtxtCRN);
            this.Controls.Add(this.mchkEstudante);
            this.Controls.Add(this.mchkNutricionista);
            this.Controls.Add(this.mBtnCadastrar);
            this.Controls.Add(this.mLblEmail);
            this.Controls.Add(this.mLblSenha);
            this.Controls.Add(this.mLblUsuario);
            this.Controls.Add(this.mTxtNome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastro";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mTxtNome;
        private MaterialSkin.Controls.MaterialTextBox mLblUsuario;
        private MaterialSkin.Controls.MaterialTextBox mLblSenha;
        private MaterialSkin.Controls.MaterialTextBox mLblEmail;
        private MaterialSkin.Controls.MaterialButton mBtnCadastrar;
        private MaterialSkin.Controls.MaterialRadioButton mchkNutricionista;
        private MaterialSkin.Controls.MaterialRadioButton mchkEstudante;
        private MaterialSkin.Controls.MaterialTextBox mtxtCRN;
    }
}