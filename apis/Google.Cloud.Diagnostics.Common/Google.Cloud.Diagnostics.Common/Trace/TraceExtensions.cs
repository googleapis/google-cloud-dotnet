// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Trace.V1;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using static Google.Cloud.Diagnostics.Common.HttpClientBuilderExtensions;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for registering Google Cloud Trace for
    /// dependency injection.
    /// </summary>
    public static class TraceExtensions
    {
        /// <summary>
        /// Configures Google Cloud Trace for dependency injection.
        /// </summary>
        public static IServiceCollection AddGoogleTrace(this IServiceCollection services, TraceServiceOptions options = null)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));

            var client = options?.Client ?? TraceServiceClient.Create();
            var traceOptions = options?.Options ?? TraceOptions.Create();
            var projectId = Project.GetAndCheckProjectId(options?.ProjectId);

            var consumer = ManagedTracer.CreateConsumer(client, traceOptions);
            var tracerFactory = ManagedTracer.CreateFactory(projectId, consumer, traceOptions);

            services.AddSingleton(tracerFactory);
            services.AddSingleton(ManagedTracer.CreateDelegatingTracer(ContextTracerManager.GetCurrentTracer));

            // On .Net Standard 2.0 or higher, we can use the System.Net.Http.IHttpClientFactory defined in Microsoft.Extensions.Http,
            // for which we need a DelegatingHandler with no InnerHandler set.
            // we register factories for the UnchainedTraceHeaderPropagatingHandler.

            // This is the new factory, that takes trace custom labels into account.
            return services.AddSingleton<OutgoingGoogleTraceHandlerFactory>();
        }
    }
}
