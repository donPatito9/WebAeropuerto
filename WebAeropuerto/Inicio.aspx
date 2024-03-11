<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebAeropuerto.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p id="imagelogo">Bienvenido al Aeropuerto regional</p>

    <asp:Button ID="btnInicio" runat="server" OnClick="btnInicio_Click" Text="Iniciar " />
</asp:Content>
