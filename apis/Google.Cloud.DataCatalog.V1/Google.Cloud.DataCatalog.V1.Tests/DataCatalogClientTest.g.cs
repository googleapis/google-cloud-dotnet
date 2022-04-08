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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataCatalog.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataCatalogClientTest
    {
        [xunit::FactAttribute]
        public void CreateEntryGroupRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "entry_group_id574a02c9",
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.CreateEntryGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntryGroupRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "entry_group_id574a02c9",
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.CreateEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.CreateEntryGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntryGroup()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "entry_group_id574a02c9",
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.CreateEntryGroup(request.Parent, request.EntryGroupId, request.EntryGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntryGroupAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "entry_group_id574a02c9",
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.CreateEntryGroupAsync(request.Parent, request.EntryGroupId, request.EntryGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.CreateEntryGroupAsync(request.Parent, request.EntryGroupId, request.EntryGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntryGroupResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "entry_group_id574a02c9",
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.CreateEntryGroup(request.ParentAsLocationName, request.EntryGroupId, request.EntryGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntryGroupResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "entry_group_id574a02c9",
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.CreateEntryGroupAsync(request.ParentAsLocationName, request.EntryGroupId, request.EntryGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.CreateEntryGroupAsync(request.ParentAsLocationName, request.EntryGroupId, request.EntryGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryGroupRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.GetEntryGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryGroupRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.GetEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.GetEntryGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryGroup1()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.GetEntryGroup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryGroup1Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.GetEntryGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.GetEntryGroupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryGroup1ResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.GetEntryGroup(request.EntryGroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryGroup1ResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.GetEntryGroupAsync(request.EntryGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.GetEntryGroupAsync(request.EntryGroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryGroup2()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.GetEntryGroup(request.Name, request.ReadMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryGroup2Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.GetEntryGroupAsync(request.Name, request.ReadMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.GetEntryGroupAsync(request.Name, request.ReadMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryGroup2ResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.GetEntryGroup(request.EntryGroupName, request.ReadMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryGroup2ResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.GetEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.GetEntryGroupAsync(request.EntryGroupName, request.ReadMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.GetEntryGroupAsync(request.EntryGroupName, request.ReadMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntryGroupRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.UpdateEntryGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntryGroupRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.UpdateEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.UpdateEntryGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntryGroup1()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.UpdateEntryGroup(request.EntryGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntryGroup1Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.UpdateEntryGroupAsync(request.EntryGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.UpdateEntryGroupAsync(request.EntryGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntryGroup2()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup response = client.UpdateEntryGroup(request.EntryGroup, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntryGroup2Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntryGroup expectedResponse = new EntryGroup
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DataCatalogTimestamps = new SystemTimestamps(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryGroup responseCallSettings = await client.UpdateEntryGroupAsync(request.EntryGroup, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryGroup responseCancellationToken = await client.UpdateEntryGroupAsync(request.EntryGroup, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntryGroupRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntryGroup(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntryGroupRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntryGroupAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntryGroup()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntryGroup(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntryGroupAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntryGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntryGroupAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntryGroupResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntryGroup(request.EntryGroupName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntryGroupResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntryGroupAsync(request.EntryGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntryGroupAsync(request.EntryGroupName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "entry_idea624ab6",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.CreateEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.CreateEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "entry_idea624ab6",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.CreateEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.CreateEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntry()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "entry_idea624ab6",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.CreateEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.CreateEntry(request.Parent, request.EntryId, request.Entry);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntryAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "entry_idea624ab6",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.CreateEntryAsync(request.Parent, request.EntryId, request.Entry, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.CreateEntryAsync(request.Parent, request.EntryId, request.Entry, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntryResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "entry_idea624ab6",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.CreateEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.CreateEntry(request.ParentAsEntryGroupName, request.EntryId, request.Entry);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntryResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "entry_idea624ab6",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.CreateEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.CreateEntryAsync(request.ParentAsEntryGroupName, request.EntryId, request.Entry, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.CreateEntryAsync(request.ParentAsEntryGroupName, request.EntryId, request.Entry, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryRequest request = new UpdateEntryRequest
            {
                Entry = new Entry(),
                UpdateMask = new wkt::FieldMask(),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.UpdateEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryRequest request = new UpdateEntryRequest
            {
                Entry = new Entry(),
                UpdateMask = new wkt::FieldMask(),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.UpdateEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.UpdateEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntry1()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryRequest request = new UpdateEntryRequest { Entry = new Entry(), };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.UpdateEntry(request.Entry);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntry1Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryRequest request = new UpdateEntryRequest { Entry = new Entry(), };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.UpdateEntryAsync(request.Entry, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.UpdateEntryAsync(request.Entry, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntry2()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryRequest request = new UpdateEntryRequest
            {
                Entry = new Entry(),
                UpdateMask = new wkt::FieldMask(),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.UpdateEntry(request.Entry, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntry2Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateEntryRequest request = new UpdateEntryRequest
            {
                Entry = new Entry(),
                UpdateMask = new wkt::FieldMask(),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.UpdateEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.UpdateEntryAsync(request.Entry, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.UpdateEntryAsync(request.Entry, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntry(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntryAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntry()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntry(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntryAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntryAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntryResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntry(request.EntryName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntryResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntryAsync(request.EntryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntryAsync(request.EntryName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.GetEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.GetEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.GetEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.GetEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.GetEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntry()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.GetEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.GetEntry(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.GetEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.GetEntryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.GetEntryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntryResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.GetEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.GetEntry(request.EntryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntryResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.GetEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.GetEntryAsync(request.EntryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.GetEntryAsync(request.EntryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LookupEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            LookupEntryRequest request = new LookupEntryRequest
            {
                LinkedResource = "linked_resourcef4db0f72",
                SqlResource = "sql_resourced9883bb3",
                FullyQualifiedName = "fully_qualified_name75818c4f",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.LookupEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry response = client.LookupEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            LookupEntryRequest request = new LookupEntryRequest
            {
                LinkedResource = "linked_resourcef4db0f72",
                SqlResource = "sql_resourced9883bb3",
                FullyQualifiedName = "fully_qualified_name75818c4f",
            };
            Entry expectedResponse = new Entry
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Type = EntryType.DataStream,
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Schema = new Schema(),
                GcsFilesetSpec = new GcsFilesetSpec(),
                SourceSystemTimestamps = new SystemTimestamps(),
                LinkedResource = "linked_resourcef4db0f72",
                BigqueryTableSpec = new BigQueryTableSpec(),
                UsageSignal = new UsageSignal(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BigqueryDateShardedSpec = new BigQueryDateShardedSpec(),
                UserSpecifiedType = "user_specified_typecdee5e15",
                IntegratedSystem = IntegratedSystem.Dataplex,
                UserSpecifiedSystem = "user_specified_systema7f0cfeb",
                DataSource = new DataSource(),
                DatabaseTableSpec = new DatabaseTableSpec(),
                PersonalDetails = new PersonalDetails(),
                DataSourceConnectionSpec = new DataSourceConnectionSpec(),
                RoutineSpec = new RoutineSpec(),
                FullyQualifiedName = "fully_qualified_name75818c4f",
                FilesetSpec = new FilesetSpec(),
                BusinessContext = new BusinessContext(),
            };
            mockGrpcClient.Setup(x => x.LookupEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Entry responseCallSettings = await client.LookupEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entry responseCancellationToken = await client.LookupEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyEntryOverviewRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            ModifyEntryOverviewRequest request = new ModifyEntryOverviewRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                EntryOverview = new EntryOverview(),
            };
            EntryOverview expectedResponse = new EntryOverview
            {
                Overview = "overview7459e0bc",
            };
            mockGrpcClient.Setup(x => x.ModifyEntryOverview(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryOverview response = client.ModifyEntryOverview(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyEntryOverviewRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            ModifyEntryOverviewRequest request = new ModifyEntryOverviewRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                EntryOverview = new EntryOverview(),
            };
            EntryOverview expectedResponse = new EntryOverview
            {
                Overview = "overview7459e0bc",
            };
            mockGrpcClient.Setup(x => x.ModifyEntryOverviewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntryOverview>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            EntryOverview responseCallSettings = await client.ModifyEntryOverviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntryOverview responseCancellationToken = await client.ModifyEntryOverviewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyEntryContactsRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            ModifyEntryContactsRequest request = new ModifyEntryContactsRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Contacts = new Contacts(),
            };
            Contacts expectedResponse = new Contacts
            {
                People =
                {
                    new Contacts.Types.Person(),
                },
            };
            mockGrpcClient.Setup(x => x.ModifyEntryContacts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Contacts response = client.ModifyEntryContacts(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyEntryContactsRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            ModifyEntryContactsRequest request = new ModifyEntryContactsRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Contacts = new Contacts(),
            };
            Contacts expectedResponse = new Contacts
            {
                People =
                {
                    new Contacts.Types.Person(),
                },
            };
            mockGrpcClient.Setup(x => x.ModifyEntryContactsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contacts>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Contacts responseCallSettings = await client.ModifyEntryContactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contacts responseCancellationToken = await client.ModifyEntryContactsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagTemplateRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "tag_template_idcfdbee5a",
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.CreateTagTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagTemplateRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "tag_template_idcfdbee5a",
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.CreateTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.CreateTagTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagTemplate()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "tag_template_idcfdbee5a",
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.CreateTagTemplate(request.Parent, request.TagTemplateId, request.TagTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagTemplateAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "tag_template_idcfdbee5a",
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.CreateTagTemplateAsync(request.Parent, request.TagTemplateId, request.TagTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.CreateTagTemplateAsync(request.Parent, request.TagTemplateId, request.TagTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagTemplateResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "tag_template_idcfdbee5a",
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.CreateTagTemplate(request.ParentAsLocationName, request.TagTemplateId, request.TagTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagTemplateResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "tag_template_idcfdbee5a",
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.CreateTagTemplateAsync(request.ParentAsLocationName, request.TagTemplateId, request.TagTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.CreateTagTemplateAsync(request.ParentAsLocationName, request.TagTemplateId, request.TagTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTagTemplateRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.GetTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.GetTagTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTagTemplateRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.GetTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.GetTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.GetTagTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTagTemplate()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.GetTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.GetTagTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTagTemplateAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.GetTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.GetTagTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.GetTagTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTagTemplateResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.GetTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.GetTagTemplate(request.TagTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTagTemplateResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.GetTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.GetTagTemplateAsync(request.TagTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.GetTagTemplateAsync(request.TagTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplateRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.UpdateTagTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplateRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.UpdateTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.UpdateTagTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplate1()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.UpdateTagTemplate(request.TagTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplate1Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.UpdateTagTemplateAsync(request.TagTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.UpdateTagTemplateAsync(request.TagTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplate2()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate response = client.UpdateTagTemplate(request.TagTemplate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplate2Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplate expectedResponse = new TagTemplate
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagTemplateField()
                    },
                },
                IsPubliclyReadable = false,
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplate responseCallSettings = await client.UpdateTagTemplateAsync(request.TagTemplate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplate responseCancellationToken = await client.UpdateTagTemplateAsync(request.TagTemplate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagTemplateRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTagTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagTemplateRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagTemplate()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTagTemplate(request.Name, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagTemplateAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagTemplateAsync(request.Name, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagTemplateAsync(request.Name, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagTemplateResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTagTemplate(request.TagTemplateName, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagTemplateResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagTemplateAsync(request.TagTemplateName, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagTemplateAsync(request.TagTemplateName, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagTemplateFieldRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "tag_template_field_id4703f553",
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.CreateTagTemplateField(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagTemplateFieldRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "tag_template_field_id4703f553",
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.CreateTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.CreateTagTemplateFieldAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagTemplateField()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "tag_template_field_id4703f553",
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.CreateTagTemplateField(request.Parent, request.TagTemplateFieldId, request.TagTemplateField);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagTemplateFieldAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "tag_template_field_id4703f553",
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.CreateTagTemplateFieldAsync(request.Parent, request.TagTemplateFieldId, request.TagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.CreateTagTemplateFieldAsync(request.Parent, request.TagTemplateFieldId, request.TagTemplateField, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagTemplateFieldResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "tag_template_field_id4703f553",
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.CreateTagTemplateField(request.ParentAsTagTemplateName, request.TagTemplateFieldId, request.TagTemplateField);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagTemplateFieldResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "tag_template_field_id4703f553",
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.CreateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.CreateTagTemplateFieldAsync(request.ParentAsTagTemplateName, request.TagTemplateFieldId, request.TagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.CreateTagTemplateFieldAsync(request.ParentAsTagTemplateName, request.TagTemplateFieldId, request.TagTemplateField, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplateFieldRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.UpdateTagTemplateField(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplateFieldRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.UpdateTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.UpdateTagTemplateFieldAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplateField1()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.UpdateTagTemplateField(request.Name, request.TagTemplateField);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplateField1Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.UpdateTagTemplateFieldAsync(request.Name, request.TagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.UpdateTagTemplateFieldAsync(request.Name, request.TagTemplateField, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplateField1ResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.UpdateTagTemplateField(request.TagTemplateFieldName, request.TagTemplateField);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplateField1ResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.UpdateTagTemplateFieldAsync(request.TagTemplateFieldName, request.TagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.UpdateTagTemplateFieldAsync(request.TagTemplateFieldName, request.TagTemplateField, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplateField2()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.UpdateTagTemplateField(request.Name, request.TagTemplateField, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplateField2Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.UpdateTagTemplateFieldAsync(request.Name, request.TagTemplateField, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.UpdateTagTemplateFieldAsync(request.Name, request.TagTemplateField, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagTemplateField2ResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.UpdateTagTemplateField(request.TagTemplateFieldName, request.TagTemplateField, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagTemplateField2ResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new wkt::FieldMask(),
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.UpdateTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.UpdateTagTemplateFieldAsync(request.TagTemplateFieldName, request.TagTemplateField, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.UpdateTagTemplateFieldAsync(request.TagTemplateFieldName, request.TagTemplateField, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RenameTagTemplateFieldRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "new_tag_template_field_id8a61ef6e",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.RenameTagTemplateField(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RenameTagTemplateFieldRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "new_tag_template_field_id8a61ef6e",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.RenameTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.RenameTagTemplateFieldAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RenameTagTemplateField()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "new_tag_template_field_id8a61ef6e",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.RenameTagTemplateField(request.Name, request.NewTagTemplateFieldId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RenameTagTemplateFieldAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "new_tag_template_field_id8a61ef6e",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.RenameTagTemplateFieldAsync(request.Name, request.NewTagTemplateFieldId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.RenameTagTemplateFieldAsync(request.Name, request.NewTagTemplateFieldId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RenameTagTemplateFieldResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "new_tag_template_field_id8a61ef6e",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.RenameTagTemplateField(request.TagTemplateFieldName, request.NewTagTemplateFieldId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RenameTagTemplateFieldResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "new_tag_template_field_id8a61ef6e",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.RenameTagTemplateFieldAsync(request.TagTemplateFieldName, request.NewTagTemplateFieldId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.RenameTagTemplateFieldAsync(request.TagTemplateFieldName, request.NewTagTemplateFieldId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RenameTagTemplateFieldEnumValueRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "new_enum_value_display_name1149e4d9",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldEnumValue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.RenameTagTemplateFieldEnumValue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RenameTagTemplateFieldEnumValueRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "new_enum_value_display_name1149e4d9",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldEnumValueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.RenameTagTemplateFieldEnumValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.RenameTagTemplateFieldEnumValueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RenameTagTemplateFieldEnumValue()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "new_enum_value_display_name1149e4d9",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldEnumValue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.RenameTagTemplateFieldEnumValue(request.Name, request.NewEnumValueDisplayName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RenameTagTemplateFieldEnumValueAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "new_enum_value_display_name1149e4d9",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldEnumValueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.RenameTagTemplateFieldEnumValueAsync(request.Name, request.NewEnumValueDisplayName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.RenameTagTemplateFieldEnumValueAsync(request.Name, request.NewEnumValueDisplayName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RenameTagTemplateFieldEnumValueResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "new_enum_value_display_name1149e4d9",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldEnumValue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField response = client.RenameTagTemplateFieldEnumValue(request.TagTemplateFieldEnumValueName, request.NewEnumValueDisplayName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RenameTagTemplateFieldEnumValueResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "new_enum_value_display_name1149e4d9",
            };
            TagTemplateField expectedResponse = new TagTemplateField
            {
                DisplayName = "display_name137f65c2",
                Type = new FieldType(),
                IsRequired = false,
                Description = "description2cf9da67",
                Order = -92298896,
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
            };
            mockGrpcClient.Setup(x => x.RenameTagTemplateFieldEnumValueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TagTemplateField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            TagTemplateField responseCallSettings = await client.RenameTagTemplateFieldEnumValueAsync(request.TagTemplateFieldEnumValueName, request.NewEnumValueDisplayName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TagTemplateField responseCancellationToken = await client.RenameTagTemplateFieldEnumValueAsync(request.TagTemplateFieldEnumValueName, request.NewEnumValueDisplayName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagTemplateFieldRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTagTemplateField(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagTemplateFieldRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagTemplateFieldAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagTemplateField()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTagTemplateField(request.Name, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagTemplateFieldAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagTemplateFieldAsync(request.Name, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagTemplateFieldAsync(request.Name, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagTemplateFieldResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTagTemplateField(request.TagTemplateFieldName, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagTemplateFieldResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagTemplateFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagTemplateFieldAsync(request.TagTemplateFieldName, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagTemplateFieldAsync(request.TagTemplateFieldName, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsTagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.CreateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag response = client.CreateTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsTagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.CreateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.CreateTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTag()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsTagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.CreateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag response = client.CreateTag(request.Parent, request.Tag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsTagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.CreateTagAsync(request.Parent, request.Tag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.CreateTagAsync(request.Parent, request.Tag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsTagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.CreateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag response = client.CreateTag(request.ParentAsTagName, request.Tag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsTagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.CreateTagAsync(request.ParentAsTagName, request.Tag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.CreateTagAsync(request.ParentAsTagName, request.Tag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.UpdateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag response = client.UpdateTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.UpdateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.UpdateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.UpdateTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTag1()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagRequest request = new UpdateTagRequest { Tag = new Tag(), };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.UpdateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag response = client.UpdateTag(request.Tag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTag1Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagRequest request = new UpdateTagRequest { Tag = new Tag(), };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.UpdateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.UpdateTagAsync(request.Tag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.UpdateTagAsync(request.Tag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTag2()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.UpdateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag response = client.UpdateTag(request.Tag, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTag2Async()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = TagName.FromProjectLocationEntryGroupEntryTag("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]"),
                Template = "template1b18f666",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new TagField()
                    },
                },
                Column = "column8132fd1a",
                TemplateDisplayName = "template_display_name16b1cc5f",
            };
            mockGrpcClient.Setup(x => x.UpdateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.UpdateTagAsync(request.Tag, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.UpdateTagAsync(request.Tag, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTag(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTag()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTag(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            client.DeleteTag(request.EntryName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagAsync(request.EntryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagAsync(request.EntryName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StarEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            StarEntryResponse expectedResponse = new StarEntryResponse { };
            mockGrpcClient.Setup(x => x.StarEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            StarEntryResponse response = client.StarEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StarEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            StarEntryResponse expectedResponse = new StarEntryResponse { };
            mockGrpcClient.Setup(x => x.StarEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StarEntryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            StarEntryResponse responseCallSettings = await client.StarEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StarEntryResponse responseCancellationToken = await client.StarEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StarEntry()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            StarEntryResponse expectedResponse = new StarEntryResponse { };
            mockGrpcClient.Setup(x => x.StarEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            StarEntryResponse response = client.StarEntry(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StarEntryAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            StarEntryResponse expectedResponse = new StarEntryResponse { };
            mockGrpcClient.Setup(x => x.StarEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StarEntryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            StarEntryResponse responseCallSettings = await client.StarEntryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StarEntryResponse responseCancellationToken = await client.StarEntryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StarEntryResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            StarEntryResponse expectedResponse = new StarEntryResponse { };
            mockGrpcClient.Setup(x => x.StarEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            StarEntryResponse response = client.StarEntry(request.EntryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StarEntryResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            StarEntryResponse expectedResponse = new StarEntryResponse { };
            mockGrpcClient.Setup(x => x.StarEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StarEntryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            StarEntryResponse responseCallSettings = await client.StarEntryAsync(request.EntryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StarEntryResponse responseCancellationToken = await client.StarEntryAsync(request.EntryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnstarEntryRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            UnstarEntryResponse expectedResponse = new UnstarEntryResponse { };
            mockGrpcClient.Setup(x => x.UnstarEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            UnstarEntryResponse response = client.UnstarEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnstarEntryRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            UnstarEntryResponse expectedResponse = new UnstarEntryResponse { };
            mockGrpcClient.Setup(x => x.UnstarEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnstarEntryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            UnstarEntryResponse responseCallSettings = await client.UnstarEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnstarEntryResponse responseCancellationToken = await client.UnstarEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnstarEntry()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            UnstarEntryResponse expectedResponse = new UnstarEntryResponse { };
            mockGrpcClient.Setup(x => x.UnstarEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            UnstarEntryResponse response = client.UnstarEntry(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnstarEntryAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            UnstarEntryResponse expectedResponse = new UnstarEntryResponse { };
            mockGrpcClient.Setup(x => x.UnstarEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnstarEntryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            UnstarEntryResponse responseCallSettings = await client.UnstarEntryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnstarEntryResponse responseCancellationToken = await client.UnstarEntryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnstarEntryResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            UnstarEntryResponse expectedResponse = new UnstarEntryResponse { };
            mockGrpcClient.Setup(x => x.UnstarEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            UnstarEntryResponse response = client.UnstarEntry(request.EntryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnstarEntryResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            UnstarEntryResponse expectedResponse = new UnstarEntryResponse { };
            mockGrpcClient.Setup(x => x.UnstarEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnstarEntryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            UnstarEntryResponse responseCallSettings = await client.UnstarEntryAsync(request.EntryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnstarEntryResponse responseCancellationToken = await client.UnstarEntryAsync(request.EntryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<DataCatalog.DataCatalogClient> mockGrpcClient = new moq::Mock<DataCatalog.DataCatalogClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataCatalogClient client = new DataCatalogClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
