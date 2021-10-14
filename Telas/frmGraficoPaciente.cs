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
using static Classes.HelperFuncoes;

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
            FormatView(this);

            this.MaximizeBox = false;

            this.Text += $" - {NomePaciente}";
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
            List<double> pescoco = new List<double>();
            List<double> abdome = new List<double>();
            List<string> data = new List<string>();
            
            var antropometriaLista = antroDAO.Buscar();
            if (antropometriaLista.Count == 0)
                return;

            antropometriaLista.ForEach(x =>
            {
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
                pescoco.Add(Convert.ToDouble(x.pescoco));
                abdome.Add(Convert.ToDouble(x.abdome));
                data.Add(x.Data.ToString("dd/MM/yyyy"));
            });

            configurarGrafico(cartPeso, peso, "Peso",data);
            configurarGrafico(cartAltura, altura, "Altura", data);
            configurarGrafico(cartBraco, braco, "Braço", data);
            configurarGrafico(cartPunho, punho, "Punho", data);
            configurarGrafico(cartCintura, cintura, "Cintura", data);
            configurarGrafico(cartTorax, torax, "Tórax", data);
            configurarGrafico(cartQuadril, quadril, "Quadril", data);
            configurarGrafico(cartPanturrilha, panturrilha, "Panturrilha", data);
            configurarGrafico(cartAnteBraco, antebraco, "Antebraço", data);
            configurarGrafico(cartCoxa, coxa, "Coxa", data);
            configurarGrafico(chtPescoco, pescoco, "Pescoço", data);
            configurarGrafico(chtAbdome, abdome, "Abdome", data);
        }

        private void configurarGrafico(LiveCharts.WinForms.CartesianChart grafico, List<double> valor, string titulo, List<string> data)
        {
            var series = new LineSeries()
            {
                Title = titulo,
                Values = new ChartValues<double>(valor),
                StrokeThickness = 3,
                StrokeDashArray = new DoubleCollection(20)
            };
            grafico.AxisX.Add(new Axis
            {
                Labels = data,
                ShowLabels = true
            });
            grafico.Series.Clear();
            grafico.Series.Add(series);
        }

    }
}
