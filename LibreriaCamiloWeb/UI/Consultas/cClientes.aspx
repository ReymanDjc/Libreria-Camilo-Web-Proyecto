<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cClientes.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Consultas.cClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:DropDownList ID="ClientesDropDownList" class="btn btn-info" runat="server">
                            <asp:ListItem>Todos</asp:ListItem>
                            <asp:ListItem>ClienteId</asp:ListItem>
                            <asp:ListItem>Nombres</asp:ListItem>
                        </asp:DropDownList>&nbsp&nbsp
                            </td>
                    <td>&nbsp&nbsp<asp:TextBox ID="FiltrarTextBox" runat="server" class="form-control" Height="30" Width="150"></asp:TextBox>&nbsp&nbsp
                            </td>
                    <td>&nbsp&nbsp<asp:Button ID="FiltrarButton" runat="server" class="btn btn-info" Text="Filtrar" OnClick="FiltrarButton_Click" />&nbsp&nbsp
                            </td>
                    <td>
                        <asp:Button ID="ImprimirButton" runat="server" class="btn btn-info" Text="Imprimir" OnClick="ImprimirButton_Click" />
                    </td>
                </tr>

            </table>

        </div>

        <div>
            <br />
            <asp:GridView ID="ClientesGridView" runat="server" CssClass=" table table-striped table-hover table-bordered">
                <HeaderStyle BackColor="LightBlue" Font-Bold="True" ForeColor="black" />
            </asp:GridView>

        </div>

    </div>

</asp:Content>
