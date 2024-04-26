<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="Phase_1.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 177px;
        }
        .max-800{
            max-width:800px;
        }
        .center-align{
            margin:0 auto;
        }
        .auto-style2 {
            width: 177px;
            height: 27px;
        }
        .auto-style3 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100 max-800 center-align">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FF9999" Text="Admin Home" Font-Italic="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3">
                </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="False" PostBackUrl="~/Add_Category.aspx" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#6666FF">Add Category</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="False" PostBackUrl="~/Edit_Category.aspx" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#6666FF">Edit Category</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton2" runat="server" Font-Underline="False" PostBackUrl="~/Add_Product.aspx" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#6666FF">Add Product</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Underline="False" PostBackUrl="~/Edit_Product.aspx" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#6666FF">Edit Product</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton6" runat="server" Font-Underline="False" PostBackUrl="ViewUser.aspx" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#6666FF">View All Users</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton5" runat="server" Font-Underline="False" PostBackUrl="Feedback.aspx" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#6666FF">Replay Feedback</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
