#pragma checksum "C:\reto 3 mision tic\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\Estadios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a4cf9e0ab57de132321ffdc5078441ea180d7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoDepartamental.App.Frontend.Pages.Estadios.Pages_Estadios_Index), @"mvc.1.0.razor-page", @"/Pages/Estadios/Index.cshtml")]
namespace TorneoDepartamental.App.Frontend.Pages.Estadios
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
#line 1 "C:\reto 3 mision tic\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoDepartamental.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a4cf9e0ab57de132321ffdc5078441ea180d7c", @"/Pages/Estadios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2689d21daeb3dc1e88c17cc62ec7dce2bb75c7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estadios_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Lista de Estadios</h1>\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">Id</th>\r\n            <th scope=\"col\">Nombre</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    </tbody>\r\n");
#nullable restore
#line 15 "C:\reto 3 mision tic\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\Estadios\Index.cshtml"
     foreach (var estadio in Model.estadios)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\reto 3 mision tic\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\Estadios\Index.cshtml"
           Write(estadio.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\reto 3 mision tic\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\Estadios\Index.cshtml"
           Write(estadio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\reto 3 mision tic\MisionTIC2022\TorneoDepartamental.App\TorneoDepartamental.App.Frontend\Pages\Estadios\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoDepartamental.App.Frontend.Pages.Estadios.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoDepartamental.App.Frontend.Pages.Estadios.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoDepartamental.App.Frontend.Pages.Estadios.IndexModel>)PageContext?.ViewData;
        public TorneoDepartamental.App.Frontend.Pages.Estadios.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
