#pragma checksum "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de1f04dee8754575412cf46ada0a7c8798ae121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AtoZBanking_Delete), @"mvc.1.0.view", @"/Views/AtoZBanking/Delete.cshtml")]
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
#line 1 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\_ViewImports.cshtml"
using AtoZBanking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\_ViewImports.cshtml"
using AtoZBanking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de1f04dee8754575412cf46ada0a7c8798ae121", @"/Views/AtoZBanking/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf954d4308f42864edfed03376786fd116b0873", @"/Views/_ViewImports.cshtml")]
    public class Views_AtoZBanking_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AtoZBanking.Models.Accounts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
 using (Html.BeginForm("Delete", "AtoZBanking", new { Id = @Model.AccountId }, FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Delete Account</h1>\r\n");
            WriteLiteral("    <h3> Are you sure you want to delete this account? </h3>\r\n");
            WriteLiteral("    <table class=\"table table-bordered table-responsive table-hover\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
           Write(Html.LabelFor(a => a.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
           Write(Html.DisplayFor(a => a.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
           Write(Html.LabelFor(a => a.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
           Write(Html.DisplayFor(a => a.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>\r\n                <input type=\"submit\" value=\"Delete\" />\r\n                ");
#nullable restore
#line 26 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
           Write(Html.ActionLink("Back to List", "Accounts", "AtoZBanking"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 31 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AtoZBanking.Models.Accounts> Html { get; private set; }
    }
}
#pragma warning restore 1591
