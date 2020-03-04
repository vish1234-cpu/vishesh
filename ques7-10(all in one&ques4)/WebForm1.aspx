<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ques7_10_all_in_one_.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<html>
    <head>
    <title>STUDENT REGISTRATION FORM</title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        input
        {
            width: 200px;
        }
        table
        {
            border: 1px solid #ccc;
        }
        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
        table th, table td
        {
            padding: 5px;
            border-color: #ccc;
        }
    </style>
</head>
<body>
   
    <table border="6" cellpadding="2" cellspacing="2">
        <tr>
            <th colspan="3">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 Student Registration
                 Form
            </th>
        </tr>
        <tr>
            <td>
               Student Username
            </td>
            <td>
                <asp:TextBox ID="stu_name" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="#CC3300" ControlToValidate="stu_name"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
               Student Age
            </td>
            <td>
                <asp:TextBox ID="stuage" runat="server" />
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="between 6-18 only.." ControlToValidate="stuage" ForeColor="#CC3300" MaximumValue="18" MinimumValue="10" Display="Dynamic"></asp:RangeValidator>  
            </td>
        </tr>
        
        <tr>
            <td>
              Enter Password
            </td>
            <td>
                <asp:TextBox ID="stupass" runat="server" TextMode="Password" />
            </td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="#CC3300" ControlToValidate="stupass"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
              Enter Confirm Password
            </td>
            <td>
                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" />
            </td>
            <td>
                <asp:CompareValidator ErrorMessage="Password Entered did not match." ForeColor="#CC3300" ControlToCompare="stupass"
                    ControlToValidate="ConfirmPassword" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
               Enter Your Email
            </td>
            <td>
                <asp:TextBox ID="stuemail" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="#CC3300"
                    ControlToValidate="stuemail" runat="server" />
                <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="stuemail" ForeColor="#CC3300" ErrorMessage="Invalid email address." />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button Text="Submit Form" runat="server" OnClick="StudentRegister" Width="90px"  />
            </td>
            <td>
            </td>
        </tr>
        
    </table>
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label1" runat="server" CssClass="alert-success" ForeColor="#000099" Height="40px"></asp:Label>

    <br />
    <br />

    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
   

    <br />
   

    <asp:Button ID="Button1" runat="server" Text="CB 1" CommandName="Button1" OnCommand="Button1_Command" CausesValidation="False" Width="70px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" ForeColor="#660066"></asp:Label>
</body>

    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="CB 2" CommandName="Button2" OnCommand="Button1_Command" CausesValidation="False" Width="70px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" ForeColor="#660066"></asp:Label>
    </html>
</asp:Content>
