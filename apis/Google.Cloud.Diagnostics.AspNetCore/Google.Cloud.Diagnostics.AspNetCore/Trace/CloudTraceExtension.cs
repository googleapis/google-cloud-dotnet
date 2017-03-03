// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Trace.V1;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    ///  Uses the Google Cloud Trace Middleware.
    ///  Traces the time taken for all subsequent delegates to run.  The time taken
    ///  and metadata will be sent to the Stackdriver Trace API.  Also allows for more
    ///  finely grained manual tracing.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void ConfigureServices(IServiceCollection services)
    /// {
    ///     string projectId = "[Google Cloud Platform project ID]";
    ///     services.AddGoogleTrace(projectId);
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void Configure(IApplicationBuilder app)
    /// {
    ///     // Use at the start of the request pipeline to ensure the entire
    ///     // request is traced.
    ///     app.UseGoogleTrace();
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void SomeFunction(IManagedTracer tracer)
    /// {
    ///     tracer.StartSpan(nameof(SomeFunction));
    ///     ...
    ///     // Do work.
    ///     ...
    ///     tracer.EndSpan();
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Traces requests and reports them to Google Cloud Trace.
    /// Docs: https://cloud.google.com/trace/docs/
    /// </remarks>
    public static class CloudTraceExtension
    {
        ///<summary>The key to save the tracer under in the <see cref="HttpContext"/></summary> 
        internal const string TraceKey = "Google.Cloud.Diagnostics.AspNetCore.Trace";

        /// <summary>
        /// A class to wrap the "shouldTraceFunc" param in <see cref="AddGoogleTrace"/>.
        /// This is used instead of injecting the value of "shouldTraceFunc" directly 
        /// to ensure we do not override a service the user setup.
        /// </summary>
        internal class ShouldTraceRequest
        {
            internal Func<HttpRequest, bool?> ShouldTrace { get; set; }
        }

        /// <summary>
        /// Uses middleware that will trace time taken for all subsequent delegates to run.
        /// The time taken and metadata will be sent to the Stackdriver Trace API. To be
        /// used with <see cref="AddGoogleTrace"/>,
        /// </summary>
        public static void UseGoogleTrace(this IApplicationBuilder app)
        {
            GaxPreconditions.CheckNotNull(app, nameof(app));
            app.UseMiddleware<CloudTraceMiddleware>();
        }

        /// <summary>
        /// Adds the needed services for Google Cloud Tracing. Used with <see cref="UseGoogleTrace"/>.
        /// </summary>
        /// <param name="services">The service collection. Cannot be null.</param>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="config">Optional trace configuration, if unset the default will be used.</param>
        /// <param name="client">Optional Trace client, if unset the default will be used.</param>
        /// <param name="shouldTraceFunc">Optional function to trace requests. If the trace header is not set
        ///     then this function will be called to determine if a given request should be traced.  This will
        ///     not override trace headers. If the function returns true the request will be traced, if false
        ///     is returned the trace will not be traced and if null is returned it will not affect the
        ///     trace decision.</param>
        public static void AddGoogleTrace(
            this IServiceCollection services, string projectId,
            TraceConfiguration config = null, TraceServiceClient client = null,
            Func<HttpRequest, bool?> shouldTraceFunc = null)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));

            client = client ?? TraceServiceClient.Create();
            config = config ?? TraceConfiguration.Create();

            var traceIdFactory = TraceIdFactory.Create();

            var consumer = ConsumerFactory<TraceProto>.GetConsumer(
                 new GrpcTraceConsumer(client), MessageSizer<TraceProto>.GetSize, config.BufferOptions);

            var tracerFactory = new ManagedTracerFactory(projectId, consumer,
                RateLimitingTraceOptionsFactory.Create(config), traceIdFactory);

            services.AddSingleton<IManagedTracerFactory>(tracerFactory);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(CreateTraceHeaderPropagatingHandler);
            services.AddSingleton(new ShouldTraceRequest { ShouldTrace = shouldTraceFunc });
            services.AddSingleton(traceIdFactory);

            services.AddScoped(CreateTraceHeaderContext);
            services.AddScoped(CreateManagedTracer);
        }

        /// <summary>
        /// Creates an <see cref="TraceHeaderPropagatingHandler"/>.
        /// </summary>
        private static TraceHeaderPropagatingHandler CreateTraceHeaderPropagatingHandler(IServiceProvider provider)
        {
            Func<IManagedTracer> managedTracerFactory = () =>
            {
                // We use the IHttpContextAccessor to get the IManagedTracer as the 
                // IHttpContextAccessor is a singleton and will always have the proper
                // HttpContext.  The IManagedTracer is attached to the HttpContext in
                // CreateManagedTracer.
                var accessor = provider.GetService<IHttpContextAccessor>();
                return accessor.HttpContext.Items[TraceKey] as IManagedTracer;
            };
            return new TraceHeaderPropagatingHandler(managedTracerFactory);
        }

        /// <summary>
        /// Creates an <see cref="TraceHeaderContext"/> based on the current <see cref="HttpContext"/>
        /// and a <see cref="ShouldTraceRequest"/>.
        /// </summary>
        internal static TraceHeaderContext CreateTraceHeaderContext(IServiceProvider provider)
        {
            var accessor = provider.GetServiceCheckNotNull<IHttpContextAccessor>();
            var shouldTraceRequest = provider.GetServiceCheckNotNull<ShouldTraceRequest>();
            var traceIdFactory = provider.GetServiceCheckNotNull<TraceIdFactory>();

            string header = accessor.HttpContext?.Request?.Headers[TraceHeaderContext.TraceHeader];
            var traceHeaderContext = TraceHeaderContext.FromHeader(header);
            if (traceHeaderContext.ShouldTrace == null && shouldTraceRequest.ShouldTrace != null)
            {
                string traceId = traceHeaderContext.TraceId ?? traceIdFactory.NextId();
                ulong spanId = traceHeaderContext.SpanId ?? 0;
                bool? shouldTrace = shouldTraceRequest.ShouldTrace(accessor.HttpContext?.Request);
                return new TraceHeaderContext(traceId, spanId, shouldTrace);
            }
            return TraceHeaderContext.FromHeader(header);
        }

        /// <summary>
        /// Creates a <see cref="IManagedTracer"/> based on the <see cref="TraceHeaderContext"/> and
        /// the rate limiter.
        /// </summary>
        internal static IManagedTracer CreateManagedTracer(IServiceProvider provider)
        {
            var headerContext = provider.GetServiceCheckNotNull<TraceHeaderContext>();
            var tracerFactory = provider.GetServiceCheckNotNull<IManagedTracerFactory>();
            var accessor = provider.GetServiceCheckNotNull<IHttpContextAccessor>();

            var tracer = tracerFactory.CreateTracer(headerContext);

            // Attach the IManagedTracer to the current HttpContext.  See comments
            // in CreateTraceHeaderPropagatingHandler for more details.
            accessor.HttpContext.Items[TraceKey] = tracer;
            return tracer;
        }

        /// <summary>
        /// Extension for the <see cref="IServiceProvider"/> that will call and return 
        /// <see cref="IServiceProvider.GetService(System.Type)"/>.  If the result of the
        /// call is null it will throw.
        /// </summary>
        internal static T GetServiceCheckNotNull<T>(this IServiceProvider provider)
        {
            var message = "No {0} service found. Ensure Google Cloud Trace is properly set up.";
            T service = provider.GetService<T>();
            GaxPreconditions.CheckState(service != null, string.Format(message, typeof(T)));
            return service;
        }
    }
}
