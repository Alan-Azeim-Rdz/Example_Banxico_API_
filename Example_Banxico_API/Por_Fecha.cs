using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
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
    public partial class Por_Fecha : Form
    {
        private readonly string token = "70cabec82bf23b9d0d3665ed13fd4757dd2483975384846ebc9dbed0f87f9550"; 
        public Por_Fecha()
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
                    MostrarDatos(json);
                }
                else
                {
                    MessageBox.Show("Error al obtener datos: " + response.StatusCode);
                }
            }
        }
        private void MostrarDatos(string json)
        {
            JObject data = JObject.Parse(json);
            var serie = data["bmx"]["series"][0]["datos"];

            DataGrideDataDolar.Rows.Clear();
            foreach (var item in serie)
            {
                string fecha = item["fecha"].ToString();
                string valor = item["dato"].ToString();
                DataGrideDataDolar.Rows.Add(fecha, valor);
            }
        }
    }
}
