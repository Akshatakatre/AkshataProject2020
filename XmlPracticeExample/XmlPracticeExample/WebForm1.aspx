<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="XmlPracticeExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Display data from xml file<br />
            <br />
            <asp:Xml ID="Xml1" runat="server" DocumentSource="~/batches.xml"></asp:Xml>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
