<%@ Page Title="" Language="C#" MasterPageFile="~/PassengerDashboard.Master" AutoEventWireup="true" CodeBehind="PassengerProfile.aspx.cs" Inherits="DigitalPass1.WebForm3" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  


    <form id="form1" runat="server">
        
    

        <table class="w-100" style="margin-top: 114px">
            <br/>
    <br/>
            <tr>
                <td style="width: 210px; height: 32px">&nbsp; Name:-&nbsp;</td>
                <td style="height: 32px; width: 560px;">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 32px"></td>
            </tr>
            <tr>
                <td style="width: 210px; height: 32px">&nbsp;</td>
                <td style="height: 32px; width: 560px;">&nbsp;</td>
                <td style="height: 32px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp; Address:-&nbsp;</td>
                <td style="width: 560px">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp; Mobile Number:-&nbsp;</td>
                <td style="width: 560px">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp; Email id:-&nbsp;</td>
                <td style="width: 560px">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp; Gender:-&nbsp;</td>
                <td style="width: 560px">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px; height: 32px">&nbsp; Date of Birth:-&nbsp;</td>
                <td style="height: 32px; width: 560px;">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 32px"></td>
            </tr>
            <tr>
                <td style="width: 210px; height: 32px">&nbsp;</td>
                <td style="height: 32px; width: 560px;">
                    &nbsp;</td>
                <td style="height: 32px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp; Adharcard Number:-&nbsp;</td>
                <td style="width: 560px">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px; height: 31px">&nbsp; Registration Date:-&nbsp;</td>
                <td style="height: 31px; width: 560px;">
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 31px"></td>
            </tr>
            <tr>
                <td style="width: 210px; height: 32px">&nbsp;</td>
                <td style="height: 32px; width: 560px;">&nbsp;</td>
                <td style="height: 32px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp; Photo:-&nbsp;</td>
                <td style="width: 560px">
                    <asp:Image ID="Image1" runat="server" Width="113px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Profile" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Change Password" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 210px">&nbsp;</td>
                <td style="width: 560px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
   
  
</asp:Content>
