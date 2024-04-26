<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="Phase_1.UserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 76px;
        }
        .center-align{
            margin:0 auto;
        }
        .text-align{
            text-align:center;
        }
        .max-900{
            max-width:900px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100 text-align max-900 center-align">
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" CellPadding="4" ForeColor="#333333" Width="712px">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="w-100">
                            <tr>
                                <td> <asp:Label ID="Label1" runat="server" Font-Underline="False" Text='<%# Eval("Cate_Description") %>' Font-Italic="True" Font-Size="Medium"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="270px" Width="210px" ImageAlign="Middle" ImageUrl='<%# Eval("Cate_Image") %>' CommandArgument='<%# Eval("Cate_Id") %>' OnCommand="ImageButton1_Command" />
                                </td>
                            </tr>
                            <tr>
                                <td> <asp:Label ID="Label3" runat="server" Text='<%# Eval("Cate_Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Send Feedback:" Font-Italic="True" Font-Underline="True" ForeColor="#CC0099"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="437px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
            &nbsp;
                <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
&nbsp;</td>
        </tr>
    </table>
</asp:Content>
