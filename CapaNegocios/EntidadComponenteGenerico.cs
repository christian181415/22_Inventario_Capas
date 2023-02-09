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
    public class EntidadComponenteGenerico
    {
        private ConexionSQL conexion = null;
        public EntidadComponenteGenerico(string cadenaConexion)
        {
            conexion = new ConexionSQL(cadenaConexion);
        }

        //--------------------------------------------------------------------INSERTAR PROVEEDOR
        //--------------------------------------------------------------------CONSULTAR PROVEEDOR
        public DataTable ObtenerComponente_DataTable(ref string mensaje, string NumSerie)
        {
            string consulta = "Select CG.Nombre, M.Marca, Cat.NombreCate, Cli.correo, NV.Fecha, CN.DiasGarantia  from Categoria Cat INNER JOIN ComponenteGenerico CG on Cat.Id_Categoria = CG.F_Categoria INNER JOIN Marca M on M.id_Marca = CG.F_Marca INNER JOIN ContenidoFactura CF on CF.F_Componente = CG.Id_Componente INNER JOIN ContenidoNota CN on CN.id_ContNota = CF.F_factura INNER JOIN NotaVenta NV on NV.Id_Nota = CN.F_Nota INNER JOIN Cliente Cli on Cli.Id_Cliente = NV.F_Cliente AND CF.NumSerie =  '" + NumSerie + "'; ";
            DataSet obtener = null;
            DataTable salida = null;
            SqlParameter[] datosCliente = new SqlParameter[]
            {
                new SqlParameter("Folio", SqlDbType.VarChar,20),
            };
            datosCliente[0].Value = NumSerie;
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
