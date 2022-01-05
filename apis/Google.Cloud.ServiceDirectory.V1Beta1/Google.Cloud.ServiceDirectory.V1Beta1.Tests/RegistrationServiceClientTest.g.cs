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

namespace Google.Cloud.ServiceDirectory.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegistrationServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateNamespaceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "namespace_id78177bcf",
                Namespace = new Namespace(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.CreateNamespace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNamespaceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "namespace_id78177bcf",
                Namespace = new Namespace(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.CreateNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.CreateNamespaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNamespace()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "namespace_id78177bcf",
                Namespace = new Namespace(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.CreateNamespace(request.Parent, request.Namespace, request.NamespaceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNamespaceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "namespace_id78177bcf",
                Namespace = new Namespace(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.CreateNamespaceAsync(request.Parent, request.Namespace, request.NamespaceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.CreateNamespaceAsync(request.Parent, request.Namespace, request.NamespaceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNamespaceResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "namespace_id78177bcf",
                Namespace = new Namespace(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.CreateNamespace(request.ParentAsLocationName, request.Namespace, request.NamespaceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNamespaceResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "namespace_id78177bcf",
                Namespace = new Namespace(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.CreateNamespaceAsync(request.ParentAsLocationName, request.Namespace, request.NamespaceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.CreateNamespaceAsync(request.ParentAsLocationName, request.Namespace, request.NamespaceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNamespaceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.GetNamespace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNamespaceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.GetNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.GetNamespaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNamespace()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.GetNamespace(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNamespaceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.GetNamespaceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.GetNamespaceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNamespaceResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.GetNamespace(request.NamespaceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNamespaceResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.GetNamespaceAsync(request.NamespaceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.GetNamespaceAsync(request.NamespaceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNamespaceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new wkt::FieldMask(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.UpdateNamespace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNamespaceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new wkt::FieldMask(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.UpdateNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.UpdateNamespaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNamespace()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new wkt::FieldMask(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace response = client.UpdateNamespace(request.Namespace, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNamespaceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new wkt::FieldMask(),
            };
            Namespace expectedResponse = new Namespace
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Namespace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Namespace responseCallSettings = await client.UpdateNamespaceAsync(request.Namespace, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Namespace responseCancellationToken = await client.UpdateNamespaceAsync(request.Namespace, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNamespaceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNamespace(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNamespaceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNamespaceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNamespace()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNamespace(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNamespaceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNamespaceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNamespaceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNamespaceResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNamespace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNamespace(request.NamespaceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNamespaceResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNamespaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNamespaceAsync(request.NamespaceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNamespaceAsync(request.NamespaceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "service_id291edcb0",
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "service_id291edcb0",
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateService()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "service_id291edcb0",
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.Parent, request.Service, request.ServiceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "service_id291edcb0",
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.Parent, request.Service, request.ServiceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.Parent, request.Service, request.ServiceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "service_id291edcb0",
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.ParentAsNamespaceName, request.Service, request.ServiceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "service_id291edcb0",
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.ParentAsNamespaceName, request.Service, request.ServiceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.ParentAsNamespaceName, request.Service, request.ServiceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetService()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request.ServiceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.ServiceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServiceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new wkt::FieldMask(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.UpdateService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new wkt::FieldMask(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.UpdateServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateService()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new wkt::FieldMask(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.UpdateService(request.Service, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new wkt::FieldMask(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Endpoints = { new Endpoint(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.UpdateServiceAsync(request.Service, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.UpdateServiceAsync(request.Service, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteService()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request.ServiceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request.ServiceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEndpointRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "endpoint_id3e575e95",
                Endpoint = new Endpoint(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.CreateEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEndpointRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "endpoint_id3e575e95",
                Endpoint = new Endpoint(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.CreateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.CreateEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEndpoint()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "endpoint_id3e575e95",
                Endpoint = new Endpoint(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.CreateEndpoint(request.Parent, request.Endpoint, request.EndpointId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEndpointAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "endpoint_id3e575e95",
                Endpoint = new Endpoint(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.CreateEndpointAsync(request.Parent, request.Endpoint, request.EndpointId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.CreateEndpointAsync(request.Parent, request.Endpoint, request.EndpointId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEndpointResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "endpoint_id3e575e95",
                Endpoint = new Endpoint(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.CreateEndpoint(request.ParentAsServiceName, request.Endpoint, request.EndpointId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEndpointResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "endpoint_id3e575e95",
                Endpoint = new Endpoint(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.CreateEndpointAsync(request.ParentAsServiceName, request.Endpoint, request.EndpointId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.CreateEndpointAsync(request.ParentAsServiceName, request.Endpoint, request.EndpointId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpointRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpoint()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpointResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request.EndpointName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request.EndpointName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request.EndpointName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEndpointRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.UpdateEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEndpointRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.UpdateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.UpdateEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEndpoint()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.UpdateEndpoint(request.Endpoint, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEndpointAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
                Address = "address04984d88",
                Port = -78310000,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.UpdateEndpointAsync(request.Endpoint, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.UpdateEndpointAsync(request.Endpoint, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEndpointRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEndpoint(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEndpointRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEndpointAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEndpoint()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEndpoint(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEndpointAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEndpointAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEndpointAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEndpointResourceNames()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteEndpoint(request.EndpointName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEndpointResourceNamesAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteEndpointAsync(request.EndpointName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEndpointAsync(request.EndpointName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
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
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
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
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
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
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
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
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
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
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<RegistrationService.RegistrationServiceClient> mockGrpcClient = new moq::Mock<RegistrationService.RegistrationServiceClient>(moq::MockBehavior.Strict);
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
            RegistrationServiceClient client = new RegistrationServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
