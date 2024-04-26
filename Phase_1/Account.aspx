<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Phase_1.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .reg-tbl {
            margin:0 auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="reg-tbl" __designer:mapid="10">
                        <tr __designer:mapid="11">
                            <td __designer:mapid="12">
                                <table class="w-100" __designer:mapid="13">
                                    <tr __designer:mapid="14">
                                        <td colspan="2" __designer:mapid="15">
                                            <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" Text="Account Details"></asp:Label>
                                        &nbsp;<asp:Label ID="Label25" runat="server" Font-Italic="True" Font-Underline="False" ForeColor="#FF3300" Text="**Ensure you are logged in before entering the details"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr __designer:mapid="17">
                                        <td __designer:mapid="18">
                                            <asp:Label ID="Label21" runat="server" Text="Account Holder Name"></asp:Label>
                                        </td>
                                        <td __designer:mapid="1a">
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*This field is mandatory"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr __designer:mapid="1d">
                                        <td __designer:mapid="1e" class="auto-style1">
                                            <asp:Label ID="Label22" runat="server" Text="Account Number"></asp:Label>
                                        </td>
                                        <td __designer:mapid="20" class="auto-style1">
                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*This field is mandatory"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr __designer:mapid="23">
                                        <td __designer:mapid="24">
                                            <asp:Label ID="Label23" runat="server" Text="Account Type"></asp:Label>
                                        </td>
                                        <td __designer:mapid="26">
                                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*This field is mandatory"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr __designer:mapid="29">
                                        <td __designer:mapid="2a">&nbsp;</td>
                                        <td __designer:mapid="2b">
                                            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                                            <asp:Label ID="Label24" runat="server" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
</asp:Content>
