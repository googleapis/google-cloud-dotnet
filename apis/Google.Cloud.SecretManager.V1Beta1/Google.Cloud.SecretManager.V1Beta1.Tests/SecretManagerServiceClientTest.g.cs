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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.SecretManager.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSecretManagerServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateSecretRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SecretId = "secret_id0fe6a1e4",
                Secret = new Secret(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.CreateSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSecretRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SecretId = "secret_id0fe6a1e4",
                Secret = new Secret(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.CreateSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.CreateSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSecret()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SecretId = "secret_id0fe6a1e4",
                Secret = new Secret(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.CreateSecret(request.Parent, request.SecretId, request.Secret);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSecretAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SecretId = "secret_id0fe6a1e4",
                Secret = new Secret(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.CreateSecretAsync(request.Parent, request.SecretId, request.Secret, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.CreateSecretAsync(request.Parent, request.SecretId, request.Secret, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSecretResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SecretId = "secret_id0fe6a1e4",
                Secret = new Secret(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.CreateSecret(request.ParentAsProjectName, request.SecretId, request.Secret);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSecretResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SecretId = "secret_id0fe6a1e4",
                Secret = new Secret(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.CreateSecretAsync(request.ParentAsProjectName, request.SecretId, request.Secret, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.CreateSecretAsync(request.ParentAsProjectName, request.SecretId, request.Secret, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddSecretVersionRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.AddSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.AddSecretVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddSecretVersionRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.AddSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.AddSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.AddSecretVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddSecretVersion()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.AddSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.AddSecretVersion(request.Parent, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddSecretVersionAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.AddSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.AddSecretVersionAsync(request.Parent, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.AddSecretVersionAsync(request.Parent, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddSecretVersionResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.AddSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.AddSecretVersion(request.ParentAsSecretName, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddSecretVersionResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.AddSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.AddSecretVersionAsync(request.ParentAsSecretName, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.AddSecretVersionAsync(request.ParentAsSecretName, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecretRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.GetSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecretRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.GetSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.GetSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecret()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.GetSecret(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecretAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.GetSecretAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.GetSecretAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecretResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.GetSecret(request.SecretName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecretResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.GetSecretAsync(request.SecretName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.GetSecretAsync(request.SecretName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSecretRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new wkt::FieldMask(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.UpdateSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSecretRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new wkt::FieldMask(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.UpdateSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.UpdateSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSecret()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new wkt::FieldMask(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret response = client.UpdateSecret(request.Secret, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSecretAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new wkt::FieldMask(),
            };
            Secret expectedResponse = new Secret
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                Replication = new Replication(),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Secret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            Secret responseCallSettings = await client.UpdateSecretAsync(request.Secret, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Secret responseCancellationToken = await client.UpdateSecretAsync(request.Secret, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSecretRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSecret(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSecretRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSecretAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSecret()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSecret(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSecretAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSecretAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSecretAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSecretResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSecret(request.SecretName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSecretResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSecretAsync(request.SecretName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSecretAsync(request.SecretName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecretVersionRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.GetSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.GetSecretVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecretVersionRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.GetSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.GetSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.GetSecretVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecretVersion()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.GetSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.GetSecretVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecretVersionAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.GetSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.GetSecretVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.GetSecretVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecretVersionResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.GetSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.GetSecretVersion(request.SecretVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecretVersionResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.GetSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.GetSecretVersionAsync(request.SecretVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.GetSecretVersionAsync(request.SecretVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AccessSecretVersionRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            AccessSecretVersionResponse expectedResponse = new AccessSecretVersionResponse
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                Payload = new SecretPayload(),
            };
            mockGrpcClient.Setup(x => x.AccessSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            AccessSecretVersionResponse response = client.AccessSecretVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AccessSecretVersionRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            AccessSecretVersionResponse expectedResponse = new AccessSecretVersionResponse
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                Payload = new SecretPayload(),
            };
            mockGrpcClient.Setup(x => x.AccessSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessSecretVersionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            AccessSecretVersionResponse responseCallSettings = await client.AccessSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessSecretVersionResponse responseCancellationToken = await client.AccessSecretVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AccessSecretVersion()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            AccessSecretVersionResponse expectedResponse = new AccessSecretVersionResponse
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                Payload = new SecretPayload(),
            };
            mockGrpcClient.Setup(x => x.AccessSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            AccessSecretVersionResponse response = client.AccessSecretVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AccessSecretVersionAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            AccessSecretVersionResponse expectedResponse = new AccessSecretVersionResponse
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                Payload = new SecretPayload(),
            };
            mockGrpcClient.Setup(x => x.AccessSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessSecretVersionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            AccessSecretVersionResponse responseCallSettings = await client.AccessSecretVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessSecretVersionResponse responseCancellationToken = await client.AccessSecretVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AccessSecretVersionResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            AccessSecretVersionResponse expectedResponse = new AccessSecretVersionResponse
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                Payload = new SecretPayload(),
            };
            mockGrpcClient.Setup(x => x.AccessSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            AccessSecretVersionResponse response = client.AccessSecretVersion(request.SecretVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AccessSecretVersionResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            AccessSecretVersionResponse expectedResponse = new AccessSecretVersionResponse
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                Payload = new SecretPayload(),
            };
            mockGrpcClient.Setup(x => x.AccessSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessSecretVersionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            AccessSecretVersionResponse responseCallSettings = await client.AccessSecretVersionAsync(request.SecretVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessSecretVersionResponse responseCancellationToken = await client.AccessSecretVersionAsync(request.SecretVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DisableSecretVersionRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DisableSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.DisableSecretVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DisableSecretVersionRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DisableSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.DisableSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.DisableSecretVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DisableSecretVersion()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DisableSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.DisableSecretVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DisableSecretVersionAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DisableSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.DisableSecretVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.DisableSecretVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DisableSecretVersionResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DisableSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.DisableSecretVersion(request.SecretVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DisableSecretVersionResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DisableSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.DisableSecretVersionAsync(request.SecretVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.DisableSecretVersionAsync(request.SecretVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void EnableSecretVersionRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.EnableSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.EnableSecretVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EnableSecretVersionRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.EnableSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.EnableSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.EnableSecretVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void EnableSecretVersion()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.EnableSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.EnableSecretVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EnableSecretVersionAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.EnableSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.EnableSecretVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.EnableSecretVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void EnableSecretVersionResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.EnableSecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.EnableSecretVersion(request.SecretVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EnableSecretVersionResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.EnableSecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.EnableSecretVersionAsync(request.SecretVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.EnableSecretVersionAsync(request.SecretVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DestroySecretVersionRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DestroySecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.DestroySecretVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DestroySecretVersionRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DestroySecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.DestroySecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.DestroySecretVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DestroySecretVersion()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DestroySecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.DestroySecretVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DestroySecretVersionAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DestroySecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.DestroySecretVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.DestroySecretVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DestroySecretVersionResourceNames()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DestroySecretVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion response = client.DestroySecretVersion(request.SecretVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DestroySecretVersionResourceNamesAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            SecretVersion expectedResponse = new SecretVersion
            {
                SecretVersionName = SecretVersionName.FromProjectSecretSecretVersion("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                State = SecretVersion.Types.State.Disabled,
            };
            mockGrpcClient.Setup(x => x.DestroySecretVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecretVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            SecretVersion responseCallSettings = await client.DestroySecretVersionAsync(request.SecretVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecretVersion responseCancellationToken = await client.DestroySecretVersionAsync(request.SecretVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
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
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
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
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
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
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<SecretManagerService.SecretManagerServiceClient> mockGrpcClient = new moq::Mock<SecretManagerService.SecretManagerServiceClient>(moq::MockBehavior.Strict);
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
            SecretManagerServiceClient client = new SecretManagerServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
