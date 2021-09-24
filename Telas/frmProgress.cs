using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC2.Telas
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        public string WaitText
        {
            get
            {
                return this.Label1.Text;
            }
            set
            {
                this.Label1.Text = value;
            }
        }

        private void frmProgress_Load(System.Object sender, System.EventArgs e)
        {
            //this.Location = new Point(Split(this.Text, "||")(0), Split(this.Text, "||")(1));
            //this.Location = new Point(Text.Split["||"][0], Split(this.Text, "||")(1));
        }

        private void lblLogo_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
