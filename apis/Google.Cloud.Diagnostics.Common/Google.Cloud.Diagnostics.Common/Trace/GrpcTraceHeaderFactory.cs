// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;

namespace Google.Cloud.Diagnostics.Common.Trace
{
    /// <summary>
    /// Factory for obtaining the proper gRPC headers that
    /// propagate a trace to outgoing gRPC requests.
    /// </summary>
    public class GrpcTraceHeaderFactory
    {
        private const byte SupportedVersion = 0;

        private const byte TraceIdFieldId = 0;
        private const short TraceIdSize = 16;

        private const byte SpanIdFieldId = 1;
        private const short SpanIdSize = 8;

        private const byte TraceOptionsFieldId = 2;
        private static readonly byte[] TraceOptions = new byte[] { 1 };

        private const string MetadataEntryKey = "grpc-trace-bin";

        private readonly Func<IManagedTracer> _managedTracerFactory;

        /// <summary>
        /// Creates a new instance using the given delegate to obtain the "current" tracer.
        /// </summary>
        /// <param name="managedTracerFactory">A delegate used to obtain the "current" tracer
        /// for each request. The delegate should therefore be thread-safe.</param>
        public GrpcTraceHeaderFactory(Func<IManagedTracer> managedTracerFactory)
        {
            _managedTracerFactory = GaxPreconditions.CheckNotNull(managedTracerFactory, nameof(managedTracerFactory));
        }

        /// <summary>
        /// Starts a <see cref="ISpan"/> with the correct name and kind for gRPC trace propagation.
        /// The span name will be of the form <code>packageName.serviceName/methodName</code>
        /// and the span kind will be of the form <see cref="SpanKind.RpcClient"/>.
        /// This method should be called before any gRPC call that will contain trace propagation
        /// headers.
        /// </summary>
        /// <param name="packageName">The name of the gRPC package.</param>
        /// <param name="serviceName">The name of the gRPC service.</param>
        /// <param name="methodName">The name of the gRPC method</param>
        /// <returns>An <see cref="ISpan"/> appropiate for gRPC trace propagation.</returns>
        public ISpan GetSpanForPropagation(string packageName, string serviceName, string methodName)
        {
            var tracer = _managedTracerFactory();
            return tracer.StartSpan(
                $"{packageName}.{serviceName}/{methodName}", StartSpanOptions.Create(SpanKind.RpcClient));
        }

        /// <summary>
        /// Builds the <see cref="CallSettings"/> to use in a gRPC call so that
        /// trace is propagated.
        /// <see cref="GetSpanForPropagation(string, string, string)"/> needs to be called
        /// before the gRPC call that used these <see cref="CallSettings"/>.
        /// </summary>
        public CallSettings GetCallSettingsForPropagation()
        {
            return CallSettings.FromHeaderMutation(GetHeaderMutationForPropagation());
        }

        /// <summary>
        /// Returns the header mutation action that will change gRPC headers so
        /// that trace is propagated to the gRPC request.
        /// </summary>
        public Action<Metadata> GetHeaderMutationForPropagation()
        {
            return metadata => metadata.Add(GetGrpcHeader());
        }

        /// <summary>
        /// Builds a <see cref="Metadata.Entry"/>, that is a gRPC header, for trace propagation.
        /// The header is built based on the tracer returned by the managed tracer factory with
        /// which this instance was built, <see cref="GrpcTraceHeaderFactory"/>.
        /// A trace and a span must have been started when this method is called. The span started
        /// should have a specific name and be of <see cref="SpanKind.RpcClient"/>. Calling
        /// <see cref="GetSpanForPropagation(string, string, string)"/> will start and return 
        /// a span with the correct name and kind.
        /// </summary>
        /// <returns>A <see cref="Metadata.Entry"/> that will propagate the trace to a gRPC request.</returns>
        public Metadata.Entry GetGrpcHeader()
        {
            var tracer = _managedTracerFactory();
            var traceId = tracer.GetCurrentTraceId();
            var spanId = tracer.GetCurrentSpanId();

            if(traceId == null || !spanId.HasValue)
            {
                throw new InvalidOperationException("A trace and a span need to be created before atempting to set gRPC trace progagation headers.");
            }

            // The Opencesus format is as follows
            // <one-byte-version>[<one-byte-field-id><field-value>]+?
            // The extra +4 stands for the version byte and each of the bytes for the 3 field IDs.
            byte[] entryValue = new byte[TraceIdSize + SpanIdSize + TraceOptions.Length + 4];

            entryValue[0] = SupportedVersion;

            SetTraceId(entryValue, traceId, 1);
            SetSpanId(entryValue, spanId.Value, 2 + TraceIdSize);
            SetOptions(entryValue, 3 + TraceIdSize + SpanIdSize);

            return new Metadata.Entry(MetadataEntryKey, entryValue);
        }

        /// <summary>
        /// Created a <see cref="GrpcTraceHeaderFactory"/> from the given tracer.
        /// </summary>
        public static GrpcTraceHeaderFactory FromTracer(IManagedTracer tracer)
        {
            GaxPreconditions.CheckNotNull(tracer, nameof(tracer));
            return new GrpcTraceHeaderFactory(() => tracer);
        }

        private void SetTraceId(byte[] output, string traceId, int offset)
        {
            output[offset] = TraceIdFieldId;
            if (!Guid.TryParse(traceId, out Guid traceIdGuid))
            {
                throw new InvalidOperationException("The trace ID is not a GUID.");
            }
            var traceIdBytes = traceIdGuid.ToByteArray();
            if (traceIdBytes.Length != TraceIdSize)
            {
                throw new InvalidOperationException($"Unexpected size for byte representation of trace ID. Expected: {TraceIdSize}, Actual: {traceIdBytes.Length}");
            }

            Array.Copy(traceIdBytes, 0, output, offset + 1, TraceIdSize);
        }

        private void SetSpanId(byte[] output, ulong spanId, int offset)
        {
            output[offset] = SpanIdFieldId;
            
            var spanIdBytes = BitConverter.GetBytes(spanId);
            if (spanIdBytes.Length != SpanIdSize)
            {
                throw new InvalidOperationException($"Unexpected size for byte representation of span ID. Expected: {SpanIdSize}, Actual: {spanIdBytes.Length}");
            }

            Array.Copy(spanIdBytes, 0, output, offset + 1, SpanIdSize);
        }

        private void SetOptions(byte[] output, int offset)
        {
            output[offset] = TraceOptionsFieldId;
            Array.Copy(TraceOptions, 0, output, offset + 1, TraceOptions.Length);
        }
    }
}
