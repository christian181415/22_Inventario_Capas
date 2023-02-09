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
    public partial class FacturaCompra : System.Web.UI.Page
    {
        EntidadFacturaCompra conexion = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                conexion = new EntidadFacturaCompra(ConfigurationManager.ConnectionStrings["conec1"].ConnectionString);
                Session["factura"] = conexion;
                //TextBox2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                conexion = (EntidadFacturaCompra)Session["factura"];
            }
        }

        protected void BtnPaginaAnterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientePagina.aspx");
        }

        //protected void BtnRegistrarCliente_Click(object sender, EventArgs e)
        //{
        //    DateTime fecha = Convert.ToDateTime(TextBox2.Text);
        //    fecha = fecha.AddDays(0);
        //    TextBox2.Text = fecha.ToString("yyyy-MM-dd");
        //}

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            GridView1.DataSource = conexion.ObtenerFacturaCompra_DataTable(ref mensaje);
            GridView1.DataBind();
            GridView2.DataSource = conexion.ObtenerTotalFactura_DataTable(ref mensaje);
            GridView2.DataBind();
            LbMensajeConsulta.Text = mensaje;
        }
    }
}