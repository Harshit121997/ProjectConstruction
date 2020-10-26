<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="ProjectConstruction.LogIn1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" type="text/css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="login-page">
            <form class="login-page form" runat="server">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                <asp:TextBox runat="server" type="text" ID="txtEmail" placeholder="Email" />
                <asp:TextBox runat="server" type="password" ID="txtPassword" placeholder="password" />
                <asp:Button runat="server" Text="Login" CssClass="button" ID="btnLogin" BackColor="LightGreen" OnClick="btnLogin_Click" />
                <p class="message">
                    Not registered? <a
                        href="#">Create an account</a>
                </p>
            </form>
        </div>
</body>
</html>
