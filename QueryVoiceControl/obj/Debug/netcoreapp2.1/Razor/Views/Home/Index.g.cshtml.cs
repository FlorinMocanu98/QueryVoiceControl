#pragma checksum "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc910862b9e58cfeec2c26cc23553ca2b9794183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\_ViewImports.cshtml"
using QueryVoiceControl;

#line default
#line hidden
#line 2 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\_ViewImports.cshtml"
using QueryVoiceControl.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc910862b9e58cfeec2c26cc23553ca2b9794183", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2f7d4c2240f235a59f21280eaec5a6e312704c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QueryVoiceControl.ViewModel.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("result"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(125, 4149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67bf43c285f64e7e9af88cf6db85664c", async() => {
                BeginContext(131, 4136, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.1/css/font-awesome.min.css"" />
    <style type=""text/css"">

        body {
            font-family: verdana;
        }

        button {
            margin-top: 9%;
            float: right;
            backface-visibility: hidden;
            position: absolute;
            cursor: pointer;
            display: inline-block;
            white-space: nowrap;
            background: #e74;
            border-radius: 500px;
            border: 0px solid #444;
            border-width: 0px 0px 0px 0px;
            padding: 10px 15px 10px 43px;
            color: #fff;
            font-size: 16px;
            font-family: Helvetica Neue;
            font-weight: 900;
            font-style");
                WriteLiteral(@": normal;
            margin-left: 1%;
            box-shadow: 0px 0px 7px rgba(66,66,66,.75);
        }

            button > div {
                color: #999;
                font-size: 10px;
                font-family: Helvetica Neue;
                font-weight: initial;
                font-style: normal;
                text-align: center;
                margin: 0px 0px 0px 0px
            }

            button > i {
                color: #e21;
                font-size: 1em;
                background: #fff;
                border-radius: 500px;
                border: 0px solid transparent;
                border-width: 0px 0px 0px 0px;
                padding: 8px 8px 8px 8px;
                float: left;
                position: absolute;
                margin-left: 6px;
                margin-top: 3px;
                top: 0px;
                left: 0px
            }

            button > .ld {
                font-size: initial
            }


        #res");
                WriteLiteral(@"ult {
            font-size: 12px;
            border-width: 1px;
            border-color: #F9DFD0;
            background-color: #F5E9E2;
            color: #000000;
            border-style: solid;
            border-radius: 3px;
            box-shadow: 0px 0px 7px rgba(66,66,66,.75);
            margin-top: 5%;
            height: 10vw;
            width: 70%;
            word-wrap: break-word;
            margin-bottom: 30px;
            margin-left: 2%;
        }

        textarea {
            resize: none;
        }

        table.MyTable {
            font-family: Tahoma, Geneva, sans-serif;
            background-color: #FFFFFF;
            width: 100%;
            text-align: center;
        }

            table.MyTable td, table.MyTable th {
                padding: 3px 2px;
            }

            table.MyTable tbody td {
                font-size: 15px;
            }

            table.MyTable thead {
                background: #000000;
                b");
                WriteLiteral(@"ackground: -moz-linear-gradient(top, #404040 0%, #191919 66%, #000000 100%);
                background: -webkit-linear-gradient(top, #404040 0%, #191919 66%, #000000 100%);
                background: linear-gradient(to bottom, #404040 0%, #191919 66%, #000000 100%);
                border-bottom: 3px solid #FF9400;
                color: #FFFFFF;
            }

                table.MyTable thead th {
                    font-size: 15px;
                    font-weight: bold;
                    color: #FFFFFF;
                    text-align: center;
                }

            table.MyTable tfoot td {
                font-size: 14px;
            }

            table.MyTable tfoot .links {
                text-align: right;
            }

                table.MyTable tfoot .links a {
                    display: inline-block;
                    background: #1C6EA4;
                    color: #FFFFFF;
                    padding: 2px 8px;
                    border-radius: 5px");
                WriteLiteral(";\r\n                }\r\n    </style>\r\n\r\n\r\n");
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
            BeginContext(4274, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4276, 2851, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b76452a3ec438b90e8843d915eea1d", async() => {
                BeginContext(4282, 10, true);
                WriteLiteral("\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(4292, 323, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3a36285474a4c4aa9db3bac08836188", async() => {
                    BeginContext(4339, 41, true);
                    WriteLiteral("\r\n        <div class=\"frm\">\r\n            ");
                    EndContext();
                    BeginContext(4380, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "995ccaad048741b29e5b3d8842ab6de1", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 147 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Speech);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4430, 178, true);
                    WriteLiteral("\r\n            <button onmouseup=\"StopConverting();\" onmousedown=\"startConverting();\"><i class=\"fas fa-microphone-alt\"></i>Tener premuto per parlare</button>\r\n        </div>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4615, 50, true);
                WriteLiteral("\r\n\r\n\r\n    <div>\r\n        <table class=\"MyTable\">\r\n");
                EndContext();
                BeginContext(5001, 25, true);
                WriteLiteral("\r\n\r\n            <tbody>\r\n");
                EndContext();
#line 166 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                 if (Model.Tabella != null) {
                    

#line default
#line hidden
#line 167 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                     for (int a = 0; a < Model.Tabella.GetLength(0); a++) {

#line default
#line hidden
                BeginContext(5150, 30, true);
                WriteLiteral("                        <tr>\r\n");
                EndContext();
#line 169 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                             for (int b = 0; b < Model.Tabella.GetLength(1); b++) {

#line default
#line hidden
                BeginContext(5265, 36, true);
                WriteLiteral("                                <td>");
                EndContext();
                BeginContext(5302, 19, false);
#line 170 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                               Write(Model.Tabella[a, b]);

#line default
#line hidden
                EndContext();
                BeginContext(5321, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 171 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(5359, 31, true);
                WriteLiteral("                        </tr>\r\n");
                EndContext();
#line 173 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 173 "C:\Users\FLORIN.MOCANU\Desktop\QueryVoiceControl\QueryVoiceControl\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(5432, 1688, true);
                WriteLiteral(@"            </tbody>
        </table>
    </div>

    <script type=""text/javascript"">

        var r = document.getElementById('result');
        var speechRecognizer = new webkitSpeechRecognition();

        function startConverting(stop) {

            if ('webkitSpeechRecognition' in window) {

                speechRecognizer.continuous = true;
                speechRecognizer.interimResults = true;
                speechRecognizer.lang = 'it-IT';
                speechRecognizer.start();

                var finalTranscripts = '';

                speechRecognizer.onresult = function (event) {
                    var interimTranscripts = '';
                    for (var i = event.resultIndex; i < event.results.length; i++) {
                        var transcript = event.results[i][0].transcript;
                        transcript.replace(""\n"", ""<br>"");
                        if (event.results[i].isFinal) {
                            finalTranscripts += transcript;
          ");
                WriteLiteral(@"              } else {
                            interimTranscripts += transcript;
                        }
                    }

                    r.value = finalTranscripts + interimTranscripts;

                };
                speechRecognizer.onerror = function (event) {
                };
            } else {
                r.value = 'Your browser is not supported. If google chrome, please upgrade!';
            }
        }
        function StopConverting() {

            speechRecognizer.stop();
        }





    </script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
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
            BeginContext(7127, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QueryVoiceControl.ViewModel.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
