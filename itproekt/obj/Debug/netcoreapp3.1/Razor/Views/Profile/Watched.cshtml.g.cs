#pragma checksum "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21d73e8a4b3387504513141c8e2b0ac326b1232a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Watched), @"mvc.1.0.view", @"/Views/Profile/Watched.cshtml")]
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
#line 1 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
using itproekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21d73e8a4b3387504513141c8e2b0ac326b1232a", @"/Views/Profile/Watched.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8541173b5370870b4218c21bf57f63e5b71a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Watched : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
  
    ViewData["Title"] = "Watched";
    Layout = "~/Views/Shared/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row pb-5\">\r\n\r\n        <div class=\"col-9 mt-4 pl-4\">\r\n            <div>\r\n                <h6 style=\"display: inline-block; font-weight: bolder; \" class=\"m-0\">");
#nullable restore
#line 13 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                                                                                Write(ViewBag.Whose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <span style=\"display:inline-block; color:#00e68a; font-weight: bolder;\r\n                        float: right; border-radius: 5px; margin-right: 50px;\">");
#nullable restore
#line 15 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                                                                          Write(Model.Watched.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <hr class=\"mt-2 mb-3\">\r\n            <div class=\"row pl-4\">\r\n");
#nullable restore
#line 19 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                 foreach (var movie in Model.Watched) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3 p-0 pb-4\">\r\n                        <img class=\"movie-img\" style=\"width: 150px; height: 220px; box-shadow: 0 10px 6px -6px black; border-radius: 5px;\"");
            BeginWriteAttribute("src", "\r\n                             src=\"", 860, "\"", 909, 1);
#nullable restore
#line 22 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
WriteAttributeValue("", 896, movie.Poster, 896, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""img-links"" style=""position:absolute; top:30%; left:12%;
                            background-color: black; width:100px; opacity: 0.9; text-align: center; border-radius: 10px; padding:20px 10px;"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1179, "\"", 1237, 3);
            WriteAttributeValue("", 1186, "../Profile/RemoveFromList?id=", 1186, 29, true);
