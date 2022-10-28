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

namespace Google.Cloud.EnterpriseKnowledgeGraph.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEnterpriseKnowledgeGraphServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateEntityReconciliationJobRequestObject()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob response = client.CreateEntityReconciliationJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityReconciliationJobRequestObjectAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityReconciliationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob responseCallSettings = await client.CreateEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityReconciliationJob responseCancellationToken = await client.CreateEntityReconciliationJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityReconciliationJob()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob response = client.CreateEntityReconciliationJob(request.Parent, request.EntityReconciliationJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityReconciliationJobAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityReconciliationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob responseCallSettings = await client.CreateEntityReconciliationJobAsync(request.Parent, request.EntityReconciliationJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityReconciliationJob responseCancellationToken = await client.CreateEntityReconciliationJobAsync(request.Parent, request.EntityReconciliationJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEntityReconciliationJobResourceNames()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob response = client.CreateEntityReconciliationJob(request.ParentAsLocationName, request.EntityReconciliationJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEntityReconciliationJobResourceNamesAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityReconciliationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob responseCallSettings = await client.CreateEntityReconciliationJobAsync(request.ParentAsLocationName, request.EntityReconciliationJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityReconciliationJob responseCancellationToken = await client.CreateEntityReconciliationJobAsync(request.ParentAsLocationName, request.EntityReconciliationJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityReconciliationJobRequestObject()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.GetEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob response = client.GetEntityReconciliationJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityReconciliationJobRequestObjectAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.GetEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityReconciliationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob responseCallSettings = await client.GetEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityReconciliationJob responseCancellationToken = await client.GetEntityReconciliationJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityReconciliationJob()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.GetEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob response = client.GetEntityReconciliationJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityReconciliationJobAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.GetEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityReconciliationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob responseCallSettings = await client.GetEntityReconciliationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityReconciliationJob responseCancellationToken = await client.GetEntityReconciliationJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntityReconciliationJobResourceNames()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.GetEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob response = client.GetEntityReconciliationJob(request.EntityReconciliationJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntityReconciliationJobResourceNamesAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            EntityReconciliationJob expectedResponse = new EntityReconciliationJob
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                State = JobState.Clustering,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReconConfig = new ReconConfig(),
            };
            mockGrpcClient.Setup(x => x.GetEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EntityReconciliationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            EntityReconciliationJob responseCallSettings = await client.GetEntityReconciliationJobAsync(request.EntityReconciliationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EntityReconciliationJob responseCancellationToken = await client.GetEntityReconciliationJobAsync(request.EntityReconciliationJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelEntityReconciliationJobRequestObject()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelEntityReconciliationJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelEntityReconciliationJobRequestObjectAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelEntityReconciliationJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelEntityReconciliationJob()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelEntityReconciliationJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelEntityReconciliationJobAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelEntityReconciliationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelEntityReconciliationJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelEntityReconciliationJobResourceNames()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelEntityReconciliationJob(request.EntityReconciliationJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelEntityReconciliationJobResourceNamesAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelEntityReconciliationJobAsync(request.EntityReconciliationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelEntityReconciliationJobAsync(request.EntityReconciliationJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityReconciliationJobRequestObject()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityReconciliationJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityReconciliationJobRequestObjectAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityReconciliationJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityReconciliationJob()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityReconciliationJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityReconciliationJobAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityReconciliationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityReconciliationJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEntityReconciliationJobResourceNames()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityReconciliationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEntityReconciliationJob(request.EntityReconciliationJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEntityReconciliationJobResourceNamesAsync()
        {
            moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient> mockGrpcClient = new moq::Mock<EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient>(moq::MockBehavior.Strict);
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEntityReconciliationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnterpriseKnowledgeGraphServiceClient client = new EnterpriseKnowledgeGraphServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEntityReconciliationJobAsync(request.EntityReconciliationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEntityReconciliationJobAsync(request.EntityReconciliationJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
