<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="LoginDesign.aspx.cs" Inherits="Assignment.LoginDesign" MasterPageFile="~/Site1.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <!DOCTYPE html>
      
        <div class="main">
        <!-- Sing in  Form -->
        <section class="sign-in">
            <div class="container">
                <div class="signin-content">
                    <div class="signin-image">
                        <figure><img src="../images/bee-laptop-decal.jpg" alt="sing up image"></figure>
                        <a href="RegisterDesignFacebook.aspx" class="signup-image-link">Create an account</a>
                        <a href="AdminLoginDesign.aspx" class="signup-image-link">Admin Login
                        </a>

                    </div>

                    <div class="signin-form">
                        <h2 class="form-title">Foodio Login</h2>
                        <form method="POST" class="register-form" id="login-form">
                            <div class="form-group">
                                <label for="your_name" style="padding-bottom:20px;"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                <asp:TextBox ID="txtname" runat="server" placeholder="Your name" CssClass="input"></asp:TextBox>                                
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter name." ControlToValidate="txtname" Display="Static" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label for="your_pass" style="padding-bottom:50px;"><i class="zmdi zmdi-lock"></i></label>
                                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" placeholder="Your Password" CssClass="input"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter password." ControlToValidate="txtpassword" Display="Static" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:CustomValidator ID="cvNotMatched" runat="server" ErrorMessage="[Password] and [Username] not matched" ControlToValidate="txtPassword" ForeColor="Red"></asp:CustomValidator>
                            </div>

                            <div class="form-group form-button">
                                <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" BackColor="Yellow" BorderColor="#FFCC00" CssClass="input"></asp:Button>
                               <asp:CheckBox ID="chkRememberMe" runat="server"/>Remember Me
                            </div>
<%--                            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />--%>
                            <br />
                        </form>
                    </div>
                </div>
            </div>
        </section>
      </div>

    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="js/main.js"></script>


</asp:Content>