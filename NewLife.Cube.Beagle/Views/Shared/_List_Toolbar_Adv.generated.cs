﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Toolbar_Adv.cshtml")]
    public partial class _Views_Shared__List_Toolbar_Adv_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Toolbar_Adv_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"btn-group btn-space mt-1\"");

WriteLiteral(">\r\n    <button");

WriteLiteral(" class=\"btn btn-secondary dropdown-toggle\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"icon icon-left mdi mdi-settings\"");

WriteLiteral("></i>高级 <span");

WriteLiteral(" class=\"icon-dropdown mdi mdi-chevron-down\"");

WriteLiteral("></span>\r\n    </button>\r\n    <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" role=\"menu\"");

WriteLiteral(" >\r\n        <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 480), Tuple.Create("\"", 513)
            
            #line 10 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 487), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportExcel")
            
            #line default
            #line hidden
, 487), false)
);

WriteLiteral(">导出Excel</a>\r\n        <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 560), Tuple.Create("\"", 591)
            
            #line 11 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportXml")
            
            #line default
            #line hidden
, 567), false)
);

WriteLiteral(">导出Xml</a>\r\n        <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 636), Tuple.Create("\"", 668)
            
            #line 12 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 643), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportJson")
            
            #line default
            #line hidden
, 643), false)
);

WriteLiteral(">导出Json</a>\r\n\r\n");

            
            #line 14 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
         if (this.Has(PermissionFlags.Delete))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dropdown-divider\"");

WriteLiteral("></div>\r\n");

WriteLiteral("            <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 829), Tuple.Create("\"", 863)
            
            #line 17 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 836), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteSelect")
            
            #line default
            #line hidden
, 836), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" data-confirm=\"该操作将删除选中数据并不可恢复！确认删除？\"");

WriteLiteral(" title=\"删除选中数据\"");

WriteLiteral(">删除选中</a>\r\n");

WriteLiteral("            <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1003), Tuple.Create("\"", 1034)
            
            #line 18 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1010), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteAll")
            
            #line default
            #line hidden
, 1010), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"该操作将删除当前查询的所有数据并不可恢复！确认删除？\"");

WriteLiteral(" title=\"删除当前查询的所有数据\"");

WriteLiteral(">删除全部</a>\r\n");

            
            #line 19 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 20 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
         if (SysConfig.Current.Develop)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dropdown-divider\"");

WriteLiteral("></div>\r\n");

            
            #line 23 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
            if (User.IsInRole("管理员"))
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1336), Tuple.Create("\"", 1363)
            
            #line 25 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1343), Tuple.Create<System.Object, System.Int32>(Url.Action("Clear")
            
            #line default
            #line hidden
, 1343), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"该操作将删除数据表所有数据并不可恢复！确认清空？\"");

WriteLiteral(" title=\"删除数据表所有数据\"");

WriteLiteral(">清空数据表</a>\r\n");

            
            #line 26 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
            }
            if (ViewHelper.IsDevelop())
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1566), Tuple.Create("\"", 1596)
            
            #line 29 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1573), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeList")
            
            #line default
            #line hidden
, 1573), false)
);

WriteLiteral(">生成列表</a>\r\n");

WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1648), Tuple.Create("\"", 1678)
            
            #line 30 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1655), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeForm")
            
            #line default
            #line hidden
, 1655), false)
);

WriteLiteral(">生成表单</a>\r\n");

            
            #line 31 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591