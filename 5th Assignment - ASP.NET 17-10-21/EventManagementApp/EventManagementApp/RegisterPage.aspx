﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="EventManagementApp.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="Shadow.css" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <div align="center" class="container jumbotron bg-light boxshadow" style="width:35%">
            <form>
                <br />
                <div class="card-header-pills bg-dark text-white" style="width:80%">
                    <h2>Registration Page</h2>
                </div>
                <br />
                <div class="form-group" style="width:80%">
                 <table>
                     <tr>
                         <td>First Name</td>
                        <td><asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox></td>
                         </tr>
                      <tr>
                         <td>Last Name</td>
                        <td><asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox></td>
                         </tr>
                     <tr>
                         <td>Email</td>
                        <td><asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                         </tr>
                     <tr>
                         <td>Password</td>
                        <td><asp:TextBox ID="tbPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
                         </tr>
                     <tr>
                         <td>Phone Number</td>
                        <td><asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control"></asp:TextBox></td>
                         </tr>
                     <tr>
                         <td>Address</td>
                        <td><asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox></td>
                         </tr>
                </table>
                </div>
                <br />
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" />
                <div>
                    <asp:LinkButton ID="lbtnLogin" runat="server" CssClass="btn btn-link">Already User?Login</asp:LinkButton>
                </div>
    </form>
    </div>
    </form>
</body>
</html>
