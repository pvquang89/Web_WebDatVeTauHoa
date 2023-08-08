<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebVeTau.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="css/login.css" rel="stylesheet" />
    <script>
        function validateForm() {
            var Uname = document.forms["form1"]["Uname"].value;
            var passW = document.forms["from1"]["passW"].value;
            console.log("Uname", Uname);
            console.log("Pass", passW);
            if (Uname == "" || passW == "") {
                alert("Tài khoản hoặc mật khẩu của bạn đang để trống");
                return false;
            }
            if (passW.length < 6) {
                alert("Mật khẩu phải có ít nhất 6 ký tự");
                return false;
            }
        }
    </script>
</head>
<body>
   <div class="login">
        <h2>Login page</h2>
        <div class="border">
            <form id="form1" runat="server" name="from1" onsubmit="return validateForm()" method="POST">

                <label><b>User Name</b></label> <br>
                <input type="text" name="Uname" id="Uname" placeholder="User name" autocomplete="off" runat="server"> <br>

                <label><b>Password</b></label><br>
                <input type="password" name="passW" id="passW" placeholder="Password" runat="server"><br>

                <input type="checkbox" name="RmbUser" id="RmbUser">Remember me<br>

                <button type="submit" runat="server">Login In Here</button>
                
                <span>Not Registered? <a style="color: blue;" href="Register.aspx">Create an account</a></span><br>
                <a style="color: blue;" href="#">Forgot Password?</a>

            </form>
        </div>
    </div>
</body>
</html>
