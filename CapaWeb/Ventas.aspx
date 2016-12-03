<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="CapaWeb.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Mis Ventas realizadas</h2>
    <p>Usuario: <asp:Label ID="LblUsuario" runat="server" Text="Label" Visible="false" ></asp:Label></p>
    <asp:Label ID="LblId" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:ObjectDataSource ID="OdsVentas" runat="server" SelectMethod="ListarBoletaVendedorCliente" TypeName="CapaWeb.BoletaVendedorClienteServ.ServicioBoletaVendedorClienteClient">
        <SelectParameters>
            <asp:ControlParameter ControlID="LblUsuario" Name="usuario" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="numeroBoleta" DataSourceID="OdsVentas" GridLines="None">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="ClienteNombreCompleto" HeaderText="ClienteNombreCompleto" SortExpression="ClienteNombreCompleto" />
            <asp:BoundField DataField="ClienteRut" HeaderText="ClienteRut" SortExpression="ClienteRut" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
            <asp:BoundField DataField="NumeroBoleta" HeaderText="NumeroBoleta" SortExpression="NumeroBoleta" />
            <asp:BoundField DataField="UsuarioVendedor" HeaderText="UsuarioVendedor" SortExpression="UsuarioVendedor" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:ObjectDataSource ID="OdsDetalle" runat="server" SelectMethod="ListarDetalleProductos" TypeName="CapaWeb.DetalleProductoServ.ServicioDetalleProductoClient">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="NumeroBoleta" PropertyName="SelectedValue" Type="Decimal" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="OdsDetalle" Height="50px" Width="325px">
        <Fields>
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            <asp:BoundField DataField="IdDetalle" HeaderText="IdDetalle" SortExpression="IdDetalle" />
            <asp:BoundField DataField="NumeroBoleta" HeaderText="NumeroBoleta" SortExpression="NumeroBoleta" />
            <asp:BoundField DataField="ProductoNombre" HeaderText="ProductoNombre" SortExpression="ProductoNombre" />
            <asp:BoundField DataField="ProductoPrecio" HeaderText="ProductoPrecio" SortExpression="ProductoPrecio" />
        </Fields>
</asp:DetailsView>
    <br />
</asp:Content>
