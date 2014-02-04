using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema_de_venta_Administrador.Entidad;

namespace Sistema_de_venta_Administrador
{
    public partial class Gestionar_categoria : Form
    {
        public Gestionar_categoria()
        {
            InitializeComponent();
            txtCodigo.Enabled = true;
        }

        private void btnIngresarCategoria_Click(object sender, EventArgs e)
        {
            categoria ct = new categoria(txtCodigo.Text,txtNombre.Text);
        }

       
    }
}
