<%@ Page Title="" Language="C#" MasterPageFile="~/MasterExternal.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NorthwindWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div id="divPrincipal">
        <table border ="0">
            <tr>
                <td>Usuario: </td>
                <td>
                    <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUsuario" CssClass="errores" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Clave: </td>
                <td>
                    <asp:TextBox ID="TxtClave" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtClave" CssClass="errores" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="BtnIniciar" runat="server" OnClick="BtnIniciar_Click" Text="Iniciar Sesión" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="LblMensaje" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
