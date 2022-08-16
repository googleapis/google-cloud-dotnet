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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gcl = Google.Cloud.Location;
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
#pragma warning disable CS0612
                Document = new Document(),
#pragma warning restore CS0612
                SkipHumanReview = true,
                InlineDocument = new Document(),
                RawDocument = new RawDocument(),
                FieldMask = new wkt::FieldMask(),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
#pragma warning disable CS0612
                Document = new Document(),
#pragma warning restore CS0612
                SkipHumanReview = true,
                InlineDocument = new Document(),
                RawDocument = new RawDocument(),
                FieldMask = new wkt::FieldMask(),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            ProcessResponse response = client.ProcessDocument(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProcessDocumentResourceNamesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            ProcessResponse responseCallSettings = await client.ProcessDocumentAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessResponse responseCancellationToken = await client.ProcessDocumentAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchProcessorTypesRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
        public void GetProcessorRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            mockGrpcClient.Setup(x => x.GetProcessor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor response = client.GetProcessor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProcessorRequestObjectAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            mockGrpcClient.Setup(x => x.GetProcessorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Processor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor responseCallSettings = await client.GetProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Processor responseCancellationToken = await client.GetProcessorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProcessor()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            mockGrpcClient.Setup(x => x.GetProcessor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor response = client.GetProcessor(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProcessorAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            mockGrpcClient.Setup(x => x.GetProcessorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Processor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor responseCallSettings = await client.GetProcessorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Processor responseCancellationToken = await client.GetProcessorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProcessorResourceNames()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            mockGrpcClient.Setup(x => x.GetProcessor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor response = client.GetProcessor(request.ProcessorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProcessorResourceNamesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            mockGrpcClient.Setup(x => x.GetProcessorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Processor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            Processor responseCallSettings = await client.GetProcessorAsync(request.ProcessorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Processor responseCancellationToken = await client.GetProcessorAsync(request.ProcessorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProcessorVersionRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            ProcessorVersion expectedResponse = new ProcessorVersion
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                DisplayName = "display_name137f65c2",
                State = ProcessorVersion.Types.State.Deleting,
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                KmsKeyVersionName = "kms_key_version_name2851eba8",
                GoogleManaged = true,
                DeprecationInfo = new ProcessorVersion.Types.DeprecationInfo(),
            };
            mockGrpcClient.Setup(x => x.GetProcessorVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessorVersion response = client.GetProcessorVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProcessorVersionRequestObjectAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            ProcessorVersion expectedResponse = new ProcessorVersion
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                DisplayName = "display_name137f65c2",
                State = ProcessorVersion.Types.State.Deleting,
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                KmsKeyVersionName = "kms_key_version_name2851eba8",
                GoogleManaged = true,
                DeprecationInfo = new ProcessorVersion.Types.DeprecationInfo(),
            };
            mockGrpcClient.Setup(x => x.GetProcessorVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProcessorVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessorVersion responseCallSettings = await client.GetProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessorVersion responseCancellationToken = await client.GetProcessorVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProcessorVersion()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            ProcessorVersion expectedResponse = new ProcessorVersion
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                DisplayName = "display_name137f65c2",
                State = ProcessorVersion.Types.State.Deleting,
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                KmsKeyVersionName = "kms_key_version_name2851eba8",
                GoogleManaged = true,
                DeprecationInfo = new ProcessorVersion.Types.DeprecationInfo(),
            };
            mockGrpcClient.Setup(x => x.GetProcessorVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessorVersion response = client.GetProcessorVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProcessorVersionAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            ProcessorVersion expectedResponse = new ProcessorVersion
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                DisplayName = "display_name137f65c2",
                State = ProcessorVersion.Types.State.Deleting,
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                KmsKeyVersionName = "kms_key_version_name2851eba8",
                GoogleManaged = true,
                DeprecationInfo = new ProcessorVersion.Types.DeprecationInfo(),
            };
            mockGrpcClient.Setup(x => x.GetProcessorVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProcessorVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessorVersion responseCallSettings = await client.GetProcessorVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessorVersion responseCancellationToken = await client.GetProcessorVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProcessorVersionResourceNames()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            ProcessorVersion expectedResponse = new ProcessorVersion
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                DisplayName = "display_name137f65c2",
                State = ProcessorVersion.Types.State.Deleting,
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                KmsKeyVersionName = "kms_key_version_name2851eba8",
                GoogleManaged = true,
                DeprecationInfo = new ProcessorVersion.Types.DeprecationInfo(),
            };
            mockGrpcClient.Setup(x => x.GetProcessorVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessorVersion response = client.GetProcessorVersion(request.ProcessorVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProcessorVersionResourceNamesAsync()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            ProcessorVersion expectedResponse = new ProcessorVersion
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                DisplayName = "display_name137f65c2",
                State = ProcessorVersion.Types.State.Deleting,
                CreateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
                KmsKeyVersionName = "kms_key_version_name2851eba8",
                GoogleManaged = true,
                DeprecationInfo = new ProcessorVersion.Types.DeprecationInfo(),
            };
            mockGrpcClient.Setup(x => x.GetProcessorVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProcessorVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentProcessorServiceClient client = new DocumentProcessorServiceClientImpl(mockGrpcClient.Object, null, null);
            ProcessorVersion responseCallSettings = await client.GetProcessorVersionAsync(request.ProcessorVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProcessorVersion responseCancellationToken = await client.GetProcessorVersionAsync(request.ProcessorVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProcessorRequestObject()
        {
            moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient> mockGrpcClient = new moq::Mock<DocumentProcessorService.DocumentProcessorServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
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
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
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
