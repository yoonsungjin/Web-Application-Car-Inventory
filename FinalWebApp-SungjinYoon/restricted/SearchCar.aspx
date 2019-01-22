<%@ Page Title="" Language="C#" MasterPageFile="~/StdLayout.Master" AutoEventWireup="true" CodeBehind="SearchCar.aspx.cs" Inherits="FinalWebApp_SungjinYoon.SearchCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div>
        <h3>Search</h3>
        <asp:Label ID="Label1" runat="server" Text="Make"></asp:Label>
        <asp:DropDownList ID="ddMake" runat="server" OnSelectedIndexChanged="ddMake_SelectedIndexChanged" AutoPostBack = "true" CssClass="form-control">
            <asp:ListItem Text = "--Select Make--" Value = ""></asp:ListItem>
        </asp:DropDownList>       
        <asp:Label ID="Label2" runat="server" Text="Model"></asp:Label>
        <asp:DropDownList ID="ddModel" runat="server" Enabled = "false" OnSelectedIndexChanged="ddModel_SelectedIndexChanged" AutoPostBack = "true" CssClass="form-control">
            <asp:ListItem Text = "--Select Model--" Value = ""></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click1" />
        <br />
    </div>   
    <div class="container">
    <div class="row">
      <div class="col-md-12">
        <div class="table-responsive">
            <asp:GridView ID="gvCar" runat="server" AutoGenerateColumns="False"  CssClass="table table-bordered table-condensed" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="MakeId" HeaderText="Make" />
                    <asp:BoundField DataField="ModelId" HeaderText="Model" />
                    <asp:BoundField DataField="Year" HeaderText="Year" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Mileage" HeaderText="Mileage" />
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="100px" Width="100px"
                                ImageUrl='<%# Eval("PhotoUrl") %>'/>
                            <asp:CheckBox ID="chkSel" runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>

            
                    <asp:TemplateField></asp:TemplateField>

            
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
         </div>
      </div>
    </div>
  </div>

<asp:Button ID="btnAddGarage" runat="server" OnClick="btnAddGarage_Click" Text="Add to Garage" />
&nbsp;<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
</asp:Content>
