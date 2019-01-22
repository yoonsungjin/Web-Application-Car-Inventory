<%@ Page Title="" Language="C#" MasterPageFile="~/StdLayout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalWebApp_SungjinYoon.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h3>Login</h3>
    <table>
        <tr>
            <td>User Name:</td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password: </td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><div style="height: 35px"><asp:CheckBox ID="CheckBox1" runat="server" Text="Remember Me." /></td>
            <td><asp:Label ID="lblStatus" runat="server"></asp:Label></td>
        </tr>
        
    </table>
    <asp:Button ID="btnLogin" runat="server" Text="Log in" OnClick="Button1_Click" />
    &nbsp;
    
</asp:Content>


