<%@ Page Title="" Language="C#" MasterPageFile="~/TiendaElectronica.Master" AutoEventWireup="true" CodeBehind="WebVentaYListado.aspx.cs" Inherits="Vista.WebVentaYListado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Listado Ventas</h3>
    <asp:GridView ID="gvVentas" runat="server">
    </asp:GridView>

    <h3>Listado productos</h3>
    <asp:GridView ID="gvProductos" runat="server">
    </asp:GridView>
    
</asp:Content>
