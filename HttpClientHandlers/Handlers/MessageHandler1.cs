using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HttpClientHandlers.Handlers
{
    public class MessageHandler1: DelegatingHandler
    {
        private int _count = 0;
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            _count++;
            request.Headers.Add("X-Custom-Header", _count.ToString());
            return base.SendAsync(request, cancellationToken);
        }
    }
}