<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ScriptingManagerExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<br />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
<br />
                Enter Number:-<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
<br />
<br />
                Result:-<asp:Label ID="Label1" runat="server"></asp:Label>
<br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <p>
            Enter Age:-<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
        </p>
        <p>
            Result:-<asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
