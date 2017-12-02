<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cFacturas.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Consultas.cFacturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/Scripts/bootstrap.min.js"></script>
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <link href="/Content/toastr.min.css" rel="stylesheet" />
    <script src="/Scripts/toastr.min.js"></script>
    <script src="/Scripts/jquery-3.2.1.slim.min.js"></script>

    <div class="Container-fluid">
        <div>
            <table>
                <tr>
                    <td>&nbsp&nbsp<asp:DropDownList ID="FacturaDropDownList" class="btn btn-info" runat="server">
                        <asp:ListItem>Todo</asp:ListItem>
                        <asp:ListItem>FacturaId</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        <asp:ListItem>ClienteId</asp:ListItem>
                        <asp:ListItem>Nombre Cliente</asp:ListItem>
                    </asp:DropDownList>
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
            <br />
            <asp:GridView ID="FacturaGridView" runat="server" CssClass=" table table-striped table-hover table-bordered">
                <HeaderStyle BackColor="LightBlue" Font-Bold="True" ForeColor="black" />
            </asp:GridView>

        </div>

    </div>

</asp:Content>
