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
    public class EntidadCliente
    {
        private ConexionSQL conexion = null;
        public EntidadCliente(string cadenaConexion)
        {
            conexion = new ConexionSQL(cadenaConexion);
        }


        //------------------------------------------------------------------------INSERTAR CLIENTE
        public Boolean InsertarCliente(string RazonSoc, string Direccion, string Telefono, string Cp, string Correo, ref string mensaje)
        {
            string insert = "insert into Cliente(RazonSocial,Direccion,Telefono,CP,correo)" +
                "values (@RazonSoc, @Direccion, @Telefono, @Cp, @Correo);";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("RazonSoc", SqlDbType.VarChar,250),
                new SqlParameter("Direccion", SqlDbType.VarChar,250),
                new SqlParameter("Telefono", SqlDbType.VarChar,20),
                new SqlParameter("Cp", SqlDbType.VarChar,20),
                new SqlParameter("Correo", SqlDbType.VarChar,250),
            };
            datosCliente[0].Value = RazonSoc;
            datosCliente[1].Value = Direccion;
            datosCliente[2].Value = Telefono;
            datosCliente[3].Value = Cp;
            datosCliente[4].Value = Correo;

            Boolean salida = false;
            salida = conexion.InsertarBD(insert, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            return salida;
        }


        //------------------------------------------------------------------------CONSULTAR CLIENTE
        public DataTable ObtenerClientes_DataTable(ref string mensaje, string correo)
        {
            string consulta = "select f.Folio, f.Fecha, c.RazonSocial, c.Direccion, c.Telefono, c.CP, c.correo from FacturaCompra f, Cliente c where correo = '" + correo + "';";
            DataSet obtener = null;
            DataTable salida = null;
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("correo", SqlDbType.VarChar,250),
            };
            datosCliente[0].Value = correo;
            obtener = conexion.Consulta_DataSet(consulta, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        //------------------------------------------------------------------------MODIFICAR CLIENTE
        public Boolean ActualizarCliente(string RazonSoc, string Direccion, string Telefono, string Cp, string Correo, ref string mensaje)
        {
            string insert = "update Cliente set RazonSocial='" + RazonSoc + "',Direccion='" + Direccion + "',Telefono='" + Telefono + "',CP='" + Cp + "',correo='" + Correo + "' where correo='" + Correo + "';";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("RazonSoc", SqlDbType.VarChar,250),
                new SqlParameter("Direccion", SqlDbType.VarChar,250),
                new SqlParameter("Telefono", SqlDbType.VarChar,20),
                new SqlParameter("Cp", SqlDbType.VarChar,20),
                new SqlParameter("Correo", SqlDbType.VarChar,250),
            };
            datosCliente[0].Value = RazonSoc;
            datosCliente[1].Value = Direccion;
            datosCliente[2].Value = Telefono;
            datosCliente[3].Value = Cp;
            datosCliente[4].Value = Correo;

            Boolean salida = false;
            salida = conexion.ModificarBD(insert, conexion.AbrirConexion(ref mensaje), ref mensaje);
            return salida;
        }

        //------------------------------------------------------------------------ELIMINAR CLIENTE
        public Boolean EliminarCliente(string Correo, ref string mensaje)
        {
            string delete = "delete Cliente where correo ='" + Correo + "';";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Correo", SqlDbType.VarChar,250),
            };
            datosCliente[0].Value = Correo;

            Boolean salida = false;
            salida = conexion.ModificarBD(delete, conexion.AbrirConexion(ref mensaje), ref mensaje);
            return salida;
        }

    }
}
