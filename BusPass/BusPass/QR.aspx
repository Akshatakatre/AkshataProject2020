<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QR.aspx.cs" Inherits="BusPass.QR" EnableEventValidation="false" %>
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
       <br/>
    <br/>
   
        
            <div>
                <asp:TextBox ID="txtCode" runat="server"> </asp:TextBox>
                <asp:Button ID="btnGenerate" runat="server" Text="Generate QR Code"    Width="246px" OnClick="btnGenerate_Click1"  ></asp:Button>
                <asp:Button ID="Button1" runat="server"  Text="Button" OnClick="Button1_Click1" />
                <hr/>
                <asp:Image ID="imgQRCode" Width="100px" Height="100px" runat="server" Visible="false"/>
                <br/><br/>
                <asp:Button ID="btnRead" runat="server" Text="Read QR Image" OnClick="btnRead_Click"/>
                <br/><br/>
                <asp:Label ID="lblQRCode" runat="server" ></asp:Label>

            </div>
          
   
</asp:Content>
