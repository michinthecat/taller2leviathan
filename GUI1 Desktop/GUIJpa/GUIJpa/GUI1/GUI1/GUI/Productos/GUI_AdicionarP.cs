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
    public partial class GUI_AdicionarP : Form
    {
        public GUI_AdicionarP()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Sw_Pro.SWControladorClient client = new Sw_Pro.SWControladorClient();

            Sw_Pro.producto pProducto = new Sw_Pro.producto();

            pProducto.idProducto = Convert.ToInt32(textBoxID.Text);
            pProducto.idProductoSpecified = true;
            pProducto.nombre = textBoxNom.Text;         
            pProducto.precioVenta = Convert.ToInt64(textBoxPVenta.Text);
            pProducto.upc = textBoxUPC.Text;

            if (client.guardarProducto(pProducto) == true)
            {
                MessageBox.Show("Se agrego el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void GUI_AdicionarP_Load(object sender, EventArgs e)
        {

        }
    }
}
