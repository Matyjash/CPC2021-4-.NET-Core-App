#pragma checksum "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Rates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b238b60c1dabb6779f495838d04048398c5c5c5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rates), @"mvc.1.0.view", @"/Views/Home/Rates.cshtml")]
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
#line 1 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\_ViewImports.cshtml"
using MaciejLendzionLab4ZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\_ViewImports.cshtml"
using MaciejLendzionLab4ZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b238b60c1dabb6779f495838d04048398c5c5c5d", @"/Views/Home/Rates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245b6b18dd41a6a23e1240d2a69f0bf9d899b6b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MaciejLendzionLab4ZadDom.Models.RateViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <h2>Opinie:</h2>\n</div>\n\n<div class=\"white-space\"></div>\n\n");
#nullable restore
#line 9 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Rates.cshtml"
 foreach (var Rate in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"rate-background\">\n\n        <h6>\n            ");
#nullable restore
#line 14 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Rates.cshtml"
       Write(Rate.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(":\n        </h6>\n        <h7>\n            ");
#nullable restore
#line 17 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Rates.cshtml"
       Write(Rate.Opinion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h7>\n    </div>\n    <div class=\"white-space\"></div>\n");
#nullable restore
#line 21 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Rates.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <button>\n        ");
#nullable restore
#line 25 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Rates.cshtml"
   Write(Html.ActionLink("Wystaw opini??!", "CreateRate", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </button>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MaciejLendzionLab4ZadDom.Models.RateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
