<%@ Page Title="" Language="C#" MasterPageFile="~/TiendaElectronica.Master" AutoEventWireup="true" CodeBehind="WebEliminarCodigo.aspx.cs" Inherits="Vista.WebEliminarCodigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Eliminar producto por codigo</h3>
    ID producto a borrar
    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    <asp:Button ID="btnEliminar" runat="server" Text="GO" OnClick="btnEliminar_Click" />
</asp:Content>
