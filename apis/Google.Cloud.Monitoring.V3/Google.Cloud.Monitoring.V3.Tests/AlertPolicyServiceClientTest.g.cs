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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Monitoring.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAlertPolicyServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAlertPolicyRequestObject()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.GetAlertPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAlertPolicyRequestObjectAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.GetAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.GetAlertPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAlertPolicy()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.GetAlertPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAlertPolicyAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.GetAlertPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.GetAlertPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAlertPolicyResourceNames1()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.GetAlertPolicy(request.AlertPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAlertPolicyResourceNames1Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.GetAlertPolicyAsync(request.AlertPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.GetAlertPolicyAsync(request.AlertPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAlertPolicyResourceNames2()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.GetAlertPolicy(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAlertPolicyResourceNames2Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.GetAlertPolicyAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.GetAlertPolicyAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlertPolicyRequestObject()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAlertPolicyRequestObjectAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.CreateAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.CreateAlertPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlertPolicy()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request.Name, request.AlertPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAlertPolicyAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.CreateAlertPolicyAsync(request.Name, request.AlertPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.CreateAlertPolicyAsync(request.Name, request.AlertPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlertPolicyResourceNames1()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request.ProjectName, request.AlertPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAlertPolicyResourceNames1Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.CreateAlertPolicyAsync(request.ProjectName, request.AlertPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.CreateAlertPolicyAsync(request.ProjectName, request.AlertPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlertPolicyResourceNames2()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request.OrganizationName, request.AlertPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAlertPolicyResourceNames2Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.CreateAlertPolicyAsync(request.OrganizationName, request.AlertPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.CreateAlertPolicyAsync(request.OrganizationName, request.AlertPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlertPolicyResourceNames3()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request.FolderName, request.AlertPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAlertPolicyResourceNames3Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.CreateAlertPolicyAsync(request.FolderName, request.AlertPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.CreateAlertPolicyAsync(request.FolderName, request.AlertPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlertPolicyResourceNames4()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request.ResourceName, request.AlertPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAlertPolicyResourceNames4Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.CreateAlertPolicyAsync(request.ResourceName, request.AlertPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.CreateAlertPolicyAsync(request.ResourceName, request.AlertPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAlertPolicyRequestObject()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlertPolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAlertPolicyRequestObjectAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAlertPolicyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAlertPolicy()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlertPolicy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAlertPolicyAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAlertPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAlertPolicyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAlertPolicyResourceNames1()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlertPolicy(request.AlertPolicyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAlertPolicyResourceNames1Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAlertPolicyAsync(request.AlertPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAlertPolicyAsync(request.AlertPolicyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAlertPolicyResourceNames2()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlertPolicy(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAlertPolicyResourceNames2Async()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAlertPolicyAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAlertPolicyAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAlertPolicyRequestObject()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                UpdateMask = new wkt::FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.UpdateAlertPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAlertPolicyRequestObjectAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                UpdateMask = new wkt::FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.UpdateAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.UpdateAlertPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAlertPolicy()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                UpdateMask = new wkt::FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.UpdateAlertPolicy(request.UpdateMask, request.AlertPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAlertPolicyAsync()
        {
            moq::Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new moq::Mock<AlertPolicyService.AlertPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                UpdateMask = new wkt::FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
                DisplayName = "display_name137f65c2",
                Combiner = AlertPolicy.Types.ConditionCombinerType.AndWithMatchingResource,
                CreationRecord = new MutationRecord(),
                MutationRecord = new MutationRecord(),
                Conditions =
                {
                    new AlertPolicy.Types.Condition(),
                },
                Documentation = new AlertPolicy.Types.Documentation(),
                NotificationChannels =
                {
                    "notification_channelseafebd2f",
                },
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Enabled = true,
                Validity = new gr::Status(),
                AlertStrategy = new AlertPolicy.Types.AlertStrategy(),
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AlertPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy responseCallSettings = await client.UpdateAlertPolicyAsync(request.UpdateMask, request.AlertPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AlertPolicy responseCancellationToken = await client.UpdateAlertPolicyAsync(request.UpdateMask, request.AlertPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
