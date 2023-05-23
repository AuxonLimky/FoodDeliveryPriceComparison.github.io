<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" AutoEventWireup="true" Async="true" CodeBehind="UserManageDetails.aspx.cs" Inherits="Assignment.Admin.UserManageDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Error.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h4><strong>MANAGE MEMBER INFO</strong></h4>   <hr />
    <br />
    <div class="row">
        <div class="col-lg-6">

            <h4>Username</h4>
            <hr />
            <asp:Label ID="memberusername" runat="server"></asp:Label>
            <br />
            <br />

            <br />
            <br />

        </div>
        <div class="col-lg-6">
            <h4>Email Address</h4>
            <hr />
            <asp:TextBox ID="memberemail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Gmail Address" CssClass="error" ControlToValidate="memberemail"></asp:RequiredFieldValidator>
            <br />
            <br />

            <br />
            <br />
            <br />
            <br />
           <asp:Button ID="memberupdate" Text="Update" runat="server" OnClick="memberupdate_Click" CssClass="btn waves-effect waves-light btn-light" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="memberdelete" Text="Delete" runat="server" OnClick="memberdel_Click" CssClass="btn waves-effect waves-light btn-light" />
        </div>
    </div>
</asp:Content>
