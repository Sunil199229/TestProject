<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function validate() {

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server" ID="updpnl">
        <ContentTemplate>
            <%--<asp:Image runat="server" ID="imglogin1" Height="100" Width="100" ImageAlign="AbsMiddle" ImageUrl="~/Image/HomePage.png"/>--%>
            <%--<img ID="imglogin" Height="100" Width="100" src="../Image/HomePage.png" onclick="return validate(this);" />--%>
            <asp:ImageButton runat="server" ID="imglogin" Height="200" Width="200" ImageUrl="~/Image/HomePage.png" OnClick="imglogin_Click" />
            <asp:HiddenField runat="server" ID="hdfFirstStatus" />
            <asp:HiddenField runat="server" ID="hdfSecondStatus" />
            <asp:HiddenField runat="server" ID="hdfThirdStatus" />
            <asp:HiddenField runat="server" ID="hdfForthStatus" />
            <asp:HiddenField runat="server" ID="hdfCount"/>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
