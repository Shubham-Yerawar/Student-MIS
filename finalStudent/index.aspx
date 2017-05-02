<%@ Page Title="" Language="C#" MasterPageFile="~/Mast.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="finalStudent.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Index page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
       
        <image src="StudentPortal.jpg" alt="student portal" height="500" width="1200"></image>
    </div>
    <div style="background-color:blanchedalmond;font-family:Verdana;font-size:22px">
       <p> This Website is for the enrollment of the Student to specific course which are available to student in the form and it displays the information of the student
        and the various courses among with their course guides and total credits.</p>
    </div>
</asp:Content>
