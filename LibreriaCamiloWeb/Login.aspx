﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibreriaCamiloWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />

    <!--Bootstrap-->
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="/Scripts/bootstrap.min.js"></script>
    <script src="/Content/bootstrap3.7.min.js"></script>
    <!--toastr-->
    <link href="/Content/toastr.min.css" rel="stylesheet" />
    <script src="/Scripts/toastr.min.js"></script>

    <!--jquery-->
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>



    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            <img src="WebHtmla.jpg" />
            <br />
            <strong>
                <asp:Label ID="Label1" runat="server" Text="User:"></asp:Label></strong>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" Height="30" Width="200"></asp:TextBox>

            <strong>
                <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></strong>
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" class="form-control" Height="30" Width="200"></asp:TextBox>
            <br />
            <asp:Button ID="LoginButton" runat="server" class="btn btn-info" Text="Login" OnClick="LoginButton_Click" />

        </div>



    </form>
</body>
</html>
