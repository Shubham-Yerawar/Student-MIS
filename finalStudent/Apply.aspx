<%@ Page Title="" Language="C#" MasterPageFile="~/Mast2.Master" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="finalStudent.Apply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Apply</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
        <div class="auto-style1" style="float:left;">
            <img alt="" class="auto-style2" src="" />
        </div>
        <div style="float:left;">
            <div>
                <h2 class="auto-style3">Available Course that can be applied will be showed here.</h2>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="view courses" />
            <br />
            ENTER COURSE ID :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Apply" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <hr />
            <hr />

          
        </div>
    </div>
</asp:Content>
