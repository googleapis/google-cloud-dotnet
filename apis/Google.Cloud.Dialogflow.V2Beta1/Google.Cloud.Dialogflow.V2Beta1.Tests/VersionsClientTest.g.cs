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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVersionsClientTest
    {
        [xunit::FactAttribute]
        public void GetVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.GetVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.GetVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.GetVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVersionResourceNames()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.GetVersion(request.VersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionResourceNamesAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.GetVersionAsync(request.VersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request.VersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateVersionRequest request = new CreateVersionRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Version = new Version(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.CreateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.CreateVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateVersionRequest request = new CreateVersionRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Version = new Version(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.CreateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.CreateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.CreateVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateVersionRequest request = new CreateVersionRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Version = new Version(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.CreateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.CreateVersion(request.Parent, request.Version);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateVersionRequest request = new CreateVersionRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Version = new Version(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.CreateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.CreateVersionAsync(request.Parent, request.Version, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.CreateVersionAsync(request.Parent, request.Version, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVersionResourceNames()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateVersionRequest request = new CreateVersionRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Version = new Version(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.CreateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.CreateVersion(request.ParentAsAgentName, request.Version);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVersionResourceNamesAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateVersionRequest request = new CreateVersionRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Version = new Version(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.CreateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.CreateVersionAsync(request.ParentAsAgentName, request.Version, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.CreateVersionAsync(request.ParentAsAgentName, request.Version, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.UpdateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.UpdateVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.UpdateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.UpdateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.UpdateVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.UpdateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version response = client.UpdateVersion(request.Version, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                Description = "description2cf9da67",
                VersionNumber = -1567505473,
                CreateTime = new wkt::Timestamp(),
                Status = Version.Types.VersionStatus.Ready,
            };
            mockGrpcClient.Setup(x => x.UpdateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.UpdateVersionAsync(request.Version, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.UpdateVersionAsync(request.Version, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteVersion(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVersionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteVersion(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVersionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVersionResourceNames()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteVersion(request.VersionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVersionResourceNamesAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteVersionAsync(request.VersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVersionAsync(request.VersionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
