#pragma checksum "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDteam\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88418f7f30cc2b22ddebe05654de65a1a96039ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasketbalAPP.Pages.CRUDteam.Pages_CRUDteam_Read), @"mvc.1.0.razor-page", @"/Pages/CRUDteam/Read.cshtml")]
namespace BasketbalAPP.Pages.CRUDteam
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
#line 1 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\_ViewImports.cshtml"
using BasketbalAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDteam\Read.cshtml"
using Logic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88418f7f30cc2b22ddebe05654de65a1a96039ff", @"/Pages/CRUDteam/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8d44cfe991415fb0d9b27828f1e0259022b86f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CRUDteam_Read : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Details Page</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n    </tr>\r\n    <tr>\r\n        <td>First Name : ");
#nullable restore
#line 13 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDteam\Read.cshtml"
                    Write(Html.DisplayFor(model => model.DisplayPlayerinTeam.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>First Name : ");
#nullable restore
#line 16 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDteam\Read.cshtml"
                    Write(Html.DisplayFor(model => model.Team.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>First Name : ");
#nullable restore
#line 19 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDteam\Read.cshtml"
                    Write(Html.DisplayFor(model => model.DisplayPlayerinTeam.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Last Name : ");
#nullable restore
#line 22 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDteam\Read.cshtml"
                   Write(Html.DisplayFor(model => model.DisplayPlayerinTeam.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketbalAPP.Pages.CRUDteam.ReadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.CRUDteam.ReadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.CRUDteam.ReadModel>)PageContext?.ViewData;
        public BasketbalAPP.Pages.CRUDteam.ReadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
