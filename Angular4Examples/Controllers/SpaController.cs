using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace Angular4Examples.Controllers
{
    public class SpaController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var indexHtml = HostingEnvironment.MapPath("~/index.html");

            var stringContent = new StreamContent(File.OpenRead(indexHtml));
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = stringContent };

            return response;
        }
    }
}