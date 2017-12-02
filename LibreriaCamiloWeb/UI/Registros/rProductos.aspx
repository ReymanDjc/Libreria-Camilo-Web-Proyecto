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
                            <strong>
                                <asp:Label ID="Label1" runat="server" Text="ProductoId:"></asp:Label></strong>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="ProductoIdTextBox" runat="server" class="form-control" Height="30" Width="200" ValidationGroup="Buscar"></asp:TextBox>
                        </td>
                        <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="BuscarButton" runat="server" class="btn btn-info" Text="Buscar" OnClick="BuscarButton_Click" ValidationGroup="Buscar" />
                            <br />
                        </td>
                    </tr>
                </table>
            </div>

        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="ProductoIdTextBox" ErrorMessage="Solo Numeros y Numeros positivos" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="Buscar"></asp:RegularExpressionValidator>

            <br />
            <div>
                <table>
                    <tr>
                        <td>
                            <strong>
                                <asp:Label ID="Label2" runat="server" Text="Descripcion:"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="DescripcionTextBox" runat="server" class="form-control" Height="30" Width="300" MaxLength="50"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campos Obligatorios" Font-Bold="True" ForeColor="Red" ControlToValidate="DescripcionTextBox">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div>
                <table>
                    <tr>
                        <td>
                            <strong>
                                <asp:Label ID="Label3" runat="server" Text="Costo:"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="CostoTextBox" runat="server" class="form-control" Height="30" Width="300" MaxLength="5"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campos Obligatorios" Font-Bold="True" ForeColor="Red" ControlToValidate="CostoTextBox">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Solo Numeros" ControlToValidate="CostoTextBox" Font-Bold="True" ForeColor="Red" ValidationExpression="([0-9]|-)*">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="CostoTextBox" ErrorMessage="Solo Numeros y Numeros positivos" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div>
                <table>
                    <tr>
                        <td>
                            <strong>
                                <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="PrecioTextBox" runat="server" class="form-control" Height="30" Width="300" MaxLength="6"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campos Obligatorios" Font-Bold="True" ForeColor="Red" ControlToValidate="PrecioTextBox">*</asp:RequiredFieldValidator> 
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Solo Numeros" ControlToValidate="PrecioTextBox" Font-Bold="True" ForeColor="Red" ValidationExpression="([0-9]|-)*">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="PrecioTextBox" ErrorMessage="Solo Numeros y Numeros positivos" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div>
                <table>
                    <tr>
                        <td>
                            <strong>
                                <asp:Label ID="Label5" runat="server" Text="Cantidad:"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="CantidadTextBox" runat="server" TextMode="Number" class="form-control" Height="30" Width="300" MaxLength="2"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campos Obligatorios" Font-Bold="True" ForeColor="Red" ControlToValidate="CantidadTextBox">*</asp:RequiredFieldValidator>
                            
        <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="CantidadTextBox" ErrorMessage="Solo Numeros y Numeros positivos" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                            
                        </td>
                    </tr>
                </table>
            </div>

            <div>
                <br />
                <asp:Button ID="NuevoButton" runat="server" class="btn btn-info" Text="Nuevo" OnClick="NuevoButton_Click" ValidationGroup="Nuevo" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-info" Text="Guardar" OnClick="GuardarButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-info" Text="Eliminar" OnClick="EliminarButton_Click" />
            </div>
            <br />
        </div>

    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
     <script src="/Scripts/bootstrap.min.js"></script>
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <link href="/Content/toastr.min.css" rel="stylesheet" />
    <script src="/Scripts/toastr.min.js"></script>
    <script src="/Scripts/jquery-3.2.1.slim.min.js"></script>

</asp:Content>
