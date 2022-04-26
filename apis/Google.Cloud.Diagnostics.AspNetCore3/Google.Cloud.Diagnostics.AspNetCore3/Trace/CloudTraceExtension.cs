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
    ///  and metadata will be sent to the Google Cloud Trace API.  Also allows for more
    ///  finely grained manual tracing.
    /// </summary>
    /// <remarks>
    /// Traces requests and reports them to Google Cloud Trace.
    /// Docs: https://cloud.google.com/trace/docs/
    /// </remarks>
#if NETCOREAPP3_1
    [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreTraceExtensions instead.")]
#elif NETSTANDARD2_0
    [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore.AspNetCoreTraceExtensions instead.")]
#else
#error unknown target framework
#endif
    public static class CloudTraceExtension
    {
        /// <summary>
        /// Uses middleware that will trace time taken for all subsequent delegates to run.
        /// The time taken and metadata will be sent to the Google Cloud Trace API. To be
        /// used with <see cref="AddGoogleTrace"/>,
        /// </summary>
#if NETCOREAPP3_1
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreTraceExtensions.AddGoogleTraceForAspNetCore" +
            "for configuring Google Cloud Trace in ASP.NET Core applications. There's no need to explicitly register the middleware.")]
#elif NETSTANDARD2_0
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore.AspNetCoreTraceExtensions.AddGoogleTraceForAspNetCore" +
            "for configuring Google Cloud Trace in ASP.NET Core applications. There's no need to explicitly register the middleware.")]
#else
#error unknown target framework
#endif
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
#if NETCOREAPP3_1
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreTraceExtensions.AddGoogleTraceForAspNetCore instead.")]
#elif NETSTANDARD2_0
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore.AspNetCoreTraceExtensions.AddGoogleTraceForAspNetCore instead.")]
#else
#error unknown target framework
#endif
        public static IServiceCollection AddGoogleTrace(
            this IServiceCollection services, Action<TraceServiceOptions> setupAction)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(setupAction, nameof(setupAction));

            var serviceOptions = new TraceServiceOptions();
            setupAction(serviceOptions);

            services.AddGoogleTraceForAspNetCore(false, new AspNetCoreTraceOptions
            { 
                TraceFallbackPredicate = serviceOptions.TraceFallbackPredicate,
                ServiceOptions = new Common.TraceServiceOptions
                {
                    Client = serviceOptions.Client,
                    Options = serviceOptions.Options,
                    ProjectId = serviceOptions.ProjectId
                }
            });

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

            return services;
        }
    }
}
