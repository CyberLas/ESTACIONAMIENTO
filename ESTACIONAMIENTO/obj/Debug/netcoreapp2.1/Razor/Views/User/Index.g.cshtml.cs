#pragma checksum "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276964912f95d0ec47ccaea092284fc0ff063952"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276964912f95d0ec47ccaea092284fc0ff063952", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 34, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <label id=\"nombre\">");
            EndContext();
            BeginContext(64, 15, false);
#line 8 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml"
                  Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(79, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(81, 14, false);
#line 8 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml"
                                   Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(95, 68, true);
            WriteLiteral("</label>\r\n    <hr />\r\n    <div>\r\n        <label>Correo electronico: ");
            EndContext();
            BeginContext(164, 11, false);
#line 11 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml"
                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(175, 66, true);
            WriteLiteral("</label>\r\n    </div>\r\n    <div>\r\n        <label>Fecha Nacimiento: ");
            EndContext();
            BeginContext(242, 33, false);
#line 14 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml"
                            Write(Model.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(275, 62, true);
            WriteLiteral("</label>\r\n    </div>\r\n    \r\n    <div>\r\n        <label>Genero: ");
            EndContext();
            BeginContext(338, 12, false);
#line 18 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Index.cshtml"
                  Write(Model.Genero);

#line default
#line hidden
            EndContext();
            BeginContext(350, 30, true);
            WriteLiteral("</label>\r\n    </div>\r\n</div>\r\n");
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
