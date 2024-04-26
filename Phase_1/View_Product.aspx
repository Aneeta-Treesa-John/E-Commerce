<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="View_Product.aspx.cs" Inherits="Phase_1.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .align-center{
            margin:0 auto;
        }
        .max-800{
            max-width:800px;
        }
        .auto-style2 {
            height: 42px;
        }
    .auto-style3 {
        width: 220px;
    }
    .auto-style4 {
        height: 42px;
        width: 330px;
    }
        .auto-style6 {
            width: 300px;
        }
        .auto-style7 {
            width: 330px;
        }
        .auto-style8 {
            width: 330px;
            height: 40px;
        }
        .auto-style9 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100 max-800 align-center">
        <tr>
            <td class="auto-style6" rowspan="7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="300px" Width="270px" />
            </td>
            <td class="auto-style4">
                <asp:Label ID="Label6" runat="server" Font-Italic="True" Font-Size="Medium" Text="Item:"></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label7" runat="server" Font-Italic="True" Font-Size="Medium" Text="Item Description:"></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Italic="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Add to cart" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp; <asp:Button ID="Button2" runat="server" Text="Continue" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label8" runat="server" Font-Italic="True" Font-Size="Medium" Text="Item Price:"></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Font-Italic="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table class="w-100">
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="Label5" runat="server" Font-Italic="True" Font-Size="Medium" Text="Quantity:"></asp:Label>
                                    &nbsp;
                                    <asp:ImageButton ID="Addbtn" runat="server" Height="15px" ImageUrl="~/images/plus.jpeg" img="" OnClick="Addbtn_Click" Width="15px" />
                                    &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="31px"></asp:TextBox>
                                    &nbsp;
                                    <asp:ImageButton ID="Minusbtn" runat="server" Height="15px" ImageUrl="~/images/minus.png" OnClick="Minusbtn_Click" Width="15px" />
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* please enter the required quantity" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label11" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
