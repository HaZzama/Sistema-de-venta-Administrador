using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_venta_Administrador.Entidad
{
    class cliente
    {
        private string rut;
        private string nombre;
        private string telefono;
        private string direccion;
         public cliente (string rut,string nombre,string telefono,string direccion){
            Rut = rut;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
       
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
      
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }       

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
