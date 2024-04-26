<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Phase_1.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
        .center-align{
            margin:0 auto;
        }
        .text-align{
            text-align:center;
        }
        .max-900{
            max-width:900px;
        }
        .auto-style1 {
         width: 950px;
     }
        .auto-style2 {
         width: 950px;
         height: 27px;
     }
     .auto-style4 {
         height: 229px;
     }
     .auto-style5 {
         width: 310px;
     }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="max-900 center-align text-align">
        <tr>
            <td class="auto-style4">
                <asp:Panel ID="Panel2" runat="server">
                    <table class="w-100">
                        <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Fb_Id" ForeColor="#333333" GridLines="None" Width="258%">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="User_Id" HeaderText="User Id" />
                                        <asp:BoundField DataField="Fb_Message" HeaderText="Feedback Message" />
                                        <asp:BoundField DataField="Fb_Replay" HeaderText="Replay" />
                                        <asp:BoundField DataField="Fb_Status" HeaderText="Status" />
                                        <asp:TemplateField HeaderText="Edit Replay here">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Fb_Id") %>' OnCommand="LinkButton1_Command">Edit</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                    <SortedDescendingHeaderStyle BackColor="#820000" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table class="w-100">
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label ID="Label4" runat="server" Text="Response to Feedback"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label5" runat="server" Text="Replay"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TextBox1" runat="server" Width="257px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label7" runat="server" Text="Email Id"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label ID="Label8" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="Button1" runat="server" Text="Send Mail" OnClick="Button1_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        </table>
</asp:Content>
