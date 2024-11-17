<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio__17._1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="row">
            <div>
                <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
                    AllowSorting="true" AllowPaging="true"
                    DataKeyName="ProductID"
                    AutoGenerateEditButton="true"
                    runat="server" />

                <asp:SqlDataSource ID="MyDataSource1" runat="server"
                    ConnectionString="data source=.\sqlexpress; initial catalog=northwind;persist security info=True;Integrated Security=SSPI;"
                    ProviderName="System.Data.SqlClient"
                    SelectCommand="SELECT ProductId, ProductName, UnitPrice FROM Products"
                    UpdateCommand="UPDATE Products SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductId]=@ProductId">
                </asp:SqlDataSource>
            </div>
        </div>

</asp:Content>
