using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSQLDataSet.Logica
{
    public static class ClientesClass
    {
        public static int Id { get; set; }
        public static string Nombre { get; set; }
        public static string Direccion { get; set; }
        public static string Sexo{ get; set; }
        public static  DateTime FechaNacimiento { get; set; }
        public static bool esNuevo { get; set; }

        public static void nuevoCliente(string _nombre, string _direccion,string _sexo, string _fechaNacimiento)
        {
            TiendaDataSetTableAdapters.ClientesTableAdapter TADatos = new TiendaDataSetTableAdapters.ClientesTableAdapter();
            TADatos.InsertQuery(_nombre, _direccion,_sexo,_fechaNacimiento);
        }

        public static void editarCliente(int _id, string _nombre, string _direccion, int _idOriginal,string _sexo, string _fechaNacimiento)
        {
            TiendaDataSetTableAdapters.ClientesTableAdapter TADatos = new TiendaDataSetTableAdapters.ClientesTableAdapter();
            TADatos.UpdateQuery( _nombre, _direccion,_sexo,_fechaNacimiento, _idOriginal);
        }
        public static void eliminarCliente(int _id)
        {
            TiendaDataSetTableAdapters.ClientesTableAdapter TADatos = new TiendaDataSetTableAdapters.ClientesTableAdapter();
            TADatos.DeleteQuery(_id);
        }
    }
}