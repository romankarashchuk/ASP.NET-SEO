﻿using System;

namespace AspNetSeo.CoreMvc
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
    public class MetaDescriptionAttribute : SeoAttributeBase
    {
        private readonly string _value;

        public MetaDescriptionAttribute(string value)
        {
            _value = value;
        }

        public override void OnHandleSeoValues(SeoHelper seoHelper)
        {
            seoHelper.MetaDescription = _value;
        }
    }
}