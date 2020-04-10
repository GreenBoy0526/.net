<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="登录.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
    <script src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#reg").click(function () {
                window.location.href = "register.aspx";
            })
            $("#log").click(function () {
                $.ajax({
                    dataType: 'html',
                    data: {
                        'Uname': $('#Uname').val(),
                        'Pwd': $('#Pwd').val()
                    },
                             url: 'Login.ashx',
                    type: 'post',
                    success: function (data) {
                        if (data=="1") {
                            window.location.href = "index.aspx";
                        } else {
                            alert("用户名或密码错误");
                        }
                        //请求成功的回调
                    },
                    error: function (data) {
                        //请求失败的回调
                    }
                })
            })
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <label for="Uname">账号</label>
                <input type="text" id="Uname" />
            </p>
            <p>
                <label for="Pwd">密码：</label>
                <input type="password" id="Pwd" />
            </p>
            <p>
                <input type="button" id="log" value="登录" />
                <input type="button" id="reg" value="注册" />
            </p>
        </div>
    </form>
</body>
</html>
