#pragma checksum "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63cbbddb50a99fcc2b1258b83cfb7f0d689db5a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeProduct_Defautl), @"mvc.1.0.view", @"/Views/Shared/Components/HomeProduct/Defautl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/HomeProduct/Defautl.cshtml", typeof(AspNetCore.Views_Shared_Components_HomeProduct_Defautl))]
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
#line 1 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\_ViewImports.cshtml"
using EvekilApp;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\_ViewImports.cshtml"
using EvekilApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\_ViewImports.cshtml"
using EvekilApp.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 5 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cbbddb50a99fcc2b1258b83cfb7f0d689db5a6", @"/Views/Shared/Components/HomeProduct/Defautl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6b4758b9bf6d39167f0391f52e1fa953c46bd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeProduct_Defautl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Document", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 25, true);
            WriteLiteral("<ul class=\"categories\">\r\n");
            EndContext();
#line 3 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
     foreach (CategoryLanguage category in Model.CategoryLanguages)
    {

#line default
#line hidden
            BeginContext(130, 150, true);
            WriteLiteral("        <div class=\"category-name col-12 p-0 py-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-10 d-flex align-items-center\"><h4>");
            EndContext();
            BeginContext(281, 13, false);
#line 7 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
                                                             Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(294, 219, true);
            WriteLiteral("</h4></div>\r\n                <div class=\"col-2 d-flex align-items-center category-icon\"><i class=\"fas fa-angle-down\"></i></div>\r\n            </div>\r\n        </div>\r\n        <li class=\"sect wow fadeInRight category-item\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 513, "\"", 532, 1);
#line 11 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
WriteAttributeValue("", 518, category.Name, 518, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(533, 196, true);
            WriteLiteral(">\r\n            <article class=\"category\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"mx-auto category-content category-bg\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 729, "\"", 810, 3);
            WriteAttributeValue("", 737, "height:500px;background-image:url(\'images/", 737, 42, true);
#line 15 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
WriteAttributeValue("", 779, category.Category.PhotoPath, 779, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 807, "\');", 807, 3, true);
            EndWriteAttribute();
            BeginContext(811, 58, true);
            WriteLiteral(">\r\n                            <h1 class=\"category-title\">");
            EndContext();
            BeginContext(870, 13, false);
#line 16 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
                                                  Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(883, 130, true);
            WriteLiteral("</h1>\r\n                        </div>\r\n                        <div class=\"category-features\">\r\n                            <ul>\r\n");
            EndContext();
#line 20 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
                                 foreach (SubcategoryLanguage subcategory in Model.SubcategoryLanguages.Where(s => s.Subcategory.CategoryId == category.Id))
                                {

#line default
#line hidden
            BeginContext(1206, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(1288, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4882a83cda4e348da6b9f8e2c42505", async() => {
                BeginContext(1336, 16, false);
#line 23 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
                                                                                  Write(subcategory.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1356, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
#line 25 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
                                }

#line default
#line hidden
            BeginContext(1436, 317, true);
            WriteLiteral(@"                            </ul>
                        </div>
                        <div class="" mx-auto category-text"">
                            <p></p>
                        </div>
                        <div class=""download-button d-flex align-items-center col-lg-12"">
                            ");
            EndContext();
            BeginContext(1753, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db3084c3e274c63bc2e19b7472115e6", async() => {
                BeginContext(1800, 208, true);
                WriteLiteral("\r\n                                <span class=\"circle\">\r\n                                </span>\r\n                                <p>Sənəd nümunələrini <br />buradan yükləyin</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2012, 125, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </article>\r\n        </li>\r\n");
            EndContext();
#line 42 "C:\Users\Admin\source\repos\EvekilApp\EvekilApp\Views\Shared\Components\HomeProduct\Defautl.cshtml"
    }

#line default
#line hidden
            BeginContext(2144, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591