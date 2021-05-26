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
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
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
    ///     using (tracer.StartSpan(nameof(SomeFunction)))
    ///     {
    ///         ...
    ///         // Do work.
    ///         ...
    ///     }
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
        /// <summary>
        /// Uses middleware that will trace time taken for all subsequent delegates to run.
        /// The time taken and metadata will be sent to the Stackdriver Trace API. To be
        /// used with <see cref="AddGoogleTrace"/>,
        /// </summary>
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app)
        {
            GaxPreconditions.CheckNotNull(app, nameof(app));
            return app.UseMiddleware<CloudTraceMiddleware>();
        }

        /// <summary>
        /// Adds the needed services for Google Cloud Tracing. Used with <see cref="UseGoogleTrace"/>.
        /// </summary>
        /// <param name="services">The service collection. Must not be null.</param>
        /// <param name="setupAction">Action to set up options. Must not be null.</param>
        /// <remarks>
        /// If <see cref="RetryOptions.ExceptionHandling"/> is set to <see cref="ExceptionHandling.Propagate"/>
        /// and the <see cref="RequestDelegate"/> executed by this middleware throws ad exception and this
        /// diagnostics library also throws an exception trying to report it and <see cref="AggregateException"/>
        /// with both exceptions will be thrown.  Otherwise only the exception from the <see cref="RequestDelegate"/>
        /// will be thrown.
        /// </remarks>
        public static IServiceCollection AddGoogleTrace(
            this IServiceCollection services, Action<TraceServiceOptions> setupAction)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(setupAction, nameof(setupAction));

            var serviceOptions = new TraceServiceOptions();
            setupAction(serviceOptions);

            services.AddGoogleTrace((Common.TraceServiceOptions commonOptions) =>
            {
                commonOptions.ProjectId = serviceOptions.ProjectId;
                commonOptions.Options = serviceOptions.Options;
                commonOptions.Client = serviceOptions.Client;
            });

            var traceFallbackPredicate = serviceOptions.TraceFallbackPredicate ?? TraceDecisionPredicate.Default;

            // We use TryAdd... here to allow user code to inject their own trace context provider
            // and matching trace context response propagator. We use Google trace header otherwise.
            services.TryAddScoped<ITraceContext>(ProvideGoogleTraceHeaderContext);
            services.TryAddSingleton<Action<HttpResponse, ITraceContext>>(PropagateGoogleTraceHeaders);

            // Obsolete: Adding this for backwards compatibility in case someone is using the old factory type.
            // The new and prefered factory type is Func<ITraceContext, IManagedTracer>.
            services.AddSingleton<Func<TraceHeaderContext, IManagedTracer>>(sp => sp.GetRequiredService<Func<ITraceContext, IManagedTracer>>());

            services.AddHttpContextAccessor();
            services.AddTransient<ICloudTraceNameProvider, DefaultCloudTraceNameProvider>();

            // This is to be used for explicitly creating an HttpClient instance. Valid for all platforms but subject to
            // issues with HttpClient lifetime as described in
            // https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests.
            // Although TraceHeaderPropagatingHandler supports a custom trace context propagator, we don't support it here by default.
            // The context propagator may be transient or scoped, in which case we'd have to register the TraceHeaderPropagatingHandler
            // as transient or scoped respectively. We don't know how to do that, and we don't want to do transient by default because
            // of the lifecycle issues described on the link above.
            // We use TryAdd so that user code may add their own TraceHeaderPropagatingHandler.
            // Obsolete: We are targeting netstastandard2.0 so user code can use the preferred UnchainedTraceHeaderPropagatingHandler.
            services.TryAddSingleton(new TraceHeaderPropagatingHandler(ContextTracerManager.GetCurrentTracer));

            return services.AddSingleton(traceFallbackPredicate);
        }

        /// <summary>
        /// Creates an <see cref="TraceHeaderContext"/> based on the current <see cref="HttpContext"/>
        /// and a <see cref="TraceDecisionPredicate"/>.
        /// Used by default to obtain trace context, if user code has not specified a trace context provider.
        /// </summary>
        internal static TraceHeaderContext ProvideGoogleTraceHeaderContext(IServiceProvider serviceProvider)
        {
            var accessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
            string header = accessor.HttpContext?.Request?.Headers[TraceHeaderContext.TraceHeader];
            return TraceHeaderContext.FromHeader(header);
        }

        /// <summary>
        /// Propagates Google trace context information to the response.
        /// Used by default if user code has not specified a propagator of their own.
        /// </summary>
        internal static void PropagateGoogleTraceHeaders(HttpResponse response, ITraceContext traceContext)
        {
            var googleHeader = TraceHeaderContext.Create(traceContext.TraceId, traceContext.SpanId ?? 0, traceContext.ShouldTrace);
            response.Headers.Add(TraceHeaderContext.TraceHeader, googleHeader.ToString());
        }
    }
}
