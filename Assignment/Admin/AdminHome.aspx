<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="Assignment.Admin.AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Foodio | Admin Home</title>
    <style>
        .main-welcome{
            text-align : center;
        }
        .main-welcome h2:hover{
            opacity:0.7;
            background-color:azure;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h4 class="card-title">Foodio Admin Page</h4>
    <hr>
    <br />
    <div class="main-welcome">
    <h2>Welcome back</h2>
        <asp:LoginName ID="LoginName1" runat="server" Font-Size="XX-Large" Font-Bold="True" Font-Italic="True" />
    </div>
</asp:Content>
