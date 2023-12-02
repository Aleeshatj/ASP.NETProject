<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Project1.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 64px;
        }
        .auto-style3 {
            height: 71px;
            width: 19px;
        }
        .auto-style4 {
            width: 19px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            width: 19px;
        }
        .auto-style7 {
            height: 71px;
        }
        .auto-style8 {
            width: 100%;
            height: 197px;
        }
        .auto-style10 {
            width: 19px;
            height: 34px;
        }
        .auto-style11 {
            height: 34px;
        }
        .auto-style12 {
            width: 19px;
            height: 64px;
        }
        .auto-style13 {
            height: 26px;
            width: 128px;
        }
        .auto-style14 {
            height: 71px;
            width: 128px;
        }
        .auto-style15 {
            height: 64px;
            width: 128px;
        }
        .auto-style16 {
            height: 34px;
            width: 128px;
        }
        .auto-style18 {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" BorderColor="Black" GridLines="Both" Height="355px" RepeatDirection="Horizontal" style="margin-right: 0px" Width="386px">
        <ItemTemplate>
            <table class="auto-style8">
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#FFCC00" Text='<%# Eval("Cat_Name") %>'></asp:Label>
                    </td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style14">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="106px" ImageUrl='<%# Eval("Cat_Image") %>' Width="106px" CommandArgument='<%# Eval("Cat_Id") %>' OnCommand="ImageButton1_Command" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Cat_Descr") %>'></asp:Label>
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Cat_Status") %>'></asp:Label>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
