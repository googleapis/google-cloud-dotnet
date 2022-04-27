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
    public sealed class GeneratedExperimentsClientTest
    {
        [xunit::FactAttribute]
        public void GetExperimentRequestObject()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.GetExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.GetExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExperimentRequestObjectAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.GetExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.GetExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.GetExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExperiment()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.GetExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.GetExperiment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExperimentAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.GetExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.GetExperimentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.GetExperimentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExperimentResourceNames()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.GetExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.GetExperiment(request.ExperimentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExperimentResourceNamesAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.GetExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.GetExperimentAsync(request.ExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.GetExperimentAsync(request.ExperimentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExperimentRequestObject()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.CreateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.CreateExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExperimentRequestObjectAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.CreateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.CreateExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.CreateExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExperiment()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.CreateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.CreateExperiment(request.Parent, request.Experiment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExperimentAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.CreateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.CreateExperimentAsync(request.Parent, request.Experiment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.CreateExperimentAsync(request.Parent, request.Experiment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExperimentResourceNames()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.CreateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.CreateExperiment(request.ParentAsEnvironmentName, request.Experiment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExperimentResourceNamesAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.CreateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.CreateExperimentAsync(request.ParentAsEnvironmentName, request.Experiment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.CreateExperimentAsync(request.ParentAsEnvironmentName, request.Experiment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExperimentRequestObject()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            UpdateExperimentRequest request = new UpdateExperimentRequest
            {
                Experiment = new Experiment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.UpdateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.UpdateExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExperimentRequestObjectAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            UpdateExperimentRequest request = new UpdateExperimentRequest
            {
                Experiment = new Experiment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.UpdateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.UpdateExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.UpdateExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExperiment()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            UpdateExperimentRequest request = new UpdateExperimentRequest
            {
                Experiment = new Experiment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.UpdateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.UpdateExperiment(request.Experiment, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExperimentAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            UpdateExperimentRequest request = new UpdateExperimentRequest
            {
                Experiment = new Experiment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.UpdateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.UpdateExperimentAsync(request.Experiment, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.UpdateExperimentAsync(request.Experiment, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExperimentRequestObject()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteExperiment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExperimentRequestObjectAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExperimentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExperiment()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteExperiment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExperimentAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteExperimentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExperimentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExperimentResourceNames()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteExperiment(request.ExperimentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExperimentResourceNamesAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteExperimentAsync(request.ExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExperimentAsync(request.ExperimentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartExperimentRequestObject()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StartExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.StartExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartExperimentRequestObjectAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StartExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.StartExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.StartExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartExperiment()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StartExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.StartExperiment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartExperimentAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StartExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.StartExperimentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.StartExperimentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartExperimentResourceNames()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StartExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.StartExperiment(request.ExperimentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartExperimentResourceNamesAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StartExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.StartExperimentAsync(request.ExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.StartExperimentAsync(request.ExperimentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StopExperimentRequestObject()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StopExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.StopExperiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopExperimentRequestObjectAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StopExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.StopExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.StopExperimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StopExperiment()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StopExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.StopExperiment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopExperimentAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StopExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.StopExperimentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.StopExperimentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StopExperimentResourceNames()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StopExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment response = client.StopExperiment(request.ExperimentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopExperimentResourceNamesAsync()
        {
            moq::Mock<Experiments.ExperimentsClient> mockGrpcClient = new moq::Mock<Experiments.ExperimentsClient>(moq::MockBehavior.Strict);
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            Experiment expectedResponse = new Experiment
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Experiment.Types.State.Done,
                Definition = new Experiment.Types.Definition(),
                Result = new Experiment.Types.Result(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                LastUpdateTime = new wkt::Timestamp(),
                ExperimentLength = new wkt::Duration(),
                VariantsHistory =
                {
                    new VariantsHistory(),
                },
                RolloutConfig = new RolloutConfig(),
                RolloutState = new RolloutState(),
                RolloutFailureReason = "rollout_failure_reason2f2db6d3",
            };
            mockGrpcClient.Setup(x => x.StopExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Experiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentsClient client = new ExperimentsClientImpl(mockGrpcClient.Object, null, null);
            Experiment responseCallSettings = await client.StopExperimentAsync(request.ExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Experiment responseCancellationToken = await client.StopExperimentAsync(request.ExperimentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
