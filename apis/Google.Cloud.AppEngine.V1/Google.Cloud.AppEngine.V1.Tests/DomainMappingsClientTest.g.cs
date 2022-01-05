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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AppEngine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDomainMappingsClientTest
    {
        [xunit::FactAttribute]
        public void GetDomainMappingRequestObject()
        {
            moq::Mock<DomainMappings.DomainMappingsClient> mockGrpcClient = new moq::Mock<DomainMappings.DomainMappingsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainMappingRequest request = new GetDomainMappingRequest
            {
                Name = "name1c9368b0",
            };
            DomainMapping expectedResponse = new DomainMapping
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                SslSettings = new SslSettings(),
                ResourceRecords =
                {
                    new ResourceRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDomainMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainMappingsClient client = new DomainMappingsClientImpl(mockGrpcClient.Object, null);
            DomainMapping response = client.GetDomainMapping(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDomainMappingRequestObjectAsync()
        {
            moq::Mock<DomainMappings.DomainMappingsClient> mockGrpcClient = new moq::Mock<DomainMappings.DomainMappingsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainMappingRequest request = new GetDomainMappingRequest
            {
                Name = "name1c9368b0",
            };
            DomainMapping expectedResponse = new DomainMapping
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                SslSettings = new SslSettings(),
                ResourceRecords =
                {
                    new ResourceRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDomainMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DomainMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainMappingsClient client = new DomainMappingsClientImpl(mockGrpcClient.Object, null);
            DomainMapping responseCallSettings = await client.GetDomainMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DomainMapping responseCancellationToken = await client.GetDomainMappingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
