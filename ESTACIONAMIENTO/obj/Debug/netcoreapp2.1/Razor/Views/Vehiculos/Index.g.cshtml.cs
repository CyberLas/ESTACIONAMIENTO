#pragma checksum "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec12fc14aaeef4d90699044a9e151d9014c4c841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculos_Index), @"mvc.1.0.view", @"/Views/Vehiculos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehiculos/Index.cshtml", typeof(AspNetCore.Views_Vehiculos_Index))]
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
#line 1 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot;

#line default
#line hidden
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec12fc14aaeef4d90699044a9e151d9014c4c841", @"/Views/Vehiculos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 7 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
     foreach (var vehiculo in Model) 
    { 
        

#line default
#line hidden
            BeginContext(95, 114, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                <label>\r\n                    Tipo: ");
            EndContext();
            BeginContext(210, 13, false);
#line 13 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
                     Write(vehiculo.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(223, 185, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <label>\r\n                    Color:\r\n                    <input type=\"Color\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 408, "\"", 431, 1);
#line 19 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
WriteAttributeValue("", 416, vehiculo.Color, 416, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 145, true);
            WriteLiteral(" />\r\n                </label>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <label>\r\n                    Descripcion: ");
            EndContext();
            BeginContext(578, 20, false);
#line 24 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
                            Write(vehiculo.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(598, 136, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <label>\r\n                    Marca: ");
            EndContext();
            BeginContext(735, 14, false);
#line 29 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
                      Write(vehiculo.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(749, 137, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <label>\r\n                    Modelo: ");
            EndContext();
            BeginContext(887, 15, false);
#line 34 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
                       Write(vehiculo.Modelo);

#line default
#line hidden
            EndContext();
            BeginContext(902, 102, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1044, 2);
            WriteAttributeValue("", 1011, "/Vehiculos/Borrar?id=", 1011, 21, true);
#line 38 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
WriteAttributeValue("", 1032, vehiculo.Id, 1032, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1045, 65, true);
            WriteLiteral(" class=\"btn\">Borrar</a>\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 43 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Vehiculos\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1117, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591