#pragma checksum "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de918decce49b4427a68c453960dc9e0be9c29c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasketbalAPP.Pages.Pages_TeamManager), @"mvc.1.0.razor-page", @"/Pages/TeamManager.cshtml")]
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
#line 1 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\_ViewImports.cshtml"
using BasketbalAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
using Logic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de918decce49b4427a68c453960dc9e0be9c29c", @"/Pages/TeamManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8d44cfe991415fb0d9b27828f1e0259022b86f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TeamManager : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1>Players and Teams</h1>\r\n    <hr />\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Team Name</th>\r\n            <th>Owner</th>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
         foreach (var team in Model.Teams)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(team.IdTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(team.Owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n            <th>Active Team</th>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
         foreach (var player in Model.Players)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(player.IdPlayer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(player.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(player.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
               Write(player.ActiveTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\TeamManager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketbalAPP.Pages.PlayersToAdd.ControllerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.PlayersToAdd.ControllerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.PlayersToAdd.ControllerModel>)PageContext?.ViewData;
        public BasketbalAPP.Pages.PlayersToAdd.ControllerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
