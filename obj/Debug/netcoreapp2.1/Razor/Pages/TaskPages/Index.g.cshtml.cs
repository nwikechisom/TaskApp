#pragma checksum "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dffb5b3452d152bee424b8047980917f6f54a4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TaskApp.Pages.TaskPages.Pages_TaskPages_Index), @"mvc.1.0.razor-page", @"/Pages/TaskPages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TaskPages/Index.cshtml", typeof(TaskApp.Pages.TaskPages.Pages_TaskPages_Index), null)]
namespace TaskApp.Pages.TaskPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/oge/Desktop/TaskApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/oge/Desktop/TaskApp/Pages/_ViewImports.cshtml"
using TaskApp;

#line default
#line hidden
#line 3 "/home/oge/Desktop/TaskApp/Pages/_ViewImports.cshtml"
using TaskApp.Data;

#line default
#line hidden
#line 6 "/home/oge/Desktop/TaskApp/Pages/_ViewImports.cshtml"
using TaskApp.Authorizations;

#line default
#line hidden
#line 7 "/home/oge/Desktop/TaskApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 8 "/home/oge/Desktop/TaskApp/Pages/_ViewImports.cshtml"
using TaskApp.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dffb5b3452d152bee424b8047980917f6f54a4a", @"/Pages/TaskPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6695ace1f33618fe7e18b4c4a0b38df2fa4a3187", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TaskPages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "047337b7702b47b1a5b84c1c6b735a93", async() => {
                BeginContext(143, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 51, false);
#line 17 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.task[0].OwnerId));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 53, false);
#line 20 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.task[0].taskTitle));

#line default
#line hidden
            EndContext();
            BeginContext(410, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(466, 59, false);
#line 23 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.task[0].taskDescription));

#line default
#line hidden
            EndContext();
            BeginContext(525, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
 foreach (var item in Model.task) {

#line default
#line hidden
            BeginContext(648, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(697, 42, false);
#line 32 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OwnerId));

#line default
#line hidden
            EndContext();
            BeginContext(739, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(795, 44, false);
#line 35 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.taskTitle));

#line default
#line hidden
            EndContext();
            BeginContext(839, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(895, 50, false);
#line 38 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.taskDescription));

#line default
#line hidden
            EndContext();
            BeginContext(945, 95, true);
            WriteLiteral("\r\n            </td>\r\n            <!-- <td>\r\n                <a asp-page=\"./Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(1041, 11, false);
#line 41 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                              Write(item.taskId);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 68, true);
            WriteLiteral("\">Edit</a> |\r\n                <a asp-page=\"./Details\" asp-route-id=\"");
            EndContext();
            BeginContext(1121, 11, false);
#line 42 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                                 Write(item.taskId);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 70, true);
            WriteLiteral("\">Details</a> |\r\n                <a asp-page=\"./Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(1203, 11, false);
#line 43 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                                Write(item.taskId);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 57, true);
            WriteLiteral("\">Delete</a>\r\n            </td> -->\r\n\r\n            <td>\r\n");
            EndContext();
#line 47 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(
                User, item, ContactOperations.Update)).Succeeded)
                {

#line default
#line hidden
            BeginContext(1423, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1443, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2629a80c87b44c7e83279c0a5618db5e", async() => {
                BeginContext(1492, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                           WriteLiteral(item.taskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1500, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1528, 3, true);
            WriteLiteral(" | ");
            EndContext();
#line 51 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(1559, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1575, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c204ecc8cf4656a2afaea96605b370", async() => {
                BeginContext(1627, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                          WriteLiteral(item.taskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1638, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(
                User, item, ContactOperations.Delete)).Succeeded)
                {
                    

#line default
#line hidden
            BeginContext(1818, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(1828, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1850, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "752d976c5c32492b803b355994b1ac90", async() => {
                BeginContext(1901, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                                             WriteLiteral(item.taskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1911, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1932, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 62 "/home/oge/Desktop/TaskApp/Pages/TaskPages/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1969, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskApp.Pages.TaskPages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TaskApp.Pages.TaskPages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TaskApp.Pages.TaskPages.IndexModel>)PageContext?.ViewData;
        public TaskApp.Pages.TaskPages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
