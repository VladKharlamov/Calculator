<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="phone.aspx.cs" Inherits="Calculator.phone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Ваше сообщение"></asp:Label><br/>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox><br/>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Отправить" />
    
    </div>
    </form>
</body>
</html>
