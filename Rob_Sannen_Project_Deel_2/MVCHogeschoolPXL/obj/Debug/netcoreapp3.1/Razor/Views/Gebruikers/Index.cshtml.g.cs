#pragma checksum "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MVCHogeschoolPXL.Pages.Gebruikers.Views_Gebruikers_Index), @"mvc.1.0.view", @"/Views/Gebruikers/Index.cshtml")]
namespace MVCHogeschoolPXL.Pages.Gebruikers
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
#line 1 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\_ViewImports.cshtml"
using MVCHogeschoolPXL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\_ViewImports.cshtml"
using MVCHogeschoolPXL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f79", @"/Views/Gebruikers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d3ea873dddd6fadcbe45635fbc889d25ed5950", @"/Views/_ViewImports.cshtml")]
    public class Views_Gebruikers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCHogeschoolPXL.ViewModels.GebruikerInfo>>
    {
        private global::MVCHogeschoolPXL.Pages.Gebruikers.Views_Gebruikers_Index.__Generated__GebruikerFilterViewComponentTagHelper __GebruikerFilterViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "danger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MVCHogeschoolPXL.TagHelpers.ActionButtonTagHelper __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
  
    ViewData["Title"] = "Index";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-2 pt-5 mt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:gebruiker-filter", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f796283", async() => {
            }
            );
            __GebruikerFilterViewComponentTagHelper = CreateTagHelper<global::MVCHogeschoolPXL.Pages.Gebruikers.Views_Gebruikers_Index.__Generated__GebruikerFilterViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__GebruikerFilterViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-10\">\r\n        <div class=\"row pt-5 pb-2\">\r\n            <div class=\"col-5 text-primary\">\r\n                <h1>Overzicht ");
#nullable restore
#line 16 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                         Write(ViewBag.Titel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"col-6 text-left d-flex align-items-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f797776", async() => {
                WriteLiteral("Cre??er nieuwe gebruiker");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <table class=\"table table-striped\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th width=\"5%\">\r\n                                ");
#nullable restore
#line 29 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.GebruikerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th width=\"15%\">\r\n                                ");
#nullable restore
#line 32 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th width=\"15%\">\r\n                                ");
#nullable restore
#line 35 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th width=\"35%\">\r\n                                ");
#nullable restore
#line 38 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </th>
                            <th width=""30%"" class=""text-center"">
                                Acties
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 46 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GebruikerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"btn-group w-100\" role=\"group\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f7913352", async() => {
                WriteLiteral("wijzig");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper = CreateTagHelper<global::MVCHogeschoolPXL.TagHelpers.ActionButtonTagHelper>();
            __tagHelperExecutionContext.Add(__MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                                                           WriteLiteral(item.GebruikerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper.Color = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f7916020", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper = CreateTagHelper<global::MVCHogeschoolPXL.TagHelpers.ActionButtonTagHelper>();
            __tagHelperExecutionContext.Add(__MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                                                              WriteLiteral(item.GebruikerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper.Color = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae11a42b0a82e5a0656ad1aaaab9d4f372c3f7918692", async() => {
                WriteLiteral("Wissen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper = CreateTagHelper<global::MVCHogeschoolPXL.TagHelpers.ActionButtonTagHelper>();
            __tagHelperExecutionContext.Add(__MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                                                             WriteLiteral(item.GebruikerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MVCHogeschoolPXL_TagHelpers_ActionButtonTagHelper.Color = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 73 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-center col-6 offset-3 pt-5\">Er zijn nog geen gebruikers!</p>\r\n");
#nullable restore
#line 77 "C:\C-Web-Project\Rob_Sannen_Project_Deel_2\MVCHogeschoolPXL\Views\Gebruikers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCHogeschoolPXL.ViewModels.GebruikerInfo>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:gebruiker-filter")]
        public class __Generated__GebruikerFilterViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__GebruikerFilterViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("GebruikerFilter", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
