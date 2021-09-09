using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
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
using System.Windows.Media;

namespace TCC2.Telas
{
    public partial class frmGraficoPaciente : MaterialForm
    {
        private int CodPaciente;
        private string NomePaciente;
        private AntropometriaDAO antroDAO = new AntropometriaDAO();

        public frmGraficoPaciente(int codPaciente, string nomePaciente)
        {
            InitializeComponent();

            CodPaciente = codPaciente;
            NomePaciente = nomePaciente;
        }

        private void frmGraficoPaciente_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            this.MaximizeBox = false;

            lblNomePaciente.Text = NomePaciente;
            lblIdadePaciente.Visible = false;
            lblIdade.Visible = false;
            CarregarGraficos();
        }

        private void CarregarGraficos()
        {
            List<double> peso = new List<double>();
            List<double> altura = new List<double>();
            List<double> braco = new List<double>();
            List<double> punho = new List<double>();
            List<double> cintura = new List<double>();
            List<double> torax = new List<double>();
            List<double> quadril = new List<double>();
            List<double> panturrilha = new List<double>();
            List<double> antebraco = new List<double>();
            List<double> coxa = new List<double>();
            
            var antropometriaLista = antroDAO.Buscar();
            if (antropometriaLista.Count == 0)
                return;

            antropometriaLista.ForEach(x => {

                peso.Add(Convert.ToDouble(x.peso));
                altura.Add(Convert.ToDouble(x.altura));
                braco.Add(Convert.ToDouble(x.braco));
                punho.Add(Convert.ToDouble(x.punho));
                cintura.Add(Convert.ToDouble(x.cintura));
                torax.Add(Convert.ToDouble(x.torax));
                quadril.Add(Convert.ToDouble(x.quadril));
                panturrilha.Add(Convert.ToDouble(x.panturrilha));
                antebraco.Add(Convert.ToDouble(x.antebraco));
                coxa.Add(Convert.ToDouble(x.coxa));

            });
           
            configurarGrafico(cartPeso, peso, "Peso");
            configurarGrafico(cartAltura, altura, "Altura");
            configurarGrafico(cartBraco, braco, "Braço");
            configurarGrafico(cartPunho, punho, "Punho");
            configurarGrafico(cartCintura, cintura, "Cintura");
            configurarGrafico(cartTorax, torax, "Tórax");
            configurarGrafico(cartQuadril, quadril, "Quadril");
            configurarGrafico(cartPanturrilha, panturrilha, "Panturrilha");
            configurarGrafico(cartAnteBraco, antebraco, "Antebraço");
            configurarGrafico(cartCoxa, coxa, "Coxa");

        }

        private void configurarGrafico(LiveCharts.WinForms.CartesianChart grafico, List<double> valor, string titulo)
        {
            var series = new LiveCharts.Wpf.LineSeries()
            {
                Title = titulo,
                Values = new LiveCharts.ChartValues<double>(valor),
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(50)
            };
            grafico.Series.Clear();
            grafico.Series.Add(series);
        }

    }
}
