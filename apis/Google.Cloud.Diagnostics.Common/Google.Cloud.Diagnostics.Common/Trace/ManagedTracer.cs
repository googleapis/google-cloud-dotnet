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
using Google.Cloud.Trace.V1;
using System;
using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Functions to create <see cref="IManagedTracer"/>s.
    /// </summary>
    public static class ManagedTracer
    {
        /// <summary>
        /// Creates a trace consumer for a <see cref="TraceServiceClient"/> and options.
        /// </summary>
        /// <param name="client">The trace client. Must not be null.</param>
        /// <param name="options">Trace options. Must not be null.</param>
        public static IConsumer<TraceProto> CreateConsumer(TraceServiceClient client, TraceOptions options)
        {
            GaxPreconditions.CheckNotNull(client, nameof(client));
            GaxPreconditions.CheckNotNull(options, nameof(options));

            return ConsumerFactory<TraceProto>.GetConsumer(
                 new GrpcTraceConsumer(client), MessageSizer<TraceProto>.GetSize,
                 options.BufferOptions, options.RetryOptions);
        }

        /// <summary>
        /// Create a factory to generate an <see cref="IManagedTracer"/> from an <see cref="ITraceContext"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Must not be null</param>
        /// <param name="consumer">The trace consumer.  Must not be null.</param>
        /// <param name="options">Trace options. Must not be null.</param>
        public static Func<ITraceContext, IManagedTracer> CreateFactory(string projectId, IConsumer<TraceProto> consumer, TraceOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            GaxPreconditions.CheckNotNull(options, nameof(options));

            var factory = new ManagedTracerFactory(projectId, consumer,
                RateLimitingTraceOptionsFactory.Create(options), TraceIdFactory.Create());
            return factory.CreateTracer;
        }

        /// <summary>
        /// Creates an <see cref="IManagedTracer"/> that delegates all calls to another <see cref="IManagedTracer"/>
        /// that is retrieved from the given function on each method call.
        /// </summary>
        public static IManagedTracer CreateDelegatingTracer(Func<IManagedTracer> tracerFactory) 
            => new DelegatingTracer(GaxPreconditions.CheckNotNull(tracerFactory, nameof(tracerFactory)));
    }
}
