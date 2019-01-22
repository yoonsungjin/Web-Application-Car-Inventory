<%@ Page Title="" Language="C#" MasterPageFile="~/StdLayout.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FinalWebApp_SungjinYoon.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
        <div>
            <h3>Customer Registration</h3>
            <table>
                <tr>
                    <td><asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> <asp:Label ID="lblPhone" runat="server" Text="Phone:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>

            </table>
            <asp:Button ID="btnReset" runat="server" Text="Reset" />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" style="width: 78px" />
            
            
        &nbsp;<asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
            
            
        </div>
</asp:Content>
