<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaCotizaciones._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        // Redirección automática al sistema principal
        window.location.href = 'Pages/Default.aspx';
    </script>
    
    <div style="text-align: center; padding: 50px;">
        <h2>Cargando Sistema de Cotizaciones...</h2>
        <p>Si no es redirigido automáticamente, <a href="Pages/Default.aspx">haga clic aquí</a></p>
    </div>
</asp:Content>