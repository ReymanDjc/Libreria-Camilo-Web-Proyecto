<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rFacturas.aspx.cs" Inherits="LibreriaCamiloWeb.UI.Registros.rFacturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container-fluid">
                <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label1" runat="server" Text="FacturaId:"></asp:Label></strong>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>

                           </td>
                           <td>
                               <strong><asp:Label ID="Label2" runat="server" Text="Fecha:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="FacturaIdTextBox" runat="server" class="form-control" Height="30"  Width="75" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                              &nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="BuscarButton" runat="server" class="btn btn-info" Text="Buscar" ValidationGroup="Buscar" />&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                               
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="FechaTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                           </td>
                       </tr>
                   </table>                
               </div> 

                <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label3" runat="server" Text="ClienteId:"></asp:Label></strong>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>

                           </td>
                           <td>
                               <strong><asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="ClienteIdTextBox" runat="server" class="form-control" Height="30"  Width="75" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                              &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="BuscarClienteButton" runat="server" class="btn btn-info" Text="Buscar" ValidationGroup="Buscar" OnClick="BuscarClienteButton_Click" />&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="NombreTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="NombreTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                           </td>
                       </tr>
                   </table>                
               </div>

        <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label5" runat="server" Text="ProductoId:"></asp:Label></strong>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>

                           </td>
                           <td>
                               <strong><asp:Label ID="Label6" runat="server" Text="Descripcion:"></asp:Label></strong>
                           </td>
                           <td>
                               &nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <strong><asp:Label ID="Label7" runat="server" Text="Precio:"></asp:Label></strong>
                           </td>
                           <td>
                               &nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <strong><asp:Label ID="Label8" runat="server" Text="Cantidad:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="ProductoIdTextBox" runat="server" class="form-control" Height="30"  Width="75" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                              &nbsp&nbsp<asp:Button ID="BuscarProductoButton" runat="server" class="btn btn-info" Text="Buscar" ValidationGroup="Buscar" OnClick="BuscarProductoButton_Click" />&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="DescripcionTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="DescripcionTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="PrecioTextBox" runat="server" class="form-control" Height="30"  Width="125" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="PrecioTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="CantidadTextBox" runat="server" TextMode="Number" class="form-control" Height="30"  Width="75" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="CantidadTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                           </td>
                           <td>
                              &nbsp&nbsp<asp:Button ID="AgregarButton" runat="server" class="btn btn-info" Text="Agregar" OnClick="AgregarButton_Click" ValidationGroup="Agregar" />&nbsp&nbsp&nbsp&nbsp
                           </td>

                       </tr>
                   </table>                
               </div>
        <br />
        <div>
            <asp:GridView ID="FacturaGridView" runat="server"></asp:GridView>
        </div>
        <div>

            <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label9" runat="server" Text="SubTotal:"></asp:Label></strong>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>

                           </td>
                           <td>
                               <strong><asp:Label ID="Label10" runat="server" Text="Itbis:"></asp:Label></strong>
                           </td>
                           <td>
                               &nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <strong><asp:Label ID="Label11" runat="server" Text="Total:"></asp:Label></strong>
                           </td>
                           <td>
                               &nbsp&nbsp&nbsp&nbsp
                           </td>                          
                       </tr>

                       <tr>
                           <td>
                               <asp:TextBox ID="SubtotalTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="SubtotalTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="ItbisTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="ItbisTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>&nbsp&nbsp&nbsp&nbsp
                           </td>
                           <td>
                               <asp:TextBox ID="TotalTextBox" runat="server" class="form-control" Height="30"  Width="200" ValidationGroup="Buscar"></asp:TextBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TotalTextBox" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator> &nbsp&nbsp&nbsp&nbsp
                           </td>
                       </tr>
                   </table>
        </div>


                <div>
                <br />
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="NuevoButton" runat="server" class="btn btn-info" Text="Nuevo" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-info" Text="Guardar" OnClick="GuardarButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-info" Text="Eliminar" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="ImprimirButton" runat="server" class="btn btn-info" Text="Imprimir" />
                </div>

        </div>

</asp:Content>
