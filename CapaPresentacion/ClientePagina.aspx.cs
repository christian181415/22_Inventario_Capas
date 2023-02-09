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
    public partial class ClienteRegistro : System.Web.UI.Page
    {
        EntidadProveedor conexion = null;
        EntidadCliente conectar = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                conectar = new EntidadCliente(ConfigurationManager.ConnectionStrings["conec1"].ConnectionString);
                Session["cliente"] = conectar;
                conexion = new EntidadProveedor(ConfigurationManager.ConnectionStrings["conec1"].ConnectionString);
                Session["prove"] = conexion;
            }
            else
            {
                conectar = (EntidadCliente)Session["cliente"];
                conexion = (EntidadProveedor)Session["prove"];
            }
        }

        protected void BtnPaginaAnterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string msg = "";
            conectar.InsertarCliente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, ref msg);
            LbRegistro.Text = msg;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            GridView1.DataSource = conectar.ObtenerClientes_DataTable(ref mensaje, TextBox6.Text);
            GridView1.DataBind();
            LbMensajeConsulta.Text = mensaje;
            TextBox6.Text = "";
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            conectar.ActualizarCliente(TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, ref mensaje);
            LbActualizar.Text = mensaje;
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            conectar.EliminarCliente(TextBox12.Text, ref mensaje);
            LbEliminar.Text = mensaje;
            TextBox12.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FacturaCompra.aspx");
        }

        protected void BtnNotaVenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("NotaVenta.aspx");
        }

        protected void BtnDetallesComponentes_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetallesComponente.aspx");
        }
    }
}