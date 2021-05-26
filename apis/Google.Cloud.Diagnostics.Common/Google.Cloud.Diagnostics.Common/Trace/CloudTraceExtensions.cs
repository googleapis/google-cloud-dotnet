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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for registering Google Cloud Trace for
    /// dependency injection.
    /// </summary>
    public static class CloudTraceExtensions
    {
        /// <summary>
        /// Configures Google Cloud Trace for dependency injection.
        /// </summary>
        public static IServiceCollection AddGoogleTrace(
            this IServiceCollection services, Action<TraceServiceOptions> setupAction)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(setupAction, nameof(setupAction));

            var serviceOptions = new TraceServiceOptions();
            setupAction(serviceOptions);

            var client = serviceOptions.Client ?? TraceServiceClient.Create();
            var options = serviceOptions.Options ?? TraceOptions.Create();
            var projectId = Project.GetAndCheckProjectId(serviceOptions.ProjectId);

            var consumer = ManagedTracer.CreateConsumer(client, options);
            var tracerFactory = ManagedTracer.CreateFactory(projectId, consumer, options);

            services.AddSingleton(tracerFactory);
            services.AddSingleton(ManagedTracer.CreateDelegatingTracer(ContextTracerManager.GetCurrentTracer));

            // On .Net Standard 2.0 or higher, we can use the System.Net.Http.IHttpClientFactory defined in Microsoft.Extensions.Http,
            // for which we need a DelegatingHandler with no InnerHandler set. This is the recommended way.
            // It should be registered as follows.
            return services.AddTransient(UnchainedTraceHeaderPropagatingHandlerFactory);
        }

        /// <summary>
        /// Returns an <see cref="UnchainedTraceHeaderPropagatingHandler"/> configured with the user specified trace context 
        /// outgoing propagator. If user code has not specified a trace context outgoing propagator, the Google header will
        /// be propagated.
        /// </summary>
        internal static UnchainedTraceHeaderPropagatingHandler UnchainedTraceHeaderPropagatingHandlerFactory(IServiceProvider serviceProvider) =>
            serviceProvider.GetService<Action<HttpRequestMessage, ITraceContext>>() is Action<HttpRequestMessage, ITraceContext> traceContextOutgoingPropagator ?
                new UnchainedTraceHeaderPropagatingHandler(ContextTracerManager.GetCurrentTracer, traceContextOutgoingPropagator) :
                new UnchainedTraceHeaderPropagatingHandler(ContextTracerManager.GetCurrentTracer);
    }
}
