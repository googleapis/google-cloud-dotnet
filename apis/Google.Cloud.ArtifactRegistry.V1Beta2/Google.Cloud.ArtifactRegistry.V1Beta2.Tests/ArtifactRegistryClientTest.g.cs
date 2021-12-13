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

namespace Google.Cloud.ArtifactRegistry.V1Beta2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedArtifactRegistryClientTest
    {
        [xunit::FactAttribute]
        public void GetRepositoryRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                Name = "name1c9368b0",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.GetRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository response = client.GetRepository(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRepositoryRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                Name = "name1c9368b0",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.GetRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository responseCallSettings = await client.GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.GetRepositoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRepository()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                Name = "name1c9368b0",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.GetRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository response = client.GetRepository(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRepositoryAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                Name = "name1c9368b0",
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.GetRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository responseCallSettings = await client.GetRepositoryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.GetRepositoryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRepositoryRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                Repository = new Repository(),
                UpdateMask = new wkt::FieldMask(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.UpdateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository response = client.UpdateRepository(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRepositoryRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                Repository = new Repository(),
                UpdateMask = new wkt::FieldMask(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.UpdateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository responseCallSettings = await client.UpdateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.UpdateRepositoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRepository()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                Repository = new Repository(),
                UpdateMask = new wkt::FieldMask(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.UpdateRepository(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository response = client.UpdateRepository(request.Repository, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRepositoryAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                Repository = new Repository(),
                UpdateMask = new wkt::FieldMask(),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Docker,
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                KmsKeyName = "kms_key_name06bd122b",
            };
            mockGrpcClient.Setup(x => x.UpdateRepositoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Repository>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Repository responseCallSettings = await client.UpdateRepositoryAsync(request.Repository, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.UpdateRepositoryAsync(request.Repository, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPackageRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPackageRequest request = new GetPackageRequest
            {
                Name = "name1c9368b0",
            };
            Package expectedResponse = new Package
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPackage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Package response = client.GetPackage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPackageRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPackageRequest request = new GetPackageRequest
            {
                Name = "name1c9368b0",
            };
            Package expectedResponse = new Package
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPackageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Package>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Package responseCallSettings = await client.GetPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Package responseCancellationToken = await client.GetPackageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPackage()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPackageRequest request = new GetPackageRequest
            {
                Name = "name1c9368b0",
            };
            Package expectedResponse = new Package
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPackage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Package response = client.GetPackage(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPackageAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPackageRequest request = new GetPackageRequest
            {
                Name = "name1c9368b0",
            };
            Package expectedResponse = new Package
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPackageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Package>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Package responseCallSettings = await client.GetPackageAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Package responseCancellationToken = await client.GetPackageAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVersionRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "name1c9368b0",
                View = VersionView.Basic,
            };
            Version expectedResponse = new Version
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedTags = { new Tag(), },
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Version response = client.GetVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "name1c9368b0",
                View = VersionView.Basic,
            };
            Version expectedResponse = new Version
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedTags = { new Tag(), },
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVersion()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "name1c9368b0",
            };
            Version expectedResponse = new Version
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedTags = { new Tag(), },
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Version response = client.GetVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "name1c9368b0",
            };
            Version expectedResponse = new Version
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedTags = { new Tag(), },
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.GetVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFileRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFileRequest request = new GetFileRequest
            {
                Name = "name1c9368b0",
            };
            File expectedResponse = new File
            {
                FileName = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
                SizeBytes = 4628423819757039038L,
                Hashes = { new Hash(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Owner = "ownere92c1272",
            };
            mockGrpcClient.Setup(x => x.GetFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            File response = client.GetFile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFileRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFileRequest request = new GetFileRequest
            {
                Name = "name1c9368b0",
            };
            File expectedResponse = new File
            {
                FileName = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
                SizeBytes = 4628423819757039038L,
                Hashes = { new Hash(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Owner = "ownere92c1272",
            };
            mockGrpcClient.Setup(x => x.GetFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<File>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            File responseCallSettings = await client.GetFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            File responseCancellationToken = await client.GetFileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFile()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFileRequest request = new GetFileRequest
            {
                Name = "name1c9368b0",
            };
            File expectedResponse = new File
            {
                FileName = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
                SizeBytes = 4628423819757039038L,
                Hashes = { new Hash(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Owner = "ownere92c1272",
            };
            mockGrpcClient.Setup(x => x.GetFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            File response = client.GetFile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFileAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFileRequest request = new GetFileRequest
            {
                Name = "name1c9368b0",
            };
            File expectedResponse = new File
            {
                FileName = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
                SizeBytes = 4628423819757039038L,
                Hashes = { new Hash(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Owner = "ownere92c1272",
            };
            mockGrpcClient.Setup(x => x.GetFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<File>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            File responseCallSettings = await client.GetFileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            File responseCancellationToken = await client.GetFileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTagRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTagRequest request = new GetTagRequest
            {
                Name = "name1c9368b0",
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag response = client.GetTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTagRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTagRequest request = new GetTagRequest
            {
                Name = "name1c9368b0",
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.GetTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.GetTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTag()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTagRequest request = new GetTagRequest
            {
                Name = "name1c9368b0",
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag response = client.GetTag(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTagAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTagRequest request = new GetTagRequest
            {
                Name = "name1c9368b0",
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.GetTagAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.GetTagAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTagRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = "parent7858e4d0",
                TagId = "tag_idbc94f076",
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag response = client.CreateTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = "parent7858e4d0",
                TagId = "tag_idbc94f076",
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.CreateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.CreateTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTag()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = "parent7858e4d0",
                TagId = "tag_idbc94f076",
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag response = client.CreateTag(request.Parent, request.Tag, request.TagId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTagAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = "parent7858e4d0",
                TagId = "tag_idbc94f076",
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.CreateTagAsync(request.Parent, request.Tag, request.TagId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.CreateTagAsync(request.Parent, request.Tag, request.TagId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTagRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag response = client.UpdateTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.UpdateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.UpdateTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTag()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag response = client.UpdateTag(request.Tag, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTagAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name1c9368b0",
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            Tag responseCallSettings = await client.UpdateTagAsync(request.Tag, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tag responseCancellationToken = await client.UpdateTagAsync(request.Tag, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTagRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTagRequest request = new DeleteTagRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            client.DeleteTag(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTagRequest request = new DeleteTagRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTag()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTagRequest request = new DeleteTagRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            client.DeleteTag(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTagAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTagRequest request = new DeleteTagRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTagAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
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
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
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
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
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
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
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
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
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
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
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
            ArtifactRegistryClient client = new ArtifactRegistryClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
