#pragma checksum "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3908b94051f638e24c9939d061f389a78979b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AtoZBanking_Home), @"mvc.1.0.view", @"/Views/AtoZBanking/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3908b94051f638e24c9939d061f389a78979b3", @"/Views/AtoZBanking/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf954d4308f42864edfed03376786fd116b0873", @"/Views/_ViewImports.cshtml")]
    public class Views_AtoZBanking_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome to AtoZ Banking App</h2>\r\n<div>\r\n    <label>View all Accounts ");
#nullable restore
#line 8 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Home.cshtml"
                        Write(Html.ActionLink("here", "Accounts", "AtoZBanking"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n    <label>Initiate a Transfer ");
#nullable restore
#line 9 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Home.cshtml"
                          Write(Html.ActionLink("here", "InitiateTransfer", "AtoZBanking"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n    <label>View all Transactions ");
#nullable restore
#line 10 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\Home.cshtml"
                            Write(Html.ActionLink("here", "TransactionDetails", "AtoZBanking"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
