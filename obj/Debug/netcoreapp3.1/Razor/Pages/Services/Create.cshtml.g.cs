#pragma checksum "C:\Users\peter\source\repos\GlimmerAuto\Pages\Services\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3c21d466e859f6d92e571be14552e16ccbefa2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GlimmerAuto.Pages.Services.Pages_Services_Create), @"mvc.1.0.razor-page", @"/Pages/Services/Create.cshtml")]
namespace GlimmerAuto.Pages.Services
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
#line 1 "C:\Users\peter\source\repos\GlimmerAuto\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peter\source\repos\GlimmerAuto\Pages\_ViewImports.cshtml"
using GlimmerAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\peter\source\repos\GlimmerAuto\Pages\_ViewImports.cshtml"
using GlimmerAuto.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3c21d466e859f6d92e571be14552e16ccbefa2a", @"/Pages/Services/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7007fc142f9827f37e4f9fed4095d769ea572c00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Services_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\peter\source\repos\GlimmerAuto\Pages\Services\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GlimmerAuto.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GlimmerAuto.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GlimmerAuto.CreateModel>)PageContext?.ViewData;
        public GlimmerAuto.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
