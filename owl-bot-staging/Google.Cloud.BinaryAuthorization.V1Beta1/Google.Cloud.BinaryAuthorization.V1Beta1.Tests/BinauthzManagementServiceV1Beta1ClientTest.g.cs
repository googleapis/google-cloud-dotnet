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

namespace Google.Cloud.BinaryAuthorization.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBinauthzManagementServiceV1Beta1ClientTest
    {
        [xunit::FactAttribute]
        public void GetPolicyRequestObject()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
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
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyRequestObjectAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
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
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicy()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
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
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
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
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyResourceNames()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
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
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetPolicy(request.PolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyResourceNamesAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
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
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request.PolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request.PolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePolicyRequestObject()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
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
            mockGrpcClient.Setup(x => x.UpdatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.UpdatePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePolicyRequestObjectAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
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
            mockGrpcClient.Setup(x => x.UpdatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.UpdatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.UpdatePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePolicy()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
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
            mockGrpcClient.Setup(x => x.UpdatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.UpdatePolicy(request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePolicyAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
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
            mockGrpcClient.Setup(x => x.UpdatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.UpdatePolicyAsync(request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.UpdatePolicyAsync(request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAttestorRequestObject()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AttestorId = "attestor_id76a3ccd6",
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.CreateAttestor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAttestorRequestObjectAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AttestorId = "attestor_id76a3ccd6",
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.CreateAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.CreateAttestorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAttestor()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AttestorId = "attestor_id76a3ccd6",
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.CreateAttestor(request.Parent, request.AttestorId, request.Attestor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAttestorAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AttestorId = "attestor_id76a3ccd6",
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.CreateAttestorAsync(request.Parent, request.AttestorId, request.Attestor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.CreateAttestorAsync(request.Parent, request.AttestorId, request.Attestor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAttestorResourceNames()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AttestorId = "attestor_id76a3ccd6",
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.CreateAttestor(request.ParentAsProjectName, request.AttestorId, request.Attestor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAttestorResourceNamesAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AttestorId = "attestor_id76a3ccd6",
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.CreateAttestorAsync(request.ParentAsProjectName, request.AttestorId, request.Attestor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.CreateAttestorAsync(request.ParentAsProjectName, request.AttestorId, request.Attestor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAttestorRequestObject()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.GetAttestor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAttestorRequestObjectAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.GetAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.GetAttestorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAttestor()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.GetAttestor(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAttestorAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.GetAttestorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.GetAttestorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAttestorResourceNames()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.GetAttestor(request.AttestorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAttestorResourceNamesAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.GetAttestorAsync(request.AttestorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.GetAttestorAsync(request.AttestorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAttestorRequestObject()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdateAttestorRequest request = new UpdateAttestorRequest
            {
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.UpdateAttestor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAttestorRequestObjectAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdateAttestorRequest request = new UpdateAttestorRequest
            {
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.UpdateAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.UpdateAttestorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAttestor()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdateAttestorRequest request = new UpdateAttestorRequest
            {
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor response = client.UpdateAttestor(request.Attestor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAttestorAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            UpdateAttestorRequest request = new UpdateAttestorRequest
            {
                Attestor = new Attestor(),
            };
            Attestor expectedResponse = new Attestor
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
                UserOwnedDrydockNote = new UserOwnedDrydockNote(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Attestor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Attestor responseCallSettings = await client.UpdateAttestorAsync(request.Attestor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Attestor responseCancellationToken = await client.UpdateAttestorAsync(request.Attestor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAttestorRequestObject()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            client.DeleteAttestor(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAttestorRequestObjectAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAttestorAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAttestor()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            client.DeleteAttestor(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAttestorAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAttestorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAttestorAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAttestorResourceNames()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAttestor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            client.DeleteAttestor(request.AttestorName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAttestorResourceNamesAsync()
        {
            moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client> mockGrpcClient = new moq::Mock<BinauthzManagementServiceV1Beta1.BinauthzManagementServiceV1Beta1Client>(moq::MockBehavior.Strict);
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAttestorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BinauthzManagementServiceV1Beta1Client client = new BinauthzManagementServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAttestorAsync(request.AttestorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAttestorAsync(request.AttestorName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
