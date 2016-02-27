<%@ Page Title="" Language="C#" MasterPageFile="~/Prac1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEBGUI.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 671px;
            height: 33px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            height: 33px;
            width: 10px;
        }
        .auto-style5 {
            width: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td style="border-width: 0px" class="auto-style3"></td>
            <td style="border-width: 0px" class="auto-style3"></td>
            <td class="auto-style2" style="border-width: 0px">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/images/ES.png" OnClick="ImageButton1_Click" />
           
&nbsp;</td>
            <td style="border-width: 0px" class="auto-style4"></td>
            <td style="border-width: 0px" class="auto-style3"></td>
        </tr>
        <tr>
            <td style="border-width: 0px">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
            <td class="auto-style2" style="border-width: 0px">
                <asp:Label ID="Label1" runat="server" Text="Bienvenido"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Text="usuario"></asp:Label>
            </td>
            <td style="border-width: 0px" class="auto-style5">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
        </tr>
        <tr>
            <td style="border-width: 0px">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
            <td class="auto-style2" style="border-width: 0px">
                &nbsp;</td>
            <td style="border-width: 0px" class="auto-style5">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
        </tr>
        <tr>
            <td style="border-width: 0px">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
            <td class="auto-style2" style="border-width: 0px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="infoUsuarios" Width="100%">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="FULLNAME" />
                        <asp:BoundField DataField="CORREO" HeaderText="Correo" />
                        <asp:BoundField DataField="ORGANIZACION" HeaderText="Organización" />
                        <asp:BoundField DataField="ULTIMO_ACCESO" HeaderText="Último Acceso" />
                    </Columns>
                </asp:GridView>
            </td>
            <td style="border-width: 0px" class="auto-style5">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
        </tr>
        <tr>
            <td style="border-width: 0px">&nbsp;</td>
            <td style="border-width: 0px">&nbsp;</td>
            <td class="auto-style2" style="border-width: 0px">
                <asp:ObjectDataSource ID="infoUsuarios" runat="server" SelectMethod="getUsuario" TypeName="Practica1.DAL.Usuarios">
                    <SelectParameters>
                        <asp:SessionParameter Name="NomUsuario" SessionField="username" Type="String" />
                        <asp:SessionParameter Name="PassUsuario" SessionField="pass" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td style="border-width: 0px"></td>
            <td style="border-width: 0px"></td>
        </tr>
    </table>
    <br />
</asp:Content>
