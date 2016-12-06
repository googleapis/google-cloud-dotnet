// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Cloud.Trace.V1;
using System;
using System.Threading.Tasks;
using System.Web;

using CloudTrace = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    ///  Google Trace for ASP.NET Applications.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    ///  public class Global : HttpApplication
    ///  { 
    ///       void Application_Start(object sender, EventArgs e)
    ///       {
    ///           Trace.Initialize("some-project-id", this);
    ///       }
    ///  }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void DoSomething()
    /// {
    ///     Trace.GetCurrentTracer().StartSpan("DoSomething");
    ///     ...
    ///     Trace.GetCurrentTracer().EndSpan();
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Handles tracing for ASP.NET applications and sends data to the Stackdriver Trace API Reporting.
    /// 
    /// By default when initialized a small sampling of http requests will automatically be traced.  Additional
    /// trace data can be collected manually.
    /// 
    /// Docs: https://cloud.google.com/trace/docs/
    /// </remarks>
    public sealed class Trace
    {
        private readonly string _projectId;
        private readonly TraceIdFactory _traceIdfactory;
        private readonly BufferingTraceConsumer _bufferingConsumer;
        private readonly RateLimitingTraceOptionsFactory _rateFactory;
        private readonly TraceHeaderTraceOptionsFactory _headerFactory;

        private Trace(string projectId, TraceConfiguration config = null, Task<TraceServiceClient> client = null)
        {
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));

            // Create the default values if not set.
            client = client ?? TraceServiceClient.CreateAsync();
            config = config ?? TraceConfiguration.Create();

            _traceIdfactory = TraceIdFactory.Create();
            _bufferingConsumer = BufferingTraceConsumer.Create(new GrpcTraceConsumer(client));
            _rateFactory = RateLimitingTraceOptionsFactory.Create(config);
            _headerFactory = TraceHeaderTraceOptionsFactory.Create();
        }

        /// <summary>
        /// Initialize tracing for this application.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="application">The Http application.</param>
        /// <param name="config">Optional trace configuration, if unset the default will be used.</param>
        /// <param name="client">Optional trace client, if unset the default will be used.</param>
        public static void Initialize(string projectId, HttpApplication application, TraceConfiguration config = null, Task<TraceServiceClient> client = null)
        {
            GaxPreconditions.CheckNotNull(application, nameof(application));
            Trace trace = new Trace(projectId, config, client);

            // Add event handlers to the application.
            application.BeginRequest += trace.BeginRequest;
            application.EndRequest += trace.EndRequest;
        }

        /// <summary>
        /// Gets the current <see cref="IManagedTracer"/> for the given request.
        /// </summary>
        public static IManagedTracer GetCurrentTracer()
        {
            return TracerManager.GetCurrentTracer() ?? DoNothingTracer.Instance;
        }

        private void BeginRequest(object sender, EventArgs e)
        {
            TraceHeaderContext headerContext = TraceHeaderContext.FromRequest(HttpContext.Current.Request);
            TraceOptions headerOptions = _headerFactory.CreateOptions(headerContext);

            // If the trace header says to trace or if the rate limiter allows tracing continue.
            if (!headerOptions.ShouldTrace)
            {
                TraceOptions options = _rateFactory.CreateOptions();
                if (!options.ShouldTrace)
                {
                    return;
                }
            }

            // Create and set the tracer for the request.
            CloudTrace trace = new CloudTrace
            {
                ProjectId = _projectId,
                TraceId = headerContext.TraceId ?? _traceIdfactory.NextId(),
            };
            IManagedTracer tracer = SimpleManagedTracer.Create(_bufferingConsumer, trace, headerContext.SpanId);
            TracerManager.SetCurrentTracer(tracer);

            // Start the span and annotate it with information from the current request.
            tracer.StartSpan(HttpContext.Current.Request.Path);
            tracer.AnnotateSpan(Labels.FromHttpRequest(HttpContext.Current.Request));
        }

        private void EndRequest(object sender, EventArgs e)
        { 
            IManagedTracer tracer = TracerManager.GetCurrentTracer();
            if (tracer == null)
            {
                return;
            }
            // End the span and annotate it with information from the current response.
            tracer.AnnotateSpan(Labels.FromHttpResponse(HttpContext.Current.Response));
            tracer.EndSpan();
        }
    }
}