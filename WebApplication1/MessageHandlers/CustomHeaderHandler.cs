using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebApplication1.MessageHandlers
{
    public class CustomHeaderHandler : DelegatingHandler
    {
       async protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            response.Headers.Add("X-Custom-Header", "this is my custom header");
            return response;
        }
    }
}