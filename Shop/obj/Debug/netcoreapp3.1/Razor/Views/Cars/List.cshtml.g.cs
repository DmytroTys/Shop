#pragma checksum "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eac2d333412696ba4e47c2f78620861f3280a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.ViewModel.Cars.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
namespace Shop.ViewModel.Cars
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eac2d333412696ba4e47c2f78620861f3280a52", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"688b4751c7808d7a81964dc077cc75e54df71e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все автомобили</h1>\n<h3>");
#nullable restore
#line 2 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
Write(Model.carCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<div class=\"row mt-5 mb2\">\n");
#nullable restore
#line 4 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
      
        foreach (var car in Model.Allcars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\">\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 216, "\"", 230, 1);
#nullable restore
#line 8 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
WriteAttributeValue("", 222, car.img, 222, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 231, "\"", 246, 1);
#nullable restore
#line 8 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
WriteAttributeValue("", 237, car.name, 237, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\n                <div>Модель: ");
#nullable restore
#line 9 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
                        Write(car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <p>");
#nullable restore
#line 10 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
              Write(car.shortDisc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>Цена: ");
#nullable restore
#line 11 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
                    Write(car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("                <p><a class=\"btn btn-warning\" href=\"#\">Подробнее</a></p>\n            </div>\n");
#nullable restore
#line 15 "/Applications/Developer/C#/Shop/Shop/Views/Cars/List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
