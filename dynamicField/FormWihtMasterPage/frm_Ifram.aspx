<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="frm_Ifram.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.frm_Ifram" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" ></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js"></script>--%>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" crossorigin="anonymous" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" crossorigin="anonymous"></script>
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>

    <script>


        function callModal() {
            var modl = document.getElementById("modl");
            modl.show();
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="panel">
            <div class="panel-heading">
                <h3>I Frame</h3>
            </div>
            <div class="panel-body">
                <asp:FileUpload runat="server" ID="fuplPDF" />
                <iframe runat="server" id="ifrm" src="~/PDF/RptMasterList1.pdf" height="500" width="500"></iframe>
                <iframe runat="server" id="ifrm1" height="500" width="500"></iframe>
            </div>
            <div class="panel-footer">
                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                    Launch Demo Modal
                </button>
                <asp:Button runat="server" ID="btnGetPDF" OnClick="btnGetPDF_Click" Text="asp btn" />
            </div>
        </div>
    </div>
    <div class="modal fade" style="height: 1000px; width: 1000px" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document" style="margin: 0px; width: 500px;">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    ...
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                    <asp:Button runat="server" ID="btnpopup" OnClick="btnpopup_Click" />
                </div>
            </div>
        </div>
    </div>


    <%--<div class="modal fade" id="MymodalPreventHTML" tabindex="-1" role="dialog" aria-labelledby="MymodalPreventHTML" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                    <h4 class="modal-title" id="myModalLabel">Change Password</h4>
                                </div>
                                <div class="modal-body">
                                    <p>Are you sure you want to change password?</p>
                                    <br />
                                    Old Password :
                      <input type="password" id="txtoldpwd" class="form-control" runat="server" required="required" />
                                    New Password :
                      <input type="password" id="txtnewpwd" class="form-control" runat="server" required="required" />
                                    Confirm Password :
                      <input type="password" id="txtconfirmpwd" class="form-control" runat="server" required="required" />
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password shuld not be match" ControlToValidate="txtconfirmpwd" ControlToCompare="txtnewpwd"></asp:CompareValidator>
                                    <%--<asp:Label ID="lblmsg" runat="server" Visible="false"></asp:Label>--%>
    <%--<br />
                                </div>
                                <div class="modal-footer">
                                   
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                </div>
                            </div>
                        </div>
                    </div>--%>
</asp:Content>
