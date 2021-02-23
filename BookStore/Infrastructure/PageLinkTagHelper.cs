using System;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace BookStore.Infrastructure

{
    [HtmlTargetElement("ul",Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper (IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]

        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }

        public string PageAction { get; set; }

        //Overriding
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("ul");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {

                TagBuilder listItem = new TagBuilder("li");

                TagBuilder link = new TagBuilder("a");

                listItem.Attributes["class"] = "px-3 nav-item";

                link.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });

                link.InnerHtml.Append(i.ToString());

                listItem.InnerHtml.Append(link.ToString());

                result.InnerHtml.AppendHtml(listItem);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
