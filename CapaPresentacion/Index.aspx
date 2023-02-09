<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaPresentacion.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Estilos.css" type="text/css" media="screen"/>
    <title>Ventas HNS</title>
    </head>
<body background="https://fondosmil.com/fondo/27475.jpg" text="black">
    <form id="form1" runat="server">
        <div class="text-center">
            <center>
                <h1 style="background-color:#808080">
                    &nbsp;<asp:Button ID="BtnCliente" runat="server" OnClick="BtnCliente_Click" Text="Cliente" />
                    &nbsp;&nbsp;&nbsp;   
                    [INVENTARIO DIGITAL]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnProveedor" runat="server" OnClick="BtnProveedor_Click" Text="Proveedor" />
                </h1>
            </center>
        </div>
        <div></div>
        <div>
            <center>
                BIENVENIDO
            </center>
        </div>
    </form>
</body>
