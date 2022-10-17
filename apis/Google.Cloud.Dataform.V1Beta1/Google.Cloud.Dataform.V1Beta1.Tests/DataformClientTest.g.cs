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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataform.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataformClientTest
    {
        [xunit::FactAttribute]
        public void GetRepositoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.GetRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.GetRepository(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRepositoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.GetRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.GetRepositoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRepository()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.GetRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.GetRepository(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRepositoryAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.GetRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.GetRepositoryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.GetRepositoryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRepositoryResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.GetRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.GetRepository(request.RepositoryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRepositoryResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.GetRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.GetRepositoryAsync(request.RepositoryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.GetRepositoryAsync(request.RepositoryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRepositoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "repository_id311aee81",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.CreateRepository(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRepositoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "repository_id311aee81",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.CreateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.CreateRepositoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRepository()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "repository_id311aee81",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.CreateRepository(request.Parent, request.Repository, request.RepositoryId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRepositoryAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "repository_id311aee81",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.CreateRepositoryAsync(request.Parent, request.Repository, request.RepositoryId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.CreateRepositoryAsync(request.Parent, request.Repository, request.RepositoryId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRepositoryResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "repository_id311aee81",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.CreateRepository(request.ParentAsLocationName, request.Repository, request.RepositoryId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRepositoryResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "repository_id311aee81",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.CreateRepositoryAsync(request.ParentAsLocationName, request.Repository, request.RepositoryId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.CreateRepositoryAsync(request.ParentAsLocationName, request.Repository, request.RepositoryId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRepositoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Repository = new Repository(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.UpdateRepository(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRepositoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Repository = new Repository(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.UpdateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.UpdateRepositoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRepository()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Repository = new Repository(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository response = client.UpdateRepository(request.Repository, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRepositoryAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Repository = new Repository(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                GitRemoteSettings = new Repository.Types.GitRemoteSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Repository responseCallSettings = await client.UpdateRepositoryAsync(request.Repository, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.UpdateRepositoryAsync(request.Repository, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRepositoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteRepository(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRepositoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRepositoryAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRepository()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteRepository(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRepositoryAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteRepositoryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRepositoryAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRepositoryResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteRepository(request.RepositoryName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRepositoryResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteRepositoryAsync(request.RepositoryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRepositoryAsync(request.RepositoryName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchRemoteBranchesRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchRemoteBranchesRequest request = new FetchRemoteBranchesRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            FetchRemoteBranchesResponse expectedResponse = new FetchRemoteBranchesResponse
            {
                Branches =
                {
                    "branchesff19ec92",
                },
            };
            mockGrpcClient.Setup(x => x.FetchRemoteBranches(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchRemoteBranchesResponse response = client.FetchRemoteBranches(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchRemoteBranchesRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchRemoteBranchesRequest request = new FetchRemoteBranchesRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            FetchRemoteBranchesResponse expectedResponse = new FetchRemoteBranchesResponse
            {
                Branches =
                {
                    "branchesff19ec92",
                },
            };
            mockGrpcClient.Setup(x => x.FetchRemoteBranchesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchRemoteBranchesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchRemoteBranchesResponse responseCallSettings = await client.FetchRemoteBranchesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchRemoteBranchesResponse responseCancellationToken = await client.FetchRemoteBranchesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkspaceRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.GetWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace response = client.GetWorkspace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkspaceRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.GetWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace responseCallSettings = await client.GetWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.GetWorkspaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkspace()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.GetWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace response = client.GetWorkspace(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkspaceAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.GetWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace responseCallSettings = await client.GetWorkspaceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.GetWorkspaceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkspaceResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.GetWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace response = client.GetWorkspace(request.WorkspaceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkspaceResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.GetWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace responseCallSettings = await client.GetWorkspaceAsync(request.WorkspaceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.GetWorkspaceAsync(request.WorkspaceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkspaceRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "workspace_id8beaedff",
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.CreateWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace response = client.CreateWorkspace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkspaceRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "workspace_id8beaedff",
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.CreateWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace responseCallSettings = await client.CreateWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.CreateWorkspaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkspace()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "workspace_id8beaedff",
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.CreateWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace response = client.CreateWorkspace(request.Parent, request.Workspace, request.WorkspaceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkspaceAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "workspace_id8beaedff",
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.CreateWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace responseCallSettings = await client.CreateWorkspaceAsync(request.Parent, request.Workspace, request.WorkspaceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.CreateWorkspaceAsync(request.Parent, request.Workspace, request.WorkspaceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkspaceResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "workspace_id8beaedff",
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.CreateWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace response = client.CreateWorkspace(request.ParentAsRepositoryName, request.Workspace, request.WorkspaceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkspaceResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "workspace_id8beaedff",
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            mockGrpcClient.Setup(x => x.CreateWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            Workspace responseCallSettings = await client.CreateWorkspaceAsync(request.ParentAsRepositoryName, request.Workspace, request.WorkspaceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.CreateWorkspaceAsync(request.ParentAsRepositoryName, request.Workspace, request.WorkspaceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkspaceRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkspace(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkspaceRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkspaceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkspace()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkspace(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkspaceAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkspaceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkspaceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkspaceResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkspace(request.WorkspaceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkspaceResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkspaceAsync(request.WorkspaceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkspaceAsync(request.WorkspaceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InstallNpmPackagesRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            InstallNpmPackagesRequest request = new InstallNpmPackagesRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            InstallNpmPackagesResponse expectedResponse = new InstallNpmPackagesResponse { };
            mockGrpcClient.Setup(x => x.InstallNpmPackages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            InstallNpmPackagesResponse response = client.InstallNpmPackages(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InstallNpmPackagesRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            InstallNpmPackagesRequest request = new InstallNpmPackagesRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            InstallNpmPackagesResponse expectedResponse = new InstallNpmPackagesResponse { };
            mockGrpcClient.Setup(x => x.InstallNpmPackagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstallNpmPackagesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            InstallNpmPackagesResponse responseCallSettings = await client.InstallNpmPackagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstallNpmPackagesResponse responseCancellationToken = await client.InstallNpmPackagesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PullGitCommitsRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullGitCommitsRequest request = new PullGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "remote_branchbb816043",
                Author = new CommitAuthor(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PullGitCommits(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.PullGitCommits(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PullGitCommitsRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullGitCommitsRequest request = new PullGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "remote_branchbb816043",
                Author = new CommitAuthor(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PullGitCommitsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.PullGitCommitsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PullGitCommitsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PushGitCommitsRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PushGitCommitsRequest request = new PushGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "remote_branchbb816043",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PushGitCommits(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.PushGitCommits(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PushGitCommitsRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PushGitCommitsRequest request = new PushGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "remote_branchbb816043",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PushGitCommitsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.PushGitCommitsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PushGitCommitsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchFileGitStatusesRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchFileGitStatusesRequest request = new FetchFileGitStatusesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            FetchFileGitStatusesResponse expectedResponse = new FetchFileGitStatusesResponse
            {
                UncommittedFileChanges =
                {
                    new FetchFileGitStatusesResponse.Types.UncommittedFileChange(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchFileGitStatuses(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchFileGitStatusesResponse response = client.FetchFileGitStatuses(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchFileGitStatusesRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchFileGitStatusesRequest request = new FetchFileGitStatusesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            FetchFileGitStatusesResponse expectedResponse = new FetchFileGitStatusesResponse
            {
                UncommittedFileChanges =
                {
                    new FetchFileGitStatusesResponse.Types.UncommittedFileChange(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchFileGitStatusesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchFileGitStatusesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchFileGitStatusesResponse responseCallSettings = await client.FetchFileGitStatusesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchFileGitStatusesResponse responseCancellationToken = await client.FetchFileGitStatusesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchGitAheadBehindRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchGitAheadBehindRequest request = new FetchGitAheadBehindRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "remote_branchbb816043",
            };
            FetchGitAheadBehindResponse expectedResponse = new FetchGitAheadBehindResponse
            {
                CommitsAhead = -789242210,
                CommitsBehind = -993136023,
            };
            mockGrpcClient.Setup(x => x.FetchGitAheadBehind(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchGitAheadBehindResponse response = client.FetchGitAheadBehind(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchGitAheadBehindRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchGitAheadBehindRequest request = new FetchGitAheadBehindRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "remote_branchbb816043",
            };
            FetchGitAheadBehindResponse expectedResponse = new FetchGitAheadBehindResponse
            {
                CommitsAhead = -789242210,
                CommitsBehind = -993136023,
            };
            mockGrpcClient.Setup(x => x.FetchGitAheadBehindAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchGitAheadBehindResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchGitAheadBehindResponse responseCallSettings = await client.FetchGitAheadBehindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchGitAheadBehindResponse responseCancellationToken = await client.FetchGitAheadBehindAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CommitWorkspaceChangesRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CommitWorkspaceChangesRequest request = new CommitWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CommitMessage = "commit_messagedf192292",
                Paths = { "paths012c8713", },
                Author = new CommitAuthor(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CommitWorkspaceChanges(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.CommitWorkspaceChanges(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CommitWorkspaceChangesRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CommitWorkspaceChangesRequest request = new CommitWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CommitMessage = "commit_messagedf192292",
                Paths = { "paths012c8713", },
                Author = new CommitAuthor(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CommitWorkspaceChangesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.CommitWorkspaceChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CommitWorkspaceChangesAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetWorkspaceChangesRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ResetWorkspaceChangesRequest request = new ResetWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Paths = { "paths012c8713", },
                Clean = false,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResetWorkspaceChanges(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.ResetWorkspaceChanges(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetWorkspaceChangesRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ResetWorkspaceChangesRequest request = new ResetWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Paths = { "paths012c8713", },
                Clean = false,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResetWorkspaceChangesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.ResetWorkspaceChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResetWorkspaceChangesAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchFileDiffRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchFileDiffRequest request = new FetchFileDiffRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            FetchFileDiffResponse expectedResponse = new FetchFileDiffResponse
            {
                FormattedDiff = "formatted_diffef1b417e",
            };
            mockGrpcClient.Setup(x => x.FetchFileDiff(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchFileDiffResponse response = client.FetchFileDiff(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchFileDiffRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchFileDiffRequest request = new FetchFileDiffRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            FetchFileDiffResponse expectedResponse = new FetchFileDiffResponse
            {
                FormattedDiff = "formatted_diffef1b417e",
            };
            mockGrpcClient.Setup(x => x.FetchFileDiffAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchFileDiffResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            FetchFileDiffResponse responseCallSettings = await client.FetchFileDiffAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchFileDiffResponse responseCancellationToken = await client.FetchFileDiffAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MakeDirectoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            MakeDirectoryRequest request = new MakeDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            MakeDirectoryResponse expectedResponse = new MakeDirectoryResponse { };
            mockGrpcClient.Setup(x => x.MakeDirectory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            MakeDirectoryResponse response = client.MakeDirectory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MakeDirectoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            MakeDirectoryRequest request = new MakeDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            MakeDirectoryResponse expectedResponse = new MakeDirectoryResponse { };
            mockGrpcClient.Setup(x => x.MakeDirectoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MakeDirectoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            MakeDirectoryResponse responseCallSettings = await client.MakeDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MakeDirectoryResponse responseCancellationToken = await client.MakeDirectoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveDirectoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RemoveDirectoryRequest request = new RemoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveDirectory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.RemoveDirectory(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveDirectoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RemoveDirectoryRequest request = new RemoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveDirectoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.RemoveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RemoveDirectoryAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveDirectoryRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            MoveDirectoryRequest request = new MoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
                NewPath = "new_path04b22490",
            };
            MoveDirectoryResponse expectedResponse = new MoveDirectoryResponse { };
            mockGrpcClient.Setup(x => x.MoveDirectory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            MoveDirectoryResponse response = client.MoveDirectory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveDirectoryRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            MoveDirectoryRequest request = new MoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
                NewPath = "new_path04b22490",
            };
            MoveDirectoryResponse expectedResponse = new MoveDirectoryResponse { };
            mockGrpcClient.Setup(x => x.MoveDirectoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MoveDirectoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            MoveDirectoryResponse responseCallSettings = await client.MoveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MoveDirectoryResponse responseCancellationToken = await client.MoveDirectoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadFileRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ReadFileRequest request = new ReadFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            ReadFileResponse expectedResponse = new ReadFileResponse
            {
                FileContents = proto::ByteString.CopyFromUtf8("file_contents3311b039"),
            };
            mockGrpcClient.Setup(x => x.ReadFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            ReadFileResponse response = client.ReadFile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadFileRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ReadFileRequest request = new ReadFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            ReadFileResponse expectedResponse = new ReadFileResponse
            {
                FileContents = proto::ByteString.CopyFromUtf8("file_contents3311b039"),
            };
            mockGrpcClient.Setup(x => x.ReadFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadFileResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            ReadFileResponse responseCallSettings = await client.ReadFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadFileResponse responseCancellationToken = await client.ReadFileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveFileRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RemoveFileRequest request = new RemoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.RemoveFile(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveFileRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RemoveFileRequest request = new RemoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.RemoveFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RemoveFileAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveFileRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            MoveFileRequest request = new MoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
                NewPath = "new_path04b22490",
            };
            MoveFileResponse expectedResponse = new MoveFileResponse { };
            mockGrpcClient.Setup(x => x.MoveFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            MoveFileResponse response = client.MoveFile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveFileRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            MoveFileRequest request = new MoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
                NewPath = "new_path04b22490",
            };
            MoveFileResponse expectedResponse = new MoveFileResponse { };
            mockGrpcClient.Setup(x => x.MoveFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MoveFileResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            MoveFileResponse responseCallSettings = await client.MoveFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MoveFileResponse responseCancellationToken = await client.MoveFileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteFileRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            WriteFileRequest request = new WriteFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            WriteFileResponse expectedResponse = new WriteFileResponse { };
            mockGrpcClient.Setup(x => x.WriteFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WriteFileResponse response = client.WriteFile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteFileRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            WriteFileRequest request = new WriteFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "path0b1dfed6",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            WriteFileResponse expectedResponse = new WriteFileResponse { };
            mockGrpcClient.Setup(x => x.WriteFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteFileResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WriteFileResponse responseCallSettings = await client.WriteFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteFileResponse responseCancellationToken = await client.WriteFileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompilationResultRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCompilationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult response = client.GetCompilationResult(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompilationResultRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCompilationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompilationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult responseCallSettings = await client.GetCompilationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompilationResult responseCancellationToken = await client.GetCompilationResultAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompilationResult()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCompilationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult response = client.GetCompilationResult(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompilationResultAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCompilationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompilationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult responseCallSettings = await client.GetCompilationResultAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompilationResult responseCancellationToken = await client.GetCompilationResultAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompilationResultResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCompilationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult response = client.GetCompilationResult(request.CompilationResultName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompilationResultResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCompilationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompilationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult responseCallSettings = await client.GetCompilationResultAsync(request.CompilationResultName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompilationResult responseCancellationToken = await client.GetCompilationResultAsync(request.CompilationResultName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCompilationResultRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCompilationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult response = client.CreateCompilationResult(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCompilationResultRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCompilationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompilationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult responseCallSettings = await client.CreateCompilationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompilationResult responseCancellationToken = await client.CreateCompilationResultAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCompilationResult()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCompilationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult response = client.CreateCompilationResult(request.Parent, request.CompilationResult);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCompilationResultAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCompilationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompilationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult responseCallSettings = await client.CreateCompilationResultAsync(request.Parent, request.CompilationResult, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompilationResult responseCancellationToken = await client.CreateCompilationResultAsync(request.Parent, request.CompilationResult, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCompilationResultResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCompilationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult response = client.CreateCompilationResult(request.ParentAsRepositoryName, request.CompilationResult);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCompilationResultResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            CompilationResult expectedResponse = new CompilationResult
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                GitCommitish = "git_commitished90bbcd",
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CodeCompilationConfig = new CompilationResult.Types.CodeCompilationConfig(),
                DataformCoreVersion = "dataform_core_versione38be759",
                CompilationErrors =
                {
                    new CompilationResult.Types.CompilationError(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCompilationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompilationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            CompilationResult responseCallSettings = await client.CreateCompilationResultAsync(request.ParentAsRepositoryName, request.CompilationResult, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompilationResult responseCancellationToken = await client.CreateCompilationResultAsync(request.ParentAsRepositoryName, request.CompilationResult, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowInvocationRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation response = client.GetWorkflowInvocation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowInvocationRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowInvocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation responseCallSettings = await client.GetWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowInvocation responseCancellationToken = await client.GetWorkflowInvocationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowInvocation()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation response = client.GetWorkflowInvocation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowInvocationAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowInvocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation responseCallSettings = await client.GetWorkflowInvocationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowInvocation responseCancellationToken = await client.GetWorkflowInvocationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowInvocationResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation response = client.GetWorkflowInvocation(request.WorkflowInvocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowInvocationResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowInvocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation responseCallSettings = await client.GetWorkflowInvocationAsync(request.WorkflowInvocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowInvocation responseCancellationToken = await client.GetWorkflowInvocationAsync(request.WorkflowInvocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowInvocationRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation response = client.CreateWorkflowInvocation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowInvocationRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowInvocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation responseCallSettings = await client.CreateWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowInvocation responseCancellationToken = await client.CreateWorkflowInvocationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowInvocation()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation response = client.CreateWorkflowInvocation(request.Parent, request.WorkflowInvocation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowInvocationAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowInvocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation responseCallSettings = await client.CreateWorkflowInvocationAsync(request.Parent, request.WorkflowInvocation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowInvocation responseCancellationToken = await client.CreateWorkflowInvocationAsync(request.Parent, request.WorkflowInvocation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowInvocationResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation response = client.CreateWorkflowInvocation(request.ParentAsRepositoryName, request.WorkflowInvocation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowInvocationResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            WorkflowInvocation expectedResponse = new WorkflowInvocation
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
                CompilationResultAsCompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                InvocationConfig = new WorkflowInvocation.Types.InvocationConfig(),
                State = WorkflowInvocation.Types.State.Unspecified,
                InvocationTiming = new gt::Interval(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowInvocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            WorkflowInvocation responseCallSettings = await client.CreateWorkflowInvocationAsync(request.ParentAsRepositoryName, request.WorkflowInvocation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowInvocation responseCancellationToken = await client.CreateWorkflowInvocationAsync(request.ParentAsRepositoryName, request.WorkflowInvocation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowInvocationRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkflowInvocation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowInvocationRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowInvocationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowInvocation()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkflowInvocation(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowInvocationAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkflowInvocationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowInvocationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowInvocationResourceNames()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkflowInvocation(request.WorkflowInvocationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowInvocationResourceNamesAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkflowInvocationAsync(request.WorkflowInvocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowInvocationAsync(request.WorkflowInvocationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelWorkflowInvocationRequestObject()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelWorkflowInvocationRequest request = new CancelWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelWorkflowInvocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            client.CancelWorkflowInvocation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelWorkflowInvocationRequestObjectAsync()
        {
            moq::Mock<Dataform.DataformClient> mockGrpcClient = new moq::Mock<Dataform.DataformClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelWorkflowInvocationRequest request = new CancelWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelWorkflowInvocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataformClient client = new DataformClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelWorkflowInvocationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
