#pragma checksum "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5ca8ca3831a42c9557bffa490aa19c026c005e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Details.cshtml", typeof(AspNetCore.Views_Movies_Details))]
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
#line 1 "/Users/jose-ims/Projects/moviemvc/Views/_ViewImports.cshtml"
using moviemvc;

#line default
#line hidden
#line 2 "/Users/jose-ims/Projects/moviemvc/Views/_ViewImports.cshtml"
using moviemvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5ca8ca3831a42c9557bffa490aa19c026c005e1", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28bd4c806e32c4c1ea23e530e3b3632296aa76a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<moviemvc.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml"
  
    ViewBag.Title = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(119, 10, false);
#line 8 "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(129, 17, true);
            WriteLiteral("</h2>\n<h2>Genre: ");
            EndContext();
            BeginContext(147, 13, false);
#line 9 "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml"
      Write(Model.GenreId);

#line default
#line hidden
            EndContext();
            BeginContext(160, 23, true);
            WriteLiteral("</h2>\n<h2>ReleaseDate: ");
            EndContext();
            BeginContext(184, 15, false);
#line 10 "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml"
            Write(Model.DateAdded);

#line default
#line hidden
            EndContext();
            BeginContext(199, 22, true);
            WriteLiteral("</h2>\n<h2>Date Added: ");
            EndContext();
            BeginContext(222, 17, false);
#line 11 "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml"
           Write(Model.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(239, 17, true);
            WriteLiteral("</h2>\n<h2>Stock: ");
            EndContext();
            BeginContext(257, 19, false);
#line 12 "/Users/jose-ims/Projects/moviemvc/Views/Movies/Details.cshtml"
      Write(Model.NumberInStock);

#line default
#line hidden
            EndContext();
            BeginContext(276, 5, true);
            WriteLiteral("</h2>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<moviemvc.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
