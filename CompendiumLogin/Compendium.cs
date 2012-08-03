using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace CompendiumLogin
{
    class Compendium
    {
        private static WebClient client = new WebClient();
        private static string rootUrl = "http://www.domain.com";

        public static void SetRootURL(string rootUrl)
        {
            Compendium.rootUrl = rootUrl;
        }

        /// <summary>
        /// Must be called once prior to any scrape operations.
        /// </summary>
        /// <param name="username">The DDI username.</param>
        /// <param name="password">The DDI password.</param>
        public static void Login(String username, String password)
        {
            NameValueCollection data = new NameValueCollection(2);
            data.Add("email", username);
            data.Add("password", password);

            Request(rootUrl + @"/global/dnd_login.asp", data, true);
        }

        public static string Fetch(CompendiumType type)
        {
            return Request(rootUrl + @"/dndinsider/compendium/" + HttpUtility.UrlEncode(type.ToString()) + @".aspx");
        }

        /// <summary>
        /// Simple wrapper around WebClient
        /// </summary>
        /// <param name="uri">What uri to hit</param>
        /// <param name="data">The parameters.</param>
        /// <param name="post">If true, POST, if false, GET</param>
        /// <returns>The response as a string.</returns>
        protected static string Request(String uri, NameValueCollection data, bool post)
        {
            byte[] result;
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Set(HttpRequestHeader.Referer, rootUrl + @"/default.asp?x=dnd/insider/compendium");
            client.Headers.Set(HttpRequestHeader.UserAgent, @"Mozilla/4.0 (compatible; MSIE 6.0;Windows NT 5.1; SV1; .NET CLR 1.1.4322)");
            if (post)
            {
                client.Headers.Set(HttpRequestHeader.ContentType, @"application/x-www-form-urlencoded");
                result = client.UploadValues(uri, "POST", data);
            }
            else
            {
                result = client.DownloadData(uri);
            }
            
            return Encoding.UTF8.GetString(result);
        }

        /// <summary>
        /// Simple GET request.
        /// </summary>
        /// <param name="uri">What URI to get?</param>
        /// <returns>The response as a string.</returns>
        protected static string Request(String uri)
        {
            return Request(uri, new NameValueCollection(), false);
        }

        /// <summary>
        /// Each string matches the ASPX page that the compendium uses to display the type.
        /// </summary>
        public sealed class CompendiumType
        {

            private readonly String name;

            public static readonly CompendiumType POWERS      = new CompendiumType("power");
            public static readonly CompendiumType NPCS        = new CompendiumType("monster");
            public static readonly CompendiumType FEATS       = new CompendiumType("feat");
            public static readonly CompendiumType RACES       = new CompendiumType("race");
            public static readonly CompendiumType PARAGONS    = new CompendiumType("paragonpath");
            public static readonly CompendiumType EPICS       = new CompendiumType("epicdestiny");
            public static readonly CompendiumType ITEMS       = new CompendiumType("item");
            public static readonly CompendiumType RITUALS     = new CompendiumType("ritual");
            public static readonly CompendiumType TRAPS       = new CompendiumType("trap");
            public static readonly CompendiumType BACKGROUNDS = new CompendiumType("background");
            public static readonly CompendiumType COMPANIONS  = new CompendiumType("companion");

            private CompendiumType(String name)
            {
                this.name = name;
            }

            public override String ToString()
            {
                return name;
            }

        }

        private class WebClient : System.Net.WebClient
        {
            private static CookieContainer cookies = new CookieContainer();

            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest request = base.GetWebRequest(address);
                HttpWebRequest webRequest = request as HttpWebRequest;
                if (webRequest != null)
                {
                    webRequest.CookieContainer = cookies;
                }
                return request;
            }
        } 
    }
}
