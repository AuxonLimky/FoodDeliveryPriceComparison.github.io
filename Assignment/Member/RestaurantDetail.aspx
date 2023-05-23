<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RestaurantDetail.aspx.cs" Inherits="Assignment.RestaurantDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ListView.css" rel="stylesheet" />
    <link href="../css/profiletemplate.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <div class="product-container">
    <hr style="width: 67%; margin-left: 0" />
    <h1 style="font-family: Corbel; color:black;">Restaurant</h1>
    <h3 class="text-success genrecover">Search Restaurant</h3>
        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" Width="950" Height="40" ForeColor="Black" BackColor="White" placeholder=" Search Here (Eg. Domino / Pizza Hut)"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    </div>



    <asp:ListView ID="lv" runat="server" GroupItemCount="1">
       <ItemTemplate>                        
<%--            <asp:HiddenField ID="HiddenField1" Value='<%# Eval("resName") %>' runat="server" />--%>
<%--            <a class="product-list" href="ProductDetail.aspx?ProductID=<%# Eval("ProductID") %>">
                <asp:Image ID="imgProduct" CssClass="imgProductShow" runat="server" />
                <div class="imgProductShow-text">
                    <div style="margin-bottom:5px;"><%# Eval("resName") %></div>
                    <div>RM <%# Eval("resDeliveryPrice") %></div>
                </div>
            </a>--%>
           <div class="courses-container" style="display:inline-block; margin-left:100px;">
               <div class="course" style="width:650px; height:250px;">
                   <div class="course-preview">
                         <img src="data:image/jpeg;base64, <%# Eval("resImg") %>"/>
                       
                   </div>
                       <div class="course-info">
                       <h1 style="color:black"><%# Eval("resName") %></h1>
                         <p> Operational Hours :<%# Eval("resOperationHour") %></p>
                         <p> Rating :<%# Eval("resRating") %></p>
                         <p> Status :<%# Eval("resStatus") %></p>
                   <asp:Button ID="ButtonDetail" runat="server" OnClick="ButtonDetail_Click" CommandArgument='<%# Eval("Details") %>' Text="More Details" />
                   </div>
               </div>
            </div>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
