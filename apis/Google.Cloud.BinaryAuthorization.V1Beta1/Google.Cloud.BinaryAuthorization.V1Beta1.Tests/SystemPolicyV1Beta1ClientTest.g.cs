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

namespace Google.Cloud.BinaryAuthorization.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSystemPolicyV1Beta1ClientTest
    {
        [xunit::FactAttribute]
        public void GetSystemPolicyRequestObject()
        {
            moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client> mockGrpcClient = new moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client>(moq::MockBehavior.Strict);
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
                AdmissionWhitelistPatterns =
                {
                    new AdmissionWhitelistPattern(),
                },
                ClusterAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                DefaultAdmissionRule = new AdmissionRule(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                GlobalPolicyEvaluationMode = Policy.Types.GlobalPolicyEvaluationMode.Disable,
                KubernetesServiceAccountAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                IstioServiceIdentityAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                KubernetesNamespaceAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSystemPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SystemPolicyV1Beta1Client client = new SystemPolicyV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetSystemPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSystemPolicyRequestObjectAsync()
        {
            moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client> mockGrpcClient = new moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client>(moq::MockBehavior.Strict);
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
                AdmissionWhitelistPatterns =
                {
                    new AdmissionWhitelistPattern(),
                },
                ClusterAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                DefaultAdmissionRule = new AdmissionRule(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                GlobalPolicyEvaluationMode = Policy.Types.GlobalPolicyEvaluationMode.Disable,
                KubernetesServiceAccountAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                IstioServiceIdentityAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                KubernetesNamespaceAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSystemPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SystemPolicyV1Beta1Client client = new SystemPolicyV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetSystemPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetSystemPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSystemPolicy()
        {
            moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client> mockGrpcClient = new moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client>(moq::MockBehavior.Strict);
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
                AdmissionWhitelistPatterns =
                {
                    new AdmissionWhitelistPattern(),
                },
                ClusterAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                DefaultAdmissionRule = new AdmissionRule(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                GlobalPolicyEvaluationMode = Policy.Types.GlobalPolicyEvaluationMode.Disable,
                KubernetesServiceAccountAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                IstioServiceIdentityAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                KubernetesNamespaceAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSystemPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SystemPolicyV1Beta1Client client = new SystemPolicyV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetSystemPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSystemPolicyAsync()
        {
            moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client> mockGrpcClient = new moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client>(moq::MockBehavior.Strict);
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
                AdmissionWhitelistPatterns =
                {
                    new AdmissionWhitelistPattern(),
                },
                ClusterAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                DefaultAdmissionRule = new AdmissionRule(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                GlobalPolicyEvaluationMode = Policy.Types.GlobalPolicyEvaluationMode.Disable,
                KubernetesServiceAccountAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                IstioServiceIdentityAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                KubernetesNamespaceAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSystemPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SystemPolicyV1Beta1Client client = new SystemPolicyV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetSystemPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetSystemPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSystemPolicyResourceNames()
        {
            moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client> mockGrpcClient = new moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client>(moq::MockBehavior.Strict);
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
                AdmissionWhitelistPatterns =
                {
                    new AdmissionWhitelistPattern(),
                },
                ClusterAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                DefaultAdmissionRule = new AdmissionRule(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                GlobalPolicyEvaluationMode = Policy.Types.GlobalPolicyEvaluationMode.Disable,
                KubernetesServiceAccountAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                IstioServiceIdentityAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                KubernetesNamespaceAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSystemPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SystemPolicyV1Beta1Client client = new SystemPolicyV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetSystemPolicy(request.PolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSystemPolicyResourceNamesAsync()
        {
            moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client> mockGrpcClient = new moq::Mock<SystemPolicyV1Beta1.SystemPolicyV1Beta1Client>(moq::MockBehavior.Strict);
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
                AdmissionWhitelistPatterns =
                {
                    new AdmissionWhitelistPattern(),
                },
                ClusterAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                DefaultAdmissionRule = new AdmissionRule(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                GlobalPolicyEvaluationMode = Policy.Types.GlobalPolicyEvaluationMode.Disable,
                KubernetesServiceAccountAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                IstioServiceIdentityAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
                KubernetesNamespaceAdmissionRules =
                {
                    {
                        "key8a0b6e3c",
                        new AdmissionRule()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSystemPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SystemPolicyV1Beta1Client client = new SystemPolicyV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetSystemPolicyAsync(request.PolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetSystemPolicyAsync(request.PolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
