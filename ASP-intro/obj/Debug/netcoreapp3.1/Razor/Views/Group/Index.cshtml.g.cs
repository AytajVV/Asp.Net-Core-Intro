#pragma checksum "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4c0c64220233b0a1d5c2f30cc1fec5fd4b45039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Index), @"mvc.1.0.view", @"/Views/Group/Index.cshtml")]
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
#line 1 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Index.cshtml"
using ASP_intro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4c0c64220233b0a1d5c2f30cc1fec5fd4b45039", @"/Views/Group/Index.cshtml")]
    #nullable restore
    public class Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Group>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("         <p>Id=");
#nullable restore
#line 6 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Index.cshtml"
          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n         <p>Name=");
#nullable restore
#line 7 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Index.cshtml"
            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n         <hr />\n");
#nullable restore
#line 9 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<h1>group/Index/view</h1>\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Group>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
