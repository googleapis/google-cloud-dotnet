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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DevTools.ContainerAnalysis.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedContainerAnalysisClientTest
    {
        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVulnerabilityOccurrencesSummaryRequestObject()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            VulnerabilityOccurrencesSummary expectedResponse = new VulnerabilityOccurrencesSummary
            {
                Counts =
                {
                    new VulnerabilityOccurrencesSummary.Types.FixableTotalByDigest(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityOccurrencesSummary(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            VulnerabilityOccurrencesSummary response = client.GetVulnerabilityOccurrencesSummary(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityOccurrencesSummaryRequestObjectAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            VulnerabilityOccurrencesSummary expectedResponse = new VulnerabilityOccurrencesSummary
            {
                Counts =
                {
                    new VulnerabilityOccurrencesSummary.Types.FixableTotalByDigest(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityOccurrencesSummaryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VulnerabilityOccurrencesSummary>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            VulnerabilityOccurrencesSummary responseCallSettings = await client.GetVulnerabilityOccurrencesSummaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityOccurrencesSummary responseCancellationToken = await client.GetVulnerabilityOccurrencesSummaryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVulnerabilityOccurrencesSummary()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            VulnerabilityOccurrencesSummary expectedResponse = new VulnerabilityOccurrencesSummary
            {
                Counts =
                {
                    new VulnerabilityOccurrencesSummary.Types.FixableTotalByDigest(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityOccurrencesSummary(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            VulnerabilityOccurrencesSummary response = client.GetVulnerabilityOccurrencesSummary(request.Parent, request.Filter);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityOccurrencesSummaryAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            VulnerabilityOccurrencesSummary expectedResponse = new VulnerabilityOccurrencesSummary
            {
                Counts =
                {
                    new VulnerabilityOccurrencesSummary.Types.FixableTotalByDigest(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityOccurrencesSummaryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VulnerabilityOccurrencesSummary>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            VulnerabilityOccurrencesSummary responseCallSettings = await client.GetVulnerabilityOccurrencesSummaryAsync(request.Parent, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityOccurrencesSummary responseCancellationToken = await client.GetVulnerabilityOccurrencesSummaryAsync(request.Parent, request.Filter, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVulnerabilityOccurrencesSummaryResourceNames()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            VulnerabilityOccurrencesSummary expectedResponse = new VulnerabilityOccurrencesSummary
            {
                Counts =
                {
                    new VulnerabilityOccurrencesSummary.Types.FixableTotalByDigest(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityOccurrencesSummary(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            VulnerabilityOccurrencesSummary response = client.GetVulnerabilityOccurrencesSummary(request.ParentAsProjectName, request.Filter);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityOccurrencesSummaryResourceNamesAsync()
        {
            moq::Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new moq::Mock<ContainerAnalysis.ContainerAnalysisClient>(moq::MockBehavior.Strict);
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            VulnerabilityOccurrencesSummary expectedResponse = new VulnerabilityOccurrencesSummary
            {
                Counts =
                {
                    new VulnerabilityOccurrencesSummary.Types.FixableTotalByDigest(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityOccurrencesSummaryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VulnerabilityOccurrencesSummary>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            VulnerabilityOccurrencesSummary responseCallSettings = await client.GetVulnerabilityOccurrencesSummaryAsync(request.ParentAsProjectName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityOccurrencesSummary responseCancellationToken = await client.GetVulnerabilityOccurrencesSummaryAsync(request.ParentAsProjectName, request.Filter, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
