#pragma checksum "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\Create\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a7d818d17be1b1077b3c0bf10a63f3d2b025c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_Index), @"mvc.1.0.view", @"/Views/Create/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Create/Index.cshtml", typeof(AspNetCore.Views_Create_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a7d818d17be1b1077b3c0bf10a63f3d2b025c6", @"/Views/Create/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6713d56be5350b5e4be8428c1e1146a7c3f95ca1", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Input your list name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-min-length", new global::Microsoft.AspNetCore.Html.HtmlString("8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("listName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Input your list name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\Create\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(134, 12419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db1b6a836d444801aac22e0dc87971ff", async() => {
                BeginContext(140, 12406, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Bootstrap 101 Template</title>

    <!-- Bootstrap -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <style>
        .form-container div, .form-container span {
            font-family: Calibri, Candara, Segoe, 'Segoe UI', Optima, Arial, sans-serif;
        }

        .form-container ::-webkit-input-placeholder { /* WebKit, Blink, Edge */
            color: #999;
        }

        .form-container :-moz-placeholder { /* Mozilla Firefox 4 to 18 */
            color: #999;
            opacity: 1;
        }

        .form-container ::-m");
                WriteLiteral(@"oz-placeholder { /* Mozilla Firefox 19+ */
            color: #999;
            opacity: 1;
        }

        .form-container :-ms-input-placeholder { /* Internet Explorer 10-11 */
            color: #999;
        }

        .form-container :placeholder-shown { /* Standard (https://drafts.csswg.org/selectors-4/#placeholder) */
            color: #999;
        }

        .oauth-buttons {
            text-align: center;
        }

        .row {
            text-align: center;
        }

        #login-form {
            min-width: 375px;
        }

        .login-container {
            width: 400px;
            height: 330px;
            display: inline-block;
            margin-top: -165px;
            top: 50%;
            left: 50%;
            position: absolute;
            margin-left: -200px;
        }

        .form-container .create-account:hover {
            opacity: .7;
        }

        .form-container .create-account {
            color: inherit;
     ");
                WriteLiteral(@"       margin-top: 15px;
            display: inline-block;
            cursor: pointer;
            text-decoration: none;
        }

        .oauth-buttons .fa {
            cursor: pointer;
            margin-top: 10px;
            color: inherit;
            width: 30px;
            height: 30px;
            text-align: center;
            line-height: 30px;
            margin: 5px;
            margin-top: 15px;
        }

            .oauth-buttons .fa:hover {
                color: white;
            }

        .oauth-buttons .fa-google-plus:hover {
            background: #dd4b39;
        }

        .oauth-buttons .fa-facebook:hover {
            background: #8b9dc3;
        }

        .oauth-buttons .fa-linkedin:hover {
            background: #0077b5;
        }

        .oauth-buttons .fa-twitter:hover {
            background: #55acee;
        }

        .form-container .req-input .input-status {
            display: inline-block;
            height: 40px;
  ");
                WriteLiteral(@"          width: 40px;
            float: left;
        }

        .form-container .input-status::before {
            content: "" "";
            height: 20px;
            width: 20px;
            position: absolute;
            top: 10px;
            left: 10px;
            color: white;
            border-radius: 50%;
            background: white;
            -webkit-transition: all .3s ease-in-out;
            -moz-transition: all .3s ease-in-out;
            -o-transition: all .3s ease-in-out;
            transition: all .3s ease-in-out;
        }

        .form-container .input-status::after {
            content: "" "";
            height: 10px;
            width: 10px;
            position: absolute;
            top: 15px;
            left: 15px;
            color: white;
            border-radius: 50%;
            background: #00BCD4;
            -webkit-transition: all .3s ease-in-out;
            -moz-transition: all .3s ease-in-out;
            -o-transition: all .3s e");
                WriteLiteral(@"ase-in-out;
            transition: all .3s ease-in-out;
        }

        .form-container .req-input {
            width: 100%;
            float: left;
            position: relative;
            background: #00BCD4;
            height: 40px;
            display: inline-block;
            border-radius: 0px;
            margin: 5px 0px;
            -webkit-transition: all .3s ease-in-out;
            -moz-transition: all .3s ease-in-out;
            -o-transition: all .3s ease-in-out;
            transition: all .3s ease-in-out;
        }

        .form-container div .row .invalid:hover {
            background: #EF9A9A;
        }

        .form-container div .row .invalid {
            background: #E57373;
        }

        .form-container .invalid .input-status:before {
            width: 20px;
            height: 4px;
            top: 19px;
            left: 10px;
            background: white; /*#F44336;*/
            border-radius: 0px;
            -ms-transform: rot");
                WriteLiteral(@"ate(45deg); /* IE 9 */
            -webkit-transform: rotate(45deg); /* Chrome, Safari, Opera */
            transform: rotate(45deg);
        }

        .form-container .invalid .input-status:after {
            width: 20px;
            height: 4px;
            background: white;
            border-radius: 0px;
            top: 19px;
            left: 10px;
            -ms-transform: rotate(-45deg); /* IE 9 */
            -webkit-transform: rotate(-45deg); /* Chrome, Safari, Opera */
            transform: rotate(-45deg);
        }

        .form-container div .row .valid:hover {
            background: #A5D6A7;
        }

        .form-container div .row .valid {
            background: #81C784;
        }

        .form-container .valid .input-status:after {
            border-radius: 0px;
            width: 17px;
            height: 4px;
            background: white;
            top: 16px;
            left: 15px;
            -ms-transform: rotate(-45deg);
            -webk");
                WriteLiteral(@"it-transform: rotate(-45deg);
            transform: rotate(-45deg);
        }

        .form-container .valid .input-status:before {
            border-radius: 0px;
            width: 11px;
            height: 4px;
            background: white;
            top: 19px;
            left: 10px;
            -ms-transform: rotate(45deg);
            -webkit-transform: rotate(45deg);
            transform: rotate(45deg);
        }

        .form-container .input-container {
            padding: 0px 20px;
        }

        .form-container .row-input {
            padding: 0px 5px;
        }

        .form-container .req-input.input-password {
            margin-bottom: 0px;
        }

        .form-container .req-input.confirm-password {
            margin-top: 0px;
        }

        .form-container {
            margin: 20px;
            padding: 20px;
            border-radius: 0px;
            background: #B3E5FC;
            color: #00838F;
            -webkit-transition:");
                WriteLiteral(@" all .3s ease-in-out;
            -moz-transition: all .3s ease-in-out;
            -o-transition: all .3s ease-in-out;
            transition: all .3s ease-in-out;
        }

            .form-container .form-title {
                font-size: 25px;
                color: inherit;
                text-align: center;
                margin-bottom: 10px;
                -webkit-transition: all .3s ease-in-out;
                -moz-transition: all .3s ease-in-out;
                -o-transition: all .3s ease-in-out;
                transition: all .3s ease-in-out;
            }

            .form-container .submit-row {
                padding: 0px 0px;
            }

            .form-container .btn.submit-form {
                margin-top: 15px;
                padding: 12px;
                background: #00BCD4;
                color: white;
                border-radius: 0px;
                -webkit-transition: all .3s ease-in-out;
                -moz-transition: all .3s ease-in-o");
                WriteLiteral(@"ut;
                -o-transition: all .3s ease-in-out;
                transition: all .3s ease-in-out;
            }

                .form-container .btn.submit-form:focus {
                    outline: 0px;
                    color: white;
                }

                .form-container .btn.submit-form:hover {
                    background: #00cde5;
                    color: white;
                }

            .form-container .tooltip.top .tooltip-arrow {
                border-top-color: #00BCD4 !important;
            }

            .form-container .tooltip.top.tooltip-invalid .tooltip-arrow {
                border-top-color: #E57373 !important;
            }

            .form-container .tooltip.top.tooltip-invalid .tooltip-inner::before {
                background: #E57373;
            }

            .form-container .tooltip.top.tooltip-invalid .tooltip-inner {
                background: #FFEBEE !important;
                color: #E57373;
            }

    ");
                WriteLiteral(@"        .form-container .tooltip.top.tooltip-valid .tooltip-arrow {
                border-top-color: #81C784 !important;
            }

            .form-container .tooltip.top.tooltip-valid .tooltip-inner::before {
                background: #81C784;
            }

            .form-container .tooltip.top.tooltip-valid .tooltip-inner {
                background: #E8F5E9 !important;
                color: #81C784;
            }

            .form-container .tooltip.top .tooltip-inner::before {
                content: "" "";
                width: 100%;
                height: 6px;
                background: #00BCD4;
                position: absolute;
                bottom: 5px;
                right: 0px;
            }

            .form-container .tooltip.top .tooltip-inner {
                border: 0px solid #00BCD4;
                background: #E0F7FA !important;
                color: #00ACC1;
                font-weight: bold;
                font-size: 13px;
           ");
                WriteLiteral(@"     border-radius: 0px;
                padding: 10px 15px;
            }

            .form-container .tooltip {
                max-width: 150px;
                opacity: 1 !important;
            }

            .form-container .message-box {
                width: 100%;
                height: auto;
            }

            .form-container textarea:focus, .form-container textarea:hover {
                background: #fff;
                outline: none;
                border: 0px;
            }

            .form-container .req-input textarea {
                max-width: calc(100% - 50px);
                width: 100%;
                height: 80px;
                border: 0px;
                color: #777;
                padding: 10px 9px 0px 9px;
                float: left;
            }

            .form-container input[type=text]:focus, .form-container input[type=password]:focus, .form-container input[type=email]:focus, .form-container input[type=tel]:focus, .form-contai");
                WriteLiteral(@"ner select {
                background: #fff;
                color: #777;
                border-left: 0px;
                outline: none;
            }

            .form-container input[type=text]:hover, .form-container input[type=password]:hover, .form-container input[type=email]:hover, .form-container input[type=tel]:hover, . form-container select {
                background: #fff;
            }

            .form-container input[type=text], .form-container input[type=password], .form-container input[type=email], input[type=tel], form-container select {
                width: calc(100% - 50px);
                float: left;
                border-radius: 0px;
                border: 0px solid #ddd;
                padding: 0px 9px;
                height: 40px;
                line-height: 40px;
                color: #777;
                background: #fff;
                -webkit-transition: all .3s ease-in-out;
                -moz-transition: all .3s ease-in-out;
              ");
                WriteLiteral("  -o-transition: all .3s ease-in-out;\r\n                transition: all .3s ease-in-out;\r\n            }\r\n    </style>\r\n");
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
            BeginContext(12553, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(12555, 1706, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a3f02db70324abba91306e291c8c2a9", async() => {
                BeginContext(12561, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(12567, 1078, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e355d45bcc9148f4a571b7640a4e6463", async() => {
                    BeginContext(12606, 474, true);
                    WriteLiteral(@"
        <div  id=""contact-form"" class=""form-container"" data-form-container style=""color: rgb(46, 125, 50); background: rgb(200, 230, 201);"">
            <div class=""row"">
                <div class=""form-title"">
                    <span> Create List </span>
                </div>
            </div>
            <div class=""input-container form-group"">
                <div class=""row"">
                    <span class=""req-input valid"">
                        ");
                    EndContext();
                    BeginContext(13080, 137, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88932560577a4360bf4f7c74f2efc51c", async() => {
                        BeginContext(13209, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 411 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\Create\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.listName);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(13217, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(13243, 131, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4da8b9fd7984a42987dd84391a3ba1e", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 412 "C:\Users\Selahattin\source\repos\TODOListApplication\TODOListApplication\Views\Create\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.listName);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(13374, 264, true);
                    WriteLiteral(@"
                    </span>
                </div>
                <div class=""row submit-row"">
                    <button type=""submit"" class=""btn btn-block submit-form valid"">Submit</button>
                </div>
            </div>
        </div>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13645, 609, true);
                WriteLiteral(@"

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
            BeginContext(14261, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList> Html { get; private set; }
    }
}
#pragma warning restore 1591
