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
            btnIngreProveedor.Enabled = false;
        }

        private void btnIngreProveedor_Click(object sender, EventArgs e)
        {
            proveedor pv = new proveedor(txtRut.Text,txtVer.Text,txtNombre.Text,txtDireccion.Text,txtTelefono.Text);
            Datos.datos misdatos = new Datos.datos();
            misdatos.ingresarProveedor(pv);
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            proveedor eliminarproveedor = new proveedor(txtRut.Text,txtVer.Text);
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
            proveedor actualizar = new proveedor(txtRut.Text, txtVer.Text,txtNombre.Text,txtTelefono.Text,txtDireccion.Text);
            Datos.datos miCDatos = new Datos.datos();
             miCDatos.mActualizar(actualizar);
             if (miCDatos.mActualizar(actualizar) > 0)
             {
                 MessageBox.Show("registro actualizado");
             }
           
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                int suma = 0;
                int pond = 2;
                int resto = 0;
                int digito = 0;
                string digVer = "";
                string rut1 = txtRut.Text;
                string[] rut2 = new string[rut1.Length];

                for (int i = 0; i < rut1.Length; i++)
                {
                    rut2[i] = rut1[i].ToString();
                }



                int largo = rut2.Length;
                for (int i = largo - 1; i > -1; i--)
                {
                    suma = suma + int.Parse(rut2[i]) * pond;
                    pond++;
                    if (pond > 7)
                    {
                        pond = 2;
                    }
                }
                resto = suma % 11;
                digito = 11 - resto;


                if (digito == 10)
                {
                    digVer = "k";
                }
                else if (digito == 11)
                {
                    digVer = "0";
                }
                else
                {
                    digVer = "" + digito;
                }


                if (Convert.ToInt32(txtVer.Text) == Convert.ToInt32(digVer))
                {
                    MessageBox.Show("El rut es correcto");
                    btnIngreProveedor.Enabled = true;

                }
                else
                {
                    MessageBox.Show("El rut es incorrecto");
                    btnIngreProveedor.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ingrese rut");
                txtRut.Focus();
            }
           
        }

        private void Gestionar_proveedor_Load(object sender, EventArgs e)
        {
            txtRut.MaxLength = 8;
            txtVer.MaxLength = 1;
        }
            
        }

        

       
    }

