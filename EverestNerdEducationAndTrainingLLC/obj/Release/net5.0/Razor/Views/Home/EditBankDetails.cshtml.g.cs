#pragma checksum "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aae409c226acd53a491934d5d5518ac06554ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditBankDetails), @"mvc.1.0.view", @"/Views/Home/EditBankDetails.cshtml")]
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
#line 1 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\_ViewImports.cshtml"
using EverestNerdEducationAndTrainingLLC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\_ViewImports.cshtml"
using EverestNerdEducationAndTrainingLLC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aae409c226acd53a491934d5d5518ac06554ff8", @"/Views/Home/EditBankDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdc0853d24b873ccc9cce31c1bfcb75e34971b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_EditBankDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EverestNerdEducationAndTrainingLLC.Models.BankDetails>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/UpdateBankDetails/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section style=\"padding: 5%\">\r\n    <div class=\"text-center\">\r\n        <h3>Edit Bank Details</h3>\r\n</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aae409c226acd53a491934d5d5518ac06554ff84345", async() => {
                WriteLiteral("\r\n  <div class=\"form-group\">\r\n      <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 294, "\"", 311, 1);
#nullable restore
#line 9 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 302, Model.Id, 302, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <label for=\"exampleInputEmail1\">AccountNO</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"AccountNO\" id=\"exampleInputEmail1\"  aria-describedby=\"emailHelp\" placeholder=\"AccountNO\"");
                BeginWriteAttribute("value", " value=\"", 509, "\"", 533, 1);
#nullable restore
#line 11 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 517, Model.AccountNO, 517, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">BankName</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"BankName\" id=\"exampleInputPassword1\" placeholder=\"BankName\"");
                BeginWriteAttribute("value", " value=\"", 741, "\"", 764, 1);
#nullable restore
#line 15 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 749, Model.BankName, 749, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">PhoneNo</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"PhoneNo\" id=\"exampleInputPassword1\" placeholder=\"PhoneNo\"");
                BeginWriteAttribute("value", " value=\"", 969, "\"", 991, 1);
#nullable restore
#line 19 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 977, Model.PhoneNo, 977, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Email</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Email\" id=\"exampleInputPassword1\" placeholder=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 1190, "\"", 1210, 1);
#nullable restore
#line 23 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 1198, Model.Email, 1198, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Country</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Country\" id=\"exampleInputCatagory\" placeholder=\"Country\"");
                BeginWriteAttribute("value", " value=\"", 1414, "\"", 1436, 1);
#nullable restore
#line 27 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 1422, Model.Country, 1422, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">City</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"City\" id=\"exampleInputCatagory\" placeholder=\"City\"");
                BeginWriteAttribute("value", " value=\"", 1631, "\"", 1650, 1);
#nullable restore
#line 31 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditBankDetails.cshtml"
WriteAttributeValue("", 1639, Model.City, 1639, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <button type=\"submit\" class=\"btn btn-primary\" style=\"margin-top: 2%\">Update Details</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EverestNerdEducationAndTrainingLLC.Models.BankDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
