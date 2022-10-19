<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.FirstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblChildFirstForm"><h1>Child First Form</h1></asp:Label>
        <asp:Button runat="server" ID="btn" PostBackUrl="~/FormWihtMasterPage/SecondPage.aspx" Text="call second page"/>
    </div>
</asp:Content>
