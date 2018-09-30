#pragma checksum "/Users/eddylara/projects/Tax calculator/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b37d715bd613d1cac53adecf5e4794bcd7f3df"
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
#line 1 "/Users/eddylara/projects/Tax calculator/Views/_ViewImports.cshtml"
using Tax_calculator;

#line default
#line hidden
#line 2 "/Users/eddylara/projects/Tax calculator/Views/_ViewImports.cshtml"
using Tax_calculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b37d715bd613d1cac53adecf5e4794bcd7f3df", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c5d0117327c8331efa719bb5c208357ea25dfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/eddylara/projects/Tax calculator/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 928, true);
            WriteLiteral(@"<div id=""koContainer"">
<div>
    <input type=""text"" placeholder=""Expected 2018 gross wages"" /><button type=""button"" id=""btnCalculate"" onclick=""""><label for=""btnCalculate"">Calculate</label>
</div>
<div>
    <span id=""lblResult"">Expected taxes to be paid: </span> <label id=""result"" for=""lblResult""></label> 
</div>
</div>
<script>
    class TaxCalculator{
        const tenPercentWage = 1905;
        const twelvePercentWage = 7002;
        const twelvePercentCap = 77400;
        let wages = ko.observable(0);

        var self = this;

        self.wages = wages;

        self.result = ko.computed(function () {
            var expectedTax = 1905 + 7002;
            if(wages > twelvePercentCap){
                expectedTax += ((wages - twelvePercentCap) * 22);
            }
            return expectedTax;
        }) 
    }

    ko.applyBinding($(""#koContainer""), new TaxCalculator())
</script>");
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