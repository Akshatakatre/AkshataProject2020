#pragma checksum "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571bd46c4979254347177c005c7cf6eb597cc674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Signup), @"mvc.1.0.view", @"/Views/Home/Signup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\_ViewImports.cshtml"
using AspNetCoreRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\_ViewImports.cshtml"
using AspNetCoreRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571bd46c4979254347177c005c7cf6eb597cc674", @"/Views/Home/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593f279a7ae123e32aa1841def307e33e9f9befb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreRegistration.Models.RegistrationTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
  
    ViewData["Title"] = "Signup";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
 using (Html.BeginForm("Form2", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>Enter ID: </td>\r\n            <td>");
#nullable restore
#line 12 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Name: </td>\r\n            <td>");
#nullable restore
#line 16 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Address: </td>\r\n            <td>");
#nullable restore
#line 20 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Mobile Number: </td>\r\n            <td>");
#nullable restore
#line 24 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Mobile_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Email id: </td>\r\n            <td>");
#nullable restore
#line 28 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Email_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Password: </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 34 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Conform Password: </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.PasswordFor(m => m.Conform_Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Conform_Password, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Gender: </td>\r\n            <td>");
#nullable restore
#line 46 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Age: </td>\r\n            <td>");
#nullable restore
#line 50 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Date of Birth: </td>\r\n            <td>");
#nullable restore
#line 54 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(m => m.Date_of_Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        \r\n        <tr>\r\n            <td colspan=\"2\"><input type=\"submit\" value=\"Submit Form\" /></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 61 "E:\Akshataproject\AspNetCoreRegistration\AspNetCoreRegistration\Views\Home\Signup.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreRegistration.Models.RegistrationTable> Html { get; private set; }
    }
}
#pragma warning restore 1591