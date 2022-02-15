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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
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
                Dataset = new Dataset(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                Dataset = new Dataset(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                Dataset = new Dataset(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                Dataset = new Dataset(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                Dataset = new Dataset(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                Dataset = new Dataset(),
            };
            Dataset expectedResponse = new Dataset
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                CreateTime = new wkt::Timestamp(),
                InputConfigs = { new InputConfig(), },
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
                ImagePayload = new ImagePayload(),
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                LabelStats = new LabelStats(),
                CreateTime = new wkt::Timestamp(),
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata(),
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
                LabelStats = new LabelStats(),
                CreateTime = new wkt::Timestamp(),
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata(),
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
                LabelStats = new LabelStats(),
                CreateTime = new wkt::Timestamp(),
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata(),
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
                LabelStats = new LabelStats(),
                CreateTime = new wkt::Timestamp(),
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata(),
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
                LabelStats = new LabelStats(),
                CreateTime = new wkt::Timestamp(),
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata(),
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
                LabelStats = new LabelStats(),
                CreateTime = new wkt::Timestamp(),
                AnnotationType = AnnotationType.ImageOrientedBoundingBoxAnnotation,
                Description = "description2cf9da67",
                Metadata = new AnnotatedDatasetMetadata(),
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
                ImagePayload = new ImagePayload(),
                Annotations = { new Annotation(), },
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                Annotations = { new Annotation(), },
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                Annotations = { new Annotation(), },
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                Annotations = { new Annotation(), },
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                Annotations = { new Annotation(), },
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                ImagePayload = new ImagePayload(),
                Annotations = { new Annotation(), },
                TextPayload = new TextPayload(),
                VideoPayload = new VideoPayload(),
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
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec(),
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
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec(),
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
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec(),
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
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec(),
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
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec(),
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
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            AnnotationSpecSet expectedResponse = new AnnotationSpecSet
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                AnnotationSpecs =
                {
                    new AnnotationSpec(),
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
                    new AnnotationSpec(),
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
                    new AnnotationSpec(),
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
                    new AnnotationSpec(),
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
                    new AnnotationSpec(),
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
                    new AnnotationSpec(),
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
                    new AnnotationSpec(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction(),
#pragma warning restore CS0612
                PdfInstruction = new PdfInstruction(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction(),
#pragma warning restore CS0612
                PdfInstruction = new PdfInstruction(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction(),
#pragma warning restore CS0612
                PdfInstruction = new PdfInstruction(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction(),
#pragma warning restore CS0612
                PdfInstruction = new PdfInstruction(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction(),
#pragma warning restore CS0612
                PdfInstruction = new PdfInstruction(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataType = DataType.Video,
#pragma warning disable CS0612
                CsvInstruction = new CsvInstruction(),
#pragma warning restore CS0612
                PdfInstruction = new PdfInstruction(),
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
                Config = new EvaluationConfig(),
                EvaluationJobRunTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                EvaluationMetrics = new EvaluationMetrics(),
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
                Config = new EvaluationConfig(),
                EvaluationJobRunTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                EvaluationMetrics = new EvaluationMetrics(),
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
                Config = new EvaluationConfig(),
                EvaluationJobRunTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                EvaluationMetrics = new EvaluationMetrics(),
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
                Config = new EvaluationConfig(),
                EvaluationJobRunTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                EvaluationMetrics = new EvaluationMetrics(),
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
                Config = new EvaluationConfig(),
                EvaluationJobRunTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                EvaluationMetrics = new EvaluationMetrics(),
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
                Config = new EvaluationConfig(),
                EvaluationJobRunTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                EvaluationMetrics = new EvaluationMetrics(),
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
                Job = new EvaluationJob(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                Job = new EvaluationJob(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                Job = new EvaluationJob(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                Job = new EvaluationJob(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                Job = new EvaluationJob(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                Job = new EvaluationJob(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJob = new EvaluationJob(),
                UpdateMask = new wkt::FieldMask(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJob = new EvaluationJob(),
                UpdateMask = new wkt::FieldMask(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJob = new EvaluationJob(),
                UpdateMask = new wkt::FieldMask(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJob = new EvaluationJob(),
                UpdateMask = new wkt::FieldMask(),
            };
            EvaluationJob expectedResponse = new EvaluationJob
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
                Description = "description2cf9da67",
                State = EvaluationJob.Types.State.Paused,
                Schedule = "schedule59559879",
                ModelVersion = "model_versionc74dd723",
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
                EvaluationJobConfig = new EvaluationJobConfig(),
                AnnotationSpecSet = "annotation_spec_set5137ce89",
                LabelMissingGroundTruth = true,
                Attempts = { new Attempt(), },
                CreateTime = new wkt::Timestamp(),
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
