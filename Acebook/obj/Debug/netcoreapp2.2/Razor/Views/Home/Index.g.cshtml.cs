#pragma checksum "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62178f4f4f43fcee9b406d356aee11c703ad8014"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/_ViewImports.cshtml"
using Acebook;

#line default
#line hidden
#line 2 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/_ViewImports.cshtml"
using Acebook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62178f4f4f43fcee9b406d356aee11c703ad8014", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc9a51b0b0cbcff56f96d393889c25471cfec22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/deletepost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var url = @Url.Action("CreatePost", "Home");
    var urlAddComment = @Url.Action("CreateComment","Home");
    var urlDeletePost = @Url.Action("deletePost", "Home");


#line default
#line hidden
            BeginContext(221, 77, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">News Feed</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(298, 415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62178f4f4f43fcee9b406d356aee11c703ad80145719", async() => {
                BeginContext(332, 374, true);
                WriteLiteral(@"
        <div class=""container"">
            <!-- <label for=""content""><b>Post </b></label> -->
            <input type=""text"" width=30px placeholder=""Add message"" style=""text-align: center"" name=""body"" required>
            <button type=""submit"" class=""btn btn-primary postbtn"">post</button>
            <div class=""clearfix"">
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 312, url, 312, 4, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(713, 61, true);
            WriteLiteral("\r\n\r\n    <div class=\"flex-container justify-content-center\">\r\n");
            EndContext();
#line 24 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
     foreach(var item in ViewData["Posts"] as IEnumerable<Acebook.Models.Post>)
    {
        string dataTarget = "#collapse" + item.Id;
        string divId ="collapse" + item.Id;


#line default
#line hidden
            BeginContext(961, 64, true);
            WriteLiteral("        <div id=\"accordion\">\r\n            <div class=\"card mt-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1025, "", 1037, 1);
#line 30 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1029, item.Id, 1029, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 160, true);
            WriteLiteral(">\r\n                <div class=\"card-header text-center\">\r\n                    <blockquote class=\"blockquote mb-0\">\r\n                        <p class=\"postBody\">");
            EndContext();
            BeginContext(1198, 9, false);
#line 33 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                       Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 34, true);
            WriteLiteral("</p>\r\n                            ");
            EndContext();
            BeginContext(1241, 355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62178f4f4f43fcee9b406d356aee11c703ad80149613", async() => {
                BeginContext(1284, 54, true);
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1338, "", 1353, 1);
#line 35 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1345, item.Id, 1345, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1353, 129, true);
                WriteLiteral(" name=\"id\">\r\n                                <input type=\"submit\" value=\"Delete\">\r\n                                <!-- <a href=\"");
                EndContext();
                BeginContext(1483, 13, false);
#line 37 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                         Write(urlDeletePost);

#line default
#line hidden
                EndContext();
                BeginContext(1496, 93, true);
                WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\" ></span></a> </p> -->\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1596, 70, true);
            WriteLiteral("\r\n                        <footer class=\"blockquote-footer\">Posted at ");
            EndContext();
            BeginContext(1667, 14, false);
#line 39 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                               Write(item.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 140, true);
            WriteLiteral("</footer>\r\n                    </blockquote>\r\n                    <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(1822, 10, false);
#line 41 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                         Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 22, true);
            WriteLiteral(" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 1854, "", 1875, 1);
#line 41 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1869, divId, 1869, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1875, 113, true);
            WriteLiteral(">\r\n                        Comments\r\n                    </button>\r\n                </div>\r\n                 <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 1988, "", 1998, 1);
#line 45 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1992, divId, 1992, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1998, 119, true);
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordion\">\r\n                    <div class=\"card-body\">\r\n");
            EndContext();
#line 47 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                         foreach(var comment in ViewData["Comments"] as IEnumerable<Acebook.Models.Comment>)
                        {
                            if (comment.postId == item.Id)
                                {

#line default
#line hidden
            BeginContext(2349, 325, true);
            WriteLiteral(@"                                    <div class=""list-group"">
                                        <div class=""d-flex w-60 justify-content-between list-group-item list-group-item-action flex-column align-items-start active"">
                                        <h6 class=""mb-1 text-center"" style=""text-align: center"">");
            EndContext();
            BeginContext(2675, 12, false);
#line 53 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                           Write(comment.Body);

#line default
#line hidden
            EndContext();
            BeginContext(2687, 149, true);
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                        <h6 class=\"mb-1\"><small>User name will display here - ");
            EndContext();
            BeginContext(2837, 17, false);
#line 55 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                         Write(comment.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(2854, 105, true);
            WriteLiteral("</small></h6>\r\n                                        <br>\r\n                                    </div>\r\n");
            EndContext();
#line 58 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                }
                        }

#line default
#line hidden
            BeginContext(3021, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3045, 814, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62178f4f4f43fcee9b406d356aee11c703ad801416591", async() => {
                BeginContext(3089, 328, true);
                WriteLiteral(@"
                            <div class=""container"">
                                <!-- <label for=""content""><b>Post </b></label> -->
                                <input type=""text"" placeholder=""comment"" style=""text-align: center"" name=""body"" required>
                                <input type=""hidden"" name=""postId""");
                EndContext();
                BeginWriteAttribute("value", " value=", 3417, "", 3432, 1);
#line 64 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 3424, item.Id, 3424, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3432, 78, true);
                WriteLiteral(" required>\r\n                                <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3510, "", 3529, 1);
#line 65 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 3517, item.UserId, 3517, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3529, 133, true);
                WriteLiteral(" required>\r\n                                <button type=\"submit\" class=\"btn btn-primary postbtn\" data-toggle=\"collapse\" data-target=");
                EndContext();
                BeginContext(3663, 10, false);
#line 66 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                                                    Write(dataTarget);

#line default
#line hidden
                EndContext();
                BeginContext(3673, 179, true);
                WriteLiteral(">Add comment</button>\r\n                                <div class=\"clearfix\">\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 60 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 3059, urlAddComment, 3059, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3859, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 75 "/Users/linna@paddle.com/week_nine/acebook-sharpies/Acebook/Views/Home/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(3958, 589, true);
            WriteLiteral(@"    </div>
    <br />

    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
        <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">Log in to Acebook</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""modal-body"">
            ");
            EndContext();
            BeginContext(4547, 337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62178f4f4f43fcee9b406d356aee11c703ad801421602", async() => {
                BeginContext(4598, 279, true);
                WriteLiteral(@"
                Email: <br>
                <input type=""email"" name=""email""><br><br>
                Password: <br>
                <input type=""password"" name=""password""><br><br>
                <input type =""submit"" value=""Sign In"" class=""btn btn-primary"">
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4884, 66, true);
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n    </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
