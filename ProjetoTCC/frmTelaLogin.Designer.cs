using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmTelaLogin : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            _txtLogin = new TextBox();
            _txtLogin.Leave += new EventHandler(txtLogin_Leave);
            _txtSenha = new TextBox();
            _txtSenha.Enter += new EventHandler(txtSenha_Enter);
            lblUsuário = new Label();
            lblSenha = new Label();
            LinkLabel1 = new LinkLabel();
            _btnLogin = new Button();
            _btnLogin.Click += new EventHandler(btnLogin_Click);
            lblLoginErrado = new Label();
            pbxLogoGrande = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogoGrande).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            _txtLogin.Location = new Point(60, 230);
            _txtLogin.Name = "_txtLogin";
            _txtLogin.Size = new Size(243, 20);
            _txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            _txtSenha.Location = new Point(60, 292);
            _txtSenha.Name = "_txtSenha";
            _txtSenha.Size = new Size(243, 20);
            _txtSenha.TabIndex = 1;
            // 
            // lblUsuário
            // 
            lblUsuário.AutoSize = true;
            lblUsuário.Location = new Point(154, 214);
            lblUsuário.Name = "lblUsuário";
            lblUsuário.Size = new Size(43, 13);
            lblUsuário.TabIndex = 6;
            lblUsuário.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(154, 276);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(38, 13);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(120, 358);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(108, 13);
            LinkLabel1.TabIndex = 3;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Esqueci minha senha";
            // 
            // btnLogin
            // 
            _btnLogin.Location = new Point(123, 395);
            _btnLogin.Name = "_btnLogin";
            _btnLogin.Size = new Size(105, 32);
            _btnLogin.TabIndex = 2;
            _btnLogin.Text = "Entrar";
            _btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblLoginErrado
            // 
            lblLoginErrado.AutoSize = true;
            lblLoginErrado.ForeColor = Color.Red;
            lblLoginErrado.Location = new Point(120, 339);
            lblLoginErrado.Name = "lblLoginErrado";
            lblLoginErrado.Size = new Size(123, 13);
            lblLoginErrado.TabIndex = 4;
            lblLoginErrado.Text = "Usuário/Senha incorreto";
            lblLoginErrado.Visible = false;
            // 
            // pbxLogoGrande
            // 
            pbxLogoGrande.Image = My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            pbxLogoGrande.Location = new Point(12, 12);
            pbxLogoGrande.Name = "pbxLogoGrande";
            pbxLogoGrande.Size = new Size(343, 167);
            pbxLogoGrande.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogoGrande.TabIndex = 7;
            pbxLogoGrande.TabStop = false;
            // 
            // frmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 439);
            Controls.Add(lblLoginErrado);
            Controls.Add(_btnLogin);
            Controls.Add(LinkLabel1);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuário);
            Controls.Add(_txtSenha);
            Controls.Add(_txtLogin);
            Controls.Add(pbxLogoGrande);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTelaLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbxLogoGrande).EndInit();
            Load += new EventHandler(frmTelaLogin_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox pbxLogoGrande;
        private TextBox _txtLogin;

        internal TextBox txtLogin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLogin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLogin != null)
                {
                    _txtLogin.Leave -= txtLogin_Leave;
                }

                _txtLogin = value;
                if (_txtLogin != null)
                {
                    _txtLogin.Leave += txtLogin_Leave;
                }
            }
        }

        private TextBox _txtSenha;

        internal TextBox txtSenha
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSenha;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSenha != null)
                {
                    _txtSenha.Enter -= txtSenha_Enter;
                }

                _txtSenha = value;
                if (_txtSenha != null)
                {
                    _txtSenha.Enter += txtSenha_Enter;
                }
            }
        }

        internal Label lblUsuário;
        internal Label lblSenha;
        internal LinkLabel LinkLabel1;
        private Button _btnLogin;

        internal Button btnLogin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnLogin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnLogin != null)
                {
                    _btnLogin.Click -= btnLogin_Click;
                }

                _btnLogin = value;
                if (_btnLogin != null)
                {
                    _btnLogin.Click += btnLogin_Click;
                }
            }
        }

        internal Label lblLoginErrado;
    }
}