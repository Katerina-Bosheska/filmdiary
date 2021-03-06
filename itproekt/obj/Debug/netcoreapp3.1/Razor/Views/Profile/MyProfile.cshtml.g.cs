#pragma checksum "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411af87cc4762f326522dfc011eb52db8c609b1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MyProfile), @"mvc.1.0.view", @"/Views/Profile/MyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411af87cc4762f326522dfc011eb52db8c609b1c", @"/Views/Profile/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8541173b5370870b4218c21bf57f63e5b71a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<itproekt.Models.Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
  
    ViewData["Title"] = "MyProfile";
    Layout = "~/Views/Shared/Menu.cshtml";

    var movies = Model.Watched;
    var watched = new List<Movie>();
    if (movies.Count > 3) {
        var index = movies.Count - 1;
        var i = 0;
        while (i < 3) {
            watched.Add(movies.ElementAt(index));
            index -= 1;
            i++;
        }
    } else watched = movies;

    movies = Model.Liked;
    var liked = new List<Movie>();
    if (movies.Count > 3) {
        var index = movies.Count - 1;
        var i = 0;
        while (i < 3) {
            liked.Add(movies.ElementAt(index));
            index -= 1;
            i++;
        }
    } else liked = movies;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">

    <div class=""row"">

        <div class=""col-9 mt-4 pl-4"">

            <div id=""recently-watched"">
                <div>
                    <h6 style=""display: inline-block; font-weight: bolder; "" class=""m-0"">RECENTLY WATCHED</h6>
                    <a href=""/Profile/Watched"" id=""watched"" style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">SEE ALL <span class=""fa fa-chevron-right""></span></a>
                </div>
                <hr class=""mt-2 mb-3"">
                <div class=""row pl-4"">
");
#nullable restore
#line 46 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                     foreach (var movie in watched) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-4 p-0\" style=\"width:273.98px; height:300px;\">\r\n                        <img class=\"movie-img\" style=\"width: 210px; height: 300px; box-shadow: 0 10px 6px -6px black; border-radius: 5px;\"");
            BeginWriteAttribute("src", "\r\n                             src=\"", 1663, "\"", 1712, 1);
#nullable restore
#line 49 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1699, movie.Poster, 1699, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""img-links"" style=""position:absolute; top:32%; left:10%;
                            background-color: black; width:150px; opacity: 0.9; text-align: center; border-radius: 10px; padding:20px 10px;"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1982, "\"", 2025, 2);
            WriteAttributeValue("", 1989, "../Movie/AddToWatchlist?id=", 1989, 27, true);
#nullable restore
#line 52 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2016, movie.ID, 2016, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:white; padding:5px;\" class=\"fa fa-clock link-watchlist\"></a>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 2158, "\"", 2178, 1);
#nullable restore
#line 53 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2169, movie.ID, 2169, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#8965cd; padding:5px;\" class=\"fa fa-heart link-liked\"></a>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 2309, "\"", 2329, 1);
#nullable restore
#line 54 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2320, movie.ID, 2320, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00e68a; padding:5px;\" class=\"fa fa-eye\"></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2438, "\"", 2479, 2);
            WriteAttributeValue("", 2445, "../Movie/MovieDetails?id=", 2445, 25, true);
#nullable restore
#line 55 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2470, movie.ID, 2470, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00CCFF; padding:5px;\" class=\"fa fa-ellipsis-h\"></a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 58 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

            <div id=""recently-liked"" class=""mt-5"">
                <div class=""pt-4"">
                    <h6 style=""display: inline-block; font-weight: bolder; "" class=""m-0"">RECENTLY LIKED</h6>
                    <a href=""/Profile/Likes"" id=""watched"" style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">SEE ALL <span class=""fa fa-chevron-right""></span></a>
                </div>
                <hr class=""mt-2 mb-3"">
                <div class=""row pl-4"">
");
#nullable restore
#line 70 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                     foreach (var movie in liked) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 p-0\" style=\"width:273.98px; height:300px;\">\r\n                            <img class=\"movie-img\" style=\"width: 210px; height: 300px; box-shadow: 0 10px 6px -6px black; border-radius: 5px;\"");
            BeginWriteAttribute("src", "\r\n                                 src=\"", 3536, "\"", 3589, 1);
#nullable restore
#line 73 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3576, movie.Poster, 3576, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""img-links"" style=""position:absolute; top:32%; left:10%;
                            background-color: black; width:150px; opacity: 0.9; text-align: center; border-radius: 10px; padding:20px 10px;"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 3867, "\"", 3910, 2);
            WriteAttributeValue("", 3874, "../Movie/AddToWatchlist?id=", 3874, 27, true);
#nullable restore
#line 76 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3901, movie.ID, 3901, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:white; padding:5px;\" class=\"fa fa-clock link-watchlist\"></a>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 4047, "\"", 4067, 1);
#nullable restore
#line 77 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4058, movie.ID, 4058, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#8965cd; padding:5px;\" class=\"fa fa-heart link-liked\"></a>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 4202, "\"", 4222, 1);
#nullable restore
#line 78 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4213, movie.ID, 4213, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00e68a; padding:5px;\" class=\"fa fa-eye\"></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4335, "\"", 4376, 2);
            WriteAttributeValue("", 4342, "../Movie/MovieDetails?id=", 4342, 25, true);
