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

namespace Google.Identity.AccessContextManager.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccessContextManagerClientTest
    {
        [xunit::FactAttribute]
        public void GetAccessPolicyRequestObject()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            AccessPolicy expectedResponse = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "parent7858e4d0",
                Title = "title17dbd3d5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAccessPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessPolicy response = client.GetAccessPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessPolicyRequestObjectAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            AccessPolicy expectedResponse = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "parent7858e4d0",
                Title = "title17dbd3d5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAccessPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessPolicy responseCallSettings = await client.GetAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessPolicy responseCancellationToken = await client.GetAccessPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessPolicy()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            AccessPolicy expectedResponse = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "parent7858e4d0",
                Title = "title17dbd3d5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAccessPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessPolicy response = client.GetAccessPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessPolicyAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            AccessPolicy expectedResponse = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "parent7858e4d0",
                Title = "title17dbd3d5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAccessPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessPolicy responseCallSettings = await client.GetAccessPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessPolicy responseCancellationToken = await client.GetAccessPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessPolicyResourceNames()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            AccessPolicy expectedResponse = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "parent7858e4d0",
                Title = "title17dbd3d5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAccessPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessPolicy response = client.GetAccessPolicy(request.AccessPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessPolicyResourceNamesAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            AccessPolicy expectedResponse = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "parent7858e4d0",
                Title = "title17dbd3d5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAccessPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessPolicy responseCallSettings = await client.GetAccessPolicyAsync(request.AccessPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessPolicy responseCancellationToken = await client.GetAccessPolicyAsync(request.AccessPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessLevelRequestObject()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                AccessLevelFormat = LevelFormat.AsDefined,
            };
            AccessLevel expectedResponse = new AccessLevel
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Basic = new BasicLevel(),
                Custom = new CustomLevel(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAccessLevel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessLevel response = client.GetAccessLevel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessLevelRequestObjectAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                AccessLevelFormat = LevelFormat.AsDefined,
            };
            AccessLevel expectedResponse = new AccessLevel
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Basic = new BasicLevel(),
                Custom = new CustomLevel(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAccessLevelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessLevel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessLevel responseCallSettings = await client.GetAccessLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessLevel responseCancellationToken = await client.GetAccessLevelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessLevel()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
            };
            AccessLevel expectedResponse = new AccessLevel
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Basic = new BasicLevel(),
                Custom = new CustomLevel(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAccessLevel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessLevel response = client.GetAccessLevel(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessLevelAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
            };
            AccessLevel expectedResponse = new AccessLevel
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Basic = new BasicLevel(),
                Custom = new CustomLevel(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAccessLevelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessLevel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessLevel responseCallSettings = await client.GetAccessLevelAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessLevel responseCancellationToken = await client.GetAccessLevelAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessLevelResourceNames()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
            };
            AccessLevel expectedResponse = new AccessLevel
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Basic = new BasicLevel(),
                Custom = new CustomLevel(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAccessLevel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessLevel response = client.GetAccessLevel(request.AccessLevelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessLevelResourceNamesAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
            };
            AccessLevel expectedResponse = new AccessLevel
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Basic = new BasicLevel(),
                Custom = new CustomLevel(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAccessLevelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessLevel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            AccessLevel responseCallSettings = await client.GetAccessLevelAsync(request.AccessLevelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessLevel responseCancellationToken = await client.GetAccessLevelAsync(request.AccessLevelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServicePerimeterRequestObject()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            ServicePerimeter expectedResponse = new ServicePerimeter
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PerimeterType = ServicePerimeter.Types.PerimeterType.Bridge,
                Status = new ServicePerimeterConfig(),
                Spec = new ServicePerimeterConfig(),
                UseExplicitDryRunSpec = true,
            };
            mockGrpcClient.Setup(x => x.GetServicePerimeter(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            ServicePerimeter response = client.GetServicePerimeter(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServicePerimeterRequestObjectAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            ServicePerimeter expectedResponse = new ServicePerimeter
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PerimeterType = ServicePerimeter.Types.PerimeterType.Bridge,
                Status = new ServicePerimeterConfig(),
                Spec = new ServicePerimeterConfig(),
                UseExplicitDryRunSpec = true,
            };
            mockGrpcClient.Setup(x => x.GetServicePerimeterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServicePerimeter>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            ServicePerimeter responseCallSettings = await client.GetServicePerimeterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServicePerimeter responseCancellationToken = await client.GetServicePerimeterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServicePerimeter()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            ServicePerimeter expectedResponse = new ServicePerimeter
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PerimeterType = ServicePerimeter.Types.PerimeterType.Bridge,
                Status = new ServicePerimeterConfig(),
                Spec = new ServicePerimeterConfig(),
                UseExplicitDryRunSpec = true,
            };
            mockGrpcClient.Setup(x => x.GetServicePerimeter(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            ServicePerimeter response = client.GetServicePerimeter(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServicePerimeterAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            ServicePerimeter expectedResponse = new ServicePerimeter
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PerimeterType = ServicePerimeter.Types.PerimeterType.Bridge,
                Status = new ServicePerimeterConfig(),
                Spec = new ServicePerimeterConfig(),
                UseExplicitDryRunSpec = true,
            };
            mockGrpcClient.Setup(x => x.GetServicePerimeterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServicePerimeter>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            ServicePerimeter responseCallSettings = await client.GetServicePerimeterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServicePerimeter responseCancellationToken = await client.GetServicePerimeterAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServicePerimeterResourceNames()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            ServicePerimeter expectedResponse = new ServicePerimeter
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PerimeterType = ServicePerimeter.Types.PerimeterType.Bridge,
                Status = new ServicePerimeterConfig(),
                Spec = new ServicePerimeterConfig(),
                UseExplicitDryRunSpec = true,
            };
            mockGrpcClient.Setup(x => x.GetServicePerimeter(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            ServicePerimeter response = client.GetServicePerimeter(request.ServicePerimeterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServicePerimeterResourceNamesAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            ServicePerimeter expectedResponse = new ServicePerimeter
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PerimeterType = ServicePerimeter.Types.PerimeterType.Bridge,
                Status = new ServicePerimeterConfig(),
                Spec = new ServicePerimeterConfig(),
                UseExplicitDryRunSpec = true,
            };
            mockGrpcClient.Setup(x => x.GetServicePerimeterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServicePerimeter>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            ServicePerimeter responseCallSettings = await client.GetServicePerimeterAsync(request.ServicePerimeterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServicePerimeter responseCancellationToken = await client.GetServicePerimeterAsync(request.ServicePerimeterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGcpUserAccessBindingRequestObject()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            GcpUserAccessBinding expectedResponse = new GcpUserAccessBinding
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
                GroupKey = "group_keycd19b56f",
                AccessLevelsAsAccessLevelNames =
                {
                    AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetGcpUserAccessBinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            GcpUserAccessBinding response = client.GetGcpUserAccessBinding(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGcpUserAccessBindingRequestObjectAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            GcpUserAccessBinding expectedResponse = new GcpUserAccessBinding
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
                GroupKey = "group_keycd19b56f",
                AccessLevelsAsAccessLevelNames =
                {
                    AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetGcpUserAccessBindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GcpUserAccessBinding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            GcpUserAccessBinding responseCallSettings = await client.GetGcpUserAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GcpUserAccessBinding responseCancellationToken = await client.GetGcpUserAccessBindingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGcpUserAccessBinding()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            GcpUserAccessBinding expectedResponse = new GcpUserAccessBinding
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
                GroupKey = "group_keycd19b56f",
                AccessLevelsAsAccessLevelNames =
                {
                    AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetGcpUserAccessBinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            GcpUserAccessBinding response = client.GetGcpUserAccessBinding(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGcpUserAccessBindingAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            GcpUserAccessBinding expectedResponse = new GcpUserAccessBinding
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
                GroupKey = "group_keycd19b56f",
                AccessLevelsAsAccessLevelNames =
                {
                    AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetGcpUserAccessBindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GcpUserAccessBinding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            GcpUserAccessBinding responseCallSettings = await client.GetGcpUserAccessBindingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GcpUserAccessBinding responseCancellationToken = await client.GetGcpUserAccessBindingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGcpUserAccessBindingResourceNames()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            GcpUserAccessBinding expectedResponse = new GcpUserAccessBinding
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
                GroupKey = "group_keycd19b56f",
                AccessLevelsAsAccessLevelNames =
                {
                    AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetGcpUserAccessBinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            GcpUserAccessBinding response = client.GetGcpUserAccessBinding(request.GcpUserAccessBindingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGcpUserAccessBindingResourceNamesAsync()
        {
            moq::Mock<AccessContextManager.AccessContextManagerClient> mockGrpcClient = new moq::Mock<AccessContextManager.AccessContextManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            GcpUserAccessBinding expectedResponse = new GcpUserAccessBinding
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
                GroupKey = "group_keycd19b56f",
                AccessLevelsAsAccessLevelNames =
                {
                    AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetGcpUserAccessBindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GcpUserAccessBinding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessContextManagerClient client = new AccessContextManagerClientImpl(mockGrpcClient.Object, null);
            GcpUserAccessBinding responseCallSettings = await client.GetGcpUserAccessBindingAsync(request.GcpUserAccessBindingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GcpUserAccessBinding responseCancellationToken = await client.GetGcpUserAccessBindingAsync(request.GcpUserAccessBindingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
