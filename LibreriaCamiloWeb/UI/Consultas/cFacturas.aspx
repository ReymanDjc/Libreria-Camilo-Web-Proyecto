﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cFacturas.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Consultas.cFacturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
        <div>
            <table>
                <tr>
                    <td>&nbsp&nbsp<asp:DropDownList ID="FacturaDropDownList" class="btn btn-info" runat="server">
                        <asp:ListItem>Todo</asp:ListItem>
                        <asp:ListItem>FacturaId</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp&nbsp<asp:TextBox ID="FiltrarTextBox" runat="server" class="form-control" Height="30" Width="150"></asp:TextBox>&nbsp&nbsp
                            </td>
                    <td>&nbsp&nbsp<asp:Button ID="FiltrarButton" runat="server" class="btn btn-info" Text="Filtrar" />&nbsp&nbsp
                            </td>
                    <td>
                        <asp:Button ID="ImprimirButton" runat="server" class="btn btn-info" Text="Imprimir" />
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
            <asp:GridView ID="FacturaGridView" runat="server"></asp:GridView>
        </div>

    </div>

</asp:Content>