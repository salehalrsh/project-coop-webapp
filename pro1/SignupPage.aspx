<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignupPage.aspx.cs" Inherits="pro1.SignupPage" ValidateRequest="false" EnableEventValidation="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/Style2.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="container" />
    <div class="header">
                
        <h2>Create an Account</h2>
    </div>
    <div class="box">
    <form class="form" id="form" runat="server">
        <div class="form-control">
            <label for="username">Username</label>
            <asp:TextBox ID="username" runat="server" Text="abc1234567890" required="required"></asp:TextBox>
            <i class="fa fa-smile-o"></i>
            <i class="fa fa-frown-o"></i>
            <p class="errorMessage">Error Message</p>
        </div>
        <div class="form-control">
            <label for="Name1">Full Name</label>
            <asp:TextBox ID="Name1" runat="server" Text="username_1234567890"></asp:TextBox>
            <i class="fa fa-smile-o"></i>
            <i class="fa fa-frown-o"></i>
            <p class="errorMessage">Error Message</p>
        </div>

        <div class="form-control">
            <label for="password">Password</label>
            <asp:TextBox ID="password" runat="server" Text="aaaaaa"></asp:TextBox>
            <i class="fa fa-smile-o"></i>
            <i class="fa fa-frown-o"></i>
            <p class="errorMessage">Error Message</p>
        </div>

        <div class="form-control">
            <label for="password2">Confirm Password</label>
            <asp:TextBox ID="password2" runat="server" Text="aaaaaa"></asp:TextBox>
            <i class="fa fa-smile-o"></i>
            <i class="fa fa-frown-o"></i>
            <p class="errorMessage">Error Message</p>
        </div>

        <asp:Button ID="Button" runat="server" Text="Submit" />
        <asp:Button ID="Button2" style="display: none;" runat="server" Text="Submit" OnClick="Button_Click" />
        
     </form>
        <div class="complete-modal">
            <h2>Successful!</h2>
        </div>

    </div>


<div class="animate-circles">
    <div class="red circle"></div>
    <div class="blue circle"></div>
    <div class="red circle"></div>
    <div class="circle"></div>
    <div class="orange circle"></div>
    <div class="red circle"></div>
    <div class="circle"></div>
    <div class="red circle"></div>
    <div class="blue circle"></div>
    <div class="orange circle"></div>
</div>
<script src="js/app.js"></script>
</body>
</html>
