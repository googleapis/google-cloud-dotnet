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
        /// when the request being handled by this server is already being traced
        /// </summary>
        public static IHttpClientBuilder AddOutgoingGoogleTraceHandler(this IHttpClientBuilder clientBuilder) =>
            clientBuilder.AddHttpMessageHandler<UnchainedTraceHeaderPropagatingHandler>();
    }
}
