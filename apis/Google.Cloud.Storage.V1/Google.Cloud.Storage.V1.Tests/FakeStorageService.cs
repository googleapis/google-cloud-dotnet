using Google.Apis.Storage.v1;
using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Requests;
using Google.Apis.Util;
using Google.Cloud.ClientTesting;
using System.Net;
using System.Net.Http;

namespace Google.Cloud.Storage.V1.Tests
{
    class FakeStorageService : StorageService
    {
        private readonly ReplayingMessageHandler handler;

        public FakeStorageService() : base(new Initializer
        {
            HttpClientFactory = new FakeHttpClientFactory(new ReplayingMessageHandler()),
            ApplicationName = "Fake",
            GZipEnabled = false
        })
        {
            handler = (ReplayingMessageHandler)HttpClient.MessageHandler.InnerHandler;
        }

        public void ExpectRequest<TResponse>(ClientServiceRequest<TResponse> request, TResponse response)
        {
            //MaybeDisablePrettyPrint(request);
            var httpRequest = request.CreateRequest();
            string responseContent = SerializeObject(response);
            handler.ExpectRequest(httpRequest.RequestUri, httpRequest.Content?.ReadAsStringAsync()?.Result, responseContent);
        }

        public void ExpectRequest<TResponse>(ClientServiceRequest<TResponse> request, HttpStatusCode statusCode)
        {
            //MaybeDisablePrettyPrint(request);
            var httpRequest = request.CreateRequest();
            var responseMessage = new HttpResponseMessage(statusCode); 
            handler.ExpectRequest(httpRequest.RequestUri, httpRequest.Content?.ReadAsStringAsync()?.Result, responseMessage);
        }

        private void MaybeDisablePrettyPrint(dynamic request)
        {
            // Almost all our tests using FakeService will have prettyPrint=false, and the requests will all
            // be derived from the generic ServiceBaseRequest which has a PrettyPrint property.
            // We use ??= so that if the request already has PrettyPrint set, we don't change that.
            request.PrettyPrint ??= false;
        }

        public void Verify() => handler.Verify();
    }
}
