<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Q5WEB.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Search and XPathSearch services Test Page<br />
        <br />
        <br />
        <br />
        Search:&nbsp; XML URL:
        <asp:TextBox ID="TxtSearchXml" runat="server" Width="182px"></asp:TextBox>
&nbsp;&nbsp; First Name&nbsp;
        <asp:TextBox ID="TxtSearchFirst" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="TxtSearchResult" runat="server" Height="247px" TextMode="MultiLine" Width="522px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <br />
        XPathSearch&nbsp;&nbsp;&nbsp; XML URL<asp:TextBox ID="TxtPathXml" runat="server" Width="182px"></asp:TextBox>
&nbsp;Xpath&nbsp;
        <asp:TextBox ID="TxtPath" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TxtXpathResult" runat="server" Height="247px" TextMode="MultiLine" Width="522px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
