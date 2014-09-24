<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WsOperationTryIt.aspx.cs" Inherits="WebApplication1.Number2WordTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        WsOperation TryIt:</div>
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Url:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtUrl" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Invoke" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtResult" runat="server" Height="299px" TextMode="MultiLine" Width="481px"></asp:TextBox>
        
    </form>
 
</body>
</html>
