<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio__15._4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p>Introduzca 2 numeros</p> 
        <p>Presione el botón para sumarlos</p>
        <asp:TextBox ID="num1" runat="server"/><br />
        <asp:TextBox ID="num2" runat="server"/><br />
        <asp:Button ID="btnSum" Text="Suma" runat="server" OnClick="btnSum_Click1"/><br />   
        <asp:Label ID="result" runat="server"/>
        </div>
    </form>
</body>
</html>
