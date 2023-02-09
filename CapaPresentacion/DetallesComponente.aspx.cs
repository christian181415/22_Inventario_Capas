using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocios;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class DetallesComponente : System.Web.UI.Page
    {
        EntidadComponenteGenerico conexion = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                conexion = new EntidadComponenteGenerico(ConfigurationManager.ConnectionStrings["conec1"].ConnectionString);
                Session["ComponenenteGenerico"] = conexion;
            }
            else
            {
                conexion = (EntidadComponenteGenerico)Session["ComponenteGenerico"];
            }
        }

        protected void BtnPaginaAnterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientePagina.aspx");
        }

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            GridView1.DataSource = conexion.ObtenerComponente_DataTable(ref mensaje, TextBox13.Text);
            GridView1.DataBind();
            LbMensajeConsulta.Text = mensaje;
        }
    }
}