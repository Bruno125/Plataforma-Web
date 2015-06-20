<%@ Page Title="" Language="C#" MasterPageFile="~/MasterExternal.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="NorthwindWeb.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Pagina de error: </h2>
        <asp:Panel id="InnerErrorPanel" runat="server" Visible="false">
            <p>
                Errores internos: <br />
                <asp:Label ID="LblErrorInterno" runat="server" 
                    Font-Bold="true" Font-Size="Large" /> <br />
            </p>
            <pre>
                <asp:Label ID="LblTraceInterno" runat="server" />
            </pre>
        </asp:Panel>
        <p>
            Mensaje de error: <br />
            <asp:Label ID="LblErrorMensaje" runat="server" 
                Font-Bold="true" Font-Size="Large" /> 
        </p>
        <pre>
            <asp:Label ID="LblErrorTrace" runat="server" Visible="false" />
        </pre>
        <br />
        Regresar a la página de <asp:LinkButton ID="LinkInicio" runat="server">
                                Inicio
                                </asp:LinkButton>
    </div>
</asp:Content>
