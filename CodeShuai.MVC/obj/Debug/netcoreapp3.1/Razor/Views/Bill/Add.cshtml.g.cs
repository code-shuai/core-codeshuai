#pragma checksum "E:\Code\DotNet\Core_CodeShuai\CodeShuai.MVC\Views\Bill\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee30b4801a9fde0c8ed40fa5963acc186dc6a2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Add), @"mvc.1.0.view", @"/Views/Bill/Add.cshtml")]
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
#line 1 "E:\Code\DotNet\Core_CodeShuai\CodeShuai.MVC\Views\_ViewImports.cshtml"
using CodeShuai.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code\DotNet\Core_CodeShuai\CodeShuai.MVC\Views\_ViewImports.cshtml"
using CodeShuai.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee30b4801a9fde0c8ed40fa5963acc186dc6a2c", @"/Views/Bill/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac45cfee42a70cffe32d866197e21fbada6c6bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Code\DotNet\Core_CodeShuai\CodeShuai.MVC\Views\Bill\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>

    .csJZA {
        width: 100%;
        height: 100%;
        margin: 0;
        padding: 0;
    }

    .csJZ {
        width: 80%;
        height: 300px;
        margin: 0 auto; /*水平居中*/
        top: 50%;
        position: relative;
        margin-top: -150px;
    }
</style>
");
#nullable restore
#line 25 "E:\Code\DotNet\Core_CodeShuai\CodeShuai.MVC\Views\Bill\Add.cshtml"
Write(Html.Partial("_billHead"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""csMain"">
    <div class=""layui-row"">
        <div class=""layui-col-xs10 layui-col-xs-offset1"">
            <div class=""layui-card"">
                <div class=""layui-card-header"">Add Bill</div>
                <div class=""layui-card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ee30b4801a9fde0c8ed40fa5963acc186dc6a2c4914", async() => {
                WriteLiteral(@"

                        <div class=""layui-form-item"">

                            <label class=""layui-form-label""><i class=""layui-icon layui-icon-theme""></i></label>
                            <div class=""layui-input-inline"">
                                <select name=""billLabel"" id=""billLabel"" lay-filter=""projectfilter"">
                                </select>
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><i class=""layui-icon layui-icon-rmb""></i></label>
                            <div class=""layui-input-block"">
                                <input type=""text"" name=""money"" autocomplete=""off"" placeholder=""请输入金额"" class=""layui-input"">
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><i class=""layui-icon layui-icon-survey""><");
                WriteLiteral(@"/i></label>
                            <div class=""layui-input-block"">
                                <input type=""text"" name=""remark"" placeholder=""请输入备注"" autocomplete=""off"" class=""layui-input"">
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <div class=""@*layui-input-block*@"">
                                <button type=""submit"" class=""layui-btn layui-btn-fluid""");
                BeginWriteAttribute("lay-submit", " lay-submit=\"", 2207, "\"", 2220, 0);
                EndWriteAttribute();
                WriteLiteral(" lay-filter=\"login\">立即提交</button>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 66 "E:\Code\DotNet\Core_CodeShuai\CodeShuai.MVC\Views\Bill\Add.cshtml"
Write(Html.Partial("_billFoot"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>
    layui.use(['form', 'upload', 'layer'], function () {

        var form = layui.form;



        //检查项目添加到下拉框中
        $.ajax({
            url: '/values/getlabels',
            dataType: 'json',
            type: 'get',
            success: function (data) {
                $(""#billLabel"").empty();
                if (data.length != 0) {
                    //$(""#billLabel"").append(new Option(""请选择项目"", """"));
                    $.each(data, function (index, item) {
                        $('#billLabel').append(new Option(item.labelCode + '/' + item.labelName, item.ID));
                    });
                } else {
                    $(""#billLabel"").append(new Option(""暂无数据"", """"));
                }

                layui.form.render(""select"");
                //重新渲染 固定写法
            }
        })

    });

    layui.use(['form', 'layedit', 'laydate'], function () {
        var form = layui.form
            , layer = layui.layer
            , layedit = lay");
            WriteLiteral(@"ui.layedit
            , laydate = layui.laydate;


        //监听提交
        form.on('submit(login)', function (data) {


            var billLabel = (this.form[1].value).split('/');
            var billData = {};

            billData.LabelName = billLabel[1];
            billData.LabelCode = billLabel[0];
            billData.Money = this.form[2].value;
            billData.Remark = this.form[3].value;
            billData.UserID = getCookie('userAccount');


            $.ajax({
                url: ""/values/AddBill"",
                data: billData,
                dataType: ""json"",
                type: ""POST""
            }).done(function (addTF) {
                if (addTF == 1001) {
                    window.location.href = '/bill/index';
                }
            })
            return false;
        });

    });
</script>");
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
