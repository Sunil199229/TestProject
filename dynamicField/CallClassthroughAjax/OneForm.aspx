<%@ Page Title="" Language="C#" MasterPageFile="~/CallClassthroughAjax/OneMaster.Master" AutoEventWireup="true" CodeBehind="OneForm.aspx.cs" Inherits="dynamicField.CallClassthroughAjax.OneForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        $(document).ready(function () {

            //callMaster();
        });
        //function callMaster(){
        //    $.get("OneClass.cs/OneMethod")
        //}

        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: "OneMaster.master/myFun",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $("#Content").text(response.d);
                },
                failure: function (response) {
                    alert(response.d);
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
</asp:Content>
