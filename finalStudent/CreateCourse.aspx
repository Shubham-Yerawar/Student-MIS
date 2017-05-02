<%@ Page Title="" Language="C#" MasterPageFile="~/Mast3.Master" AutoEventWireup="true" CodeBehind="CreateCourse.aspx.cs" Inherits="finalStudent.CreateCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Create New Course</title>
    <style type="text/css">
        .auto-style3 {
            margin-left: 40px;
            margin-right: 40px;
            margin-top: 30px;
            width: 223px;
            height: 120px;
        }
        .auto-style7 {
            height: 33px;
        }
        .auto-style8 {
            width: 265px;
            min-height: 500px;
            background-color: darkgray;
            height: 33px;
        }
    .auto-style9 {
        height: 16px;
    }
    .auto-style10 {
        width: 265px;
    }
    .auto-style11 {
        height: 16px;
        width: 265px;
    }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style=" margin-top:75px; margin-left:400px; margin-right:200px; width:600px; height:800px;">
    <table border="2" style="background-color:gainsboro" class="table-bordered table-responsive">
        <tr>
            <td>Course Name</td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox1" runat="server" Width="226px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Faculty Name</td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox2" runat="server" Width="227px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Branch</td>
            <td class="auto-style8"> &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="226px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>IT</asp:ListItem>
                <asp:ListItem>Mech</asp:ListItem>
                <asp:ListItem>Eln</asp:ListItem>
                <asp:ListItem>Ele</asp:ListItem>
                <asp:ListItem>Civil</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Credits Offered</td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="reset" />
            </td>
            <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="create" Width="60px" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
