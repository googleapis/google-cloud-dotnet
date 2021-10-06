// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUrlMapsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMap responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap response = client.Get(request.Project, request.UrlMap);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap responseCallSettings = await client.GetAsync(request.Project, request.UrlMap, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMap responseCancellationToken = await client.GetAsync(request.Project, request.UrlMap, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.Validate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse response = client.Validate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.ValidateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapsValidateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse responseCallSettings = await client.ValidateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapsValidateResponse responseCancellationToken = await client.ValidateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Validate()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.Validate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse response = client.Validate(request.Project, request.UrlMap, request.UrlMapsValidateRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.ValidateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapsValidateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse responseCallSettings = await client.ValidateAsync(request.Project, request.UrlMap, request.UrlMapsValidateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapsValidateResponse responseCancellationToken = await client.ValidateAsync(request.Project, request.UrlMap, request.UrlMapsValidateRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
