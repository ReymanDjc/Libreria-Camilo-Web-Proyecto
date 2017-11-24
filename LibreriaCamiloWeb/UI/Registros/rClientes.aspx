<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rClientes.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Registros.rClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
            <div class="align-content-center">
                <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label1" runat="server" Text="ClienteId:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="ClienteIdTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                              &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="BuscarButton" runat="server" class="btn btn-info" Text="Buscar" OnClick="BuscarButton_Click" />
                           </td>
                       </tr>
                   </table>                
               </div> 
                <br/>
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label2" runat="server" Text="Nombres:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="NombreTextBox" runat="server" class="form-control" Height="30"  Width="300" ></asp:TextBox>
                            </td>
                            <td>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Llenar Campos Vacios" ForeColor="Red" ControlToValidate="NombreTextBox" Font-Bold="True">*</asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                    </table>
               </div> 
                <br />
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label3" runat="server" Text="Direccion:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="DireccionTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="ClaveTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                    </table>
               </div> 
                <br />
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="EmailTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="ConfirmarClaveTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                    </table>
               </div>
                <br />
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TelefonoTextBox"  TextMode="Phone" runat="server"  class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="FechaTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                    </table>                  
               </div>

                <div>
                <br />
                    <asp:Button ID="NuevoButton" runat="server" class="btn btn-info" Text="Nuevo" OnClick="NuevoButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-info" Text="Guardar" OnClick="GuardarButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-info" Text="Eliminar" OnClick="EliminarButton_Click" />   
                </div>

            </div>

        </div>

</asp:Content>
