#pragma checksum "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ca513e4fe0112adf9af1120cc286389e91bff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AtoZBanking_TransactionDetails), @"mvc.1.0.view", @"/Views/AtoZBanking/TransactionDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ca513e4fe0112adf9af1120cc286389e91bff8", @"/Views/AtoZBanking/TransactionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf954d4308f42864edfed03376786fd116b0873", @"/Views/_ViewImports.cshtml")]
    public class Views_AtoZBanking_TransactionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AtoZBanking.Models.Transactions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
  
    ViewData["Title"] = "Transaction Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>All Transactions</h1>

<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th>From Account</th>
        <th>To Account</th>
        <th>Transaction Time</th>
        <th>Amount Debited</th>
        <th>From Account Balance</th>
        <th>To Account Balance</th>
    </tr>
");
#nullable restore
#line 17 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
     foreach (var d in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
           Write(d.FromAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
           Write(d.ToAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
           Write(d.TransactionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
           Write(d.AmountDebited);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
           Write(d.FromAccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
           Write(d.ToAccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td>\r\n        ");
#nullable restore
#line 36 "C:\Users\Aadil Desai\Desktop\Projects\AtoZBanking\AtoZBanking\AtoZBanking\Views\AtoZBanking\TransactionDetails.cshtml"
   Write(Html.ActionLink("Back to List", "Home", "AtoZBanking"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AtoZBanking.Models.Transactions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
