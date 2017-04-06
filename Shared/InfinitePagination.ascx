<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Control Language="vb" AutoEventWireup="false" CodeFile="InfinitePagination.ascx.vb" Inherits="ePortalWFApproval.UI.InfinitePagination" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table cellspacing="0" cellpadding="0" border="0" style="visibility:hidden;display:none"><tr><td class="prbggo"><table><tr><td><asp:ImageButton runat="server" id="_FirstPage" causesvalidation="False" commandname="FirstPage" imageurl="../Images/ButtonBarFirst.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarFirst.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarFirstOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:FirstPage&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_PreviousPage" causesvalidation="False" commandname="PreviousPage" imageurl="../Images/ButtonBarPrevious.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarPrevious.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPreviousOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PreviousPage&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_CurrentPage" cssclass="Pagination_Input" maxlength="10" onchange="ISD_InfiScrollHandler(this)" size="5" visible="True">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td><td><asp:ImageButton runat="server" id="_NextPage" causesvalidation="False" commandname="NextPage" imageurl="../Images/ButtonBarNext.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarNext.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNextOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:NextPage&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_LastPage" causesvalidation="False" commandname="LastPage" imageurl="../Images/ButtonBarLast.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarLast.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarLastOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:LastPage&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td></tr></table>
</td><td class="prbggo"><asp:LinkButton runat="server" id="_PageSizeButton" causesvalidation="False" commandname="PageSize" cssclass="button_link" text="&lt;%# GetResourceValue(&quot;Txt:PageSize&quot;, &quot;ePortalWFApproval&quot;) %>" style="visibility:hidden;display:none">		
	</asp:LinkButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_PageSize" cssclass="Pagination_Input" maxlength="5" text="10" style="visibility:hidden;display:none">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td><td class="prbg"><asp:TextBox runat="server" id="_Summary" text="Infinite Pagination" style="visibility:hidden;display:none">	</asp:TextBox></td></tr></table><div><iframe id="Infiniteframe" runat="server" style="width:0px;height:0px;visibility:hidden;position:fixed;top:500px;left:0px"></iframe></div>
