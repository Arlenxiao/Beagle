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
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Toolbar_Search.cshtml")]
    public partial class _Views_Shared__List_Toolbar_Search_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Toolbar_Search_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"input-group pl-1\"");

WriteLiteral(" style=\"margin-top:6px;\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" name=\"q\"");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"q\"");

WriteAttribute("value", Tuple.Create(" value=\"", 98), Tuple.Create("\"", 119)
            
            #line 3 "..\..\Views\Shared\_List_Toolbar_Search.cshtml"
, Tuple.Create(Tuple.Create("", 106), Tuple.Create<System.Object, System.Int32>(Request["q"]
            
            #line default
            #line hidden
, 106), false)
);

WriteLiteral(" class=\"form-control form-control-xs\"");

WriteLiteral(" style=\"border: 1px solid #4285f4;\"");

WriteLiteral(" placeholder=\"搜索关键字\"");

WriteLiteral(" />\r\n    <button");

WriteLiteral(" class=\"btn btn-space btn-primary btn-space\"");

WriteLiteral("><i");

WriteLiteral(" class=\"icon icon-left mdi mdi-search\"");

WriteLiteral("></i>查询</button>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
