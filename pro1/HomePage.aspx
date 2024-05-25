<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="pro1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/semantic.min.css">
    <link rel="stylesheet" href="css/site.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="ui container">
        
        <div style="display: flex; justify-content: space-between;">
            <div class="segment">
                <img src="img/cybersecurity_logo.svg" alt="AFTS Logo">
            </div>
    
            
    
            <div class="segment company">
                <img src="img/hadeed_logo.png" alt="Hadeed Logo">
            </div>
        </div>
    




        <div class="ui top attached tabular menu">
            <a href="HomePage.aspx" class="item active">Home</a>
            <a href="index/Quiz.html" class="item">Quiz</a>
            <a href="index/Phishing.html" class="item">Phishing</a>
            <a href="reference.html" class="item">Reference</a>
            <a href="top10.html" class="item">Top 10</a>
            <a href="about.html" class="item">About</a>
            <a href="contact.html" class="item">Contact us</a>
        </div>
        <div class="ui bottom attached segment">
            <h1>Welcome</h1>

            <div style="display: flex; flex-direction: column; gap: 4em; justify-content: space-evenly;">
                <div style="display: flex; justify-content: space-around;">
                    <a href="quiz.html" class="">
                        <i class="massive question circle icon"></i>
                        Quiz
                    </a>
                    <a href="phishing.html">
                        <i class="huge icons">
                            <i class="envelope open outline icon"></i>
                            <i class="big red dont icon"></i>
                            
                        </i>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phishing
        
                        
                    </a>
                </div>
                <div style="display: flex; justify-content: space-around;">
                    <a href="reference.html">
                        <i class="massive book icon"></i>
                        Reference
                    </a>
                    <a href="top10.html">
                        <i class="massive trophy icon"></i>
                        Top 10
                    </a>
                </div>
            </div>
        </div>
        
    </div>
    </form>
</body>
</html>
