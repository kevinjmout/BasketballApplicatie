#pragma checksum "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d25f5adf641f17cfbf94dfb6a5c553ea451f804d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasketbalAPP.Pages.Pages_Players), @"mvc.1.0.razor-page", @"/Pages/Players.cshtml")]
namespace BasketbalAPP.Pages
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
#line 1 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\_ViewImports.cshtml"
using BasketbalAPP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d25f5adf641f17cfbf94dfb6a5c553ea451f804d", @"/Pages/Players.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8d44cfe991415fb0d9b27828f1e0259022b86f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Players : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
  
    ViewData["Title"] = "Players";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1>Players</h1>

    <table class=""table table-hover table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Active Team</th>
                <th scope=""col"">Games played</th>
                <th scope=""col"">Points</th>
                <th scope=""col"">Rebounds</th>
                <th scope=""col"">Assists</th>
                <th scope=""col"">Blocks</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
             foreach (var player in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.ActiveTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.Games);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.Rebounds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.Assists);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
                   Write(player.Blocks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <input type=\"search\" list=\"data1\" id=\"searchid\" placeholder=\"Enter Player...\" />\r\n    <datalist id=\"data1\">\r\n");
#nullable restore
#line 42 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
         foreach (var item in Model.Players)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d25f5adf641f17cfbf94dfb6a5c553ea451f804d8085", async() => {
#nullable restore
#line 44 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 5\Eigen applicatie\BasketbalAppInversion\BasketbalAPP\Pages\Players.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </datalist>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketbalAPP.Pages.PlayersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.PlayersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.PlayersModel>)PageContext?.ViewData;
        public BasketbalAPP.Pages.PlayersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591