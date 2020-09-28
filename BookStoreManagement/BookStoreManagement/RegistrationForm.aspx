<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="BookStoreManagement.RegistrationForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        width: 177px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    Registration Form</p>
<p>
</p>
<table class="auto-style4">
    <tr>
        <td class="auto-style5">Name :-</td>
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
        <td class="auto-style5">Address :-</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Mobile Number :-</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Email id :-</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" TextMode="Email"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Password :-</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged" TextMode="Password"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Conform Password :-</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" TextMode="Password"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Gender :-</td>
        <td>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Female" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gender" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Other" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Age :-</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Date of Birth :-</td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server" OnTextChanged="TextBox8_TextChanged" TextMode="Date"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Registration Date :-</td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server" OnTextChanged="TextBox9_TextChanged" TextMode="Date"></asp:TextBox>
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
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
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
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
<p>
</p>
</asp:Content>
