<%@ Page Title="" Language="C#" MasterPageFile="~/Mast3.Master" AutoEventWireup="true" CodeBehind="ProfileT.aspx.cs" Inherits="finalStudent.ProfileT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Profile teacher</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <div class="auto-style1" style="float:left; width:40%">
            <img alt="my photo" class="auto-style2" src="Shubham.jpg" style="width:80%;height=50%;"  />
        </div>
        <div style="float:left;">
            <div>
                <h2 class="auto-style3">Profile Will be displayed here.</h2>
            </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp; Department&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Not Set"></asp:Label>
            <hr />
            <hr />

        </div>

</asp:Content>
