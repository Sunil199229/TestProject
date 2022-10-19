<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="SecondPage.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.SecondPage" %>

<%--<%@ Register Src="~/FormWihtMasterPage/CommonPage.ascx" TagName="cc2" TagPrefix="cc3" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server" ID="uppnl">
        <ContentTemplate>
            <%--<asp:ScriptManager runat="server" ID="scrpMng"></asp:ScriptManager>--%>

            <asp:Label runat="server" ID="lblmsg">Second Page</asp:Label>
            <%-- <cc3:cc2 runat="server" ID="dd" />--%>
            <asp:Timer runat="server" ID="timer1" OnTick="timer1_Tick" Interval="100" Enabled="False"></asp:Timer>
            <asp:Label runat="server" ID="lblTimer"></asp:Label>
            <asp:Button runat="server" ID="btnTimerStar" Text="start" OnClick="btnTimerStar_Click"/>
            <asp:Button runat="server" ID="btnPause" Text="Pause" OnClick="btnPause_Click"/>
            <asp:Button runat="server" ID="btnStop" Text="Stop" OnClick="btnStop_Click"/>
            <asp:Button runat="server" ID="btnReset" Text="Reset" OnClick="btnReset_Click"/>
            <asp:GridView runat="server" ID="grdviewTable" AllowPaging="true" Width="500px" OnPageIndexChanging="grdviewTable_PageIndexChanging" AllowSorting="True" OnSorting="grdviewTable_Sorting" PageSize="5">
                <PagerSettings Position="TopAndBottom" Mode="NextPreviousFirstLast" PageButtonCount="10" LastPageText="Last" FirstPageText="First" NextPageText="Next" PreviousPageText="Prev"/>
            </asp:GridView>
            <asp:GridView runat="server" ID="GridView1" AllowPaging="true" PagerSettings-Mode="NextPreviousFirstLast">
                <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="next" LastPageText="last" />
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
