<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacturaCompra.aspx.cs" Inherits="CapaPresentacion.FacturaCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Estilos.css" type="text/css" media="screen"/>
    <title>Factura Compra</title>
</head>
<body background="https://fondosmil.com/fondo/27475.jpg" text="black">
    <form id="form1" runat="server">
        <div class="contenedor">
            <center>
                <div style="background-color:#808080">
                <h1 style="background-color:#808080">[FACTURA COMPRA]</h1>
                <asp:Button ID="BtnPaginaAnterior" runat="server" Text="Pagina anterior" OnClick="BtnPaginaAnterior_Click" />
            </div><div></div>
            <div>
                <center>
                    <br />
                    <h2>[Mostrar Factura]</h2>
                    <br />
                    <asp:Button ID="BtnConsulta" runat="server" OnClick="BtnConsulta_Click" Text="Consultar" />
                    <br />
                    <asp:Label ID="LbMensajeConsulta" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField AccessibleHeaderText="HOLA" />
                        </Columns>
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
&nbsp;&nbsp;
                    <br />
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" Width="471px">
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
                    <br />
                </center>
            </div>
            <div></div>
            <div>
                <div style="background-color:#808080">---------------------------------------------------------------------</div>

            </div>
            </center>
        </div>
    </form>
</body>
</html>
