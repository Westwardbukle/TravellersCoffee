#pragma checksum "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\Shared\AllCoffee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "defea981b28982491d42a44b26a384613386b2b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCoffee), @"mvc.1.0.view", @"/Views/Shared/AllCoffee.cshtml")]
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
#line 1 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\_ViewImports.cshtml"
using Travellers_Coffee.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\_ViewImports.cshtml"
using Travellers_Coffee.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"defea981b28982491d42a44b26a384613386b2b5", @"/Views/Shared/AllCoffee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee302827b1cb241a0462dc2fc6361b96cfe2c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCoffee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coffe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 74, "\"", 90, 1);
#nullable restore
#line 6 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\Shared\AllCoffee.cshtml"
WriteAttributeValue("", 80, Model.img, 80, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 91, "\"", 108, 1);
#nullable restore
#line 6 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\Shared\AllCoffee.cshtml"
WriteAttributeValue("", 97, Model.name, 97, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <h2>Товар: ");
#nullable restore
#line 7 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\Shared\AllCoffee.cshtml"
          Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>");
#nullable restore
#line 8 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\Shared\AllCoffee.cshtml"
  Write(Model.shortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Цена: ");
#nullable restore
#line 9 "C:\Users\sens4\Desktop\Travellers Coffee\Travellers Coffee\Views\Shared\AllCoffee.cshtml"
        Write(Model.price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><a class=\"btn btn-warning href=\"#\" > Подробнее </a> </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coffe> Html { get; private set; }
    }
}
#pragma warning restore 1591