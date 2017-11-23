<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibreriaCamiloWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container-fluid">
            <img src="WebHtmla.jpg" />
            <div class="col-4">
                <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label1" runat="server" Text="Admin:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="AdminTextBox" runat="server" class="form-control" Height="30"  Width="200"></asp:TextBox>
                           </td>
                           </tr>
                           <tr>
                           <td>
                               <strong><asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></strong>
                           </td>
                           
                       </tr>
                       <tr>
                           <td>
                               <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" class="form-control" Height="30"  Width="200"></asp:TextBox>
                           </td>
                           </tr>
                    </table>                  
               </div>
                <div>
                <br />
                 &nbsp&nbsp&nbsp&nbsp  <asp:Button ID="LoginButton" runat="server"  class="btn btn-info" Text="Login" OnClick="LoginButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp
                     <asp:Button ID="Button2" runat="server" class="btn btn-info" Text="Button" />
                </div>

            </div>

        </div>
    </form>
</body>
</html>
