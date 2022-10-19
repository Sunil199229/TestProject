<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="ExcelUpload.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.ExcelUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server" ID="updpnl">
        <ContentTemplate>
            <div class="col-md-12">
                <div class="form-group">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="row">
                                <asp:FileUpload runat="server" ID="FileUploadExcelFile" CssClass="col-md-2"></asp:FileUpload>
                                <asp:Button runat="server" ID="btnUpload" Text="Upload" CssClass="btn btn-success col-md-1" OnClick="btnUpload_Click" />
                            </div>
                        </div>
                        <div class="col-md-12">
                            <asp:ListBox runat="server" ID="lstbox" Height="100" Width="100"></asp:ListBox>
                            <asp:Button runat="server" ID="btnAdd" OnClick="btnAdd_Click" Text="Add" />
                            <asp:ListBox runat="server" ID="lstbox1" Height="100" Width="100"></asp:ListBox>
                            <asp:ListBox runat="server" ID="lstbox2" Height="100" Width="100"></asp:ListBox>
                            <asp:Button runat="server" ID="btnRmv" OnClick="btnRmv_Click" Text="Rem" />
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnUpload" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
