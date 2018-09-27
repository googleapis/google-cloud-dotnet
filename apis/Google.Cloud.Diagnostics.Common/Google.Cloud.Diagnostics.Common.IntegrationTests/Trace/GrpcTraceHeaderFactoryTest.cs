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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common.Trace;
using Google.Cloud.Spanner.Admin.Instance.V1;
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;
using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests.Trace
{
    public class GrpcTraceHeaderFactoryTest : IDisposable
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();
        private static readonly TraceEntryPolling _polling = new TraceEntryPolling();

        private readonly string _testId;

        private readonly IConsumer<TraceProto> _consumer;
        private readonly IManagedTracer _tracer;

        private readonly Timestamp _startTime;

        public GrpcTraceHeaderFactoryTest()
        {
            _testId = IdGenerator.FromDateTime();

            _consumer = new GrpcTraceConsumer(TraceServiceClient.Create());
            _tracer = SimpleManagedTracer.Create(_consumer, TestEnvironment.GetTestProjectId(), _traceIdFactory.NextId(), null);

            _startTime = Timestamp.FromDateTime(DateTime.UtcNow);
        }

        [Fact]
        public void TraceOutgoing()
        {
            var spanName = EntryData.GetMessage(nameof(TraceOutgoing), _testId);
            var packageName = "google.spanner.admin.instance.v1";
            var serviceName = "InstanceAdmin";
            var methodName = "ListInstances";

            var propagationFactory = GrpcTraceHeaderFactory.FromTracer(_tracer);
            var grpcClient = InstanceAdminClient.Create(
                settings: new InstanceAdminSettings
                {
                    CallSettings = propagationFactory.GetCallSettingsForPropagation()
                });

            using (_tracer.StartSpan(spanName))
            {
                using (propagationFactory.GetSpanForPropagation(packageName, serviceName, methodName))
                {
                    var response = grpcClient.ListInstances(new ProjectName(TestEnvironment.GetTestProjectId()));
                }
            }

            var trace = _polling.GetTrace(spanName, _startTime);
            TraceEntryVerifiers.AssertParentChildSpan(trace, spanName, $"{packageName}.{serviceName}/{methodName}");
        }

        public void Dispose()
        {
            _consumer.Dispose();
        }
    }
}
