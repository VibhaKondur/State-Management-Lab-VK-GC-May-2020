#pragma checksum "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ed9f257e07ed3a6fe96d70e3989265424c6693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieRegistration_Result), @"mvc.1.0.view", @"/Views/MovieRegistration/Result.cshtml")]
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
#line 1 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\_ViewImports.cshtml"
using Lab21MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\_ViewImports.cshtml"
using Lab21MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ed9f257e07ed3a6fe96d70e3989265424c6693", @"/Views/MovieRegistration/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e87cd11af520fe5972849a56461d06e65083e1", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieRegistration_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
  
    ViewData["Title"] = "Here's the movie you registered!!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>This ");
#nullable restore
#line 5 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
    Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered!</h1>\r\n\r\n<h2>ID: ");
#nullable restore
#line 7 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
   Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>Title: ");
#nullable restore
#line 9 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>Genre: ");
#nullable restore
#line 11 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
      Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>Year: ");
#nullable restore
#line 13 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
     Write(ViewBag.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>Actors: ");
#nullable restore
#line 15 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
       Write(ViewBag.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>Directors: ");
#nullable restore
#line 17 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result.cshtml"
          Write(ViewBag.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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