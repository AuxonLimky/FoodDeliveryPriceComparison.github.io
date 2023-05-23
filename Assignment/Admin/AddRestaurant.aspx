<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" AutoEventWireup="true" CodeBehind="AddRestaurant.aspx.cs" Inherits="Assignment.Admin.AddRestaurant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../css/List.css" rel="stylesheet" />
    <link href="../css/Error.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h4><strong>ADD RESTAURANT</strong></h4>
    <hr />
    <div class="row">
        <div class="col-lg-6">
            <h4>Restaurant Name</h4>
            <hr />
            <asp:TextBox ID="storeRestaurantName" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter [Restaurant Name]" ControlToValidate="storeRestaurantName" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br/>

            <h4>Restaurant Address</h4>
            <hr />
            <asp:TextBox ID="storeRestaurantAddress" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter [Restaurant Address]" ControlToValidate="storeRestaurantAddress" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Operational Hour</h4>
            <hr />
            <asp:TextBox ID="storeResOperationHour" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter [Restaurant Operational Hour]" ControlToValidate="storeResOperationHour" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Phone No</h4>
            <hr />
            <asp:TextBox ID="storeResPhoneNo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter [Restaurant Phone No]" ControlToValidate="storeResPhoneNo" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Rating</h4>
            <hr />
            <asp:TextBox ID="storeRating" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter [Restaurant Rating]" ControlToValidate="storeRating" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Status</h4>
            <hr />
            <asp:TextBox ID="storeResStatus" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please Enter [Restaurant Status]" ControlToValidate="storeResStatus" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>ShopeeFood Delivery Price</h4>
            <hr />
            <asp:TextBox ID="storeShopeeFoodPrice" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please Enter [Restaurant Shopee Delivery Price]" ControlToValidate="storeShopeeFoodPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>GrabFood Delivery Price</h4>
            <hr />
            <asp:TextBox ID="storeGrabFoodPrice" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please Enter [Restaurant GrabFood Delivery Price]" ControlToValidate="storeGrabFoodPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>FoodPanda Delivery Price</h4>
            <hr />
            <asp:TextBox ID="storeFoodPandaPrice" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please Enter [Restaurant FoodPanda Delivery Price]" ControlToValidate="storeFoodPandaPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

        </div>
        <div class="col-lg-6">   
                       
         <h4>Upload Restaurant Image</h4>
            <hr />
            <asp:FileUpload ID="imgUpload" runat="server" Font-Bold="True" Font-Italic="True" CssClass="form-control-file" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Insert Image" ControlToValidate="imgUpload" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Only JPG | jpg files are allowed" ControlToValidate="imgUpload" Display="Dynamic" ValidationExpression=".+\.(jpg|JPG)" CssClass="error"></asp:RegularExpressionValidator>
            <br />

        <h4>Restaurant's Food</h4>
        <hr />
        <asp:TextBox ID="storeFood" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please Enter [Food]" ControlToValidate="storeFood" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />

        <h4>Restaurant's Food Price</h4>
        <hr />
        <asp:TextBox ID="storeFoodPrice" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please Enter [Food Price]" ControlToValidate="storeFoodPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />

        <h4>Restaurant's Food 2</h4>
        <hr />
        <asp:TextBox ID="storeFood1" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please Enter [Food]" ControlToValidate="storeFood1" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />

        <h4>Restaurant's Food Price 2</h4>
        <hr />
        <asp:TextBox ID="storeFoodPrice1" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Please Enter [Food Price]" ControlToValidate="storeFoodPrice1" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />

        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="btn waves-effect waves-light btn-light" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="False" CssClass="btn waves-effect waves-light btn-light" OnClick="btnCancel_Click" />
        </div>
    </div>
</asp:Content>
