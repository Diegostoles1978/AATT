#pragma checksum "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\Personas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fab7714d4b5f8b90bcf3892d6b2b796644f1feb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcciTransito.App.Frontend.Pages.Personas.Pages_Personas_List), @"mvc.1.0.razor-page", @"/Pages/Personas/List.cshtml")]
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
#line 1 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\_ViewImports.cshtml"
using AcciTransito.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fab7714d4b5f8b90bcf3892d6b2b796644f1feb", @"/Pages/Personas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ab60bfe578d84bc7e47fef422cbf1e6e510d96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Personas</h2>\n<table  class=\"table\">\n");
#nullable restore
#line 8 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\Personas\List.cshtml"
     foreach (var perso in Model.personas)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n<tr>\n            <th scope=\"row\">Nombres</th>\n            <th scope=\"row\">Apellidos</th>\n            <th scope=\"row\">Dirección</th>  </tr>\n\n            <td > ");
#nullable restore
#line 18 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\Personas\List.cshtml"
             Write(perso.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n            <td > ");
#nullable restore
#line 21 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\Personas\List.cshtml"
             Write(perso.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n            <td > ");
#nullable restore
#line 24 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\Personas\List.cshtml"
             Write(perso.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\Personas\List.cshtml"

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
