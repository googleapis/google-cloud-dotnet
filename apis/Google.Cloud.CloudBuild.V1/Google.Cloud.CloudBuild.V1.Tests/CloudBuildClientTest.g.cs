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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.CloudBuild.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudBuildClientTest
    {
        [xunit::FactAttribute]
        public void GetBuildRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildRequest request = new GetBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBuild(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build response = client.GetBuild(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBuildRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildRequest request = new GetBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBuildAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Build>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build responseCallSettings = await client.GetBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Build responseCancellationToken = await client.GetBuildAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBuild()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildRequest request = new GetBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBuild(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build response = client.GetBuild(request.ProjectId, request.Id);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBuildAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildRequest request = new GetBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBuildAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Build>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build responseCallSettings = await client.GetBuildAsync(request.ProjectId, request.Id, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Build responseCancellationToken = await client.GetBuildAsync(request.ProjectId, request.Id, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelBuildRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBuildRequest request = new CancelBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.CancelBuild(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build response = client.CancelBuild(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelBuildRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBuildRequest request = new CancelBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.CancelBuildAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Build>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build responseCallSettings = await client.CancelBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Build responseCancellationToken = await client.CancelBuildAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelBuild()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBuildRequest request = new CancelBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.CancelBuild(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build response = client.CancelBuild(request.ProjectId, request.Id);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelBuildAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelBuildRequest request = new CancelBuildRequest
            {
                ProjectId = "project_id43ad98b0",
                Id = "id74b70bb8",
            };
            Build expectedResponse = new Build
            {
                Id = "id74b70bb8",
                Status = Build.Types.Status.InternalError,
                Source = new Source(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                FinishTime = new wkt::Timestamp(),
                Results = new Results(),
                Steps = { new BuildStep(), },
                Timeout = new wkt::Duration(),
                Images = { "images1714b559", },
                ProjectId = "project_id43ad98b0",
                LogsBucket = "logs_bucket85d3caaa",
                SourceProvenance = new SourceProvenance(),
                BuildTriggerId = "build_trigger_idbd29c2e8",
                Options = new BuildOptions(),
                StatusDetail = "status_detail859ccc64",
                LogUrl = "log_url5edf0128",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tags = { "tags52c47ad5", },
                Secrets = { new Secret(), },
                Timing =
                {
                    {
                        "key8a0b6e3c",
                        new TimeSpan()
                    },
                },
                Artifacts = new Artifacts(),
                QueueTtl = new wkt::Duration(),
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
                AvailableSecrets = new Secrets(),
                Warnings =
                {
                    new Build.Types.Warning(),
                },
            };
            mockGrpcClient.Setup(x => x.CancelBuildAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Build>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            Build responseCallSettings = await client.CancelBuildAsync(request.ProjectId, request.Id, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Build responseCancellationToken = await client.CancelBuildAsync(request.ProjectId, request.Id, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBuildTriggerRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBuildTriggerRequest request = new CreateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                Trigger = new BuildTrigger(),
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger response = client.CreateBuildTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBuildTriggerRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBuildTriggerRequest request = new CreateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                Trigger = new BuildTrigger(),
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BuildTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger responseCallSettings = await client.CreateBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BuildTrigger responseCancellationToken = await client.CreateBuildTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBuildTrigger()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBuildTriggerRequest request = new CreateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                Trigger = new BuildTrigger(),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger response = client.CreateBuildTrigger(request.ProjectId, request.Trigger);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBuildTriggerAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBuildTriggerRequest request = new CreateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                Trigger = new BuildTrigger(),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BuildTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger responseCallSettings = await client.CreateBuildTriggerAsync(request.ProjectId, request.Trigger, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BuildTrigger responseCancellationToken = await client.CreateBuildTriggerAsync(request.ProjectId, request.Trigger, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBuildTriggerRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildTriggerRequest request = new GetBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.GetBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger response = client.GetBuildTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBuildTriggerRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildTriggerRequest request = new GetBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.GetBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BuildTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger responseCallSettings = await client.GetBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BuildTrigger responseCancellationToken = await client.GetBuildTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBuildTrigger()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildTriggerRequest request = new GetBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.GetBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger response = client.GetBuildTrigger(request.ProjectId, request.TriggerId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBuildTriggerAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBuildTriggerRequest request = new GetBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.GetBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BuildTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger responseCallSettings = await client.GetBuildTriggerAsync(request.ProjectId, request.TriggerId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BuildTrigger responseCancellationToken = await client.GetBuildTriggerAsync(request.ProjectId, request.TriggerId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBuildTriggerRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBuildTriggerRequest request = new DeleteBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            client.DeleteBuildTrigger(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBuildTriggerRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBuildTriggerRequest request = new DeleteBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBuildTriggerAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBuildTrigger()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBuildTriggerRequest request = new DeleteBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            client.DeleteBuildTrigger(request.ProjectId, request.TriggerId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBuildTriggerAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBuildTriggerRequest request = new DeleteBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBuildTriggerAsync(request.ProjectId, request.TriggerId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBuildTriggerAsync(request.ProjectId, request.TriggerId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBuildTriggerRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBuildTriggerRequest request = new UpdateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                Trigger = new BuildTrigger(),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.UpdateBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger response = client.UpdateBuildTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBuildTriggerRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBuildTriggerRequest request = new UpdateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                Trigger = new BuildTrigger(),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.UpdateBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BuildTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger responseCallSettings = await client.UpdateBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BuildTrigger responseCancellationToken = await client.UpdateBuildTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBuildTrigger()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBuildTriggerRequest request = new UpdateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                Trigger = new BuildTrigger(),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.UpdateBuildTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger response = client.UpdateBuildTrigger(request.ProjectId, request.TriggerId, request.Trigger);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBuildTriggerAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBuildTriggerRequest request = new UpdateBuildTriggerRequest
            {
                ProjectId = "project_id43ad98b0",
                TriggerId = "trigger_id9f1f0bb1",
                Trigger = new BuildTrigger(),
            };
            BuildTrigger expectedResponse = new BuildTrigger
            {
                Id = "id74b70bb8",
                Build = new Build(),
                CreateTime = new wkt::Timestamp(),
                TriggerTemplate = new RepoSource(),
                Filename = "filenamee9d75e43",
                Disabled = false,
                Description = "description2cf9da67",
                Substitutions =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Github = new GitHubEventsConfig(),
                IgnoredFiles =
                {
                    "ignored_filesf5916206",
                },
                IncludedFiles =
                {
                    "included_files53b7943b",
                },
                Autodetect = false,
                Tags = { "tags52c47ad5", },
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
                PubsubConfig = new PubsubConfig(),
                Filter = "filtere47ac9b2",
                WebhookConfig = new WebhookConfig(),
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.UpdateBuildTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BuildTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            BuildTrigger responseCallSettings = await client.UpdateBuildTriggerAsync(request.ProjectId, request.TriggerId, request.Trigger, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BuildTrigger responseCancellationToken = await client.UpdateBuildTriggerAsync(request.ProjectId, request.TriggerId, request.Trigger, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReceiveTriggerWebhookRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReceiveTriggerWebhookRequest request = new ReceiveTriggerWebhookRequest
            {
                Body = new ga::HttpBody(),
                ProjectId = "project_id43ad98b0",
                Trigger = "trigger098ed0c7",
                Secret = "secret9422be5e",
                Name = "name1c9368b0",
            };
            ReceiveTriggerWebhookResponse expectedResponse = new ReceiveTriggerWebhookResponse { };
            mockGrpcClient.Setup(x => x.ReceiveTriggerWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            ReceiveTriggerWebhookResponse response = client.ReceiveTriggerWebhook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReceiveTriggerWebhookRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ReceiveTriggerWebhookRequest request = new ReceiveTriggerWebhookRequest
            {
                Body = new ga::HttpBody(),
                ProjectId = "project_id43ad98b0",
                Trigger = "trigger098ed0c7",
                Secret = "secret9422be5e",
                Name = "name1c9368b0",
            };
            ReceiveTriggerWebhookResponse expectedResponse = new ReceiveTriggerWebhookResponse { };
            mockGrpcClient.Setup(x => x.ReceiveTriggerWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReceiveTriggerWebhookResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            ReceiveTriggerWebhookResponse responseCallSettings = await client.ReceiveTriggerWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReceiveTriggerWebhookResponse responseCancellationToken = await client.ReceiveTriggerWebhookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkerPoolRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkerPoolRequest request = new CreateWorkerPoolRequest
            {
                Parent = "parent7858e4d0",
                WorkerPool = new WorkerPool(),
            };
            WorkerPool expectedResponse = new WorkerPool
            {
                ProjectId = "project_id43ad98b0",
                ServiceAccountEmail = "service_account_emailb0c3703d",
                WorkerCount = -1903495562118123823L,
                Regions =
                {
                    WorkerPool.Types.Region.UsEast1,
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Status = WorkerPool.Types.Status.Deleted,
                Name = "name1c9368b0",
                WorkerConfig = new WorkerConfig(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkerPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            WorkerPool response = client.CreateWorkerPool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkerPoolRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkerPoolRequest request = new CreateWorkerPoolRequest
            {
                Parent = "parent7858e4d0",
                WorkerPool = new WorkerPool(),
            };
            WorkerPool expectedResponse = new WorkerPool
            {
                ProjectId = "project_id43ad98b0",
                ServiceAccountEmail = "service_account_emailb0c3703d",
                WorkerCount = -1903495562118123823L,
                Regions =
                {
                    WorkerPool.Types.Region.UsEast1,
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Status = WorkerPool.Types.Status.Deleted,
                Name = "name1c9368b0",
                WorkerConfig = new WorkerConfig(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkerPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkerPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            WorkerPool responseCallSettings = await client.CreateWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkerPool responseCancellationToken = await client.CreateWorkerPoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkerPoolRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkerPoolRequest request = new GetWorkerPoolRequest
            {
                Name = "name1c9368b0",
            };
            WorkerPool expectedResponse = new WorkerPool
            {
                ProjectId = "project_id43ad98b0",
                ServiceAccountEmail = "service_account_emailb0c3703d",
                WorkerCount = -1903495562118123823L,
                Regions =
                {
                    WorkerPool.Types.Region.UsEast1,
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Status = WorkerPool.Types.Status.Deleted,
                Name = "name1c9368b0",
                WorkerConfig = new WorkerConfig(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetWorkerPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            WorkerPool response = client.GetWorkerPool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkerPoolRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkerPoolRequest request = new GetWorkerPoolRequest
            {
                Name = "name1c9368b0",
            };
            WorkerPool expectedResponse = new WorkerPool
            {
                ProjectId = "project_id43ad98b0",
                ServiceAccountEmail = "service_account_emailb0c3703d",
                WorkerCount = -1903495562118123823L,
                Regions =
                {
                    WorkerPool.Types.Region.UsEast1,
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Status = WorkerPool.Types.Status.Deleted,
                Name = "name1c9368b0",
                WorkerConfig = new WorkerConfig(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetWorkerPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkerPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            WorkerPool responseCallSettings = await client.GetWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkerPool responseCancellationToken = await client.GetWorkerPoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkerPoolRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkerPoolRequest request = new DeleteWorkerPoolRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkerPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkerPool(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkerPoolRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkerPoolRequest request = new DeleteWorkerPoolRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkerPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkerPoolAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWorkerPoolRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkerPoolRequest request = new UpdateWorkerPoolRequest
            {
                Name = "name1c9368b0",
                WorkerPool = new WorkerPool(),
            };
            WorkerPool expectedResponse = new WorkerPool
            {
                ProjectId = "project_id43ad98b0",
                ServiceAccountEmail = "service_account_emailb0c3703d",
                WorkerCount = -1903495562118123823L,
                Regions =
                {
                    WorkerPool.Types.Region.UsEast1,
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Status = WorkerPool.Types.Status.Deleted,
                Name = "name1c9368b0",
                WorkerConfig = new WorkerConfig(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateWorkerPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            WorkerPool response = client.UpdateWorkerPool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkerPoolRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkerPoolRequest request = new UpdateWorkerPoolRequest
            {
                Name = "name1c9368b0",
                WorkerPool = new WorkerPool(),
            };
            WorkerPool expectedResponse = new WorkerPool
            {
                ProjectId = "project_id43ad98b0",
                ServiceAccountEmail = "service_account_emailb0c3703d",
                WorkerCount = -1903495562118123823L,
                Regions =
                {
                    WorkerPool.Types.Region.UsEast1,
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Status = WorkerPool.Types.Status.Deleted,
                Name = "name1c9368b0",
                WorkerConfig = new WorkerConfig(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateWorkerPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkerPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            WorkerPool responseCallSettings = await client.UpdateWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkerPool responseCancellationToken = await client.UpdateWorkerPoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListWorkerPoolsRequestObject()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListWorkerPoolsResponse expectedResponse = new ListWorkerPoolsResponse
            {
                WorkerPools = { new WorkerPool(), },
            };
            mockGrpcClient.Setup(x => x.ListWorkerPools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            ListWorkerPoolsResponse response = client.ListWorkerPools(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListWorkerPoolsRequestObjectAsync()
        {
            moq::Mock<CloudBuild.CloudBuildClient> mockGrpcClient = new moq::Mock<CloudBuild.CloudBuildClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListWorkerPoolsResponse expectedResponse = new ListWorkerPoolsResponse
            {
                WorkerPools = { new WorkerPool(), },
            };
            mockGrpcClient.Setup(x => x.ListWorkerPoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListWorkerPoolsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBuildClient client = new CloudBuildClientImpl(mockGrpcClient.Object, null);
            ListWorkerPoolsResponse responseCallSettings = await client.ListWorkerPoolsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListWorkerPoolsResponse responseCancellationToken = await client.ListWorkerPoolsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
