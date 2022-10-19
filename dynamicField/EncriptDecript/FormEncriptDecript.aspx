<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormEncriptDecript.aspx.cs" Inherits="dynamicField.EncriptDecript.FormEncriptDecript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="form-group">
                <asp:Label runat="server" ID="lblEnciptedData">Enter Encripted Data</asp:Label>
                <asp:TextBox CssClass="Form_control" runat="server" ID="txtEnciptedData"></asp:TextBox>
                <asp:Label runat="server" ID="lblDecriptedData"></asp:Label>
                <asp:Button Text="Decript" runat="server" ID="btnDecript" OnClick="btnDecript_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
