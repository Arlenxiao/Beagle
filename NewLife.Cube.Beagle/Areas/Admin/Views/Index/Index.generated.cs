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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/Index.cshtml")]
    public partial class _Areas_Admin_Views_Index_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Admin\Views\Index\Index.cshtml"
  
    Layout = null;

    var User = ViewBag.User;
    var cfg = NewLife.Common.SysConfig.Current;

    var title = ViewBag.Title + "";
    if (title != "" && !title.EndsWith(" - ")) { title += " - "; }
    title += cfg.DisplayName;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable" +
"=no\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"author\"");

WriteLiteral(" content=\"\"");

WriteLiteral(">\r\n    <title>");

            
            #line 19 "..\..\Areas\Admin\Views\Index\Index.cshtml"
      Write(ViewData["Title"]);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 606), Tuple.Create("\"", 671)
, Tuple.Create(Tuple.Create("", 613), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/perfect-scrollbar/css/perfect-scrollbar.css")
, 613), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 703), Tuple.Create("\"", 782)
, Tuple.Create(Tuple.Create("", 710), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/material-design-icons/css/material-design-iconic-font.css")
, 710), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 814), Tuple.Create("\"", 867)
, Tuple.Create(Tuple.Create("", 821), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/sweetalert2/sweetalert2.min.css")
, 821), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 899), Tuple.Create("\"", 928)
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(Href("~/Template/css/app.css")
, 906), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n</head>\r\n<body>\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"be-wrapper be-collapsible-sidebar be-collapsible-sidebar-hide-logo be-fix" +
"ed-sidebar \"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Areas\Admin\Views\Index\Index.cshtml"
   Write(Html.Partial("_Navbar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 29 "..\..\Areas\Admin\Views\Index\Index.cshtml"
   Write(Html.Partial("_Left"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"be-content be-no-padding\"");

WriteLiteral(">\r\n            <iframe");

WriteLiteral(" style=\"width: 100%; height: 100%; margin: 0; padding: 0; border: none;\"");

WriteLiteral(" id=\"main\"");

WriteLiteral(" name=\"main\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1343), Tuple.Create("\"", 1362)
            
            #line 31 "..\..\Areas\Admin\Views\Index\Index.cshtml"
                                       , Tuple.Create(Tuple.Create("", 1349), Tuple.Create<System.Object, System.Int32>(ViewBag.Main
            
            #line default
            #line hidden
, 1349), false)
);

WriteLiteral("></iframe>\r\n        </div>\r\n    </div>\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1416), Tuple.Create("\"", 1453)
, Tuple.Create(Tuple.Create("", 1422), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/jquery/jquery.js")
, 1422), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1477), Tuple.Create("\"", 1539)
, Tuple.Create(Tuple.Create("", 1483), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/perfect-scrollbar/js/perfect-scrollbar.js")
, 1483), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1563), Tuple.Create("\"", 1621)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/bootstrap/dist/js/bootstrap.bundle.js")
, 1569), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1645), Tuple.Create("\"", 1671)
, Tuple.Create(Tuple.Create("", 1651), Tuple.Create<System.Object, System.Int32>(Href("~/Template/js/app.js")
, 1651), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1695), Tuple.Create("\"", 1736)
, Tuple.Create(Tuple.Create("", 1701), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/prettify/prettify.js")
, 1701), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1760), Tuple.Create("\"", 1815)
, Tuple.Create(Tuple.Create("", 1766), Tuple.Create<System.Object, System.Int32>(Href("~/Template/lib/sweetalert2/sweetalert2.all.min.js")
, 1766), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            //-initialize the javascript
            App.init();

            //Runs prettify
            prettyPrint();

            var $frmContent = $('#main');
            function fixFrmContentSize() {
                var offset = $frmContent.offset();
                var top = offset.top;
                var height = document.documentElement.clientHeight;
                $frmContent.height(height - top - 5);
            }
            fixFrmContentSize();
            $(window).resize(fixFrmContentSize);

            //增加iframe被嵌套的检测2015-6-4 景裔增加
            if (window != top) {
                top.location.href = location.href;
            }
        });
    </script>
</body>
</html>
");

        }
    }
}
#pragma warning restore 1591
