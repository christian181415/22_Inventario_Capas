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
    public class EntidadFacturaCompra
    {
        private ConexionSQL conexion = null;
        public EntidadFacturaCompra(string cadenaConexion)
        {
            conexion = new ConexionSQL(cadenaConexion);
        }

        //--------------------------------------------------------------------INSERTAR PROVEEDOR
        public Boolean InsertarFacturaCompra(string Folio, DateTime Fecha, int F_Proveedor, string AnotacionExtra, ref string mensaje)
        {
            string insert = "insert into FacturaCompra(Folio,Fecha,F_Proveedor,AnotacionExtra)" +
                "values (@Folio, @Fecha, @F_Proveedor, @AnotacionExtra);";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Folio", SqlDbType.VarChar,50),
                new SqlParameter("Fecha", SqlDbType.Date),
                new SqlParameter("F_Proveedor", SqlDbType.Int),
                new SqlParameter("AnotacionExtra", SqlDbType.VarChar,60),
            };
            datosCliente[0].Value = Folio;
            datosCliente[1].Value = Fecha;
            datosCliente[2].Value = F_Proveedor;
            datosCliente[3].Value = AnotacionExtra;



            Boolean salida = false;
            salida = conexion.InsertarBD(insert, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            return salida;
        }

        //--------------------------------------------------------------------CONSULTAR PROVEEDOR
        public DataTable ObtenerFacturaCompra_DataTable(ref string mensaje)
        {
            string consulta = "select * from FacturaCompra; ";
            DataSet obtener = null;
            DataTable salida = null;

            obtener = conexion.Consulta_DataSet_Simple(consulta, conexion.AbrirConexion(ref mensaje), ref mensaje);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }


        public DataTable ObtenerTotalFactura_DataTable(ref string mensaje)
        {
            string consulta = "SELECT SUM(PrecioCompra) AS \" Monto Facturas Total\" FROM FacturaCompra f INNER JOIN ContenidoFactura c ON f.Id_Factura = c.F_factura; ";
            DataSet obtener = null;
            DataTable salida = null;

            obtener = conexion.Consulta_DataSet_Simple(consulta, conexion.AbrirConexion(ref mensaje), ref mensaje);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        //--------------------------------------------------------------------MODIFICAR PROVEEDOR
        public Boolean ActualizarFacturaCompra(string Folio, DateTime Fecha, int F_Proveedor, string AnotacionExtra, ref string mensaje)
        {
            string insert = "update FacturaCompra set Folio='" + Folio + "', Fecha='" + Fecha + "', F_Proveedor='" + F_Proveedor + "',AnotacionExtra='" + AnotacionExtra + "' where Folio='" + Folio + "';";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Folio", SqlDbType.VarChar,50),
                new SqlParameter("Fecha", SqlDbType.Date),
                new SqlParameter("F_Proveedor", SqlDbType.Int),
                new SqlParameter("AnotacionExtra", SqlDbType.VarChar,60),
            };
            datosCliente[0].Value = Folio;
            datosCliente[1].Value = Fecha;
            datosCliente[2].Value = F_Proveedor;
            datosCliente[3].Value = AnotacionExtra;

            Boolean salida = false;
            salida = conexion.ModificarBD(insert, conexion.AbrirConexion(ref mensaje), ref mensaje);
            return salida;
        }

        //--------------------------------------------------------------------ELIMINAR PROVEEDOR
        public Boolean EliminarFacturaCompra(string Folio, ref string mensaje)
        {
            string delete = "delete FacturaCompra where Folio ='" + Folio + "';";
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Folio", SqlDbType.VarChar,50),
            };
            datosCliente[0].Value = Folio;

            Boolean salida = false;
            salida = conexion.ModificarBD(delete, conexion.AbrirConexion(ref mensaje), ref mensaje);
            return salida;
        }
    }
}
