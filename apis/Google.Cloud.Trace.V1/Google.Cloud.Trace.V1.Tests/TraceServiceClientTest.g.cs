// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Trace.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTraceServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetTraceRequestObject()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
                Spans = { new TraceSpan(), },
            };
            mockGrpcClient.Setup(x => x.GetTrace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            Trace response = client.GetTrace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTraceRequestObjectAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
                Spans = { new TraceSpan(), },
            };
            mockGrpcClient.Setup(x => x.GetTraceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            Trace responseCallSettings = await client.GetTraceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trace responseCancellationToken = await client.GetTraceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrace()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
                Spans = { new TraceSpan(), },
            };
            mockGrpcClient.Setup(x => x.GetTrace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            Trace response = client.GetTrace(request.ProjectId, request.TraceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTraceAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
            };
            Trace expectedResponse = new Trace
            {
                ProjectId = "project_id43ad98b0",
                TraceId = "trace_id105c890f",
                Spans = { new TraceSpan(), },
            };
            mockGrpcClient.Setup(x => x.GetTraceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            Trace responseCallSettings = await client.GetTraceAsync(request.ProjectId, request.TraceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trace responseCancellationToken = await client.GetTraceAsync(request.ProjectId, request.TraceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchTracesRequestObject()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "project_id43ad98b0",
                Traces = new Traces(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PatchTraces(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            client.PatchTraces(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchTracesRequestObjectAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "project_id43ad98b0",
                Traces = new Traces(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PatchTracesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.PatchTracesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PatchTracesAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchTraces()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "project_id43ad98b0",
                Traces = new Traces(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PatchTraces(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            client.PatchTraces(request.ProjectId, request.Traces);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchTracesAsync()
        {
            moq::Mock<TraceService.TraceServiceClient> mockGrpcClient = new moq::Mock<TraceService.TraceServiceClient>(moq::MockBehavior.Strict);
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "project_id43ad98b0",
                Traces = new Traces(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PatchTracesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TraceServiceClient client = new TraceServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.PatchTracesAsync(request.ProjectId, request.Traces, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PatchTracesAsync(request.ProjectId, request.Traces, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
