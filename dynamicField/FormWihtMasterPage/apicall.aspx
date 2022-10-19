<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="apicall.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.apicall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="loading active"></div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel runat="server" ID="UpdatePanel1">
        <ContentTemplate>
            <script type="text/javascript">
                //Sys.Application.add_load(LoadAllScript)
            </script>

            <div class="content-wrapper">

                <h3 class="text-center head">SALES VOUCHER 
                    <span class="invoiceHead">
                        <asp:Label ID="lblInvoiceAndDate" Text="" runat="server" Visible="false"/></span>
                </h3>
                <div class="container_fluid">
                    <div class="row">
                        <div class="panel panel-default pmb0">
                            <div class="panel-body">
                                <div class="col-xs-12">
                                    <asp:Button ID="btnJsonConvert" runat="server" Text="Json COnvert" OnClick="btnJsonConvert_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
