<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cUsuarios.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Consultas.cUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container-fluid">
            <img src="WebHtml.jpg" />
            <div class="col-12">

                <div>
                    <table>
                        <tr>
                            <td>
                                <asp:DropDownList ID="UsuariosDropDownList" runat="server">
                                    <asp:ListItem>Todos</asp:ListItem>
                                    <asp:ListItem>UsuarioId</asp:ListItem>
                                    <asp:ListItem>Nombres</asp:ListItem>
                                    <asp:ListItem>Fecha</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:TextBox ID="FiltrarTextBox" runat="server" class="form-control" Height="30"  Width="150"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp&nbsp<asp:Button ID="FiltrarButton" runat="server" class="btn btn-info" Text="Filtrar" OnClick="FiltrarButton_Click" />
                            </td>
                            <td>
                                <asp:Button ID="ImprimirButton" runat="server" class="btn btn-info" Text="Imprimir" OnClick="ImprimirButton_Click" />
                            </td>
                        </tr>

                    </table>  
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="FechaunoTextBox" TextMode="Date" runat="server" class="form-control" Height="25"  Width="175"></asp:TextBox> 
                                </td>
                                <td>
                                    &nbsp<strong><asp:Label ID="Label1" runat="server" Text="-">  </asp:Label></strong>&nbsp
                                </td>
                                <td>
                                    <asp:TextBox ID="FechadosTextBox" TextMode="Date" runat="server" class="form-control" Height="25"  Width="175"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                         
                    </div>
                </div>

                <div>
                    <asp:GridView ID="UsuariosGridView" runat="server"></asp:GridView>
                </div>



            </div>
        </div>
    </form>
</body>
</html>
