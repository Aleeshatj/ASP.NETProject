<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayProdct.aspx.cs" Inherits="Project1.DisplayProdct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 63px;
        }
        .auto-style3 {
            height: 165px;
        }
        .auto-style4 {
            height: 52px;
        }
        .auto-style5 {
            height: 60px;
        }
        .auto-style6 {
            height: 47px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server" BorderColor="Yellow" BorderWidth="2px" GridLines="Both">
                        <ItemTemplate>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#FFCC00" Text='<%# Eval("Pro_Name") %>'></asp:Label>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <asp:ImageButton ID="ImageButton1" runat="server" Height="122px" ImageUrl='<%# Eval("Pro_Image") %>' Width="145px" CommandArgument='<%# Eval("Pro_Id") %>' OnCommand="ImageButton1_Command" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Pro_Price") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Pro_Descr") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Pro_Status") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Pro_Stock") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
