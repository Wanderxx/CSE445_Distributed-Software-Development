<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherTryIt.aspx.cs" Inherits="WebApplication1.WeatherTyrIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 396px">
    <form id="form1" runat="server">
    <div>
    
        Weather TryIt:</div>
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="ZipCode:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="Txtzip" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Invoke" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;
        <asp:TextBox ID="Txtweather" runat="server" Height="286px" TextMode="MultiLine" Width="427px"></asp:TextBox>
        
    </form>
</body>
</html>
