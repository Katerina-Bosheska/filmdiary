#pragma checksum "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043003a24b54461261efd83e483e30d90862031e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Watchlist), @"mvc.1.0.view", @"/Views/Profile/Watchlist.cshtml")]
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
#line 1 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
using itproekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043003a24b54461261efd83e483e30d90862031e", @"/Views/Profile/Watchlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8541173b5370870b4218c21bf57f63e5b71a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Watchlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
  
    ViewData["Title"] = "Watchlist";
    Layout = "~/Views/Shared/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row pb-5"">

    <div class=""col-9 mt-4 pl-4"">
        <div>
            <h6 style=""display: inline-block; font-weight: bolder; "" class=""m-0"">YOUR WATCHLIST</h6>
            <span style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">");
#nullable restore
#line 15 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                                                                          Write(Model.Watchlist.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <hr class=\"mt-2 mb-3\">\r\n                    <div class=\"row pl-4\">\r\n");
#nullable restore
#line 19 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                         foreach (var movie in Model.Watchlist) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-3 p-0 pb-4\">\r\n                                <img class=\"movie-img\" style=\"width: 150px; height: 220px; box-shadow: 0 10px 6px -6px black; border-radius: 5px;\"");
            BeginWriteAttribute("src", "\r\n                                     src=\"", 894, "\"", 951, 1);
#nullable restore
#line 22 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
WriteAttributeValue("", 938, movie.Poster, 938, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""img-links"" style=""position:absolute; top:30%; left:12%;
                            background-color: black; width:100px; opacity: 0.9; text-align: center; border-radius: 10px; padding:20px 10px;"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1237, "\"", 1297, 3);
            WriteAttributeValue("", 1244, "../Profile/RemoveFromList?id=", 1244, 29, true);
#nullable restore
#line 25 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
WriteAttributeValue("", 1273, movie.ID, 1273, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1282, "&list=watchlist", 1282, 15, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:white; padding:5px;\" class=\"fa fa-trash link-remove\"></a>\r\n                                    <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 1435, "\"", 1455, 1);
#nullable restore
#line 26 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
WriteAttributeValue("", 1446, movie.ID, 1446, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:#8965cd; padding:5px;\" class=\"fa fa-heart link-liked\"></a>\r\n                                    <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 1594, "\"", 1614, 1);
#nullable restore
#line 27 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
WriteAttributeValue("", 1605, movie.ID, 1605, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:#00e68a; padding:5px;\" class=\"fa fa-eye link-watch\"></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1742, "\"", 1783, 2);
            WriteAttributeValue("", 1749, "../Movie/MovieDetails?id=", 1749, 25, true);
#nullable restore
#line 28 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
WriteAttributeValue("", 1774, movie.ID, 1774, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; color:#00CCFF; padding:5px;\" class=\"fa fa-ellipsis-h\"></a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 31 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>


                </div>

                <!-- PROFILE MENU -->
                <div class=""col"">
                    <div class=""row mt-4"" style=""width: 250px; margin: 0;"">
                        <div class=""col p-0"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 2260, "\"", 2280, 1);
#nullable restore
#line 41 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
WriteAttributeValue("", 2266, Model.Picture, 2266, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height: 100px; border-radius: 10px;\">\r\n                        </div>\r\n                        <div class=\"col p-0\">\r\n                            <h3>");
#nullable restore
#line 44 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 45 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                             using (Html.BeginForm("Edit", "Profile")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-outline-dark w-75 mt-4\" type=\"submit\" style=\"height: 32px; font-size: 12px; vertical-align: center\">EDIT PROFILE</button>\r\n");
#nullable restore
#line 47 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"row mt-4\">\r\n                        <div class=\"col\" id=\"my-bio\">\r\n                            <p>");
#nullable restore
#line 52 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Watchlist.cshtml"
                          Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <hr>
                        </div>
                    </div>

                    <!--FILTERING BY GENRE-->
                    <div>
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
                                    <input type=""radio"" class=""custom-control-inpu");
            WriteLiteral(@"t"" id=""adventure"" value=""Adventure"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""adventure"">Adventure</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
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
                                    <input type=""radio"" class=""custom-co");
            WriteLiteral(@"ntrol-input"" id=""drama"" value=""Drama"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""drama"">Drama</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <div class=""custom-control custom-radio"">
                                    <input type=""radio"" class=""custom-control-input"" id=""documentary"" value=""Documentary"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""documentary"">Documentary</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <div class=""custom-control custom-radio"">
                                    <input type=""radio"" cl");
            WriteLiteral(@"ass=""custom-control-input"" id=""fantasy"" value=""Fantasy"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""fantasy"">Fantasy</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <div class=""custom-control custom-radio"">
                                    <input type=""radio"" class=""custom-control-input"" id=""history"" value=""History"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""history"">History</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <div class=""custom-control custom-radio"">
                                    <input type=""rad");
            WriteLiteral(@"io"" class=""custom-control-input"" id=""horror"" value=""Horror"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""horror"">Horror</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <div class=""custom-control custom-radio"">
                                    <input type=""radio"" class=""custom-control-input"" id=""mystery"" value=""Mystery"" name=""genre"">
                                    <label class=""custom-control-label pl-4"" for=""mystery"">Mystery</label>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <div class=""custom-control custom-radio"">
                                    <input type=""r");
            WriteLiteral(@"adio"" class=""custom-control-input"" id=""romance"" value=""Romance"" name=""genre"">
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
                            <div class=""col"">
                                <button class=""btn btn-outline-dark w-75 mt-4"" id=""filterbtn"" style=""height: 32px; ");
            WriteLiteral(@"font-size: 12px; vertical-align: center"">FILTER</button>
                            </div>
                        </div>
                    </div>

                </div>

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
                   ");
            WriteLiteral(@" tofind = $("".movie-img"");
                    $(this).parent().find(tofind).addClass(""darken"");
                }, function () {
                    $("".img-links"").css(""display"", ""none"");
                    $("".movie-img"").removeClass(""darken"");
                });


                $("".link-watchlist"").click(function (e) {
                    e.preventDefault();
                    var path = $(this).attr(""href"");
                    $.get(path, function (data, status) {
                        alert(data);
                    });
                });

                $("".link-watch"").click(function (e) {
                    e.preventDefault();
                    var toRemove = $(this).parent().parent();
                    var movieID = $(this).attr(""movie-id"");
                    var path = ""../Movie/AddToWatched?id="" + movieID;
                    $.get(path, function (data, status) {
                        alert(data);
                        toRemove.css(""display"", ""none"");
");
            WriteLiteral(@"                    });
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
                    $.get(path, function (data, status) {
                        toDelete.css(""display"", ""none"");
                        alert(data);
                    });
                });

                $(""#filterbtn"").click(function (e) {

                    e.preventDefault();
                    var selectedgenre = $(""input[name='genre']:checked"").val();
          ");
            WriteLiteral("          window.location.href = \"/Profile/FilterByGenre?genre=\" + selectedgenre + \"&list=watchlist\";\r\n                });\r\n\r\n            });\r\n            </script>\r\n");
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
