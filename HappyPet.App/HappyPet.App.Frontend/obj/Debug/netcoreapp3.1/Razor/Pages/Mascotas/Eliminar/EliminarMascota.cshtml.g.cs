#pragma checksum "/Users/europe/Documents/Perfil Profesional/Proyectos/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/Mascotas/Eliminar/EliminarMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31facab10d51352fd057c831156f1820f39f2a3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HappyPet.App.Frontend.Pages.Mascotas.Eliminar.Pages_Mascotas_Eliminar_EliminarMascota), @"mvc.1.0.razor-page", @"/Pages/Mascotas/Eliminar/EliminarMascota.cshtml")]
namespace HappyPet.App.Frontend.Pages.Mascotas.Eliminar
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
#line 1 "/Users/europe/Documents/Perfil Profesional/Proyectos/HappyPet_Personal/HappyPet.App/HappyPet.App.Frontend/Pages/_ViewImports.cshtml"
using HappyPet.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31facab10d51352fd057c831156f1820f39f2a3a", @"/Pages/Mascotas/Eliminar/EliminarMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24c5d0bf85d4573e43c77f261f7ce9d1e3e935d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_Eliminar_EliminarMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Mascota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        background-color: black !important;
        color: gold;
    }

    .container-buttons a:active{
        background-color: black !important;
    }

  .main-subtitle{
        text-align: center;
        background-color: aliceblue;
        border-radius: 1rem;    
  }

</style>
<h1 class=""main-title"">Formulario Eliminar Mascota</h1>

<h4 class=""main-subtitle"">La Mascota ha sido eliminada</h4>

<aside class=""container-buttons"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31facab10d51352fd057c831156f1820f39f2a3a4636", async() => {
                WriteLiteral("<i class=\"fas fa-boxes fa-lg\"></i><br><strong>Menu Mascotas</strong>");
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
            WriteLiteral("\r\n");
            WriteLiteral("</aside>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HappyPet.App.Frontend.Pages.Mascotas.Eliminar.EliminarMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HappyPet.App.Frontend.Pages.Mascotas.Eliminar.EliminarMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HappyPet.App.Frontend.Pages.Mascotas.Eliminar.EliminarMascotaModel>)PageContext?.ViewData;
        public HappyPet.App.Frontend.Pages.Mascotas.Eliminar.EliminarMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
