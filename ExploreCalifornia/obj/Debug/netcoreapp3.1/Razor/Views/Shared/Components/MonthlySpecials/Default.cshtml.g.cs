#pragma checksum "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a8a080419371440fa298b365d467f681607f2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
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
#line 3 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\_ViewImports.cshtml"
using ExploreCalifornia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a8a080419371440fa298b365d467f681607f2e", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056f03fed17577adcc093ce41b571060debdb298", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MonthlySpecials_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExploreCalifornia.Models.MonthlySpecial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Monthly Specials</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
 foreach (var special in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"top\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 162, "\"", 198, 3);
            WriteAttributeValue("", 168, "/images/", 168, 8, true);
#nullable restore
#line 8 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 176, special.Key, 176, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 190, "_bug.gif", 190, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 199, "\"", 218, 1);
#nullable restore
#line 8 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 205, special.Name, 205, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"75\" height=\"75\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n    <p>\r\n        ");
#nullable restore
#line 12 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 358, 3);
            WriteAttributeValue("", 333, "/tours/", 333, 7, true);
#nullable restore
#line 13 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 340, special.Key, 340, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 354, ".htm", 354, 4, true);
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 13 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
                                        Write(special.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\Owner\Desktop\.Net core projects\ExploreCalifornia\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExploreCalifornia.Models.MonthlySpecial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
