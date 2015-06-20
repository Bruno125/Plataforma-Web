<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterInternal.Master" AutoEventWireup="true" CodeBehind="MntCategoria.aspx.cs" Inherits="NorthwindWeb.Pages.Categoria.MntCategoria" %>

<%@ Import Namespace="NorthwindBusiness.Business" %>
<%@ Import Namespace="NorthwindEntity.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div id="divPrincipal">
        
        <asp:GridView ID="GvCategorias" runat="server" AutoGenerateColumns="False" OnRowDeleting="GvCategorias_RowDeleting" OnRowEditing="GvCategorias_RowEditing">
            <Columns>
                <asp:BoundField DataField="CategoryID" HeaderText="Código" />
                <asp:BoundField DataField="CategoryName" HeaderText="Nombre" />
                <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Resources/img/delete.png" DeleteText="Eliminar" EditImageUrl="~/Resources/img/edit.png" EditText="Editar" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <div>
            <asp:Label ID="LblMensaje" runat="server" Text="" />
        </div>
        
    </div>
</asp:Content>
