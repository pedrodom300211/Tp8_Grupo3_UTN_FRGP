<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
<<<<<<< HEAD
=======
        .auto-style2 {
            height: 23px;
        }
>>>>>>> 870c888694d222a3cfb799afdb0d5f6992f12006
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlbtnAgregarSucursal" runat="server">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlbtnListarSucursal" runat="server">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlbtnEliminarSucursal" runat="server">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
<<<<<<< HEAD
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
=======
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
>>>>>>> 870c888694d222a3cfb799afdb0d5f6992f12006
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><strong>GRUPO Nº3</strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><strong>Agregar Sucursal</strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Nombre Sucursal:</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtNombreSucursal" runat="server" ValidationGroup="grupo1" Width="254px"></asp:TextBox>
<<<<<<< HEAD
=======
                        <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ValidationGroup="grupo1" ControlToValidate="txtNombreSucursal" ForeColor="#CC0000">Debe ingresar un nombre de sucursal</asp:RequiredFieldValidator>
>>>>>>> 870c888694d222a3cfb799afdb0d5f6992f12006
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Descripción:</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" ValidationGroup="grupo1" Width="254px"></asp:TextBox>
<<<<<<< HEAD
=======
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ValidationGroup="grupo1" ControlToValidate="txtDescripcion" ForeColor="#CC0000">Debe ingresar una descripcion</asp:RequiredFieldValidator>
>>>>>>> 870c888694d222a3cfb799afdb0d5f6992f12006
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Provincias:</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlProvincia" runat="server" Height="17px" ValidationGroup="grupo1" Width="262px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
<<<<<<< HEAD
                            <asp:ListItem Value="1">Buenos Aires</asp:ListItem>
                            <asp:ListItem Value="2">Entre Rios</asp:ListItem>
                            <asp:ListItem Value="3">Santa Fe</asp:ListItem>
                            <asp:ListItem Value="4">La Pampa</asp:ListItem>
                            <asp:ListItem Value="5">Cordoba</asp:ListItem>
                            <asp:ListItem Value="6">Misiones</asp:ListItem>
                            <asp:ListItem Value="7">Chaco</asp:ListItem>
                        </asp:DropDownList>
=======
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ValidationGroup="grupo1" ControlToValidate="ddlProvincia" InitialValue="--Seleccionar--" ForeColor="#CC0000">Debe seleccionar una provincia</asp:RequiredFieldValidator>
>>>>>>> 870c888694d222a3cfb799afdb0d5f6992f12006
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Dirección:</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtDireccion" runat="server" ValidationGroup="grupo1" Width="254px"></asp:TextBox>
<<<<<<< HEAD
=======
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ValidationGroup="grupo1" ControlToValidate="txtDescripcion" ForeColor="#CC0000">Debe ingresar una dirreción</asp:RequiredFieldValidator>
>>>>>>> 870c888694d222a3cfb799afdb0d5f6992f12006
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" ValidationGroup="grupo1" Width="89px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblAgregarDato" runat="server" Text="" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
