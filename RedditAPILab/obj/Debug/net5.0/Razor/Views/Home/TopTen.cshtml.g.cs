#pragma checksum "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4ae9657444e0e52cf7d0e0a06221872ade32aa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TopTen), @"mvc.1.0.view", @"/Views/Home/TopTen.cshtml")]
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
#line 1 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\_ViewImports.cshtml"
using RedditAPILab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\_ViewImports.cshtml"
using RedditAPILab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ae9657444e0e52cf7d0e0a06221872ade32aa5", @"/Views/Home/TopTen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbe47f31044c1e7a8c21ae1457f53235326ee33", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TopTen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Child>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Posts from r/");
#nullable restore
#line 3 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
            Write(TempData["sub"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 5 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
 for (int i = 2; i < 12; i++)
{
    
    string permalink = "https://www.reddit.com" + Model[i].data.permalink;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 9 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
    Write(i-1);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <a");
            BeginWriteAttribute("href", " href=\"", 198, "\"", 215, 1);
#nullable restore
#line 9 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
WriteAttributeValue("", 205, permalink, 205, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
                                Write(Model[i].data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n    <p>");
#nullable restore
#line 10 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
  Write(Model[i].data.selftext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
     if (Model[i].data.thumbnail != "self")
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
         if (Model[i].data.is_video)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <video width=\"320\" height=\"240\" controls=\"controls\"");
            BeginWriteAttribute("src", " src=\"", 448, "\"", 500, 1);
#nullable restore
#line 15 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
WriteAttributeValue("", 454, Model[i].data.media.reddit_video.fallback_url, 454, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Your browser does not support the HTML5 Video element.\r\n            </video>\r\n            <br />\r\n");
#nullable restore
#line 19 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
        }
        else if (Model[i].data.url.EndsWith(".html"))
        {

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 772, 1);
#nullable restore
#line 26 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
WriteAttributeValue("", 754, Model[i].data.url, 754, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 812, "\"", 842, 1);
#nullable restore
#line 27 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
WriteAttributeValue("", 818, Model[i].data.thumbnail, 818, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:100%;\"");
            BeginWriteAttribute("alt", " alt=\"", 867, "\"", 893, 1);
#nullable restore
#line 27 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
WriteAttributeValue("", 873, Model[i].data.title, 873, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n");
#nullable restore
#line 29 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Number of Upvotes: ");
#nullable restore
#line 31 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
                     Write(Model[i].data.ups);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Author: ");
#nullable restore
#line 32 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"
          Write(Model[i].data.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n");
#nullable restore
#line 34 "D:\Grand Circus\Grand Circus Docs\NET Core\RedditAPILab\RedditAPILab\Views\Home\TopTen.cshtml"



}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Child>> Html { get; private set; }
    }
}
#pragma warning restore 1591
