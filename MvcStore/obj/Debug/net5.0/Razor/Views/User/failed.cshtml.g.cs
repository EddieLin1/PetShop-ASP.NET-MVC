#pragma checksum "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\User\failed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc42e5b918f22b01986ad9769c0e81e3d7c764fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_failed), @"mvc.1.0.view", @"/Views/User/failed.cshtml")]
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
#line 1 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\_ViewImports.cshtml"
using MvcStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\_ViewImports.cshtml"
using MvcStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc42e5b918f22b01986ad9769c0e81e3d7c764fb", @"/Views/User/failed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c01f6375ea150eb393fec0a5e372bc11e335d2d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_failed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcStore.Models.UserModels.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nthis action failed\r\n\r\n");
#nullable restore
#line 5 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\User\failed.cshtml"
Write(Html.DisplayFor(model => Model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\User\failed.cshtml"
Write(Html.DisplayFor(model => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\User\failed.cshtml"
Write(Html.DisplayFor(model => Model.PasswordConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\edric\Desktop\Projects\MvcStore\MvcStore\Views\User\failed.cshtml"
Write(Html.ValidationSummary());

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcStore.Models.UserModels.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
