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
    
    #line 2 "..\..\Views\Shared\_Form_Action.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Action.cshtml")]
    public partial class _Views_Shared__Form_Action_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Action_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Shared\_Form_Action.cshtml"
  
    var entity = Model as IEntity;
    var isNew = entity.IsNullKey;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Shared\_Form_Action.cshtml"
 if (this.Has(PermissionFlags.Insert, PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\" be-datatable-footer fixed-bottom form-actions col-sm-12 col-md-12\"");

WriteLiteral(" style=\"padding:10px 0px 0px 0px;\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-xs-4 col-sm-5 col-md-5\"");

WriteLiteral("></label>\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-space btn-primary\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 433), Tuple.Create("\"", 491)
, Tuple.Create(Tuple.Create("", 441), Tuple.Create("pr-2", 441), true)
, Tuple.Create(Tuple.Create(" ", 445), Tuple.Create("mdi", 446), true)
, Tuple.Create(Tuple.Create(" ", 449), Tuple.Create("mdi-", 450), true)
            
            #line 11 "..\..\Views\Shared\_Form_Action.cshtml"
         , Tuple.Create(Tuple.Create("", 454), Tuple.Create<System.Object, System.Int32>(isNew ? "plus-circle-o" : "floppy"
            
            #line default
            #line hidden
, 454), false)
);

WriteLiteral("></i>");

            
            #line 11 "..\..\Views\Shared\_Form_Action.cshtml"
                                                                                                                              Write(isNew ? "新 增" : "保 存");

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-space btn-danger\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"pr-2 mdi mdi-undo\"");

WriteLiteral("></i>取 消</button>\r\n    </div>\r\n");

            
            #line 14 "..\..\Views\Shared\_Form_Action.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
