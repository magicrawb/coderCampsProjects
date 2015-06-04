﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Day7HTMLHelpers.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string url)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.MergeAttribute("src", url);
            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }

    public static class ShowPriceHelper
    {
        public static MvcHtmlString ShowPrice<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            //get view modeel property name
            var name = ExpressionHelper.GetExpressionText(expression);

            //get view model prop meta data
            var metaData = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);

            //display price
            var text = string.Format("{0} is {1:c}", name, metaData.Model);
            return MvcHtmlString.Create(text);
        }
    }
}