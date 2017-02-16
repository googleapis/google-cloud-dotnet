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
        private const string ServiceErrorMessageTemplate = 
            "No {0} service found. Ensure Google Cloud Trace is properly set up.";

        /// <summary>
        /// Class used to allow dependency injection of a project id.
        /// </summary>
        internal class ProjectId
         {
             public string Id;
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
        /// <param name="clientTask">Optional task which produces the Trace client, if 
        ///     unset the default will be used.</param>
        public static void AddGoogleTrace(
            this IServiceCollection services, string projectId,
            TraceConfiguration config = null, Task<TraceServiceClient> clientTask = null)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));

            clientTask = clientTask ?? TraceServiceClient.CreateAsync();
            config = config ?? TraceConfiguration.Create();

            var consumer = ConsumerFactory<TraceProto>.GetConsumer(
                 new GrpcTraceConsumer(clientTask), MessageSizer<TraceProto>.GetSize, config.BufferOptions);

            services.AddSingleton(new ProjectId { Id = projectId });
            services.AddSingleton(config);
            services.AddSingleton(consumer);
            services.AddSingleton(CreateManagedTracerFactory);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(CreateTraceHeaderContext);
            services.AddScoped(CreateManagedTracer);
        }

        /// <summary>
        /// Creates an <see cref="IManagedTracer"/> from an <see cref="ProjectId"/>, 
        /// <see cref="TraceConfiguration"/> and <see cref="IConsumer{TraceProto}"/>.
        /// </summary>
        internal static IManagedTracerFactory CreateManagedTracerFactory(IServiceProvider provider)
        {
            var projectId = provider.GetService<ProjectId>();
            var config = provider.GetService<TraceConfiguration>();
            var consumer = provider.GetService<IConsumer<TraceProto>>();

            GaxPreconditions.CheckState(projectId != null,
                string.Format(ServiceErrorMessageTemplate, typeof(ProjectId).GetType()));
            GaxPreconditions.CheckState(config != null,
                string.Format(ServiceErrorMessageTemplate, typeof(TraceConfiguration).GetType()));
            GaxPreconditions.CheckState(consumer != null,
                string.Format(ServiceErrorMessageTemplate, typeof(IConsumer<TraceProto>).GetType()));

            return new ManagedTracerFactory(projectId.Id, consumer,
                RateLimitingTraceOptionsFactory.Create(config), TraceIdFactory.Create());
        }

        /// <summary>
        /// Creates an <see cref="TraceHeaderContext"/> based on the current <see cref="HttpContext"/>.
        /// </summary>
        internal static TraceHeaderContext CreateTraceHeaderContext(IServiceProvider provider)
        {
            var accessor = provider.GetService<IHttpContextAccessor>();
            string header = accessor?.HttpContext?.Request?.Headers[TraceHeaderContext.TraceHeader];
            return TraceHeaderContext.FromHeader(header);
        }

        /// <summary>
        /// Creates a <see cref="IManagedTracer"/> based on the <see cref="TraceHeaderContext"/> and
        /// the rate limiter.
        /// </summary>
        internal static IManagedTracer CreateManagedTracer(IServiceProvider provider)
        {
            var headerContext = provider.GetService<TraceHeaderContext>();
            var tracerFactory = provider.GetService<IManagedTracerFactory>();

            GaxPreconditions.CheckState(headerContext != null, 
                string.Format(ServiceErrorMessageTemplate, typeof(TraceHeaderContext).GetType()));
            GaxPreconditions.CheckState(tracerFactory != null,
                string.Format(ServiceErrorMessageTemplate, typeof(IManagedTracerFactory).GetType()));

            return tracerFactory.CreateTracer(headerContext);
        }
    }
}
