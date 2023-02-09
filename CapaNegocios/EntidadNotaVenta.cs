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
    public class EntidadNotaVenta
    {
        private ConexionSQL conexion = null;
        public EntidadNotaVenta(string cadenaConexion)
        {
            conexion = new ConexionSQL(cadenaConexion);
        }

        //--------------------------------------------------------------------INSERTAR PROVEEDOR
        //--------------------------------------------------------------------CONSULTAR PROVEEDOR
        public DataTable ObtenerNota_DataTable(ref string mensaje, string Folio)
        {
            string consulta = "SELECT * from NotaVenta NV INNER JOIN ContenidoNota CN on NV.Id_Nota = CN.id_ContNota AND NV.Folio = '"+Folio+"'; ";
            DataSet obtener = null;
            DataTable salida = null;
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Folio", SqlDbType.VarChar,20),
            };
            datosCliente[0].Value = Folio;
            obtener = conexion.Consulta_DataSet(consulta, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public DataTable ObtenerGanancia_DataTable(ref string mensaje, string Folio)
        {
            string consulta = "SELECT CN.PrecioVenta-CF.PrecioCompra AS \" Ganancia \" from ContenidoNota CN INNER JOIN ContenidoFactura CF on CN.F_ContFactura = CF.Id_Cont INNER JOIN NotaVenta NV on CN.F_Nota = NV.Id_Nota AND NV.Folio = '" + Folio + "'; ";
            DataSet obtener = null;
            DataTable salida = null;
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Folio", SqlDbType.VarChar,20),
            };
            datosCliente[0].Value = Folio;
            obtener = conexion.Consulta_DataSet(consulta, conexion.AbrirConexion(ref mensaje), ref mensaje, datosCliente);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        //--------------------------------------------------------------------MODIFICAR PROVEEDOR
        //--------------------------------------------------------------------ELIMINAR PROVEEDOR
    }
}
