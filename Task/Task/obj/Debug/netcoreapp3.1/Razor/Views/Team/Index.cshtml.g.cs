#pragma checksum "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266e315eddb55bfd092ebe9d5b03328b76bfb702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 1 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\_ViewImports.cshtml"
using Task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"266e315eddb55bfd092ebe9d5b03328b76bfb702", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e979a2d1a7db1d0f09cb1f2b8d7dc01a705f4fa0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Member>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  
<!-- ======= Team Section ======= -->
<section id=""team"" class=""team section-bg"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""section-title"">
            <h2>Team</h2>
            <h3>Our Hardworking <span>Team</span></h3>
            <p>Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.</p>
        </div>

        <div class=""row"">

");
#nullable restore
#line 15 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
             foreach (var member in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 d-flex align-items-stretch\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n                    <div class=\"member\">\r\n                        <div class=\"member-img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "266e315eddb55bfd092ebe9d5b03328b76bfb7024543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 766, "~/assets/img/team/", 766, 18, true);
#nullable restore
#line 20 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 784, member.BgImg, 784, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"social\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 910, "\"", 917, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 921, "\"", 942, 1);
#nullable restore
#line 22 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
WriteAttributeValue("", 929, member.Icon1, 929, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 988, "\"", 995, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 999, "\"", 1020, 1);
#nullable restore
#line 23 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
WriteAttributeValue("", 1007, member.Icon2, 1007, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1073, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1077, "\"", 1098, 1);
#nullable restore
#line 24 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
WriteAttributeValue("", 1085, member.Icon3, 1085, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1144, "\"", 1151, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1155, "\"", 1176, 1);
#nullable restore
#line 25 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
WriteAttributeValue("", 1163, member.Icon4, 1163, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"member-info\">\r\n                            <h4>");
#nullable restore
#line 29 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
                           Write(member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <span>");
#nullable restore
#line 30 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
                             Write(member.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\SONY\Desktop\4-3-23\Task\Task\Views\Team\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Team Section -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Member>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591