<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="pro1.loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
	<title> Login Form</title>
	<link rel="stylesheet" href="CSS/style.css">

</head>
<body>
    
<div class="segment company">
			<img src="img/hadeed_logo.png" alt="Hadeed Logo">
		</div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

	<div class="box">
		
		<form autocomplete="off" runat="server">
			<h2>Sign in</h2>
			<div class="inputBox1">

				
                <asp:TextBox ID="username" runat="server" ></asp:TextBox>

				<span>Userame</span>
				<i></i>
			</div>
			<div class="inputBox">
                 <asp:TextBox ID="password" runat="server"></asp:TextBox>
				<span>Password</span>
				<i></i>
			</div>
			<div class="links">
				<a href="indexsin.html">Sign up</a>
			</div>

            <asp:Button ID="Button1" runat="server" Text="Login" onclick="Saleh_click" />
            
		</form>
	</div>


</body>
</html>
