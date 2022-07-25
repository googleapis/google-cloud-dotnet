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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Functions.V2Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFunctionServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetFunctionRequestObject()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            Function expectedResponse = new Function
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                BuildConfig = new BuildConfig(),
                ServiceConfig = new ServiceConfig(),
                EventTrigger = new EventTrigger(),
                State = Function.Types.State.Unspecified,
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                StateMessages = { new StateMessage(), },
                Environment = Environment.Gen1,
            };
            mockGrpcClient.Setup(x => x.GetFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            Function response = client.GetFunction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFunctionRequestObjectAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            Function expectedResponse = new Function
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                BuildConfig = new BuildConfig(),
                ServiceConfig = new ServiceConfig(),
                EventTrigger = new EventTrigger(),
                State = Function.Types.State.Unspecified,
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                StateMessages = { new StateMessage(), },
                Environment = Environment.Gen1,
            };
            mockGrpcClient.Setup(x => x.GetFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Function>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            Function responseCallSettings = await client.GetFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Function responseCancellationToken = await client.GetFunctionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFunction()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            Function expectedResponse = new Function
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                BuildConfig = new BuildConfig(),
                ServiceConfig = new ServiceConfig(),
                EventTrigger = new EventTrigger(),
                State = Function.Types.State.Unspecified,
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                StateMessages = { new StateMessage(), },
                Environment = Environment.Gen1,
            };
            mockGrpcClient.Setup(x => x.GetFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            Function response = client.GetFunction(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFunctionAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            Function expectedResponse = new Function
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                BuildConfig = new BuildConfig(),
                ServiceConfig = new ServiceConfig(),
                EventTrigger = new EventTrigger(),
                State = Function.Types.State.Unspecified,
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                StateMessages = { new StateMessage(), },
                Environment = Environment.Gen1,
            };
            mockGrpcClient.Setup(x => x.GetFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Function>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            Function responseCallSettings = await client.GetFunctionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Function responseCancellationToken = await client.GetFunctionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFunctionResourceNames()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            Function expectedResponse = new Function
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                BuildConfig = new BuildConfig(),
                ServiceConfig = new ServiceConfig(),
                EventTrigger = new EventTrigger(),
                State = Function.Types.State.Unspecified,
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                StateMessages = { new StateMessage(), },
                Environment = Environment.Gen1,
            };
            mockGrpcClient.Setup(x => x.GetFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            Function response = client.GetFunction(request.FunctionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFunctionResourceNamesAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            Function expectedResponse = new Function
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                BuildConfig = new BuildConfig(),
                ServiceConfig = new ServiceConfig(),
                EventTrigger = new EventTrigger(),
                State = Function.Types.State.Unspecified,
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                StateMessages = { new StateMessage(), },
                Environment = Environment.Gen1,
            };
            mockGrpcClient.Setup(x => x.GetFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Function>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            Function responseCallSettings = await client.GetFunctionAsync(request.FunctionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Function responseCancellationToken = await client.GetFunctionAsync(request.FunctionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateUploadUrlRequestObject()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            GenerateUploadUrlResponse expectedResponse = new GenerateUploadUrlResponse
            {
                UploadUrl = "upload_url333fbc45",
                StorageSource = new StorageSource(),
            };
            mockGrpcClient.Setup(x => x.GenerateUploadUrl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            GenerateUploadUrlResponse response = client.GenerateUploadUrl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateUploadUrlRequestObjectAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            GenerateUploadUrlResponse expectedResponse = new GenerateUploadUrlResponse
            {
                UploadUrl = "upload_url333fbc45",
                StorageSource = new StorageSource(),
            };
            mockGrpcClient.Setup(x => x.GenerateUploadUrlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateUploadUrlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            GenerateUploadUrlResponse responseCallSettings = await client.GenerateUploadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateUploadUrlResponse responseCancellationToken = await client.GenerateUploadUrlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateDownloadUrlRequestObject()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            GenerateDownloadUrlResponse expectedResponse = new GenerateDownloadUrlResponse
            {
                DownloadUrl = "download_url0ffcbc1c",
            };
            mockGrpcClient.Setup(x => x.GenerateDownloadUrl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            GenerateDownloadUrlResponse response = client.GenerateDownloadUrl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateDownloadUrlRequestObjectAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            GenerateDownloadUrlResponse expectedResponse = new GenerateDownloadUrlResponse
            {
                DownloadUrl = "download_url0ffcbc1c",
            };
            mockGrpcClient.Setup(x => x.GenerateDownloadUrlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateDownloadUrlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            GenerateDownloadUrlResponse responseCallSettings = await client.GenerateDownloadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateDownloadUrlResponse responseCancellationToken = await client.GenerateDownloadUrlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRuntimesRequestObject()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "filtere47ac9b2",
            };
            ListRuntimesResponse expectedResponse = new ListRuntimesResponse
            {
                Runtimes =
                {
                    new ListRuntimesResponse.Types.Runtime(),
                },
            };
            mockGrpcClient.Setup(x => x.ListRuntimes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            ListRuntimesResponse response = client.ListRuntimes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRuntimesRequestObjectAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "filtere47ac9b2",
            };
            ListRuntimesResponse expectedResponse = new ListRuntimesResponse
            {
                Runtimes =
                {
                    new ListRuntimesResponse.Types.Runtime(),
                },
            };
            mockGrpcClient.Setup(x => x.ListRuntimesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListRuntimesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            ListRuntimesResponse responseCallSettings = await client.ListRuntimesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListRuntimesResponse responseCancellationToken = await client.ListRuntimesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRuntimes()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListRuntimesResponse expectedResponse = new ListRuntimesResponse
            {
                Runtimes =
                {
                    new ListRuntimesResponse.Types.Runtime(),
                },
            };
            mockGrpcClient.Setup(x => x.ListRuntimes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            ListRuntimesResponse response = client.ListRuntimes(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRuntimesAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListRuntimesResponse expectedResponse = new ListRuntimesResponse
            {
                Runtimes =
                {
                    new ListRuntimesResponse.Types.Runtime(),
                },
            };
            mockGrpcClient.Setup(x => x.ListRuntimesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListRuntimesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            ListRuntimesResponse responseCallSettings = await client.ListRuntimesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListRuntimesResponse responseCancellationToken = await client.ListRuntimesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRuntimesResourceNames()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListRuntimesResponse expectedResponse = new ListRuntimesResponse
            {
                Runtimes =
                {
                    new ListRuntimesResponse.Types.Runtime(),
                },
            };
            mockGrpcClient.Setup(x => x.ListRuntimes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            ListRuntimesResponse response = client.ListRuntimes(request.ParentAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRuntimesResourceNamesAsync()
        {
            moq::Mock<FunctionService.FunctionServiceClient> mockGrpcClient = new moq::Mock<FunctionService.FunctionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListRuntimesResponse expectedResponse = new ListRuntimesResponse
            {
                Runtimes =
                {
                    new ListRuntimesResponse.Types.Runtime(),
                },
            };
            mockGrpcClient.Setup(x => x.ListRuntimesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListRuntimesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FunctionServiceClient client = new FunctionServiceClientImpl(mockGrpcClient.Object, null, null);
            ListRuntimesResponse responseCallSettings = await client.ListRuntimesAsync(request.ParentAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListRuntimesResponse responseCancellationToken = await client.ListRuntimesAsync(request.ParentAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
