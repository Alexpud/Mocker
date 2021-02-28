using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;

namespace Mocker
{
    public class HttpCustomDispatcher : HttpMessageHandler
    {
        private IHttpControllerSelector _controllerSelector;
        private readonly HttpConfiguration _configuration;

        public HttpCustomDispatcher(HttpConfiguration configuration)
        {
            _configuration = configuration;
        }

        public HttpConfiguration Configuration
        {
            get { return _configuration; }
        }

        private IHttpControllerSelector ControllerSelector
        {
            get
            {
                if (_controllerSelector == null)
                {
                    _controllerSelector = _configuration.Services.GetHttpControllerSelector();
                }
                return _controllerSelector;
            }
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return SendAsyncInternal(request, cancellationToken);
        }

        private Task<HttpResponseMessage> SendAsyncInternal(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            IHttpRouteData routeData = request.GetRouteData();
            Contract.Assert(routeData != null);

            //DO SOMETHING CUSTOM HERE TO PICK YOUR CONTROLLER
            HttpControllerDescriptor httpControllerDescriptor = ControllerSelector.SelectController(request);
            IHttpController httpController = httpControllerDescriptor.CreateController(request);

            // Create context
            HttpControllerContext controllerContext = new HttpControllerContext(_configuration, routeData, request);
            controllerContext.Controller = httpController;
            controllerContext.ControllerDescriptor = httpControllerDescriptor;

            return httpController.ExecuteAsync(controllerContext, cancellationToken);
        }
    }
}
