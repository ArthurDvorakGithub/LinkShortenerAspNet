#pragma checksum "C:\Users\Arthur\source\repos\ExampleLinkShortener\ExampleLinkShortener\Views\PanelAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2943e13b41ac1021b22ff39716aeb33eca378d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PanelAdmin_Index), @"mvc.1.0.view", @"/Views/PanelAdmin/Index.cshtml")]
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
#line 1 "C:\Users\Arthur\source\repos\ExampleLinkShortener\ExampleLinkShortener\Views\_ViewImports.cshtml"
using ExampleLinkShortener;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arthur\source\repos\ExampleLinkShortener\ExampleLinkShortener\Views\_ViewImports.cshtml"
using ExampleLinkShortener.DataAccess.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2943e13b41ac1021b22ff39716aeb33eca378d99", @"/Views/PanelAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b0edd7340a4545418f8aa07aab6fbd92e379db", @"/Views/_ViewImports.cshtml")]
    public class Views_PanelAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Arthur\source\repos\ExampleLinkShortener\ExampleLinkShortener\Views\PanelAdmin\Index.cshtml"
   ViewData["Title"] = "Admin panel"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 2 "C:\Users\Arthur\source\repos\ExampleLinkShortener\ExampleLinkShortener\Views\PanelAdmin\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>


<div class=""container px-4"">
    <div class=""row gx-5"">
        <div class=""col"">
            <nav class=""navbar navbar-light bg-light"">
                <div class=""container-fluid"">
                    <a class=""navbar-brand"" href=""#"">Управление пользователями</a>
                </div>
                <div class=""container-fluid"">
                    <a class=""navbar-brand"" href=""#"">Список пользователей</a>
                </div>
                <div class=""container-fluid"">
                    <a class=""navbar-brand"" href=""#"">Управление ролями</a>
                </div>
                <div class=""container-fluid"">
                    <a class=""navbar-brand"" href=""#"">Управление страницами сайта</a>
                </div>

            </nav>
        </div>
        <div class=""col"">
            <div class=""p-3 border bg-light"">Custom column padding</div>
        </div>
    </div>
</div>

");
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
