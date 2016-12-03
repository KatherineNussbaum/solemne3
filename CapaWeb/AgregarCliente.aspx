<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="CapaWeb.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 139px;
        }
        .auto-style2 {
            width: 138px;
        }
        .auto-style3 {
            width: 139px;
            height: 30px;
        }
        .auto-style4 {
            width: 138px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Agregar Cliente</h2>
    <p>Usuario: <asp:Label ID="LblUsuario" runat="server" Text="Label" Visible="false" ></asp:Label></p>
    <asp:Label ID="LblMensaje" Visible="false" runat="server" Text="Label"></asp:Label>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">Rut:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtRut" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RfvRut" runat="server" ControlToValidate="TxtRut" ErrorMessage="Rut es obligatorio">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Nombre Completo:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Dirección:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
            </td>
            <td class="auto-style5"></td>
        </tr>
    </table>

    <asp:ValidationSummary ID="ValSumCliente" runat="server" EnableTheming="True" ShowMessageBox="True" ShowSummary="False" />
</asp:Content>
