#pragma checksum "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\CreateRateSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91f1e373114cfab0a97baa3925b8c40fe7626314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateRateSuccess), @"mvc.1.0.view", @"/Views/Home/CreateRateSuccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91f1e373114cfab0a97baa3925b8c40fe7626314", @"/Views/Home/CreateRateSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245b6b18dd41a6a23e1240d2a69f0bf9d899b6b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateRateSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\n    <h6>\n        Wystawiono opinię!\n    </h6>\n    <div class=\"rate-background\">\n        <h6>\n            ");
#nullable restore
#line 7 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\CreateRateSuccess.cshtml"
       Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h6>\n        <h7>\n            ");
#nullable restore
#line 10 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\CreateRateSuccess.cshtml"
       Write(ViewBag.Opinion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h7>\n    </div>\n</div>");
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
