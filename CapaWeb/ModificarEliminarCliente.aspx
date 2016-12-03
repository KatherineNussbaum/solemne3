<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="ModificarEliminarCliente.aspx.cs" Inherits="CapaWeb.ModificarEliminarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 86px;
        }
        .auto-style2 {
            width: 138px;
        }
        .auto-style3 {
            width: 12px;
        }
        .auto-style4 {
            width: 86px;
            height: 26px;
        }
        .auto-style5 {
            width: 138px;
            height: 26px;
        }
        .auto-style6 {
            width: 12px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 86px;
            height: 54px;
        }
        .auto-style9 {
            width: 138px;
            height: 54px;
        }
        .auto-style10 {
            width: 12px;
            height: 54px;
        }
        .auto-style11 {
            height: 54px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Modificar y Eliminar Cliente</h2>
    <p>Usuario: <asp:Label ID="LblUsuario" runat="server" Text="Label" Visible="false" ></asp:Label></p>
    <asp:Label ID="LblMensaje" Visible="false" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="LblId" runat="server" Text="Label" Visible="false"></asp:Label>
    <br />

    <table style="width: 100%;">
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style2">
                <asp:DropDownList ID="DdlRutCliente" runat="server" AutoPostBack="True" DataSourceID="OdsRutClientes" DataTextField="Rut" DataValueField="Rut">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar Cliente" OnClick="BtnBuscar_Click" />
                <asp:ObjectDataSource ID="OdsRutClientes" runat="server" SelectMethod="ListarClientes" TypeName="CapaWeb.ClienteServ.ServicioClienteClient">

                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Rut:</td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtRut" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Nombre:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Dirección</td>
            <td class="auto-style5">
                <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
            </td>
        </tr>
    </table>
    </asp:Content>
