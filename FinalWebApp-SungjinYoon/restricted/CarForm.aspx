<%@ Page Title="" Language="C#" MasterPageFile="~/StdLayout.Master" AutoEventWireup="true" CodeBehind="CarForm.aspx.cs" Inherits="FinalWebApp_SungjinYoon.restricted.CarForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h3>Manage Car</h3>
        <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Make"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddMake" runat="server" OnSelectedIndexChanged="ddMake_SelectedIndexChanged" AutoPostBack = "true">
                    <asp:ListItem Text = "--Select Make--" Value = ""></asp:ListItem>
                </asp:DropDownList>       
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Model"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddModel" runat="server" Enabled = "false"  AutoPostBack = "true">
                    <asp:ListItem Text = "--Select Model--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Year"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Mileage"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMileage" runat="server"></asp:TextBox>
            </td>
        </tr>

    </table>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
    </div>

</asp:Content>
