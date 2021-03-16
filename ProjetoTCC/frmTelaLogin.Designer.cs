using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmTelaLogin : MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblLoginErrado = new System.Windows.Forms.Label();
            this.pbxLogoGrande = new System.Windows.Forms.PictureBox();
            this._btnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this._txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this._txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel1.Location = new System.Drawing.Point(12, 515);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(108, 13);
            this.LinkLabel1.TabIndex = 3;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Esqueci minha senha";
            // 
            // lblLoginErrado
            // 
            this.lblLoginErrado.AutoSize = true;
            this.lblLoginErrado.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginErrado.ForeColor = System.Drawing.Color.Red;
            this.lblLoginErrado.Location = new System.Drawing.Point(183, 390);
            this.lblLoginErrado.Name = "lblLoginErrado";
            this.lblLoginErrado.Size = new System.Drawing.Size(123, 13);
            this.lblLoginErrado.TabIndex = 4;
            this.lblLoginErrado.Text = "Usuário/Senha incorreto";
            this.lblLoginErrado.Visible = false;
            // 
            // pbxLogoGrande
            // 
            this.pbxLogoGrande.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoGrande.Image = global::ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            this.pbxLogoGrande.Location = new System.Drawing.Point(121, 83);
            this.pbxLogoGrande.Name = "pbxLogoGrande";
            this.pbxLogoGrande.Size = new System.Drawing.Size(275, 180);
            this.pbxLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoGrande.TabIndex = 7;
            this.pbxLogoGrande.TabStop = false;
            // 
            // _btnLogin
            // 
            this._btnLogin.AutoSize = true;
            this._btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._btnLogin.BackColor = System.Drawing.Color.Transparent;
            this._btnLogin.Depth = 0;
            this._btnLogin.Location = new System.Drawing.Point(217, 437);
            this._btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Primary = false;
            this._btnLogin.Size = new System.Drawing.Size(64, 36);
            this._btnLogin.TabIndex = 2;
            this._btnLogin.Text = "Entrar";
            this._btnLogin.UseVisualStyleBackColor = false;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // _txtLogin
            // 
            this._txtLogin.Depth = 0;
            this._txtLogin.Hint = "Usuário";
            this._txtLogin.Location = new System.Drawing.Point(115, 300);
            this._txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this._txtLogin.Name = "_txtLogin";
            this._txtLogin.PasswordChar = '\0';
            this._txtLogin.SelectedText = "";
            this._txtLogin.SelectionLength = 0;
            this._txtLogin.SelectionStart = 0;
            this._txtLogin.Size = new System.Drawing.Size(281, 23);
            this._txtLogin.TabIndex = 0;
            this._txtLogin.Tag = "";
            this._txtLogin.UseSystemPasswordChar = false;
            // 
            // _txtSenha
            // 
            this._txtSenha.Depth = 0;
            this._txtSenha.Hint = "Senha";
            this._txtSenha.Location = new System.Drawing.Point(115, 350);
            this._txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this._txtSenha.Name = "_txtSenha";
            this._txtSenha.PasswordChar = '\0';
            this._txtSenha.SelectedText = "";
            this._txtSenha.SelectionLength = 0;
            this._txtSenha.SelectionStart = 0;
            this._txtSenha.Size = new System.Drawing.Size(281, 23);
            this._txtSenha.TabIndex = 1;
            this._txtSenha.UseSystemPasswordChar = false;
            this._txtSenha.Enter += new System.EventHandler(this._txtSenha_Enter);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 493);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(499, 2);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(517, 583);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this._txtSenha);
            this.Controls.Add(this._txtLogin);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this.lblLoginErrado);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.pbxLogoGrande);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmTelaLogin_Load);
            this.Resize += new System.EventHandler(this.frmTelaLogin_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal PictureBox pbxLogoGrande;
        internal LinkLabel LinkLabel1;
        internal Label lblLoginErrado;
        private MaterialFlatButton _btnLogin;
        private MaterialSingleLineTextField _txtLogin;
        private MaterialSingleLineTextField _txtSenha;
        private MaterialDivider materialDivider1;
    }
}