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
    public partial class ProveedorPagina : System.Web.UI.Page
    {
        EntidadProveedor conexion = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                conexion = new EntidadProveedor(ConfigurationManager.ConnectionStrings["conec1"].ConnectionString);
                Session["prove"] = conexion;
            }
            else
            {
                conexion = (EntidadProveedor)Session["prove"];
            }
        }

        protected void BtnPaginaAnterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string msg = "";
            conexion.InsertarProveedor(TextBox1.Text, TextBox14.Text, TextBox2.Text, TextBox3.Text, TextBox15.Text, TextBox4.Text, TextBox5.Text, ref msg);
            LbRegistro.Text = msg;
            TextBox1.Text = "";
            TextBox14.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox15.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            GridView1.DataSource = conexion.ObtenerProveedor_DataTable(ref mensaje, TextBox6.Text);
            GridView1.DataBind();
            LbMensajeConsulta.Text = mensaje;
            TextBox6.Text = "";
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            conexion.ActualizarProveedor(TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, ref mensaje);
            LbActualizar.Text = mensaje;
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            conexion.EliminarCliente(TextBox16.Text, ref mensaje);
            LbEliminar.Text = mensaje;
            TextBox12.Text = "";
        }
    }
}