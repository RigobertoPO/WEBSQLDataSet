<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSQLDataSet.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="ClientesGridView" runat="server" Width="60%" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ClientesGridView_SelectedIndexChanged"></asp:GridView>
    </div>
    <div>
    
        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
        <asp:Button ID="EditarButton" runat="server" Text="Editar" Enabled="False" OnClick="EditarButton_Click" />
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" Enabled="False" OnClick="EliminarButton_Click" />
       
    
    </div>
</asp:Content>
