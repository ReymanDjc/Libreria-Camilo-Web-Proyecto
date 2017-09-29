<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rUsuarios.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Registros.rUsuarios" %>

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
            <div class="col-4">
                <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label1" runat="server" Text="UsuarioId:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="UsuarioIdTextBox" runat="server" class="form-control" Height="30"  Width="200"></asp:TextBox>
                           </td>
                           <td>
                              &nbsp&nbsp&nbsp&nbsp <asp:Button ID="BuscarButton" runat="server" class="btn btn-info" Text="Buscar" OnClick="BuscarButton_Click" />
                           </td>
                       </tr>
                   </table>                
               </div> 
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label2" runat="server" Text="Nombres:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="NombreTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Llenar Campos Vacios" ForeColor="Red" ControlToValidate="NombreTextBox" Font-Bold="True">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
               </div> 
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label3" runat="server" Text="Clave:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="ClaveTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="ClaveTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
               </div> 
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label4" runat="server" Text="ConfirmarClave:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="ConfirmarClaveTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="ConfirmarClaveTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
               </div>
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label5" runat="server" Text="Fecha de Inscripcion:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date" class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="FechaTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>                  
               </div>
                <div>
                <br />
                    <asp:Button ID="NuevoButton" runat="server" class="btn btn-info" Text="Nuevo" OnClick="NuevoButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-info" Text="Guardar" OnClick="GuardarButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-info" Text="Eliminar" OnClick="EliminarButton_Click" />         
                </div>

            </div>

        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
