#pragma checksum "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53504bde46211bcb36d7f43301cc5ebbe3eabce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnostics_Index), @"mvc.1.0.view", @"/Views/Diagnostics/Index.cshtml")]
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
#line 1 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53504bde46211bcb36d7f43301cc5ebbe3eabce7", @"/Views/Diagnostics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f422aaa09212e40150922039b3abf2a62dc6b201", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Diagnostics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SsoProject.STS.Identity.ViewModels.Diagnostics.DiagnosticsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h3>");
#nullable restore
#line 7 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
Write(Localizer["Claims"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<dl>\r\n");
#nullable restore
#line 9 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
     foreach (var claim in Model.AuthenticateResult.Principal.Claims)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<dt>");
#nullable restore
#line 11 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n\t\t<dd>");
#nullable restore
#line 12 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 13 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n<h3>");
#nullable restore
#line 16 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
Write(Localizer["Properties"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<dl>\r\n");
#nullable restore
#line 18 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
     foreach (var prop in Model.AuthenticateResult.Properties.Items)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<dt>");
#nullable restore
#line 20 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n\t\t<dd>");
#nullable restore
#line 21 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 22 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
 if (Model.Clients.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<h3>");
#nullable restore
#line 27 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
   Write(Localizer["Clients"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t<ul>\r\n");
#nullable restore
#line 29 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
         foreach (var client in Model.Clients)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li>");
#nullable restore
#line 31 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
           Write(client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n");
#nullable restore
#line 34 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Diagnostics\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUrlHelper UrlHelper { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SsoProject.STS.Identity.ViewModels.Diagnostics.DiagnosticsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
