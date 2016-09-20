using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Routing;

namespace System.Web.Mvc.Html
{

    public static partial class HtmlHelperExtensions
    {
        internal const string LINK_TEXT = "linkText";

        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, object routeValues)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, routeValues);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, RouteValueDictionary routeValues)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, routeValues);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, controllerName);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, object routeValues, object htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, controllerName, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, controllerName, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, controllerName, protocol, hostName, fragment, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.ActionLink(LINK_TEXT, actionName, controllerName, protocol, hostName, fragment, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, object routeValues)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeValues);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, RouteValueDictionary routeValues)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeValues);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, object routeValues)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName, routeValues);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, RouteValueDictionary routeValues)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName, routeValues);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, object routeValues, object htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, object routeValues, object htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName, protocol, hostName, fragment, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }
        public static MvcLink BeginRouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            var mvcHtmlString = htmlHelper.RouteLink(LINK_TEXT, routeName, protocol, hostName, fragment, routeValues, htmlAttributes);
            return BeginActionLink(htmlHelper.ViewContext, mvcHtmlString, linkText);
        }

        public static void EndLink(this HtmlHelper htmlHelper)
        {
            EndLink(htmlHelper.ViewContext);
        }

        public static void EndLink(ViewContext viewContext)
        {
            const string END_LINK = "</a>";
            var linkText = viewContext.ViewBag.BeginActionLinkText ?? string.Empty;

            viewContext.Writer.Write(linkText + END_LINK);
        }

        public static MvcLink BeginActionLink(ViewContext viewContext, MvcHtmlString mvcHtmlString, string linkText)
        {
            const string PATTERN = "<(\\w+)\\s+\\w+.*?>";

            if (linkText == null)
            {
                linkText = string.Empty;
            }

            var str = mvcHtmlString.ToString();
            var beginTag = Regex.Match(str, PATTERN).Value;

            viewContext.Writer.Write(beginTag);
            viewContext.ViewBag.BeginActionLinkText = linkText;

            var mvcActionLink = new MvcLink(viewContext);

            return mvcActionLink;
        }
    }
}