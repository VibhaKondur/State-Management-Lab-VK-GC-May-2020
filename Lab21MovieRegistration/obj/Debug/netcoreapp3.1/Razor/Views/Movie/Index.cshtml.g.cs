#pragma checksum "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a226bf50a67348d9f29cad79575bd48401e1e79c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\_ViewImports.cshtml"
using Lab21MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\_ViewImports.cshtml"
using Lab21MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a226bf50a67348d9f29cad79575bd48401e1e79c", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e87cd11af520fe5972849a56461d06e65083e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Title</th>\r\n        <th>Genre</th>\r\n        <th>Runtime</th>\r\n        <th>Release Year</th>\r\n        <th>Rental Cost</th>\r\n");
            WriteLiteral("        <th><a class=\"btn\" href=\".../Movie\"</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
     foreach (Movie movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
   Write(movie.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
   Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
   Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
   Write(movie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
   Write(movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
   Write(movie.RentalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 640, "\"", 787, 11);
            WriteAttributeValue("", 647, "../Movie/AddToCart?title=", 647, 25, true);
#nullable restore
#line 26 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
WriteAttributeValue("", 672, movie.Title, 672, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 684, "&genre=", 684, 7, true);
#nullable restore
#line 26 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
WriteAttributeValue("", 691, movie.Genre, 691, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 703, "&runtime=", 703, 9, true);
#nullable restore
#line 26 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
WriteAttributeValue("", 712, movie.Runtime, 712, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 726, "&releaseYear=", 726, 13, true);
#nullable restore
#line 26 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
WriteAttributeValue("", 739, movie.ReleaseYear, 739, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 757, "&rentalCost=", 757, 12, true);
#nullable restore
#line 26 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
WriteAttributeValue("", 769, movie.RentalCost, 769, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 786, "", 787, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Rent</a></td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\Users\Vibha Kondur\source\repos\MovieRegistrationLabWithSessions\Lab21MovieRegistration\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
