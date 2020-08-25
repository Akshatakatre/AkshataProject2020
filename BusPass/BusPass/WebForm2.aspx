<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BusPass.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    &nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
&nbsp&nbsp<asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
<hr />
<br />
 &nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp&nbsp<asp:GridView runat="server" ID="gvQRCode" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="gvQRCode_SelectedIndexChanged">
    <Columns>
        <asp:TemplateField HeaderText="Image">
            <ItemTemplate>
                 &nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp&nbsp<asp:Image ID="Image1" runat="server" Height="50px" Width="75px" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
