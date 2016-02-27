<%@ Page Title="" Language="C#" MasterPageFile="~/Prac1.Master" AutoEventWireup="true" CodeBehind="crearUsuario.aspx.cs" Inherits="WEBGUI.crearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
        border-collapse: collapse;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td colspan="2" style="border-width: 0px; border-style: hidden">Crear Usuario</td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label5" runat="server" Text="Apellido Paterno"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label6" runat="server" Text="Apellido Materno"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label7" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label3" runat="server" Text="Correo electrónico"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Label ID="Label4" runat="server" Text="Organización"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td style="border-width: 0px; border-style: hidden;">
            <asp:Button ID="Button1" runat="server" Text="Crear Usuario" />
        </td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
        <td style="border-width: 0px; border-style: hidden">&nbsp;</td>
    </tr>
</table>
</asp:Content>
