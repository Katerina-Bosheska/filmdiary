#pragma checksum "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9658245c38397f50d01984d9dc639f31d02a0e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Profile), @"mvc.1.0.view", @"/Views/Profile/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9658245c38397f50d01984d9dc639f31d02a0e1", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8541173b5370870b4218c21bf57f63e5b71a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<itproekt.Models.Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
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
                    <a");
            BeginWriteAttribute("href", " href=\"", 1043, "\"", 1087, 2);
            WriteAttributeValue("", 1050, "/Profile/WatchedBy?id=", 1050, 22, true);
#nullable restore
#line 41 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 1072, Model.Username, 1072, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""watched"" style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">SEE ALL <span class=""fa fa-chevron-right""></span></a>
                </div>
                <hr class=""mt-2 mb-3"">
                <div class=""row pl-4"">
");
#nullable restore
#line 46 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                     foreach (var movie in watched) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 p-0\" style=\"width:273.98px; height:300px;\">\r\n                            <img class=\"movie-img\" style=\"width: 210px; height: 300px; box-shadow: 0 10px 6px -6px black; border-radius: 5px;\"");
            BeginWriteAttribute("src", "\r\n                                 src=\"", 1690, "\"", 1743, 1);
#nullable restore
#line 49 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 1730, movie.Poster, 1730, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""img-links"" style=""position:absolute; top:32%; left:10%;
                            background-color: black; width:150px; opacity: 0.9; text-align: center; border-radius: 10px; padding:20px 10px;"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 2021, "\"", 2064, 2);
            WriteAttributeValue("", 2028, "../Movie/AddToWatchlist?id=", 2028, 27, true);
#nullable restore
#line 52 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 2055, movie.ID, 2055, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:white; padding:5px;\" class=\"fa fa-clock link-watchlist\"></a>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 2201, "\"", 2221, 1);
#nullable restore
#line 53 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 2212, movie.ID, 2212, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#8965cd; padding:5px;\" class=\"fa fa-heart link-liked\"></a>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 2356, "\"", 2376, 1);
#nullable restore
#line 54 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 2367, movie.ID, 2367, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00e68a; padding:5px;\" class=\"fa fa-eye\"></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2489, "\"", 2530, 2);
            WriteAttributeValue("", 2496, "../Movie/MovieDetails?id=", 2496, 25, true);
#nullable restore
#line 55 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 2521, movie.ID, 2521, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00CCFF; padding:5px;\" class=\"fa fa-ellipsis-h\"></a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 58 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

            <div id=""recently-liked"" class=""mt-5"">
                <div class=""pt-4"">
                    <h6 style=""display: inline-block; font-weight: bolder; "" class=""m-0"">RECENTLY LIKED</h6>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2973, "\"", 3015, 2);
            WriteAttributeValue("", 2980, "/Profile/LikesBy?id=", 2980, 20, true);
#nullable restore
#line 65 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 3000, Model.Username, 3000, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""watched"" style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">SEE ALL <span class=""fa fa-chevron-right""></span></a>
                </div>
                <hr class=""mt-2 mb-3"">
                <div class=""row pl-4"">
");
#nullable restore
#line 70 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                     foreach (var movie in liked) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 p-0\" style=\"width:273.98px; height:300px;\">\r\n                            <img class=\"movie-img\" style=\"width: 210px; height: 300px; box-shadow: 0 10px 6px -6px black; border-radius: 5px;\"");
            BeginWriteAttribute("src", "\r\n                                 src=\"", 3616, "\"", 3669, 1);
#nullable restore
#line 73 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 3656, movie.Poster, 3656, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""img-links"" style=""position:absolute; top:32%; left:10%;
                            background-color: black; width:150px; opacity: 0.9; text-align: center; border-radius: 10px; padding:20px 10px;"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 3947, "\"", 3990, 2);
            WriteAttributeValue("", 3954, "../Movie/AddToWatchlist?id=", 3954, 27, true);
#nullable restore
#line 76 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 3981, movie.ID, 3981, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:white; padding:5px;\" class=\"fa fa-clock link-watchlist\"></a>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 4127, "\"", 4147, 1);
#nullable restore
#line 77 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 4138, movie.ID, 4138, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#8965cd; padding:5px;\" class=\"fa fa-heart link-liked\"></a>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("movie-id", " movie-id=\"", 4282, "\"", 4302, 1);
#nullable restore
#line 78 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 4293, movie.ID, 4293, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00e68a; padding:5px;\" class=\"fa fa-eye\"></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4415, "\"", 4456, 2);
            WriteAttributeValue("", 4422, "../Movie/MovieDetails?id=", 4422, 25, true);
