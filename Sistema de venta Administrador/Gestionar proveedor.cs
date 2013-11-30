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
    public partial class Gestionar_proveedor : Form
    {
        public Gestionar_proveedor()
        {
            InitializeComponent();
        }

        private void btnIngreProveedor_Click(object sender, EventArgs e)
        {
            proveedor pv = new proveedor(txtRut.Text,txtNombre.Text,txtDireccion.Text,txtTelefono.Text);
            Datos.datos misdatos = new Datos.datos();
            misdatos.ingresarProveedor(pv);
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            proveedor eliminarproveedor = new proveedor(txtRut.Text);
            Datos.datos datos = new Datos.datos();
            if (datos.eliminarProveedor(eliminarproveedor)>0)
            {
                MessageBox.Show("registro eliminado");
            }
            else
            {
                MessageBox.Show("problemas al eliminar");
            }
            }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            proveedor actualizar = new proveedor(txtRut.Text, txtNombre.Text,txtTelefono.Text,txtDireccion.Text);
            Datos.datos miCDatos = new Datos.datos();
             miCDatos.mActualizar(actualizar);
             if (miCDatos.mActualizar(actualizar) > 0)
             {
                 MessageBox.Show("registro actualizado");
             }
           
        }
            
        }

        

       
    }

