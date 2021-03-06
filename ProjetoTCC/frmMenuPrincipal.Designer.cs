﻿using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this._BtnPacientes = new System.Windows.Forms.Button();
            this._btnDeslogar = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this._btnAgenda = new System.Windows.Forms.Button();
            this._btnOcultar = new System.Windows.Forms.Button();
            this._btnConfig = new System.Windows.Forms.Button();
            this._btnCadAlimento = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this._btnCadCardapio = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.PictureBox();
            this.lblNomeApp = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbxLogoGrande = new System.Windows.Forms.PictureBox();
            this._btnMostrar = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBotoes.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlBotoes.Controls.Add(this._BtnPacientes);
            this.pnlBotoes.Controls.Add(this._btnDeslogar);
            this.pnlBotoes.Controls.Add(this.btnFinanceiro);
            this.pnlBotoes.Controls.Add(this._btnAgenda);
            this.pnlBotoes.Controls.Add(this._btnOcultar);
            this.pnlBotoes.Controls.Add(this._btnConfig);
            this.pnlBotoes.Controls.Add(this._btnCadAlimento);
            this.pnlBotoes.Controls.Add(this.pbLogo);
            this.pnlBotoes.Controls.Add(this._btnCadCardapio);
            this.pnlBotoes.Controls.Add(this.pnlLogo);
            this.pnlBotoes.Location = new System.Drawing.Point(6, 5);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(234, 616);
            this.pnlBotoes.TabIndex = 5;
            // 
            // _BtnPacientes
            // 
            this._BtnPacientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._BtnPacientes.FlatAppearance.BorderSize = 0;
            this._BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnPacientes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnPacientes.ForeColor = System.Drawing.Color.Black;
            this._BtnPacientes.Location = new System.Drawing.Point(12, 334);
            this._BtnPacientes.Name = "_BtnPacientes";
            this._BtnPacientes.Size = new System.Drawing.Size(208, 41);
            this._BtnPacientes.TabIndex = 10;
            this._BtnPacientes.Text = "Pacientes";
            this._BtnPacientes.UseVisualStyleBackColor = false;
            this._BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // _btnDeslogar
            // 
            this._btnDeslogar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._btnDeslogar.FlatAppearance.BorderSize = 0;
            this._btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDeslogar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDeslogar.ForeColor = System.Drawing.Color.Black;
            this._btnDeslogar.Location = new System.Drawing.Point(12, 566);
            this._btnDeslogar.Name = "_btnDeslogar";
            this._btnDeslogar.Size = new System.Drawing.Size(208, 41);
            this._btnDeslogar.TabIndex = 10;
            this._btnDeslogar.Text = "Sair e fechar";
            this._btnDeslogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnDeslogar.UseVisualStyleBackColor = false;
            this._btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.Black;
            this.btnFinanceiro.Location = new System.Drawing.Point(12, 287);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(208, 41);
            this.btnFinanceiro.TabIndex = 9;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            // 
            // _btnAgenda
            // 
            this._btnAgenda.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._btnAgenda.FlatAppearance.BorderSize = 0;
            this._btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAgenda.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAgenda.ForeColor = System.Drawing.Color.Black;
            this._btnAgenda.Location = new System.Drawing.Point(12, 146);
            this._btnAgenda.Name = "_btnAgenda";
            this._btnAgenda.Size = new System.Drawing.Size(208, 41);
            this._btnAgenda.TabIndex = 8;
            this._btnAgenda.Text = "Agenda";
            this._btnAgenda.UseVisualStyleBackColor = false;
            this._btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // _btnOcultar
            // 
            this._btnOcultar.BackColor = System.Drawing.Color.Transparent;
            this._btnOcultar.FlatAppearance.BorderSize = 0;
            this._btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOcultar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnOcultar.ForeColor = System.Drawing.Color.Black;
            this._btnOcultar.Image = global::ProjetoTCC.My.Resources.Resources.baixados_removebg_preview__1_;
            this._btnOcultar.Location = new System.Drawing.Point(3, 0);
            this._btnOcultar.Name = "_btnOcultar";
            this._btnOcultar.Size = new System.Drawing.Size(40, 40);
            this._btnOcultar.TabIndex = 7;
            this._btnOcultar.UseVisualStyleBackColor = false;
            this._btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // _btnConfig
            // 
            this._btnConfig.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._btnConfig.FlatAppearance.BorderSize = 0;
            this._btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnConfig.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConfig.ForeColor = System.Drawing.Color.Black;
            this._btnConfig.Location = new System.Drawing.Point(12, 519);
            this._btnConfig.Name = "_btnConfig";
            this._btnConfig.Size = new System.Drawing.Size(208, 41);
            this._btnConfig.TabIndex = 6;
            this._btnConfig.Text = "Configurações";
            this._btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnConfig.UseVisualStyleBackColor = false;
            this._btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // _btnCadAlimento
            // 
            this._btnCadAlimento.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._btnCadAlimento.FlatAppearance.BorderSize = 0;
            this._btnCadAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCadAlimento.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCadAlimento.ForeColor = System.Drawing.Color.Black;
            this._btnCadAlimento.Location = new System.Drawing.Point(12, 193);
            this._btnCadAlimento.Name = "_btnCadAlimento";
            this._btnCadAlimento.Size = new System.Drawing.Size(208, 41);
            this._btnCadAlimento.TabIndex = 2;
            this._btnCadAlimento.Text = "Alimentos";
            this._btnCadAlimento.UseVisualStyleBackColor = false;
            this._btnCadAlimento.Click += new System.EventHandler(this.btnCadastrarAlimento_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            this.pbLogo.Location = new System.Drawing.Point(41, 18);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(144, 109);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // _btnCadCardapio
            // 
            this._btnCadCardapio.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._btnCadCardapio.FlatAppearance.BorderSize = 0;
            this._btnCadCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCadCardapio.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCadCardapio.ForeColor = System.Drawing.Color.Black;
            this._btnCadCardapio.Location = new System.Drawing.Point(12, 240);
            this._btnCadCardapio.Name = "_btnCadCardapio";
            this._btnCadCardapio.Size = new System.Drawing.Size(208, 41);
            this._btnCadCardapio.TabIndex = 4;
            this._btnCadCardapio.Text = "Cardápio";
            this._btnCadCardapio.UseVisualStyleBackColor = false;
            this._btnCadCardapio.Click += new System.EventHandler(this.btnCadCardapio_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Location = new System.Drawing.Point(4, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(228, 136);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.TabStop = false;
            // 
            // lblNomeApp
            // 
            this.lblNomeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeApp.AutoSize = true;
            this.lblNomeApp.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblNomeApp.Location = new System.Drawing.Point(467, 465);
            this.lblNomeApp.Name = "lblNomeApp";
            this.lblNomeApp.Size = new System.Drawing.Size(152, 45);
            this.lblNomeApp.TabIndex = 7;
            this.lblNomeApp.Text = "Nutreasy";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(890, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 19);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Label1";
            // 
            // pbxLogoGrande
            // 
            this.pbxLogoGrande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogoGrande.Image = global::ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            this.pbxLogoGrande.Location = new System.Drawing.Point(385, 120);
            this.pbxLogoGrande.Name = "pbxLogoGrande";
            this.pbxLogoGrande.Size = new System.Drawing.Size(332, 308);
            this.pbxLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoGrande.TabIndex = 6;
            this.pbxLogoGrande.TabStop = false;
            // 
            // _btnMostrar
            // 
            this._btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this._btnMostrar.FlatAppearance.BorderSize = 0;
            this._btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMostrar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMostrar.ForeColor = System.Drawing.Color.Black;
            this._btnMostrar.Image = global::ProjetoTCC.My.Resources.Resources.baixados_removebg_preview__1_;
            this._btnMostrar.Location = new System.Drawing.Point(12, 8);
            this._btnMostrar.Name = "_btnMostrar";
            this._btnMostrar.Size = new System.Drawing.Size(40, 40);
            this._btnMostrar.TabIndex = 8;
            this._btnMostrar.UseVisualStyleBackColor = false;
            this._btnMostrar.Visible = false;
            this._btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 624);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNomeApp);
            this.Controls.Add(this.pbxLogoGrande);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this._btnMostrar);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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