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
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();
            GUI1.Sw_Pro.listarPreciosResponseEntry[] listaDetalle = servicio.listarPrecios();

            chartTortita.Series.Clear();
            chartTortita.Palette = ChartColorPalette.Pastel;       


            Series graficaMain = new Series();        
                     

            foreach (var precio in listaDetalle)
            {
                graficaMain = chartTortita.Series.Add(precio.key.ToString());
                graficaMain.Label = precio.value.ToString();
                graficaMain.Points.Add(precio.value);              
                

            }



        }

        private void chartTortita_Click(object sender, EventArgs e)
        {

        }
    }
}
