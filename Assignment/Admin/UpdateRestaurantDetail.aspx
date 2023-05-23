<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" Async="true" AutoEventWireup="true" CodeBehind="UpdateRestaurantDetail.aspx.cs" Inherits="Assignment.Admin.UpdateRestaurantDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/List.css" rel="stylesheet" />
    <link href="../css/Error.css" rel="stylesheet" />
    <link href="../css/profiletemplate.css" rel="stylesheet" />

    <style>
        .marginHREF{
            margin : 0 7px 0 7px;
        }
        .marginHREF img:hover{
            opacity:0.5;
        }
        .covergenre{
            width : 75px;
            height : 75px;
        }
        .songcover img {
            border-radius: 50%;
            box-shadow: 0 10px 10px rgba(0, 0, 0, 0.5);
            width : 300px;
            height: 300px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h4><strong>UPDATING RESTAURANT</strong></h4>
    <hr />
    <div class="row">
         <div class="col-lg-6">
            <h4>Restaurant Image</h4>
            <hr />
            <div class="col-sm songcover">
                <asp:Image ID="resImg" runat="server" />
            </div>
            <br />

            <h4>Restaurant Name</h4>
            <hr />
            <asp:TextBox ID="updateResName" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter [Restaurant Name]" ControlToValidate="updateResName" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
             <br />

             <h4>Restaurant Address</h4>
             <asp:TextBox ID="updateResAddress" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter [Restaurant Address]" ControlToValidate="updateResAddress" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
             <br />

             <h4>Restaurant Operational Hour</h4>
            <hr />
            <asp:TextBox ID="updateResOperationHour" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter [Restaurant Operational Hour]" ControlToValidate="updateResOperationHour" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Phone No</h4>
            <hr />
            <asp:TextBox ID="updateResPhoneNo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter [Restaurant Phone No]" ControlToValidate="updateResPhoneNo" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Rating</h4>
            <hr />
            <asp:TextBox ID="updateRating" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter [Restaurant Rating]" ControlToValidate="updateRating" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <h4>Restaurant Status</h4>
            <hr />
            <asp:TextBox ID="updateResStatus" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please Enter [Restaurant Status]" ControlToValidate="updateResStatus" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

          </div>
              <div class="col-lg-6">
                  <br />

                  <h4>Update Restaurant Image</h4>
                  <hr />
            <asp:FileUpload ID="updateImg" runat="server" Font-Bold="True" Font-Italic="True" CssClass="form-control-file" />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Insert Image" ControlToValidate="updateImg" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Only JPG | jpg files are allowed" ControlToValidate="updateImg" Display="Dynamic" ValidationExpression=".+\.(jpg|JPG)" CssClass="error"></asp:RegularExpressionValidator>
                  <br />

            <h4>Restaurant's Food</h4>
                <hr />
                <asp:TextBox ID="updateFood" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please Enter [Food]" ControlToValidate="updateFood" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                <h4>Restaurant's Food Price</h4>
                <hr />
                <asp:TextBox ID="updateFoodPrice" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please Enter [Food Price]" ControlToValidate="updateFoodPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                <h4>Restaurant's Food 2</h4>
                <hr />
                <asp:TextBox ID="updateFood1" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please Enter [Food]" ControlToValidate="updateFood1" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                <h4>Restaurant's Food Price 2</h4>
                <hr />
                <asp:TextBox ID="updateFoodPrice1" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Please Enter [Food Price]" ControlToValidate="updateFoodPrice1" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                <h4>ShopeeFood Delivery Price</h4>
                <hr />
                <asp:TextBox ID="updateShopeeFoodPrice" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please Enter [Restaurant Shopee Delivery Price]" ControlToValidate="updateShopeeFoodPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                <h4>GrabFood Delivery Price</h4>
                <hr />
                <asp:TextBox ID="updateGrabFoodPrice" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please Enter [Restaurant GrabFood Delivery Price]" ControlToValidate="updateGrabFoodPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                <h4>FoodPanda Delivery Price</h4>
                <hr />
                <asp:TextBox ID="updateFoodPandaPrice" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please Enter [Restaurant FoodPanda Delivery Price]" ControlToValidate="updateFoodPandaPrice" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

              </div>
    </div>
    <asp:Label ID="txtSong" runat="server" Text="Label" Visible="False"></asp:Label>
    <div class="row">
        <div class="col-lg-12">
             <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="btn waves-effect waves-light btn-light" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="btn waves-effect waves-light btn-light" />
            </div>
        </div>
</asp:Content>
