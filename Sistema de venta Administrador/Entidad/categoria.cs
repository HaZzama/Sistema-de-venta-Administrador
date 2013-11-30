using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_venta_Administrador.Entidad
{
    class categoria
    {
        private string nombre;
        private string codigo;
        public categoria(string nombre, string codigo) {
            Nombre = nombre;
            Codigo = codigo;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
     

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
