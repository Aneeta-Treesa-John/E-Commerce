<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="Phase_1.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="729px">
                    <Columns>
                        <asp:BoundField DataField="User_Id" HeaderText="User ID" />
                        <asp:BoundField DataField="User_Name" HeaderText="Name" />
                        <asp:BoundField DataField="User_Email" HeaderText="Email ID" />
                        <asp:BoundField DataField="User_Phone" HeaderText="Phone" />
                        <asp:BoundField DataField="User_Status" HeaderText="Status" />
                        <asp:TemplateField HeaderText="Remove/Block">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("User_Id") %>' OnCommand="LinkButton1_Command">select</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
