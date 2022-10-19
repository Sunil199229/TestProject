<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommonPage.ascx.cs" Inherits="dynamicField.FormWihtMasterPage.CommonPage" %>
<style>
    .w {
        width: 20%;
    }
</style>
<div class="w">
    <header>CommonPage</header>
    <ul>
        <li>
            <a data-toggle="collapse" data-target="#id1" class="collapsed"></a>
            <ul id="id1" class="sidenav collapse first-level">
                <li>
                    <a href="FirstPage.aspx"><span>First</span></a>
                </li>
            </ul>
        </li>
    </ul>
</div>
