#pragma checksum "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459c22743b8febcd2a91996b37d6fbe1a60b8d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HappyPet.App.Frontend.Pages.Administrador.Historias.Pages_Administrador_Historias_Historia), @"mvc.1.0.razor-page", @"/Pages/Administrador/Historias/Historia.cshtml")]
namespace HappyPet.App.Frontend.Pages.Administrador.Historias
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
#line 1 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/_ViewImports.cshtml"
using HappyPet.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459c22743b8febcd2a91996b37d6fbe1a60b8d64", @"/Pages/Administrador/Historias/Historia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24c5d0bf85d4573e43c77f261f7ce9d1e3e935d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Administrador_Historias_Historia : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Crear/CrearHistoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Buscar/BuscarHistoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btm primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Detalles/Detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../../index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
    
    .main-title{
        text-align: center;
        color: whitesmoke;
        background-color: black;
        border-radius: 15px;
        padding: 20px;
        
    }

    .container-buttons{ 
          
        display: flex;
        justify-content:space-evenly;
        background-color: aliceblue !important;
        padding: 2rem;
    }

    .container-buttons a:hover{
        background-color: black;
        color: gold;
    }

    .container-buttons a:active{
        background-color: black !important;
    }


    .position-table{
        padding: 1rem;
        padding-top: 3rem;
    }

    .container-buttons-bootom{
        display: flex;
        justify-content: center;
        background-color: aliceblue !important;
        padding: 2rem;
    }

    .container-buttons-bootom a:hover{
        background-color: black;
        color: gold;
    }
    
    .container-buttons-bootom a:active{
        background-color: black !important;
      ");
            WriteLiteral(" \r\n    }\r\n\r\n\r\n</style>\r\n\r\n<main>\r\n    <h1 class=\"main-title\">Menu Historias Clinicas</h1>\r\n \r\n    <aside class=\"container-buttons\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459c22743b8febcd2a91996b37d6fbe1a60b8d646594", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus fa-lg\"></i><br><b>Crear</b>\r\n        ");
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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459c22743b8febcd2a91996b37d6fbe1a60b8d647894", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-search fa-lg\"></i><br><b>Buscar</b>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </aside>\r\n    <section class=\"position-table\">\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Mascota</th>\r\n                <th>Peso (Kgs)</th>\r\n");
            WriteLiteral("                <th>Temperatura (°C)</th>\r\n                <th>Estado de Salud</th>\r\n                <th>&nbsp;&nbsp;Info.</th>\r\n            </tr>\r\n");
#nullable restore
#line 81 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
             foreach (var item in Model.HistoriaClinicas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 84 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                     if(item.Mascota != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <td>");
#nullable restore
#line 86 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                     Write(item.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 87 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <td>N/A</td>\r\n");
#nullable restore
#line 89 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 90 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                   Write(item.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                   Write(item.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                   Write(item.EstadoDeSalud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459c22743b8febcd2a91996b37d6fbe1a60b8d6412293", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle fa-lg\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idHistoria", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idHistoria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 97 "/Users/europe/Desktop/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Administrador/Historias/Historia.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </section>\r\n    <aside class=\"container-buttons-bootom\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459c22743b8febcd2a91996b37d6fbe1a60b8d6415061", async() => {
                WriteLiteral("<i class=\"fas fa-house-user fa-lg\"></i><br><b>Home</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </aside>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HappyPet.App.Frontend.Pages.Administrador.Historias.HistoriaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HappyPet.App.Frontend.Pages.Administrador.Historias.HistoriaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HappyPet.App.Frontend.Pages.Administrador.Historias.HistoriaModel>)PageContext?.ViewData;
        public HappyPet.App.Frontend.Pages.Administrador.Historias.HistoriaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591