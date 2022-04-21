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

namespace Google.Cloud.Dataproc.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAutoscalingPolicyServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateAutoscalingPolicyRequestObject()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.CreateAutoscalingPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAutoscalingPolicyRequestObjectAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.CreateAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.CreateAutoscalingPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAutoscalingPolicy()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.CreateAutoscalingPolicy(request.Parent, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAutoscalingPolicyAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.CreateAutoscalingPolicyAsync(request.Parent, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.CreateAutoscalingPolicyAsync(request.Parent, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAutoscalingPolicyResourceNames1()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.CreateAutoscalingPolicy(request.ParentAsLocationName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAutoscalingPolicyResourceNames1Async()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.CreateAutoscalingPolicyAsync(request.ParentAsLocationName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.CreateAutoscalingPolicyAsync(request.ParentAsLocationName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAutoscalingPolicyResourceNames2()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.CreateAutoscalingPolicy(request.ParentAsRegionName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAutoscalingPolicyResourceNames2Async()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.CreateAutoscalingPolicyAsync(request.ParentAsRegionName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.CreateAutoscalingPolicyAsync(request.ParentAsRegionName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAutoscalingPolicyRequestObject()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.UpdateAutoscalingPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAutoscalingPolicyRequestObjectAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.UpdateAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.UpdateAutoscalingPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAutoscalingPolicy()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.UpdateAutoscalingPolicy(request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAutoscalingPolicyAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.UpdateAutoscalingPolicyAsync(request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.UpdateAutoscalingPolicyAsync(request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAutoscalingPolicyRequestObject()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.GetAutoscalingPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAutoscalingPolicyRequestObjectAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.GetAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.GetAutoscalingPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAutoscalingPolicy()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.GetAutoscalingPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAutoscalingPolicyAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.GetAutoscalingPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.GetAutoscalingPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAutoscalingPolicyResourceNames()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy response = client.GetAutoscalingPolicy(request.AutoscalingPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAutoscalingPolicyResourceNamesAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id74b70bb8",
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
                BasicAlgorithm = new BasicAutoscalingAlgorithm(),
                WorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                SecondaryWorkerConfig = new InstanceGroupAutoscalingPolicyConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AutoscalingPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            AutoscalingPolicy responseCallSettings = await client.GetAutoscalingPolicyAsync(request.AutoscalingPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AutoscalingPolicy responseCancellationToken = await client.GetAutoscalingPolicyAsync(request.AutoscalingPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAutoscalingPolicyRequestObject()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAutoscalingPolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAutoscalingPolicyRequestObjectAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAutoscalingPolicyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAutoscalingPolicy()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAutoscalingPolicy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAutoscalingPolicyAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAutoscalingPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAutoscalingPolicyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAutoscalingPolicyResourceNames()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAutoscalingPolicy(request.AutoscalingPolicyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAutoscalingPolicyResourceNamesAsync()
        {
            moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new moq::Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAutoscalingPolicyAsync(request.AutoscalingPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAutoscalingPolicyAsync(request.AutoscalingPolicyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
