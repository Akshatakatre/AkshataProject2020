<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ScriptingManagerExample.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<br />
                <br />
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                </asp:Timer>
<br />
                <asp:Label ID="Label1" runat="server" Height="101px" Style="width:304px"></asp:Label>
                <br />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
            </div>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            Hello... Welcome!!</p>
    </form>
</body>
</html>
