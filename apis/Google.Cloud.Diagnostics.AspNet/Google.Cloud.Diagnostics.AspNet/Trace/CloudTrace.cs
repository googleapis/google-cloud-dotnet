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
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Trace.V1;
using System;
using System.Web;

using TraceProto = Google.Cloud.Trace.V1.Trace;

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
    ///       public override void Init()
    ///       {
    ///           base.Init();
    ///           CloudTrace.Initialize(this, "some-project-id");
    ///       }
    ///  }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void MakeHttpRequest()
    /// {
    ///     var traceHeaderHandler = CloudTrace.CreateTracingHttpMessageHandler();
    ///     using (var httpClient = HttpClientFactory.Create(traceHeaderHandler))
    ///     {
    ///         ...
    ///     }
    /// }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void DoSomething()
    /// {
    ///     CloudTrace.Tracer.StartSpan("DoSomething");
    ///     ...
    ///     CloudTrace.Tracer.EndSpan();
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
    public sealed class CloudTrace : IDisposable
    {
        private readonly IManagedTracerFactory _tracerFactory;

        private readonly IConsumer<TraceProto> _consumer;

        private readonly TraceDecisionPredicate _traceFallbackPredicate;

        /// <summary>
        /// Gets the <see cref="IManagedTracer"/> for tracing. It can be used
        /// for creating spans for a trace as well as adding meta data to them.
        /// This <see cref="IManagedTracer"/> is a singleton.
        /// </summary>
        public static readonly IManagedTracer Tracer =
            new DelegatingTracer(() => TracerManager.GetCurrentTracer() ?? NullManagedTracer.Instance);

        /// <summary>
        /// Creates a <see cref="TraceHeaderPropagatingHandler"/> to propagate trace headers
        /// in Http requests.
        /// <example>
        /// <code>
        /// public void DoSomething()
        /// {
        ///     var traceHeaderHandler = CloudTrace.CreateTracingHttpMessageHandler();
        ///     using (var httpClient = new HttpClient(traceHeaderHandler))
        ///     {
        ///         ...
        ///     }
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public static TraceHeaderPropagatingHandler CreateTracingHttpMessageHandler() =>
            new TraceHeaderPropagatingHandler(() => Tracer);

        private CloudTrace(string projectId, TraceConfiguration config = null, TraceServiceClient client = null,
            TraceDecisionPredicate traceFallbackPredicate = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));

            // Create the default values if not set.
            client = client ?? TraceServiceClient.Create();
            config = config ?? TraceConfiguration.Create(); 
            _traceFallbackPredicate = traceFallbackPredicate ?? TraceDecisionPredicate.Default;

            _consumer = ConsumerFactory<TraceProto>.GetConsumer(
                new GrpcTraceConsumer(client), MessageSizer<TraceProto>.GetSize, config.BufferOptions);

            _tracerFactory = new ManagedTracerFactory(projectId, _consumer,
                RateLimitingTraceOptionsFactory.Create(config), TraceIdFactory.Create());
        }

        /// <summary>
        /// Initialize tracing for this application.
        /// </summary>
        /// <param name="application">The Http application.</param>
        /// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
        ///     The Google Cloud Platform project ID. If unspecified and running on GAE or GCE the project ID will be
        ///     detected from the platform.</param>
        /// <param name="config">Optional trace configuration, if unset the default will be used.</param>
        /// <param name="client">Optional trace client, if unset the default will be used.</param>
        /// <param name="traceFallbackPredicate">Optional function to trace requests. If the trace header is not set
        ///     then this function will be called to determine if a given request should be traced.  This will
        ///     not override trace headers.</param>
        public static void Initialize(HttpApplication application, string projectId = null,
            TraceConfiguration config = null, TraceServiceClient client = null,
            TraceDecisionPredicate traceFallbackPredicate = null)
        {
            GaxPreconditions.CheckNotNull(application, nameof(application));

            projectId = CommonUtils.GetAndCheckProjectId(projectId);
            CloudTrace trace = new CloudTrace(projectId, config, client, traceFallbackPredicate);

            // Add event handlers to the application.
            application.BeginRequest += trace.BeginRequest;
            application.EndRequest += trace.EndRequest;
            application.Disposed += (object sender, EventArgs e) => { trace.Dispose(); };
        }

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();

        private void BeginRequest(object sender, EventArgs e)
        {
            var request = HttpContext.Current.Request;
            string header = request.Headers.Get(TraceHeaderContext.TraceHeader);
            var headerContext = TraceHeaderContext.FromHeader(
                header, () => _traceFallbackPredicate?.ShouldTrace(request));

            var tracer = _tracerFactory.CreateTracer(headerContext);
            if (tracer.GetCurrentTraceId() == null)
            {
                return;
            }

            TracerManager.SetCurrentTracer(tracer);

            if (headerContext.TraceId != null)
            {
                // Set the updated trace header on the response.
                var updatedHeaderContext = TraceHeaderContext.Create(
                    tracer.GetCurrentTraceId(), tracer.GetCurrentSpanId() ?? 0, true);
                HttpContext.Current.Response.Headers.Set(
                    TraceHeaderContext.TraceHeader, updatedHeaderContext.ToString());
            }

            // Start the span and annotate it with information from the current request.
            tracer.StartSpan(HttpContext.Current.Request.Path);
            tracer.AnnotateSpan(Labels.FromHttpRequest(HttpContext.Current.Request));
            tracer.AnnotateSpan(Labels.AgentLabel);
        }

        private void EndRequest(object sender, EventArgs e)
        {
            IManagedTracer tracer = Tracer;
            if (tracer.GetCurrentTraceId() == null)
            {
                return;
            }
            // End the span and annotate it with information from the current response.
            tracer.AnnotateSpan(Labels.FromHttpResponse(HttpContext.Current.Response));
            tracer.EndSpan();
        }
    }
}