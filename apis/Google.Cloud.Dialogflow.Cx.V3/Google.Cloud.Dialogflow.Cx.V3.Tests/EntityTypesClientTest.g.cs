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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEntityTypesClientTest
    {
        [xunit::FactAttribute]
        public void GetEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityType()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityTypeResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.GetEntityType(request.EntityTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityTypeResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.GetEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.GetEntityTypeAsync(request.EntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.GetEntityTypeAsync(request.EntityTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityType()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request.Parent, request.EntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityTypeAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request.Parent, request.EntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request.Parent, request.EntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityTypeResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.CreateEntityType(request.ParentAsAgentName, request.EntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityTypeResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.CreateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.CreateEntityTypeAsync(request.ParentAsAgentName, request.EntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.CreateEntityTypeAsync(request.ParentAsAgentName, request.EntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.UpdateEntityType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEntityType()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType response = client.UpdateEntityType(request.EntityType, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEntityTypeAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new wkt::FieldMask(),
            };
            EntityType expectedResponse = new EntityType
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                DisplayName = "display_name137f65c2",
                Kind = EntityType.Types.Kind.Regexp,
                AutoExpansionMode = EntityType.Types.AutoExpansionMode.Default,
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                ExcludedPhrases =
                {
                    new EntityType.Types.ExcludedPhrase(),
                },
                EnableFuzzyExtraction = false,
                Redact = true,
            };
            mockGrpcClient.Setup(x => x.UpdateEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            EntityType responseCallSettings = await client.UpdateEntityTypeAsync(request.EntityType, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityType responseCancellationToken = await client.UpdateEntityTypeAsync(request.EntityType, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityTypeRequestObject()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityType(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityTypeRequestObjectAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityTypeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityType()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityType(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityTypeAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityTypeAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityTypeResourceNames()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityType(request.EntityTypeName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityTypeResourceNamesAsync()
        {
            moq::Mock<EntityTypes.EntityTypesClient> mockGrpcClient = new moq::Mock<EntityTypes.EntityTypesClient>(moq::MockBehavior.Strict);
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EntityTypesClient client = new EntityTypesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityTypeAsync(request.EntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityTypeAsync(request.EntityTypeName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
