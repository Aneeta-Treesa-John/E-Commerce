<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Phase_1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 219px;
        }
        .auto-style2 {
            height: 27px;
        }
        .login-table{
            width:100%;
            max-width: 600px;
            margin:0 auto;
        }
        .login-table td{
            padding-bottom:20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class=" login-table">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label9" runat="server" Text="Already Registered..!" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="#FF9933"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="Username" Font-Size="Medium" ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="210px" Height="21px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Field Mandatory"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label6" runat="server" Text="Password" Font-Size="Medium" ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Width="210px" Height="21px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Field Mandatory"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" BackColor="#FF9933" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </td>
    </tr>
    </table>
</asp:Content>
