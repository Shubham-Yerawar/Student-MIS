<%@ Page Title="" Language="C#" MasterPageFile="~/Mast2.Master" AutoEventWireup="true" CodeBehind="ViewCourses.aspx.cs" Inherits="finalStudent.ViewCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>View Courses</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="CNAME" HeaderText="CNAME" SortExpression="CNAME" />
            <asp:BoundField DataField="CDEPT" HeaderText="CDEPT" SortExpression="CDEPT" />
            <asp:BoundField DataField="CFACULTY" HeaderText="CFACULTY" SortExpression="CFACULTY" />
            <asp:BoundField DataField="CCREDITS" HeaderText="CCREDITS" SortExpression="CCREDITS" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;CNAME&quot;, &quot;CDEPT&quot;, &quot;CFACULTY&quot;, &quot;CCREDITS&quot; FROM &quot;COURSE&quot; ORDER BY &quot;CID&quot;"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
    <p>
    </p>
</asp:Content>
