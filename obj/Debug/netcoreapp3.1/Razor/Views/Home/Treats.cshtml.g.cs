#pragma checksum "D:\School\module6-backend-foundations\lesson7-authentication\secfromscratch\Views\Home\Treats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f5896af0e292d4bb3e315e128c7488e4263ba33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Treats), @"mvc.1.0.view", @"/Views/Home/Treats.cshtml")]
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
#line 1 "D:\School\module6-backend-foundations\lesson7-authentication\secfromscratch\Views\_ViewImports.cshtml"
using secfromscratch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\School\module6-backend-foundations\lesson7-authentication\secfromscratch\Views\_ViewImports.cshtml"
using secfromscratch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f5896af0e292d4bb3e315e128c7488e4263ba33", @"/Views/Home/Treats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b242342654c0571be3f4de7fe952f03e67279ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Treats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<secfromscratch.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\School\module6-backend-foundations\lesson7-authentication\secfromscratch\Views\Home\Treats.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>You are a real user! Here is a treat!</h1>\r\n<img src=\"https://c4.staticflickr.com/6/5207/5300208149_fe4473ea4e_o.jpg\" width=\"600px\">");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<secfromscratch.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
