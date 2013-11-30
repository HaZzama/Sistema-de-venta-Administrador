using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_venta_Administrador.Entidad
{
    class producto
    {
        private string codigo;
        private string nombre;
        private int stock;      
        private int precio;

        public producto(string codigo,string nombre,int stock,int precio) {
            Codigo = codigo;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
