#pragma checksum "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f607c743f01286a88ff7e2f7276e139acb132c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\_ViewImports.cshtml"
using PizzaBoxFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\_ViewImports.cshtml"
using PizzaBoxFrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f607c743f01286a88ff7e2f7276e139acb132c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719df44f99a8594e0489ea14bafc99458cefdb0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Ciao!</h1>
    <h2> Welcome to PizzaBox!</h2>
    <p>
        Thank you for choosing PizzaBox! 
        We collectively strive to make sure
        each individual pizza is made to perfection! 
        We cannot wait to service you with our most 
        delicious hand-crafted masterpieces.  
    </p>
");
#nullable restore
#line 15 "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\Home\Index.cshtml"
     if(TempData["SuccessMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"text-success\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\Home\Index.cshtml"
               Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 20 "C:\Users\bldav\revature\P1-PizzaBox\PizzaBox\PizzaBoxFrontEnd\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
