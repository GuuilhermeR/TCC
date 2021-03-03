using System;
using System.Windows.Forms;

namespace ProjetoTCC
{
    public partial class frmMenuNovo
    {
        public frmMenuNovo()
        {
            InitializeComponent();
            _btnCadastrar.Name = "btnCadastrar";
            _btnCadPaciente.Name = "btnCadPaciente";
            _btnCardapio.Name = "btnCardapio";
            _btnCadastrarAlimento.Name = "btnCadastrarAlimento";
            _btnPaciente.Name = "btnPaciente";
            _btnConsCardápio.Name = "btnConsCardápio";
            _button8.Name = "button8";
            _btnExit.Name = "btnExit";
            _PanelSideMenu.Name = "PanelSideMenu";
            _btnConfigurações.Name = "btnConfigurações";
            _btnConsultar.Name = "btnConsultar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void hideSubmenu()
        {
            PanelMediaSubmenu.Visible = false;
            PanelPlaylistSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelMediaSubmenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelPlaylistSubmenu);
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAlimento());
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new frmConsultaAlimentos());
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private Form currentForm = null;

        private void openChildForm(Form childForm)
        {
            if (currentForm is object)
                currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PanelSideMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnConfigurações_Click(object sender, EventArgs e)
        {
            openChildForm(new frmConfiguracoes());
            hideSubmenu();
        }
    }
}