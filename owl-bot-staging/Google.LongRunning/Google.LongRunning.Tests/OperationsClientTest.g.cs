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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.LongRunning.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOperationsClientTest
    {
        [xunit::FactAttribute]
        public void GetOperationRequestObject()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Metadata = new wkt::Any(),
                Done = true,
                Error = new gr::Status(),
                Response = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.GetOperation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOperationRequestObjectAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Metadata = new wkt::Any(),
                Done = true,
                Error = new gr::Status(),
                Response = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.GetOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.GetOperationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOperation()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Metadata = new wkt::Any(),
                Done = true,
                Error = new gr::Status(),
                Response = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.GetOperation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOperationAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Metadata = new wkt::Any(),
                Done = true,
                Error = new gr::Status(),
                Response = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.GetOperationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.GetOperationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteOperationRequestObject()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            DeleteOperationRequest request = new DeleteOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            client.DeleteOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteOperationRequestObjectAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            DeleteOperationRequest request = new DeleteOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteOperationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteOperation()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            DeleteOperationRequest request = new DeleteOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            client.DeleteOperation(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteOperationAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            DeleteOperationRequest request = new DeleteOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOperationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteOperationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelOperationRequestObject()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            client.CancelOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelOperationRequestObjectAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            await client.CancelOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelOperationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelOperation()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            client.CancelOperation(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelOperationAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            await client.CancelOperationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelOperationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WaitOperationRequestObject()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            WaitOperationRequest request = new WaitOperationRequest
            {
                Name = "name1c9368b0",
                Timeout = new wkt::Duration(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Metadata = new wkt::Any(),
                Done = true,
                Error = new gr::Status(),
                Response = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.WaitOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.WaitOperation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WaitOperationRequestObjectAsync()
        {
            moq::Mock<Operations.OperationsClient> mockGrpcClient = new moq::Mock<Operations.OperationsClient>(moq::MockBehavior.Strict);
            WaitOperationRequest request = new WaitOperationRequest
            {
                Name = "name1c9368b0",
                Timeout = new wkt::Duration(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Metadata = new wkt::Any(),
                Done = true,
                Error = new gr::Status(),
                Response = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.WaitOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.WaitOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.WaitOperationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
