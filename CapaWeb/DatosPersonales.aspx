<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="DatosPersonales.aspx.cs" Inherits="CapaWeb.DatosPersonales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 140px;
        }
        .auto-style2 {
            width: 140px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Datos Personales Vendedor</h2>
    <p>Usuario: <asp:Label ID="LblUsuario" runat="server" Text="Label" Visible="false" ></asp:Label></p>
    
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">Rut:</td>
            <td class="auto-style3">
                <asp:Label ID="LblRut" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style1">Nombre Completo:</td>
            <td>
                <asp:Label ID="LblNombre" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Dirección:</td>
            <td>
                <asp:Label ID="LblDireccion" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Sexo:</td>
            <td>
                <asp:Label ID="LblSexo" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Teléfono:</td>
            <td>
                <asp:Label ID="LblTelefono" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>
