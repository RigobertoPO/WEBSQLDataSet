<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalSite.Master" AutoEventWireup="true" CodeBehind="ClientesWF.aspx.cs" Inherits="WebSQLDataSet.ClientesWF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
    <table>
        <tr>
            <td>Id:</td>
            <td> <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox></td>
           
        </tr>
        <tr>
           <td>Nombre:</td>
            <td> <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Dirección:</td>
            <td> <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Sexo:</td>
            <td>
                
                <asp:RadioButton ID="MasculinoRadioButton" runat="server" GroupName="Software" Text="Masculino" Checked="true" />
                <asp:RadioButton ID="FemeninoRadioButton" runat="server" GroupName="Software"  Text="Femenino"/>
            </td>
           
           
        </tr>
        <tr>
            <td>Fecha de nacimiento:</td>
            <td> 
                <asp:Calendar ID="FechaNacimientoCalendar" runat="server"></asp:Calendar>
            </td>
        </tr>
    </table>
        <asp:Button ID="AceptarButton" runat="server" Text="Aceptar" OnClick="AceptarButton_Click" />
        <asp:Button ID="SalirButton" runat="server" Text="Salir" OnClick="SalirButton_Click" />
    </div>
</asp:Content>
