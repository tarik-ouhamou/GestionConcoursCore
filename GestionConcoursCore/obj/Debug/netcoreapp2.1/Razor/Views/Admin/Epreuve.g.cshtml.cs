#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Admin\Epreuve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6fdab2fb715868ee86db3369f36d9f0aa6af6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Epreuve), @"mvc.1.0.view", @"/Views/Admin/Epreuve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Epreuve.cshtml", typeof(AspNetCore.Views_Admin_Epreuve))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6fdab2fb715868ee86db3369f36d9f0aa6af6c", @"/Views/Admin/Epreuve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Epreuve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Math", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Programmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Physique", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Admin\Epreuve.cshtml"
  
    ViewData["Title"] = "Epreuves";

#line default
#line hidden
            BeginContext(46, 248, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2 class=\"text-center\">Upload Epreuve</h2><br /><br /><br />\r\n    <div id=\"message\"></div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <select id=\"matiere\" class=\"form-control\">\r\n                ");
            EndContext();
            BeginContext(294, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e36c231429485e9b52df5311afded6", async() => {
                BeginContext(315, 4, true);
                WriteLiteral("Math");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(346, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e953692d0847cab0183560be778afa", async() => {
                BeginContext(376, 13, true);
                WriteLiteral("Programmation");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(398, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(416, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66764cf2f1ed445e98be30af0c49a8b7", async() => {
                BeginContext(441, 8, true);
                WriteLiteral("Physique");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(458, 1903, true);
            WriteLiteral(@"
            </select>
        </div>
        <div class=""col-6"">
            <input type=""text"" id=""annee"" class=""form-control"" placeholder=""Année épreuve"" />
        </div>
    </div><br /><br />
    <div class=""row offset-2"">
        <div class=""col-6"">
            <input type=""file"" class=""form-control"" name=""file"" id=""file"" />
        </div>
        <div class=""col-4"">
            <button class=""btn btn-info btn-block"" id=""upload"">Upload</button>
        </div>
    </div>
    <div class=""alert alert-warning mt-5"">
        <span>Veuillez enregistrer un fichier à la fois!</span>
    </div>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        $(""#upload"").click(function () {
            $(""#message"").empty();
            var file = $(""#file"").get(0).files[0];
            var formData = new FormData();
            formData.append(""file"", file);
            formData.append(""matiere"", $");
            WriteLiteral(@"(""#matiere"").val());
            formData.append(""annee"", $(""#annee"").val());

            $.ajax({
                url: ""/Admin/UploadEpreuve"",
                method: ""post"",
                data: formData,
                cache: false,
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response == ""1"") {
                        $(""#message"").append(""<div class='alert alert-success'><span>Fichier enregistrer avec succes</span></div>"")
                    }
                    else {
                        $(""#message"").append(""<div class='alert alert-danger'><span>Erreur lors d'enregistrement</span></div>"")
                    }
                }
            })
            .then(function(result) {

            });
                });
    })
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