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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ArtifactRegistry.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedArtifactRegistryClientTest
    {
        [xunit::FactAttribute]
        public void GetRepositoryRequestObject()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Yum,
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
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Yum,
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
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Yum,
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
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Yum,
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
        public void GetRepositoryResourceNames()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Yum,
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
            Repository response = client.GetRepository(request.RepositoryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRepositoryResourceNamesAsync()
        {
            moq::Mock<ArtifactRegistry.ArtifactRegistryClient> mockGrpcClient = new moq::Mock<ArtifactRegistry.ArtifactRegistryClient>(moq::MockBehavior.Strict);
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            Repository expectedResponse = new Repository
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Format = Repository.Types.Format.Yum,
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
            Repository responseCallSettings = await client.GetRepositoryAsync(request.RepositoryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Repository responseCancellationToken = await client.GetRepositoryAsync(request.RepositoryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
