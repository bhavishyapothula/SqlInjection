<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SqlInjection.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<asp:TextBox ID="uname" runat="server"></asp:TextBox>
        </div>
        <p>
            Password:<asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
        </p>
    </form>
</body>
</html>
