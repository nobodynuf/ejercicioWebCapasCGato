<%@ Page Title="" Language="C#" MasterPageFile="~/TiendaElectronica.Master" AutoEventWireup="true" CodeBehind="WebIngresar.aspx.cs" Inherits="Vista.WebIngresar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Administrador de ventas y productos</h3>
    
    <h4>Ingreso producto</h4>
    <table>
        <tr>
            <td>
                Marca
            </td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Modelo
            </td>
            <td>
                <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Tipo
            </td>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Precio
            </td>
            <td>
                <asp:TextBox TextMode="Number" ID="txtPrecio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnGuardar" runat="server"  text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnLimpiar" runat="server" text="Limpiar" />
            </td>
        </tr>
    </table>
</asp:Content>
