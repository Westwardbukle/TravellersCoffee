#pragma checksum "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cebf5b096a82e7454d9de653f4c29abd953c9ee"
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
#line 1 "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\_ViewImports.cshtml"
using Travellers_Coffee.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\_ViewImports.cshtml"
using Travellers_Coffee.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\_ViewImports.cshtml"
using Travellers_Coffee.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cebf5b096a82e7454d9de653f4c29abd953c9ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28706a41d06b5b919ca83d3d0276ab9c7a4431ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Лучшее</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 5 "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\Home\Index.cshtml"
      
        foreach (Coffe cof in Model.FavCoffees)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\Home\Index.cshtml"
       Write(Html.Partial("AllCoffee",cof));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\инет\Desktop\Shop\TravellersCoffee\Travellers Coffee\Views\Home\Index.cshtml"
                                          
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
