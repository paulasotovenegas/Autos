#pragma checksum "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad565f827b9db5d0ded9644246d805d27590bd22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Create), @"mvc.1.0.view", @"/Views/Roles/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad565f827b9db5d0ded9644246d805d27590bd22", @"/Views/Roles/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d940b264254a42355fc4a51019f4b59e72f15668", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrontEnd.API.Models.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 14 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
 using (Html.BeginForm("Create", "Roles"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container form-horizontal pt-5\">\r\n        <h4>Create Role</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 23 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
       Write(Html.LabelFor(model => model.Descripcion, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-sm-4 col-6\">\r\n                ");
#nullable restore
#line 27 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
           Write(Html.EditorFor(model => model.Descripcion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Descripcion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>



        <div class=""form-group mt-3"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-success"" />
            </div>
        </div>



    </div>
");
#nullable restore
#line 43 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    ");
#nullable restore
#line 48 "E:\11 Cuatrimestre\Programacion Avanzada Web\Clase 15\Proyecto_Autos_Repo\Solution.UI\FrontEnd.API\Views\Roles\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontEnd.API.Models.Roles> Html { get; private set; }
    }
}
#pragma warning restore 1591
