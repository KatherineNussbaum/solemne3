<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
        .auto-style2 {
            width: 137px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido a la Plataforma &quot;Fuente de Soda&quot;</h1>
    <asp:Label ID="LblMensaje" runat="server" Text="Label" Visible="false"></asp:Label>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">Usuario:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RfvUsuario" runat="server" ControlToValidate="TxtUsuario" ErrorMessage="Usuario es obligatorio">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Contraseña:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RfvPass" runat="server" ControlToValidate="TxtPass" ErrorMessage="Contraseña es obligatorio">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:ValidationSummary ID="ValSumLogin" runat="server" ShowMessageBox="True" ShowSummary="False" />
    </asp:Content>
