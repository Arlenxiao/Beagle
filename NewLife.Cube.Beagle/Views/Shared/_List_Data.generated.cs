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
    
    #line 2 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data.cshtml")]
    public partial class _Views_Shared__List_Data_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var fk = fact.Unique;
    var set = ViewBag.PageSetting as PageSetting;

    var hasUser = fields.Any(f => f.Name.EqualIgnoreCase("CreateUserID", "UpdateUserID"));
    if (hasUser && ViewData["Provider"] == null) { ViewData["Provider"] = ManageProvider.Provider; }

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed table-data" +
"-list\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 19 "..\..\Views\Shared\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\_List_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"be-checkbox custom-control custom-checkbox\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"custom-control-input\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"custom-control-label\"");

WriteLiteral(" for=\"chkAll\"");

WriteLiteral("></label>\r\n                    </div>\r\n                </th>\r\n");

            
            #line 27 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
             foreach (var item in fields)
            {
                var sortUrl = item.OriField != null ? page.GetSortUrl(item.OriField.Name) : page.GetSortUrl(item.Name);
                var width = item.Name.EndsWithIgnoreCase("Date") ? 80 : 134;
                if (item.Type == typeof(DateTime))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1433), Tuple.Create("\"", 1462)
, Tuple.Create(Tuple.Create("", 1441), Tuple.Create("min-width:", 1441), true)
            
            #line 34 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create<System.Object, System.Int32>(width
            
            #line default
            #line hidden
, 1451), false)
, Tuple.Create(Tuple.Create("", 1459), Tuple.Create("px;", 1459), true)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1463), Tuple.Create("\"", 1488)
            
            #line 34 "..\..\Views\Shared\_List_Data.cshtml"
 , Tuple.Create(Tuple.Create("", 1471), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1471), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1492), Tuple.Create("\"", 1517)
            
            #line 34 "..\..\Views\Shared\_List_Data.cshtml"
                             , Tuple.Create(Tuple.Create("", 1499), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1499), false)
);

WriteLiteral(">");

            
            #line 34 "..\..\Views\Shared\_List_Data.cshtml"
                                                                                                                            Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1650), Tuple.Create("\"", 1675)
            
            #line 38 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1658), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1658), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1679), Tuple.Create("\"", 1704)
            
            #line 38 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1686), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1686), false)
);

WriteLiteral(">");

            
            #line 38 "..\..\Views\Shared\_List_Data.cshtml"
                                                                                              Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 39 "..\..\Views\Shared\_List_Data.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 41 "..\..\Views\Shared\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 44 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 48 "..\..\Views\Shared\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Shared\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 51 "..\..\Views\Shared\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\_List_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"be-checkbox custom-control custom-checkbox\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" class=\"custom-control-input\"");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2349), Tuple.Create("\"", 2373)
, Tuple.Create(Tuple.Create("", 2354), Tuple.Create("id_", 2354), true)
            
            #line 55 "..\..\Views\Shared\_List_Data.cshtml"
       , Tuple.Create(Tuple.Create("", 2357), Tuple.Create<System.Object, System.Int32>(entity[fk.Name]
            
            #line default
            #line hidden
, 2357), false)
);

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2386), Tuple.Create("\"", 2410)
            
            #line 55 "..\..\Views\Shared\_List_Data.cshtml"
                                            , Tuple.Create(Tuple.Create("", 2394), Tuple.Create<System.Object, System.Int32>(entity[fk.Name]
            
            #line default
            #line hidden
, 2394), false)
);

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"custom-control-label\"");

WriteAttribute("for", Tuple.Create(" for=\"", 2477), Tuple.Create("\"", 2502)
, Tuple.Create(Tuple.Create("", 2483), Tuple.Create("id_", 2483), true)
            
            #line 56 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2486), Tuple.Create<System.Object, System.Int32>(entity[fk.Name]
            
            #line default
            #line hidden
, 2486), false)
);

WriteLiteral("></label>\r\n                        </div>\r\n                    </td>\r\n");

            
            #line 59 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 60 "..\..\Views\Shared\_List_Data.cshtml"
                 foreach (var item in fields)
                {
                    
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Shared\_List_Data.cshtml"
               Write(Html.Partial("_List_Data_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Shared\_List_Data.cshtml"
                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 64 "..\..\Views\Shared\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 67 "..\..\Views\Shared\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 69 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 71 "..\..\Views\Shared\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 72 "..\..\Views\Shared\_List_Data.cshtml"
         if (page.State != null)
        {
            
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Shared\_List_Data.cshtml"
       Write(Html.Partial("_List_Data_Stat", page.State));

            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Shared\_List_Data.cshtml"
                                                        
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
