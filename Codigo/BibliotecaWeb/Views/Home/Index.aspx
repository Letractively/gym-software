<%@ Page Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script type="text/javascript" src="../../Content/shapeworld/js/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="../../Content/shapeworld/js/script.js"></script>
<script type="text/javascript" src="../../Content/shapeworld/js/coin-slider.min.js"></script>
      <div class="slider">
        <div id="coin-slider"> <a href="#"><img src="../../Content/shapeworld/images/slide1.jpg" width="960" height="320" alt="" /> </a> <a href="#"><img src="../../Content/shapeworld/images/slide2.jpg" width="960" height="320" alt="" /> </a> <a href="#"><img src="../../Content/shapeworld/images/slide3.jpg" width="960" height="320" alt="" /> </a> <a href="#"><img src="../../Content/shapeworld/images/slide4.jpg" width="960" height="320" alt="" /> </a> <a href="#"><img src="../../Content/shapeworld/images/slide5.jpg" width="960" height="320" alt="" /> </a></div>
        
      </div>

</asp:Content>
