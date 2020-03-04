<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ques6(session and view).aspx.cs" Inherits="ques6.ques6_session_and_view_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your name(session) " ForeColor="#FF0066"></asp:Label>
               <br />
               <br />
               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
               <br />
               <br />
            <asp:Label ID="Label2" runat="server" Text="Enter your password(session) " ForeColor="#FF0066"></asp:Label>
               <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               <br />
               <br />
            <asp:Label ID="Label3" runat="server" Text="Enter your name(view)" ForeColor="#993333"></asp:Label>
               <br />
            <br />
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
               <br />
               <br />
            <asp:Label ID="Label4" runat="server" Text="Enter your password(view)" ForeColor="#993333"></asp:Label>
               <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
               <br />
               <br />
            <br />

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="click me ! " BackColor="Red" ForeColor="#FFFF99" Width="80px" />
        </div>
    </form>
</body>
</html>
