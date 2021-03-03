using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmMenuPrincipal : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            pnlBotoes = new Panel();
            _BtnPacientes = new Button();
            _BtnPacientes.Click += new EventHandler(BtnPacientes_Click);
            _btnDeslogar = new Button();
            _btnDeslogar.Click += new EventHandler(btnDeslogar_Click);
            btnFinanceiro = new Button();
            _btnAgenda = new Button();
            _btnAgenda.Click += new EventHandler(btnAgenda_Click);
            _btnOcultar = new Button();
            _btnOcultar.Click += new EventHandler(btnOcultar_Click);
            _btnConfig = new Button();
            _btnConfig.Click += new EventHandler(btnConfig_Click);
            _btnCadAlimento = new Button();
            _btnCadAlimento.Click += new EventHandler(btnCadastrarAlimento_Click);
            pbLogo = new PictureBox();
            _btnCadCardapio = new Button();
            _btnCadCardapio.Click += new EventHandler(btnCadCardapio_Click);
            pnlLogo = new PictureBox();
            lblNomeApp = new Label();
            lblUsuario = new Label();
            pbxLogoGrande = new PictureBox();
            _btnMostrar = new Button();
            _btnMostrar.Click += new EventHandler(btnMostrar_Click);
            pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoGrande).BeginInit();
            SuspendLayout();
            // 
            // pnlBotoes
            // 
            pnlBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBotoes.BackColor = Color.SpringGreen;
            pnlBotoes.Controls.Add(_BtnPacientes);
            pnlBotoes.Controls.Add(_btnDeslogar);
            pnlBotoes.Controls.Add(btnFinanceiro);
            pnlBotoes.Controls.Add(_btnAgenda);
            pnlBotoes.Controls.Add(_btnOcultar);
            pnlBotoes.Controls.Add(_btnConfig);
            pnlBotoes.Controls.Add(_btnCadAlimento);
            pnlBotoes.Controls.Add(pbLogo);
            pnlBotoes.Controls.Add(_btnCadCardapio);
            pnlBotoes.Controls.Add(pnlLogo);
            pnlBotoes.Location = new Point(6, 5);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(234, 616);
            pnlBotoes.TabIndex = 5;
            // 
            // BtnPacientes
            // 
            _BtnPacientes.BackColor = Color.MediumSeaGreen;
            _BtnPacientes.FlatAppearance.BorderSize = 0;
            _BtnPacientes.FlatStyle = FlatStyle.Flat;
            _BtnPacientes.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BtnPacientes.ForeColor = Color.Black;
            _BtnPacientes.Location = new Point(12, 334);
            _BtnPacientes.Name = "_BtnPacientes";
            _BtnPacientes.Size = new Size(208, 41);
            _BtnPacientes.TabIndex = 10;
            _BtnPacientes.Text = "Pacientes";
            _BtnPacientes.UseVisualStyleBackColor = false;
            // 
            // btnDeslogar
            // 
            _btnDeslogar.BackColor = Color.MediumSeaGreen;
            _btnDeslogar.FlatAppearance.BorderSize = 0;
            _btnDeslogar.FlatStyle = FlatStyle.Flat;
            _btnDeslogar.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDeslogar.ForeColor = Color.Black;
            _btnDeslogar.Location = new Point(12, 566);
            _btnDeslogar.Name = "_btnDeslogar";
            _btnDeslogar.Size = new Size(208, 41);
            _btnDeslogar.TabIndex = 10;
            _btnDeslogar.Text = "Sair e fechar";
            _btnDeslogar.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnDeslogar.UseVisualStyleBackColor = false;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.BackColor = Color.MediumSeaGreen;
            btnFinanceiro.FlatAppearance.BorderSize = 0;
            btnFinanceiro.FlatStyle = FlatStyle.Flat;
            btnFinanceiro.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            btnFinanceiro.ForeColor = Color.Black;
            btnFinanceiro.Location = new Point(12, 287);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(208, 41);
            btnFinanceiro.TabIndex = 9;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = false;
            // 
            // btnAgenda
            // 
            _btnAgenda.BackColor = Color.MediumSeaGreen;
            _btnAgenda.FlatAppearance.BorderSize = 0;
            _btnAgenda.FlatStyle = FlatStyle.Flat;
            _btnAgenda.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAgenda.ForeColor = Color.Black;
            _btnAgenda.Location = new Point(12, 146);
            _btnAgenda.Name = "_btnAgenda";
            _btnAgenda.Size = new Size(208, 41);
            _btnAgenda.TabIndex = 8;
            _btnAgenda.Text = "Agenda";
            _btnAgenda.UseVisualStyleBackColor = false;
            // 
            // btnOcultar
            // 
            _btnOcultar.BackColor = Color.Transparent;
            _btnOcultar.FlatAppearance.BorderSize = 0;
            _btnOcultar.FlatStyle = FlatStyle.Flat;
            _btnOcultar.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnOcultar.ForeColor = Color.Black;
            _btnOcultar.Image = My.Resources.Resources.baixados_removebg_preview__1_;
            _btnOcultar.Location = new Point(3, 0);
            _btnOcultar.Name = "_btnOcultar";
            _btnOcultar.Size = new Size(40, 40);
            _btnOcultar.TabIndex = 7;
            _btnOcultar.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            _btnConfig.BackColor = Color.MediumSeaGreen;
            _btnConfig.FlatAppearance.BorderSize = 0;
            _btnConfig.FlatStyle = FlatStyle.Flat;
            _btnConfig.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnConfig.ForeColor = Color.Black;
            _btnConfig.Location = new Point(12, 519);
            _btnConfig.Name = "_btnConfig";
            _btnConfig.Size = new Size(208, 41);
            _btnConfig.TabIndex = 6;
            _btnConfig.Text = "Configurações";
            _btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnCadAlimento
            // 
            _btnCadAlimento.BackColor = Color.MediumSeaGreen;
            _btnCadAlimento.FlatAppearance.BorderSize = 0;
            _btnCadAlimento.FlatStyle = FlatStyle.Flat;
            _btnCadAlimento.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCadAlimento.ForeColor = Color.Black;
            _btnCadAlimento.Location = new Point(12, 193);
            _btnCadAlimento.Name = "_btnCadAlimento";
            _btnCadAlimento.Size = new Size(208, 41);
            _btnCadAlimento.TabIndex = 2;
            _btnCadAlimento.Text = "Alimentos";
            _btnCadAlimento.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            pbLogo.Location = new Point(41, 18);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(144, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // btnCadCardapio
            // 
            _btnCadCardapio.BackColor = Color.MediumSeaGreen;
            _btnCadCardapio.FlatAppearance.BorderSize = 0;
            _btnCadCardapio.FlatStyle = FlatStyle.Flat;
            _btnCadCardapio.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCadCardapio.ForeColor = Color.Black;
            _btnCadCardapio.Location = new Point(12, 240);
            _btnCadCardapio.Name = "_btnCadCardapio";
            _btnCadCardapio.Size = new Size(208, 41);
            _btnCadCardapio.TabIndex = 4;
            _btnCadCardapio.Text = "Cardápio";
            _btnCadCardapio.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.Location = new Point(4, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(228, 136);
            pnlLogo.TabIndex = 0;
            pnlLogo.TabStop = false;
            // 
            // lblNomeApp
            // 
            lblNomeApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            lblNomeApp.AutoSize = true;
            lblNomeApp.Font = new Font("Yu Gothic UI Semibold", 24.0f, FontStyle.Bold);
            lblNomeApp.Location = new Point(467, 465);
            lblNomeApp.Name = "lblNomeApp";
            lblNomeApp.Size = new Size(152, 45);
            lblNomeApp.TabIndex = 7;
            lblNomeApp.Text = "Nutreasy";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Right;
            lblUsuario.Font = new Font("Yu Gothic UI Semibold", 10.0f, FontStyle.Bold);
            lblUsuario.Location = new Point(890, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(48, 19);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Label1";
            // 
            // pbxLogoGrande
            // 
            pbxLogoGrande.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            pbxLogoGrande.Image = My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            pbxLogoGrande.Location = new Point(385, 120);
            pbxLogoGrande.Name = "pbxLogoGrande";
            pbxLogoGrande.Size = new Size(332, 308);
            pbxLogoGrande.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogoGrande.TabIndex = 6;
            pbxLogoGrande.TabStop = false;
            // 
            // btnMostrar
            // 
            _btnMostrar.BackColor = Color.Transparent;
            _btnMostrar.FlatAppearance.BorderSize = 0;
            _btnMostrar.FlatStyle = FlatStyle.Flat;
            _btnMostrar.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnMostrar.ForeColor = Color.Black;
            _btnMostrar.Image = My.Resources.Resources.baixados_removebg_preview__1_;
            _btnMostrar.Location = new Point(12, 8);
            _btnMostrar.Name = "_btnMostrar";
            _btnMostrar.Size = new Size(40, 40);
            _btnMostrar.TabIndex = 8;
            _btnMostrar.UseVisualStyleBackColor = false;
            _btnMostrar.Visible = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(96.0f, 96.0f);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(938, 624);
            Controls.Add(lblUsuario);
            Controls.Add(lblNomeApp);
            Controls.Add(pbxLogoGrande);
            Controls.Add(pnlBotoes);
            Controls.Add(_btnMostrar);
            Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenuPrincipal";
            Text = "Menu Principal";
            pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoGrande).EndInit();
            Load += new EventHandler(frmMenuPrincipal_Load);
            FormClosing += new FormClosingEventHandler(frmMenuPrincipal_FormClosing);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel pnlBotoes;
        internal PictureBox pbLogo;
        private Button _btnCadAlimento;

        internal Button btnCadAlimento
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCadAlimento;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCadAlimento != null)
                {
                    _btnCadAlimento.Click -= btnCadastrarAlimento_Click;
                }

                _btnCadAlimento = value;
                if (_btnCadAlimento != null)
                {
                    _btnCadAlimento.Click += btnCadastrarAlimento_Click;
                }
            }
        }

        private Button _btnCadCardapio;

        internal Button btnCadCardapio
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCadCardapio;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCadCardapio != null)
                {
                    _btnCadCardapio.Click -= btnCadCardapio_Click;
                }

                _btnCadCardapio = value;
                if (_btnCadCardapio != null)
                {
                    _btnCadCardapio.Click += btnCadCardapio_Click;
                }
            }
        }

        private Button _btnConfig;

        internal Button btnConfig
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConfig;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConfig != null)
                {
                    _btnConfig.Click -= btnConfig_Click;
                }

                _btnConfig = value;
                if (_btnConfig != null)
                {
                    _btnConfig.Click += btnConfig_Click;
                }
            }
        }

        internal PictureBox pbxLogoGrande;
        private Button _btnOcultar;

        internal Button btnOcultar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOcultar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOcultar != null)
                {
                    _btnOcultar.Click -= btnOcultar_Click;
                }

                _btnOcultar = value;
                if (_btnOcultar != null)
                {
                    _btnOcultar.Click += btnOcultar_Click;
                }
            }
        }

        private Button _btnMostrar;

        internal Button btnMostrar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnMostrar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMostrar != null)
                {
                    _btnMostrar.Click -= btnMostrar_Click;
                }

                _btnMostrar = value;
                if (_btnMostrar != null)
                {
                    _btnMostrar.Click += btnMostrar_Click;
                }
            }
        }

        internal PictureBox pnlLogo;
        internal Button btnFinanceiro;
        private Button _btnAgenda;

        internal Button btnAgenda
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAgenda;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAgenda != null)
                {
                    _btnAgenda.Click -= btnAgenda_Click;
                }

                _btnAgenda = value;
                if (_btnAgenda != null)
                {
                    _btnAgenda.Click += btnAgenda_Click;
                }
            }
        }

        private Button _btnDeslogar;

        internal Button btnDeslogar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDeslogar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDeslogar != null)
                {
                    _btnDeslogar.Click -= btnDeslogar_Click;
                }

                _btnDeslogar = value;
                if (_btnDeslogar != null)
                {
                    _btnDeslogar.Click += btnDeslogar_Click;
                }
            }
        }

        internal Label lblNomeApp;
        internal Label lblUsuario;
        private Button _BtnPacientes;

        internal Button BtnPacientes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnPacientes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnPacientes != null)
                {
                    _BtnPacientes.Click -= BtnPacientes_Click;
                }

                _BtnPacientes = value;
                if (_BtnPacientes != null)
                {
                    _BtnPacientes.Click += BtnPacientes_Click;
                }
            }
        }
    }
}