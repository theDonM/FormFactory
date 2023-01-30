using System;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using FormFactory.AspMvc.Wrappers;
using Microsoft.AspNetCore.Html;
using HtmlString = Microsoft.AspNetCore.Html.HtmlString;

namespace FormFactory
{
    public static class AspMvcViewFinderExtensions
    {
        public static HtmlString BestProperty(this HtmlHelper html, PropertyVm vm)
        {
            string viewName = ViewFinderExtensions.BestPropertyName(new FormFactoryHtmlHelper(html), vm);
            return new HtmlString(html.Partial(viewName, vm).ToString());
        }

        public static string BestViewName(this HtmlHelper html, Type type, string prefix = null)
        {
            return FormFactory.ViewFinderExtensions.BestViewName(new FormFactoryHtmlHelper(html), type, prefix);
        }
        public static HtmlString BestPartial(this HtmlHelper html, object model, Type type = null, string prefix = null)
        {
            var partialViewName = BestViewName(html, type ?? model.GetType(), prefix);
            return new HtmlString(html.Partial(partialViewName, model).ToString());
        }
    }
}
