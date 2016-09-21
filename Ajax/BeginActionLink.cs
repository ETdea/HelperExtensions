using System.Collections.Generic;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace System.Web.Mvc.Ajax
{
    public static partial class AjaxHelperExtensions
    {
        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, object routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, protocol, hostName, fragment, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.ActionLink(HtmlHelperExtensions.LINK_TEXT, actionName, controllerName, protocol, hostName, fragment, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, object routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, linkText, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, object routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, routeValues, ajaxOptions);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static MvcLink BeginRouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = ajaxHelper.RouteLink(HtmlHelperExtensions.LINK_TEXT, routeName, protocol, hostName, fragment, routeValues, ajaxOptions, htmlAttributes);
            return HtmlHelperExtensions.BeginActionLink(ajaxHelper.ViewContext, mvcHtmlString, linkText);
        }
    }
}