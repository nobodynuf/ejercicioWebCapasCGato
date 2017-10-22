<%@ Page Title="" Language="C#" MasterPageFile="~/Session.Master" AutoEventWireup="true" CodeBehind="WebInicio.aspx.cs" Inherits="Vista.WebInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;font-weight:bolder">
        <h3>Bienvenido, ingrese credenciales</h3>
        Usuario <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        Password<asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Ingresar" OnClick="btnEnviar_Click" />
        
    </div>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
</asp:Content>
