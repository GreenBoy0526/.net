<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="登录.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="name" runat="server">登录</asp:HyperLink>&nbsp;
        <asp:LinkButton ID="exit" runat="server" OnClick="exit_Click">退出</asp:LinkButton>
    </div>
    </form>
</body>
</html>
