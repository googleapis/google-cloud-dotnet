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

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A factory that will generate <see cref="IManagedTracer"/>s from 
    /// <see cref="TraceHeaderContext"/>s.  If the <see cref="TraceHeaderContext"/> does not provide
    /// the needed context to determine the proper <see cref="IManagedTracer"/> then the given
    /// <see cref="ITraceOptionsFactory"/> will decide.
    /// </summary>
    internal class ManagedTracerFactory : IManagedTracerFactory
    {
        private readonly string _projectId;
        private readonly IConsumer<TraceProto> _consumer;
        private readonly ITraceOptionsFactory _optionsFactory;
        private readonly TraceIdFactory _traceIdFactory;

        /// <summary>
        /// Creates a new <see cref="ManagedTracerFactory"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="consumer">A trace consumer for the tracer. Cannot be null.</param>
        /// <param name="optionsFactory">An options factory to fall back to if the 
        ///     <see cref="TraceHeaderContext"/> does not provide enough context. Cannot be null.</param>
        /// <param name="traceIdFactory">A trace Id factory. Cannot be null.</param>
        internal ManagedTracerFactory(
            string projectId,
            IConsumer<TraceProto> consumer,
            ITraceOptionsFactory optionsFactory,
            TraceIdFactory traceIdFactory
            )
        {
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _optionsFactory = GaxPreconditions.CheckNotNull(optionsFactory, nameof(optionsFactory));
            _traceIdFactory = GaxPreconditions.CheckNotNull(traceIdFactory, nameof(traceIdFactory));
        }

        /// <inheritdoc />
        public IManagedTracer CreateTracer(TraceHeaderContext headerContext)
        {
            GaxPreconditions.CheckNotNull(headerContext, nameof(headerContext));
            if (!ShouldTrace(headerContext))
            {
                return NullManagedTracer.Instance;
            }
            var traceId = headerContext.TraceId ?? _traceIdFactory.NextId();
            return SimpleManagedTracer.Create(_consumer, _projectId, traceId,  headerContext.SpanId);
        }

        /// <summary>
        /// True if the tracing should occur. Decision based on a <see cref="TraceHeaderContext"/>
        /// and an <see cref="ITraceOptionsFactory"/>.
        /// </summary>
        internal bool ShouldTrace(TraceHeaderContext headerContext) => 
            headerContext.ShouldTrace ?? _optionsFactory.CreateOptions().ShouldTrace;
    }
}
