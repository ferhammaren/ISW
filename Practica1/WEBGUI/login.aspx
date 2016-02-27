<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Prac1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WEBGUI.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
    <tr>
        <td style="border-width: 0px"></td>
        <td style="border-width: 0px">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/images/ES.png" OnClick="ImageButton1_Click" />
           
        </td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">
             <asp:Label ID="errorMsg" runat="server" Visible="False">Error: te faltan campos</asp:Label>
          
             <asp:Label ID="notFound" runat="server" Text="Error: Usuario no encontrado" Visible="False"></asp:Label>
          
        </td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">
              <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario: "></asp:Label>
            <asp:TextBox ID="uNBox" runat="server" CausesValidation="True"></asp:TextBox>
            </td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">
            <asp:Label ID="Label2" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="pWBox" runat="server" TextMode="Password" CausesValidation="True"></asp:TextBox>
        
            
        </td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
    </tr>
    <tr>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px"><asp:Button ID="enter" runat="server" Text="Ingresar" OnClick="Button1_Click" /></td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
        <td style="border-width: 0px">&nbsp;</td>
    </tr>
</table>
    <br />
</asp:Content>
