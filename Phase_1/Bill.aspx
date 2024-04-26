<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="Phase_1.Bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 44px;
        }
        .auto-style3 {
            height: 95px;
        }
        .auto-style5 {
            width: 622px;
        }
        .auto-style7 {
            margin-left: 26px;
        }
        .auto-style8 {
            width: 305px;
        }
        table tr{
            border:1px solid #000000;
        }
        table td{
            border:1px solid #000000;
        } 
        .auto-style9 {
            width: 155px;
        }
        .auto-style10 {
            width: 173px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td colspan="4">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Font-Underline="True" Text="INVOICE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="3">
                <asp:Label ID="Label2" runat="server" Height="20px" Text="JOAN Enterprises India PVT LTD." Width="220px"></asp:Label>
                <br />
                <asp:Label ID="Label15" runat="server" Text="Building Number : 18,"></asp:Label>
                <br />
                <asp:Label ID="Label16" runat="server" Text="Street Name :&nbsp;Amin Street,"></asp:Label>
                <br />
                <asp:Label ID="Label17" runat="server" Text="Street :&nbsp;Urmila Apartments, Ehsaan Nagar"></asp:Label>
                <br />
                <asp:Label ID="Label18" runat="server" Text="Madhya Pradesh, Post Code-258240."></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Image ID="Image1" runat="server" Height="130px" ImageAlign="Middle" ImageUrl="~/images/logo.png" Width="130px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3">
                <asp:Label ID="Label3" runat="server" Text="Invoice No.:"></asp:Label>
                <asp:Label ID="Bill_No" runat="server"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Invoice Date:"></asp:Label>
                <asp:Label ID="Bill_date" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="User_Address" runat="server"></asp:Label>
                <br />
                <asp:Label ID="User_State" runat="server"></asp:Label>
                <br />
                <asp:Label ID="User_Pin" runat="server"></asp:Label>
                <br />
                <asp:Label ID="User_Ph" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Cart_Id" HeaderText="Bill ID" />
                        <asp:BoundField DataField="Pro_Name" HeaderText="Item" />
                        <asp:BoundField DataField="Cart_Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="Pro_Price" HeaderText="Price" />
                        <asp:BoundField DataField="Total_Price" HeaderText="Total" />
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
            <td class="auto-style5" colspan="2">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label12" runat="server" ForeColor="Black" Text="Grand Total"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label19" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="Button1" runat="server" CssClass="auto-style7" ForeColor="Black" Text="Proceed to Payment" Width="149px" OnClick="Button1_Click" />
            </td>
            <td colspan="2">
                <asp:Label ID="Label20" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label13" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#FF9900" Text="M/s JOAN Enterprises INDIA PVT LTD."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#FF6600" Text="Look better and live better... Happy Shopping!"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
