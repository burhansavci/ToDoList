#pragma checksum "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "813b2ddfab306299edb102ef4d153ec4d568a5f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoList_GetToDoList), @"mvc.1.0.view", @"/Views/ToDoList/GetToDoList.cshtml")]
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
#line 1 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\_ViewImports.cshtml"
using ToDoList.Project.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\_ViewImports.cshtml"
using ToDoList.Project.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813b2ddfab306299edb102ef4d153ec4d568a5f0", @"/Views/ToDoList/GetToDoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015a6223c1a9d95244fa422b3bf3332c0b75a261", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoList_GetToDoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList.Project.Models.Entities.ToDoList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml"
  
    ViewData["Title"] = "GetToDoList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml"
 foreach (var toDoList in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"callout callout-info\">\r\n        <h4>");
#nullable restore
#line 10 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml"
       Write(toDoList.Name__c);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       ");
#nullable restore
#line 10 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml"
                                                               Write(toDoList.Duedate__c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> \r\n\r\n        <p>\r\n         ");
#nullable restore
#line 13 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml"
    Write(toDoList.IsCompleted__c);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\ToDoList\GetToDoList.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList.Project.Models.Entities.ToDoList>> Html { get; private set; }
    }
}
#pragma warning restore 1591