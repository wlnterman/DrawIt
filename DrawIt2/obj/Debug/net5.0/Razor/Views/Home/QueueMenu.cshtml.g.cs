#pragma checksum "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25e5eac637265b26eca1f48ab17ab9a5b68ce197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QueueMenu), @"mvc.1.0.view", @"/Views/Home/QueueMenu.cshtml")]
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
#line 1 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\_ViewImports.cshtml"
using DrawIt2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\_ViewImports.cshtml"
using DrawIt2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e5eac637265b26eca1f48ab17ab9a5b68ce197", @"/Views/Home/QueueMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7fae9edfdbd1d0fcbc9a4a8f99e170a4a8e611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QueueMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml"
  
    ViewData["Title"] = "QueueMenu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""display:flex;justify-content:space-between"">
    <h1>QueueMenu</h1>
    <!-- Button trigger modal -->
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
        Create Room
    </button>
</div>
");
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Draw Rooms</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml"
     for (int i = 1; i < 10; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th> <a");
            BeginWriteAttribute("href", " href=\"", 573, "\"", 607, 1);
#nullable restore
#line 25 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml"
WriteAttributeValue("", 580, Url.Action("Index","Home"), 580, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">text</a></th>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table> \r\n\r\n");
#nullable restore
#line 30 "C:\Users\vlll\source\repos\DrawIt\DrawIt2\Views\Home\QueueMenu.cshtml"
Write(await Html.PartialAsync("~/Views/Home/Partials/CreateRoomModal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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