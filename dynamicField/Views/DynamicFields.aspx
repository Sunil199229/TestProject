<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicFields.aspx.cs" Inherits="dynamicField.Views.DynamicFields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    
    <script>

        $(document).ready(function () {

        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel runat="server" ID="updpnl">
                <ContentTemplate>
                    <asp:ScriptManager runat="server" ID="srptmng"></asp:ScriptManager>
                    <div class="panel" id="pnl" runat="server">
                         <asp:CheckBoxList runat="server" ID="chkboxlist" OnSelectedIndexChanged="chkboxlist_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Text="a" Value="1"></asp:ListItem>
                        <asp:ListItem Text="b" Value="2"></asp:ListItem>
                        <asp:ListItem Text="c" Value="3"></asp:ListItem>
                        <asp:ListItem Text="d" Value="4"></asp:ListItem>
                        <asp:ListItem Text="e" Value="5"></asp:ListItem>
                    </asp:CheckBoxList>
                        <asp:Button runat="server" ID="btnSave" OnClick="btnSave_Click" Text="Save"/>
                    </div>                   
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
