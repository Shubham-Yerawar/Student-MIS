<%@ Page Title="" Language="C#" MasterPageFile="~/Mast.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="finalStudent.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>SignUp</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
     <div style="background-color:navajowhite; width:auto; height:auto; margin-right: 400px; margin-top: 150px; margin-left: 400px; border:solid;border-color:black" >
    <div style="background-color: darkgoldenrod; width:auto; height:auto"">
        <h2 style="text-align:center;color:brown">Enter Details For SignUp!</h2></div>
         <p align="center">Enter First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p>
         <p align="center">Enter Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </asp:TextBox>
             <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
         </p>
       <p align="center" style="height: auto; width: auto">Prefered Username&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></p>
        <p align="center">Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>  </p>
         
      <p align="center"> Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server">
           <asp:ListItem Value=""></asp:ListItem>
           <asp:ListItem Value="t">Teacher</asp:ListItem>
           <asp:ListItem Value="s">Student</asp:ListItem>
       </asp:DropDownList></p>
         
       
       <p align="center"><asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click"  />
         </p>
    </div>
</asp:Content>
