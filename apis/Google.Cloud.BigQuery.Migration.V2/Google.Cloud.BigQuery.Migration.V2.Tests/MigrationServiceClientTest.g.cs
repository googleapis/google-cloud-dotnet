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
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.Migration.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMigrationServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateMigrationWorkflowRequestObject()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow response = client.CreateMigrationWorkflow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMigrationWorkflowRequestObjectAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationWorkflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow responseCallSettings = await client.CreateMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationWorkflow responseCancellationToken = await client.CreateMigrationWorkflowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMigrationWorkflow()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow response = client.CreateMigrationWorkflow(request.Parent, request.MigrationWorkflow);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMigrationWorkflowAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationWorkflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow responseCallSettings = await client.CreateMigrationWorkflowAsync(request.Parent, request.MigrationWorkflow, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationWorkflow responseCancellationToken = await client.CreateMigrationWorkflowAsync(request.Parent, request.MigrationWorkflow, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMigrationWorkflowResourceNames()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow response = client.CreateMigrationWorkflow(request.ParentAsLocationName, request.MigrationWorkflow);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMigrationWorkflowResourceNamesAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationWorkflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow responseCallSettings = await client.CreateMigrationWorkflowAsync(request.ParentAsLocationName, request.MigrationWorkflow, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationWorkflow responseCancellationToken = await client.CreateMigrationWorkflowAsync(request.ParentAsLocationName, request.MigrationWorkflow, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationWorkflowRequestObject()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new wkt::FieldMask(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow response = client.GetMigrationWorkflow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationWorkflowRequestObjectAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new wkt::FieldMask(),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationWorkflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow responseCallSettings = await client.GetMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationWorkflow responseCancellationToken = await client.GetMigrationWorkflowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationWorkflow()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow response = client.GetMigrationWorkflow(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationWorkflowAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationWorkflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow responseCallSettings = await client.GetMigrationWorkflowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationWorkflow responseCancellationToken = await client.GetMigrationWorkflowAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationWorkflowResourceNames()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow response = client.GetMigrationWorkflow(request.MigrationWorkflowName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationWorkflowResourceNamesAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            MigrationWorkflow expectedResponse = new MigrationWorkflow
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Tasks =
                {
                    {
                        "key8a0b6e3c",
                        new MigrationTask()
                    },
                },
                State = MigrationWorkflow.Types.State.Paused,
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationWorkflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationWorkflow responseCallSettings = await client.GetMigrationWorkflowAsync(request.MigrationWorkflowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationWorkflow responseCancellationToken = await client.GetMigrationWorkflowAsync(request.MigrationWorkflowName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMigrationWorkflowRequestObject()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteMigrationWorkflow(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMigrationWorkflowRequestObjectAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMigrationWorkflowAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMigrationWorkflow()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteMigrationWorkflow(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMigrationWorkflowAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteMigrationWorkflowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMigrationWorkflowAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMigrationWorkflowResourceNames()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteMigrationWorkflow(request.MigrationWorkflowName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMigrationWorkflowResourceNamesAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteMigrationWorkflowAsync(request.MigrationWorkflowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMigrationWorkflowAsync(request.MigrationWorkflowName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartMigrationWorkflowRequestObject()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.StartMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            client.StartMigrationWorkflow(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartMigrationWorkflowRequestObjectAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.StartMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.StartMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.StartMigrationWorkflowAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartMigrationWorkflow()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.StartMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            client.StartMigrationWorkflow(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartMigrationWorkflowAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.StartMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.StartMigrationWorkflowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.StartMigrationWorkflowAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartMigrationWorkflowResourceNames()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.StartMigrationWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            client.StartMigrationWorkflow(request.MigrationWorkflowName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartMigrationWorkflowResourceNamesAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.StartMigrationWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.StartMigrationWorkflowAsync(request.MigrationWorkflowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.StartMigrationWorkflowAsync(request.MigrationWorkflowName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationSubtaskRequestObject()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                ReadMask = new wkt::FieldMask(),
            };
            MigrationSubtask expectedResponse = new MigrationSubtask
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                TaskId = "task_idc86c7457",
                Type = "typee2cc9d59",
                State = MigrationSubtask.Types.State.Unspecified,
                ProcessingError = new gr::ErrorInfo(),
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                Metrics = { new TimeSeries(), },
                ResourceErrorDetails =
                {
                    new ResourceErrorDetail(),
                },
                ResourceErrorCount = -1309858018,
            };
            mockGrpcClient.Setup(x => x.GetMigrationSubtask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationSubtask response = client.GetMigrationSubtask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationSubtaskRequestObjectAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                ReadMask = new wkt::FieldMask(),
            };
            MigrationSubtask expectedResponse = new MigrationSubtask
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                TaskId = "task_idc86c7457",
                Type = "typee2cc9d59",
                State = MigrationSubtask.Types.State.Unspecified,
                ProcessingError = new gr::ErrorInfo(),
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                Metrics = { new TimeSeries(), },
                ResourceErrorDetails =
                {
                    new ResourceErrorDetail(),
                },
                ResourceErrorCount = -1309858018,
            };
            mockGrpcClient.Setup(x => x.GetMigrationSubtaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationSubtask>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationSubtask responseCallSettings = await client.GetMigrationSubtaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationSubtask responseCancellationToken = await client.GetMigrationSubtaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationSubtask()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
            };
            MigrationSubtask expectedResponse = new MigrationSubtask
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                TaskId = "task_idc86c7457",
                Type = "typee2cc9d59",
                State = MigrationSubtask.Types.State.Unspecified,
                ProcessingError = new gr::ErrorInfo(),
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                Metrics = { new TimeSeries(), },
                ResourceErrorDetails =
                {
                    new ResourceErrorDetail(),
                },
                ResourceErrorCount = -1309858018,
            };
            mockGrpcClient.Setup(x => x.GetMigrationSubtask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationSubtask response = client.GetMigrationSubtask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationSubtaskAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
            };
            MigrationSubtask expectedResponse = new MigrationSubtask
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                TaskId = "task_idc86c7457",
                Type = "typee2cc9d59",
                State = MigrationSubtask.Types.State.Unspecified,
                ProcessingError = new gr::ErrorInfo(),
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                Metrics = { new TimeSeries(), },
                ResourceErrorDetails =
                {
                    new ResourceErrorDetail(),
                },
                ResourceErrorCount = -1309858018,
            };
            mockGrpcClient.Setup(x => x.GetMigrationSubtaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationSubtask>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationSubtask responseCallSettings = await client.GetMigrationSubtaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationSubtask responseCancellationToken = await client.GetMigrationSubtaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationSubtaskResourceNames()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
            };
            MigrationSubtask expectedResponse = new MigrationSubtask
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                TaskId = "task_idc86c7457",
                Type = "typee2cc9d59",
                State = MigrationSubtask.Types.State.Unspecified,
                ProcessingError = new gr::ErrorInfo(),
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                Metrics = { new TimeSeries(), },
                ResourceErrorDetails =
                {
                    new ResourceErrorDetail(),
                },
                ResourceErrorCount = -1309858018,
            };
            mockGrpcClient.Setup(x => x.GetMigrationSubtask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationSubtask response = client.GetMigrationSubtask(request.MigrationSubtaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationSubtaskResourceNamesAsync()
        {
            moq::Mock<MigrationService.MigrationServiceClient> mockGrpcClient = new moq::Mock<MigrationService.MigrationServiceClient>(moq::MockBehavior.Strict);
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
            };
            MigrationSubtask expectedResponse = new MigrationSubtask
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                TaskId = "task_idc86c7457",
                Type = "typee2cc9d59",
                State = MigrationSubtask.Types.State.Unspecified,
                ProcessingError = new gr::ErrorInfo(),
                CreateTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                Metrics = { new TimeSeries(), },
                ResourceErrorDetails =
                {
                    new ResourceErrorDetail(),
                },
                ResourceErrorCount = -1309858018,
            };
            mockGrpcClient.Setup(x => x.GetMigrationSubtaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationSubtask>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MigrationServiceClient client = new MigrationServiceClientImpl(mockGrpcClient.Object, null, null);
            MigrationSubtask responseCallSettings = await client.GetMigrationSubtaskAsync(request.MigrationSubtaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationSubtask responseCancellationToken = await client.GetMigrationSubtaskAsync(request.MigrationSubtaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
