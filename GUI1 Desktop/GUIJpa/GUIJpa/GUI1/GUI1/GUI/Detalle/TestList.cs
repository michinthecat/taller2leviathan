using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Detalle
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void listar_Click(object sender, EventArgs e)
        {
            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            dataGridViewTest.AutoGenerateColumns = true;
            dataGridViewTest.DataSource = servicio.listarOrdenes();
        }
    }
}
