#pragma checksum "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartDetails_Index), @"mvc.1.0.view", @"/Views/CartDetails/Index.cshtml")]
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
#line 1 "D:\licenta\MobiSys\MobiSys\Views\_ViewImports.cshtml"
using MobiSys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\licenta\MobiSys\MobiSys\Views\_ViewImports.cshtml"
using MobiSys.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71073814fa30c61b1a487ca46fa7d24e9a5f6fa", @"/Views/CartDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b8334c7ee771c26989198b8d0f64df568d52e6", @"/Views/_ViewImports.cshtml")]
    public class Views_CartDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobiSys.Models.CartDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark d-inline-block align-middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this item?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button-addon3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UseVaucher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark px-4 rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark rounded-pill py-2 btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"px-4 px-lg-0 container-fluid\">\r\n    <div class=\"alert alert-primary\">\r\n        <p class=\"d-flex justify-content-center\">Current credit : <strong> ");
#nullable restore
#line 13 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                      Write(ViewBag.credit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong> RON.</p>
    </div>

    <div class=""pb-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 p-5 bg-white rounded shadow-sm mb-5"">


                    <div class=""table-responsive"">
                        <table class=""table "">
                            <thead>
                                <tr>

                                    <th scope=""col"" class=""border-0 bg-info"">
                                        <div class=""p-2 px-3 text-uppercase"">Product</div>
                                    </th>
                                    <th scope=""col"" class=""border-0 bg-info"">
                                        <div class=""py-2 text-uppercase"">Units/Box</div>
                                    </th>
                                    <th scope=""col"" class=""border-0 bg-info"">
                                        <div class=""py-2 text-uppercase"">Price</div>
                                    </th>
         ");
            WriteLiteral(@"                           <th scope=""col"" class=""border-0 bg-info"">
                                        <div class=""py-2 text-uppercase"">Quantity</div>
                                    </th>
                                    <th scope=""col"" class=""border-0 bg-info"">
                                        <div class=""py-2 text-uppercase"">Remove</div>
                                    </th>
                                </tr>
                            </thead>

");
#nullable restore
#line 45 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                             foreach (var item in Model)
                            {
                                var photoPath = "~/images/" + item.Product.Image;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tbody>
                                    <tr>
                                        <th scope=""row"" class=""border-0"">
                                            <div class=""p-2"">

                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa11310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                             WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <div class=\"ml-3 d-inline-block align-middle\">\r\n                                                    <h5 class=\"mb-0\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa13651", async() => {
#nullable restore
#line 55 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                                                                                                                                                Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                                                                          WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n\r\n                                                </div>\r\n                                            </div>\r\n                                        </th>\r\n                                        <td class=\"border-0 align-middle\"><strong>");
#nullable restore
#line 60 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                             Write(item.Product.UnitsPerBox);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                                        <td class=\"border-0 align-middle\"><strong>");
#nullable restore
#line 61 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                             Write(item.Product.FinalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RON</strong></td>\r\n                                        <td class=\"border-0 align-middle\"><strong>");
#nullable restore
#line 62 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                             Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                                        <td class=\"border-0 align-middle\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa17862", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    </tr>\r\n\r\n                                </tbody>\r\n");
#nullable restore
#line 67 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row py-5 p-4 bg-white shadow-sm\">\r\n\r\n                <div class=\"col-lg-6 border \">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa20871", async() => {
                WriteLiteral(@"
                        <div class=""bg-info pill px-4 py-3 text-uppercase font-weight-bold"">Vouchers</div>
                        <div class=""p-4"">
                            <p class="" mb-4"">If you have a Voucher code, please enter it in the box below</p>
                            <p class="" mb-4""><strong>Use Vouchers only wehn you want to check-out</strong>,because if you use vouchers and remove some products  from the cart, you will lose the discounts. </p>
                            <div class=""input-group mb-4 border rounded-pill p-2"">

                                <input type=""text"" name=""vaucherInput"" placeholder=""Apply coupon"" aria-describedby=""button-addon3"" class=""form-control border-0"" />
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa21905", async() => {
                    WriteLiteral("<i class=\"fa fa-gift mr-2\"></i>Apply Voucher");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            </div>\r\n                            <label class=\"text-danger field-validation-error\">");
#nullable restore
#line 88 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                         Write(TempData["error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            <label class=\"text-success field-validation-error\">");
#nullable restore
#line 89 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                          Write(TempData["succes"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>


                <div class=""col-lg-6 border"">
                    <div class=""bg-info px-4 py-3 text-uppercase font-weight-bold"">Order summary </div>
                    <div class=""p-4"">

                        <ul class=""list-unstyled mb-4"">
                            <li class=""d-flex justify-content-between py-3 border-bottom"">
                                <strong class=""text-muted"">Subtotal </strong>
                                <strong>");
#nullable restore
#line 105 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                   Write(ViewBag.subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RON</strong>\r\n                            </li>\r\n");
#nullable restore
#line 107 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                             if (ViewBag.discPackage>0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"d-flex justify-content-between py-3 border-bottom\">\r\n                                    <strong class=\"text-muted\">Full Pack Discount </strong>\r\n                                    <strong>- ");
#nullable restore
#line 111 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                         Write(ViewBag.discPackage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RON</strong>\r\n                                </li>\r\n");
#nullable restore
#line 113 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                             if (ViewBag.discountVal > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"d-flex justify-content-between py-3 border-bottom\">\r\n                                    <strong class=\"text-muted\">Value Voucher</strong>\r\n                                    <strong>-");
#nullable restore
#line 118 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                        Write(ViewBag.discountVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RON</strong>\r\n                                </li>\r\n");
#nullable restore
#line 120 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                             if (ViewBag.discountPer > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"d-flex justify-content-between py-3 border-bottom\">\r\n                                    <strong class=\"text-muted\">Percentage Voucher</strong>\r\n                                    <strong>-");
#nullable restore
#line 125 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                        Write(ViewBag.discountPer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % </strong>\r\n                                </li>\r\n");
#nullable restore
#line 127 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"d-flex justify-content-between py-3 border-bottom\">\r\n                                <strong class=\"text-muted\">Total</strong>\r\n                                <h5 class=\"font-weight-bold\">");
#nullable restore
#line 130 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                        Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </li>\r\n                        </ul>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71073814fa30c61b1a487ca46fa7d24e9a5f6fa29751", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                             <label class=\"text-danger field-validation-error\">");
#nullable restore
#line 133 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
                                                                          Write(TempData["CartMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 145 "D:\licenta\MobiSys\MobiSys\Views\CartDetails\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MobiSys.Models.CartDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
