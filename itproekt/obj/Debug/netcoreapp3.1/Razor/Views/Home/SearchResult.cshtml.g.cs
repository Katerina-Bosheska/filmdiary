#pragma checksum "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c57d629e5f946d26e123d7278fbd7fd3fab470"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResult), @"mvc.1.0.view", @"/Views/Home/SearchResult.cshtml")]
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
#line 1 "D:\ASP .NET\itproekt\itproekt\Views\_ViewImports.cshtml"
using itproekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP .NET\itproekt\itproekt\Views\_ViewImports.cshtml"
using itproekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c57d629e5f946d26e123d7278fbd7fd3fab470", @"/Views/Home/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8541173b5370870b4218c21bf57f63e5b71a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<itproekt.ViewModels.ResultsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
  
    ViewData["Title"] = "SearchResult";
    Layout = "~/Views/Shared/Menu.cshtml";

    var total = Model.MovieResults.Count + Model.UserResults.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"p-5\">\r\n        <h6>FOUND ");
#nullable restore
#line 11 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
             Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" MATCHES FOR \"");
#nullable restore
#line 11 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
                                 Write(Model.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h6>\r\n        <hr class=\"mb-3\" />\r\n");
#nullable restore
#line 13 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
         foreach (var item in Model.MovieResults) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-6\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-3\">\r\n                        <img style=\"width:140px; height: 140px; border-radius: 5px;\"");
            BeginWriteAttribute("src", " src=", 567, "", 584, 1);
#nullable restore
#line 17 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 572, item.Poster, 572, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <h3>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 714, "\"", 754, 2);
            WriteAttributeValue("", 721, "../Movie/MovieDetails?id=", 721, 25, true);
#nullable restore
#line 21 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 746, item.ID, 746, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               style=\"text-decoration:none; color:black;\">");
#nullable restore
#line 22 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <span style=\"font-weight: normal; font-size: 20px; padding-left: 10px; color:gray;\">");
#nullable restore
#line 24 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
                                                                                                       Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <h6>Directed by ");
#nullable restore
#line 25 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
                                   Write(item.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p class=\"review-text\">\r\n                            ");
#nullable restore
#line 27 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
                       Write(item.Cast);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <hr style=\"padding-top: 10px;\">\r\n            </div>\r\n");
#nullable restore
#line 33 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
         foreach (var user in Model.UserResults) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img style=\"width:50px; height:50px; display: inline-block; border-radius:10px;\"");
            BeginWriteAttribute("src", " src=", 1464, "", 1482, 1);
#nullable restore
#line 36 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 1469, user.Picture, 1469, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <p style=\"display: inline-block; font-weight: bold; color: #222222; font-size: 14px; padding-left: 2px;\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1622, "\"", 1663, 2);
            WriteAttributeValue("", 1629, "/Profile/Profile?id=", 1629, 20, true);
#nullable restore
#line 38 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 1649, user.Username, 1649, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight:bold; color:black; text-decoration:none\">\r\n                    ");
#nullable restore
#line 39 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
               Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </p>\r\n            <hr style=\"padding-top: 10px; padding-bottom:5px;\">\r\n");
#nullable restore
#line 43 "D:\ASP .NET\itproekt\itproekt\Views\Home\SearchResult.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<itproekt.ViewModels.ResultsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
