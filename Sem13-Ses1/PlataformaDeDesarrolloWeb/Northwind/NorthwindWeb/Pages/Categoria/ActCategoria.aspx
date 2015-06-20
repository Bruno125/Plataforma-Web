<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterInternal.Master" AutoEventWireup="true" CodeBehind="ActCategoria.aspx.cs" Inherits="NorthwindWeb.Pages.Categoria.ActCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table>
        <tr>
            <td>Código: </td>
            <td>
                <asp:TextBox ID="TxtCodigo" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nombre: </td>
            <td>
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RqfNombre" runat="server" ControlToValidate="TxtNombre" CssClass="errores" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Descripción: </td>
            <td>
                <asp:TextBox ID="TxtDescripcion" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtDescripcion" CssClass="errores" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="BtnActualizar" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" />
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
