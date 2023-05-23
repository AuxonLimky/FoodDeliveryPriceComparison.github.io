<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" Async="true" AutoEventWireup="true" CodeBehind="AdminProfile.aspx.cs" Inherits="Assignment.Admin.AdminProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-lg-5 profileadmin">
            <h4><strong>Profile Picture</strong></h4>
            <hr />
            <asp:Image ID="Image1" CssClass="profileadmin" runat="server" Width="350" />
        </div>
        <div class="col-lg-7">
            <h4><strong>ProfileName</strong></h4>
            <hr />
            <asp:Label ID="txtAdminName" runat="server" ></asp:Label><br />
            <br />
         
            <h4><strong>Gender</strong></h4>
            <hr />
            <asp:Label ID="txtAdminGender" runat="server"></asp:Label><br />
            <br />

            <h4><strong>Role</strong></h4>
            <hr />
            <asp:TextBox ID="txtAdminRole" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox> 
            <br />
        </div>
    </div>
</asp:Content>
