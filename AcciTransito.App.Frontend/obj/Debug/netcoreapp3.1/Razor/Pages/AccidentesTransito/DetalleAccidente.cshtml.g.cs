#pragma checksum "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56bcfe9a29648a682c51bb9990ab1cfe7d57698f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcciTransito.App.Frontend.Pages.AccidentesTransito.Pages_AccidentesTransito_DetalleAccidente), @"mvc.1.0.razor-page", @"/Pages/AccidentesTransito/DetalleAccidente.cshtml")]
namespace AcciTransito.App.Frontend.Pages.AccidentesTransito
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
#line 1 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\_ViewImports.cshtml"
using AcciTransito.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56bcfe9a29648a682c51bb9990ab1cfe7d57698f", @"/Pages/AccidentesTransito/DetalleAccidente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ab60bfe578d84bc7e47fef422cbf1e6e510d96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AccidentesTransito_DetalleAccidente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AccidentesTransito/ListaAccidentes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\n    .round1{\n        background-color: white;\n        margin:0 auto;\n        margin-top:2%;\n        padding:0;\n");
            WriteLiteral("        border: 3px solid green;\n        border-radius: 12px;\n        padding: 5px;\n    }\n</style>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56bcfe9a29648a682c51bb9990ab1cfe7d57698f4192", async() => {
                WriteLiteral("\n<title>Detalle Accidente</title> ");
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
            WriteLiteral("\n<h5>Detalle Accidente No.:");
#nullable restore
#line 19 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
                     Write(Model.accidentes.NumeroAccidente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<div class=\"col-sm-12 round1\">\n<p>Id: ");
#nullable restore
#line 21 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
  Write(Model.accidentes.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Numero Accidente: ");
#nullable restore
#line 22 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
                Write(Model.accidentes.NumeroAccidente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Fecha: ");
#nullable restore
#line 23 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
     Write(Model.accidentes.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Tipo Accidente: ");
#nullable restore
#line 24 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
              Write(Model.accidentes.TipoAccidente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Peritaje: ");
#nullable restore
#line 25 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
        Write(Model.accidentes.Peritaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Direccion: ");
#nullable restore
#line 26 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
         Write(Model.accidentes.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Barrio: ");
#nullable restore
#line 27 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleAccidente.cshtml"
      Write(Model.accidentes.Barrio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56bcfe9a29648a682c51bb9990ab1cfe7d57698f7577", async() => {
                WriteLiteral("Lista de Accidentes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcciTransito.App.Frontend.Pages.DetalleAccidenteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.DetalleAccidenteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.DetalleAccidenteModel>)PageContext?.ViewData;
        public AcciTransito.App.Frontend.Pages.DetalleAccidenteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
