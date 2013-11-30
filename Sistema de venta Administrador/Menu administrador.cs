using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_venta_Administrador
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            Gestionar_cliente cliente = new Gestionar_cliente();
            cliente.ShowDialog();
        }

        private void mnuProducto_Click(object sender, EventArgs e)
        {
            Gestionar_producto producto = new Gestionar_producto();
            producto.ShowDialog();
        }

        private void mnuProveedor_Click(object sender, EventArgs e)
        {
            Gestionar_proveedor proveedor = new Gestionar_proveedor();
            proveedor.ShowDialog();
        }

        private void mnuCategoria_Click(object sender, EventArgs e)
        {
            Gestionar_categoria categoria = new Gestionar_categoria();
            categoria.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
