#pragma checksum "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d176cf5de4ca9bdd92d2f23d58a2a3bed1651399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcciTransito.App.Frontend.Pages.AccidentesTransito.Pages_AccidentesTransito_ListaPersonas), @"mvc.1.0.razor-page", @"/Pages/AccidentesTransito/ListaPersonas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d176cf5de4ca9bdd92d2f23d58a2a3bed1651399", @"/Pages/AccidentesTransito/ListaPersonas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ab60bfe578d84bc7e47fef422cbf1e6e510d96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AccidentesTransito_ListaPersonas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "AccidentesTransito/ListaPersonas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Personas</h2>\n<table class=\"table table-bordered\">\n     <tr>\n\n<caption>Información Personas</caption>\n\n <th scope=\"col\" > Numero Documento</td>\n <th scope=\"col\" > Nombres</td>\n <th scope=\"col\" > Apellidos</td>\n <th scope=\"col\" > Genero</td>\n<tbody>\n");
#nullable restore
#line 17 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"
     foreach (var perso in Model.personas)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n\n            <td > ");
#nullable restore
#line 23 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"
             Write(perso.NumeroIdentificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 24 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"
             Write(perso.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 25 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"
             Write(perso.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 26 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"
             Write(perso.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n             <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d176cf5de4ca9bdd92d2f23d58a2a3bed16513995528", async() => {
                WriteLiteral("\n             Detalle Persona");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"
                                                                                                     WriteLiteral(perso.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n\n\n\n\n        </tr>\n");
#nullable restore
#line 35 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\ListaPersonas.cshtml"


   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\n</table>\n\n\n");
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcciTransito.App.Frontend.Pages.ListModel1> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.ListModel1> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.ListModel1>)PageContext?.ViewData;
        public AcciTransito.App.Frontend.Pages.ListModel1 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
