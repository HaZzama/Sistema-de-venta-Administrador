using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_venta_Administrador.Entidad
{
    class proveedor
    {
        private string rut;
        private string nombre;
        private string telefono;
        private string direccion;
        private string verificador;

        public string Verificador
        {
            get { return verificador; }
            set { verificador = value; }
        }

        public proveedor(string rut,string verificador,string nombre,string direccion,string telefono){
            Rut = rut;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Verificador = verificador;
            
        }
        public proveedor(string rut,string verificador) {
            Rut = rut;
            Verificador = verificador;
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
