<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="SendSMSEMAIL.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.SendSMSEMAIL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server" ID="updpnl">
        <ContentTemplate>
            <asp:FileUpload runat="server" ID="flup" />
            <asp:Button runat="server" ID="btnEMail" OnClick="btnEMail_Click" Text="Email"/>
            <asp:Button runat="server" ID="btnSMS" OnClick="btnSMS_Click" Text="SMS"/>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnEMail" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
