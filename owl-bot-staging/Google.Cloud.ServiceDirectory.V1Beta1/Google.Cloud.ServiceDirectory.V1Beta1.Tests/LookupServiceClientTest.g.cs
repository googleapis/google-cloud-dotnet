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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ServiceDirectory.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLookupServiceClientTest
    {
        [xunit::FactAttribute]
        public void ResolveServiceRequestObject()
        {
            moq::Mock<LookupService.LookupServiceClient> mockGrpcClient = new moq::Mock<LookupService.LookupServiceClient>(moq::MockBehavior.Strict);
            ResolveServiceRequest request = new ResolveServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                MaxEndpoints = 1499755084,
                EndpointFilter = "endpoint_filter76fda152",
            };
            ResolveServiceResponse expectedResponse = new ResolveServiceResponse
            {
                Service = new Service(),
            };
            mockGrpcClient.Setup(x => x.ResolveService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LookupServiceClient client = new LookupServiceClientImpl(mockGrpcClient.Object, null);
            ResolveServiceResponse response = client.ResolveService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResolveServiceRequestObjectAsync()
        {
            moq::Mock<LookupService.LookupServiceClient> mockGrpcClient = new moq::Mock<LookupService.LookupServiceClient>(moq::MockBehavior.Strict);
            ResolveServiceRequest request = new ResolveServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                MaxEndpoints = 1499755084,
                EndpointFilter = "endpoint_filter76fda152",
            };
            ResolveServiceResponse expectedResponse = new ResolveServiceResponse
            {
                Service = new Service(),
            };
            mockGrpcClient.Setup(x => x.ResolveServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ResolveServiceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LookupServiceClient client = new LookupServiceClientImpl(mockGrpcClient.Object, null);
            ResolveServiceResponse responseCallSettings = await client.ResolveServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ResolveServiceResponse responseCancellationToken = await client.ResolveServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
