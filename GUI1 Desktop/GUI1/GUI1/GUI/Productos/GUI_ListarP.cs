using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Productos
{
    public partial class GUI_ListarP : Form
    {
        public GUI_ListarP()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listarProductosPorNombreResponseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ButtonMostrar_Click(object sender, EventArgs e)
        {
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            Sw_Pro.producto pProducto = new Sw_Pro.producto();

            dataGridProductos.AutoGenerateColumns = true;
            dataGridProductos.DataSource = servicio.listarProductosPorNombre(textBoxNombreP.Text);          

        }
    }
}
