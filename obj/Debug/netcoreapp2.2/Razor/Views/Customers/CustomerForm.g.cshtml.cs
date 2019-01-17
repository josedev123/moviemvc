#pragma checksum "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcd03d443a01c97581782dc10d33c5f4a6ea24c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerForm), @"mvc.1.0.view", @"/Views/Customers/CustomerForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/CustomerForm.cshtml", typeof(AspNetCore.Views_Customers_CustomerForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcd03d443a01c97581782dc10d33c5f4a6ea24c3", @"/Views/Customers/CustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28bd4c806e32c4c1ea23e530e3b3632296aa76a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<moviemvc.ViewModels.CustomerFormViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 23, true);
            WriteLiteral("\n<h2>New Custmer</h2>\n\n");
            EndContext();
#line 9 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
 using (@Html.BeginForm("Save", "Customers"))
{

#line default
#line hidden
            BeginContext(172, 37, true);
            WriteLiteral("    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(210, 35, false);
#line 12 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(245, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(255, 70, false);
#line 13 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(325, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(338, 90, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label for=\"Birthdate\">Date of Birth</label>\n        ");
            EndContext();
            BeginContext(429, 75, false);
#line 18 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Birthdate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(504, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(523, 121, true);
            WriteLiteral("        <div class=\"form-group\">\n            <p></p> \n    <select name=\"Customer.MembershipTypeId\" class=\"form-control\">\n");
            EndContext();
#line 26 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
     foreach (var memtype in Model.MembershipTypes)
{
    if(@memtype.Id == @Model.Customer.MembershipTypeId) {

#line default
#line hidden
            BeginContext(756, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(760, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd03d443a01c97581782dc10d33c5f4a6ea24c35904", async() => {
                BeginContext(809, 12, false);
#line 29 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
                                               Write(memtype.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 29 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
       WriteLiteral(memtype.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(830, 4, true);
            WriteLiteral("   \n");
            EndContext();
#line 30 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"

    } else {

#line default
#line hidden
            BeginContext(848, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(860, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd03d443a01c97581782dc10d33c5f4a6ea24c38090", async() => {
                BeginContext(889, 12, false);
#line 32 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
                                   Write(memtype.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 32 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
               WriteLiteral(memtype.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(910, 4, true);
            WriteLiteral("   \n");
            EndContext();
#line 33 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"

    }
} 

#line default
#line hidden
            BeginContext(924, 30, true);
            WriteLiteral("    </select>\n    \n    </div>\n");
            EndContext();
            BeginContext(957, 34, false);
#line 41 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"
Write(Html.HiddenFor(m => m.Customer.Id));

#line default
#line hidden
            EndContext();
            BeginContext(993, 68, true);
            WriteLiteral("<button type=\"submit\" class=\"btn btn-primary\">Add Customer</button>\n");
            EndContext();
#line 44 "/Users/jose-ims/Projects/moviemvc/Views/Customers/CustomerForm.cshtml"

}

#line default
#line hidden
            BeginContext(1064, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<moviemvc.ViewModels.CustomerFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591