#pragma checksum "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\Signin\Signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c251f892f621d1e630b5521aa4062082adeb72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Signin_Signin), @"mvc.1.0.view", @"/Views/Signin/Signin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Signin/Signin.cshtml", typeof(AspNetCore.Views_Signin_Signin))]
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
#line 1 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\_ViewImports.cshtml"
using Makalem;

#line default
#line hidden
#line 1 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\Signin\Signin.cshtml"
using Makalem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c251f892f621d1e630b5521aa4062082adeb72", @"/Views/Signin/Signin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2977efaf0c374908c4f72cb10eeb94392950b40d", @"/Views/_ViewImports.cshtml")]
    public class Views_Signin_Signin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kullanici>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\Signin\Signin.cshtml"
  
    ViewData["Title"] = "Signin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 52, true);
            WriteLiteral("\r\n<div class=\"text-center\" >\r\n    <br /><br />\r\n    ");
            EndContext();
            BeginContext(197, 811, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "726d866c397f47bdb55cd8b368f08c55", async() => {
                BeginContext(237, 764, true);
                WriteLiteral(@"
 
        <h1 class=""h3 mb-3 font-weight-normal"">Lütfen Giriş Yapın</h1>
        <label for=""inputEmail"" class=""sr-only"">Email </label>                                                
         <input name=""email"" type=""email"" id=""inputEmail"" class=""form-control"" placeholder=""Email"" required autofocus>    
        <label for=""inputPassword"" class=""sr-only"">Şifre</label>
        <input type=""password"" id=""inputPassword"" class=""form-control"" placeholder=""Şifre"" name=""password""  required>
        <div class=""checkbox mb-3"">
            <label>
                <input type=""checkbox"" value=""remember-me""> Beni Hatırla
            </label>
        </div>
        <button class=""btn btn-lg btn-primary btn-block"" type=""submit"">Giriş</button><br/>
    ");
                EndContext();
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
            EndContext();
            BeginContext(1008, 64, true);
            WriteLiteral("\r\n    <h1 class=\"h3 mb-3 font-weight-normal\" style=\"color:red;\">");
            EndContext();
            BeginContext(1073, 16, false);
#line 25 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\Signin\Signin.cshtml"
                                                         Write(ViewData["info"]);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 21, true);
            WriteLiteral("</h1>\r\n\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kullanici>> Html { get; private set; }
    }
}
#pragma warning restore 1591
