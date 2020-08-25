<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ScannedCode.aspx.cs" Inherits="BusPass.ScannedCode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





  
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <h2> <%# Eval("Name") %> </h2>
                <asp:Image Width="100" Height="100" ID="QR_Code" runat="server"/>
                </ItemTemplate>

        </asp:DataList>
    
      




</asp:Content>
