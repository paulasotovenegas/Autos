#pragma checksum "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df404ea0fdaac53ea1f1ef32381e90d84521746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autos_Index), @"mvc.1.0.view", @"/Views/Autos/Index.cshtml")]
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
#line 1 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\_ViewImports.cshtml"
using FrontEnd.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\_ViewImports.cshtml"
using FrontEnd.API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df404ea0fdaac53ea1f1ef32381e90d84521746", @"/Views/Autos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d940b264254a42355fc4a51019f4b59e72f15668", @"/Views/_ViewImports.cshtml")]
    public class Views_Autos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrontEnd.API.Models.Autos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container my-5\">\n    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df404ea0fdaac53ea1f1ef32381e90d845217465580", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n    <div class=\"table-responsive\">\n        <table class=\"table table-bordered table-sm\">\n            <thead>\n                <tr>\n                    <th>\n                        ");
#nullable restore
#line 15 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 18 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 21 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Anio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 24 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Kilometraje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 27 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TerminacionPlaca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 30 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cpuertas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 33 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 36 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 39 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 42 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 45 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Combustible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 48 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 51 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 54 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 57 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 60 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Transmision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 67 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 71 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 74 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 77 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Anio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 80 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Kilometraje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 83 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.TerminacionPlaca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 86 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cpuertas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 89 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 92 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 95 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9df404ea0fdaac53ea1f1ef32381e90d8452174616591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
           WriteLiteral("~/Image/"+ item.Imagen);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 98 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 101 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Combustible.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 104 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Estado.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 107 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Marca.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 110 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Modelo.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 113 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Tipo.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 116 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Transmision.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n\n        <td>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df404ea0fdaac53ea1f1ef32381e90d8452174621020", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                                   WriteLiteral(item.Id);

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
            WriteLiteral(" |\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df404ea0fdaac53ea1f1ef32381e90d8452174623221", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                                      WriteLiteral(item.Id);

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
            WriteLiteral(" |\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df404ea0fdaac53ea1f1ef32381e90d8452174625428", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
                                     WriteLiteral(item.Id);

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
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 125 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Autos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrontEnd.API.Models.Autos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
