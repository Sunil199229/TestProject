<%@ Page Title="" Language="C#" MasterPageFile="~/FormWihtMasterPage/Demo.Master" AutoEventWireup="true" CodeBehind="GridViewUpdatePanelTrigger.aspx.cs" Inherits="dynamicField.FormWihtMasterPage.GridViewUpdatePanelTrigger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>
<style>
        input#ContentPlaceHolder1_btnAddRevenue {
            padding: 0px 8px;
            font-size: 17px;
            width: 30px !important;
            font-weight: 800;
            height: 22px;
        }

        .form-control {
            display: block;
            width: 100%;
            height: 24px;
            padding: 1px 2px;
            margin: 0 0;
        }

        .form-left {
            float: left;
            width: 100%;
            position: relative;
            border-bottom: solid 2px #722e36;
            padding-bottom: 3px;
        }

            .form-left h5 {
                font-size: 15px;
                margin: 5px 0 0 0;
                color: #79353f;
            }

        label {
            margin: 1px 0px;
            line-height: 18px;
        }

        table#ContentPlaceHolder1_grdSubHEAD tbody tr td:nth-child(3), table#ContentPlaceHolder1_grdSubHEAD tbody tr td:nth-child(5), table#ContentPlaceHolder1_grdSubHEAD tbody tr td:nth-child(6), table#ContentPlaceHolder1_grdSubHEAD tbody tr td:nth-child(7) {
            text-align: right;
        }

        .my-button {
            display: inline-block;
            padding: 6px 8px;
            margin-bottom: 0;
            width: 75px;
            font-size: 14px;
            height: 30px;
            color: #fff;
            font-weight: 400;
            border-radius: 4px;
            line-height: 10px;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            -ms-touch-action: manipulation;
            touch-action: manipulation;
            cursor: pointer;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            background: #722e36;
            ;
            border: solid 1px #722e36;
            ;
            font-weight: 400;
            -webkit-transition: all 0.45s ease-in-out;
            -moz-transition: all 0.45s ease-in-out;
            -o-transition: all 0.45s ease-in-out;
            -ms-transition: all 0.45s ease-in-out;
            transition: all 0.45s ease-in-out;
        }

        .btn {
            display: inline-block;
            padding: 6px 8px;
            margin-bottom: 0;
            font-size: 14px;
            width: 75px;
            font-weight: 400;
            line-height: 10px;
            height: 30px;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            -ms-touch-action: manipulation;
            touch-action: manipulation;
            cursor: pointer;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            background-image: none;
            border: 1px solid transparent;
            border-radius: 4px;
        }

        .my-button:hover {
            background: #ffad20;
            border: solid 1px #ffad20;
            color: #ffffff;
        }

        .gst-ac-error {
            background: #f05050;
            color: #fff !important;
            text-align: center !important;
            width: auto;
            padding: 0 10px !important;
            border-radius: 4px;
            border: 1px solid #fff;
            position: absolute;
            Z-INDEX: 2;
            top: 0;
            right: 0;
            box-shadow: 0px 0px 5px 2px rgba(0,0,0,0.5);
        }

            .gst-ac-error::after {
                content: '';
                display: block;
                position: absolute;
                top: 100%;
                left: 50%;
                width: 0;
                Z-INDEX: 2;
                transform: translateX(-50%);
                height: 0;
                border-top: 10px solid #f05050;
                border-right: 10px solid transparent;
                border-bottom: 10px solid transparent;
                border-left: 10px solid transparent;
            }

        span.fa.fa-inr {
            font-size: 15px;
            padding: 7px 3px 3px;
            position: absolute;
            margin: 0px -15px;
            color: #722e36;
            border: 1px solid #722e36;
            background-color: #eee;
            border-radius: 4px;
            border-right: none;
            border-top-right-radius: 0;
            border-bottom-right-radius: 0;
        }

        span#ContentPlaceHolder1_lblTaxRate {
            color: red;
            font-size: 12px;
            font-weight: 600;
            display: block;
            margin: -2px 0 -6px;
        }

        input, select {
            text-transform: capitalize;
        }

        ::-webkit-input-placeholder { /* WebKit browsers */
            text-transform: capitalize;
        }

        placeholder { /* Recent browsers */
            text-transform: capitalize;
        }

        :-moz-placeholder { /* Mozilla Firefox 4 to 18 */
            text-transform: capitalize;
        }

        ::-moz-placeholder { /* Mozilla Firefox 19+ */
            text-transform: capitalize;
        }

        :-ms-input-placeholder { /* Internet Explorer 10+ */
            text-transform: capitalize;
        }


        .form-inner {
            padding-top: 3px;
        }

            .form-inner h4 {
                padding-bottom: 4px;
            }

        .counter-form {
            margin: 82px 0 0px 0;
            float: left;
            position: inherit;
            width: 100%;
        }




        .gst-ac-error {
            padding: 0 10px;
            right: 11px;
        }

        .required_two {
            position: absolute;
            top: 4px;
            right: 16px;
            color: red;
            font-size: 12px;
            font-weight: 600;
            float: right;
        }

        .panel {
            margin-bottom: 0 !important;
        }

        .counter-form .form-control {
            display: block;
            width: 100%;
            height: 27px;
            padding: 4px 5px;
            font-size: 12px;
            line-height: 1.428571;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }

        .counter-form .form-group {
            margin-bottom: 6px;
        }

        .counter-form input[type=checkbox], .counter-form input[type=radio] {
            margin: 7px 0 0;
            margin-top: 1px\9;
            line-height: normal;
            width: 16%;
            float: left;
            zoom: 0.7;
            height: 25px;
        }

        .counter-form label {
            font-size: 12px;
            margin: 6px 0;
        }

        input, select, textarea {
            font-family: inherit;
            font-size: inherit;
            line-height: inherit;
            padding: 0 10px;
            width: 100%;
        }

        label.fxd {
            margin: 8px 0 0px 0px;
            font-size: 12px;
        }

        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }

        .marT10 {
            margin-top: 10px;
        }

        .check-detail h3 {
            font-size: 14px;
            font-weight: 600;
            margin: 0 0 10px 0;
            text-decoration: underline;
        }

        .check-detail {
            float: left;
            position: relative;
            width: 100%;
        }

        .counter-form .btn-primary {
            background: #5cb85c;
            border-color: #5cb85c;
        }

        .cheque {
            display: none;
        }

        .badge {
            display: inline-block;
            min-width: 10px;
            padding: 3px 7px;
            font-size: 12px;
            font-weight: 700;
            line-height: 1;
            color: #fff;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            background-color: #000;
            border-radius: 10px;
            position: absolute;
            left: 14px;
            bottom: -25px;
        }

        .rmv.fa {
            color: red;
            font-size: 16px;
            text-align: center;
        }

        #ui-datepicker-div {
            z-index: 10 !important;
        }

        .mydatagrid a /** FOR THE PAGING ICONS  **/ {
            background-color: Transparent;
            padding: 5px 5px 5px 5px;
            color: #fff;
            text-decoration: none;
            font-weight: bold;
        }

            .mydatagrid a:hover /** FOR THE PAGING ICONS  HOVER STYLES**/ {
                background-color: #000;
                color: #fff;
            }

        .mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/ {
            background-color: #c9c9c9;
            color: #000;
            padding: 5px 5px 5px 5px;
        }

        .mydatagrid td {
            padding: 5px;
            width: 26%;
            text-align: center;
            font-size: 12px;
            font-weight: 700;
        }

        .mydatagrid tbody {
            height: 170px;
            float: left;
            position: relative;
            width: 100%;
            overflow: hidden;
            overflow-y: scroll;
        }

        .mydatagrid th {
            padding: 5px;
        }

        .mydatagrid tbody tr.header {
            display: none;
        }

        table.table-grid tr.header th {
            padding: 5px 10px;
            width: 40%;
            border-top: solid 2px #000;
            text-align: center;
        }

        table tr td {
            font-size: 11px;
        }

            table tr td span {
                font-size: 12px;
            }

        table.table-grid .header {
            border-right: solid 2px #000;
            border-left: solid 2px #000;
        }

        th {
            font-size: 13px;
        }

        table.table-grid {
            width: 100%;
        }

        .wd-20 {
            width: 20% !important;
        }

        .rows {
            background-color: #fff;
            font-family: Arial;
            font-size: 14px;
            color: #000;
            min-height: 25px;
            text-align: left;
        }

        tr.rows td:first-child {
            width: 10%;
        }

        tr.rows td:last-child {
            width: 13%;
        }

        table.table-grid tr.header th:last-child {
            width: 26%;
        }

        a#ContentPlaceHolder1_btnlinksearch {
            padding: 5px 10px;
            font-size: 14px;
            background: green;
            color: #fff;
            border-radius: 3px;
            margin: 2px 0px;
        }

        .service-block {
            margin: 15px 0;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 0px 8px;
            font-size: 12px;
            font-weight: 700;
            line-height: 18px;
        }

        .table > tbody > tr > td, .table > tbody > tr > th, .table > tfoot > tr > td, .table > tfoot > tr > th, .table > thead > tr > td, .table > thead > tr > th {
            padding: 4px 4px;
            line-height: 18px;
            vertical-align: top;
            border-top: 1px solid #ddd;
            font-size: 12px;
        }

        .panel-body {
            padding: 10px 15px 0;
        }

        .popover {
            width: 260px !important;
            top: -66px !important;
            left: -65.054688px !important;
        }

            .popover .popover-title {
                padding: 0px 14px !important;
                color: #ff0000 !important;
            }

        .double.table-bordered table tbody tr td {
            border-color: transparent;
        }

        #dvContents .double {
            border-width: 0;
        }

        .popup-area {
            height: 100%;
            width: 100%;
            background: #000000b0;
            position: fixed;
            top: 0px;
            left: 0px;
            right: 0px;
            bottom: 0px;
            z-index: 10000;
        }

        .container-full {
            margin-left: -30px;
            position: fixed;
            z-index: 999;
            height: 100%;
            width: 100%;
            top: 0;
        }

        a.chosen-single {
            background: #fff !important;
            height: 34px !important;
            padding-top: 4px !important;
            font-size: 14px;
        }

        #mask {
            left: 0px;
            top: 0px;
            z-index: 4;
            opacity: 0.4;
            -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=40)"; /* first!*/
            filter: alpha(opacity=40); /* second!*/
            background-color: gray;
            display: none;
            width: 100%;
            height: 100%;
        }

        .header-table tr td {
            border: none;
        }

        .btnClose11 {
            width: 30px;
            height: 28px;
            background: #337ab7;
            border: none;
            color: #ffffff;
            border-radius: 7px;
        }

        span#ContentPlaceHolder1_regExVal {
            color: red;
            font-weight: 600;
            font-size: 12px;
            margin-left: -69px;
        }

        span#ContentPlaceHolder1_ctl01 {
            margin-left: 18px;
            float: left;
        }

        span#ContentPlaceHolder1_RegularExpressionValidator3 {
            position: relative;
            top: 0 !important;
            right: 0 !important;
            float: left;
            width: 142px;
            margin-bottom: -10px;
        }

        .panel-heading {
            padding: 3px 15px;
            border-bottom: 1px solid #722e36;
            ;
            border-top-left-radius: 3px;
            border-top-right-radius: 3px;
        }

            .panel-heading h3 {
                color: #fff;
            }

            .panel-heading h3 {
                color: #fff;
                font-size: 16px;
                text-align: center;
                font-weight: 600;
            }
    </style>
    <script>
        function LoadAllScript() {
            //LoadBasic();
            $('.form-control').attr('autocomplete', 'off');
        }
    </script>
    <script type="text/javascript">
        function FileUploadCall(fileUpload) {
            if (fileUpload.value != '') {

                $('[id*="btnview"]').css('display', 'inline');
            }

        }
    </script>
