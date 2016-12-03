<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="CapaWeb.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Productos</h2>
    <p>Usuario: <asp:Label ID="LblUsuario" runat="server" Text="Label" Visible="false" ></asp:Label></p>
    
    <asp:GridView ID="GvProducto" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="OdsProductos">
        <Columns>
            <asp:BoundField DataField="IdProducto" HeaderText="IdProducto" SortExpression="IdProducto" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="OdsProductos" runat="server" SelectMethod="ListarProductos" TypeName="CapaWeb.ProductoServ.ServicioProductoClient"></asp:ObjectDataSource>

</asp:Content>