#nullable restore
#line 79 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 4447, movie.ID, 4447, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 30px; color:#00CCFF; padding:5px;\" class=\"fa fa-ellipsis-h\"></a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 82 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
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
                        <a");
            BeginWriteAttribute("href", " href=\"", 4957, "\"", 5001, 2);
            WriteAttributeValue("", 4964, "/Profile/ReviewsBy?id=", 4964, 22, true);
#nullable restore
#line 90 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 4986, Model.Username, 4986, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""see-all-reviews"" style=""display:inline-block; color:#00e68a; font-weight: bolder;
                        float: right; border-radius: 5px; margin-right: 50px;"">SEE ALL <span class=""fa fa-chevron-right""></span></a>
                    </div>
                    <hr class=""mt-2 mb-3"">
");
#nullable restore
#line 94 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                     foreach (var review in Model.Reviews) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <img style=\"width:100px; height: 140px; border-radius: 5px;\"");
            BeginWriteAttribute("src", " src=\"", 5542, "\"", 5568, 1);
#nullable restore
#line 97 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 5548, review.Movie.Poster, 5548, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5689, "\"", 5737, 2);
            WriteAttributeValue("", 5696, "../Movie/MovieDetails?id=", 5696, 25, true);
#nullable restore
#line 100 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 5721, review.Movie.ID, 5721, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none; color:black\">\r\n                                    <h3 class=\"review-for-title\">");
#nullable restore
#line 101 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                            Write(review.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"font-weight: normal; font-size: 22px; padding-left: 10px; color:gray;\">");
#nullable restore
#line 101 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                                                                                                                                    Write(review.Movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                </a>\r\n                                <div class=\"jstars\"\r\n                                     data-value=\"");
#nullable restore
#line 104 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
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
#line 110 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                  Write(review.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a href=\"#\"");
            BeginWriteAttribute("reviewId", " reviewId=\"", 6540, "\"", 6561, 1);
#nullable restore
#line 111 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 6551, review.ID, 6551, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"like-review\" style=\"text-decoration: none; font-weight: bold; color:gray\"><span class=\"fa fa-heart\"></span> LIKE REVIEW</a>\r\n                                <p");
            BeginWriteAttribute("id", " id=\"", 6729, "\"", 6744, 1);
#nullable restore
#line 112 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 6734, review.ID, 6734, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: inline-block; padding-left: 5px; font-weight: bold; color: #8965cd\">");
#nullable restore
#line 112 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                                                                                                  Write(review.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" likes</p>\r\n                            </div>\r\n                        </div>\r\n                        <hr class=\"mt-2 mb-3\">\r\n");
#nullable restore
#line 116 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <!-- PROFILE MENU -->\r\n        <div class=\"col\">\r\n            <div class=\"row mt-4\" style=\"width: 250px; margin: 0;\">\r\n                <div class=\"col p-0\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 7248, "\"", 7268, 1);
#nullable restore
#line 126 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 7254, Model.Picture, 7254, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height: 100px; border-radius: 10px;\">\r\n                </div>\r\n                <div class=\"col p-0\">\r\n                    <h3>");
#nullable restore
#line 129 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                   Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mt-4\">\r\n                <div class=\"col\" id=\"my-bio\">\r\n                    <p>");
#nullable restore
#line 134 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                  Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mt-2\">\r\n                <div class=\"col\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7768, "\"", 7812, 2);
            WriteAttributeValue("", 7775, "/Profile/WatchedBy?id=", 7775, 22, true);
#nullable restore
#line 140 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 7797, Model.Username, 7797, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""your-movies-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Movies</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 143 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                            Write(Model.Watched.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row mt-2\">\r\n                <div class=\"col\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8246, "\"", 8288, 2);
            WriteAttributeValue("", 8253, "/Profile/LikesBy?id=", 8253, 20, true);
#nullable restore
#line 149 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 8273, Model.Username, 8273, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""your-reviews-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Likes</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 152 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                            Write(Model.Liked.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row mt-2\">\r\n                <div class=\"col\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8720, "\"", 8764, 2);
            WriteAttributeValue("", 8727, "/Profile/ReviewsBy?id=", 8727, 22, true);
#nullable restore
#line 158 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 8749, Model.Username, 8749, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""your-lists-link"" style=""color:black; font-weight: bold; text-decoration: none;"">Reviews</a>
                </div>
                <div class=""col"" style=""text-align: right; margin-right:10px;"">
                    <p style=""color: #00e68a; font-weight: bold"">");
#nullable restore
#line 161 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Profile.cshtml"
                                                            Write(Model.Reviews.Count);

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

        $("".like-review"").click(function (e) {
            e.preventDefault();
            var path = ""/Movie/LikeReview?reviewid="" + $(this).attr(""reviewId"");
            var id = ""#");
            WriteLiteral(@""" + $(this).attr(""reviewId"");
            var likes = parseInt($(id).text()) + 1;
            var newlikes = likes + "" likes"";
            $.get(path, function (data, status) {
                $(id).text(newlikes);
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