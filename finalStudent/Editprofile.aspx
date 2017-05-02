<%@ Page Title="" Language="C#" MasterPageFile="~/Mast2.Master" AutoEventWireup="true" CodeBehind="Editprofile.aspx.cs" Inherits="finalStudent.Editprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Edit Profile</title>
    <style type="text/css">
        #Text1 {
            width: 238px;
        }
        #Text2 {
            width: 240px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-left:150px;">
    
    
         <br />
         <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="Label10" runat="server" Text="FirstName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="Label9" runat="server" Text="LastName"></asp:Label>
         <br />
    
    
     <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
&nbsp;&nbsp;
     <asp:TextBox ID="TextBox2" runat="server" Width="224px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label2" runat="server" Text="Date of Birth"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox3" runat="server" Width="114px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="Label8" runat="server" Text="(dd-mm-yyyy)"></asp:Label>
     <br />
     <br />
     <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
     <asp:TextBox ID="TextBox4" runat="server" Height="41px" TextMode="MultiLine" Width="365px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label4" runat="server" Text="E-mail"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox5" runat="server" TextMode="Email" Width="366px"></asp:TextBox>
     <br />
&nbsp;<br />
     <asp:Label ID="Label5" runat="server" Text="Year"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
     <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="382px">
         <asp:ListItem>FY</asp:ListItem>
         <asp:ListItem>SY</asp:ListItem>
         <asp:ListItem>TY</asp:ListItem>
         <asp:ListItem>B.Tech</asp:ListItem>
     </asp:DropDownList>
     <br />
     <br />
     <asp:Label ID="Label6" runat="server" Text="Department"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="382px">
         <asp:ListItem>CSE</asp:ListItem>
         <asp:ListItem>IT</asp:ListItem>
         <asp:ListItem>Mech</asp:ListItem>
         <asp:ListItem>Ele</asp:ListItem>
         <asp:ListItem>Civil</asp:ListItem>
         <asp:ListItem>Eln</asp:ListItem>
     </asp:DropDownList>
     <br />
     <br />
     <asp:Label ID="Label7" runat="server" Text="College"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox6" runat="server" Width="382px"></asp:TextBox>
     <br />
&nbsp;<br />
         &nbsp;
         <br />
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
         <br />

         </div>
</asp:Content>
