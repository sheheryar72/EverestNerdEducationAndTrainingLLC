#pragma checksum "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6437c4797cf26a14359107fcdb88352ce593d0b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditAboutUs), @"mvc.1.0.view", @"/Views/Home/EditAboutUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6437c4797cf26a14359107fcdb88352ce593d0b4", @"/Views/Home/EditAboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdc0853d24b873ccc9cce31c1bfcb75e34971b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_EditAboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EverestNerdEducationAndTrainingLLC.Models.AboutUs>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/UpdateAboutUs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<section style=\"padding: 5%\">\r\n    <div class=\"text-center\">\r\n        <h3>Edit Footer</h3>\r\n</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6437c4797cf26a14359107fcdb88352ce593d0b44310", async() => {
                WriteLiteral("\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Title</label>\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 331, "\"", 348, 1);
#nullable restore
#line 10 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 339, Model.Id, 339, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <input type=\"text\" class=\"form-control\" name=\"Title\" id=\"exampleInputPassword1\" placeholder=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 456, "\"", 476, 1);
#nullable restore
#line 11 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 464, Model.Title, 464, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Discription</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Discription\" id=\"exampleInputPassword1\" placeholder=\"Discription\"");
                BeginWriteAttribute("value", " value=\"", 693, "\"", 719, 1);
#nullable restore
#line 15 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 701, Model.Discription, 701, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Why Choose Us</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"WhyChooseUs\" id=\"exampleInputPassword1\" placeholder=\"Why ChooseUs\"");
                BeginWriteAttribute("value", " value=\"", 939, "\"", 965, 1);
#nullable restore
#line 19 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 947, Model.WhyChooseUs, 947, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Our Mission</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"OurMission\" id=\"exampleInputPassword1\" placeholder=\"Our Mission\"");
                BeginWriteAttribute("value", " value=\"", 1181, "\"", 1206, 1);
#nullable restore
#line 23 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 1189, Model.OurMission, 1189, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Our Vission</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"OurVission\" id=\"exampleInputPassword1\" placeholder=\"Our Vission\"");
                BeginWriteAttribute("value", " value=\"", 1422, "\"", 1447, 1);
#nullable restore
#line 27 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 1430, Model.OurVission, 1430, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Students Enrolled</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"StudentsEnrolled\" id=\"exampleInputPassword1\" placeholder=\"Students Enrolled\"");
                BeginWriteAttribute("value", " value=\"", 1681, "\"", 1712, 1);
#nullable restore
#line 31 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 1689, Model.StudentsEnrolled, 1689, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Courses Uploaded</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"CoursesUploaded\" id=\"exampleInputPassword1\" placeholder=\"Courses Uploaded\"");
                BeginWriteAttribute("value", " value=\"", 1943, "\"", 1973, 1);
#nullable restore
#line 35 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 1951, Model.CoursesUploaded, 1951, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">People Certifie</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"PeopleCertifie\" id=\"exampleInputPassword1\" placeholder=\"People Certifie\"");
                BeginWriteAttribute("value", " value=\"", 2201, "\"", 2230, 1);
#nullable restore
#line 39 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 2209, Model.PeopleCertifie, 2209, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Global Teachers</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"GlobalTeachers\" id=\"exampleInputPassword1\" placeholder=\"Global Teachers\"");
                BeginWriteAttribute("value", " value=\"", 2458, "\"", 2487, 1);
#nullable restore
#line 43 "C:\Users\Sheheryar Izhar\source\repos\EverestNerdEducationAndTrainingLLC\EverestNerdEducationAndTrainingLLC\Views\Home\EditAboutUs.cshtml"
WriteAttributeValue("", 2466, Model.GlobalTeachers, 2466, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n  </div>\r\n  \r\n  <button type=\"submit\" class=\"btn btn-primary\" style=\"margin-top: 2%\">Update About Us</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EverestNerdEducationAndTrainingLLC.Models.AboutUs> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
