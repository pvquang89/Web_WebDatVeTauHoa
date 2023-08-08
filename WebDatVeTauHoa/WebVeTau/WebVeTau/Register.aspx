<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebVeTau.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register page</title>
    <link rel="stylesheet" href="css/register.css" type="text/css">
    <script>
        function check() {
            if (document.getElementById('Password').value ==
                document.getElementById('Password-1').value) {
                document.getElementById('message').style.color = 'green';
                document.getElementById('message').innerHTML = 'matching' + '<br>';
            } else {
                document.getElementById('message').style.color = 'red';
                document.getElementById('message').innerHTML = 'not matching' + '<br>';
            }
        }

        function validateDate() {
            var myDate = document.forms["form1"]["myDate"].value.split("-");
            let today = new Date();
            let myDate_convert = new Date(myDate[0], myDate[1] - 1, myDate[2]);

            console.log(myDate_convert);
            console.log(today);
            if (myDate_convert > today) return false;
        }

        function validateForm() {
            var fullName = document.forms["form1"]["fullName"].value;
            var cccd = document.forms["form1"]["cccd"].value;
            var sdt = document.forms["form1"]["sdt"].value;
            var pass1 = document.forms["form1"]["Password"].value;
            var pass2 = document.forms["form1"]["Password-1"].value;

            console.log(today.getFullYear());
            console.log(myDate);
            if (fullName == "" || cccd == "" || sdt == "" || email == "" || pass1 == "" || pass2 == "" || myDate == "") {
                alert("Không được để trống các thuộc tính * ");
                return false;
            }
            if (cccd.length < 9) {
                alert("Mời bạn kiểm tra lại số căn cước công dân");
                return false;
            }
            if (pass1 != pass2) {
                alert("Mật khẩu không khớp !");
                return false;
            }
            if (pass1.length < 6 || pass1.length > 50) {
                alert("Mật khẩu phải từ 6 đến 50 kí tự");
                return false;
            }
            debugger
            if (!validateDate()) {
                alert("Ngày sinh không thể lớn hơn ngày hiện tại!");
                return false;
            }
        }
    </script>
</head>

<body>
    <div class="Register">
        <header>
            <div>
                <a href="Home.aspx"><img src="img/logo.png" alt="logo" id="logo" style="background-color:blue""></a>
                <label for="">ĐĂNG KÝ</label>
            </div>
            <div class="the-link">
                <a href="Login.aspx">LOGIN</a>
                <a href="Register.aspx"> REGISTER PAGE</a>
            </div>

        </header>
        <form id="form1" runat="server" onsubmit="return validateForm()" method="POST">
            <div class="form-dk">
                <div class="form-tt">
                    <span>Họ và tên: <span style="color: red;">*</span> </span>
                    <input type="text" name="fullName" id="fullName" placeholder="Full Name" autocomplete='of'>

                    <span>CMND: <span style="color: red;">*</span> </span>
                    <input type="text" name="cccd" id="cccd" autocomplete="of" placeholder="Thẻ căn cước">

                    <span>Số điện thoại: <span style="color: red;">*</span> </span>
                    <input type="tel" name="sdt" id="sdt" pattern="[0-9]{10}" placeholder="Số điện thoại" autocomplete="of">

                    <span>Email: <span style="color: red; ">*</span> </span>
                    <input type="email" name="email" id="email" placeholder="Email" autocomplete="off">

                    <span>Password: <span style="color: red; ">*</span> </span>
                    <input type="password" onkeyup="check()" name="Password" id="Password" autocomplete="off" placeholder="Password">

                    <span>Xác nhận Password: <span style="color: red; ">*</span> </span>
                    <input type="password" onkeyup="check()" name="Password-1" id="Password-1" autocomplete="off" placeholder="Password">
                    <span id="message"></span> <br />

                    <span>Giới tính <span style="color: red; ">*</span> </span>
                    <span>
                        <input type="radio" name="rdo-gt" id="rdogtnam" value="Nam" runat="server" checked>
                        <label for="rdogtnam" name="rdo-gt">Nam</label>
                        <input type="radio" name="rdo-gt" id="rdogtnu" value="Nữ" runat="server">
                        <label for="rdogtnu" name="rdo-gt">Nữ</label>
                    </span>

                    <span>Ngày tháng năm sinh <span style="color: red; ">*</span> </span>
                    <input type="date" name="myDate" id="myDate">
                </div>

                <div class="form-nut">
                    <button type="reset">Reset</button>
                    <button type="submit" runat="server">Đăng kí</button>
                </div>
</form>
        </div>
</body>
</html>
