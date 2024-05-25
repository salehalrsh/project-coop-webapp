<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="pro1.Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/QuizStyle.css" rel="stylesheet" />
    <title></title>
    <script>

        function opclick(id) {
            document.getElementById('<%=oplbl.ClientID %>').value = id;
            document.getElementById('<%=Button1.ClientID %>').disabled = false;
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <img src="img/cybersecurity_logo.svg" alt="AFTS Logo" />
    <img  src="img/hadeed_logo.png"  alt="" style="float: right;" />
    
     <asp:ScriptManager runat="server"></asp:ScriptManager>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <ContentTemplate>
         <asp:Image ID="Image1" runat="server" />
        <div class="box">
        <div class="form">
            <div id="Qdiv" runat="server"></div>
        <div>
            <asp:HiddenField ID="oplbl" runat="server" />
        </div>
                <div class="next-button">


                            <asp:Button ID="Button1" runat="server" Text="Start" OnClick="Button1_Click" />
                     
                    

                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Re Take Test" Visible="False" />
                     
                    

                </div>
            </div>
        
        </div>
         <asp:Label ID="oplbl1" runat="server"></asp:Label>
         <asp:Label ID="oplbl2" runat="server"></asp:Label>
     </ContentTemplate>
     </asp:UpdatePanel>
  
        
    </form>
</body>
</html>
