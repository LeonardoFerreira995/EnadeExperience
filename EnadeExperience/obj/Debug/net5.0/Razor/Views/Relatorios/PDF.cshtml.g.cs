#pragma checksum "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c9eb09a4661e5285ad44d9a70c835e7a4511f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorios_PDF), @"mvc.1.0.view", @"/Views/Relatorios/PDF.cshtml")]
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
#line 1 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\_ViewImports.cshtml"
using EnadeExperience;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\_ViewImports.cshtml"
using EnadeExperience.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c9eb09a4661e5285ad44d9a70c835e7a4511f6", @"/Views/Relatorios/PDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea688b793857cc9006edf2b58f271ea8ecd39b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorios_PDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EnadeExperience.Models.QuestoesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c9eb09a4661e5285ad44d9a70c835e7a4511f64232", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00c9eb09a4661e5285ad44d9a70c835e7a4511f64559", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>View</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c9eb09a4661e5285ad44d9a70c835e7a4511f66468", async() => {
                WriteLiteral("\r\n    <h2 class=\"text-center\">Relat??rio de Quest??es</h2>\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
     foreach (var item in Model)
    {
        // S?? est?? funcionando nessa log??ca por algum motivo
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
         if (item.Imagem is null || item.Imagem == "")
        {

        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <strong>Imagem: </strong>\r\n            <br />\r\n            <img style=\"width: 320px; height: 320px;\"");
                BeginWriteAttribute("src", " src=\"", 669, "\"", 700, 1);
#nullable restore
#line 25 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
WriteAttributeValue("", 675, Url.Content(item.Imagem), 675, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <br /><br />\r\n");
#nullable restore
#line 27 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <strong>Quest??o: </strong>\r\n        <p class=\"text-justify\">");
#nullable restore
#line 29 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
                           Write(Html.Raw(item.Questao));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br />\r\n        <strong>Resposta: </strong>\r\n        <p class=\"text-justify\">");
#nullable restore
#line 32 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
                           Write(Html.Raw(item.Resposta));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br />\r\n        <strong>Curso: </strong>\r\n        <p>");
#nullable restore
#line 35 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
      Write(Html.DisplayFor(modelItem => item.Curso));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br />\r\n        <strong>Disciplinas: </strong>\r\n        <p>\r\n            ");
#nullable restore
#line 39 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
       Write(Html.DisplayFor(modelItem => item.Disciplina));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 40 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
             if (item.Disciplina2 != "")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disciplina2));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 43 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
             if (item.Disciplina3 != "")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disciplina3));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 48 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
             if (item.Disciplina4 != "")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disciplina4));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 53 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
             if (item.Disciplina5 != "")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disciplina5));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 58 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </p>\r\n        <br />\r\n        <strong>Dificuldade: </strong>\r\n        <p>");
#nullable restore
#line 62 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
      Write(Html.DisplayFor(modelItem => item.Dificuldade));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br />\r\n        <strong>Ano: </strong>\r\n        <p>");
#nullable restore
#line 65 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
      Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br />\r\n        <hr style=\"border-color: #6C6C6C\" />\r\n        <br />\r\n");
#nullable restore
#line 69 "C:\Users\Leona\Desktop\Projeto\EnadeExperience\EnadeExperience\Views\Relatorios\PDF.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <h6 class=\"float-right\"><strong>Enade Experience</strong> By: AdLeste</h6>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EnadeExperience.Models.QuestoesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
