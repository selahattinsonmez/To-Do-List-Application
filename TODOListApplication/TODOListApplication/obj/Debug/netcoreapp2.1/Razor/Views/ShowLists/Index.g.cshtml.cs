#pragma checksum "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d44959fdd0ecbe121ef348185ca1cef5706da113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowLists_Index), @"mvc.1.0.view", @"/Views/ShowLists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShowLists/Index.cshtml", typeof(AspNetCore.Views_ShowLists_Index))]
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
#line 1 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\_ViewImports.cshtml"
using TODOListApplication;

#line default
#line hidden
#line 2 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\_ViewImports.cshtml"
using TODOListApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44959fdd0ecbe121ef348185ca1cef5706da113", @"/Views/ShowLists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6713d56be5350b5e4be8428c1e1146a7c3f95ca1", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ListAndItemDTO>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "My Lists";

#line default
#line hidden
            BeginContext(123, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(152, 1085, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7962d2631f6460d92186e8449545a5c", async() => {
                BeginContext(158, 568, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Bootstrap 101 Template</title>

    <!-- Bootstrap -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
");
                EndContext();
#line 19 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
                BeginContext(768, 143, true);
                WriteLiteral("        <script type=\"text/javascript\">\r\n                                window.onload = function () {\r\n                                alert(\"");
                EndContext();
                BeginContext(912, 15, false);
#line 23 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                  Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(927, 26, true);
                WriteLiteral("\");};\r\n        </script>\r\n");
                EndContext();
#line 25 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(960, 270, true);
                WriteLiteral(@"    <script type=""text/javascript"">
        void myFunction(id){
            document.getElementById(id).remove();

        }
    </script>
    <style>
        .box {
            border: 1px solid #777;
            border-radius: 8px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1237, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1239, 4474, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2997ec5fe7b419fafbf38eef02c0529", async() => {
                BeginContext(1245, 36, true);
                WriteLiteral("\r\n    <div class=\"container main\">\r\n");
                EndContext();
#line 41 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(1330, 149, true);
                WriteLiteral("        <div class=\"list-group\" style=\"margin-bottom:40px\">\r\n            <a  class=\"list-group-item list-group-item-action active\">\r\n                ");
                EndContext();
                BeginContext(1480, 13, false);
#line 45 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
           Write(item.listName);

#line default
#line hidden
                EndContext();
                BeginContext(1493, 20, true);
                WriteLiteral("\r\n            </a>\r\n");
                EndContext();
#line 47 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
             foreach (var item2 in item.toDoItems)
            {

#line default
#line hidden
                BeginContext(1580, 61, true);
                WriteLiteral("                <button data-toggle=\"collapse\" data-target=\"#");
                EndContext();
                BeginContext(1642, 23, false);
#line 49 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                                        Write(item2.toDoItem.itemName);

#line default
#line hidden
                EndContext();
                BeginContext(1665, 98, true);
                WriteLiteral("\" class=\"list-group-item list-group-item-action btn btn-primary text-center align-content-center\">");
                EndContext();
                BeginContext(1764, 23, false);
#line 49 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                                                                                                                                                                  Write(item2.toDoItem.itemName);

#line default
#line hidden
                EndContext();
                BeginContext(1787, 48, true);
                WriteLiteral("</button>\r\n                <div class=\"collapse\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1835, "\"", 1864, 1);
#line 50 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 1840, item2.toDoItem.itemName, 1840, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1865, 225, true);
                WriteLiteral(">\r\n                    <div class=\"card\" style=\"width: 18rem;\">\r\n                        <ul style=\"margin-left:50px\" class=\"list-group list-group-flush\">\r\n                            <li class=\"list-group-item\">Description: ");
                EndContext();
                BeginContext(2091, 30, false);
#line 53 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                                                Write(item2.toDoItem.itemDescription);

#line default
#line hidden
                EndContext();
                BeginContext(2121, 73, true);
                WriteLiteral("</li>\r\n                            <li class=\"list-group-item\">Deadline: ");
                EndContext();
                BeginContext(2195, 27, false);
#line 54 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                                             Write(item2.toDoItem.itemDeadline);

#line default
#line hidden
                EndContext();
                BeginContext(2222, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 55 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                             if (item2.dependencies.Count > 0)
                            {

#line default
#line hidden
                BeginContext(2324, 134, true);
                WriteLiteral("                                <p style=\"margin-left:20px;margin-top:10px;\">Dependencies:</p>\r\n                                <ul>\r\n");
                EndContext();
#line 59 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                     foreach (var dependency in item2.dependencies)
                                    {

#line default
#line hidden
                BeginContext(2582, 89, true);
                WriteLiteral("                                        <li style=\"margin-left:0px; margin-bottom:10px;\">");
                EndContext();
                BeginContext(2672, 10, false);
#line 61 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                                                                    Write(dependency);

#line default
#line hidden
                EndContext();
                BeginContext(2682, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 62 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2728, 39, true);
                WriteLiteral("                                </ul>\r\n");
                EndContext();
#line 64 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(2798, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 65 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                             if (item2.toDoItem.status)
                            {

#line default
#line hidden
                BeginContext(2886, 83, true);
                WriteLiteral("                                <li class=\"list-group-item\">Status: complete</li>\r\n");
                EndContext();
#line 68 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"

                            }
                            else if (!item2.toDoItem.expired)
                            {

#line default
#line hidden
                BeginContext(3096, 82, true);
                WriteLiteral("                                <li class=\"list-group-item\">Status: expired</li>\r\n");
                EndContext();
#line 73 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
                BeginContext(3276, 87, true);
                WriteLiteral("                                <li class=\"list-group-item\">Status: Not complete</li>\r\n");
                EndContext();
#line 78 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(3394, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 79 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                             if (!item2.toDoItem.status && item2.toDoItem.expired)
                            {

#line default
#line hidden
                BeginContext(3509, 60, true);
                WriteLiteral("                                <li class=\"list-group-item \"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3569, "\"", 3596, 1);
#line 81 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 3574, item2.toDoItem.itemId, 3574, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3597, 39, true);
                WriteLiteral(">\r\n                                    ");
                EndContext();
                BeginContext(3636, 564, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eef2a56e47a47dfbc753947c16d1fa3", async() => {
                    BeginContext(3642, 134, true);
                    WriteLiteral("\r\n                                        <input type=\"button\" name=\"button\" class=\"btn btn-success\" title=\"Complete\" value=\"Complete\"");
                    EndContext();
                    BeginWriteAttribute("onclick", " onclick=\"", 3776, "\"", 3898, 3);
                    WriteAttributeValue("", 3786, "location.href=\'", 3786, 15, true);
#line 83 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 3801, Url.Action("indexButtons", "ShowLists", new { button = "complete" ,id = item2.toDoItem.itemId}), 3801, 96, false);

#line default
#line hidden
                    WriteAttributeValue("", 3897, "\'", 3897, 1, true);
                    EndWriteAttribute();
                    BeginContext(3899, 132, true);
                    WriteLiteral(" />\r\n                                        <input type=\"button\" name=\"button\" class=\"btn btn-danger\" title=\"Delete\" value=\"Delete\"");
                    EndContext();
                    BeginWriteAttribute("onclick", " onclick=\"", 4031, "\"", 4151, 4);
                    WriteAttributeValue("", 4041, "location.href=\'", 4041, 15, true);
#line 84 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 4056, Url.Action("indexButtons", "ShowLists", new { button = "delete",id = item2.toDoItem.itemId}), 4056, 93, false);

#line default
#line hidden
                    WriteAttributeValue("", 4149, "\'", 4149, 1, true);
                    WriteAttributeValue(" ", 4150, "", 4151, 1, true);
                    EndWriteAttribute();
                    BeginContext(4152, 41, true);
                    WriteLiteral(" />\r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4200, 43, true);
                WriteLiteral("\r\n\r\n                                </li>\r\n");
                EndContext();
#line 88 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(4274, 91, true);
                WriteLiteral("\r\n\r\n\r\n                        </ul>\r\n\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 96 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(4380, 115, true);
                WriteLiteral("                <div class=\"list-group-item list-group-item-action btn btn-primary  \">\r\n                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4495, "\"", 4581, 3);
                WriteAttributeValue("", 4505, "location.href=\'", 4505, 15, true);
#line 98 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 4520, Url.Action("addItem", "Create", new {listId = item.listId}), 4520, 60, false);

#line default
#line hidden
                WriteAttributeValue("", 4580, "\'", 4580, 1, true);
                EndWriteAttribute();
                BeginContext(4582, 94, true);
                WriteLiteral(" style=\"border-radius:5px;\" class=\"btn-success\">Add Item</button>\r\n                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4676, "\"", 4766, 3);
                WriteAttributeValue("", 4686, "location.href=\'", 4686, 15, true);
#line 99 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 4701, Url.Action("showList", "ShowLists", new {listId = item.listId}), 4701, 64, false);

#line default
#line hidden
                WriteAttributeValue("", 4765, "\'", 4765, 1, true);
                EndWriteAttribute();
                BeginContext(4767, 98, true);
                WriteLiteral(" style=\"border-radius:5px;\" class=\"btn-light\">Filter/Order</button>\r\n\r\n                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4865, "\"", 4957, 3);
                WriteAttributeValue("", 4875, "location.href=\'", 4875, 15, true);
#line 101 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"
WriteAttributeValue("", 4890, Url.Action("deleteList", "ShowLists", new {listId = item.listId}), 4890, 66, false);

#line default
#line hidden
                WriteAttributeValue("", 4956, "\'", 4956, 1, true);
                EndWriteAttribute();
                BeginContext(4958, 112, true);
                WriteLiteral(" style=\"border-radius:5px;\" class=\"btn-danger\">Delete</button>\r\n\r\n\r\n                </div>\r\n\r\n\r\n        </div>\r\n");
                EndContext();
#line 108 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\ShowLists\Index.cshtml"



        }

#line default
#line hidden
                BeginContext(5087, 619, true);
                WriteLiteral(@"    </div>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5713, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ListAndItemDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