#nullable restore
#line 25 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
WriteAttributeValue("", 1215, movie.ID, 1215, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1224, "&list=watched", 1224, 13, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:#00e68a; padding:5px;\" class=\"fa fa-trash link-remove\"></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1403, 2);
            WriteAttributeValue("", 1367, "../Movie/AddToWatchlist?id=", 1367, 27, true);
#nullable restore
#line 26 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
WriteAttributeValue("", 1394, movie.ID, 1394, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:white; padding:5px;\" class=\"fa fa-clock link-watchlist\"></a>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 1536, "\"", 1556, 1);
#nullable restore
#line 27 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
WriteAttributeValue("", 1547, movie.ID, 1547, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:#8965cd; padding:5px;\" class=\"fa fa-heart link-liked\"></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1678, "\"", 1719, 2);
            WriteAttributeValue("", 1685, "../Movie/MovieDetails?id=", 1685, 25, true);
#nullable restore
#line 28 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
WriteAttributeValue("", 1710, movie.ID, 1710, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:#00CCFF; padding:5px;\" class=\"fa fa-ellipsis-h\"></a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 31 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n           \r\n\r\n        </div>\r\n\r\n        <!-- PROFILE MENU -->\r\n        <div class=\"col\">\r\n            <div class=\"row mt-4\" style=\"width: 250px; margin: 0;\">\r\n                <div class=\"col p-0\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2127, "\"", 2147, 1);
#nullable restore
#line 41 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
WriteAttributeValue("", 2133, Model.Picture, 2133, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height: 100px; border-radius: 10px;\">\r\n                </div>\r\n                <div class=\"col p-0\">\r\n                    <h3>");
#nullable restore
#line 44 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                   Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 45 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                     using (Html.BeginForm("Edit", "Profile")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-outline-dark w-75 mt-4\" type=\"submit\" style=\"height: 32px; font-size: 12px; vertical-align: center\">EDIT PROFILE</button>\r\n");
#nullable restore
#line 47 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"row mt-4\">\r\n                <div class=\"col\" id=\"my-bio\">\r\n                    <p>");
#nullable restore
#line 52 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
                  Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr>\r\n                </div>\r\n            </div>\r\n\r\n            <!--FILTERING BY GENRE-->\r\n");
#nullable restore
#line 58 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
             if(ViewBag.Whose == "YOUR MOVIES") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div>
                <h6 class=""pb-3"" style=""color:#00e68a"">Filter by genre</h6>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""action"" value=""Action"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""action"">Action</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""adventure"" value=""Adventure"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""adventure"">Adventure</label>
                        </div>
                    </div>
                </div>
                <div c");
            WriteLiteral(@"lass=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""comedy"" value=""Comedy"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""comedy"">Comedy</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""drama"" value=""Drama"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""drama"">Drama</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
          ");
            WriteLiteral(@"                  <input type=""radio"" class=""custom-control-input"" id=""documentary"" value=""Documentary"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""documentary"">Documentary</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""fantasy"" value=""Fantasy"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""fantasy"">Fantasy</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""history"" value=""History"" name=""genr");
            WriteLiteral(@"e"">
                            <label class=""custom-control-label pl-4"" for=""history"">History</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""horror"" value=""Horror"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""horror"">Horror</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""mystery"" value=""Mystery"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""mystery"">Mystery</label>
                     ");
            WriteLiteral(@"   </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""romance"" value=""Romance"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""romance"">Romance</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <div class=""custom-control custom-radio"">
                            <input type=""radio"" class=""custom-control-input"" id=""thriller"" value=""Thriller"" name=""genre"">
                            <label class=""custom-control-label pl-4"" for=""thriller"">Thriller</label>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
               ");
            WriteLiteral(@"     <div class=""col"">
                        <button class=""btn btn-outline-dark w-75 mt-4"" id=""filterbtn"" style=""height: 32px; font-size: 12px; vertical-align: center"">FILTER</button>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 155 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watched.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

    </div>
        <script>

            $(document).ready(function () {

                $("".img-links"").css(""display"", ""none"");

                $("".movie-img"").hover(function () {
                    $(this).addClass(""darken"");
                    var tofind = $("".img-links"");
                    var imglinks = $(this).parent().find(tofind);
                    imglinks.css(""display"", ""inline"");
                }, function () {
                    $("".img-links"").css(""display"", ""none"");
                    $(this).removeClass(""darken"");
                });

                $("".img-links"").hover(function () {
                    var tofind = $("".img-links"");
                    var imglinks = $(this).parent().find(tofind);
                    imglinks.css(""display"", ""inline"");
                    tofind = $("".movie-img"");
                    $(this).parent().find(tofind).addClass(""darken"");
                }, function () {
                    $("".img-links"").css(""di");
            WriteLiteral(@"splay"", ""none"");
                    $("".movie-img"").removeClass(""darken"");
                });


                $("".link-watchlist"").click(function (e) {
                    e.preventDefault();
                    var path = $(this).attr(""href"");
                    $.get(path, function (data, status) {
                        alert(data);
                    });
                });

                $("".link-liked"").click(function (e) {
                    e.preventDefault();
                    var movieID = $(this).attr(""movie-id"");
                    var path = ""../Movie/AddToLiked?id="" + movieID;
                    $.get(path, function (data, status) {
                        alert(data);
                    });
                });

                $("".link-remove"").click(function (e) {
                    e.preventDefault();
                    var toDelete = $(this).parent().parent();
                    var path = $(this).attr(""href"");
                    $.get(path, funct");
            WriteLiteral(@"ion (data, status) {
                        toDelete.css(""display"", ""none"");
                        alert(data);
                    });
                });

                $(""#filterbtn"").click(function (e) {

                    e.preventDefault();  
                    var selectedgenre = $(""input[name='genre']:checked"").val();
                    window.location.href = ""/Profile/FilterByGenre?genre="" + selectedgenre + ""&list=watched"";
                });

            });
        </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591