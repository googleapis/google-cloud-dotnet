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

namespace Google.Cloud.Diagnostics.AspNetCore.Trace
{
    public static class CloudTraceExtension
    {
        public static void UseCloudTrace(this IApplicationBuilder app)
        {
            app.UseMiddleware<CloudTraceMiddleware>();
        }

        public static void AddCloudTrace(
            this IServiceCollection services, string projectId,
            TraceConfiguration config = null, Task<TraceServiceClient> clientTask = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));

            clientTask = clientTask ?? TraceServiceClient.CreateAsync();
            config = config ?? TraceConfiguration.Create();

            IConsumer<TraceProto> consumer = ConsumerFactory<TraceProto>.GetConsumer(
                new GrpcTraceConsumer(clientTask), TraceSizer.Instance, config.BufferOptions);

            services.AddSingleton(new ProjectId(projectId));
            services.AddSingleton(consumer);
            services.AddSingleton(TraceIdFactory.Create());
            services.AddSingleton(RateLimitingTraceOptionsFactory.Create(config));

            services.AddScoped(GetTraceHeaderContext);
            services.AddScoped<IManagedTracer>();
        }


        internal static TraceHeaderContext GetTraceHeaderContext(IServiceProvider provider)
        {
            HttpContext context = provider.GetService<HttpContext>();
            string headerString = context.Request.Headers[TraceHeaderContext.TraceHeader];
            return TraceHeaderContext.FromHeader(headerString);
        }


        internal static IManagedTracer GetManagedTracer(IServiceProvider provider)
        {
            var headerContext = provider.GetService<TraceHeaderContext>();
            if (!headerContext.ShouldTrace)
            {
                var rateLimitingFactory = provider.GetService<RateLimitingTraceOptionsFactory>();
                TraceOptions options = rateLimitingFactory.CreateOptions();
                if (!options.ShouldTrace)
                {
                    return DoNothingTracer.Instance;
                }
            }

            ProjectId projectId = provider.GetService<ProjectId>();
            TraceIdFactory traceIdFactory = provider.GetService<TraceIdFactory>();
            IConsumer<TraceProto> consumer = provider.GetService<IConsumer<TraceProto>>();

            TraceProto trace = new TraceProto
            {
                ProjectId = projectId.Id,
                TraceId = headerContext.TraceId ?? traceIdFactory.NextId(),
            };
            return SimpleManagedTracer.Create(consumer, trace, headerContext.SpanId);
        }
    }

    internal class ProjectId
    {
        internal string Id { get; }

        public ProjectId(string id)
        {
            id = GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id));
        }
    }
}
