#pragma checksum "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9414c358441aea7e51282063393dc82aa851400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcciTransito.App.Frontend.Pages.Personas.Pages_Personas_ListaPersonas), @"mvc.1.0.razor-page", @"/Pages/Personas/ListaPersonas.cshtml")]
namespace AcciTransito.App.Frontend.Pages.Personas
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
#line 1 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\_ViewImports.cshtml"
using AcciTransito.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9414c358441aea7e51282063393dc82aa851400", @"/Pages/Personas/ListaPersonas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ab60bfe578d84bc7e47fef422cbf1e6e510d96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_ListaPersonas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9414c358441aea7e51282063393dc82aa8514003004", async() => {
                WriteLiteral("\n<h2>Personas</h2>\n<table class=\"table table-bordered\">\n<caption>Información Personas</caption>\n");
#nullable restore
#line 9 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"
     foreach (var perso in Model.personas)
    {



#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n\n            <td > ");
#nullable restore
#line 15 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"
             Write(perso.TipoDocumento);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 16 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"
             Write(perso.NumeroIdentificacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 17 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"
             Write(perso.Nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 18 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"
             Write(perso.Apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td > ");
#nullable restore
#line 19 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"
             Write(perso.Genero);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n\n\n\n        </tr>\n");
#nullable restore
#line 25 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.frontend\Pages\Personas\ListaPersonas.cshtml"


   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
</table>


<div class=""d-grid gap- d-md-flex justify-content-md-end relative fullwidth col-xs-15end"">
 <button type=""submit"" id=""actualizar"" name=""submit"" class=""form-btn-submit semibold"" style=""color:teal; background-color:white; height:50px; width:100px; font-size:16px;"" >Actualizar</button>
 <button type=""submit"" id=""eliminar"" name=""submit"" class=""form-btn-submit semibold"" style=""color:teal;background-color:white;  height:50px; width:100px; font-size:16px;"">Eliminar</button>
 <button type=""submit"" id=""eliminar"" name=""submit"" class=""form-btn-submit semibold"" style=""color:teal; background-color:white; height:50px; width:100px; font-size:16px;"">Guardar</button>
  </div>
     <div class=""clear""></div>

");
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
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcciTransito.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public AcciTransito.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591