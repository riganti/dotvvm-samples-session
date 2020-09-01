<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DotvvmSessionSample.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginView runat="server" ID="LoginView1">
                <AnonymousTemplate>
                    Not logged in 
                    <br/>
                    <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_OnClick" />
                </AnonymousTemplate>
                <LoggedInTemplate>
                    Logged in
                    <br />
                    <asp:Button ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_OnClick" />
                </LoggedInTemplate>
            </asp:LoginView>
            
            <p>
                <a href="/">Back to the session test page</a>
            </p>
        </div>
    </form>
</body>
</html>
