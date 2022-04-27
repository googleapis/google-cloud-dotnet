// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extensions methods for <see cref="IHttpClientBuilder"/>.
    /// </summary>
    public static class HttpClientBuilderExtensions
    {
        /// <summary>
        /// Adds an <see cref="UnchainedTraceHeaderPropagatingHandler"/> to the HTTP client being built,
        /// which will propagate trace information for outgoing requests, made with this client,
        /// when the request being handled by this server is already being traced.
        /// </summary>
        /// <param name="clientBuilder">The <see cref="IHttpClientBuilder"/> to add this handler to.</param>
        public static IHttpClientBuilder AddOutgoingGoogleTraceHandler(this IHttpClientBuilder clientBuilder) =>
            clientBuilder.AddOutgoingGoogleTraceHandler(labelsProvider: null);

        /// <summary>
        /// Adds an <see cref="UnchainedTraceHeaderPropagatingHandler"/> to the HTTP client being built,
        /// which will propagate trace information for outgoing requests, made with this client,
        /// when the request being handled by this server is already being traced.
        /// </summary>
        /// <param name="clientBuilder">The <see cref="IHttpClientBuilder"/> to add this handler to.</param>
        /// <param name="labelsProvider">A function that provides labels that will be added to the outgoing trace.
        /// The function will be called once per handler, on creation, and the labels obtained at that point will be
        /// used for all subsequent requests made through this handler. Note that the scope of the
        /// <see cref="IServiceProvider"/> argument will share the lifetime of the handler being created.
        /// May be null, in which case no costum labels will be added to the outgoing trace.</param>
        public static IHttpClientBuilder AddOutgoingGoogleTraceHandler(
            this IHttpClientBuilder clientBuilder, Func<IServiceProvider, IDictionary<string, string>> labelsProvider) =>
            clientBuilder.AddHttpMessageHandler(sp => sp.GetRequiredService<OutgoingGoogleTraceHandlerFactory>().Create(sp, labelsProvider));

        internal class OutgoingGoogleTraceHandlerFactory
        {
            internal UnchainedTraceHeaderPropagatingHandler Create(IServiceProvider serviceProvider, Func<IServiceProvider, IDictionary<string, string>> labelsProvider) =>
                new UnchainedTraceHeaderPropagatingHandler(
                    ContextTracerManager.GetCurrentTracer,
                    serviceProvider.GetService<Action<HttpRequestMessage, ITraceContext>>(),
                    labelsProvider?.Invoke(serviceProvider));
        }
    }
}
