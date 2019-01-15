﻿using AspNetSeo.CoreMvc.Internal;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetSeo.CoreMvc.TagHelpers
{
    [HtmlTargetElement("og-type", TagStructure = TagStructure.WithoutEndTag)]
    [OutputElementHint("meta")]
    public class OgTypeTagHelper : SeoTagHelperBase
    {
        public OgTypeTagHelper(SeoHelper seoHelper)
            : base(seoHelper)
        {
        }

        public string Value { get; set; }

        public override void Process(
            TagHelperContext context,
            TagHelperOutput output)
        {
            var content = TagValueUtility.GetContent(
                Value,
                SeoHelper.OgType);

            output.ProcessMeta(OgMetaName.Type, content);
        }
    }
}