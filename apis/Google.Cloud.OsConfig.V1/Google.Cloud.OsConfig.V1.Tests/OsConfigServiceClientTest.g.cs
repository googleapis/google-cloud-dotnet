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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.OsConfig.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOsConfigServiceClientTest
    {
        [xunit::FactAttribute]
        public void ExecutePatchJobRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Description = "description2cf9da67",
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                DryRun = true,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                Rollout = new PatchRollout(),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.ExecutePatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.ExecutePatchJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecutePatchJobRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Description = "description2cf9da67",
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                DryRun = true,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                Rollout = new PatchRollout(),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.ExecutePatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.ExecutePatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.ExecutePatchJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchJobRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.GetPatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.GetPatchJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchJobRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.GetPatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.GetPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.GetPatchJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchJob()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.GetPatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.GetPatchJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchJobAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.GetPatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.GetPatchJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.GetPatchJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchJobResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.GetPatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.GetPatchJob(request.PatchJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchJobResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.GetPatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.GetPatchJobAsync(request.PatchJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.GetPatchJobAsync(request.PatchJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelPatchJobRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.CancelPatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.CancelPatchJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelPatchJobRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            PatchJob expectedResponse = new PatchJob
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeploymentAsPatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Rollout = new PatchRollout(),
            };
            mockGrpcClient.Setup(x => x.CancelPatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.CancelPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.CancelPatchJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.CreatePatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.CreatePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.CreatePatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePatchDeployment()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.CreatePatchDeployment(request.Parent, request.PatchDeployment, request.PatchDeploymentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePatchDeploymentAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.CreatePatchDeploymentAsync(request.Parent, request.PatchDeployment, request.PatchDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.CreatePatchDeploymentAsync(request.Parent, request.PatchDeployment, request.PatchDeploymentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePatchDeploymentResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.CreatePatchDeployment(request.ParentAsProjectName, request.PatchDeployment, request.PatchDeploymentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePatchDeploymentResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.CreatePatchDeploymentAsync(request.ParentAsProjectName, request.PatchDeployment, request.PatchDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.CreatePatchDeploymentAsync(request.ParentAsProjectName, request.PatchDeployment, request.PatchDeploymentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.GetPatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.GetPatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.GetPatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchDeployment()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.GetPatchDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchDeploymentAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.GetPatchDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.GetPatchDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchDeploymentResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.GetPatchDeployment(request.PatchDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchDeploymentResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.GetPatchDeploymentAsync(request.PatchDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.GetPatchDeploymentAsync(request.PatchDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePatchDeployment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePatchDeploymentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePatchDeployment()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePatchDeployment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePatchDeploymentAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePatchDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePatchDeploymentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePatchDeploymentResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePatchDeployment(request.PatchDeploymentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePatchDeploymentResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePatchDeploymentAsync(request.PatchDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePatchDeploymentAsync(request.PatchDeploymentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdatePatchDeploymentRequest request = new UpdatePatchDeploymentRequest
            {
                PatchDeployment = new PatchDeployment(),
                UpdateMask = new wkt::FieldMask(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.UpdatePatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdatePatchDeploymentRequest request = new UpdatePatchDeploymentRequest
            {
                PatchDeployment = new PatchDeployment(),
                UpdateMask = new wkt::FieldMask(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.UpdatePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.UpdatePatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePatchDeployment()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdatePatchDeploymentRequest request = new UpdatePatchDeploymentRequest
            {
                PatchDeployment = new PatchDeployment(),
                UpdateMask = new wkt::FieldMask(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.UpdatePatchDeployment(request.PatchDeployment, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePatchDeploymentAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdatePatchDeploymentRequest request = new UpdatePatchDeploymentRequest
            {
                PatchDeployment = new PatchDeployment(),
                UpdateMask = new wkt::FieldMask(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.UpdatePatchDeploymentAsync(request.PatchDeployment, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.UpdatePatchDeploymentAsync(request.PatchDeployment, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PausePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.PausePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.PausePatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PausePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.PausePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.PausePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.PausePatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PausePatchDeployment()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.PausePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.PausePatchDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PausePatchDeploymentAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.PausePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.PausePatchDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.PausePatchDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PausePatchDeploymentResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.PausePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.PausePatchDeployment(request.PatchDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PausePatchDeploymentResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.PausePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.PausePatchDeploymentAsync(request.PatchDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.PausePatchDeploymentAsync(request.PatchDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.ResumePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.ResumePatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.ResumePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.ResumePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.ResumePatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumePatchDeployment()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.ResumePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.ResumePatchDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumePatchDeploymentAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.ResumePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.ResumePatchDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.ResumePatchDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumePatchDeploymentResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.ResumePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.ResumePatchDeployment(request.PatchDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumePatchDeploymentResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
                Rollout = new PatchRollout(),
                State = PatchDeployment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.ResumePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.ResumePatchDeploymentAsync(request.PatchDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.ResumePatchDeploymentAsync(request.PatchDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
