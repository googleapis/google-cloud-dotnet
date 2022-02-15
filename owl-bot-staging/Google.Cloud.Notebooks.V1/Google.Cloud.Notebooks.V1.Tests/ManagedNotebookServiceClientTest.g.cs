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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Notebooks.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedManagedNotebookServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetRuntimeRequestObject()
        {
            moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient> mockGrpcClient = new moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            Runtime expectedResponse = new Runtime
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VirtualMachine = new VirtualMachine(),
                State = Runtime.Types.State.Active,
                HealthState = Runtime.Types.HealthState.Healthy,
                AccessConfig = new RuntimeAccessConfig(),
                SoftwareConfig = new RuntimeSoftwareConfig(),
                Metrics = new RuntimeMetrics(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetRuntime(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedNotebookServiceClient client = new ManagedNotebookServiceClientImpl(mockGrpcClient.Object, null);
            Runtime response = client.GetRuntime(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuntimeRequestObjectAsync()
        {
            moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient> mockGrpcClient = new moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            Runtime expectedResponse = new Runtime
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VirtualMachine = new VirtualMachine(),
                State = Runtime.Types.State.Active,
                HealthState = Runtime.Types.HealthState.Healthy,
                AccessConfig = new RuntimeAccessConfig(),
                SoftwareConfig = new RuntimeSoftwareConfig(),
                Metrics = new RuntimeMetrics(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetRuntimeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Runtime>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedNotebookServiceClient client = new ManagedNotebookServiceClientImpl(mockGrpcClient.Object, null);
            Runtime responseCallSettings = await client.GetRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Runtime responseCancellationToken = await client.GetRuntimeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuntime()
        {
            moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient> mockGrpcClient = new moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            Runtime expectedResponse = new Runtime
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VirtualMachine = new VirtualMachine(),
                State = Runtime.Types.State.Active,
                HealthState = Runtime.Types.HealthState.Healthy,
                AccessConfig = new RuntimeAccessConfig(),
                SoftwareConfig = new RuntimeSoftwareConfig(),
                Metrics = new RuntimeMetrics(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetRuntime(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedNotebookServiceClient client = new ManagedNotebookServiceClientImpl(mockGrpcClient.Object, null);
            Runtime response = client.GetRuntime(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuntimeAsync()
        {
            moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient> mockGrpcClient = new moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            Runtime expectedResponse = new Runtime
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VirtualMachine = new VirtualMachine(),
                State = Runtime.Types.State.Active,
                HealthState = Runtime.Types.HealthState.Healthy,
                AccessConfig = new RuntimeAccessConfig(),
                SoftwareConfig = new RuntimeSoftwareConfig(),
                Metrics = new RuntimeMetrics(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetRuntimeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Runtime>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedNotebookServiceClient client = new ManagedNotebookServiceClientImpl(mockGrpcClient.Object, null);
            Runtime responseCallSettings = await client.GetRuntimeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Runtime responseCancellationToken = await client.GetRuntimeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuntimeResourceNames()
        {
            moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient> mockGrpcClient = new moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            Runtime expectedResponse = new Runtime
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VirtualMachine = new VirtualMachine(),
                State = Runtime.Types.State.Active,
                HealthState = Runtime.Types.HealthState.Healthy,
                AccessConfig = new RuntimeAccessConfig(),
                SoftwareConfig = new RuntimeSoftwareConfig(),
                Metrics = new RuntimeMetrics(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetRuntime(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedNotebookServiceClient client = new ManagedNotebookServiceClientImpl(mockGrpcClient.Object, null);
            Runtime response = client.GetRuntime(request.RuntimeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuntimeResourceNamesAsync()
        {
            moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient> mockGrpcClient = new moq::Mock<ManagedNotebookService.ManagedNotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            Runtime expectedResponse = new Runtime
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VirtualMachine = new VirtualMachine(),
                State = Runtime.Types.State.Active,
                HealthState = Runtime.Types.HealthState.Healthy,
                AccessConfig = new RuntimeAccessConfig(),
                SoftwareConfig = new RuntimeSoftwareConfig(),
                Metrics = new RuntimeMetrics(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetRuntimeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Runtime>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedNotebookServiceClient client = new ManagedNotebookServiceClientImpl(mockGrpcClient.Object, null);
            Runtime responseCallSettings = await client.GetRuntimeAsync(request.RuntimeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Runtime responseCancellationToken = await client.GetRuntimeAsync(request.RuntimeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
