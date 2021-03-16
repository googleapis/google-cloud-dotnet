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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataLabeling.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataLabelingServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateDatasetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset
                {
                    DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InputConfigs =
                    {
                        new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                    DataItemCount = -1298706410089620484L,
                },
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.CreateDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.CreateDataset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDatasetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset
                {
                    DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InputConfigs =
                    {
                        new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                    DataItemCount = -1298706410089620484L,
                },
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.CreateDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset responseCallSettings = await client.CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.CreateDatasetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataset()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset
                {
                    DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InputConfigs =
                    {
                        new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                    DataItemCount = -1298706410089620484L,
                },
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.CreateDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.CreateDataset(request.Parent, request.Dataset);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDatasetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset
                {
                    DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InputConfigs =
                    {
                        new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                    DataItemCount = -1298706410089620484L,
                },
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.CreateDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset responseCallSettings = await client.CreateDatasetAsync(request.Parent, request.Dataset, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.CreateDatasetAsync(request.Parent, request.Dataset, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDatasetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset
                {
                    DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InputConfigs =
                    {
                        new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                    DataItemCount = -1298706410089620484L,
                },
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.CreateDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.CreateDataset(request.ParentAsProjectName, request.Dataset);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDatasetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset
                {
                    DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InputConfigs =
                    {
                        new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                    DataItemCount = -1298706410089620484L,
                },
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.CreateDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset responseCallSettings = await client.CreateDatasetAsync(request.ParentAsProjectName, request.Dataset, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.CreateDatasetAsync(request.ParentAsProjectName, request.Dataset, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatasetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.GetDataset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatasetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset responseCallSettings = await client.GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.GetDatasetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataset()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.GetDataset(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatasetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset responseCallSettings = await client.GetDatasetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.GetDatasetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatasetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.GetDataset(request.DatasetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatasetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                InputConfigs =
                {
                    new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
                DataItemCount = -1298706410089620484L,
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Dataset responseCallSettings = await client.GetDatasetAsync(request.DatasetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dataset responseCancellationToken = await client.GetDatasetAsync(request.DatasetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDatasetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDataset(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDatasetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDatasetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataset()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDataset(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDatasetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDatasetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDatasetAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDatasetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDataset(request.DatasetName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDatasetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDatasetAsync(request.DatasetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDatasetAsync(request.DatasetName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataItemRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            DataItem expectedResponse = new DataItem
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetDataItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            DataItem response = client.GetDataItem(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataItemRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            DataItem expectedResponse = new DataItem
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetDataItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            DataItem responseCallSettings = await client.GetDataItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataItem responseCancellationToken = await client.GetDataItemAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataItem()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            DataItem expectedResponse = new DataItem
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetDataItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            DataItem response = client.GetDataItem(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataItemAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            DataItem expectedResponse = new DataItem
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetDataItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            DataItem responseCallSettings = await client.GetDataItemAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataItem responseCancellationToken = await client.GetDataItemAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataItemResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            DataItem expectedResponse = new DataItem
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetDataItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            DataItem response = client.GetDataItem(request.DataItemName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataItemResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            DataItem expectedResponse = new DataItem
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetDataItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            DataItem responseCallSettings = await client.GetDataItemAsync(request.DataItemName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataItem responseCancellationToken = await client.GetDataItemAsync(request.DataItemName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotatedDatasetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            AnnotatedDataset expectedResponse = new AnnotatedDataset
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                DisplayName = "display_name137f65c2",
                AnnotationSource = AnnotationSource.Operator,
                ExampleCount = -5473761259576080533L,
                CompletedExampleCount = 4983637739211990991L,
                LabelStats = new LabelStats
                {
                    ExampleCount =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata
                {
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    PolylineConfig = new PolylineConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    SegmentationConfig = new SegmentationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    VideoClassificationConfig = new VideoClassificationConfig
                    {
                        AnnotationSpecSetConfigs =
                        {
                            new VideoClassificationConfig.Types.AnnotationSpecSetConfig
                            {
                                AnnotationSpecSet = "annotation_spec_set5137ce89",
                                AllowMultiLabel = true,
                            },
                        },
                        ApplyShotDetection = true,
                    },
                    ObjectDetectionConfig = new ObjectDetectionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        ExtractionFrameRate = 1.1203052147209875E+18,
                    },
                    ObjectTrackingConfig = new ObjectTrackingConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                    EventConfig = new EventConfig
                    {
                        AnnotationSpecSets =
                        {
                            "annotation_spec_sets13a5ed0c",
                        },
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    TextEntityExtractionConfig = new TextEntityExtractionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotatedDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotatedDataset response = client.GetAnnotatedDataset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotatedDatasetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            AnnotatedDataset expectedResponse = new AnnotatedDataset
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                DisplayName = "display_name137f65c2",
                AnnotationSource = AnnotationSource.Operator,
                ExampleCount = -5473761259576080533L,
                CompletedExampleCount = 4983637739211990991L,
                LabelStats = new LabelStats
                {
                    ExampleCount =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata
                {
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    PolylineConfig = new PolylineConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    SegmentationConfig = new SegmentationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    VideoClassificationConfig = new VideoClassificationConfig
                    {
                        AnnotationSpecSetConfigs =
                        {
                            new VideoClassificationConfig.Types.AnnotationSpecSetConfig
                            {
                                AnnotationSpecSet = "annotation_spec_set5137ce89",
                                AllowMultiLabel = true,
                            },
                        },
                        ApplyShotDetection = true,
                    },
                    ObjectDetectionConfig = new ObjectDetectionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        ExtractionFrameRate = 1.1203052147209875E+18,
                    },
                    ObjectTrackingConfig = new ObjectTrackingConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                    EventConfig = new EventConfig
                    {
                        AnnotationSpecSets =
                        {
                            "annotation_spec_sets13a5ed0c",
                        },
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    TextEntityExtractionConfig = new TextEntityExtractionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotatedDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotatedDataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotatedDataset responseCallSettings = await client.GetAnnotatedDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotatedDataset responseCancellationToken = await client.GetAnnotatedDatasetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotatedDataset()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            AnnotatedDataset expectedResponse = new AnnotatedDataset
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                DisplayName = "display_name137f65c2",
                AnnotationSource = AnnotationSource.Operator,
                ExampleCount = -5473761259576080533L,
                CompletedExampleCount = 4983637739211990991L,
                LabelStats = new LabelStats
                {
                    ExampleCount =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata
                {
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    PolylineConfig = new PolylineConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    SegmentationConfig = new SegmentationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    VideoClassificationConfig = new VideoClassificationConfig
                    {
                        AnnotationSpecSetConfigs =
                        {
                            new VideoClassificationConfig.Types.AnnotationSpecSetConfig
                            {
                                AnnotationSpecSet = "annotation_spec_set5137ce89",
                                AllowMultiLabel = true,
                            },
                        },
                        ApplyShotDetection = true,
                    },
                    ObjectDetectionConfig = new ObjectDetectionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        ExtractionFrameRate = 1.1203052147209875E+18,
                    },
                    ObjectTrackingConfig = new ObjectTrackingConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                    EventConfig = new EventConfig
                    {
                        AnnotationSpecSets =
                        {
                            "annotation_spec_sets13a5ed0c",
                        },
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    TextEntityExtractionConfig = new TextEntityExtractionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotatedDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotatedDataset response = client.GetAnnotatedDataset(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotatedDatasetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            AnnotatedDataset expectedResponse = new AnnotatedDataset
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                DisplayName = "display_name137f65c2",
                AnnotationSource = AnnotationSource.Operator,
                ExampleCount = -5473761259576080533L,
                CompletedExampleCount = 4983637739211990991L,
                LabelStats = new LabelStats
                {
                    ExampleCount =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata
                {
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    PolylineConfig = new PolylineConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    SegmentationConfig = new SegmentationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    VideoClassificationConfig = new VideoClassificationConfig
                    {
                        AnnotationSpecSetConfigs =
                        {
                            new VideoClassificationConfig.Types.AnnotationSpecSetConfig
                            {
                                AnnotationSpecSet = "annotation_spec_set5137ce89",
                                AllowMultiLabel = true,
                            },
                        },
                        ApplyShotDetection = true,
                    },
                    ObjectDetectionConfig = new ObjectDetectionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        ExtractionFrameRate = 1.1203052147209875E+18,
                    },
                    ObjectTrackingConfig = new ObjectTrackingConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                    EventConfig = new EventConfig
                    {
                        AnnotationSpecSets =
                        {
                            "annotation_spec_sets13a5ed0c",
                        },
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    TextEntityExtractionConfig = new TextEntityExtractionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotatedDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotatedDataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotatedDataset responseCallSettings = await client.GetAnnotatedDatasetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotatedDataset responseCancellationToken = await client.GetAnnotatedDatasetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotatedDatasetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            AnnotatedDataset expectedResponse = new AnnotatedDataset
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                DisplayName = "display_name137f65c2",
                AnnotationSource = AnnotationSource.Operator,
                ExampleCount = -5473761259576080533L,
                CompletedExampleCount = 4983637739211990991L,
                LabelStats = new LabelStats
                {
                    ExampleCount =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata
                {
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    PolylineConfig = new PolylineConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    SegmentationConfig = new SegmentationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    VideoClassificationConfig = new VideoClassificationConfig
                    {
                        AnnotationSpecSetConfigs =
                        {
                            new VideoClassificationConfig.Types.AnnotationSpecSetConfig
                            {
                                AnnotationSpecSet = "annotation_spec_set5137ce89",
                                AllowMultiLabel = true,
                            },
                        },
                        ApplyShotDetection = true,
                    },
                    ObjectDetectionConfig = new ObjectDetectionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        ExtractionFrameRate = 1.1203052147209875E+18,
                    },
                    ObjectTrackingConfig = new ObjectTrackingConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                    EventConfig = new EventConfig
                    {
                        AnnotationSpecSets =
                        {
                            "annotation_spec_sets13a5ed0c",
                        },
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    TextEntityExtractionConfig = new TextEntityExtractionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotatedDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotatedDataset response = client.GetAnnotatedDataset(request.AnnotatedDatasetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotatedDatasetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            AnnotatedDataset expectedResponse = new AnnotatedDataset
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                DisplayName = "display_name137f65c2",
                AnnotationSource = AnnotationSource.Operator,
                ExampleCount = -5473761259576080533L,
                CompletedExampleCount = 4983637739211990991L,
                LabelStats = new LabelStats
                {
                    ExampleCount =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata
                {
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    PolylineConfig = new PolylineConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    SegmentationConfig = new SegmentationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    VideoClassificationConfig = new VideoClassificationConfig
                    {
                        AnnotationSpecSetConfigs =
                        {
                            new VideoClassificationConfig.Types.AnnotationSpecSetConfig
                            {
                                AnnotationSpecSet = "annotation_spec_set5137ce89",
                                AllowMultiLabel = true,
                            },
                        },
                        ApplyShotDetection = true,
                    },
                    ObjectDetectionConfig = new ObjectDetectionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        ExtractionFrameRate = 1.1203052147209875E+18,
                    },
                    ObjectTrackingConfig = new ObjectTrackingConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                    EventConfig = new EventConfig
                    {
                        AnnotationSpecSets =
                        {
                            "annotation_spec_sets13a5ed0c",
                        },
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    TextEntityExtractionConfig = new TextEntityExtractionConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotatedDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotatedDataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotatedDataset responseCallSettings = await client.GetAnnotatedDatasetAsync(request.AnnotatedDatasetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotatedDataset responseCancellationToken = await client.GetAnnotatedDatasetAsync(request.AnnotatedDatasetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnnotatedDatasetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotatedDatasetRequest request = new DeleteAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotatedDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnnotatedDataset(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnnotatedDatasetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotatedDatasetRequest request = new DeleteAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotatedDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnnotatedDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnnotatedDatasetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExampleRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "filtere47ac9b2",
            };
            Example expectedResponse = new Example
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                Annotations =
                {
                    new Annotation
                    {
                        Name = "name1c9368b0",
                        AnnotationSource = AnnotationSource.Operator,
                        AnnotationValue = new AnnotationValue
                        {
                            ImageClassificationAnnotation = new ImageClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            ImageBoundingPolyAnnotation = new ImageBoundingPolyAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                BoundingPoly = new BoundingPoly
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedBoundingPoly = new NormalizedBoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            TextClassificationAnnotation = new TextClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoClassificationAnnotation = new VideoClassificationAnnotation
                            {
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoObjectTrackingAnnotation = new VideoObjectTrackingAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                ObjectTrackingFrames =
                                {
                                    new ObjectTrackingFrame
                                    {
                                        BoundingPoly = new BoundingPoly
                                        {
                                            Vertices =
                                            {
                                                new Vertex
                                                {
                                                    X = 1642386589,
                                                    Y = 1989169729,
                                                },
                                            },
                                        },
                                        NormalizedBoundingPoly = new NormalizedBoundingPoly
                                        {
                                            NormalizedVertices =
                                            {
                                                new NormalizedVertex
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                },
                                            },
                                        },
                                        TimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                            VideoEventAnnotation = new VideoEventAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            ImagePolylineAnnotation = new ImagePolylineAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                Polyline = new Polyline
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedPolyline = new NormalizedPolyline
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            ImageSegmentationAnnotation = new ImageSegmentationAnnotation
                            {
                                AnnotationColors =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AnnotationSpec
                                        {
                                            DisplayName = "display_name137f65c2",
                                            Description = "description2cf9da67",
                                        }
                                    },
                                },
                                MimeType = "mime_type606a0ffc",
                                ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                            },
                            TextEntityExtractionAnnotation = new TextEntityExtractionAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                SequentialSegment = new SequentialSegment
                                {
                                    Start = 1982213098,
                                    End = 337248895,
                                },
                            },
                        },
                        AnnotationMetadata = new AnnotationMetadata
                        {
                            OperatorMetadata = new OperatorMetadata
                            {
                                Score = -5.80354E+17F,
                                TotalVotes = 1079038140,
                                LabelVotes = 778908618,
                                Comments =
                                {
                                    "comments0691d4a5",
                                },
                            },
                        },
                        AnnotationSentiment = AnnotationSentiment.Negative,
                    },
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetExample(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Example response = client.GetExample(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExampleRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "filtere47ac9b2",
            };
            Example expectedResponse = new Example
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                Annotations =
                {
                    new Annotation
                    {
                        Name = "name1c9368b0",
                        AnnotationSource = AnnotationSource.Operator,
                        AnnotationValue = new AnnotationValue
                        {
                            ImageClassificationAnnotation = new ImageClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            ImageBoundingPolyAnnotation = new ImageBoundingPolyAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                BoundingPoly = new BoundingPoly
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedBoundingPoly = new NormalizedBoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            TextClassificationAnnotation = new TextClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoClassificationAnnotation = new VideoClassificationAnnotation
                            {
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoObjectTrackingAnnotation = new VideoObjectTrackingAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                ObjectTrackingFrames =
                                {
                                    new ObjectTrackingFrame
                                    {
                                        BoundingPoly = new BoundingPoly
                                        {
                                            Vertices =
                                            {
                                                new Vertex
                                                {
                                                    X = 1642386589,
                                                    Y = 1989169729,
                                                },
                                            },
                                        },
                                        NormalizedBoundingPoly = new NormalizedBoundingPoly
                                        {
                                            NormalizedVertices =
                                            {
                                                new NormalizedVertex
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                },
                                            },
                                        },
                                        TimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                            VideoEventAnnotation = new VideoEventAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            ImagePolylineAnnotation = new ImagePolylineAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                Polyline = new Polyline
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedPolyline = new NormalizedPolyline
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            ImageSegmentationAnnotation = new ImageSegmentationAnnotation
                            {
                                AnnotationColors =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AnnotationSpec
                                        {
                                            DisplayName = "display_name137f65c2",
                                            Description = "description2cf9da67",
                                        }
                                    },
                                },
                                MimeType = "mime_type606a0ffc",
                                ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                            },
                            TextEntityExtractionAnnotation = new TextEntityExtractionAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                SequentialSegment = new SequentialSegment
                                {
                                    Start = 1982213098,
                                    End = 337248895,
                                },
                            },
                        },
                        AnnotationMetadata = new AnnotationMetadata
                        {
                            OperatorMetadata = new OperatorMetadata
                            {
                                Score = -5.80354E+17F,
                                TotalVotes = 1079038140,
                                LabelVotes = 778908618,
                                Comments =
                                {
                                    "comments0691d4a5",
                                },
                            },
                        },
                        AnnotationSentiment = AnnotationSentiment.Negative,
                    },
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetExampleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Example>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Example responseCallSettings = await client.GetExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Example responseCancellationToken = await client.GetExampleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExample()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "filtere47ac9b2",
            };
            Example expectedResponse = new Example
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                Annotations =
                {
                    new Annotation
                    {
                        Name = "name1c9368b0",
                        AnnotationSource = AnnotationSource.Operator,
                        AnnotationValue = new AnnotationValue
                        {
                            ImageClassificationAnnotation = new ImageClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            ImageBoundingPolyAnnotation = new ImageBoundingPolyAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                BoundingPoly = new BoundingPoly
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedBoundingPoly = new NormalizedBoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            TextClassificationAnnotation = new TextClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoClassificationAnnotation = new VideoClassificationAnnotation
                            {
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoObjectTrackingAnnotation = new VideoObjectTrackingAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                ObjectTrackingFrames =
                                {
                                    new ObjectTrackingFrame
                                    {
                                        BoundingPoly = new BoundingPoly
                                        {
                                            Vertices =
                                            {
                                                new Vertex
                                                {
                                                    X = 1642386589,
                                                    Y = 1989169729,
                                                },
                                            },
                                        },
                                        NormalizedBoundingPoly = new NormalizedBoundingPoly
                                        {
                                            NormalizedVertices =
                                            {
                                                new NormalizedVertex
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                },
                                            },
                                        },
                                        TimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                            VideoEventAnnotation = new VideoEventAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            ImagePolylineAnnotation = new ImagePolylineAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                Polyline = new Polyline
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedPolyline = new NormalizedPolyline
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            ImageSegmentationAnnotation = new ImageSegmentationAnnotation
                            {
                                AnnotationColors =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AnnotationSpec
                                        {
                                            DisplayName = "display_name137f65c2",
                                            Description = "description2cf9da67",
                                        }
                                    },
                                },
                                MimeType = "mime_type606a0ffc",
                                ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                            },
                            TextEntityExtractionAnnotation = new TextEntityExtractionAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                SequentialSegment = new SequentialSegment
                                {
                                    Start = 1982213098,
                                    End = 337248895,
                                },
                            },
                        },
                        AnnotationMetadata = new AnnotationMetadata
                        {
                            OperatorMetadata = new OperatorMetadata
                            {
                                Score = -5.80354E+17F,
                                TotalVotes = 1079038140,
                                LabelVotes = 778908618,
                                Comments =
                                {
                                    "comments0691d4a5",
                                },
                            },
                        },
                        AnnotationSentiment = AnnotationSentiment.Negative,
                    },
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetExample(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Example response = client.GetExample(request.Name, request.Filter);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExampleAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "filtere47ac9b2",
            };
            Example expectedResponse = new Example
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                Annotations =
                {
                    new Annotation
                    {
                        Name = "name1c9368b0",
                        AnnotationSource = AnnotationSource.Operator,
                        AnnotationValue = new AnnotationValue
                        {
                            ImageClassificationAnnotation = new ImageClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            ImageBoundingPolyAnnotation = new ImageBoundingPolyAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                BoundingPoly = new BoundingPoly
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedBoundingPoly = new NormalizedBoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            TextClassificationAnnotation = new TextClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoClassificationAnnotation = new VideoClassificationAnnotation
                            {
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoObjectTrackingAnnotation = new VideoObjectTrackingAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                ObjectTrackingFrames =
                                {
                                    new ObjectTrackingFrame
                                    {
                                        BoundingPoly = new BoundingPoly
                                        {
                                            Vertices =
                                            {
                                                new Vertex
                                                {
                                                    X = 1642386589,
                                                    Y = 1989169729,
                                                },
                                            },
                                        },
                                        NormalizedBoundingPoly = new NormalizedBoundingPoly
                                        {
                                            NormalizedVertices =
                                            {
                                                new NormalizedVertex
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                },
                                            },
                                        },
                                        TimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                            VideoEventAnnotation = new VideoEventAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            ImagePolylineAnnotation = new ImagePolylineAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                Polyline = new Polyline
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedPolyline = new NormalizedPolyline
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            ImageSegmentationAnnotation = new ImageSegmentationAnnotation
                            {
                                AnnotationColors =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AnnotationSpec
                                        {
                                            DisplayName = "display_name137f65c2",
                                            Description = "description2cf9da67",
                                        }
                                    },
                                },
                                MimeType = "mime_type606a0ffc",
                                ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                            },
                            TextEntityExtractionAnnotation = new TextEntityExtractionAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                SequentialSegment = new SequentialSegment
                                {
                                    Start = 1982213098,
                                    End = 337248895,
                                },
                            },
                        },
                        AnnotationMetadata = new AnnotationMetadata
                        {
                            OperatorMetadata = new OperatorMetadata
                            {
                                Score = -5.80354E+17F,
                                TotalVotes = 1079038140,
                                LabelVotes = 778908618,
                                Comments =
                                {
                                    "comments0691d4a5",
                                },
                            },
                        },
                        AnnotationSentiment = AnnotationSentiment.Negative,
                    },
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetExampleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Example>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Example responseCallSettings = await client.GetExampleAsync(request.Name, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Example responseCancellationToken = await client.GetExampleAsync(request.Name, request.Filter, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExampleResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "filtere47ac9b2",
            };
            Example expectedResponse = new Example
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                Annotations =
                {
                    new Annotation
                    {
                        Name = "name1c9368b0",
                        AnnotationSource = AnnotationSource.Operator,
                        AnnotationValue = new AnnotationValue
                        {
                            ImageClassificationAnnotation = new ImageClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            ImageBoundingPolyAnnotation = new ImageBoundingPolyAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                BoundingPoly = new BoundingPoly
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedBoundingPoly = new NormalizedBoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            TextClassificationAnnotation = new TextClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoClassificationAnnotation = new VideoClassificationAnnotation
                            {
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoObjectTrackingAnnotation = new VideoObjectTrackingAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                ObjectTrackingFrames =
                                {
                                    new ObjectTrackingFrame
                                    {
                                        BoundingPoly = new BoundingPoly
                                        {
                                            Vertices =
                                            {
                                                new Vertex
                                                {
                                                    X = 1642386589,
                                                    Y = 1989169729,
                                                },
                                            },
                                        },
                                        NormalizedBoundingPoly = new NormalizedBoundingPoly
                                        {
                                            NormalizedVertices =
                                            {
                                                new NormalizedVertex
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                },
                                            },
                                        },
                                        TimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                            VideoEventAnnotation = new VideoEventAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            ImagePolylineAnnotation = new ImagePolylineAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                Polyline = new Polyline
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedPolyline = new NormalizedPolyline
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            ImageSegmentationAnnotation = new ImageSegmentationAnnotation
                            {
                                AnnotationColors =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AnnotationSpec
                                        {
                                            DisplayName = "display_name137f65c2",
                                            Description = "description2cf9da67",
                                        }
                                    },
                                },
                                MimeType = "mime_type606a0ffc",
                                ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                            },
                            TextEntityExtractionAnnotation = new TextEntityExtractionAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                SequentialSegment = new SequentialSegment
                                {
                                    Start = 1982213098,
                                    End = 337248895,
                                },
                            },
                        },
                        AnnotationMetadata = new AnnotationMetadata
                        {
                            OperatorMetadata = new OperatorMetadata
                            {
                                Score = -5.80354E+17F,
                                TotalVotes = 1079038140,
                                LabelVotes = 778908618,
                                Comments =
                                {
                                    "comments0691d4a5",
                                },
                            },
                        },
                        AnnotationSentiment = AnnotationSentiment.Negative,
                    },
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetExample(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Example response = client.GetExample(request.ExampleName, request.Filter);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExampleResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "filtere47ac9b2",
            };
            Example expectedResponse = new Example
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                ImagePayload = new ImagePayload
                {
                    MimeType = "mime_type606a0ffc",
                    ImageThumbnail = proto::ByteString.CopyFromUtf8("image_thumbnail69b7b0f7"),
                    ImageUri = "image_urieba3b1bc",
                    SignedUri = "signed_urib553b9cf",
                },
                Annotations =
                {
                    new Annotation
                    {
                        Name = "name1c9368b0",
                        AnnotationSource = AnnotationSource.Operator,
                        AnnotationValue = new AnnotationValue
                        {
                            ImageClassificationAnnotation = new ImageClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            ImageBoundingPolyAnnotation = new ImageBoundingPolyAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                BoundingPoly = new BoundingPoly
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedBoundingPoly = new NormalizedBoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            TextClassificationAnnotation = new TextClassificationAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoClassificationAnnotation = new VideoClassificationAnnotation
                            {
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                            },
                            VideoObjectTrackingAnnotation = new VideoObjectTrackingAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                                ObjectTrackingFrames =
                                {
                                    new ObjectTrackingFrame
                                    {
                                        BoundingPoly = new BoundingPoly
                                        {
                                            Vertices =
                                            {
                                                new Vertex
                                                {
                                                    X = 1642386589,
                                                    Y = 1989169729,
                                                },
                                            },
                                        },
                                        NormalizedBoundingPoly = new NormalizedBoundingPoly
                                        {
                                            NormalizedVertices =
                                            {
                                                new NormalizedVertex
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                },
                                            },
                                        },
                                        TimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                            VideoEventAnnotation = new VideoEventAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                TimeSegment = new TimeSegment
                                {
                                    StartTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EndTimeOffset = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            ImagePolylineAnnotation = new ImagePolylineAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                Polyline = new Polyline
                                {
                                    Vertices =
                                    {
                                        new Vertex
                                        {
                                            X = 1642386589,
                                            Y = 1989169729,
                                        },
                                    },
                                },
                                NormalizedPolyline = new NormalizedPolyline
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                            },
                            ImageSegmentationAnnotation = new ImageSegmentationAnnotation
                            {
                                AnnotationColors =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new AnnotationSpec
                                        {
                                            DisplayName = "display_name137f65c2",
                                            Description = "description2cf9da67",
                                        }
                                    },
                                },
                                MimeType = "mime_type606a0ffc",
                                ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                            },
                            TextEntityExtractionAnnotation = new TextEntityExtractionAnnotation
                            {
                                AnnotationSpec = new AnnotationSpec
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                },
                                SequentialSegment = new SequentialSegment
                                {
                                    Start = 1982213098,
                                    End = 337248895,
                                },
                            },
                        },
                        AnnotationMetadata = new AnnotationMetadata
                        {
                            OperatorMetadata = new OperatorMetadata
                            {
                                Score = -5.80354E+17F,
                                TotalVotes = 1079038140,
                                LabelVotes = 778908618,
                                Comments =
                                {
                                    "comments0691d4a5",
                                },
                            },
                        },
                        AnnotationSentiment = AnnotationSentiment.Negative,
                    },
                },
                TextPayload = new TextPayload
                {
                    TextContent = "text_content5b2f6d06",
                },
                VideoPayload = new VideoPayload
                {
                    MimeType = "mime_type606a0ffc",
                    VideoUri = "video_urif4ec0988",
                    VideoThumbnails =
                    {
                        new VideoThumbnail
                        {
                            Thumbnail = proto::ByteString.CopyFromUtf8("thumbnailff4d1d95"),
                            TimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    FrameRate = 2.5591685E+17F,
                    SignedUri = "signed_urib553b9cf",
                },
            };
            mockGrpcClient.Setup(x => x.GetExampleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Example>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Example responseCallSettings = await client.GetExampleAsync(request.ExampleName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Example responseCancellationToken = await client.GetExampleAsync(request.ExampleName, request.Filter, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAnnotationSpecSetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet
                {
                    AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    AnnotationSpecs =
                    {
                        new AnnotationSpec
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                },
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet response = client.CreateAnnotationSpecSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAnnotationSpecSetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet
                {
                    AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    AnnotationSpecs =
                    {
                        new AnnotationSpec
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                },
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpecSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet responseCallSettings = await client.CreateAnnotationSpecSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpecSet responseCancellationToken = await client.CreateAnnotationSpecSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAnnotationSpecSet()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet
                {
                    AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    AnnotationSpecs =
                    {
                        new AnnotationSpec
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                },
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet response = client.CreateAnnotationSpecSet(request.Parent, request.AnnotationSpecSet);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAnnotationSpecSetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet
                {
                    AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    AnnotationSpecs =
                    {
                        new AnnotationSpec
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                },
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpecSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet responseCallSettings = await client.CreateAnnotationSpecSetAsync(request.Parent, request.AnnotationSpecSet, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpecSet responseCancellationToken = await client.CreateAnnotationSpecSetAsync(request.Parent, request.AnnotationSpecSet, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAnnotationSpecSetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet
                {
                    AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    AnnotationSpecs =
                    {
                        new AnnotationSpec
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                },
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet response = client.CreateAnnotationSpecSet(request.ParentAsProjectName, request.AnnotationSpecSet);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAnnotationSpecSetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet
                {
                    AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                    DisplayName = "display_name137f65c2",
                    Description = "description2cf9da67",
                    AnnotationSpecs =
                    {
                        new AnnotationSpec
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                        },
                    },
                    BlockingResources =
                    {
                        "blocking_resourcesa21d409d",
                    },
                },
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpecSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet responseCallSettings = await client.CreateAnnotationSpecSetAsync(request.ParentAsProjectName, request.AnnotationSpecSet, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpecSet responseCancellationToken = await client.CreateAnnotationSpecSetAsync(request.ParentAsProjectName, request.AnnotationSpecSet, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotationSpecSetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet response = client.GetAnnotationSpecSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotationSpecSetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpecSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet responseCallSettings = await client.GetAnnotationSpecSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpecSet responseCancellationToken = await client.GetAnnotationSpecSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotationSpecSet()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet response = client.GetAnnotationSpecSet(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotationSpecSetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpecSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet responseCallSettings = await client.GetAnnotationSpecSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpecSet responseCancellationToken = await client.GetAnnotationSpecSetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnnotationSpecSetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet response = client.GetAnnotationSpecSet(request.AnnotationSpecSetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnnotationSpecSetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                    },
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotationSpecSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecSet responseCallSettings = await client.GetAnnotationSpecSetAsync(request.AnnotationSpecSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotationSpecSet responseCancellationToken = await client.GetAnnotationSpecSetAsync(request.AnnotationSpecSetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnnotationSpecSetRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnnotationSpecSet(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnnotationSpecSetRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnnotationSpecSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnnotationSpecSetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnnotationSpecSet()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnnotationSpecSet(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnnotationSpecSetAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnnotationSpecSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnnotationSpecSetAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnnotationSpecSetResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotationSpecSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnnotationSpecSet(request.AnnotationSpecSetName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnnotationSpecSetResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnnotationSpecSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnnotationSpecSetAsync(request.AnnotationSpecSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnnotationSpecSetAsync(request.AnnotationSpecSetName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstructionRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            Instruction expectedResponse = new Instruction
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction
#pragma warning restore CS0612
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                PdfInstruction = new PdfInstruction
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstruction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Instruction response = client.GetInstruction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstructionRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            Instruction expectedResponse = new Instruction
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction
#pragma warning restore CS0612
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                PdfInstruction = new PdfInstruction
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstructionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instruction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Instruction responseCallSettings = await client.GetInstructionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instruction responseCancellationToken = await client.GetInstructionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstruction()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            Instruction expectedResponse = new Instruction
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction
#pragma warning restore CS0612
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                PdfInstruction = new PdfInstruction
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstruction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Instruction response = client.GetInstruction(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstructionAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            Instruction expectedResponse = new Instruction
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction
#pragma warning restore CS0612
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                PdfInstruction = new PdfInstruction
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstructionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instruction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Instruction responseCallSettings = await client.GetInstructionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instruction responseCancellationToken = await client.GetInstructionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstructionResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            Instruction expectedResponse = new Instruction
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction
#pragma warning restore CS0612
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                PdfInstruction = new PdfInstruction
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstruction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Instruction response = client.GetInstruction(request.InstructionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstructionResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            Instruction expectedResponse = new Instruction
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction
#pragma warning restore CS0612
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                PdfInstruction = new PdfInstruction
                {
                    GcsFileUri = "gcs_file_uri08cbc4a1",
                },
                BlockingResources =
                {
                    "blocking_resourcesa21d409d",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstructionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instruction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Instruction responseCallSettings = await client.GetInstructionAsync(request.InstructionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instruction responseCancellationToken = await client.GetInstructionAsync(request.InstructionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstructionRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstruction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstruction(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstructionRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstructionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstructionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstructionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstruction()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstruction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstruction(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstructionAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstructionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstructionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstructionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstructionResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstruction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstruction(request.InstructionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstructionResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstructionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstructionAsync(request.InstructionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstructionAsync(request.InstructionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvaluationRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            Evaluation expectedResponse = new Evaluation
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Config = new EvaluationConfig
                {
                    BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                    {
                        IouThreshold = -2.1410331E+17F,
                    },
                },
                EvaluationJobRunTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EvaluationMetrics = new EvaluationMetrics
                {
                    ClassificationMetrics = new ClassificationMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                        ConfusionMatrix = new ConfusionMatrix
                        {
                            Row =
                            {
                                new ConfusionMatrix.Types.Row
                                {
                                    AnnotationSpec = new AnnotationSpec
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                    },
                                    Entries =
                                    {
                                        new ConfusionMatrix.Types.ConfusionMatrixEntry
                                        {
                                            AnnotationSpec = new AnnotationSpec
                                            {
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                            },
                                            ItemCount = -1255094419,
                                        },
                                    },
                                },
                            },
                        },
                    },
                    ObjectDetectionMetrics = new ObjectDetectionMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                    },
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                EvaluatedItemCount = -6593700645137490122L,
            };
            mockGrpcClient.Setup(x => x.GetEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Evaluation response = client.GetEvaluation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEvaluationRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            Evaluation expectedResponse = new Evaluation
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Config = new EvaluationConfig
                {
                    BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                    {
                        IouThreshold = -2.1410331E+17F,
                    },
                },
                EvaluationJobRunTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EvaluationMetrics = new EvaluationMetrics
                {
                    ClassificationMetrics = new ClassificationMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                        ConfusionMatrix = new ConfusionMatrix
                        {
                            Row =
                            {
                                new ConfusionMatrix.Types.Row
                                {
                                    AnnotationSpec = new AnnotationSpec
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                    },
                                    Entries =
                                    {
                                        new ConfusionMatrix.Types.ConfusionMatrixEntry
                                        {
                                            AnnotationSpec = new AnnotationSpec
                                            {
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                            },
                                            ItemCount = -1255094419,
                                        },
                                    },
                                },
                            },
                        },
                    },
                    ObjectDetectionMetrics = new ObjectDetectionMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                    },
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                EvaluatedItemCount = -6593700645137490122L,
            };
            mockGrpcClient.Setup(x => x.GetEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Evaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Evaluation responseCallSettings = await client.GetEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Evaluation responseCancellationToken = await client.GetEvaluationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvaluation()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            Evaluation expectedResponse = new Evaluation
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Config = new EvaluationConfig
                {
                    BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                    {
                        IouThreshold = -2.1410331E+17F,
                    },
                },
                EvaluationJobRunTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EvaluationMetrics = new EvaluationMetrics
                {
                    ClassificationMetrics = new ClassificationMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                        ConfusionMatrix = new ConfusionMatrix
                        {
                            Row =
                            {
                                new ConfusionMatrix.Types.Row
                                {
                                    AnnotationSpec = new AnnotationSpec
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                    },
                                    Entries =
                                    {
                                        new ConfusionMatrix.Types.ConfusionMatrixEntry
                                        {
                                            AnnotationSpec = new AnnotationSpec
                                            {
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                            },
                                            ItemCount = -1255094419,
                                        },
                                    },
                                },
                            },
                        },
                    },
                    ObjectDetectionMetrics = new ObjectDetectionMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                    },
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                EvaluatedItemCount = -6593700645137490122L,
            };
            mockGrpcClient.Setup(x => x.GetEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Evaluation response = client.GetEvaluation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEvaluationAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            Evaluation expectedResponse = new Evaluation
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Config = new EvaluationConfig
                {
                    BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                    {
                        IouThreshold = -2.1410331E+17F,
                    },
                },
                EvaluationJobRunTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EvaluationMetrics = new EvaluationMetrics
                {
                    ClassificationMetrics = new ClassificationMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                        ConfusionMatrix = new ConfusionMatrix
                        {
                            Row =
                            {
                                new ConfusionMatrix.Types.Row
                                {
                                    AnnotationSpec = new AnnotationSpec
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                    },
                                    Entries =
                                    {
                                        new ConfusionMatrix.Types.ConfusionMatrixEntry
                                        {
                                            AnnotationSpec = new AnnotationSpec
                                            {
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                            },
                                            ItemCount = -1255094419,
                                        },
                                    },
                                },
                            },
                        },
                    },
                    ObjectDetectionMetrics = new ObjectDetectionMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                    },
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                EvaluatedItemCount = -6593700645137490122L,
            };
            mockGrpcClient.Setup(x => x.GetEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Evaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Evaluation responseCallSettings = await client.GetEvaluationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Evaluation responseCancellationToken = await client.GetEvaluationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvaluationResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            Evaluation expectedResponse = new Evaluation
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Config = new EvaluationConfig
                {
                    BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                    {
                        IouThreshold = -2.1410331E+17F,
                    },
                },
                EvaluationJobRunTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EvaluationMetrics = new EvaluationMetrics
                {
                    ClassificationMetrics = new ClassificationMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                        ConfusionMatrix = new ConfusionMatrix
                        {
                            Row =
                            {
                                new ConfusionMatrix.Types.Row
                                {
                                    AnnotationSpec = new AnnotationSpec
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                    },
                                    Entries =
                                    {
                                        new ConfusionMatrix.Types.ConfusionMatrixEntry
                                        {
                                            AnnotationSpec = new AnnotationSpec
                                            {
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                            },
                                            ItemCount = -1255094419,
                                        },
                                    },
                                },
                            },
                        },
                    },
                    ObjectDetectionMetrics = new ObjectDetectionMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                    },
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                EvaluatedItemCount = -6593700645137490122L,
            };
            mockGrpcClient.Setup(x => x.GetEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Evaluation response = client.GetEvaluation(request.EvaluationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEvaluationResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            Evaluation expectedResponse = new Evaluation
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Config = new EvaluationConfig
                {
                    BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                    {
                        IouThreshold = -2.1410331E+17F,
                    },
                },
                EvaluationJobRunTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EvaluationMetrics = new EvaluationMetrics
                {
                    ClassificationMetrics = new ClassificationMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                        ConfusionMatrix = new ConfusionMatrix
                        {
                            Row =
                            {
                                new ConfusionMatrix.Types.Row
                                {
                                    AnnotationSpec = new AnnotationSpec
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                    },
                                    Entries =
                                    {
                                        new ConfusionMatrix.Types.ConfusionMatrixEntry
                                        {
                                            AnnotationSpec = new AnnotationSpec
                                            {
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                            },
                                            ItemCount = -1255094419,
                                        },
                                    },
                                },
                            },
                        },
                    },
                    ObjectDetectionMetrics = new ObjectDetectionMetrics
                    {
                        PrCurve = new PrCurve
                        {
                            AnnotationSpec = new AnnotationSpec
                            {
                                DisplayName = "display_name137f65c2",
                                Description = "description2cf9da67",
                            },
                            AreaUnderCurve = -4.7771348E+17F,
                            ConfidenceMetricsEntries =
                            {
                                new PrCurve.Types.ConfidenceMetricsEntry
                                {
                                    ConfidenceThreshold = -1.11012796E+18F,
                                    Recall = -1.1387424E+18F,
                                    Precision = -1.13876186E+18F,
                                    F1Score = -3.0822623E+17F,
                                    RecallAt1 = 1.8027053E+17F,
                                    PrecisionAt1 = 1.0815272E+18F,
                                    F1ScoreAt1 = -6.61423E+17F,
                                    RecallAt5 = -3.2754008E+17F,
                                    PrecisionAt5 = -1.1509507E+17F,
                                    F1ScoreAt5 = -5.155E+17F,
                                },
                            },
                            MeanAveragePrecision = 3.3292076E+16F,
                        },
                    },
                },
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                EvaluatedItemCount = -6593700645137490122L,
            };
            mockGrpcClient.Setup(x => x.GetEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Evaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            Evaluation responseCallSettings = await client.GetEvaluationAsync(request.EvaluationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Evaluation responseCancellationToken = await client.GetEvaluationAsync(request.EvaluationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEvaluationJobRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.CreateEvaluationJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEvaluationJobRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.CreateEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.CreateEvaluationJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEvaluationJob()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.CreateEvaluationJob(request.Parent, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEvaluationJobAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.CreateEvaluationJobAsync(request.Parent, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.CreateEvaluationJobAsync(request.Parent, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEvaluationJobResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.CreateEvaluationJob(request.ParentAsProjectName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEvaluationJobResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.CreateEvaluationJobAsync(request.ParentAsProjectName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.CreateEvaluationJobAsync(request.ParentAsProjectName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEvaluationJobRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEvaluationJobRequest request = new UpdateEvaluationJobRequest
            {
                EvaluationJob = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.UpdateEvaluationJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEvaluationJobRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEvaluationJobRequest request = new UpdateEvaluationJobRequest
            {
                EvaluationJob = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.UpdateEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.UpdateEvaluationJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEvaluationJob()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEvaluationJobRequest request = new UpdateEvaluationJobRequest
            {
                EvaluationJob = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.UpdateEvaluationJob(request.EvaluationJob, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEvaluationJobAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEvaluationJobRequest request = new UpdateEvaluationJobRequest
            {
                EvaluationJob = new EvaluationJob
                {
                    EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                    Description = "description2cf9da67",
                    State = EvaluationJob.Types.State.Paused,
                    Schedule = "schedule59559879",
                    ModelVersion = "model_versionc74dd723",
                    EvaluationJobConfig = new EvaluationJobConfig
                    {
                        InputConfig = new InputConfig
                        {
                            DataType = DataType.Video,
                            GcsSource = new GcsSource
                            {
                                InputUri = "input_uriec9462a7",
                                MimeType = "mime_type606a0ffc",
                            },
                            AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                            ClassificationMetadata = new ClassificationMetadata
                            {
                                IsMultiLabel = false,
                            },
                            BigquerySource = new BigQuerySource
                            {
                                InputUri = "input_uriec9462a7",
                            },
                            TextMetadata = new TextMetadata
                            {
                                LanguageCode = "language_code2f6c7160",
                            },
                        },
                        EvaluationConfig = new EvaluationConfig
                        {
                            BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                            {
                                IouThreshold = -2.1410331E+17F,
                            },
                        },
                        HumanAnnotationConfig = new HumanAnnotationConfig
                        {
                            Instruction = "instructionfa6ecc39",
                            AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                            AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                            LabelGroup = "label_groupef150cd3",
                            LanguageCode = "language_code2f6c7160",
                            ReplicaCount = -2132170114,
                            QuestionDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ContributorEmails =
                            {
                                "contributor_emailsa64beb83",
                            },
                            UserEmailAddress = "user_email_address36240c4e",
                        },
                        ImageClassificationConfig = new ImageClassificationConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            AllowMultiLabel = true,
                            AnswerAggregationType = StringAggregationType.NoAggregation,
                        },
                        BoundingPolyConfig = new BoundingPolyConfig
                        {
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            InstructionMessage = "instruction_messagea30fe952",
                        },
                        TextClassificationConfig = new TextClassificationConfig
                        {
                            AllowMultiLabel = true,
                            AnnotationSpecSet = "annotation_spec_set5137ce89",
                            SentimentConfig = new SentimentConfig
                            {
                                EnableLabelSentimentSelection = false,
                            },
                        },
                        BigqueryImportKeys =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        ExampleCount = -1179891861,
                        ExampleSamplePercentage = -4.868342680869164E+17,
                        EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                        {
                            Email = "email7cf5830c",
                            MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                        },
                    },
                    AnnotationSpecSet = "annotation_spec_set5137ce89",
                    LabelMissingGroundTruth = true,
                    Attempts =
                    {
                        new Attempt
                        {
                            AttemptTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PartialFailures =
                            {
                                new gr::Status
                                {
                                    Code = -1805175871,
                                    Message = "message0231e778",
                                    Details =
                                    {
                                        new wkt::Any
                                        {
                                            TypeUrl = "type_urlfde5623b",
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.UpdateEvaluationJobAsync(request.EvaluationJob, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.UpdateEvaluationJobAsync(request.EvaluationJob, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvaluationJobRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.GetEvaluationJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEvaluationJobRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.GetEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.GetEvaluationJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvaluationJob()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.GetEvaluationJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEvaluationJobAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.GetEvaluationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.GetEvaluationJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvaluationJobResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob response = client.GetEvaluationJob(request.EvaluationJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEvaluationJobResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig
                {
                    InputConfig = new InputConfig
                    {
                        DataType = DataType.Video,
                        GcsSource = new GcsSource
                        {
                            InputUri = "input_uriec9462a7",
                            MimeType = "mime_type606a0ffc",
                        },
                        AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                        ClassificationMetadata = new ClassificationMetadata
                        {
                            IsMultiLabel = false,
                        },
                        BigquerySource = new BigQuerySource
                        {
                            InputUri = "input_uriec9462a7",
                        },
                        TextMetadata = new TextMetadata
                        {
                            LanguageCode = "language_code2f6c7160",
                        },
                    },
                    EvaluationConfig = new EvaluationConfig
                    {
                        BoundingBoxEvaluationOptions = new BoundingBoxEvaluationOptions
                        {
                            IouThreshold = -2.1410331E+17F,
                        },
                    },
                    HumanAnnotationConfig = new HumanAnnotationConfig
                    {
                        Instruction = "instructionfa6ecc39",
                        AnnotatedDatasetDisplayName = "annotated_dataset_display_name6e5d1c98",
                        AnnotatedDatasetDescription = "annotated_dataset_descriptionf03c4228",
                        LabelGroup = "label_groupef150cd3",
                        LanguageCode = "language_code2f6c7160",
                        ReplicaCount = -2132170114,
                        QuestionDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ContributorEmails =
                        {
                            "contributor_emailsa64beb83",
                        },
                        UserEmailAddress = "user_email_address36240c4e",
                    },
                    ImageClassificationConfig = new ImageClassificationConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        AllowMultiLabel = true,
                        AnswerAggregationType = StringAggregationType.NoAggregation,
                    },
                    BoundingPolyConfig = new BoundingPolyConfig
                    {
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        InstructionMessage = "instruction_messagea30fe952",
                    },
                    TextClassificationConfig = new TextClassificationConfig
                    {
                        AllowMultiLabel = true,
                        AnnotationSpecSet = "annotation_spec_set5137ce89",
                        SentimentConfig = new SentimentConfig
                        {
                            EnableLabelSentimentSelection = false,
                        },
                    },
                    BigqueryImportKeys =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    ExampleCount = -1179891861,
                    ExampleSamplePercentage = -4.868342680869164E+17,
                    EvaluationJobAlertConfig = new EvaluationJobAlertConfig
                    {
                        Email = "email7cf5830c",
                        MinAcceptableMeanAveragePrecision = -2.8662230132080832E+17,
                    },
                },
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts =
                {
                    new Attempt
                    {
                        AttemptTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        PartialFailures =
                        {
                            new gr::Status
                            {
                                Code = -1805175871,
                                Message = "message0231e778",
                                Details =
                                {
                                    new wkt::Any
                                    {
                                        TypeUrl = "type_urlfde5623b",
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EvaluationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            EvaluationJob responseCallSettings = await client.GetEvaluationJobAsync(request.EvaluationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EvaluationJob responseCancellationToken = await client.GetEvaluationJobAsync(request.EvaluationJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseEvaluationJobRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseEvaluationJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseEvaluationJobRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseEvaluationJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseEvaluationJob()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseEvaluationJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseEvaluationJobAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseEvaluationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseEvaluationJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseEvaluationJobResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseEvaluationJob(request.EvaluationJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseEvaluationJobResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseEvaluationJobAsync(request.EvaluationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseEvaluationJobAsync(request.EvaluationJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeEvaluationJobRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeEvaluationJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeEvaluationJobRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeEvaluationJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeEvaluationJob()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeEvaluationJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeEvaluationJobAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeEvaluationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeEvaluationJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeEvaluationJobResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeEvaluationJob(request.EvaluationJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeEvaluationJobResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeEvaluationJobAsync(request.EvaluationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeEvaluationJobAsync(request.EvaluationJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEvaluationJobRequestObject()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEvaluationJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEvaluationJobRequestObjectAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEvaluationJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEvaluationJob()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEvaluationJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEvaluationJobAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEvaluationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEvaluationJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEvaluationJobResourceNames()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvaluationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEvaluationJob(request.EvaluationJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEvaluationJobResourceNamesAsync()
        {
            moq::Mock<DataLabelingService.DataLabelingServiceClient> mockGrpcClient = new moq::Mock<DataLabelingService.DataLabelingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvaluationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataLabelingServiceClient client = new DataLabelingServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEvaluationJobAsync(request.EvaluationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEvaluationJobAsync(request.EvaluationJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
