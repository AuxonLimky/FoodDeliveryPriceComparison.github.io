<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" Async="true" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="Assignment.Admin.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Foodio | Manage Members</title>
    <link href="../css/List.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h4><strong>MEMBER LIST</strong></h4>
    <hr />
    <br />
    <div>
        <br />
        <asp:GridView ID="gv" runat="server" OnSelectedIndexChanged="gv_SelectedIndexChanged" CssClass="gridview" Width="100%" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="NO.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="User Name">
                    <ItemTemplate>
                        <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("user_Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="User Email">
                    <ItemTemplate>
                        <asp:Label ID="lblUserEmail" runat="server" Text='<%#Eval("user_Email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="User Role">
                    <ItemTemplate>
                        <asp:Label ID="lblUserRole" runat="server" Text='<%#Eval("UserRole") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="userupdate" runat="server" OnClick="userupdate_Click" CommandArgument='<%# Eval("Manage") %>' Text='Manage' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>