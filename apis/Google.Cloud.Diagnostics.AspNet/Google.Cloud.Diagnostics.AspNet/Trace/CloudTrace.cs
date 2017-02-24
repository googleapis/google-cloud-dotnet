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
using System.Threading.Tasks;
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
    ///           CloudTrace.Initialize("some-project-id", this);
    ///       }
    ///  }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void MakeHttpRequest()
    /// {
    ///     var traceHeaderHandler = TraceHeaderPropagatingHandler.Create();
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
    ///     CloudTrace.GetCurrentTracer().StartSpan("DoSomething");
    ///     ...
    ///     CloudTrace.GetCurrentTracer().EndSpan();
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

        /// <summary>Gets the current <see cref="IManagedTracer"/> for the given request.</summary>
        public static IManagedTracer CurrentTracer =>
            TracerManager.GetCurrentTracer() ?? DoNothingTracer.Instance;

        private CloudTrace(string projectId, TraceConfiguration config = null, Task<TraceServiceClient> client = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));

            // Create the default values if not set.
            client = client ?? TraceServiceClient.CreateAsync();
            config = config ?? TraceConfiguration.Create();

            _consumer = ConsumerFactory<TraceProto>.GetConsumer(
                new GrpcTraceConsumer(client), MessageSizer<TraceProto>.GetSize, config.BufferOptions);

            _tracerFactory = new ManagedTracerFactory(projectId, _consumer,
                RateLimitingTraceOptionsFactory.Create(config), TraceIdFactory.Create());
        }

        /// <summary>
        /// Initialize tracing for this application.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="application">The Http application.</param>
        /// <param name="config">Optional trace configuration, if unset the default will be used.</param>
        /// <param name="client">Optional trace client, if unset the default will be used.</param>
        /// <returns>The initialized instance of <see cref="CloudTrace"/> the caller is responsible for disposal.</returns>
        public static void Initialize(string projectId, HttpApplication application, TraceConfiguration config = null, Task<TraceServiceClient> client = null)
        {
            GaxPreconditions.CheckNotNull(application, nameof(application));
            CloudTrace trace = new CloudTrace(projectId, config, client);

            // Add event handlers to the application.
            application.BeginRequest += trace.BeginRequest;
            application.EndRequest += trace.EndRequest;
            application.Disposed += trace.Disposed;
        }

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();

        private void Disposed(object sender, EventArgs e) => Dispose();

        private void BeginRequest(object sender, EventArgs e)
        {
            var headerContext = TraceHeaderContextUtils.CreateContext(HttpContext.Current.Request);
            var tracer = _tracerFactory.CreateTracer(headerContext);
            if (tracer.GetCurrentTraceId() == null)
            {
                return;
            }

            TracerManager.SetCurrentTracer(tracer);

            // Start the span and annotate it with information from the current request.
            tracer.StartSpan(HttpContext.Current.Request.Path);
            tracer.AnnotateSpan(Labels.FromHttpRequest(HttpContext.Current.Request));
            tracer.AnnotateSpan(Labels.AgentLabel);
        }

        private void EndRequest(object sender, EventArgs e)
        {
            IManagedTracer tracer = CurrentTracer;
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