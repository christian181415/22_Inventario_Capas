using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using AccesoSQL;

namespace CapaNegocios
{
    public class EntidadProveedor
    {
        private ConexionSQL conexion = null;
        public EntidadProveedor(string cadenaConexion)
        {
            conexion = new ConexionSQL(cadenaConexion);
        }

        //--------------------------------------------------------------------INSERTAR PROVEEDOR
        public Boolean InsertarProveedor(string NombreProvee, string Contacto, string Direccion, string Telefono, string PaginaWeb, string RFC, string CP, ref string mensaje)
        {
            string insert = "insert into Proveedor(NombreProvee,Contacto,Direccion,Telefono,PaginaWeb,RFC,CP)" +
                "values (@NombreProvee, @Contacto, @Direccion, @Telefono, @PaginaWeb, @RFC, @CP);";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("NombreProvee", SqlDbType.VarChar,250),
                new SqlParameter("Contacto", SqlDbType.VarChar,200),
                new SqlParameter("Direccion", SqlDbType.VarChar,250),
                new SqlParameter("Telefono", SqlDbType.VarChar,20),
                new SqlParameter("PaginaWeb", SqlDbType.VarChar,150),
                new SqlParameter("RFC", SqlDbType.VarChar,50),
                new SqlParameter("CP", SqlDbType.VarChar,50),
            };
            datosCliente[0].Value = NombreProvee;
            datosCliente[1].Value = Contacto;
            datosCliente[2].Value = Direccion;
            datosCliente[3].Value = Telefono;
            datosCliente[4].Value = PaginaWeb;
            datosCliente[5].Value = RFC;
            datosCliente[6].Value = CP;


            Boolean salida = false;
            salida = conexion.InsertarBD(insert, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            return salida;
        }

        //--------------------------------------------------------------------CONSULTAR PROVEEDOR
        public DataTable ObtenerProveedor_DataTable(ref string mensaje, string nombre)
        {
            string consulta = "select p.NombreProvee, p.Contacto, p.Direcccion, p.Telefono, p.PaginaWeb, p.RFC, p.CP from Proveedor p where NombreProvee = '" + nombre + "'; ";
            DataSet obtener = null;
            DataTable salida = null;
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("correo", SqlDbType.VarChar,250),
            };
            datosCliente[0].Value = nombre;
            obtener = conexion.Consulta_DataSet(consulta, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        //--------------------------------------------------------------------MODIFICAR PROVEEDOR
        public Boolean ActualizarProveedor(string Nombre, string Contacto, string Direccion, string Telefono, string PaginaWeb, string RFC, string CP, ref string mensaje)
        {
            string insert = "update Cliente set NombreProvee='" + Nombre + "', Contacto='" + Contacto + "', Direccion='" + Direccion + "',Telefono='" + Telefono + "',PaginaWeb='" + PaginaWeb + "',RFC='" + RFC + "', CP='" + CP + "' where NombreProvee='" + Nombre + "';";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("nom", SqlDbType.VarChar,250),
                new SqlParameter("contac", SqlDbType.VarChar,200),
                new SqlParameter("direcc", SqlDbType.VarChar,250),
                new SqlParameter("telef", SqlDbType.VarChar,20),
                new SqlParameter("paginaweb", SqlDbType.VarChar,150),
                new SqlParameter("rfc", SqlDbType.VarChar,50),
                new SqlParameter("cp", SqlDbType.VarChar,50),
            };
            datosCliente[0].Value = Nombre;
            datosCliente[1].Value = Contacto;
            datosCliente[2].Value = Direccion;
            datosCliente[3].Value = Telefono;
            datosCliente[4].Value = PaginaWeb;
            datosCliente[5].Value = RFC;
            datosCliente[6].Value = CP;

            Boolean salida = false;
            salida = conexion.ModificarBD(insert, conexion.AbrirConexion(ref mensaje), ref mensaje);
            return salida;
        }

        //--------------------------------------------------------------------ELIMINAR PROVEEDOR
        public Boolean EliminarCliente(string NombreProvee, ref string mensaje)
        {
            string delete = "delete Cliente where NombreProvee ='" + NombreProvee + "';";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("NombreProvee", SqlDbType.VarChar,250),
            };
            datosCliente[0].Value = NombreProvee;

            Boolean salida = false;
            salida = conexion.ModificarBD(delete, conexion.AbrirConexion(ref mensaje), ref mensaje);
            return salida;
        }

    }
}
