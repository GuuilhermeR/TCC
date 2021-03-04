using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetoTCC

{
    public partial class frmBuscarAlimento : Form
    {
        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;

        public frmBuscarAlimento()
        {
            InitializeComponent();
        }

        private void frmBuscarAlimento_Load(object sender, EventArgs e)
        {
            //CarregarComboBoxTabelas();
        }


        private void CarregarComboBoxTabelas()
        {

            var strSQL = $@"SELECT nomeTabela FROM TabelasImportadas";

            var cmd = new SQLiteCommand(strSQL, objConexao);

            objConexao.Open();

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbxTabelaAlimentos.Items.Add(dr["existe"]);
            }

            objConexao.Close();

        }

    }
}
