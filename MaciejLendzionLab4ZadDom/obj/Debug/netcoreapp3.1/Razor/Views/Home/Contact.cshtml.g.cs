#pragma checksum "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af43def2e033563ef4a793cdc0da03fcf2af412a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af43def2e033563ef4a793cdc0da03fcf2af412a", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245b6b18dd41a6a23e1240d2a69f0bf9d899b6b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaciejLendzionLab4ZadDom.Models.ContactViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Strona z danymi kontaktowymi i formularzem kontaktowym-->\n\n\n\n\n");
            WriteLiteral(@"<!--Dane kontaktowe-->
<left>
    <h3>Kebab Core sp. z o. o.</h3>
    <h4>
        W??a??ciciel: Maciej Lendzion<br />
        <a href=""mailto: kebab-core@dev.com"">kebab-core@dev.com</a><br />
        tel: 993 742 137<br />
        adres: 156.17.220.63<br />
    </h4>
</left>

<!--Przerwa-->
<div class=""white-space""></div>

<h3>Formularz kontaktowy:</h3>
<!--Formularz kontaktowy-->
");
#nullable restore
#line 23 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
 using (Html.BeginForm("Contact", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 28 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
   Write(Html.LabelFor(model => model.FirstName, "Imie", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-3\">\n            ");
#nullable restore
#line 30 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 34 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
   Write(Html.LabelFor(model => model.LastName, "Nazwisko", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-3\">\n            ");
#nullable restore
#line 36 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 40 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
   Write(Html.LabelFor(model => model.Mail, "E-Mail (odpiszemy na niego)", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-5\">\n            ");
#nullable restore
#line 42 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
       Write(Html.EditorFor(model => model.Mail, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 46 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
   Write(Html.LabelFor(model => model.Message, "Wiadomo????", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 48 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"
       Write(Html.EditorFor(model => model.Message, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""white-space""></div>
    <div class=""white-space-small"">
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" volume=""Wy??lij wiadomo????"" class=""btn btn-success"" />
                </div"">
            </div>
        </div>
");
#nullable restore
#line 59 "C:\Users\lengo\Desktop\maciej_lendzion_cpc2021-1-main\maciej_lendzion_cpc2021-1-main\Lab4\Zadanie domowe\MaciejLendzionLab4ZadDom\MaciejLendzionLab4ZadDom\Views\Home\Contact.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaciejLendzionLab4ZadDom.Models.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
