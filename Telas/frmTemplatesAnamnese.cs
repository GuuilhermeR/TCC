using MaterialSkin.Controls;
using ProjetoTCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC2.Telas;
using static Classes.HelperFuncoes;

namespace TCC2.Telas
{
    public partial class frmTemplatesAnamnese : MaterialForm
    {
        public AnamneseDAO anamneseDAO = new AnamneseDAO();

        public frmTemplatesAnamnese()
        {
            InitializeComponent();
            FormatView(this);
        }

        private void frmTemplatesAnamnese_Load(object sender, EventArgs e)
        {
            loadStart();
            CarregarAnamnesesConfigs();
            loadStop();
            this.Activate();
        }

        private void CarregarAnamnesesConfigs()
        {
            var templates = anamneseDAO.CarregarAnamneseConfig();

            if (templates is null || templates.Count == 0)
            {
                loadStop();
                return;
            }

            templates.ForEach(x =>
            {
                cbxTempSalvo.Items.Add(x.Template);
            });
        }

        private void btnSalvarAnamnese_Click(object sender, EventArgs e)
        {
            anamneseDAO.SalvarConfig(txtNomeTemplate.Text, rtxtAnamnese.Text,Convert.ToBoolean(cbxExibirSalvos.Checked));
            CarregarAnamnesesConfigs();
            rtxtAnamnese.Text = string.Empty;
            txtNomeTemplate.Text = string.Empty;
        }

        private void cbxExibirSalvos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExibirSalvos.Checked)
            {
                txtNomeTemplate.Visible = false;
                cbxTempSalvo.Visible = true;
                rtxtAnamnese.Text = string.Empty;
            }
            else
            {
                txtNomeTemplate.Visible = true;
                cbxTempSalvo.Visible = false;
                rtxtAnamnese.Text = string.Empty;
            }
        }

        private void cbxTempSalvo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStart();
            var templates = anamneseDAO.CarregarAnamneseTemplate(cbxTempSalvo.Text);

            if (templates is null || templates.Count == 0)
            {
                loadStop();
                return;
            }

            templates.ForEach(x =>
            {
                rtxtAnamnese.Text = x.Texto;
            });

            loadStop();
        }
    }
}
