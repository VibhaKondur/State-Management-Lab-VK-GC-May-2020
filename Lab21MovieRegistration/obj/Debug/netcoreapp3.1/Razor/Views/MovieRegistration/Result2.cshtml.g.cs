#pragma checksum "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "112a6c7da6d0b5f7de64f96dfb87732800aedca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieRegistration_Result2), @"mvc.1.0.view", @"/Views/MovieRegistration/Result2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112a6c7da6d0b5f7de64f96dfb87732800aedca1", @"/Views/MovieRegistration/Result2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e87cd11af520fe5972849a56461d06e65083e1", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieRegistration_Result2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
  
    ViewData["Title"] = "Here's the movie you registered!!";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>This ");
#nullable restore
#line 8 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered!</p>\r\n\r\n<p>ID: ");
#nullable restore
#line 10 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
  Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Title: ");
#nullable restore
#line 12 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Genre: ");
#nullable restore
#line 14 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Year: ");
#nullable restore
#line 16 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
    Write(Model.Year.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Actors: ");
#nullable restore
#line 18 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
      Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Directors: ");
#nullable restore
#line 20 "C:\Users\Vibha Kondur\source\repos\Lab21MovieRegistration\Lab21MovieRegistration\Views\MovieRegistration\Result2.cshtml"
         Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
