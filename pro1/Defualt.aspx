<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="pro1.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/style.css"/>
</head>
<body>
    		<div class="segment company">
			<img src="img/hadeed_logo.png" alt="Hadeed Logo" />
		</div>

	<div class="box"> 
		
		<form autocomplete="off" runat="server">
			<h2>Sign in</h2>
			<div class="inputBox1">
                <asp:TextBox ID="TextBox1" runat="server" Text="abc1234567890" required="required"></asp:TextBox>
				<span>Userame</span>
				<i></i>
			</div>
			<div class="inputBox">
                <asp:TextBox ID="TextBox" runat="server" Text="aaaaaa"  required="required"></asp:TextBox>
				<span>Password</span>
				<i></i>
			</div>
			<div class="links">
				<a>Sign up</a>
			</div>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
		</form>
	</div>
    <div>
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Your Username or Passwrod is Incorrect Please Try Agein" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
