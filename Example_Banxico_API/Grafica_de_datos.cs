using Newtonsoft.Json.Linq;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Banxico_API
{
    public partial class Grafica_de_datos : Form
    {
        private readonly string token = "70cabec82bf23b9d0d3665ed13fd4757dd2483975384846ebc9dbed0f87f9550";
        public Grafica_de_datos()
        {
            InitializeComponent();
        }

        private async void BtnEnter_Click(object sender, EventArgs e)
        {
            string fechaInicio = DataTimeInicio.Value.ToString("yyyy-MM-dd");
            string fechaFin = DataTimeFinal.Value.ToString("yyyy-MM-dd");

            string url = $"https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{fechaInicio}/{fechaFin}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Bmx-Token", token);
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    MostrarGrafica(json);
                }
                else
                {
                    MessageBox.Show("Error al obtener datos: " + response.StatusCode);
                }
            }
        }

        private void MostrarGrafica(string json)
        {
            // Parsear el JSON para obtener los datos
            JObject data = JObject.Parse(json);
            JArray datos = (JArray)data["bmx"]["series"][0]["datos"];

            // Listas para almacenar los valores
            List<double> precios = new List<double>();

            // Iterar sobre los datos y extraer el valor
            foreach (var item in datos)
            {
                double precio = double.Parse(item["dato"].ToString().Replace(",", "."));
                precios.Add(precio);
            }

            double[] dataX = Enumerable.Range(1, precios.Count).Select(x => (double)x).ToArray();
            double[] dataY = precios.ToArray();


            // Graficar los datos en un scatter plot
            var scart = FromPlotDataDolar.Plot.Add.Scatter(dataX, dataY);

            scart.Color = Colors.Blue;
            scart.LineWidth = 5;
            scart.MarkerSize = 15;
            scart.MarkerShape = MarkerShape.FilledDiamond;
            FromPlotDataDolar.Refresh();
        }

        private void Grafica_de_datos_Load(object sender, EventArgs e)
        {

        }
    }
}