#nullable restore
#line 79 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4367, movie.ID, 4367, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00CCFF; padding:5px;\" class=\"fa fa-ellipsis-h\"></a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 82 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

            <div id=""recent-reviews"" class=""mt-5"">
                <div class=""review-preview"">
                    <div class=""pt-4"">
                        <h6 style=""display: inline-block; font-weight: bolder; "" class=""m-0"">RECENT REVIEWS</h6>
                        <a href=""/Profile/Reviews"" id=""see-all-reviews"" style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">SEE ALL <span class=""fa fa-chevron-right""></span></a>
                    </div>
                    <hr class=""mt-2 mb-3"">
");
#nullable restore
#line 94 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                     foreach (var review in Model.Reviews) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <img style=\"width:100px; height: 140px; border-radius: 5px;\"");
            BeginWriteAttribute("src", " src=\"", 5441, "\"", 5467, 1);
#nullable restore
#line 97 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 5447, review.Movie.Poster, 5447, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5588, "\"", 5636, 2);
            WriteAttributeValue("", 5595, "../Movie/MovieDetails?id=", 5595, 25, true);
#nullable restore
#line 100 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 5620, review.Movie.ID, 5620, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none; color:black\">\r\n                                    <h3 class=\"review-for-title\">");
#nullable restore
#line 101 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                            Write(review.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"font-weight: normal; font-size: 22px; padding-left: 10px; color:gray;\">");
#nullable restore
#line 101 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                                                                                                                                    Write(review.Movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                </a>\r\n                                <div class=\"jstars\"\r\n                                     data-value=\"");
#nullable restore
#line 104 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                            Write(review.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                     data-total-stars=""5""
                                     data-color=""#00FF99""
                                     data-empty-color=""white""
                                     data-size=""30px"">
                                </div>
                                <p class=""review-text"">");
#nullable restore
#line 110 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                  Write(review.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <a style=""text-decoration: none; font-weight: bold; color:gray""><span class=""fa fa-heart""></span> LIKE REVIEW</a>
                                <p style=""display: inline-block;  padding-left: 5px; font-weight: bold; color: #8965cd"">");
#nullable restore
#line 112 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                                                                                   Write(review.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" likes</p>\r\n                            </div>\r\n                        </div>\r\n                        <hr class=\"mt-2 mb-3\">\r\n");
#nullable restore
#line 116 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <!-- PROFILE MENU -->\r\n        <div class=\"col\">\r\n            <div class=\"row mt-4\" style=\"width: 250px; margin: 0;\">\r\n                <div class=\"col p-0\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 7081, "\"", 7101, 1);
#nullable restore
#line 126 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 7087, Model.Picture, 7087, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height: 100px; border-radius: 10px;\">\r\n                </div>\r\n                <div class=\"col p-0\">\r\n                    <h3>");
#nullable restore
#line 129 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                   Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 130 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                     using (Html.BeginForm("Edit", "Profile")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-outline-dark w-75 mt-4\" type=\"submit\" style=\"height: 32px; font-size: 12px; vertical-align: center\">EDIT PROFILE</button>\r\n");
#nullable restore
#line 132 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"row mt-4\">\r\n                <div class=\"col\" id=\"my-bio\">\r\n                    <p>");
#nullable restore
#line 137 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                  Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <hr>
                </div>
            </div>
            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/Profile/Watched"" id=""your-movies-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Your Movies</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 146 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                            Write(Model.Watched.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>

            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/Profile/Likes"" id=""your-reviews-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Your Likes</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 155 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                            Write(Model.Liked.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>

            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/Profile/Reviews"" id=""your-lists-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Your Reviews</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 164 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                            Write(Model.Reviews.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>

            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/Profile/Watchlist"" id=""your-watchlist-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Watchlist</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 173 "D:\ASP .NET\itproekt\itproekt\Views\Profile\MyProfile.cshtml"
                                                            Write(Model.Watchlist.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>

    </div>

</div>

<script>

    $(document).ready(function () {
        $("".img-links"").css(""display"",""none"");

        $("".movie-img"").hover(function(){
            $(this).addClass(""darken"");
            var tofind = $("".img-links"");
            var imglinks = $(this).parent().find(tofind);
            imglinks.css(""display"", ""inline"");
        }, function (){
            $("".img-links"").css(""display"",""none"");
            $(this).removeClass(""darken"");
        });

        $("".img-links"").hover(function (){
            var tofind = $("".img-links"");
            var imglinks = $(this).parent().find(tofind);
            imglinks.css(""display"", ""inline"");
            tofind = $("".movie-img"");
            $(this).parent().find(tofind).addClass(""darken"");
        }, function (){
            $("".img-links"").css(""display"",""none"");
            $("".movie-img"").removeClass(""darken"");
        });


        $("".link-watc");
            WriteLiteral(@"hlist"").click(function (e) {
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

        $("".link-watch"").click(function (e) {
            e.preventDefault();
            var movieID = $(this).attr(""movie-id"");
            var path = ""../Movie/AddToWatched?id="" + movieID;
            $.get(path, function (data, status) {
                alert(data);
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<itproekt.Models.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
