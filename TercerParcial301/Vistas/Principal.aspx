<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="TercerParcial301.Vistas.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Vistas/Calificaciones.aspx">Consulta de Calificaciones</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Vistas/RegistroCalificaciones.aspx">Registrar Calificaciones</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Vistas/RegistroAlumno.aspx">Registrar Datos de Alumno</asp:LinkButton>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
