<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" Async="true" AutoEventWireup="true" CodeBehind="ManageRestaurant.aspx.cs" Inherits="Assignment.Admin.ManageRestaurant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/List.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h4><strong>Restaurant List</strong></h4>
    <br />
    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" CssClass="gridview" Width="100%">
               <Columns>
                   <asp:TemplateField HeaderText="NO.">
                       <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Restaurant Name">
                       <ItemTemplate>
                            <asp:Label ID="lblresName" runat="server" Text='<%#Eval("resName") %>'></asp:Label>
                        </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Address">
                       <ItemTemplate>
                            <asp:Label ID="lblresAddress" runat="server" Text='<%#Eval("resAddress") %>'></asp:Label>
                        </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Operation Hour">
                       <ItemTemplate>
                            <asp:Label ID="lblresOperationHour" runat="server" Text='<%#Eval("resOperationHour") %>'></asp:Label>
                        </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Phone Number">
                       <ItemTemplate>
                            <asp:Label ID="lblresPhoneNo" runat="server" Text='<%#Eval("resPhoneNo") %>'></asp:Label>
                        </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Rating">
                       <ItemTemplate>
                            <asp:Label ID="lblresRating" runat="server" Text='<%#Eval("resRating") %>'></asp:Label>
                        </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="restaurantUpdate" runat="server" OnClick="restaurantUpdate_Click" CommandArgument='<%# Eval("Update") %>' Text='Manage' />
                        </ItemTemplate>
                    </asp:TemplateField>
               </Columns>              
            </asp:GridView>
    <br /><br />
    <asp:Hyperlink class="btn btn-info" Text="ADD RESTAURANT" runat="server" ID="hplAddSong" NavigateUrl="~/Admin/AddRestaurant.aspx"></asp:Hyperlink>
    <br /><br />
</asp:Content>
