#pragma checksum "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\Shared\Components\TopNavBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a290020300dccb53271ac9cce512b7e74f0562b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopNavBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopNavBar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a290020300dccb53271ac9cce512b7e74f0562b", @"/Views/Shared/Components/TopNavBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015a6223c1a9d95244fa422b3bf3332c0b75a261", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopNavBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Project.UI.Models.ToDoListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("toDoListAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<header class=""main-header"">
    <nav class=""navbar navbar-static-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <a href=""../../index2.html"" class=""navbar-brand"">My ToDoApp</a>
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar-collapse"">
                    <i class=""fa fa-bars""></i>
                </button>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class=""collapse navbar-collapse pull-left"" id=""navbar-collapse"">
                <ul class=""nav navbar-nav"">
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">My ToDoLists <span class=""caret""></span></a>
                        <ul class=""dropdown-menu"" role=""menu"">
");
#nullable restore
#line 18 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\Shared\Components\TopNavBar\Default.cshtml"
                             foreach (var toDoList in Model.ToDoLists.OrderBy(x => x.Name__c))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1211, 1);
#nullable restore
#line 20 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\Shared\Components\TopNavBar\Default.cshtml"
WriteAttributeValue("", 1117, Url.RouteUrl(new { controller = "ToDoList", action = "GetToDoList", parentId = toDoList.Id }), 1117, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\Shared\Components\TopNavBar\Default.cshtml"
                                                                                                                                        Write(toDoList.Name__c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 21 "C:\Users\burha\OneDrive\Desktop\Projects\ToDoList\ToDoList.Project\ToDoList.Project.UI\Views\Shared\Components\TopNavBar\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </li>
                    <li>
                        <button type=""button"" class=""btn btn-default"" data-toggle=""modal"" data-target=""#modal-default"">
                            Create ToDoList
                        </button>
                    </li>
                    <li>
                        <a href=""#"">Update ToDoList</a>
                    </li>
                    <li>
                        <a href=""#"">Delete ToDoList</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
            <!-- Navbar Right Menu -->
            <!-- /.navbar-custom-menu -->
        </div>
        <!-- /.container-fluid -->
    </nav>
</header>
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
   ");
            WriteLiteral("                 <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n                <h4 class=\"modal-title\">Default Modal</h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a290020300dccb53271ac9cce512b7e74f0562b8002", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Name</label>
                        <input type=""text"" class=""form-control"" placeholder=""Enter ..."">
                    </div>
                    <div class=""form-group"">
                        <label>Due Date:</label>
                        <div class=""input-group date"">
                            <div class=""input-group-addon"">
                                <i class=""fa fa-calendar""></i>
                            </div>
                            <input type=""text"" class=""form-control pull-right"" id=""datepicker"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Project.UI.Models.ToDoListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591