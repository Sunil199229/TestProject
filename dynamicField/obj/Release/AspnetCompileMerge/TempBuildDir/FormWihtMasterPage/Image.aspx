<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.Image" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.24/themes/start/jquery-ui.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.24/jquery-ui.min.js"></script>
    <script>
        $(document).ready(function () {
            $(window).on('wheel', function(e) {

                var delta = e.originalEvent.deltaY;
                if (delta > 0) {
                    img = document.getElementById("imgZoom");
                    var height = img.height;
                    var width = img.width;
                    var a = $(this).scrollTop();
                    var x = 1;

                    height -= x;
                    width -= x;

                    img.height = height < 150 ? 150 : height;
                    img.width = height < 200 ? 200 : width;
                }
                else {
                    img = document.getElementById("imgZoom");
                    var height = img.height;
                    var width = img.width;
                    var a = $(this).scrollTop();
                    var x = 1;

                    height += x;
                    width += x;

                    img.height = height < 150 ? 150 : height;
                    img.width = height < 200 ? 200 : width;
                }
            });
        });      
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:Image runat="server" id="imgZoom" ImageUrl="~/Image/HomePage.png" Height="100" Width="100" />--%>
    <img id="imgZoom" src="../Image/HomePage.png" Height="100" Width="100" />
</asp:Content>
