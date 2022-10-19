<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multipagereg.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.Multipagereg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel ID="upPnl" runat="server">
                <ContentTemplate>
                    <asp:ScriptManager runat="server" ID="scrptmng"></asp:ScriptManager>
                    <div runat="server" id="divFirst">
                        <asp:Label runat="server" ID="lblName">Name</asp:Label>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:Label runat="server" ID="lblFname">F Name</asp:Label>
                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                    </div>
                    <div runat="server" id="divSecond" visible="false">
                        <asp:Label runat="server" ID="lblMobNo">Mob No</asp:Label>
                        <asp:TextBox ID="txtMobNo" runat="server"></asp:TextBox>
                        <asp:Label runat="server" ID="lblAdd">Add</asp:Label>
                        <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                    </div>
                    <div runat="server" id="divThird" visible="false">
                        <asp:Label runat="server" ID="lblPinCode">Pin Code</asp:Label>
                        <asp:TextBox ID="txtPinCode" runat="server"></asp:TextBox>
                        <asp:Label runat="server" ID="lblState">State</asp:Label>
                        <asp:DropDownList runat="server" ID="ddlState" AppendDataBoundItems="true">
                            <asp:ListItem Selected="True" Value="0" Text="--Select State--"></asp:ListItem>
                            <asp:ListItem Value="1" Text="MP"></asp:ListItem>
                            <asp:ListItem Value="2" Text="UP"></asp:ListItem>
                            <asp:ListItem Value="3" Text="AP"></asp:ListItem>
                            <asp:ListItem Value="4" Text="UK"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div runat="server" id="DivComm">
                        <asp:Button ID="btnPrv" runat="server" Text="Prev" Visible="false" OnClick="btnPrv_Click" />
                        <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Visible="false" OnClick="btnSubmit_Click" />
                    </div>
                </ContentTemplate>
                <%-- <Triggers>
                    <asp:PostBackTrigger ControlID="" />
                </Triggers>--%>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
