using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    [DesignerGenerated()]
    public partial class frmMenuNovo : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
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

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuNovo));
            PanelChildForm = new Panel();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            _btnCadastrar = new Button();
            _btnCadastrar.Click += new EventHandler(btnMedia_Click);
            PanelMediaSubmenu = new Panel();
            _btnCadPaciente = new Button();
            _btnCadPaciente.Click += new EventHandler(button4_Click);
            _btnCardapio = new Button();
            _btnCardapio.Click += new EventHandler(button3_Click);
            _btnCadastrarAlimento = new Button();
            _btnCadastrarAlimento.Click += new EventHandler(button2_Click);
            PanelPlaylistSubmenu = new Panel();
            _btnPaciente = new Button();
            _btnPaciente.Click += new EventHandler(button6_Click);
            _btnConsCardápio = new Button();
            _btnConsCardápio.Click += new EventHandler(button7_Click);
            _button8 = new Button();
            _button8.Click += new EventHandler(button8_Click);
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            _PanelSideMenu = new Panel();
            _PanelSideMenu.Paint += new PaintEventHandler(PanelSideMenu_Paint);
            _btnConfigurações = new Button();
            _btnConfigurações.Click += new EventHandler(btnConfigurações_Click);
            _btnConsultar = new Button();
            _btnConsultar.Click += new EventHandler(btnPlaylist_Click);
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMediaSubmenu.SuspendLayout();
            PanelPlaylistSubmenu.SuspendLayout();
            _PanelSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelChildForm
            // 
            PanelChildForm.BackColor = Color.Transparent;
            PanelChildForm.Dock = DockStyle.Fill;
            PanelChildForm.Location = new Point(250, 0);
            PanelChildForm.Name = "PanelChildForm";
            PanelChildForm.Size = new Size(878, 749);
            PanelChildForm.TabIndex = 3;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.GreenYellow;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 92);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = My.Resources.Resources.iconTCC_removebg_preview__1____Copia;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            _btnCadastrar.BackColor = Color.Green;
            _btnCadastrar.Dock = DockStyle.Top;
            _btnCadastrar.FlatAppearance.BorderSize = 0;
            _btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(23)), Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(32)));
            _btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(24)), Conversions.ToInteger(Conversions.ToByte(22)), Conversions.ToInteger(Conversions.ToByte(34)));
            _btnCadastrar.FlatStyle = FlatStyle.Flat;
            _btnCadastrar.Font = new Font("Microsoft Sans Serif", 12.0f);
            _btnCadastrar.ForeColor = Color.Black;
            _btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            _btnCadastrar.Location = new Point(0, 92);
            _btnCadastrar.Name = "_btnCadastrar";
            _btnCadastrar.Padding = new Padding(5, 0, 0, 0);
            _btnCadastrar.Size = new Size(250, 57);
            _btnCadastrar.TabIndex = 1;
            _btnCadastrar.Text = "  Cadastrar";
            _btnCadastrar.TextAlign = ContentAlignment.MiddleLeft;
            _btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // PanelMediaSubmenu
            // 
            PanelMediaSubmenu.BackColor = Color.GreenYellow;
            PanelMediaSubmenu.Controls.Add(_btnCadPaciente);
            PanelMediaSubmenu.Controls.Add(_btnCardapio);
            PanelMediaSubmenu.Controls.Add(_btnCadastrarAlimento);
            PanelMediaSubmenu.Dock = DockStyle.Top;
            PanelMediaSubmenu.Location = new Point(0, 149);
            PanelMediaSubmenu.Name = "PanelMediaSubmenu";
            PanelMediaSubmenu.Size = new Size(250, 165);
            PanelMediaSubmenu.TabIndex = 2;
            // 
            // btnCadPaciente
            // 
            _btnCadPaciente.BackColor = Color.LimeGreen;
            _btnCadPaciente.Dock = DockStyle.Top;
            _btnCadPaciente.FlatAppearance.BorderSize = 0;
            _btnCadPaciente.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnCadPaciente.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnCadPaciente.FlatStyle = FlatStyle.Flat;
            _btnCadPaciente.ForeColor = Color.Black;
            _btnCadPaciente.Location = new Point(0, 80);
            _btnCadPaciente.Name = "_btnCadPaciente";
            _btnCadPaciente.Padding = new Padding(35, 0, 0, 0);
            _btnCadPaciente.Size = new Size(250, 40);
            _btnCadPaciente.TabIndex = 2;
            _btnCadPaciente.Text = "Paciente";
            _btnCadPaciente.TextAlign = ContentAlignment.MiddleLeft;
            _btnCadPaciente.UseVisualStyleBackColor = false;
            // 
            // btnCardapio
            // 
            _btnCardapio.BackColor = Color.LimeGreen;
            _btnCardapio.Dock = DockStyle.Top;
            _btnCardapio.FlatAppearance.BorderSize = 0;
            _btnCardapio.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnCardapio.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnCardapio.FlatStyle = FlatStyle.Flat;
            _btnCardapio.ForeColor = Color.Black;
            _btnCardapio.Location = new Point(0, 40);
            _btnCardapio.Name = "_btnCardapio";
            _btnCardapio.Padding = new Padding(35, 0, 0, 0);
            _btnCardapio.Size = new Size(250, 40);
            _btnCardapio.TabIndex = 1;
            _btnCardapio.Text = "Cardápio";
            _btnCardapio.TextAlign = ContentAlignment.MiddleLeft;
            _btnCardapio.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarAlimento
            // 
            _btnCadastrarAlimento.BackColor = Color.LimeGreen;
            _btnCadastrarAlimento.Dock = DockStyle.Top;
            _btnCadastrarAlimento.FlatAppearance.BorderSize = 0;
            _btnCadastrarAlimento.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnCadastrarAlimento.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnCadastrarAlimento.FlatStyle = FlatStyle.Flat;
            _btnCadastrarAlimento.ForeColor = Color.Black;
            _btnCadastrarAlimento.Location = new Point(0, 0);
            _btnCadastrarAlimento.Name = "_btnCadastrarAlimento";
            _btnCadastrarAlimento.Padding = new Padding(35, 0, 0, 0);
            _btnCadastrarAlimento.Size = new Size(250, 40);
            _btnCadastrarAlimento.TabIndex = 0;
            _btnCadastrarAlimento.Text = "Alimentos";
            _btnCadastrarAlimento.TextAlign = ContentAlignment.MiddleLeft;
            _btnCadastrarAlimento.UseVisualStyleBackColor = false;
            // 
            // PanelPlaylistSubmenu
            // 
            PanelPlaylistSubmenu.BackColor = Color.GreenYellow;
            PanelPlaylistSubmenu.Controls.Add(_btnPaciente);
            PanelPlaylistSubmenu.Controls.Add(_btnConsCardápio);
            PanelPlaylistSubmenu.Controls.Add(_button8);
            PanelPlaylistSubmenu.Dock = DockStyle.Top;
            PanelPlaylistSubmenu.Location = new Point(0, 379);
            PanelPlaylistSubmenu.Name = "PanelPlaylistSubmenu";
            PanelPlaylistSubmenu.Size = new Size(250, 119);
            PanelPlaylistSubmenu.TabIndex = 4;
            // 
            // btnPaciente
            // 
            _btnPaciente.BackColor = Color.LimeGreen;
            _btnPaciente.Dock = DockStyle.Top;
            _btnPaciente.FlatAppearance.BorderSize = 0;
            _btnPaciente.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnPaciente.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnPaciente.FlatStyle = FlatStyle.Flat;
            _btnPaciente.ForeColor = Color.Black;
            _btnPaciente.Location = new Point(0, 80);
            _btnPaciente.Name = "_btnPaciente";
            _btnPaciente.Padding = new Padding(35, 0, 0, 0);
            _btnPaciente.Size = new Size(250, 40);
            _btnPaciente.TabIndex = 2;
            _btnPaciente.Text = "Paciente";
            _btnPaciente.TextAlign = ContentAlignment.MiddleLeft;
            _btnPaciente.UseVisualStyleBackColor = false;
            // 
            // btnConsCardápio
            // 
            _btnConsCardápio.BackColor = Color.LimeGreen;
            _btnConsCardápio.Dock = DockStyle.Top;
            _btnConsCardápio.FlatAppearance.BorderSize = 0;
            _btnConsCardápio.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnConsCardápio.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _btnConsCardápio.FlatStyle = FlatStyle.Flat;
            _btnConsCardápio.ForeColor = Color.Black;
            _btnConsCardápio.Location = new Point(0, 40);
            _btnConsCardápio.Name = "_btnConsCardápio";
            _btnConsCardápio.Padding = new Padding(35, 0, 0, 0);
            _btnConsCardápio.Size = new Size(250, 40);
            _btnConsCardápio.TabIndex = 1;
            _btnConsCardápio.Text = "Cardápio";
            _btnConsCardápio.TextAlign = ContentAlignment.MiddleLeft;
            _btnConsCardápio.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            _button8.BackColor = Color.LimeGreen;
            _button8.Dock = DockStyle.Top;
            _button8.FlatAppearance.BorderSize = 0;
            _button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            _button8.FlatStyle = FlatStyle.Flat;
            _button8.ForeColor = Color.Black;
            _button8.Location = new Point(0, 0);
            _button8.Name = "_button8";
            _button8.Padding = new Padding(35, 0, 0, 0);
            _button8.Size = new Size(250, 40);
            _button8.TabIndex = 0;
            _button8.Text = "Alimentos";
            _button8.TextAlign = ContentAlignment.MiddleLeft;
            _button8.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Green;
            _btnExit.Dock = DockStyle.Bottom;
            _btnExit.FlatAppearance.BorderSize = 0;
            _btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(23)), Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(32)));
            _btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(24)), Conversions.ToInteger(Conversions.ToByte(22)), Conversions.ToInteger(Conversions.ToByte(34)));
            _btnExit.FlatStyle = FlatStyle.Flat;
            _btnExit.Font = new Font("Microsoft Sans Serif", 12.0f);
            _btnExit.ForeColor = Color.Black;
            _btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            _btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            _btnExit.Location = new Point(0, 704);
            _btnExit.Name = "_btnExit";
            _btnExit.Padding = new Padding(5, 0, 0, 0);
            _btnExit.Size = new Size(250, 45);
            _btnExit.TabIndex = 9;
            _btnExit.Text = "  Exit";
            _btnExit.TextAlign = ContentAlignment.MiddleLeft;
            _btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // PanelSideMenu
            // 
            _PanelSideMenu.AutoScroll = true;
            _PanelSideMenu.BackColor = Color.GreenYellow;
            _PanelSideMenu.Controls.Add(_btnConfigurações);
            _PanelSideMenu.Controls.Add(_btnExit);
            _PanelSideMenu.Controls.Add(PanelPlaylistSubmenu);
            _PanelSideMenu.Controls.Add(_btnConsultar);
            _PanelSideMenu.Controls.Add(PanelMediaSubmenu);
            _PanelSideMenu.Controls.Add(_btnCadastrar);
            _PanelSideMenu.Controls.Add(panelLogo);
            _PanelSideMenu.Dock = DockStyle.Left;
            _PanelSideMenu.Location = new Point(0, 0);
            _PanelSideMenu.Name = "_PanelSideMenu";
            _PanelSideMenu.Size = new Size(250, 749);
            _PanelSideMenu.TabIndex = 0;
            // 
            // btnConfigurações
            // 
            _btnConfigurações.BackColor = Color.Green;
            _btnConfigurações.Dock = DockStyle.Bottom;
            _btnConfigurações.FlatAppearance.BorderSize = 0;
            _btnConfigurações.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(23)), Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(32)));
            _btnConfigurações.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(24)), Conversions.ToInteger(Conversions.ToByte(22)), Conversions.ToInteger(Conversions.ToByte(34)));
            _btnConfigurações.FlatStyle = FlatStyle.Flat;
            _btnConfigurações.Font = new Font("Microsoft Sans Serif", 12.0f);
            _btnConfigurações.ForeColor = Color.Black;
            _btnConfigurações.ImageAlign = ContentAlignment.MiddleLeft;
            _btnConfigurações.Location = new Point(0, 659);
            _btnConfigurações.Name = "_btnConfigurações";
            _btnConfigurações.Padding = new Padding(5, 0, 0, 0);
            _btnConfigurações.Size = new Size(250, 45);
            _btnConfigurações.TabIndex = 10;
            _btnConfigurações.Text = "Configurações";
            _btnConfigurações.TextAlign = ContentAlignment.MiddleLeft;
            _btnConfigurações.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnConfigurações.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            _btnConsultar.BackColor = Color.Green;
            _btnConsultar.Dock = DockStyle.Top;
            _btnConsultar.FlatAppearance.BorderSize = 0;
            _btnConsultar.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(23)), Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(32)));
            _btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(24)), Conversions.ToInteger(Conversions.ToByte(22)), Conversions.ToInteger(Conversions.ToByte(34)));
            _btnConsultar.FlatStyle = FlatStyle.Flat;
            _btnConsultar.Font = new Font("Microsoft Sans Serif", 12.0f);
            _btnConsultar.ForeColor = Color.Black;
            _btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            _btnConsultar.Location = new Point(0, 314);
            _btnConsultar.Name = "_btnConsultar";
            _btnConsultar.Padding = new Padding(5, 0, 0, 0);
            _btnConsultar.Size = new Size(250, 65);
            _btnConsultar.TabIndex = 3;
            _btnConsultar.Text = "  Consultar";
            _btnConsultar.TextAlign = ContentAlignment.MiddleLeft;
            _btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnConsultar.UseVisualStyleBackColor = false;
            // 
            // frmMenuNovo
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 749);
            Controls.Add(PanelChildForm);
            Controls.Add(_PanelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(950, 600);
            Name = "frmMenuNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMediaSubmenu.ResumeLayout(false);
            PanelPlaylistSubmenu.ResumeLayout(false);
            _PanelSideMenu.ResumeLayout(false);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
        }

        internal Panel PanelChildForm;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button _btnCadastrar;

        private Button btnCadastrar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCadastrar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCadastrar != null)
                {
                    _btnCadastrar.Click -= btnMedia_Click;
                }

                _btnCadastrar = value;
                if (_btnCadastrar != null)
                {
                    _btnCadastrar.Click += btnMedia_Click;
                }
            }
        }

        private Panel PanelMediaSubmenu;
        private Button _btnCadPaciente;

        private Button btnCadPaciente
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCadPaciente;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCadPaciente != null)
                {
                    _btnCadPaciente.Click -= button4_Click;
                }

                _btnCadPaciente = value;
                if (_btnCadPaciente != null)
                {
                    _btnCadPaciente.Click += button4_Click;
                }
            }
        }

        private Button _btnCardapio;

        private Button btnCardapio
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCardapio;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCardapio != null)
                {
                    _btnCardapio.Click -= button3_Click;
                }

                _btnCardapio = value;
                if (_btnCardapio != null)
                {
                    _btnCardapio.Click += button3_Click;
                }
            }
        }

        private Button _btnCadastrarAlimento;

        private Button btnCadastrarAlimento
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCadastrarAlimento;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCadastrarAlimento != null)
                {
                    _btnCadastrarAlimento.Click -= button2_Click;
                }

                _btnCadastrarAlimento = value;
                if (_btnCadastrarAlimento != null)
                {
                    _btnCadastrarAlimento.Click += button2_Click;
                }
            }
        }

        private Panel PanelPlaylistSubmenu;
        private Button _btnPaciente;

        private Button btnPaciente
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPaciente;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPaciente != null)
                {
                    _btnPaciente.Click -= button6_Click;
                }

                _btnPaciente = value;
                if (_btnPaciente != null)
                {
                    _btnPaciente.Click += button6_Click;
                }
            }
        }

        private Button _btnConsCardápio;

        private Button btnConsCardápio
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConsCardápio;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConsCardápio != null)
                {
                    _btnConsCardápio.Click -= button7_Click;
                }

                _btnConsCardápio = value;
                if (_btnConsCardápio != null)
                {
                    _btnConsCardápio.Click += button7_Click;
                }
            }
        }

        private Button _button8;

        private Button button8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _button8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_button8 != null)
                {
                    _button8.Click -= button8_Click;
                }

                _button8 = value;
                if (_button8 != null)
                {
                    _button8.Click += button8_Click;
                }
            }
        }

        private Button _btnExit;

        private Button btnExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExit != null)
                {
                    _btnExit.Click -= btnExit_Click;
                }

                _btnExit = value;
                if (_btnExit != null)
                {
                    _btnExit.Click += btnExit_Click;
                }
            }
        }

        private Panel _PanelSideMenu;

        private Panel PanelSideMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PanelSideMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PanelSideMenu != null)
                {
                    _PanelSideMenu.Paint -= PanelSideMenu_Paint;
                }

                _PanelSideMenu = value;
                if (_PanelSideMenu != null)
                {
                    _PanelSideMenu.Paint += PanelSideMenu_Paint;
                }
            }
        }

        private Button _btnConfigurações;

        private Button btnConfigurações
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConfigurações;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConfigurações != null)
                {
                    _btnConfigurações.Click -= btnConfigurações_Click;
                }

                _btnConfigurações = value;
                if (_btnConfigurações != null)
                {
                    _btnConfigurações.Click += btnConfigurações_Click;
                }
            }
        }

        private Button _btnConsultar;

        private Button btnConsultar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConsultar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConsultar != null)
                {
                    _btnConsultar.Click -= btnPlaylist_Click;
                }

                _btnConsultar = value;
                if (_btnConsultar != null)
                {
                    _btnConsultar.Click += btnPlaylist_Click;
                }
            }
        }
    }
}