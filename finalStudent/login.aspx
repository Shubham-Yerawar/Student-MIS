<%@ Page Title="" Language="C#" MasterPageFile="~/Mast.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="finalStudent.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Login Page</title>
    <style type="text/css">
        .auto-style2 {
            width: 496px;
            height: 219px;
            margin-left: 426px; 
        }
        .auto-style3 {
            height: 29px;
            width: 95px;
            margin-left: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="background-color:navajowhite; margin-right: 400px; margin-top: 150px; border:medium solid black;" class="auto-style2" >
    <div style="background-color: darkgoldenrod; width:auto; height:auto;">
        <h2 style="text-align:center; color:brown;">Enter Login Credentials</h2></div>
       <p align="center" style="height: auto; width: auto">
           Username&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      </p>
        <p align="center">
            Password&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
       </p>
      
           <p align="center"> <asp:Button ID="Button1" runat="server" Text="Login" CssClass="auto-style3" OnClick="Button1_Click"></asp:Button></p>
    </div>
       

</asp:Content>
