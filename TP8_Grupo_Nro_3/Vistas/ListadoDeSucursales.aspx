<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="Vistas.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 233px;
        }
        .auto-style4 {
            width: 233px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 314px;
            height: 23px;
        }
        .auto-style8 {
            width: 314px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:HyperLink ID="hplBtnAgregarSucursal" runat="server">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style7">
                    <asp:HyperLink ID="hlbtnListadoSucursales" runat="server">Listado de sucursales</asp:HyperLink>
                </td>
                <td class="auto-style6">
                    <asp:HyperLink ID="hplbtnEliminarSucursal" runat="server">Eliminar sucursal</asp:HyperLink>
                </td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><strong><FONT SIZE=5>Listado de sucursales</font></strong></td>
                <td class="auto-style7"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Busqueda: Ingrese Id sucursal:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtIdSucursal" runat="server" Width="293px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
