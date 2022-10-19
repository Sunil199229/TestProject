<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadFileProperty.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.ReadFileProperty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function fnValidate() {
            var pickPath = document.getElementById("<%=txtPickPath.ClientID%>").value;
            var SavePath = document.getElementById("<%=txtSavePath.ClientID%>").value;
            var fileName = document.getElementById("<%=txtFileName.ClientID%>").value;

            if (pickPath == "") {
                var lblmsg = document.getElementById("<%=lblMsg.ClientID%>");
                document.getElementById("<%=lblMsg.ClientID%>").innerText = "Enter Pick Path";
                document.getElementById("<%=lblMsg.ClientID%>").style.display = "inline-block";
                document.getElementById("<%=lblMsg.ClientID%>").style.color = "red";
                document.getElementById("<%=lblMsg.ClientID%>").focus();
                return false
            }
            else if (SavePath == "") {
                return false
            }
            else if (fileName == "") {
                return false
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtPickPath" Placeholder="Enter Pick Path"></asp:TextBox>
            <asp:TextBox runat="server" ID="txtSavePath" Placeholder="Enter Save Path"></asp:TextBox>
            <asp:TextBox runat="server" ID="txtFileName" Placeholder="Enter File Name"></asp:TextBox>
            <asp:Label ID="lblMsg" runat="server" Style="display: none" />
            <asp:Button Text="Get Details" ID="btngetdetail" runat="server" OnClick="btngetdetail_Click" OnClientClick="return fnValidate();"/>
        </div>
    </form>
</body>
</html>
