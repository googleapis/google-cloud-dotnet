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

            var client = serviceOptions.Client ?? TraceServiceClient.Create();
            var options = serviceOptions.Options ?? TraceOptions.Create();
            var traceFallbackPredicate = serviceOptions.TraceFallbackPredicate ?? TraceDecisionPredicate.Default;
            var projectId = Project.GetAndCheckProjectId(serviceOptions.ProjectId);

            var consumer = ManagedTracer.CreateConsumer(client, options);
            var tracerFactory = ManagedTracer.CreateTracerFactory(projectId, consumer, options);

            services.AddScoped(CreateTraceHeaderContext);
            services.AddSingleton(tracerFactory);
            services.AddHttpContextAccessor();
            services.AddSingleton(ManagedTracer.CreateDelegatingTracer(ContextTracerManager.GetCurrentTracer));
            services.AddTransient<ICloudTraceNameProvider, DefaultCloudTraceNameProvider>();
            
            // On .Net Standard 2.0 or higher, we can use the System.Net.Http.IHttpClientFactory defined in Microsoft.Extensions.Http,
            // for which we need a DelagatingHandler with no InnerHandler set. This is the recommended way.
            // It should be registered as follows.
            services.AddTransient(sp => new UnchainedTraceHeaderPropagatingHandler(ContextTracerManager.GetCurrentTracer));
            // This is to be used for explicitly creating an HttpClient instance. Valid for all platforms.
            services.AddSingleton(new TraceHeaderPropagatingHandler(ContextTracerManager.GetCurrentTracer));

            return services.AddSingleton(traceFallbackPredicate);
        }

        /// <summary>
        /// Creates an <see cref="TraceHeaderContext"/> based on the current <see cref="HttpContext"/>
        /// and a <see cref="TraceDecisionPredicate"/>.
        /// </summary>
        internal static TraceHeaderContext CreateTraceHeaderContext(IServiceProvider provider)
        {
            var accessor = provider.GetRequiredService<IHttpContextAccessor>();
            var traceDecisionPredicate = provider.GetRequiredService<TraceDecisionPredicate>();

            string header = accessor.HttpContext?.Request?.Headers[TraceHeaderContext.TraceHeader];
            Func<bool?> shouldTraceFunc = () =>
                traceDecisionPredicate.ShouldTrace(accessor.HttpContext?.Request);
            return TraceHeaderContext.FromHeader(header, shouldTraceFunc);
        }
    }
}
