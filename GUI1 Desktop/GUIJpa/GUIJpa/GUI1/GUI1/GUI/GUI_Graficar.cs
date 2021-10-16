using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI1.GUI
{
    public partial class GUI_Graficar : Form
    {
        public GUI_Graficar()
        {
            InitializeComponent();
        }

        private void GUI_Graficar_Load(object sender, EventArgs e)
        {
            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            Sw_Pro.anyTypeArray1[] listaDetalle = servicio.listarPreciosChidos();

            chartTortita.Series.Clear();
            chartTortita.Palette = ChartColorPalette.Pastel;       


            Series graficaMain = new Series();


            foreach (var precio in listaDetalle)
            {
                graficaMain = chartTortita.Series.Add(precio.item.GetValue(0).ToString());
                graficaMain.Label = precio.item.GetValue(1).ToString();
                graficaMain.Points.Add(Convert.ToInt32(precio.item.GetValue(1)));
            }
            



        }

        private void chartTortita_Click(object sender, EventArgs e)
        {

        }
    }
}
