#pragma checksum "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91cbce3ac8ae5a6638ee253f1e2a3e4cee8180f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Delivers_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Delivers/Details.cshtml")]
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
#line 1 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\_ViewImports.cshtml"
using MobiSys.Areas.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91cbce3ac8ae5a6638ee253f1e2a3e4cee8180f6", @"/Areas/Admin/Views/Delivers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4835d94433b7e28d26b067d88c05e9252426c3c0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Delivers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobiSys.Models.DeliverDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <p class=\"col-md\">Deliver number:<strong> ");
#nullable restore
#line 12 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
                                         Write(Html.Raw(ViewBag.Content[0]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <p class=\"col-md\">Customer:<strong>");
#nullable restore
#line 13 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
                                  Write(Html.Raw(ViewBag.Content[1]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <p class=\"col-md\">Adress: <strong> ");
#nullable restore
#line 14 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
                                  Write(Html.Raw(ViewBag.Content[2]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</div>\r\n<div class=\"row\">\r\n    <p class=\"col-md\">Order ID:<strong> ");
#nullable restore
#line 17 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
                                   Write(Html.Raw(ViewBag.Content[3]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <p class=\"col-md\">Phone: <strong>");
#nullable restore
#line 18 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
                                Write(Html.Raw(ViewBag.Content[5]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <p class=\"col-md\">Car: <strong> ");
#nullable restore
#line 19 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
                               Write(Html.Raw(ViewBag.Content[4]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</div>\r\n<hr />\r\n\r\n\r\n\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.UnitsPerBox));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 44 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Deliver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.UnitsPerBox));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Deliver.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 74 "D:\licenta\MobiSys\MobiSys\Areas\Admin\Views\Delivers\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MobiSys.Models.DeliverDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
