<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pasajero.aspx.cs" Inherits="WebAeropuerto.Pasajero1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style type="text/css">
        .auto-style3 {
             width: 28px;
         }
    </style>
        <div>
 
             <p>
        Registro de pasajeros:</p>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">Nombre:</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="189px" MaxLength="15"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar nombre">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido:</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server" Width="188px" MaxLength="15"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Debe ingresar apellido">(*)</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvNombreApellido" runat="server" ControlToCompare="txtNombre" ControlToValidate="txtApellido" ErrorMessage="Nombre y apellido deben ser diferentes" Operator="NotEqual">(*)</asp:CompareValidator>
               </td>
               </tr>
               <tr>
                <td class="auto-style3">Identificacion:</td>
                <td>
                <asp:TextBox ID="txtIdentificacion" runat="server" Width="186px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtIdentificacion" Display="None" ErrorMessage="Identificacion requerida"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtIdentificacion" Display="None" ErrorMessage="Número debe ser entre 100.000 y 999.999.999" MaximumValue="999999999" MinimumValue="100000" Type="Integer"></asp:RangeValidator>
                <tr>
                <td class="auto-style3">Pais de Origen:</td>
                <td>
                    <asp:DropDownList ID="ddlPais" runat="server" Height="17px" Width="197px" ItemType="string">
                    <asp:ListItem>Argentina</asp:ListItem>
                    <asp:ListItem>Bolivia</asp:ListItem>
                    <asp:ListItem>Brasil</asp:ListItem>
                    <asp:ListItem>Chile</asp:ListItem>
                    <asp:ListItem>Perú</asp:ListItem>
                    <asp:ListItem>Uruguay</asp:ListItem>
                    <asp:ListItem>Otros</asp:ListItem>
                    </asp:DropDownList>
                <tr>
                <td class="auto-style3">Codigo de Reserva:</td>
                <td>
                <asp:TextBox ID="txtCodigo" runat="server" ToolTip="Formato: AAA999" Width="192px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCodigo" Display="None" ErrorMessage="Código requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtCodigo" Display="None" ErrorMessage="Código inválido" ValidationExpression="^[A-Z]{3}\d{3}$"></asp:RegularExpressionValidator>
                <tr>
                <td class="auto-style3"></td>
                <td>
                 <asp:Button ID="btnGrabar" runat="server" CausesValidation="False" OnClick="btnGrabar_Click" Text="Grabar" />
&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="btnVolver_Click" Text="Vovler a registros" />
                     &nbsp;&nbsp;
                <asp:Button ID="btnVolverlist" runat="server" CausesValidation="False" OnClick="btnVolver_Click" Text="Volver al Listado" Width="148px" />
                <br />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="70px" />
                <p>

</table>
  </div>
</asp:Content>
