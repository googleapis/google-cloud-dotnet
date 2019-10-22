// Copyright 2019 Google LLC
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

namespace Google.Cloud.AutoML.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.AutoML.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedAutoMlClientTest
    {
        [Fact]
        public void UpdateDataset()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateDatasetRequest expectedRequest = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateDataset(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            Dataset response = client.UpdateDataset(dataset, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateDatasetAsync()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateDatasetRequest expectedRequest = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateDatasetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Dataset>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            Dataset response = await client.UpdateDatasetAsync(dataset, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateDataset2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateDataset(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.UpdateDataset(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateDatasetAsync2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateDatasetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Dataset>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Dataset response = await client.UpdateDatasetAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDataset()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatasetRequest expectedRequest = new GetDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetDataset(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            Dataset response = client.GetDataset(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDatasetAsync()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatasetRequest expectedRequest = new GetDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Dataset>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            Dataset response = await client.GetDatasetAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDataset2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetDataset(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Dataset response = client.GetDataset(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDatasetAsync2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            Dataset expectedResponse = new Dataset
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ExampleCount = 1517063674,
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetDatasetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Dataset>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Dataset response = await client.GetDatasetAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAnnotationSpec()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest expectedRequest = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                ExampleCount = 1517063674,
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpec(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecName name = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]");
            AnnotationSpec response = client.GetAnnotationSpec(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAnnotationSpecAsync()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest expectedRequest = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                ExampleCount = 1517063674,
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotationSpec>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            AnnotationSpecName name = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]");
            AnnotationSpec response = await client.GetAnnotationSpecAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAnnotationSpec2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                ExampleCount = 1517063674,
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpec(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            AnnotationSpec response = client.GetAnnotationSpec(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAnnotationSpecAsync2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            AnnotationSpec expectedResponse = new AnnotationSpec
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                ExampleCount = 1517063674,
            };
            mockGrpcClient.Setup(x => x.GetAnnotationSpecAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotationSpec>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            AnnotationSpec response = await client.GetAnnotationSpecAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetModel()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelRequest expectedRequest = new GetModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetModel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            Model response = client.GetModel(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetModelAsync()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelRequest expectedRequest = new GetModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Model>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            Model response = await client.GetModelAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetModel2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetModel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Model response = client.GetModel(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetModelAsync2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Model>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Model response = await client.GetModelAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateModel()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateModelRequest expectedRequest = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            Model expectedResponse = new Model
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateModel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            Model response = client.UpdateModel(model, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateModelAsync()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateModelRequest expectedRequest = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            Model expectedResponse = new Model
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateModelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Model>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            Model response = await client.UpdateModelAsync(model, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateModel2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            Model expectedResponse = new Model
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateModel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Model response = client.UpdateModel(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateModelAsync2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            Model expectedResponse = new Model
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                DatasetId = "datasetId-2115646910",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateModelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Model>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            Model response = await client.UpdateModelAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetModelEvaluation()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelEvaluationRequest expectedRequest = new GetModelEvaluationRequest
            {
                ModelEvaluationName = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                Name = "name2-1052831874",
                AnnotationSpecId = "annotationSpecId60690191",
                DisplayName = "displayName1615086568",
                EvaluatedExampleCount = 277565350,
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationName name = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]");
            ModelEvaluation response = client.GetModelEvaluation(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetModelEvaluationAsync()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelEvaluationRequest expectedRequest = new GetModelEvaluationRequest
            {
                ModelEvaluationName = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                Name = "name2-1052831874",
                AnnotationSpecId = "annotationSpecId60690191",
                DisplayName = "displayName1615086568",
                EvaluatedExampleCount = 277565350,
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ModelEvaluation>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationName name = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]");
            ModelEvaluation response = await client.GetModelEvaluationAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetModelEvaluation2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                Name = "name2-1052831874",
                AnnotationSpecId = "annotationSpecId60690191",
                DisplayName = "displayName1615086568",
                EvaluatedExampleCount = 277565350,
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.GetModelEvaluation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetModelEvaluationAsync2()
        {
            Mock<AutoMl.AutoMlClient> mockGrpcClient = new Mock<AutoMl.AutoMlClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                Name = "name2-1052831874",
                AnnotationSpecId = "annotationSpecId60690191",
                DisplayName = "displayName1615086568",
                EvaluatedExampleCount = 277565350,
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ModelEvaluation>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoMlClient client = new AutoMlClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = await client.GetModelEvaluationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
