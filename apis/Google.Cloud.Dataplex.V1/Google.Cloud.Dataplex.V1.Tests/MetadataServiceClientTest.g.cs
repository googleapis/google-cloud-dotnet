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
        public void CreateEntityRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
                ValidateOnly = true,
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
            mockGrpcClient.Setup(x => x.CreateEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.CreateEntity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
                ValidateOnly = true,
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
            mockGrpcClient.Setup(x => x.CreateEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.CreateEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.CreateEntityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntity()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
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
            mockGrpcClient.Setup(x => x.CreateEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.CreateEntity(request.Parent, request.Entity);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
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
            mockGrpcClient.Setup(x => x.CreateEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.CreateEntityAsync(request.Parent, request.Entity, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.CreateEntityAsync(request.Parent, request.Entity, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
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
            mockGrpcClient.Setup(x => x.CreateEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.CreateEntity(request.ParentAsZoneName, request.Entity);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
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
            mockGrpcClient.Setup(x => x.CreateEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.CreateEntityAsync(request.ParentAsZoneName, request.Entity, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.CreateEntityAsync(request.ParentAsZoneName, request.Entity, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            UpdateEntityRequest request = new UpdateEntityRequest
            {
                Entity = new Entity(),
                ValidateOnly = true,
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
            mockGrpcClient.Setup(x => x.UpdateEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity response = client.UpdateEntity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            UpdateEntityRequest request = new UpdateEntityRequest
            {
                Entity = new Entity(),
                ValidateOnly = true,
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
            mockGrpcClient.Setup(x => x.UpdateEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Entity responseCallSettings = await client.UpdateEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entity responseCancellationToken = await client.UpdateEntityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityRequest request = new DeleteEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntity(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityRequest request = new DeleteEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntity()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityRequest request = new DeleteEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntity(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityRequest request = new DeleteEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntityAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityRequest request = new DeleteEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEntity(request.EntityName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityRequest request = new DeleteEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEntityAsync(request.EntityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityAsync(request.EntityName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

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
        public void CreatePartitionRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreatePartitionRequest request = new CreatePartitionRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new Partition(),
                ValidateOnly = true,
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition response = client.CreatePartition(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePartitionRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreatePartitionRequest request = new CreatePartitionRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new Partition(),
                ValidateOnly = true,
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Partition>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition responseCallSettings = await client.CreatePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Partition responseCancellationToken = await client.CreatePartitionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePartition()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreatePartitionRequest request = new CreatePartitionRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new Partition(),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition response = client.CreatePartition(request.Parent, request.Partition);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePartitionAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreatePartitionRequest request = new CreatePartitionRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new Partition(),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Partition>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition responseCallSettings = await client.CreatePartitionAsync(request.Parent, request.Partition, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Partition responseCancellationToken = await client.CreatePartitionAsync(request.Parent, request.Partition, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePartitionResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreatePartitionRequest request = new CreatePartitionRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new Partition(),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition response = client.CreatePartition(request.ParentAsEntityName, request.Partition);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePartitionResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            CreatePartitionRequest request = new CreatePartitionRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new Partition(),
            };
            Partition expectedResponse = new Partition
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
                Values = { "valueseec79cf0", },
                Location = "locatione09d18d5",
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Partition>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            Partition responseCallSettings = await client.CreatePartitionAsync(request.ParentAsEntityName, request.Partition, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Partition responseCancellationToken = await client.CreatePartitionAsync(request.ParentAsEntityName, request.Partition, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePartitionRequestObject()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeletePartitionRequest request = new DeletePartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePartition(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePartitionRequestObjectAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeletePartitionRequest request = new DeletePartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePartitionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePartition()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeletePartitionRequest request = new DeletePartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePartition(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePartitionAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeletePartitionRequest request = new DeletePartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePartitionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePartitionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePartitionResourceNames()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeletePartitionRequest request = new DeletePartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePartition(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePartition(request.PartitionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePartitionResourceNamesAsync()
        {
            moq::Mock<MetadataService.MetadataServiceClient> mockGrpcClient = new moq::Mock<MetadataService.MetadataServiceClient>(moq::MockBehavior.Strict);
            DeletePartitionRequest request = new DeletePartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePartitionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetadataServiceClient client = new MetadataServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePartitionAsync(request.PartitionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePartitionAsync(request.PartitionName, st::CancellationToken.None);
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
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
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
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
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
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
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
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
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
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
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
#pragma warning disable CS0612
                Etag = "etage8ad7218",
#pragma warning restore CS0612
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
