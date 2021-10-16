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
    public partial class GUI_ListarD : Form
    {
        public GUI_ListarD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
          



        }

        private void GUI_ListarD_Load(object sender, EventArgs e)
        {

            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();

            
            if (textBoxIDPro.Text.Equals(""))
            {
                var listaDetalle = servicio.listarOrdenes();

                foreach (var detalle in listaDetalle)
                {
                    ListViewItem lista = new ListViewItem(detalle.producto.idProducto.ToString());
                    lista.SubItems.Add(detalle.pedidos.idPedido.ToString());
                    lista.SubItems.Add(detalle.cantidad.ToString());
                    lista.SubItems.Add(detalle.precio.ToString());
                    lista.SubItems.Add(detalle.fecha.ToString());
                    listView1.Items.Add(lista);

                }
                return;
            }
            else
            {
                var listaDetalleProductos = servicio.listarOrdenesPorIdProducto(Convert.ToInt64(textBoxIDPro.Text));
                foreach (var detalle in listaDetalleProductos)
                {
                    ListViewItem lista = new ListViewItem(detalle.producto.idProducto.ToString());
                    lista.SubItems.Add(detalle.pedidos.idPedido.ToString());
                    lista.SubItems.Add(detalle.cantidad.ToString());
                    lista.SubItems.Add(detalle.precio.ToString());
                    lista.SubItems.Add(detalle.fecha.ToString());
                    listView1.Items.Add(lista);

                }
                return;
            }


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
