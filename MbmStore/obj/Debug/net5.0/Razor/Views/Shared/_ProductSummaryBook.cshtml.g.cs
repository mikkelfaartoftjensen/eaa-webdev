#pragma checksum "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d854c8ada30bb756b9343b2a39c794c3e3d39378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSummaryBook), @"mvc.1.0.view", @"/Views/Shared/_ProductSummaryBook.cshtml")]
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
#line 2 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
using MbmStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d854c8ada30bb756b9343b2a39c794c3e3d39378", @"/Views/Shared/_ProductSummaryBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9274a51a748ad41e7d8c3bcb0b7e4f9470b5e19", @"/_ViewImports.cshtml")]
    public class Views_Shared__ProductSummaryBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 144, "\"", 173, 2);
            WriteAttributeValue("", 150, "/Images/", 150, 8, true);
#nullable restore
#line 6 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
WriteAttributeValue("", 158, Model.ImageUrl, 158, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 174, "\"", 192, 1);
#nullable restore
#line 6 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
WriteAttributeValue("", 180, Model.Title, 180, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\" />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong>Title:</strong> ");
#nullable restore
#line 9 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Author:</strong> ");
#nullable restore
#line 10 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Price:</strong> ");
#nullable restore
#line 11 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Publisher:</strong> ");
#nullable restore
#line 12 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                               Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 12 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                                                 Write(Model.Published);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br />\r\n        <strong>ISBN:</strong> ");
#nullable restore
#line 13 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                          Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> <br />\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 16 "G:\Shared drives\A DIFENTO - MAIN\studie\mandatory 2\mbm_store_jes_solution\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
Write(await Html.PartialAsync("_AddToCartButton", (Product)Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
