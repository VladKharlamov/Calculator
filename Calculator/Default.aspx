<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Models.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 17%;
        }
    </style>
</head>
<body>
    <p><a rel="nofollow" href="phone.aspx"> Здесь вы сможете отправить мне сообщение </a></p>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1" aria-setsize="90">
            <tr>
                <td colspan="3">
    
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="С" Height="90%" Width="90%" />
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="7" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="8" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="9" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="/" Height="90%" Width="90%" />
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="4" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="5" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="6" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="*" Height="90%" Width="90%" />
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="1" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="2" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="3" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="-" Height="90%" Width="90%" />
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="0" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="," Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="=" Height="90%" Width="90%" />
                </td>
                <td>
        <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="+" Height="90%" Width="90%" />
    
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>
</body>
</html>
