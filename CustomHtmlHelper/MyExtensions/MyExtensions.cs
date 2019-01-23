using CustomHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomHtmlHelper.MyExtensions
{
    public static class MyExtensions
    {
        public static MvcHtmlString Alert(this HtmlHelper helper, string id = "alert1", string color = "success", string text = "")
        {
            /*
            <div role = "alert" class="alert alert-success">
            Bu bir örnek yazıdır!
            </div>*/
            TagBuilder tag = new TagBuilder("div");
            tag.AddCssClass("alert alert-" + color);
            tag.GenerateId(id);
            tag.Attributes.Add(new KeyValuePair<string, string>("role", "alert"));
            tag.SetInnerText(text);

            return MvcHtmlString.Create(tag.ToString());
        }
        public static MvcHtmlString AlertFor<TModel, TProperty>(this HtmlHelper<TModel> helper, System.Linq.Expressions.Expression<Func<TModel, TProperty>> expression, object htmlAttributes)
        {
            TagBuilder tag = new TagBuilder("div");
            tag.AddCssClass("alert");
            tag.Attributes.Add(new KeyValuePair<string, string>("role", "alert"));

            var valueGetter = expression.Compile();
            var message = valueGetter(helper.ViewData.Model) as MyMessages;

            if (message.Id == Guid.Empty) message.Id = Guid.NewGuid();

            if (message.Level < 1) message.Level = 1;
            if (message.Level > 4) message.Level = 4;

            switch (message.Level)
            {
                case 1:
                    tag.AddCssClass("alert-success");
                    break;
                case 2:
                    tag.AddCssClass("alert-info");
                    break;
                case 3:
                    tag.AddCssClass("alert-warning");
                    break;
                case 4:
                    tag.AddCssClass("alert-danger");
                    break;
                default:
                    break;
            }

            tag.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            tag.GenerateId(message.Id.ToString());
            tag.SetInnerText(message.Text);

            return MvcHtmlString.Create(tag.ToString());
        }


        public static MvcHtmlString CustomButton(this HtmlHelper poHelper, string id = "testId", string name = "testName", string buttonName = "Custom Button")
        {
            //<button type="submit" id="testId" name="testId" class="btn btn-success">Custom Button</button>
            TagBuilder tag = new TagBuilder("button");

            tag.GenerateId(id);

            tag.MergeAttribute("name", name);
            tag.MergeAttribute("type", "submit");

            tag.AddCssClass("btn btn-success");

            tag.SetInnerText(buttonName);

            //tag.MergeAttributes(new RouteValueDictionary(htmlAttributes));


            return MvcHtmlString.Create(tag.ToString());
        }
    }
}