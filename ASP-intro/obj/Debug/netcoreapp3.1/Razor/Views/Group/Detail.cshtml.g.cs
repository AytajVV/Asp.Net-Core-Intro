#pragma checksum "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abb62f056390d1ad62f66d928ac05d678778dd67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Detail), @"mvc.1.0.view", @"/Views/Group/Detail.cshtml")]
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
#line 1 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Detail.cshtml"
using ASP_intro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb62f056390d1ad62f66d928ac05d678778dd67", @"/Views/Group/Detail.cshtml")]
    #nullable restore
    public class Views_Group_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Group>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>");
#nullable restore
#line 4 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Detail.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 5 "C:\Users\Orbit Computers\Desktop\ASP-intro\ASP-intro\Views\Group\Detail.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<h1>gorup/detail/view</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Group> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
