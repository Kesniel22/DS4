<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio__20._3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Gestión de Productos</h1>
        <table>
            <tr>
                <td>Id:</td>
                <td><asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nombre:</td>
                <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Precio:</td>
                <td><asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Stock:</td>
                <td><asp:TextBox ID="txtStock" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <asp:TextBox ID="tstId" runat="server" Placeholder="Buscar por Id"></asp:TextBox>
        <asp:Button ID="tsbBuscar" runat="server" Text="Buscar" OnClick="tsbBuscar_Click" />
        <br /><br />
        <asp:Button ID="tsbNuevo" runat="server" Text="Nuevo" OnClick="tsbNuevo_Click" />
        <asp:Button ID="tsbGuardar" runat="server" Text="Guardar" OnClick="tsbGuardar_Click" Enabled="false" />
        <asp:Button ID="tsbCancelar" runat="server" Text="Cancelar" OnClick="tsbCancelar_Click" Enabled="false" />
        <asp:Button ID="tsbEliminar" runat="server" Text="Eliminar" OnClick="tsbEliminar_Click" Enabled="false" />
        <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
    </form>
</body>
</html>