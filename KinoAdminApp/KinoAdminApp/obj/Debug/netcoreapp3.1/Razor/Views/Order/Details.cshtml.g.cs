#pragma checksum "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f02e69c552d3f7aca7e145d58702bea31062d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\_ViewImports.cshtml"
using KinoAdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\_ViewImports.cshtml"
using KinoAdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f02e69c552d3f7aca7e145d58702bea31062d5", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb983dbee10c15513538c6f7e606bac0a578a19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KinoAdminApp.Models.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <p>\r\n        <a class=\"btn btn-success\">");
#nullable restore
#line 11 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
                              Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </p>\r\n\r\n");
#nullable restore
#line 14 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
     for (int i = 0; i < Model.ProductInOrders.Count(); i++)
    {
        var item = Model.ProductInOrders.ElementAt(i).OrderedProduct;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 21 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 18rem; height: 30rem;\">\r\n                    <img class=\"card-img-top\" style=\"height: 70%\"");
            BeginWriteAttribute("src", " src=\"", 681, "\"", 705, 1);
#nullable restore
#line 25 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
WriteAttributeValue("", 687, item.ProductImage, 687, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                    <div class=\"card-body\">\r\n                        <h3>");
#nullable restore
#line 27 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 28 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
                      Write(item.data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 29 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"

            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 39 "F:\IMPORTANTTTTTTTTTTTTTTTTTTTT\FINKI\Reopsitory\Integrirani-Sistemi-Domashna\KinoAdminApp\KinoAdminApp\Views\Order\Details.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KinoAdminApp.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
