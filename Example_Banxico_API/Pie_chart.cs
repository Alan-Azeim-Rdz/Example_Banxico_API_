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
    public partial class Pie_chart : Form
    {
        public Pie_chart()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double[] values = new double[5] ;

            for (int i = 0; i < 5; i++)
            {
                values[i] = random.Next(0, 101);  // Números entre 0 y 100
            }
            Pie_with_Percent_Labels(values);
            Pie_Chart_from_Values(values);
            Donut_from_Slices(values);
            Pie_with_Different_Labels(values);
        }

        private void Pie_with_Percent_Labels(double[] values)
        {
            // create a pie chart
            var pie = FromPlotPiePercent.Plot.Add.Pie(values);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 0.5;

            // determine percentages for each slice
            double total = pie.Slices.Select(x => x.Value).Sum();
            double[] percentages = pie.Slices.Select(x => x.Value / total * 100).ToArray();

            // set each slice label to its percentage
            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].Label = $"{percentages[i]:0.0}%";
                pie.Slices[i].LabelFontSize = 20;
                pie.Slices[i].LabelBold = true;
            }

            // hide unnecessary plot components
            FromPlotPiePercent.Plot.Axes.Frameless();
            FromPlotPiePercent.Plot.HideGrid();
            FromPlotPiePercent.Refresh();
        }

        private void Pie_Chart_from_Values(double[] values)
        {
            var pie = FormPlotPieFromValues.Plot.Add.Pie(values);
            pie.ExplodeFraction = .1;

            // hide unnecessary plot components
            FormPlotPieFromValues.Plot.Axes.Frameless();
            FormPlotPieFromValues.Plot.HideGrid();
            FormPlotPieFromValues.Refresh();
        }

        private void Donut_from_Slices(double[] values)
        {
            var pie = FromPlotDonut.Plot.Add.Pie(values);
            pie.DonutFraction = .5;

            FromPlotDonut.Plot.ShowLegend();

            // hide unnecessary plot components
            FromPlotDonut.Plot.Axes.Frameless();
            FromPlotDonut.Plot.HideGrid();

            FromPlotDonut.Refresh();
        }

        private void Pie_with_Different_Labels(double[] values)
        {
            var pie = FromPlotPieDifferentLabels.Plot.Add.Pie(values);
            pie.ExplodeFraction = 0.1;
            pie.SliceLabelDistance = 0.5;

            // set different labels for slices and legend
            double total = pie.Slices.Select(x => x.Value).Sum();
            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].LabelFontSize = 20;
                pie.Slices[i].Label = $"{pie.Slices[i].Value}";
                pie.Slices[i].LegendText = $"{pie.Slices[i].Value} " +
                    $"({pie.Slices[i].Value / total:p1})";
            }

            // hide unnecessary plot components
            FromPlotPieDifferentLabels.Plot.Axes.Frameless();
            FromPlotPieDifferentLabels.Plot.HideGrid();

            FromPlotPieDifferentLabels.Refresh();
        }
    }
}
