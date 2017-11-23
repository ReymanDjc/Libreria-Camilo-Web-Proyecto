<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rProductos.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Registros.rProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
            <div class="align-content-center">
                <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label1" runat="server" Text="ProductoId:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="ProductoIdTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                              &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="BuscarButton" runat="server" class="btn btn-info" Text="Buscar" />
                           </td>
                       </tr>
                   </table>                
               </div> 
                <br/>
                <div>
                    <table>
                        <tr>
                            <td>
                                <strong><asp:Label ID="Label2" runat="server" Text="Descripcion:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="DescripcionTextBox" runat="server" class="form-control" Height="30"  Width="300" ></asp:TextBox>
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
                                <strong><asp:Label ID="Label3" runat="server" Text="Costo:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="CostoTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
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
                                <strong><asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="PrecioTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
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
                                <strong><asp:Label ID="Label5" runat="server" Text="Cantidad:"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="CantidadTextBox" runat="server"  class="form-control" Height="30"  Width="300"></asp:TextBox>
                            </td>
                            <td>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="FechaTextBox" ForeColor="Red" Font-Bold="True">*</asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                    </table>                  
               </div>

                <div>
                <br />
                    <asp:Button ID="NuevoButton" runat="server" class="btn btn-info" Text="Nuevo" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-info" Text="Guardar" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-info" Text="Eliminar" />  
                </div>

            </div>

        </div>

</asp:Content>
