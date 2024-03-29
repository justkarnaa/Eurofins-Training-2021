﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="OrderManagement.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 40%;">

                <h2>Enter Order details</h2>
                <tr>
                    <td>
                        <asp:Label ID="number" runat="server">Order Number :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="order_no" runat="server"> </asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td>
                        <asp:Label ID="amount" runat="server">Purchase Amount :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="purch_amt" runat="server"> </asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td>
                        <asp:Label ID="date" runat="server">Date :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="order_date" runat="server"> </asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td>
                        <asp:Label ID="id" runat="server">Customer Id :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="Customer_id" runat="server"> </asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td>
                        <asp:Label ID="salesmanid" runat="server">Salesman Id :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="Salesman_id" runat="server"> </asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td>
                        <asp:Button ID="Submit" runat="server" Text="Submit" BorderStyle="Solid" ToolTip="Submit" OnClick="Submit_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
