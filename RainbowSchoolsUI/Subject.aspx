<%@ Page Title="" Language="C#" MasterPageFile="~/SchoolSite.Master" AutoEventWireup="true" CodeBehind="Subject.aspx.cs" Inherits="RainbowSchoolsUI.Subject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 100%;
        }
        .auto-style14 {
            margin-left: 547px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Subject</h2>
    <table class="auto-style13">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style14" DataKeyNames="SubjectId" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                        <asp:BoundField DataField="SubjectId" HeaderText="SubjectId" ReadOnly="True" SortExpression="SubjectId" />
                        <asp:BoundField DataField="SubjectName" HeaderText="SubjectName" SortExpression="SubjectName" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:RainbowSchoolDbsConnectionString %>" DeleteCommand="DELETE FROM [Subjects] WHERE [SubjectId] = @original_SubjectId AND (([SubjectName] = @original_SubjectName) OR ([SubjectName] IS NULL AND @original_SubjectName IS NULL))" InsertCommand="INSERT INTO [Subjects] ([SubjectId], [SubjectName]) VALUES (@SubjectId, @SubjectName)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Subjects]" UpdateCommand="UPDATE [Subjects] SET [SubjectName] = @SubjectName WHERE [SubjectId] = @original_SubjectId AND (([SubjectName] = @original_SubjectName) OR ([SubjectName] IS NULL AND @original_SubjectName IS NULL))">
                    <DeleteParameters>
                        <asp:Parameter Name="original_SubjectId" Type="Int32" />
                        <asp:Parameter Name="original_SubjectName" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="SubjectId" Type="Int32" />
                        <asp:Parameter Name="SubjectName" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="SubjectName" Type="String" />
                        <asp:Parameter Name="original_SubjectId" Type="Int32" />
                        <asp:Parameter Name="original_SubjectName" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
