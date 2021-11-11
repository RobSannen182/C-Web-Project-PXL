#pragma checksum "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703462152e461e2669fa084b458ac1efbc558f31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MVCHogeschoolPXL.Pages.Handboek.Views_Handboek_Details), @"mvc.1.0.view", @"/Views/Handboek/Details.cshtml")]
namespace MVCHogeschoolPXL.Pages.Handboek
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
#line 1 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\_ViewImports.cshtml"
using MVCHogeschoolPXL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\_ViewImports.cshtml"
using MVCHogeschoolPXL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703462152e461e2669fa084b458ac1efbc558f31", @"/Views/Handboek/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d3ea873dddd6fadcbe45635fbc889d25ed5950", @"/Views/_ViewImports.cshtml")]
    public class Views_Handboek_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCHogeschoolPXL.Models.Handboek>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info w-50 mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning w-50 mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var fileExist = Convert.ToBoolean(ViewBag.FileExist);
    var imgLink = $"/images/{ Model.Afbeelding }";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card w-50 text-center border-info mx-auto mt-5"">
    <div class=""card-header border-info"">
        <h1 class=""text-primary"">Details</h1>
    </div>
    <div class=""card-body"">
        <div>
            <h4 class=""text-left"">Handboek</h4>
            <hr class=""border-info"" />
            <div class=""row px-4"">
                <div class=""col-7"">
                    <dl class=""row pt-5"">
                        <dt class=""col-sm-5 text-left"">
                            ");
#nullable restore
#line 21 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.HandboekId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-7 text-left\">\r\n                            ");
#nullable restore
#line 24 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayFor(model => model.HandboekId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5 text-left\">\r\n                            ");
#nullable restore
#line 27 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Titel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-7 text-left\">\r\n                            ");
#nullable restore
#line 30 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Titel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5 text-left\">\r\n                            ");
#nullable restore
#line 33 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Kostprijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-7 text-left\">\r\n                            ");
#nullable restore
#line 36 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Kostprijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5 text-left\">\r\n                            ");
#nullable restore
#line 39 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.UitgifteDatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-7 text-left\">\r\n                            ");
#nullable restore
#line 42 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayFor(model => model.UitgifteDatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5 text-left\">\r\n                            ");
#nullable restore
#line 45 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Afbeelding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-7 text-left\">\r\n                            ");
#nullable restore
#line 48 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Afbeelding));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                 if (fileExist)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-5\">\r\n                        <img class=\"card-img px-4 pt-4\"");
            BeginWriteAttribute("src", " src=\"", 2435, "\"", 2449, 1);
#nullable restore
#line 55 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
WriteAttributeValue("", 2441, imgLink, 2441, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Afbeelding niet beschikbaar\" />\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer border-info\">\r\n        <div class=\"btn-group w-100\" role=\"group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "703462152e461e2669fa084b458ac1efbc558f3110584", async() => {
                WriteLiteral("Wijzig");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\C-Web-Project\Rob_Sannen_Project_Deel_1\MVCHogeschoolPXL\Views\Handboek\Details.cshtml"
                                   WriteLiteral(Model.HandboekId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "703462152e461e2669fa084b458ac1efbc558f3112844", async() => {
                WriteLiteral("Terug");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCHogeschoolPXL.Models.Handboek> Html { get; private set; }
    }
}
#pragma warning restore 1591
