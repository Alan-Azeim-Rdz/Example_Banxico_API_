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
    public partial class Dolar_menu : Form
    {
        public Dolar_menu()
        {
            InitializeComponent();
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            //abre la ventana de Por_Fecha y cierra la ventana actual
            Por_Fecha por_Fecha = new Por_Fecha();
            por_Fecha.Show();
            this.Close();
        }

        private void BtnGrafic_Click(object sender, EventArgs e)
        {
            Grafica_de_datos grafica_De_Datos = new Grafica_de_datos();
            grafica_De_Datos.Show();
            this.Close();
        }

        private void BtnPieGrafic_Click(object sender, EventArgs e)
        {
            Pie_chart pie_Chart = new Pie_chart();
            pie_Chart.Show();
            this.Close();
        }
    }
}
