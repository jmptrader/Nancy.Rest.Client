﻿using System;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;

namespace Nancy.Rest.Client.Rest
{
    public class Request
    {
        public Uri BaseUri { get; set; }
        public HttpMethod Method { get; set; }
        public string Path { get; set; }
        public object BodyObject { get; set; }
        public JsonSerializerSettings SerializerSettings { get; set; }
        public Type ReturnType { get; set; }
        public TimeSpan Timeout { get; set; }

        public void AddQueryParamater(string name, string value)
        {
            string separator = "&";
            if (!Path.Contains("?"))
                separator = "?";
            Path=Path + separator + HttpUtility.UrlEncode(name) + "=" + HttpUtility.UrlEncode(value);
        }
    }
}
