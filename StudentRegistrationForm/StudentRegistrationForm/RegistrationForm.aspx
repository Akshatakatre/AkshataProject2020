<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="StudentRegistrationForm.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 181px;
        }
        .auto-style3 {
            width: 351px;
        }
        .auto-style4 {
            width: 181px;
            height: 29px;
        }
        .auto-style5 {
            width: 351px;
            height: 29px;
        }
        .auto-style6 {
            height: 29px;
        }
        .auto-style7 {
            width: 181px;
            height: 26px;
        }
        .auto-style8 {
            width: 351px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRATION FORM<br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="310px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter the name."></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="The first letter of the  name is capital and give the space between firstname, middlename and lastname, and the first letters of the firstname,middlename and lastname mudt be capital. "></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Address :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="MultiLine" Width="310px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter the address."></asp:RequiredFieldValidator>
                    &nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="The address must contain house no. ,area, streat name, city name and pincode."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Mobile Number :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="304px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter the Mobile number."></asp:RequiredFieldValidator>
                    &nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="The mobile number only contains 10 digits."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Email id :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" TextMode="Email" Width="309px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please enter the email id."></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter correct email id." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Password :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged" TextMode="Password" Width="308px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please enter the password."></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Password must be 6 characters long and it contains integer value(numbers),uppercase letters,lowercase letters and special characters."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Conform Password :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" TextMode="Password" Width="297px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please enter the conform password."></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="Password cannot match."></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Age :-</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox9" runat="server" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox9" ErrorMessage="Please enter the age."></asp:RequiredFieldValidator>
&nbsp;
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox9" ErrorMessage="Age is not proper." MaximumValue="30" MinimumValue="18"></asp:RangeValidator>
                    &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender :-</td>
                    <td class="auto-style3">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gender" Text="Others" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Date of Birth :-</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged" TextMode="Date" Width="295px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7" ErrorMessage="Please enter the date of birth."></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Cource :-</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="292px">
                            <asp:ListItem>-----Select-----</asp:ListItem>
                            <asp:ListItem>.Net</asp:ListItem>
                            <asp:ListItem>Python</asp:ListItem>
                            <asp:ListItem>Java</asp:ListItem>
                            <asp:ListItem>C Programming</asp:ListItem>
                            <asp:ListItem>C++</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Please select the any one course."></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select one course at a time."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Registration Date :-</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox8" runat="server" TextMode="Date" Width="289px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox8" ErrorMessage="Please enter the registration date."></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TextBox8" ErrorMessage="Please enter todays date."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Photo :-</td>
                    <td class="auto-style3">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="294px" />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Please upload the photo."></asp:RequiredFieldValidator>
                    &nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Upload your current photo."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="105px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
