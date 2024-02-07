<%@ Page Title="" Language="C#" MasterPageFile="~/SchoolSite.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RainbowSchoolsUI.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 100%;
        }
        .auto-style14 {
            width: 473px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home</h2>
    <table cellpadding="5" cellspacing="5" class="auto-style13">
        <tr>
            <td class="auto-style14">
                <h4>Memory Album</h4>
                <marquee>&nbsp;&nbsp;&nbsp; 
                    <asp:Image runat="server" ImageUrl="~/images/img1.jpg" Width="200" Height="200" ID="Image1" />
                    <asp:Image runat="server" ImageUrl="~/images/img2.jpg" Width="200" Height="200" ID="Image2" />
                    <asp:Image runat="server" ImageUrl="~/images/img5.jpg" Width="200" Height="200" ID="Image5" />
                    <asp:Image runat="server" ImageUrl="~/images/img6.jpg" Width="200" Height="200" ID="Image6" />
                    <asp:Image runat="server" ImageUrl="~/images/img7.jpg" Width="200" Height="200" ID="Image7" />

                </marquee></td>
            <td>&nbsp;
                <p>The school is known for galvanizing the intellectual and creative abilities of each student, equipping them with the ability to excel in future academic endeavors. We pride ourselves in our ability to instill in each student self-reliance and awareness to enable them to work through life’s challenges.

It is the progressive widening of consciousness which helps the child to manifest that within him, leading to an increasing satisfaction and success in individual living as also collective living, socially, nationally and internationally.</p>
            </td>
        </tr>
    </table>
</asp:Content>
