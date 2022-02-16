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

namespace Google.Cloud.OrgPolicy.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOrgPolicyClientTest
    {
        [xunit::FactAttribute]
        public void GetPolicyRequestObject()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyRequestObjectAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicy()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyResourceNames()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetPolicy(request.PolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyResourceNamesAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request.PolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request.PolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectivePolicyRequestObject()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetEffectivePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetEffectivePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectivePolicyRequestObjectAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetEffectivePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetEffectivePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetEffectivePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectivePolicy()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetEffectivePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetEffectivePolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectivePolicyAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetEffectivePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetEffectivePolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetEffectivePolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectivePolicyResourceNames()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetEffectivePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetEffectivePolicy(request.PolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectivePolicyResourceNamesAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetEffectivePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetEffectivePolicyAsync(request.PolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetEffectivePolicyAsync(request.PolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyRequestObject()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.CreatePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyRequestObjectAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.CreatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.CreatePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicy()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.CreatePolicy(request.Parent, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.CreatePolicyAsync(request.Parent, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.CreatePolicyAsync(request.Parent, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyResourceNames1()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.CreatePolicy(request.ParentAsProjectName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyResourceNames1Async()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.CreatePolicyAsync(request.ParentAsProjectName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.CreatePolicyAsync(request.ParentAsProjectName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyResourceNames2()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.CreatePolicy(request.ParentAsFolderName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyResourceNames2Async()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.CreatePolicyAsync(request.ParentAsFolderName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.CreatePolicyAsync(request.ParentAsFolderName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyResourceNames3()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.CreatePolicy(request.ParentAsOrganizationName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyResourceNames3Async()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.CreatePolicyAsync(request.ParentAsOrganizationName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.CreatePolicyAsync(request.ParentAsOrganizationName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePolicyRequestObject()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.UpdatePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePolicyRequestObjectAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.UpdatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.UpdatePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePolicy()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdatePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy response = client.UpdatePolicy(request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePolicyAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
                Spec = new PolicySpec(),
#pragma warning disable CS0612
                Alternate = new AlternatePolicySpec(),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdatePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.UpdatePolicyAsync(request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.UpdatePolicyAsync(request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePolicyRequestObject()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            client.DeletePolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePolicyRequestObjectAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            await client.DeletePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePolicyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePolicy()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            client.DeletePolicy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePolicyAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            await client.DeletePolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePolicyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePolicyResourceNames()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            client.DeletePolicy(request.PolicyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePolicyResourceNamesAsync()
        {
            moq::Mock<OrgPolicy.OrgPolicyClient> mockGrpcClient = new moq::Mock<OrgPolicy.OrgPolicyClient>(moq::MockBehavior.Strict);
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OrgPolicyClient client = new OrgPolicyClientImpl(mockGrpcClient.Object, null);
            await client.DeletePolicyAsync(request.PolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePolicyAsync(request.PolicyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
