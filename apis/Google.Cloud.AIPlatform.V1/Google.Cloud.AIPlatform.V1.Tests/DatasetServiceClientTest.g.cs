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

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDatasetServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetDatasetRequestObject()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ReadMask = new wkt::FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset response = client.GetDataset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatasetRequestObjectAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ReadMask = new wkt::FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset responseCallSettings = await client.GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.GetDatasetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataset()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset response = client.GetDataset(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatasetAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset responseCallSettings = await client.GetDatasetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.GetDatasetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatasetResourceNames()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset response = client.GetDataset(request.DatasetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatasetResourceNamesAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset responseCallSettings = await client.GetDatasetAsync(request.DatasetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.GetDatasetAsync(request.DatasetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDatasetRequestObject()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new wkt::FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset response = client.UpdateDataset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDatasetRequestObjectAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new wkt::FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset responseCallSettings = await client.UpdateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.UpdateDatasetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataset()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new wkt::FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset response = client.UpdateDataset(request.Dataset, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDatasetAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new wkt::FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Value(),
                EncryptionSpec = new EncryptionSpec(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            Dataset responseCallSettings = await client.UpdateDatasetAsync(request.Dataset, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.UpdateDatasetAsync(request.Dataset, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotationSpecRequestObject()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                ReadMask = new wkt::FieldMask(),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnnotationSpec response = client.GetAnnotationSpec(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotationSpecRequestObjectAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                ReadMask = new wkt::FieldMask(),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnnotationSpec responseCallSettings = await client.GetAnnotationSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpec responseCancellationToken = await client.GetAnnotationSpecAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotationSpec()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnnotationSpec response = client.GetAnnotationSpec(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotationSpecAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnnotationSpec responseCallSettings = await client.GetAnnotationSpecAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpec responseCancellationToken = await client.GetAnnotationSpecAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotationSpecResourceNames()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnnotationSpec response = client.GetAnnotationSpec(request.AnnotationSpecName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotationSpecResourceNamesAsync()
        {
            moq::Mock<DatasetService.DatasetServiceClient> mockGrpcClient = new moq::Mock<DatasetService.DatasetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatasetServiceClient client = new DatasetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnnotationSpec responseCallSettings = await client.GetAnnotationSpecAsync(request.AnnotationSpecName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpec responseCancellationToken = await client.GetAnnotationSpecAsync(request.AnnotationSpecName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
