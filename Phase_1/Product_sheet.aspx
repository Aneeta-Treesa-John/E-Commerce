<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Product_sheet.aspx.cs" Inherits="Phase_1.Product_sheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .align-center{
            margin:0 auto;
        }
        .max-800{
            max-width:800px;
        }
        .text-align-center{
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100 align-center max-800">
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server" HorizontalAlign="Center" RepeatColumns="1" CellPadding="4" ForeColor="#333333">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="w-100">
                            <tr class="text-align-center">
                                <td colspan="2">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Pro_Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr class="text-align-center">
                                <td colspan="2"><asp:Label ID="Label3" runat="server" Text="Rs."></asp:Label>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Pro_Price") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr class="text-align-center">
                                <td colspan="2">
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="236px" ImageUrl='<%# Eval("Pro_Image") %>' Width="194px" CommandArgument='<%# Eval("Pro_Id") %>' OnCommand="ImageButton1_Command" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Pro_Description") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>
