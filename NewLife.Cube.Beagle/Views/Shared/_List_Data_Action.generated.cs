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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Action.cshtml")]
    public partial class _Views_Shared__List_Data_Action_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Action_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_List_Data_Action.cshtml"
  
    var entity = Model as IEntity;

    var rv = entity.GetRouteKey();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (this.Has(PermissionFlags.Update))
{


            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 132), Tuple.Create("\"", 162)
            
            #line 9 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 139), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", rv)
            
            #line default
            #line hidden
, 139), false)
);

WriteLiteral(" class=\"editcell icon pr-2 h4\"");

WriteLiteral(" title=\"编辑\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"mdi mdi-settings text-dark\"");

WriteLiteral("></i>\r\n    </a>\r\n");

            
            #line 12 "..\..\Views\Shared\_List_Data_Action.cshtml"
}
else if (this.Has(PermissionFlags.Detail))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 325), Tuple.Create("\"", 357)
            
            #line 15 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 332), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", rv)
            
            #line default
            #line hidden
, 332), false)
);

WriteLiteral(" class=\"editcell icon pr-2  h4\"");

WriteLiteral(" title=\"查看\"");

WriteLiteral("> <i");

WriteLiteral(" class=\"mdi mdi-format-list-bulleted text-info\"");

WriteLiteral("></i></a>\r\n");

            
            #line 16 "..\..\Views\Shared\_List_Data_Action.cshtml"
}

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (this.Has(PermissionFlags.Delete))
{
    var fact = ViewBag.Factory as IEntityOperate;
    var fi = (fact == null || fact.Fields == null) ? null : fact.Fields.FirstOrDefault(e => e.Name.EqualIgnoreCase("Deleted", "IsDelete", "IsDeleted"));
    if (fi != null && fi.Type == typeof(Boolean) && (Boolean)entity[fi.Name])
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 809), Tuple.Create("\"", 841)
            
            #line 23 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 816), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 816), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"确认恢复？\"");

WriteLiteral(" title=\"恢复\"");

WriteLiteral(" class=\"icon pr-2 h4\"");

WriteLiteral("><i");

WriteLiteral(" class=\"mdi mdi-delete text-danger\"");

WriteLiteral("></i></a>\r\n");

            
            #line 24 "..\..\Views\Shared\_List_Data_Action.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 999), Tuple.Create("\"", 1031)
            
            #line 27 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 1006), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 1006), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"确认删除？\"");

WriteLiteral(" title=\"删除\"");

WriteLiteral(" class=\"icon pr-2 h4\"");

WriteLiteral("><i");

WriteLiteral(" class=\"mdi mdi-delete text-danger\"");

WriteLiteral("></i></a>\r\n");

            
            #line 28 "..\..\Views\Shared\_List_Data_Action.cshtml"
    }
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591