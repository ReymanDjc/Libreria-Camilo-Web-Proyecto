<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cUsuarios.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Consultas.cUsuarios1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
        <div>
            <table>
                <tr>
                    <td>
                        &nbsp&nbsp<asp:DropDownList ID="UsuariosDropDownList" class="btn btn-info" runat="server">
                            <asp:ListItem>Todos</asp:ListItem>
                            <asp:ListItem>Fecha</asp:ListItem>
                            <asp:ListItem>Nombre</asp:ListItem>
                            <asp:ListItem>UsuarioId</asp:ListItem>
                        </asp:DropDownList>
                            </td>
                    <td>&nbsp&nbsp<asp:TextBox ID="FiltrarTextBox" runat="server" class="form-control" Height="30" Width="150"></asp:TextBox>&nbsp&nbsp
                            </td>
                    <td>&nbsp&nbsp<asp:Button ID="FiltrarButton" runat="server" class="btn btn-info" Text="Filtrar" OnClick="FiltrarButton_Click" />&nbsp&nbsp
                            </td>
                    <td>
                        <asp:Button ID="ImprimirButton" runat="server" class="btn btn-info" Text="Imptimir" OnClick="ImprimirButton_Click" />
                    </td>
                </tr>

            </table>


            <div>
                <table>
                    <tr>
                        <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        </td>
                        <td>
                            <asp:TextBox ID="FechaunoTextBox" TextMode="Date" runat="server" class="form-control" Height="25" Width="175"></asp:TextBox>
                        </td>
                        <td>&nbsp<strong><asp:Label ID="Label1" runat="server" Text="-">  </asp:Label></strong>&nbsp
                        </td>
                        <td>
                            <asp:TextBox ID="FechadosTextBox" TextMode="Date" runat="server" class="form-control" Height="25" Width="175"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>


        </div>

        <div>
            <asp:GridView ID="UsuariosGridView" runat="server"></asp:GridView>
        </div>

    </div>
</asp:Content>
