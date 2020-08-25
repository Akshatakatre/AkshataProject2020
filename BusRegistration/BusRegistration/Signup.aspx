<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="BusRegistration.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="                 Note:-The fields which contains  * symbol is manditary fields." style="color: #FF0000"></asp:Label>
        <br />
        <br />
        <br />
        <table class="w-100" style="height: 1654px">
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000">&nbsp;&nbsp;*</span> Name:-&nbsp;</td>
                <td style="width: 253px">
                    <script>

</script>
                    <asp:TextBox ID="TextBox1" runat="server" Width="520px" ForeColor="Silver"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter the name."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;<span style="color: #FF0000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*</span> Address:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="520px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter the address."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px; height: 20px;"></td>
                <td style="width: 253px; height: 20px;"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 260px; height: 40px;"><span style="color: #FF0000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><span style="color:#FF0000">*</span> Mobile Number:-&nbsp;</td>
                <td style="width: 253px; height: 40px;">
                    <asp:TextBox ID="TextBox3" runat="server" Width="520px" ForeColor="Silver"></asp:TextBox>
                </td>
                <td style="height: 40px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter the mobile number"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Mobile number contain only 10 integers."></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000"> *</span> Email id:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Email" Width="520px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please enter the email id."></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Incorrect email id." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000"> *</span> Password:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:TextBox ID="TextBox11" runat="server" Width="520px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter the password." ControlToValidate="TextBox11"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">(The password must be 8 characters long it contains uppercase letters,lowercase letters,special characters and integer.)</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox11" ErrorMessage="The password must be 8 characters long it contains uppercase letters, lowercase letters,special characters and numbers." MaximumValue="8" MinimumValue="8"></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px; height: 20px;">&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000">&nbsp; *</span> Conform Password:-&nbsp;</td>
                <td style="width: 253px; height: 20px;">
                    <asp:TextBox ID="TextBox7" runat="server" Width="520px" OnTextChanged="TextBox7_TextChanged" TextMode="Password"></asp:TextBox>
                </td>
                <td style="height: 20px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter the confoem password." ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px; height: 20px"></td>
                <td style="height: 20px; width: 253px">
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox11" ControlToValidate="TextBox7" ErrorMessage="Password cannot match."></asp:CompareValidator>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 260px; height: 20px">&nbsp;</td>
                <td style="height: 20px; width: 253px">&nbsp;</td>
                <td style="height: 20px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000">*</span> Gender:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Gender" Text="Others" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000">&nbsp; *</span> Date of Birth:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Date" Width="520px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox4" ErrorMessage="please enter the date of birth."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Date of birth is not proper." OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px; height: 20px;"></td>
                <td style="width: 253px; height: 20px;"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;<span style="color: #FF0000">&nbsp;&nbsp;&nbsp;&nbsp;*</span> Adharcard Number:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:TextBox ID="TextBox8" runat="server" Width="520px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox8" ErrorMessage="Please enter the adharcard number."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox8" ErrorMessage="Adharcard number contain 12 integers." MaximumValue="12" MinimumValue="12"></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #FF0000"> *</span> Security Questions:-&nbsp;</td>
                <td style="width: 253px">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="529px">
                        <asp:ListItem>-----Select----</asp:ListItem>
                        <asp:ListItem>What is the name of the town where you were born ?</asp:ListItem>
                        <asp:ListItem>What primary school did you attend ?</asp:ListItem>
                        <asp:ListItem>What is your favourite food ?</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Please select the security question."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px; height: 28px;">&nbsp;<span style="color: #FF0000">&nbsp;&nbsp;&nbsp;&nbsp; *</span> Security Answer:-&nbsp;</td>
                <td style="width: 253px; height: 28px;">
                    <asp:TextBox ID="TextBox9" runat="server" Width="520px"></asp:TextBox>
                </td>
                <td style="height: 30px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox9" ErrorMessage="Please enter the security answer."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px; height: 32px;"></td>
                <td style="width: 200px; height: 32px;"></td>
                <td style="height: 32px"></td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;<span style="color: #FF0000">&nbsp;&nbsp;&nbsp;&nbsp; *</span>  Date:-&nbsp;</td>
                <td style="width: 200px">
                    <asp:TextBox ID="TextBox10" runat="server" Width="520px" OnTextChanged="TextBox10_TextChanged" TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox10" ErrorMessage="Please enter the current date."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px; height: 25px;"></td>
                <td style="width: 253px; height: 25px;">
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="TextBox10" ErrorMessage="Date is not proper." OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                </td>
                <td style="height: 25px"></td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px; height: 35px;">&nbsp;&nbsp;&nbsp;<span style="color: #FF0000">&nbsp;&nbsp;&nbsp;</span><span style="color: #FF0000">*</span> Photo:-&nbsp;</td>
                <td style="width: 253px; height: 35px;">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="526px" />
                </td>
                <td style="height: 35px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Please upload photo."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 260px; height: 36px;"></td>
                <td style="width: 253px; height: 36px;"></td>
                <td style="height: 36px"></td>
            </tr>
           
            <tr>
                <td style="width: 260px; height: 19px;"></td>
                <td style="width: 253px; height: 19px;">&nbsp; &nbsp;</td>
                <td style="height: 19px"></td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td style="width: 253px">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Back" />
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 260px">&nbsp;</td>
                <td style="width: 253px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
                  </table>
        <br />
        
        </div>
    </form>
</body>
</html>
