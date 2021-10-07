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
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            Sw_Pro.producto pProducto = new Sw_Pro.producto();

            pProducto.idProducto = Convert.ToInt32(textBoxID.Text);
            pProducto.idProductoSpecified = true;
            pProducto.nombre = textBoxNom.Text;         
            pProducto.precioVenta = Convert.ToDouble(textBoxPVenta.Text);
            pProducto.precioVentaSpecified = true;
            pProducto.upc = Convert.ToInt64(textBoxUPC.Text);
            pProducto.upcSpecified = true;         
            


            if(servicio.guardarProducto(pProducto) == true)
            {
                MessageBox.Show("Se ha agregado exitosamente el Producto", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }
            else
            {
                MessageBox.Show("Hubo un error al agrega el Producto, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUI_AdicionarP_Load(object sender, EventArgs e)
        {

        }
    }
}
