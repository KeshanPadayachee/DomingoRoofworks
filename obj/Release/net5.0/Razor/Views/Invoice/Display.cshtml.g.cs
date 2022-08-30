#pragma checksum "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b65066d7f6d5ac775cab292cf7a9e6f74d61d295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Display), @"mvc.1.0.view", @"/Views/Invoice/Display.cshtml")]
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
#line 1 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\_ViewImports.cshtml"
using DomingoRoofWorks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
using DomingoRoofWorks.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65066d7f6d5ac775cab292cf7a9e6f74d61d295", @"/Views/Invoice/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6378e087939e24fd4a1e19fc3065c9477ef2c19", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenerateInvoice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<h1>Invoice for Job Card Number ");
#nullable restore
#line 11 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
                           Write(Model.jobNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<br>\r\n<br>\r\n\r\n<h4>Customer Name</h4>\r\n<small>");
#nullable restore
#line 17 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n<br>\r\n<br>\r\n\r\n<h4>Address</h4>\r\n<small>");
#nullable restore
#line 23 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.jobAddress.HouseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n<small>");
#nullable restore
#line 24 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.jobAddress.StreetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n<small>");
#nullable restore
#line 25 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.jobAddress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n<small>");
#nullable restore
#line 26 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.jobAddress.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n<small>");
#nullable restore
#line 27 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.jobAddress.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n<br>\r\n<br>\r\n\r\n<h4>Employees on the Job</h4>\r\n");
#nullable restore
#line 33 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
 foreach (var e in Model.lstEmployees)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> ");
#nullable restore
#line 35 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
Write(e.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
             Write(e.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 36 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n<br>\r\n\r\n<h4>Materials used on the Job</h4>\r\n");
#nullable restore
#line 42 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
 foreach (var m in Model.lstMaterials)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
     foreach (var jm in Model.lstJobMaterials)
    {
        if (m.MaterialID.Equals(jm.MaterialID))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <strong>ID: </strong>");
#nullable restore
#line 49 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
                    Write(m.MaterialID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <strong>Description: </strong> ");
#nullable restore
#line 50 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
                              Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <strong>Quantity: </strong> ");
#nullable restore
#line 51 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
                           Write(jm.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 53 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n<br>\r\n\r\n<h4>Rates</h4>\r\n<small>");
#nullable restore
#line 61 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.rates.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - </small>\r\n<small>R ");
#nullable restore
#line 62 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
    Write(Model.rates.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n<br>\r\n<br>\r\n\r\n<h4>Number of Days</h4>\r\n<small>");
#nullable restore
#line 68 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
  Write(Model.jobs.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n<br>\r\n<br>\r\n\r\n<h4>Subtotal</h4>\r\n<small>R ");
#nullable restore
#line 74 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
    Write(Model.subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n<br>\r\n<br>\r\n\r\n<h4>VAT</h4>\r\n<small>R ");
#nullable restore
#line 80 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
    Write(Model.VAT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n<br>\r\n<br>\r\n<h4>Total</h4>\r\n<small>R ");
#nullable restore
#line 85 "C:\Users\Keshan\Desktop\DomingoRoofWorks\Views\Invoice\Display.cshtml"
    Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenerateInvoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
