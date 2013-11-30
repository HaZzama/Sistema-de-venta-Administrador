using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema_de_venta_Administrador.Entidad;
namespace Sistema_de_venta_Administrador.Datos
{
    class datos
    {
        public void ingresarCategoria(categoria objingresarCategoria) {
            SqlConnection cnn = new SqlConnection("Data Source=HAZAMA-PC\\HAZAMA;Initial Catalog=SistemaDeVenta;Integrated Security=True");
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cnn.Open();
            cmm.CommandText = "insert into Categoria values('"+objingresarCategoria.Codigo+"','"+objingresarCategoria.Nombre+"')";
            if (cmm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Datos Ingresados");

            }
            else
            {
                MessageBox.Show("Datos no Ingresados");
            }
            cnn.Close();
            cmm.Dispose();
            cnn.Dispose();

        }
        public void ingresarProveedor(proveedor objIngresar) {
            SqlConnection cnn = new SqlConnection("Data Source=HAZAMA-PC\\HAZAMA;Initial Catalog=SistemaDeVenta;Integrated Security=True");
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cnn.Open();
            cmm.CommandText = "insert into Proveedor values('"+objIngresar.Rut+"','"+objIngresar.Nombre+"','"+objIngresar.Telefono+"','"+objIngresar.Direccion+"')";
            if (cmm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Datos Ingresados");

            }
            else
            {
                MessageBox.Show("Datos no Ingresados");
            }
            cnn.Close();
            cmm.Dispose();
            cnn.Dispose();
        }
        public int eliminarProveedor(proveedor objEliminar) {
            SqlConnection cnn = new SqlConnection("Data Source=HAZAMA-PC\\HAZAMA;Initial Catalog=SistemaDeVenta;Integrated Security=True");
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cnn.Open();
            cmm.CommandText = "delete Proveedor where rut='" + objEliminar.Rut + "'";
            return cmm.ExecuteNonQuery();
            cnn.Close();
            cmm.Dispose();
            cnn.Dispose();
        }
        public int mActualizar(proveedor objActualizar)
        {
            SqlConnection cnn = new SqlConnection("Data Source=HAZAMA-PC\\HAZAMA;Initial Catalog=SistemaDeVenta;Integrated Security=True");
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cnn.Open();
            cmm.CommandText = "update Proveedor set nombreProveedor='" + objActualizar.Nombre + "', telefonoProveedor='" + objActualizar.Telefono + "', direccion='" + objActualizar.Direccion+ "' where rut='" + objActualizar.Rut + "'";
            return cmm.ExecuteNonQuery();
            
        }
    }
}
