<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="登录.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>注册</title>
   <script src="js/jquery-3.4.1.min.js"></script>
    <style>
        .ts{
            display:none;
        }
    </style>
    <script>
        function yz() {
            var bool = true;
            if ($('#StuNo').val() == "") {
                $('#StuNo').next(".ts").show();
                bool = false;
            }
            if ($('#uName').val() == "") {
                $('#uName').next(".ts").show();
                bool = false;
            }
            return bool;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li>
                    <p>
                        <label for="StuNo"><span style="color: #ff0000;">*</span>学号：</label>
                        <input type="text" id="StuNo" runat="server" placeholder="学号长度不能超过15位" onblur="jd()"/>
                        <span class="ts">（学号不能为空）</span>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="Pwd">密码：</label>
                        <asp:TextBox ID="Pwd" runat="server"></asp:TextBox>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="uName"><span style="color: #ff0000;">*</span>姓名：</label>
                        <asp:TextBox ID="uName" runat="server"></asp:TextBox>
                        <span class="ts">（姓名不能为空）</span>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="Sex">性别：</label>
                        <asp:TextBox ID="Sex" runat="server"></asp:TextBox>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="GradeId1">年级：</label>
                        <input type="number" id="GradeId1" runat="server" />
                    </p>
                </li>
                <li>
                    <p>
                        <label for="Phone">电话：</label>
                        <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="Addr">地址：</label>
                        <asp:TextBox ID="Addr" runat="server"></asp:TextBox>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="BornDate">出生日期：</label>
                        <asp:TextBox ID="BornDate" runat="server"></asp:TextBox>
                    </p>
                </li>
                <li>
                    <p>
                        <label for="Email">邮箱：</label>
                        <input type="email" id="Email" runat="server" />
                    </p>
                </li>
                <li>
                    <asp:Button ID="Button1" runat="server" OnClientClick="return yz()" OnClick="Button1_Click" Text="保存" />
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
