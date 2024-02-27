<%@ Page Title="" Language="C#" MasterPageFile="~/SchoolSite.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="RainbowSchoolsUI.Class" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 100%;
        }
        .auto-style15 {
            width: 496px;
        }
        .auto-style17 {
            margin-left: 62px;
            margin-right: 122px;
        }
        .auto-style18 {
            width: 504px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Class</h2>
    <table class="auto-style13">
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style15">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="ClassId" DataSourceID="SqlDataSource1" CssClass="auto-style17" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="ClassId" HeaderText="ClassId" ReadOnly="True" SortExpression="ClassId" />
            <asp:BoundField DataField="ClassName" HeaderText="ClassName" SortExpression="ClassName" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:RainbowSchoolDbsConnectionString %>" DeleteCommand="DELETE FROM [Classes] WHERE [ClassId] = @original_ClassId AND (([ClassName] = @original_ClassName) OR ([ClassName] IS NULL AND @original_ClassName IS NULL))" InsertCommand="INSERT INTO [Classes] ([ClassId], [ClassName]) VALUES (@ClassId, @ClassName)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:RainbowSchoolDbsConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Classes]" UpdateCommand="UPDATE [Classes] SET [ClassName] = @ClassName WHERE [ClassId] = @original_ClassId AND (([ClassName] = @original_ClassName) OR ([ClassName] IS NULL AND @original_ClassName IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_ClassId" Type="Int32" />
            <asp:Parameter Name="original_ClassName" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ClassId" Type="Int32" />
            <asp:Parameter Name="ClassName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ClassName" Type="String" />
            <asp:Parameter Name="original_ClassId" Type="Int32" />
            <asp:Parameter Name="original_ClassName" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>
