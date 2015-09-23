using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.MessageHandlers
{
    public class PreRouteMessageHandler:DelegatingHandler
    {
       async protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage
            {
                Content = new StringContent("Hello")
            };
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}