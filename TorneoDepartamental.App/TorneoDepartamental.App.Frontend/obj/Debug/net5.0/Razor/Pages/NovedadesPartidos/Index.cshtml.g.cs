#pragma checksum "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eb9a7c96c23c7652a099a5bc4e8ace09abcdf74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos.Pages_NovedadesPartidos_Index), @"mvc.1.0.razor-page", @"/Pages/NovedadesPartidos/Index.cshtml")]
namespace TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos
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
#line 1 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoDepartamental.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb9a7c96c23c7652a099a5bc4e8ace09abcdf74", @"/Pages/NovedadesPartidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2689d21daeb3dc1e88c17cc62ec7dce2bb75c7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NovedadesPartidos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listado de Novedades de Partidos</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Minuto Partido</th>
            <th scope=""col"">Tarjeta</th>
            <th scope=""col"">Gol</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml"
         foreach (var novPartido in Model.NovedadesPartidos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml"
               Write(novPartido.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml"
               Write(novPartido.MinutoPartido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml"
               Write(novPartido.Tarjeta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml"
               Write(novPartido.Gol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\alexander.alzate\Documents\MisionTIC_2022\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\NovedadesPartidos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos.IndexModel>)PageContext?.ViewData;
        public TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
