#pragma checksum "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "242224bb594730ac8fc9e757249fe18de2ae4018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MakaleEkle_MakaleEkle), @"mvc.1.0.view", @"/Views/MakaleEkle/MakaleEkle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MakaleEkle/MakaleEkle.cshtml", typeof(AspNetCore.Views_MakaleEkle_MakaleEkle))]
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
#line 2 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\_ViewImports.cshtml"
using Makalem.Models;

#line default
#line hidden
#line 1 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242224bb594730ac8fc9e757249fe18de2ae4018", @"/Views/MakaleEkle/MakaleEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2977efaf0c374908c4f72cb10eeb94392950b40d", @"/Views/_ViewImports.cshtml")]
    public class Views_MakaleEkle_MakaleEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kategori>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MakaleEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakaleEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml"
  
    ViewData["Title"] = "MakaleEkle";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 226, true);
            WriteLiteral("\r\n<center>\r\n    <div class=\"wrapper wrapper--w680\">\r\n        <div class=\"card card-4\">\r\n            <div class=\"card-body\" style=\"background-color:black\">\r\n                <h2 class=\"title\">Makale Ekleme</h2>\r\n                ");
            EndContext();
            BeginContext(385, 2660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c85492ccaf4fa0b7eeade8e8c61f6d", async() => {
                BeginContext(470, 686, true);
                WriteLiteral(@"

                    <div class=""col-2"">
                        <div class=""input-group"">
                            <label class=""label"" style=""font-size:18px;"">Makale Başlığı:</label><br />
                            <input class=""input--style-4"" style=""line-height:30px;width:340px;color:black;"" type=""text"" name=""Baslik"">
                        </div>
                    </div>
                    <br />

                    <div class=""col-2"">
                        <div class=""input-group"" style=""width:350px"">
                            <label class=""label"" style=""font-size:18px;"">Kategori:</label><br />
                            <div class=""p-t-10"">
");
                EndContext();
#line 28 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml"
                                 foreach (var cat in Model)
                                {

#line default
#line hidden
                BeginContext(1252, 108, true);
                WriteLiteral("                                    <label style=\"color:white\" ;> <input style=\"width:20px;\" type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1360, "\"", 1375, 1);
#line 30 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml"
WriteAttributeValue("", 1368, cat.Id, 1368, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1376, 16, true);
                WriteLiteral(" name=\"catid\" />");
                EndContext();
                BeginContext(1393, 7, false);
#line 30 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml"
                                                                                                                                       Write(cat.Adi);

#line default
#line hidden
                EndContext();
                BeginContext(1400, 17, true);
                WriteLiteral(" &nbsp;</label>\r\n");
                EndContext();
#line 31 "C:\Users\YAHYA\source\Workspaces\Workspace\Makalem\Makalem\Makalem\Views\MakaleEkle\MakaleEkle.cshtml"
                                }

#line default
#line hidden
                BeginContext(1452, 498, true);
                WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <br />

                    <div class=""input-group"" style=""color:black"">
                        <label class=""label"" style=""font-size:18px;"">Makale Dili:</label><br />
                        <div class=""rs-select2 js-select-simple select--no-search"">
                            <select id=""makaledil"" name=""MakaleDili"" style=""width:340px"">
                                ");
                EndContext();
                BeginContext(1950, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035f71b98e43496c8e1d8475be599bea", async() => {
                    BeginContext(1988, 6, true);
                    WriteLiteral("Türkçe");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2003, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2037, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebb22a87d2094a958284ae9295832a86", async() => {
                    BeginContext(2055, 9, true);
                    WriteLiteral("İngilizce");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2073, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2107, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ecedd4c44d346919e9af6abfbfd4b1a", async() => {
                    BeginContext(2125, 5, true);
                    WriteLiteral("Diğer");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2139, 899, true);
                WriteLiteral(@"
                            </select>
                            <div class=""select-dropdown""></div>
                        </div>
                    </div>
                    <br />
                    <div class=""col-2"">
                        <div class=""input-group"" style=""width:340px;color:black"">
                            <label class=""label"" style=""font-size:18px;"">İçerik:</label><br />
                            <textarea class=""form-control"" style=""width:340px; height:100px;color:black;"" type=""text"" name=""Icerik""></textarea>
                        </div>
                    </div>
                    <br />
                    <div class=""form-group"">
                        <div class=""col-2"">
                        <button type=""submit"" class=""btn btn-default"">Ekle</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3045, 87, true);
            WriteLiteral("\r\n                <br />\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kategori>> Html { get; private set; }
    }
}
#pragma warning restore 1591
