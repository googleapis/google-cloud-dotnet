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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DocumentAI.V1Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDocumentProcessorServiceClientTest
    {
        [xunit::FactAttribute]
        public void ProcessDocumentRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
#pragma warning disable CS0612
                Document = new Document(),
#pragma warning restore CS0612
                SkipHumanReview = true,
                InlineDocument = new Document(),
                RawDocument = new RawDocument(),
            };
            ProcessResponse expectedResponse = new ProcessResponse
            {
                Document = new Document(),
#pragma warning disable CS0612
                HumanReviewOperation = "human_review_operationb1fb7921",
#pragma warning restore CS0612
                HumanReviewStatus = new HumanReviewStatus(),
            };
            mockGrpcClient.Setup(x => x.ProcessDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessResponse response = client.ProcessDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProcessDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
#pragma warning disable CS0612
                Document = new Document(),
#pragma warning restore CS0612
                SkipHumanReview = true,
                InlineDocument = new Document(),
                RawDocument = new RawDocument(),
            };
            ProcessResponse expectedResponse = new ProcessResponse
            {
                Document = new Document(),
#pragma warning disable CS0612
                HumanReviewOperation = "human_review_operationb1fb7921",
#pragma warning restore CS0612
                HumanReviewStatus = new HumanReviewStatus(),
            };
            mockGrpcClient.Setup(x => x.ProcessDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProcessResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessResponse responseCallSettings = await client.ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessResponse responseCancellationToken = await client.ProcessDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ProcessDocument()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            ProcessResponse expectedResponse = new ProcessResponse
            {
                Document = new Document(),
#pragma warning disable CS0612
                HumanReviewOperation = "human_review_operationb1fb7921",
#pragma warning restore CS0612
                HumanReviewStatus = new HumanReviewStatus(),
            };
            mockGrpcClient.Setup(x => x.ProcessDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessResponse response = client.ProcessDocument(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProcessDocumentAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            ProcessResponse expectedResponse = new ProcessResponse
            {
                Document = new Document(),
#pragma warning disable CS0612
                HumanReviewOperation = "human_review_operationb1fb7921",
#pragma warning restore CS0612
                HumanReviewStatus = new HumanReviewStatus(),
            };
            mockGrpcClient.Setup(x => x.ProcessDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProcessResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessResponse responseCallSettings = await client.ProcessDocumentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessResponse responseCancellationToken = await client.ProcessDocumentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ProcessDocumentResourceNames()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            ProcessResponse expectedResponse = new ProcessResponse
            {
                Document = new Document(),
#pragma warning disable CS0612
                HumanReviewOperation = "human_review_operationb1fb7921",
#pragma warning restore CS0612
                HumanReviewStatus = new HumanReviewStatus(),
            };
            mockGrpcClient.Setup(x => x.ProcessDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessResponse response = client.ProcessDocument(request.ProcessorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProcessDocumentResourceNamesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            ProcessResponse expectedResponse = new ProcessResponse
            {
                Document = new Document(),
#pragma warning disable CS0612
                HumanReviewOperation = "human_review_operationb1fb7921",
#pragma warning restore CS0612
                HumanReviewStatus = new HumanReviewStatus(),
            };
            mockGrpcClient.Setup(x => x.ProcessDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProcessResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessResponse responseCallSettings = await client.ProcessDocumentAsync(request.ProcessorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessResponse responseCancellationToken = await client.ProcessDocumentAsync(request.ProcessorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchProcessorTypesRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            FetchProcessorTypesResponse expectedResponse = new FetchProcessorTypesResponse
            {
                ProcessorTypes =
                {
                    new ProcessorType(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchProcessorTypes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchProcessorTypesResponse response = client.FetchProcessorTypes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchProcessorTypesRequestObjectAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            FetchProcessorTypesResponse expectedResponse = new FetchProcessorTypesResponse
            {
                ProcessorTypes =
                {
                    new ProcessorType(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchProcessorTypesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchProcessorTypesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchProcessorTypesResponse responseCallSettings = await client.FetchProcessorTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchProcessorTypesResponse responseCancellationToken = await client.FetchProcessorTypesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchProcessorTypes()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            FetchProcessorTypesResponse expectedResponse = new FetchProcessorTypesResponse
            {
                ProcessorTypes =
                {
                    new ProcessorType(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchProcessorTypes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchProcessorTypesResponse response = client.FetchProcessorTypes(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchProcessorTypesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            FetchProcessorTypesResponse expectedResponse = new FetchProcessorTypesResponse
            {
                ProcessorTypes =
                {
                    new ProcessorType(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchProcessorTypesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchProcessorTypesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchProcessorTypesResponse responseCallSettings = await client.FetchProcessorTypesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchProcessorTypesResponse responseCancellationToken = await client.FetchProcessorTypesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchProcessorTypesResourceNames()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            FetchProcessorTypesResponse expectedResponse = new FetchProcessorTypesResponse
            {
                ProcessorTypes =
                {
                    new ProcessorType(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchProcessorTypes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchProcessorTypesResponse response = client.FetchProcessorTypes(request.ParentAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchProcessorTypesResourceNamesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            FetchProcessorTypesResponse expectedResponse = new FetchProcessorTypesResponse
            {
                ProcessorTypes =
                {
                    new ProcessorType(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchProcessorTypesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchProcessorTypesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchProcessorTypesResponse responseCallSettings = await client.FetchProcessorTypesAsync(request.ParentAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchProcessorTypesResponse responseCancellationToken = await client.FetchProcessorTypesAsync(request.ParentAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProcessorRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            Processor expectedResponse = new Processor
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                State = Processor.Types.State.Failed,
                ProcessEndpoint = "process_endpoint4445f26d",
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                DefaultProcessorVersion = "default_processor_versiona99cda5e",
            };
            mockGrpcClient.Setup(x => x.CreateProcessor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor response = client.CreateProcessor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProcessorRequestObjectAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            Processor expectedResponse = new Processor
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                State = Processor.Types.State.Failed,
                ProcessEndpoint = "process_endpoint4445f26d",
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                DefaultProcessorVersion = "default_processor_versiona99cda5e",
            };
            mockGrpcClient.Setup(x => x.CreateProcessorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Processor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor responseCallSettings = await client.CreateProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Processor responseCancellationToken = await client.CreateProcessorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProcessor()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            Processor expectedResponse = new Processor
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                State = Processor.Types.State.Failed,
                ProcessEndpoint = "process_endpoint4445f26d",
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                DefaultProcessorVersion = "default_processor_versiona99cda5e",
            };
            mockGrpcClient.Setup(x => x.CreateProcessor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor response = client.CreateProcessor(request.Parent, request.Processor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProcessorAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            Processor expectedResponse = new Processor
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                State = Processor.Types.State.Failed,
                ProcessEndpoint = "process_endpoint4445f26d",
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                DefaultProcessorVersion = "default_processor_versiona99cda5e",
            };
            mockGrpcClient.Setup(x => x.CreateProcessorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Processor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor responseCallSettings = await client.CreateProcessorAsync(request.Parent, request.Processor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Processor responseCancellationToken = await client.CreateProcessorAsync(request.Parent, request.Processor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProcessorResourceNames()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            Processor expectedResponse = new Processor
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                State = Processor.Types.State.Failed,
                ProcessEndpoint = "process_endpoint4445f26d",
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                DefaultProcessorVersion = "default_processor_versiona99cda5e",
            };
            mockGrpcClient.Setup(x => x.CreateProcessor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor response = client.CreateProcessor(request.ParentAsLocationName, request.Processor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProcessorResourceNamesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            Processor expectedResponse = new Processor
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                State = Processor.Types.State.Failed,
                ProcessEndpoint = "process_endpoint4445f26d",
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                DefaultProcessorVersion = "default_processor_versiona99cda5e",
            };
            mockGrpcClient.Setup(x => x.CreateProcessorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Processor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor responseCallSettings = await client.CreateProcessorAsync(request.ParentAsLocationName, request.Processor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Processor responseCancellationToken = await client.CreateProcessorAsync(request.ParentAsLocationName, request.Processor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
