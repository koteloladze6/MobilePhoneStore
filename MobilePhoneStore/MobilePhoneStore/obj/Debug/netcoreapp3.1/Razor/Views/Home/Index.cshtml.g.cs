#pragma checksum "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d31b0f4a3cf91113371e8580a1888bc288e19dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\_ViewImports.cshtml"
using MobilePhoneStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\_ViewImports.cshtml"
using MobilePhoneStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d31b0f4a3cf91113371e8580a1888bc288e19dae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7df057c4d836d43a206a76cf4bc6a60241fb295c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/MyStylecss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d31b0f4a3cf91113371e8580a1888bc288e19dae4527", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d31b0f4a3cf91113371e8580a1888bc288e19dae4789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""row justify-content-center mt-2"">
                    <div class=""col"">
                        <div class=""input-group"">
                            ");
#nullable restore
#line 16 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                       Write(Html.TextBoxFor(s => s.SearchWord, new { @class = "form-control", @placeholder = "დასახელება" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""row justify-content-center mt-2"">
                    <div class=""col"">
                        <div class=""input-group"">
                            ");
#nullable restore
#line 23 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                       Write(Html.DropDownListFor(m => m.ManufacturerID, new SelectList(Model.Manufacturers, "Value", "Text"), "Select Manufacturer", new { @class = "custom-select" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""row justify-content-center mt-2"">
                    <div class=""col-lg-auto pt-lg-1 pr-lg-1"">
                        ფასი:
                    </div>
                    <div class=""col-lg"">
                        ");
#nullable restore
#line 32 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(p => p.MinPrice, new { @class = "form-control", @placeholder = "ფასი - დან" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-lg-auto text-center text-success p-lg-1\">-</div>\r\n                    <div class=\"col-lg\">\r\n                        ");
#nullable restore
#line 36 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(p => p.MaxPrice, new { @class = "form-control", @placeholder = "ფასი - მდე" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""row justify-content-center mt-2 mb-2"">
                    <div class=""col-auto"">
                        <input type=""submit"" class=""form-control btn btn-primary"" value=""ძებნა"" />
                    </div>
                </div>
            </div>


            <div class=""col-md"">
                
");
#nullable restore
#line 49 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                     if (Model.Phones.Count() != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"Divider\">\r\n                    <div class=\"row1\">\r\n");
#nullable restore
#line 53 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                         foreach (var item in Model.Phones)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-3\">\r\n                                <figure class=\"card card-product\">\r\n                                    <div class=\"img-wrap\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d31b0f4a3cf91113371e8580a1888bc288e19dae10804", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2600, "~/images/", 2600, 9, true);
#nullable restore
#line 58 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2609, item.Image, 2609, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <figcaption class=\"info-wrap\">\r\n                                        <h6 class=\"title text-dots\"><a");
            BeginWriteAttribute("href", " href=\"", 2806, "\"", 2839, 2);
            WriteAttributeValue("", 2813, "/Home/Details/?id=", 2813, 18, true);
#nullable restore
#line 61 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2831, item.ID, 2831, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                        <div class=\"action-wrap\">\r\n                                            <div class=\"price-wrap h5\">\r\n                                                <span class=\"price-new\">");
#nullable restore
#line 64 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                                                                   Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("$</span>\r\n                                            </div>\r\n                                        </div>\r\n                                    </figcaption>\r\n                                </figure>\r\n                            </div>\r\n");
#nullable restore
#line 70 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                    <div style=""display:flex; justify-content: center; margin-top: 30px;"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination"">
                                <li");
            BeginWriteAttribute("class", " class=\"", 3663, "\"", 3723, 2);
            WriteAttributeValue("", 3671, "page-item", 3671, 9, true);
#nullable restore
#line 76 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3680, Model.Page > 1  ? "active" : "disabled", 3681, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"page-link\" name=\"Page\"");
            BeginWriteAttribute("value", " value=\"", 3814, "\"", 3839, 1);
#nullable restore
#line 77 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3822, Model.Page - 1, 3822, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">წინა</button>\r\n                                </li>\r\n");
#nullable restore
#line 79 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                                 for (int i = 1; i <= @Model.TotalPages; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li");
            BeginWriteAttribute("class", " class=\"", 4048, "\"", 4109, 3);
            WriteAttributeValue("", 4056, "page-item", 4056, 9, true);
#nullable restore
#line 81 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4065, Model.Page == i ? "disabled" : "active", 4066, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4108, "", 4109, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <button type=\"submit\" class=\"page-link\" name=\"Page\"");
            BeginWriteAttribute("value", " value=\"", 4204, "\"", 4214, 1);
#nullable restore
#line 82 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4212, i, 4212, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                    </li>\r\n");
#nullable restore
#line 84 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 4344, "\"", 4420, 2);
            WriteAttributeValue("", 4352, "page-item", 4352, 9, true);
#nullable restore
#line 86 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue("  ", 4361, Model.Page == Model.TotalPages ? "disabled" : "active", 4363, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"page-link\" name=\"Page\"");
            BeginWriteAttribute("value", " value=\"", 4511, "\"", 4536, 1);
#nullable restore
#line 87 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4519, Model.Page + 1, 4519, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">შემდეგი</button>\r\n                                </li>\r\n                            </ul>\r\n                        </nav>\r\n                    </div>\r\n");
#nullable restore
#line 92 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"

                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row justify-content-center\">\r\n                        <p>ტელეფონი ვერ მოიძებნა</p>\r\n                    </div>\r\n");
#nullable restore
#line 100 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 106 "D:\User\Desktop\MobilePhoneStore2\MobilePhoneStore\MobilePhoneStore\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
