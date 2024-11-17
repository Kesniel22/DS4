<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio__15._3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Introduzca un Texto</p> 
            <asp:TextBox ID="TextBox1" runat="server" />
            <asp:Button ID="Button1" Text="Enviar Saludo!" runat="server" OnClick="Button1_Click1" />
        </div>
    </form>
</body>
</html>
