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

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Hosting;
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
    /// Extensions for configuring Google Cloud Trace in ASP.NET Core applications.
    /// </summary>
    public static class AspNetCoreTraceExtensions
    {
        /// <summary>
        /// Configures Google Cloud Tracing for ASP .NET Core applications./>.
        /// </summary>
        public static IServiceCollection AddGoogleTraceForAspNetCore(this IServiceCollection services, AspNetCoreTraceOptions options = null) =>
#pragma warning disable CS0618 // Type or member is obsolete
            services.AddGoogleTraceForAspNetCore(true, options);
#pragma warning restore CS0618 // Type or member is obsolete

        [Obsolete("This was added to avoid code duplication between the obsolete extension methods and the new one.")]
        internal static IServiceCollection AddGoogleTraceForAspNetCore(this IServiceCollection services, bool registerMiddleware, AspNetCoreTraceOptions options)
        {
            services.AddGoogleTrace(options?.ServiceOptions);

            services.AddSingleton(options?.TraceFallbackPredicate ?? TraceDecisionPredicate.Default);

            // We use TryAdd... here to allow user code to inject their own trace context provider
            // and matching trace context response propagator. We use Google trace header otherwise.
            services.TryAddGoogleTraceContextProvider();
            services.TryAddSingleton<Action<HttpResponse, ITraceContext>>(PropagateGoogleTraceHeaders);

            // Obsolete: Adding this for backwards compatibility in case someone is using the old factory type.
            // The new and prefered factory type is Func<ITraceContext, IManagedTracer> which is being added by Common.
            services.AddSingleton<Func<TraceHeaderContext, IManagedTracer>>(sp => sp.GetRequiredService<Func<ITraceContext, IManagedTracer>>());

            services.AddHttpContextAccessor();
            services.AddTransient<ICloudTraceNameProvider, DefaultCloudTraceNameProvider>();

            if (registerMiddleware)
            {
                // This registers the trace middleware so users don't have to.
                services.AddSingleton<IStartupFilter, AspNetCoreTraceStartupFilter>();
            }

            return services;
        }

        /// <summary>
        /// Adds the services needed for obtaining the trace context from Google's own trace header,
        /// but only if no other trace context provider is registered.
        /// If you are using <see cref="AddGoogleTraceForAspNetCore(IServiceCollection, AspNetCoreTraceOptions)"/>
        /// you don't need to call this method. Only use this method if you want to extract the trace context
        /// information from Google's own header for your own code to use, or if you are not using the tracing
        /// component of this library but are using the logging component and want the trace context information
        /// to be associated with the log entries.
        /// </summary>
        public static IServiceCollection TryAddGoogleTraceContextProvider(this IServiceCollection services)
        {
            // We use TryAdd... here to allow user code to inject their own trace context provider
            // and matching trace context response propagator. We use Google trace header otherwise.
            services.TryAddScoped<ITraceContext>(ProvideGoogleTraceHeaderContext);
            return services;
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
