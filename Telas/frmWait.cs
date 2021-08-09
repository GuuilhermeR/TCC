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
    public partial class frmWait : Form
    {
        public frmWait()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(System.Object sender, System.EventArgs e)
        {
            if (this.pgbProgresso.Value + 1 > this.pgbProgresso.Maximum)
                this.pgbProgresso.Value = 0;
            else
                this.pgbProgresso.Value += 1;
            this.Refresh();
            this.pgbProgresso.Show();
            this.pgbProgresso.Refresh();
        }

        private void frmWaint_Load(System.Object sender, System.EventArgs e)
        {
            this.timer1.Enabled = true;
            this.ShowInTaskbar = false;
        }
    }
}
