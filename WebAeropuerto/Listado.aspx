<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="WebAeropuerto.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:ListBox ID="lstPasajeros" runat="server" Width="452px"></asp:ListBox>
    </p>
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
    <p>
        <asp:Button ID="Eliminar" runat="server" OnClick="Eliminar_Click" Text="Eliminar" />
&nbsp;
        <asp:Button ID="verRegistro" runat="server" OnClick="verRegistro_Click" Text="Ver Registros" />
    </p>
</asp:Content>
