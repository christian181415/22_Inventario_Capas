<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProveedorPagina.aspx.cs" Inherits="CapaPresentacion.ProveedorPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Estilos.css" type="text/css" media="screen"/>
    <title></title>
</head>
<body background="https://fondosmil.com/fondo/27475.jpg" text="black">
    <form id="form1" runat="server">
        <div class="contenedor">
            <center>
                <div style="background-color:#808080">
                <h1 style="background-color:#808080">[PROVEEDOR]</h1>
                <asp:Button ID="BtnPaginaAnterior" runat="server" Text="Pagina anterior" OnClick="BtnPaginaAnterior_Click" />
            </div><div></div>
            <div>
                <h2>[Registrar Proveedor]</h2>
                Nombre:&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label13" runat="server" Text="Contacto:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Dirección:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Telefono:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label14" runat="server" Text="Pagina Web:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="RFC:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="CP:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="LbRegistro" runat="server"></asp:Label>
                <br />
                <asp:Button ID="BtnRegistrar" runat="server" OnClick="BtnRegistrar_Click" Text="Registrar" />
                <br />
                <br />
            </div>
            <div>
                <div style="background-color:#808080">---------------------------------------------------------------------</div>
                <center>
                    <br />
                    <h2>[Mostrar Proveedor]</h2>
                    <asp:Label ID="Label15" runat="server" BackColor="#99CCFF" Text="Nombre:"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="BtnConsulta" runat="server" OnClick="BtnConsulta_Click" Text="Consultar" />
                    <br />
                    <br />
                    <asp:Label ID="LbMensajeConsulta" runat="server"></asp:Label>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" Width="598px">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                </center>
            </div>
            <div></div>
            <div>
                <div style="background-color:#808080">---------------------------------------------------------------------</div>
                <br/><h2>[Actualizar Datos]</h2>
                <asp:Label ID="Label6" runat="server" Text="Nombre:" BackColor="#99CCFF"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Contacto:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Text="Direccion:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Telefono:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" runat="server" Text="Pagina Web:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label11" runat="server" Text="RFC:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label12" runat="server" Text="CP:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="LbActualizar" runat="server"></asp:Label>
                <br />
                <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click" />
                <br />
                <br />
                <br />
            </div>
            <div>
                <div style="background-color:#808080">---------------------------------------------------------------------</div>
                <br /><br />
                <h2>[Eliminar Proveedor]</h2>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Nombre:" BackColor="#99CCFF"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LbEliminar" runat="server"></asp:Label>
                <br />
                <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
            </center>
        </div>
    </form>
</body>
</html>
