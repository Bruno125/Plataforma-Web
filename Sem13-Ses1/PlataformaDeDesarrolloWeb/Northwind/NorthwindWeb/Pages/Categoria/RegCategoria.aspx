<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterInternal.Master" AutoEventWireup="true" CodeBehind="RegCategoria.aspx.cs" Inherits="NorthwindWeb.Pages.Categoria.RegCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table>
        <tr>
            <td>Nombre:</td>
            <td>
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtNombre" CssClass="errores" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Descripcion:</td>
            <td>
                <asp:TextBox ID="TxtDescipcion" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtDescipcion" CssClass="errores" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="BtnRegistrar" runat="server" OnClick="BtnRegistrar_Click" Text="Registrar" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="LblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