<script type="text/javascript">
    var ScrollRegionName = ""; var innerpage = ""; var bool = "False"; var NewRecords = "True"; var RecordsRowCount = 0;
    var RowCount = 0; var index = 0; var done = "True"; var id = ""; var postbackSucess = "True"; var OrgPageSize = 0; var justcopied = false;
    var OrgRowLenght = 0; var counter = 0; var rowfetch = 0; var check = 0; var i = 0; var j = 0; var parentwaiting = false;
    var CurrPageinfo = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>'); var dontpostback = false;
    var OnLoadHit = false; var PageReadyHit = false;
    if (OrgPageSize == 0) { OrgPageSize = parseInt(CurrPageinfo.value); }
    if (document.forms[0].action.indexOf("InfiIframe") == -1 && OrgPageSize == 0) { OrgPageSize = 1; }
    var currpagesize = OrgPageSize; var cpychld = false;
    var initialframe = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
    var parenttframe = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
    function pageLoad() {
        try {
            ScrollRegionName = ScrollRegName();
            if (window.frameElement == null && ScrollRegionName == "scrollRegion") {
                innerpage = "False";
                $(window).scroll(function () {
                    if ((($(window).scrollTop() + 10) >= $(document).height() - $(window).height()) || (($(window).scrollTop() + 10) >= $(document).height() - window.innerHeight)) {
                        if (bool == "True" && done == "True" && postbackSucess == "True") { var olddiv = document.getElementById('loadgif'); if (olddiv == null) { parentwaiting = false; onScroll(); }} else {
                            if (NewRecords == "True") {
                                var olddiv = document.getElementById('loadgif');
                                if (olddiv == null) { $('#' + '<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>').after('<div id=\"loadgif\" align=\"center\"><img id=\"loading-image\" src=\"../Images/ajax-loader.gif\"></img></div>'); parentwaiting = true;  }
                            }
                        }
                    }
                });
            } else {
                innerpage = "True";
                $('#' + ScrollRegionName).scroll(function () {
                    if ($(this)[0].scrollHeight - $(this).outerHeight() <= ($(this).scrollTop() + 10)) {
                        if (bool == "True" && done == "True" && postbackSucess == "True") { var olddiv = document.getElementById('loadgif'); if (olddiv == null) { parentwaiting = false; onScroll(); }} else {
                            if (NewRecords == "True") {
                                var olddiv = document.getElementById('loadgif');
                                if (olddiv == null) { $('#' + '<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>').after('<div id=\"loadgif\" align=\"center\"><img id=\"loading-image\" src=\"../Images/ajax-loader.gif\"></img></div>'); parentwaiting = true;  }
                            }
                        }
                    }
                });
            }
            if ((document.forms[0].action.indexOf("InfiIframe") != -1)) {
             
            }
        } catch (err) { }
    }
	$(window).on('beforeunload', function () {
        if (document.forms[0].action.indexOf("InfiIframe") == -1) {
            $(window).scrollTop(0);
        }
    });

    $(document).ready(function () {
        try {
            if ((document.forms[0].action.indexOf("InfiIframe") != -1)) {
                window.parent.PageReadyHit = true;
                var parenttframe = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
                if (((parenttframe.name == "PostbackIframe" && window.parent.done == "False") || window.parent.cpychld == true) && navigator.appName != 'Microsoft Internet Explorer') {
                    var IframePageSize = parenttframe.contentDocument.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>');
                    IframePageSize.value = window.parent.currpagesize; dontpostback = true; IframePageSize.onchange();
                    window.parent.done = "True"; window.parent.postbackSucess = "False";
                }
            }
        } catch (err) {  }
    });
    var prm = Sys.WebForms.PageRequestManager.getInstance(); prm.add_initializeRequest(InitializeRequestHandler);
    function InitializeRequestHandler(sender, args) {
        if (document.readyState != "complete") {
            var iframeName = "";
            if (window.frameElement != null) {iframeName = window.frameElement.id;}
            if (iframeName.indexOf("Infiniteframe") == -1) {args.set_cancel(true);}
        } else {resetvalue();}
    }
    prm.add_endRequest(function (s, e) {
        try {
            var parenttframe = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
            if (document.forms[0].action.indexOf("InfiIframe") != -1) {
                if (parenttframe.src != "" || parenttframe.name == "PostbackIframe") {
                    var initialframe = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
                    if (dontpostback == true) { dontpostback = false;  throw true; }
                    window.parent.bool = "True"; var olddiv = window.parent.document.getElementById('loadgif');
                    olddiv.outerHTML = ""; delete olddiv.parentNode;
                    var t = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
                    var ParentTable = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
                    var iFrameBody = t.contentDocument.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
                    var ParentVS = window.parent.document.getElementById('__VIEWSTATE'); var a = [];
                    var IframeVSCode = document.getElementById("__VIEWSTATE"); var check = 0; j = 0;
                    if (iFrameBody != "null") {
                        var rowLength = iFrameBody.rows.length;
                        var parentrowlength = ParentTable.rows.length;
                        for (i = 0; i < rowLength; i++) { if (i >= rowfetch) { a[j] = iFrameBody.rows.item(i).outerHTML; j += 1; } }
                        for (i = (parentrowlength - 1) ; i >= (parentrowlength - window.parent.counter) ; i--) {ParentTable.deleteRow(i); }
                        if (rowLength == (rowfetch + counter)) { window.parent.NewRecords = "False"; }
                        if ((document.forms[0].action.indexOf("InfiIframe") == -1)) {initialframe.contentWindow.rowfetch = rowLength - window.parent.counter; rowfetch = rowLength - window.parent.counter;}
                        if ((document.forms[0].action.indexOf("InfiIframe") != -1)) {
                            window.parent.rowfetch = rowLength - window.parent.counter;
                            rowfetch = rowLength - window.parent.counter;
                        }
                        for (var i = 0; i < a.length; i++) {window.parent.$('#' + ParentTable.id + ' > tbody:last').append(a[i]);}
                        if (a.length > 0) {ParentVS.value = IframeVSCode.value;}
                        ScrollBarCheck()
                    }
                    window.parent.submitcount = 0;
                    submitcount = 0;
                }
            }
            else { CopyToChild();}
        }
        catch (err) {
            if ((document.forms[0].action.indexOf("InfiIframe") != -1)) {
                if (parenttframe.name == "PostbackIframe" && window.parent.done == "True" && navigator.appName != 'Microsoft Internet Explorer') {rowfetch = CalculateRowFetch(); }
                if (window.parent.postbackSucess == "False") {
                	window.parent.postbackSucess = "True"; 
                    if (window.parent.parentwaiting == true) {
                        window.parent.parentwaiting = false;
                        if (window.parent.bool == "True" && window.parent.done == "True") {window.parent.parentwaiting = false; window.parent.onScroll(); }
                    }
                    ScrollBarCheck(); 
                }
            }
        }
    });
    window.onload = function () {
        try {
            var initialframe = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
            var parenttframe = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
            var table = document.getElementsByTagName("table"); rowfetch = CalculateRowFetch();
            if (OrgRowLenght == 0) { OrgRowLenght = rowfetch; }
            if ((document.forms[0].action.indexOf("InfiIframe") != -1)) {
                window.parent.OnLoadHit = true;
                if (window.parent.done = "False") { window.parent.done = "True"; }
                if (window.parent.parentwaiting == true) {
                    window.parent.parentwaiting = false;
                    if (window.parent.bool == "True" && window.parent.done == "True") {window.parent.parentwaiting = false; window.parent.onScroll(); }
                }
                ScrollBarCheck();
            } else {CopyToChild(); }
        } catch (err) {}
    }
    function onScrollNoSbar() {
        if (rowfetch > 0) {
            try {
                var Form = document.forms['aspnetForm'];
                var Loc = Form.action;
                var z = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
                var iFrameBod = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
                var rowLengt = iFrameBod.rows.length;
                var PageSize = document.getElementsByClassName('panelPaginationC');
                var ParentPageSize = window.parent.document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>');
                var IframePageSize = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>');
                if (PageSize != null) {
                    if (window.parent.NewRecords == "True") {
                        window.parent.currpagesize = parseInt(IframePageSize.value) + parseInt(OrgPageSize);
                        IframePageSize.value = window.parent.currpagesize;
                        IframePageSize.onchange();
                        var olddiv = window.parent.document.getElementById('loadgif');
                        if (olddiv == null) {
                            window.parent.$('#' + '<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>').after('<div id=\"loadgif\" align=\"center\"><img id=\"loading-image\" src=\"../Images/ajax-loader.gif\"></img></div>');
                        }
                    }
                }
                window.parent.bool = "False";
            } catch (err) {
            }
        }
    }
    function onScroll() {
        try {
            var t = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
            if (t != null && t.contentWindow.rowfetch > 0) {
                var Form = document.forms['aspnetForm'];
                var Loc = Form.action;
                var iFrameBod = t.contentDocument.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
                var rowLengt = iFrameBod.rows.length;
                var PageSize = t.contentDocument.getElementsByClassName('panelPaginationC');
                var ParentPageSize = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>');
                var IframePageSize = t.contentDocument.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>');
                if (PageSize != null) {
                    if (NewRecords == "True") {
                        currpagesize = parseInt(IframePageSize.value) + parseInt(OrgPageSize);
                        IframePageSize.value = currpagesize;
                        IframePageSize.onchange();
                        var olddiv = document.getElementById('loadgif');
                        if (olddiv == null) {
                            $('#' + '<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>').after('<div id=\"loadgif\" align=\"center\"><img id=\"loading-image\" src=\"../Images/ajax-loader.gif\"></img></div>');
                        }
                    }
                }
                bool = "False";
            }     
        } catch (err) {
            var olddiv = document.getElementById('loadgif');
            if (olddiv != null) {
                olddiv.outerHTML = ""; delete olddiv.parentNode;
            }
        }
    }
    function ScrollRegName() {
        try {
            var parent = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
            var stop = "False"; var divid = parent.className;
            while (stop != "True") {
                if (divid != undefined) {
                    if (divid == "scrollRegion" || divid == "QSscrollRegion" || divid == "tableContainer" || divid == "fixedHeaderScrollRegion") { stop = "True"; return parent.id } else {
                        parent = parent.parentNode; if (parent != undefined) { divid = parent.className;} else { return;}
                    }
                } else { return;}
            }
        } catch (err) {}
    }

    function ScrollBarCheck() {
        try {
            if (ScrollRegionName == "") { ScrollRegionName = window.parent.ScrollRegionName;}
            if ((window.parent.frameElement == null && ScrollRegionName == "scrollRegion") || (window.parent.frameElement == null && ScrollRegionName == "")) {
                if ($(window.parent).scrollTop() == 0) { $(window.parent).scrollTop(10);}
                window.parent.bool = "True"; var Height = document.body.scrollHeight;
                var Top = $(window.parent).scrollTop(); var CHeight = document.body.scrollHeight;
                if (Height == (Top + CHeight)) {
                    if ($(window.parent).scrollTop() == 0) { $(window.parent).scrollTop(10);}
                    if (window.parent.postbackSucess == "True") {onScrollNoSbar();}
                }
            } else {
                if (window.parent.$('#' + ScrollRegionName).scrollTop() == 0) {window.parent.$('#' + ScrollRegionName).scrollTop(1);}
                window.parent.bool = "True"; var Height = window.parent.$('#' + ScrollRegionName)[0].scrollHeight;
                var Top = window.parent.$('#' + ScrollRegionName).scrollTop(); var CHeight = window.parent.$('#' + ScrollRegionName)[0].scrollHeight;
                if (Height == (Top + CHeight)) {
                    if (window.parent.$('#' + ScrollRegionName).scrollTop() == 0) {
                        window.parent.$('#' + ScrollRegionName).scrollTop(1);
                    }
                    if (window.parent.postbackSucess == "True") {onScrollNoSbar();}
                }
            }
        } catch (err) {
        }
    }
    function CalculateRowFetch() {
        try {
            var iframtable = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
            var rowLength = iframtable.rows.length; rowfetch = iframtable.rows.length; counter = 0;
            for (i = (rowLength - 1) ; i >= 0; i--) {
                if (iframtable.rows[i].attributes.length != 0) {
                    if (iframtable.rows[i].attributes[0].value == "Footer") {counter = counter + 1; }
                }
                else { break;}
            }
            rowfetch = rowfetch - counter;
            return rowfetch;
        } catch (err) {}
    }
    function resetvalue() {
       var iframeName = "";
       if (window.frameElement != null) {iframeName = window.frameElement.id; }
       if (iframeName.indexOf("Infiniteframe") == -1) { var PageIndex = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>'); PageIndex.value = parseInt(OrgPageSize); }
    }
    function CopyToChild() {
        bool = "True"; NewRecords = "True"; postback = "True"; var parentid = "";
        var ParentTable = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_PageSizeButton")) %>');
        var parentrowlength = ParentTable.rows.length - counter;
        if (parentrowlength == OrgRowLenght) { currpagesize = OrgPageSize; }
        var MyCurrForm = document.getElementById('aspnetForm');
        var initialframe = document.getElementById('<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
        var mystring = document.documentElement.outerHTML; var ind1 = mystring.indexOf("action=\"", mystring.indexOf("<form"));
        var ind2 = mystring.indexOf("\"", (ind1 + 8)); var replace = mystring.substring(ind1, (ind2));
        if (MyCurrForm.action.indexOf("?") == -1) {mystring = mystring.replace(replace, "action = \"" + MyCurrForm.action + "?InfiIframe"); } else { mystring = mystring.replace(replace, "action = \"" + MyCurrForm.action + "&InfiIframe") }
        var index1 = mystring.indexOf("<iframe id=\"" + '<%= SystemUtils.InfinitePagination(FindControl("Infiniteframe")) %>');
        var index2 = mystring.indexOf("</iframe>", index1); var outerstuff = mystring
        if (index1 != -1) { outerstuff = mystring.substring(0, index1) + mystring.substring((index2 + 9), mystring.length); }
        var dstDoc = initialframe.contentWindow.document;
        cpychld = true;
        OnLoadHit = false;
        PageReadyHit = false;
        dstDoc.open(); dstDoc.write(outerstuff); dstDoc.close();
        cpychld = false;
        if (OnLoadHit != true && PageReadyHit != true) {
            done = "False";
        }
        initialframe.name = "PostbackIframe"; 
        submitcount = 0; justcopied = true;
        if (navigator.appName == 'Microsoft Internet Explorer') {
            var IframePageSize = initialframe.contentDocument.getElementById('<%= SystemUtils.InfinitePagination(FindControl("_CurrentPage")) %>');
            IframePageSize.value = currpagesize; dontpostback = true; IframePageSize.onchange();
        }
    }
</script>