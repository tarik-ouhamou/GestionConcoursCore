#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd28c2b2602ceb0fb30fc842ce8507c6ebd5a626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminAuth_Login), @"mvc.1.0.view", @"/Views/AdminAuth/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminAuth/Login.cshtml", typeof(AspNetCore.Views_AdminAuth_Login))]
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
#line 1 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd28c2b2602ceb0fb30fc842ce8507c6ebd5a626", @"/Views/AdminAuth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminAuth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.Models.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/admin_pic/admin2.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gradient-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
  
    ViewBag.Title = "Login";
    Layout = "~/Views/Shared/_AdminAuthLayout.cshtml";

#line default
#line hidden
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 3305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e5a6510d764a9eafac2927eaa43972", async() => {
                BeginContext(170, 514, true);
                WriteLiteral(@"

    <div class=""container"">

        <!-- Outer Row -->
        <div class=""row justify-content-center"">

            <div class=""col-xl-10 col-lg-12 col-md-9 my_card"">

                <div class=""card o-hidden border-0 shadow-lg my-5"">
                    <div class=""card-body p-0 "">
                        <!-- Nested Row within Card Body -->
                        <div class=""row"">
                            <div class=""col-lg-6 d-none d-lg-block my_img"">
                                ");
                EndContext();
                BeginContext(684, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b2c7695419b4cc7b13ab91a0d09e458", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(727, 394, true);
                WriteLiteral(@"
                            </div>
                            <div class=""col-lg-6 my-auto"">
                                <div class=""p-5"">
                                    <div class=""text-center"">
                                        <h1 class=""h4 text-gray-900 mb-4"">Welcome Back Admin!</h1>
                                    </div>

                                    ");
                EndContext();
                BeginContext(1122, 64, false);
#line 29 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1186, 60, true);
                WriteLiteral("\r\n                                    <h6 class=text-danger>");
                EndContext();
                BeginContext(1247, 13, false);
#line 30 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                                     Write(ViewBag.error);

#line default
#line hidden
                EndContext();
                BeginContext(1260, 7, true);
                WriteLiteral("</h6>\r\n");
                EndContext();
#line 31 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                     using (Html.BeginForm())
                                    {

#line default
#line hidden
                BeginContext(1369, 155, true);
                WriteLiteral("                                        <div class=\"form-group\">\r\n                                           \r\n                                            ");
                EndContext();
                BeginContext(1525, 164, false);
#line 35 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                       Write(Html.EditorFor(model => model.Username, new { htmlAttributes = new { @class = "form-control form-control-user", placeholder = "Enter Username", id = "username" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1689, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(1736, 86, false);
#line 36 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1822, 251, true);
                WriteLiteral("\r\n                                            \r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                           \r\n                                            ");
                EndContext();
                BeginContext(2074, 164, false);
#line 41 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control form-control-user", placeholder = "Enter Password", id = "password" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2238, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(2285, 86, false);
#line 42 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2371, 678, true);
                WriteLiteral(@"

                                        </div>
                                        <div class=""form-group"">
                                            <div class=""custom-control custom-checkbox small"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                                <label class=""custom-control-label"" for=""customCheck"">Remember Me</label>
                                            </div>
                                        </div>
                                        <input type=""submit"" class=""btn btn-primary btn-user btn-block"" value=""Login"" />
");
                EndContext();
#line 52 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\AdminAuth\Login.cshtml"
                                                                                
                                    }

#line default
#line hidden
                BeginContext(3170, 264, true);
                WriteLiteral(@"
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

    

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3441, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionConcoursCore.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
