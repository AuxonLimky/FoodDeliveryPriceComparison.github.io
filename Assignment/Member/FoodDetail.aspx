<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FoodDetail.aspx.cs" Inherits="Assignment.FoodDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <style>
	    .column {
	      padding: 16px;
	      height: 250px;
	      margin: 5px;
	      background-color: floralwhite;
          
	    }
    </style>
    <div class="product-container">
        <hr style="width: 67%; margin-left: 0" />
        <h1 style="font-family: Corbel; color:black;">Delivery Fee</h1>
    </div>
	    <div class="container" style="display: grid; grid-template-columns: 300px 300px 300px; text-align: center; border-color:antiquewhite;">
	        <div class="column">
                <img src="/images/shopeefood11.png" style="width:200px; height:200px;" />
                <h2>RM <asp:Label ID="lblshopeeFoodPrice" runat="server" class="text-info" Text='<%# Eval("shopeeFoodPrice") %>'></asp:Label></h2>
	        </div>
	        <div class="column">
                <img src="/images/foodpanda11.png" style="width:200px; height:200px;" />
                <h2>RM <asp:Label ID="lblfoodPandaPrice" runat="server" class="text-info" Text='<%# Eval("foodPandaPrice") %>'></asp:Label></h2>
	        </div>
	        <div class="column">
                <img src="/images/grabfood11.png" style="width:200px; height:200px;" />
	            <h2>RM <asp:Label ID="lblgrabFoodPrice" runat="server" class="text-info" Text='<%# Eval("grabFoodPrice") %>'></asp:Label></h2>
	        </div>

	    </div>
            <div class="col-lg-12 text-center">                
            <br />
            <br />

            <div class="container">
                <div class="row">
                    <div class="col-sm songcover">
                        <%--<asp:Image ID="img1" runat="server"/> <br /><br />--%>
                        <h1><asp:Label ID="lblName" class="text-info" runat="server" Text='<%# Eval("resName") %>'></asp:Label></h1>
                        <br />
                    </div>
                </div>
            </div>
          </div>
            <div class="container">
                <div class="row">
                    <div class="col-sm">
                        <h2>Menu Price</h2>
                        <asp:Label ID="lblFood" class="text-info" runat="server" Text='<%# Eval("food1") %>'></asp:Label>
                        - RM <asp:Label ID="lblFoodPrice" class="text-info" runat="server" Text='<%# Eval("food1Price") %>'></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblFood2" class="text-info" runat="server" Text='<%# Eval("food2") %>'></asp:Label>
                        <asp:Label ID="lblFoodPrice2" class="text-info" runat="server" Text='<%# Eval("food2Price") %>'></asp:Label>

                    </div>
<%--                    <div class="col-sm">
                        <h6>Artist</h6>
                        <asp:Label ID="lblArtist" class="text-info" runat="server" Text='<%# Eval("foodCategory") %>'></asp:Label>
                        <h6>File Songs</h6>
                        <asp:Label ID="lblFileSongs" class="text-info" runat="server" Text='<%# Eval("shopeeFoodPrice") %>'></asp:Label>
                    </div>--%>
                </div>
            </div>

            <div id="disqus_thread"></div>
            <script>
            /**
            *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
            *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables    */

            const urlParams = new URLSearchParams(window.location.search);
            const myParam = urlParams.get('myParam');
            var id = getParameterByName('id');
            var localhost = 'https://localhost:44337/Member/FoodDetail.aspx?id=';
            var localhost2 = localhost + id + ".aspx";

            var disqus_config = function () {
            this.page.url = localhost2;  // Replace PAGE_URL with your page's canonical URL variable
            this.page.identifier = id; // Replace PAGE_IDENTIFIER with your page's unique identifier variable
            };
            
            (function () { // DON'T EDIT BELOW THIS LINE
                var d = document, s = d.createElement('script');
                s.src = 'https://foodio-1.disqus.com/embed.js';
                s.setAttribute('data-timestamp', +new Date());
                (d.head || d.body).appendChild(s);
                })();

            function getParameterByName(name, url = window.location.href) {
                name = name.replace(/[\[\]]/g, '\\$&');
                var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
                    results = regex.exec(url);
                if (!results) return null;
                if (!results[2]) return '';
                return decodeURIComponent(results[2].replace(/\+/g, ' '));
            }
            </script>
            <noscript>Please enable JavaScript to view the <a href="https://disqus.com/?ref_noscript">comments powered by Disqus.</a></noscript>
</asp:Content>
