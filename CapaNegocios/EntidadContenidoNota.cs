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
    public class EntidadContenidoNota
    {
        private ConexionSQL conexion = null;
        public EntidadContenidoNota(string cadenaConexion)
        {
            conexion = new ConexionSQL(cadenaConexion);
        }

        //--------------------------------------------------------------------INSERTAR PROVEEDOR
        //--------------------------------------------------------------------CONSULTAR PROVEEDOR
        //--------------------------------------------------------------------MODIFICAR PROVEEDOR
        //--------------------------------------------------------------------ELIMINAR PROVEEDOR
    }
}
