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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Functions.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudFunctionsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetFunctionRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            CloudFunction expectedResponse = new CloudFunction
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                SourceArchiveUrl = "source_archive_url88af9b91",
                SourceRepository = new SourceRepository(),
                HttpsTrigger = new HttpsTrigger(),
                EventTrigger = new EventTrigger(),
                Status = CloudFunctionStatus.Offline,
                EntryPoint = "entry_pointb3d450a5",
                Timeout = new wkt::Duration(),
                AvailableMemoryMb = 1905057947,
                ServiceAccountEmail = "service_account_emailb0c3703d",
                UpdateTime = new wkt::Timestamp(),
                VersionId = 8696643459580522033L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceUploadUrl = "source_upload_urle9bc6ad5",
                EnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                Runtime = "runtime2519a6b4",
                MaxInstances = -1449803711,
                VpcConnector = "vpc_connectordc82c0cc",
                VpcConnectorEgressSettings = CloudFunction.Types.VpcConnectorEgressSettings.AllTraffic,
                IngressSettings = CloudFunction.Types.IngressSettings.AllowAll,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                BuildWorkerPool = "build_worker_pool4c1ad1a6",
                BuildId = "build_id2ab7699b",
                BuildEnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SecretEnvironmentVariables = { new SecretEnvVar(), },
                SecretVolumes = { new SecretVolume(), },
                SourceToken = "source_tokenecdd3693",
                MinInstances = 445814344,
                BuildName = "build_namead3cc4b7",
                DockerRepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            mockGrpcClient.Setup(x => x.GetFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CloudFunction response = client.GetFunction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFunctionRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            CloudFunction expectedResponse = new CloudFunction
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                SourceArchiveUrl = "source_archive_url88af9b91",
                SourceRepository = new SourceRepository(),
                HttpsTrigger = new HttpsTrigger(),
                EventTrigger = new EventTrigger(),
                Status = CloudFunctionStatus.Offline,
                EntryPoint = "entry_pointb3d450a5",
                Timeout = new wkt::Duration(),
                AvailableMemoryMb = 1905057947,
                ServiceAccountEmail = "service_account_emailb0c3703d",
                UpdateTime = new wkt::Timestamp(),
                VersionId = 8696643459580522033L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceUploadUrl = "source_upload_urle9bc6ad5",
                EnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                Runtime = "runtime2519a6b4",
                MaxInstances = -1449803711,
                VpcConnector = "vpc_connectordc82c0cc",
                VpcConnectorEgressSettings = CloudFunction.Types.VpcConnectorEgressSettings.AllTraffic,
                IngressSettings = CloudFunction.Types.IngressSettings.AllowAll,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                BuildWorkerPool = "build_worker_pool4c1ad1a6",
                BuildId = "build_id2ab7699b",
                BuildEnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SecretEnvironmentVariables = { new SecretEnvVar(), },
                SecretVolumes = { new SecretVolume(), },
                SourceToken = "source_tokenecdd3693",
                MinInstances = 445814344,
                BuildName = "build_namead3cc4b7",
                DockerRepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            mockGrpcClient.Setup(x => x.GetFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CloudFunction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CloudFunction responseCallSettings = await client.GetFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CloudFunction responseCancellationToken = await client.GetFunctionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFunction()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            CloudFunction expectedResponse = new CloudFunction
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                SourceArchiveUrl = "source_archive_url88af9b91",
                SourceRepository = new SourceRepository(),
                HttpsTrigger = new HttpsTrigger(),
                EventTrigger = new EventTrigger(),
                Status = CloudFunctionStatus.Offline,
                EntryPoint = "entry_pointb3d450a5",
                Timeout = new wkt::Duration(),
                AvailableMemoryMb = 1905057947,
                ServiceAccountEmail = "service_account_emailb0c3703d",
                UpdateTime = new wkt::Timestamp(),
                VersionId = 8696643459580522033L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceUploadUrl = "source_upload_urle9bc6ad5",
                EnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                Runtime = "runtime2519a6b4",
                MaxInstances = -1449803711,
                VpcConnector = "vpc_connectordc82c0cc",
                VpcConnectorEgressSettings = CloudFunction.Types.VpcConnectorEgressSettings.AllTraffic,
                IngressSettings = CloudFunction.Types.IngressSettings.AllowAll,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                BuildWorkerPool = "build_worker_pool4c1ad1a6",
                BuildId = "build_id2ab7699b",
                BuildEnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SecretEnvironmentVariables = { new SecretEnvVar(), },
                SecretVolumes = { new SecretVolume(), },
                SourceToken = "source_tokenecdd3693",
                MinInstances = 445814344,
                BuildName = "build_namead3cc4b7",
                DockerRepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            mockGrpcClient.Setup(x => x.GetFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CloudFunction response = client.GetFunction(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFunctionAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            CloudFunction expectedResponse = new CloudFunction
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                SourceArchiveUrl = "source_archive_url88af9b91",
                SourceRepository = new SourceRepository(),
                HttpsTrigger = new HttpsTrigger(),
                EventTrigger = new EventTrigger(),
                Status = CloudFunctionStatus.Offline,
                EntryPoint = "entry_pointb3d450a5",
                Timeout = new wkt::Duration(),
                AvailableMemoryMb = 1905057947,
                ServiceAccountEmail = "service_account_emailb0c3703d",
                UpdateTime = new wkt::Timestamp(),
                VersionId = 8696643459580522033L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceUploadUrl = "source_upload_urle9bc6ad5",
                EnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                Runtime = "runtime2519a6b4",
                MaxInstances = -1449803711,
                VpcConnector = "vpc_connectordc82c0cc",
                VpcConnectorEgressSettings = CloudFunction.Types.VpcConnectorEgressSettings.AllTraffic,
                IngressSettings = CloudFunction.Types.IngressSettings.AllowAll,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                BuildWorkerPool = "build_worker_pool4c1ad1a6",
                BuildId = "build_id2ab7699b",
                BuildEnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SecretEnvironmentVariables = { new SecretEnvVar(), },
                SecretVolumes = { new SecretVolume(), },
                SourceToken = "source_tokenecdd3693",
                MinInstances = 445814344,
                BuildName = "build_namead3cc4b7",
                DockerRepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            mockGrpcClient.Setup(x => x.GetFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CloudFunction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CloudFunction responseCallSettings = await client.GetFunctionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CloudFunction responseCancellationToken = await client.GetFunctionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFunctionResourceNames()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            CloudFunction expectedResponse = new CloudFunction
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                SourceArchiveUrl = "source_archive_url88af9b91",
                SourceRepository = new SourceRepository(),
                HttpsTrigger = new HttpsTrigger(),
                EventTrigger = new EventTrigger(),
                Status = CloudFunctionStatus.Offline,
                EntryPoint = "entry_pointb3d450a5",
                Timeout = new wkt::Duration(),
                AvailableMemoryMb = 1905057947,
                ServiceAccountEmail = "service_account_emailb0c3703d",
                UpdateTime = new wkt::Timestamp(),
                VersionId = 8696643459580522033L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceUploadUrl = "source_upload_urle9bc6ad5",
                EnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                Runtime = "runtime2519a6b4",
                MaxInstances = -1449803711,
                VpcConnector = "vpc_connectordc82c0cc",
                VpcConnectorEgressSettings = CloudFunction.Types.VpcConnectorEgressSettings.AllTraffic,
                IngressSettings = CloudFunction.Types.IngressSettings.AllowAll,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                BuildWorkerPool = "build_worker_pool4c1ad1a6",
                BuildId = "build_id2ab7699b",
                BuildEnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SecretEnvironmentVariables = { new SecretEnvVar(), },
                SecretVolumes = { new SecretVolume(), },
                SourceToken = "source_tokenecdd3693",
                MinInstances = 445814344,
                BuildName = "build_namead3cc4b7",
                DockerRepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            mockGrpcClient.Setup(x => x.GetFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CloudFunction response = client.GetFunction(request.CloudFunctionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFunctionResourceNamesAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            CloudFunction expectedResponse = new CloudFunction
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Description = "description2cf9da67",
                SourceArchiveUrl = "source_archive_url88af9b91",
                SourceRepository = new SourceRepository(),
                HttpsTrigger = new HttpsTrigger(),
                EventTrigger = new EventTrigger(),
                Status = CloudFunctionStatus.Offline,
                EntryPoint = "entry_pointb3d450a5",
                Timeout = new wkt::Duration(),
                AvailableMemoryMb = 1905057947,
                ServiceAccountEmail = "service_account_emailb0c3703d",
                UpdateTime = new wkt::Timestamp(),
                VersionId = 8696643459580522033L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceUploadUrl = "source_upload_urle9bc6ad5",
                EnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                Runtime = "runtime2519a6b4",
                MaxInstances = -1449803711,
                VpcConnector = "vpc_connectordc82c0cc",
                VpcConnectorEgressSettings = CloudFunction.Types.VpcConnectorEgressSettings.AllTraffic,
                IngressSettings = CloudFunction.Types.IngressSettings.AllowAll,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                BuildWorkerPool = "build_worker_pool4c1ad1a6",
                BuildId = "build_id2ab7699b",
                BuildEnvironmentVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SecretEnvironmentVariables = { new SecretEnvVar(), },
                SecretVolumes = { new SecretVolume(), },
                SourceToken = "source_tokenecdd3693",
                MinInstances = 445814344,
                BuildName = "build_namead3cc4b7",
                DockerRepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            mockGrpcClient.Setup(x => x.GetFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CloudFunction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CloudFunction responseCallSettings = await client.GetFunctionAsync(request.CloudFunctionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CloudFunction responseCancellationToken = await client.GetFunctionAsync(request.CloudFunctionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CallFunctionRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "data387f778d",
            };
            CallFunctionResponse expectedResponse = new CallFunctionResponse
            {
                ExecutionId = "execution_id7e78fb21",
                Result = "result1784a8b4",
                Error = "error0e105ecb",
            };
            mockGrpcClient.Setup(x => x.CallFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CallFunctionResponse response = client.CallFunction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CallFunctionRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "data387f778d",
            };
            CallFunctionResponse expectedResponse = new CallFunctionResponse
            {
                ExecutionId = "execution_id7e78fb21",
                Result = "result1784a8b4",
                Error = "error0e105ecb",
            };
            mockGrpcClient.Setup(x => x.CallFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CallFunctionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CallFunctionResponse responseCallSettings = await client.CallFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CallFunctionResponse responseCancellationToken = await client.CallFunctionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CallFunction()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "data387f778d",
            };
            CallFunctionResponse expectedResponse = new CallFunctionResponse
            {
                ExecutionId = "execution_id7e78fb21",
                Result = "result1784a8b4",
                Error = "error0e105ecb",
            };
            mockGrpcClient.Setup(x => x.CallFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CallFunctionResponse response = client.CallFunction(request.Name, request.Data);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CallFunctionAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "data387f778d",
            };
            CallFunctionResponse expectedResponse = new CallFunctionResponse
            {
                ExecutionId = "execution_id7e78fb21",
                Result = "result1784a8b4",
                Error = "error0e105ecb",
            };
            mockGrpcClient.Setup(x => x.CallFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CallFunctionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CallFunctionResponse responseCallSettings = await client.CallFunctionAsync(request.Name, request.Data, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CallFunctionResponse responseCancellationToken = await client.CallFunctionAsync(request.Name, request.Data, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CallFunctionResourceNames()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "data387f778d",
            };
            CallFunctionResponse expectedResponse = new CallFunctionResponse
            {
                ExecutionId = "execution_id7e78fb21",
                Result = "result1784a8b4",
                Error = "error0e105ecb",
            };
            mockGrpcClient.Setup(x => x.CallFunction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CallFunctionResponse response = client.CallFunction(request.CloudFunctionName, request.Data);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CallFunctionResourceNamesAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "data387f778d",
            };
            CallFunctionResponse expectedResponse = new CallFunctionResponse
            {
                ExecutionId = "execution_id7e78fb21",
                Result = "result1784a8b4",
                Error = "error0e105ecb",
            };
            mockGrpcClient.Setup(x => x.CallFunctionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CallFunctionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            CallFunctionResponse responseCallSettings = await client.CallFunctionAsync(request.CloudFunctionName, request.Data, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CallFunctionResponse responseCancellationToken = await client.CallFunctionAsync(request.CloudFunctionName, request.Data, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateUploadUrlRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                Parent = "parent7858e4d0",
            };
            GenerateUploadUrlResponse expectedResponse = new GenerateUploadUrlResponse
            {
                UploadUrl = "upload_url333fbc45",
            };
            mockGrpcClient.Setup(x => x.GenerateUploadUrl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateUploadUrlResponse response = client.GenerateUploadUrl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateUploadUrlRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                Parent = "parent7858e4d0",
            };
            GenerateUploadUrlResponse expectedResponse = new GenerateUploadUrlResponse
            {
                UploadUrl = "upload_url333fbc45",
            };
            mockGrpcClient.Setup(x => x.GenerateUploadUrlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateUploadUrlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateUploadUrlResponse responseCallSettings = await client.GenerateUploadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateUploadUrlResponse responseCancellationToken = await client.GenerateUploadUrlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateDownloadUrlRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                Name = "name1c9368b0",
                VersionId = 8696643459580522033UL,
            };
            GenerateDownloadUrlResponse expectedResponse = new GenerateDownloadUrlResponse
            {
                DownloadUrl = "download_url0ffcbc1c",
            };
            mockGrpcClient.Setup(x => x.GenerateDownloadUrl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateDownloadUrlResponse response = client.GenerateDownloadUrl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateDownloadUrlRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                Name = "name1c9368b0",
                VersionId = 8696643459580522033UL,
            };
            GenerateDownloadUrlResponse expectedResponse = new GenerateDownloadUrlResponse
            {
                DownloadUrl = "download_url0ffcbc1c",
            };
            mockGrpcClient.Setup(x => x.GenerateDownloadUrlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateDownloadUrlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateDownloadUrlResponse responseCallSettings = await client.GenerateDownloadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateDownloadUrlResponse responseCancellationToken = await client.GenerateDownloadUrlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient> mockGrpcClient = new moq::Mock<CloudFunctionsService.CloudFunctionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFunctionsServiceClient client = new CloudFunctionsServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
