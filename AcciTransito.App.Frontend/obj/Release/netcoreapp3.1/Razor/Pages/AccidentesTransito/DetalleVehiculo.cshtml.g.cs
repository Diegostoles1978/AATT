#pragma checksum "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d982b86a763efbc593460204101467b3de55261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcciTransito.App.Frontend.Pages.AccidentesTransito.Pages_AccidentesTransito_DetalleVehiculo), @"mvc.1.0.razor-page", @"/Pages/AccidentesTransito/DetalleVehiculo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d982b86a763efbc593460204101467b3de55261", @"/Pages/AccidentesTransito/DetalleVehiculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ab60bfe578d84bc7e47fef422cbf1e6e510d96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AccidentesTransito_DetalleVehiculo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AccidentesTransito/ListaVehiculos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            WriteLiteral("<h2>");
#nullable restore
#line 7 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml"
Write(Model.vehiculos.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<p>Placa  ");
#nullable restore
#line 9 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml"
     Write(Model.vehiculos.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Marca: ");
#nullable restore
#line 10 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml"
     Write(Model.vehiculos.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p> Modelo: ");
#nullable restore
#line 11 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml"
       Write(Model.vehiculos.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Tipo de Vehiculo: ");
#nullable restore
#line 12 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml"
                Write(Model.vehiculos.TipoVehiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Licencia de Transito: ");
#nullable restore
#line 13 "C:\Users\mileniso\Documents\GitHub\AATT\AcciTransito.App.Frontend\Pages\AccidentesTransito\DetalleVehiculo.cshtml"
                    Write(Model.vehiculos.LicenciaTransito);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d982b86a763efbc593460204101467b3de552615554", async() => {
                WriteLiteral("Lista de Vehiculos");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcciTransito.App.Frontend.Pages.DetalleVehiculoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.DetalleVehiculoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcciTransito.App.Frontend.Pages.DetalleVehiculoModel>)PageContext?.ViewData;
        public AcciTransito.App.Frontend.Pages.DetalleVehiculoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
