<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Assignment.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <div class="ImgContainer">

        <div class="mySlide fade">
            <img src="../images/foodwallpaper.jpg" class="slideShowImg" />
            <div class="ImgContainer-FirstTitle">Welcome to Foodio</div>
            <asp:Button ID="Button1" runat="server" Text="BROWSE NOW" CssClass="showNow" OnClick="Button1_Click" />
        </div>

        <div class="mySlide fade">
            <img src="../images/foodwallpaper2.jpg" class="slideShowImg" />
            <div class="purchaseNow">
                <div style="font-size: 65px;">Over 50</div>
                <div style="font-size: 60px;">Featured Restaurant</div>
                <asp:Button ID="Button2" runat="server" Text="BROWSE NOW" CssClass="purchaseNow-Button" OnClick="Button1_Click" />
            </div>
        </div>

    </div>

    <div style="text-align: center; margin-top: 20px; margin-bottom: 20px;">
        <span class="dot" onclick="currentSlide(1)"></span>
        <span class="dot" onclick="currentSlide(2)"></span>
    </div>




    <div class="heatProduct-Container" style="margin-bottom: 20px;">
        <img src="../images/showingProduct3.0.jpg" class="slideShowImg" />
        <img src="../images/food-transparent-background-7.png" class="heatProduct" />
        <div class="heatProduct-Title">
            <p>HOT</p>
            <p>DEALS</p>
        </div>
        <div class="heatProduct-ProductDetail">
            <p>Smoked Salmon</p>
            <p>Salad</p>
            <p>RM 7.50</p>
            <asp:Button ID="Button3" runat="server" Text="GRAB NOW" CssClass="heatProduct-PurchaseNow" OnClick="Button1_Click" />
        </div>

    </div>

    <div id="disqus_thread"></div>
        <script>
           
            /**
            *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
            *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables    */
            var disqus_developer = 1;
            const urlParams = new URLSearchParams(window.location.search);
            const myParam = urlParams.get('myParam');
            var id = getParameterByName('id');
            var localhost = 'https://localhost:44337/Member/FoodDetail.aspx?id=';
            var localhost2 = localhost + id + ".aspx";

            var disqus_config = function () {
                this.page.url = "https://localhost:44337/Home.aspx";  // Replace PAGE_URL with your page's canonical URL variable
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

        var slideNum = 0;
        showSlides();

        function showSlides() {
            var i;
            var slide = document.getElementsByClassName("mySlide");
            var dot = document.getElementsByClassName("dot");
            for (i = 0; i < slide.length; i++) {
                slide[i].style.display = "none";
            }
            slideNum++;
            if (slideNum > slide.length) { slideNum = 1 }
            for (i = 0; i < dot.length; i++) {
                dot[i].className = dot[i].className.replace(" active", "");
            }
            slide[slideNum - 1].style.display = "block";
            dot[slideNum - 1].className += " active";
            setTimeout(showSlides, 5000);
        }
    </script>
</asp:Content>