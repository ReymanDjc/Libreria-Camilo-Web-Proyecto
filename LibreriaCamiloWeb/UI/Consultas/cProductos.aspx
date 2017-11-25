<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cProductos.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Consultas.cProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
                <div>
                    <table>
                        <tr>
                            <td>
                                <asp:DropDownList ID="ProductosDropDownList" class="btn btn-info" runat="server">
                                    <asp:ListItem>Todos</asp:ListItem>
                                    <asp:ListItem>ProductoId</asp:ListItem>
                                    <asp:ListItem>Descripcion</asp:ListItem>
                                </asp:DropDownList>&nbsp&nbsp
                            </td>
                            <td>
                                &nbsp&nbsp<asp:TextBox ID="FiltrarTextBox" runat="server" class="form-control" Height="30"  Width="150"></asp:TextBox>&nbsp&nbsp
                            </td>
                            <td>
                                &nbsp&nbsp<asp:Button ID="FiltrarButton" runat="server" class="btn btn-info" Text="Filtrar" OnClick="FiltrarButton_Click" />&nbsp&nbsp
                            </td>
                            <td>
                                <asp:Button ID="ImprimirButton" runat="server" class="btn btn-info" Text="Imprimir" OnClick="ImprimirButton_Click" />
                            </td>
                        </tr>

                    </table>  

                </div>

                <div>
                    <asp:GridView ID="ProductosGridView" runat="server"></asp:GridView>
                </div>

            </div>

</asp:Content>
