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

namespace Google.Cloud.Dataplex.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMetadataServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetEntityRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                View = GetEntityRequest.Types.EntityView.Basic,
            };
            Entity expectedResponse = new Entity
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Type = Entity.Types.Type.Unspecified,
                Asset = "assetd4344ec0",
                DataPath = "data_path6b0d38a8",
                DataPathPattern = "data_path_pattern534aa82f",
                CatalogEntry = "catalog_entry0c83a523",
                System = StorageSystem.CloudStorage,
                Format = new StorageFormat(),
                Compatibility = new Entity.Types.CompatibilityStatus(),
                Schema = new Schema(),
            };
            mockGrpcClient.Setup(x => x.GetEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.GetEntity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                View = GetEntityRequest.Types.EntityView.Basic,
            };
            Entity expectedResponse = new Entity
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Type = Entity.Types.Type.Unspecified,
                Asset = "assetd4344ec0",
                DataPath = "data_path6b0d38a8",
                DataPathPattern = "data_path_pattern534aa82f",
                CatalogEntry = "catalog_entry0c83a523",
                System = StorageSystem.CloudStorage,
                Format = new StorageFormat(),
                Compatibility = new Entity.Types.CompatibilityStatus(),
                Schema = new Schema(),
            };
            mockGrpcClient.Setup(x => x.GetEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.GetEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.GetEntityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntity()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            Entity expectedResponse = new Entity
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Type = Entity.Types.Type.Unspecified,
                Asset = "assetd4344ec0",
                DataPath = "data_path6b0d38a8",
                DataPathPattern = "data_path_pattern534aa82f",
                CatalogEntry = "catalog_entry0c83a523",
                System = StorageSystem.CloudStorage,
                Format = new StorageFormat(),
                Compatibility = new Entity.Types.CompatibilityStatus(),
                Schema = new Schema(),
            };
            mockGrpcClient.Setup(x => x.GetEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.GetEntity(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            Entity expectedResponse = new Entity
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Type = Entity.Types.Type.Unspecified,
                Asset = "assetd4344ec0",
                DataPath = "data_path6b0d38a8",
                DataPathPattern = "data_path_pattern534aa82f",
                CatalogEntry = "catalog_entry0c83a523",
                System = StorageSystem.CloudStorage,
                Format = new StorageFormat(),
                Compatibility = new Entity.Types.CompatibilityStatus(),
                Schema = new Schema(),
            };
            mockGrpcClient.Setup(x => x.GetEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.GetEntityAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.GetEntityAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            Entity expectedResponse = new Entity
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Type = Entity.Types.Type.Unspecified,
                Asset = "assetd4344ec0",
                DataPath = "data_path6b0d38a8",
                DataPathPattern = "data_path_pattern534aa82f",
                CatalogEntry = "catalog_entry0c83a523",
                System = StorageSystem.CloudStorage,
                Format = new StorageFormat(),
                Compatibility = new Entity.Types.CompatibilityStatus(),
                Schema = new Schema(),
            };
            mockGrpcClient.Setup(x => x.GetEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.GetEntity(request.EntityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            Entity expectedResponse = new Entity
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Type = Entity.Types.Type.Unspecified,
                Asset = "assetd4344ec0",
                DataPath = "data_path6b0d38a8",
                DataPathPattern = "data_path_pattern534aa82f",
                CatalogEntry = "catalog_entry0c83a523",
                System = StorageSystem.CloudStorage,
                Format = new StorageFormat(),
                Compatibility = new Entity.Types.CompatibilityStatus(),
                Schema = new Schema(),
            };
            mockGrpcClient.Setup(x => x.GetEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.GetEntityAsync(request.EntityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.GetEntityAsync(request.EntityName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPartitionRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetPartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition response = client.GetPartition(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPartitionRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetPartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Partition>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition responseCallSettings = await client.GetPartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Partition responseCancellationToken = await client.GetPartitionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPartition()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetPartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition response = client.GetPartition(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPartitionAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetPartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Partition>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition responseCallSettings = await client.GetPartitionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Partition responseCancellationToken = await client.GetPartitionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPartitionResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetPartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition response = client.GetPartition(request.PartitionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPartitionResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetPartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Partition>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition responseCallSettings = await client.GetPartitionAsync(request.PartitionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Partition responseCancellationToken = await client.GetPartitionAsync(request.PartitionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