<%--    <script>

        $(function () {
            $("#dialog").dialog({
                autoOpen: false,
                modal: true,
                height: 300,
                width: 300,
                title: "Zoomed Image"
            });
            $("[id*=btnview").click(function () {
                $('#dialog').html('');
                //   $('#dialog').append($(this).clone());
                $('#dialog').dialog('open');
            });
        });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="col-md-12 col-md-offset-0 padT20 padB20">
                    <script type="text/javascript">
                        Sys.Application.add_load(LoadAllScript)
                    </script>
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3>Create</h3>
                        </div>
                        <div class="panel-body">
                            <div class="col-md-12 pad0">
                                <div class="form-panel">
                                    <%-- <h4>Challan Details</h4>--%>
                                    <div class="form-group">
                                        <div class="col-md-4">
                                            <div class="row">
                                                <div class="col-md-4" id="applicDate">
                                                    <label>Date<b class="Red">*</b></label>
                                                </div>
                                                <%--name="ctl00$ContentPlaceHolder1$ctl00" autocomplete="off" placeholder="dd/mm/yyyy" --%>
                                                <div class="col-md-6 padR0" id="challanDate">
                                                    <asp:TextBox runat="server" ID="txtChallandate" CssClass="form-control datepicker" Enabled="false"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="row">
                                                        <div class="col-md-4">
                                                            <label>Zone No<b class="Red">*</b></label>
                                                        </div>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList runat="server" ID="ddlZone" Style="width: 95%;" CssClass="form-control text-uppercase" ValidationGroup="a" autofocus="true" AutoPostBack="true"></asp:DropDownList>
                                                            <%--<asp:RequiredFieldValidator ID="rvfZone" Enabled="false" ErrorMessage="Required..!!" SetFocusOnError="true" runat="server" ControlToValidate="ddlZone" InitialValue="0" CssClass="required" Display="Dynamic" ValidationGroup="a"></asp:RequiredFieldValidator>--%>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" CssClass="gst-ac-error" ValidationGroup="a" ControlToValidate="ddlZone" SetFocusOnError="true" Style="top: -25px;" InitialValue="0" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="row">
                                                        <div class="col-md-4">
                                                            <label>Ward No :<b class="Red">*</b></label>
                                                        </div>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList runat="server" ID="ddlward" Style="width: 95%;" CssClass="form-control text-uppercase" ValidationGroup="a" autofocus="true"></asp:DropDownList>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="gst-ac-error" ValidationGroup="a" ControlToValidate="ddlward" SetFocusOnError="true" Style="top: -25px;" InitialValue="0" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr />
                            <div class="form-group">
                                <div class="form-inner">
                                    <div class="col-md-6">
                                        <div class="form-left">
                                            <div class="col-md-12 padL0">
                                                <h5>Applicant Information</h5>
                                            </div>
                                        </div>
                                        <div class="row" style="margin-top: -6px;">
                                            <div class="col-md-12">
                                                <label>Name<b class="Red">*</b></label>
                                                <asp:TextBox runat="server" CssClass="form-control text-uppercase" ID="txtapplicantName" Placeholder="Name" MaxLength="44"></asp:TextBox>
                                                <asp:RequiredFieldValidator SetFocusOnError="true" ID="RquiredFieldValidator2" Display="Dynamic" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="txtapplicantName" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                <%--<cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" Enabled="True" TargetControlID="txtapplicantName" FilterType="LowercaseLetters,UppercaseLetters,Custom" ValidChars="./ -"></cc1:FilteredTextBoxExtender>--%>
                                            </div>
                                            <div class="col-md-6">
                                                <label>
                                                    Father Name
                                                </label>
                                                <asp:TextBox runat="server" CssClass="form-control text-uppercase" ID="txtfathername" Placeholder="Father Name" MaxLength="44"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="gst-ac-error" ValidationGroup="a" ControlToValidate="txtfathername" SetFocusOnError="true" Style="top: -25px;" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                <%--<cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender9" runat="server" Enabled="True" TargetControlID="txtfathername" FilterType="LowercaseLetters,UppercaseLetters,Custom" ValidChars="./ -"></cc1:FilteredTextBoxExtender>--%>
                                            </div>
                                            <div class="col-md-6">
                                                <label>Mobile No.<b class="Red">*</b></label>
                                                <%--autocomplete="off"--%>
                                                <asp:TextBox runat="server" CssClass="form-control" ID="txtphoneno" Placeholder="Mobile No." MaxLength="10"></asp:TextBox>
                                                <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" CssClass="gst-ac-error" ID="RequiredFieldValidator5" runat="server" ValidationGroup="a" ControlToValidate="txtphoneno" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                <%--<cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" Enabled="True" TargetControlID="txtphoneno" FilterType="Numbers"></cc1:FilteredTextBoxExtender>--%>
                                                <asp:RegularExpressionValidator ValidationGroup="a" ID="RegularExpressionValidator3" runat="server"
                                                    ControlToValidate="txtphoneno" ErrorMessage="Enter Valid Mobile No." Display="Dynamic" CssClass="gst-ac-error" Style="top: 0 !important; right: -16px !important; display: inline; font-size: 14px; width: max-content !important; position: absolute;"
                                                    ValidationExpression="^([56789]{1})([0-9]{1})([0-9]{8})$"></asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <label>Address</label>
                                                <asp:TextBox runat="server" CssClass="form-control text-uppercase" ID="txtaddress" Placeholder="Address" MaxLength="65"></asp:TextBox>
                                                <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator3" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="txtaddress" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowFooter="false" ShowHeader="false" OnRowCommand="GridView1_RowCommand">
                                                    <Columns>
                                                        <%--  <asp:BoundField DataField="DocumentName" ControlStyle-ForeColor="#722e36" />--%>
                                                        <%-- <asp:BoundField DataField="DocumentId" Visible="false" ControlStyle-ForeColor="#722e36" />--%>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbldocName" CssClass="header" runat="server" Text='<%#Eval("DocumentName")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField Visible="false">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbldocId" CssClass="header" runat="server" Text='<%#Eval("DocumentId")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField Visible="false">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblcomp" CssClass="header" runat="server" Text='<%#Eval("Compulsory")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField ItemStyle-Width="50%">
                                                            <ItemTemplate>
                                                                <asp:FileUpload accept=".pdf,.png,.jpeg,.jpg" ID="FileUpload1" runat="server" CssClass="form-control" onchange="FileUploadCall(this)" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField ItemStyle-Width="10.5%">
                                                            <ItemTemplate>
                                                                <%-- <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                    <ContentTemplate>--%>
                                                                <asp:Button ID="btnview" Text="View" Style="padding: 2px 8px; width: 48px; display: none;"
                                                                    CommandName="ViewRow"
                                                                    CssClass="btn btn-xs btn-warning add_btn" runat="server" CommandArgument="<%#Container.DataItemIndex %>"></asp:Button>
                                                                <%--</ContentTemplate>
                                                                 <Triggers>
                                                                        <asp:AsyncPostBackTrigger ControlID="btnview" />
                                                                    </Triggers>
                                                                </asp:UpdatePanel>--%>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-left">
                                            <div class="col-md-12 padL0">
                                                <h5>Pet Information :</h5>
                                            </div>
                                        </div>
                                        <div class="row" style="margin-top: -6px;">
                                            <div class="col-md-12">
                                                <label>Pet Type<b class="Red">*</b></label>
                                                <asp:DropDownList runat="server" ID="ddlPetType" CssClass="form-control" ValidationGroup="a" autofocus="true"></asp:DropDownList>
                                                <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator12" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="ddlPetType" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="col-md-6">
                                                <label>
                                                    Pet Name
                                                </label>
                                                <asp:TextBox runat="server" CssClass="form-control text-uppercase" ID="txtPetName" Placeholder="Pet Name" MaxLength="44"></asp:TextBox>
                                                <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator13" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="txtPetName" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                <%--<cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" Enabled="True" TargetControlID="txtPetName" FilterType="LowercaseLetters,UppercaseLetters,Custom" ValidChars="./ -"></cc1:FilteredTextBoxExtender>--%>
                                            </div>
                                            <div class="col-md-6">
                                                <label>DOB<b class="Red">*</b></label>
                                                <%--autocomplete="off"--%>
                                                <asp:TextBox ID="TxtDOBdate" name="ctl00$ContentPlaceHolder1$ctl00" CssClass="form-control datepicker" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator14" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="TxtDOBdate" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 padR0">
                                                <label>Breed</label>
                                                <asp:TextBox runat="server" CssClass="form-control text-uppercase" ID="TxtBreed" Placeholder="Breed." MaxLength="15"></asp:TextBox>
                                                <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator10" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="TxtBreed" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="col-md-3 ">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label>Color</label>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <asp:TextBox runat="server" ID="TxtColor" MaxLength="10" CssClass="form-control text-uppercase" placeholder="Color"></asp:TextBox>
                                                        <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator7" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="Txtmark" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-3 padL0 padR10">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label>Mark</label>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <asp:TextBox runat="server" ID="Txtmark" MaxLength="25" CssClass="form-control text-uppercase" placeholder="Mark"></asp:TextBox>
                                                        <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator6" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="Txtmark" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-3 padL0 ">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label>Gender</label>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <asp:DropDownList runat="server" ID="ddlgender" CssClass="form-control">
                                                            <asp:ListItem Value="0">--Select Gender--</asp:ListItem>
                                                            <asp:ListItem Value="1">Male</asp:ListItem>
                                                            <asp:ListItem Value="2"> Female</asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator15" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="ddlgender" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 ">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label>Vaccination Details<b class="Red">*</b></label>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <asp:TextBox runat="server" ID="TxtVacdetails" MaxLength="25" CssClass="form-control text-uppercase" placeholder="Vaccination Details"></asp:TextBox>
                                                        <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator11" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="TxtVacdetails" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-6 ">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label>Sterilization Details</label>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <asp:TextBox runat="server" ID="TxtSterilizDet" CssClass="form-control" placeholder="Sterilization Details"></asp:TextBox>
                                                        <asp:RequiredFieldValidator Display="Dynamic" SetFocusOnError="true" ID="RequiredFieldValidator4" CssClass="gst-ac-error" runat="server" ValidationGroup="a" ControlToValidate="TxtSterilizDet" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-2 pull-right text-right">
                                <br />
                                <asp:Button Text=" Save" ID="btnSave" runat="server" CssClass=" my-button" Style="width: auto;" ValidationGroup="a" />
                                <asp:Button Text=" Clear" ID="btnClear" runat="server" CssClass=" btn btn-warning" Style="width: auto;" OnClick="btnClear_Click" />
                            </div>
                            <div class="form-group">
                                <div class="col-md-12 text-left pull-left">
                                    <div class="row">
                                        <div id="dialog" style="display: none">
                                            <asp:Image ID="Image1" runat="server" Visible="true"></asp:Image>
                                        </div>
                                        <div class="col-md-10">
                                            <asp:Label runat="server" Style="bottom: 0; left: 0; padding: 0px 4px; margin: 0; float: right; font-size: 13px; border: 1px solid transparent; border-radius: 4px; display: inline-block;" ID="lblMsg"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <%--<asp:PostBackTrigger ControlID="GridView1"/>--%>
                <%-- <%= GridView1.btnview.ClientID %>--%>
               <%--<asp:PostBackTrigger ControlID="btnSave" />--%>
             </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>
