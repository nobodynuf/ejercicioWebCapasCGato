<%@ Page Title="" Language="C#" MasterPageFile="~/TiendaElectronica.Master" AutoEventWireup="true" CodeBehind="WebListarRango.aspx.cs" Inherits="Vista.WebListarRango" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <h3>
            Busqueda productos por rango
        </h3>
        <tr>
            <td>Rango inferior</td>
            
            <td><asp:TextBox ID="txtRMenor" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Rango mayor</td>
            <td><asp:TextBox ID="txtRMayor" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnGO" runat="server" Text="GO" OnClick="btnGO_Click" /></td>
            
        </tr>
    </table>

    <asp:GridView ID="gvProductos" runat="server">
    </asp:GridView>
</asp:Content>
