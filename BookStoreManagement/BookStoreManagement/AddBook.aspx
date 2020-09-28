<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookStoreManagement.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        width: 213px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
<p>
    Book Entry Form<br />
</p>
<table class="auto-style4">
    <tr>
        <td class="auto-style5">Book Name :-</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">MRP :-</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Author :-</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>------Select------</asp:ListItem>
                <asp:ListItem>Amit Garg</asp:ListItem>
                <asp:ListItem>Sharad Kumar Verma</asp:ListItem>
                <asp:ListItem>Saurabh Singhal</asp:ListItem>
                <asp:ListItem>Tolstoy</asp:ListItem>
                <asp:ListItem>Herman Melville</asp:ListItem>
                <asp:ListItem>Henry Fielding</asp:ListItem>
                <asp:ListItem>Stendhal</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Category :-</td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                <asp:ListItem>-------Select---------</asp:ListItem>
                <asp:ListItem>Education and Reference</asp:ListItem>
                <asp:ListItem>Novels</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Publisher :-</td>
        <td>
            <asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                <asp:ListItem>-------Select------</asp:ListItem>
                <asp:ListItem>Reader&#39;s Zone</asp:ListItem>
                <asp:ListItem>Sun India Publications,New Delhi</asp:ListItem>
                <asp:ListItem>Thakur Publications</asp:ListItem>
                <asp:ListItem>K Nath &amp; Sons,Meerut</asp:ListItem>
                <asp:ListItem>MK Publications</asp:ListItem>
                <asp:ListItem>JSONS Publications</asp:ListItem>
                <asp:ListItem>T&amp;J Publishers</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
&nbsp;&nbsp;&nbsp; </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
