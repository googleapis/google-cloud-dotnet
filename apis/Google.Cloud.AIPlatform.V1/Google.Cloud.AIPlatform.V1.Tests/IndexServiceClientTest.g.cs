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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIndexServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetIndexRequestObject()
        {
            moq::Mock<IndexService.IndexServiceClient> mockGrpcClient = new moq::Mock<IndexService.IndexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                DeployedIndexes =
                {
                    new DeployedIndexRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexServiceClient client = new IndexServiceClientImpl(mockGrpcClient.Object, null, null);
            Index response = client.GetIndex(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexRequestObjectAsync()
        {
            moq::Mock<IndexService.IndexServiceClient> mockGrpcClient = new moq::Mock<IndexService.IndexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                DeployedIndexes =
                {
                    new DeployedIndexRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexServiceClient client = new IndexServiceClientImpl(mockGrpcClient.Object, null, null);
            Index responseCallSettings = await client.GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIndex()
        {
            moq::Mock<IndexService.IndexServiceClient> mockGrpcClient = new moq::Mock<IndexService.IndexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                DeployedIndexes =
                {
                    new DeployedIndexRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexServiceClient client = new IndexServiceClientImpl(mockGrpcClient.Object, null, null);
            Index response = client.GetIndex(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexAsync()
        {
            moq::Mock<IndexService.IndexServiceClient> mockGrpcClient = new moq::Mock<IndexService.IndexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                DeployedIndexes =
                {
                    new DeployedIndexRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexServiceClient client = new IndexServiceClientImpl(mockGrpcClient.Object, null, null);
            Index responseCallSettings = await client.GetIndexAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIndexResourceNames()
        {
            moq::Mock<IndexService.IndexServiceClient> mockGrpcClient = new moq::Mock<IndexService.IndexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                DeployedIndexes =
                {
                    new DeployedIndexRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexServiceClient client = new IndexServiceClientImpl(mockGrpcClient.Object, null, null);
            Index response = client.GetIndex(request.IndexName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexResourceNamesAsync()
        {
            moq::Mock<IndexService.IndexServiceClient> mockGrpcClient = new moq::Mock<IndexService.IndexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                DeployedIndexes =
                {
                    new DeployedIndexRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexServiceClient client = new IndexServiceClientImpl(mockGrpcClient.Object, null, null);
            Index responseCallSettings = await client.GetIndexAsync(request.IndexName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request.IndexName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
