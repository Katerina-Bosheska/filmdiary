#pragma checksum "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16ed65add4a0a566054ee1afa4dd02853dae281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Edit), @"mvc.1.0.view", @"/Views/Profile/Edit.cshtml")]
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
#nullable restore
#line 1 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
using itproekt.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16ed65add4a0a566054ee1afa4dd02853dae281", @"/Views/Profile/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8541173b5370870b4218c21bf57f63e5b71a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/Menu.cshtml";

    var newmodel = new EditProfileViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"content mt-5 p-3 pb-5\">\r\n\r\n        <h3>Edit Your Profile</h3>\r\n        <hr>\r\n\r\n");
#nullable restore
#line 16 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
         using (Html.BeginForm("ApplyEdit", "Profile")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"form-group\">\r\n                <h6>New Username</h6>\r\n                ");
#nullable restore
#line 21 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Username, new { value = @Model.Username, style = "width:100%;", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <br><br>\r\n\r\n            <div class=\"form-group\">\r\n                <h6>Update your bio</h6>\r\n                ");
#nullable restore
#line 28 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Bio, new { style = "width:500px;", value = Model.Bio, rows = "5", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <br>\r\n\r\n            <div class=\"form-group\">\r\n                <h6>Update your bio</h6>\r\n                ");
#nullable restore
#line 35 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Picture, new { style = "width:500px;", value = Model.Picture, rows = "5", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <button class=""btn"" style=""color:white; margin-top: 30px; background-color: #6f42c1;"" id=""save-btn"">
                Save changes
            </button>

        </div>

        <!--
        <div class=""col"">
            <h6>Change your profile picture</h6>
            <br />
            <div class=""row"">
                <div class=""col"">
                    <a href=""#"" id=""changepic"">
                        <img id=""pic"" name=""Picture"" src=");
#nullable restore
#line 51 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"
                                                    Write(Model.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" style=""width:150px; height:150px; opacity:0.7; border-radius: 10px;"">
                        <span class=""fa fa-plus"" style=""position:absolute; top:35%; left:15%; font-size: 50px; color:white;""></span>
                    </a>
                </div>
            </div>
        </div>
    -->
    </div>
");
#nullable restore
#line 59 "D:\ASP .NET\itproekt\itproekt\Views\Profile\Edit.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>


    <script>

        $(document).ready(function () {

            $(""#changepic"").click(function (e) {

                e.preventDefault();
                var newsrc = window.prompt(""Post the url of your picture"");
                $(""#pic"").attr(""src"", newsrc);
            });

        });

    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
