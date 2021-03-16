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

using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PolicyTroubleshooter.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIamCheckerClientTest
    {
        [xunit::FactAttribute]
        public void TroubleshootIamPolicyRequestObject()
        {
            moq::Mock<IamChecker.IamCheckerClient> mockGrpcClient = new moq::Mock<IamChecker.IamCheckerClient>(moq::MockBehavior.Strict);
            TroubleshootIamPolicyRequest request = new TroubleshootIamPolicyRequest
            {
                AccessTuple = new AccessTuple
                {
                    Principal = "principala915d7e7",
                    FullResourceName = "full_resource_nameb0e77737",
                    Permission = "permission0fca654b",
                },
            };
            TroubleshootIamPolicyResponse expectedResponse = new TroubleshootIamPolicyResponse
            {
                Access = AccessState.UnknownInfoDenied,
                ExplainedPolicies =
                {
                    new ExplainedPolicy
                    {
                        Access = AccessState.UnknownInfoDenied,
                        FullResourceName = "full_resource_nameb0e77737",
                        Policy = new gciv::Policy
                        {
                            Version = 271578922,
                            Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                            Bindings =
                            {
                                new gciv::Binding
                                {
                                    Role = "role64e9a729",
                                    Members = { "members3408e3d2", },
                                    Condition = new gt::Expr
                                    {
                                        Expression = "expressiond33c9763",
                                        Title = "title17dbd3d5",
                                        Description = "description2cf9da67",
                                        Location = "locatione09d18d5",
                                    },
                                },
                            },
                        },
                        BindingExplanations =
                        {
                            new BindingExplanation
                            {
                                Access = AccessState.UnknownInfoDenied,
                                Role = "role64e9a729",
                                RolePermission = BindingExplanation.Types.RolePermission.Included,
                                RolePermissionRelevance = HeuristicRelevance.High,
                                Memberships =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new BindingExplanation.Types.AnnotatedMembership
                                        {
                                            Membership = BindingExplanation.Types.Membership.UnknownUnsupported,
                                            Relevance = HeuristicRelevance.Normal,
                                        }
                                    },
                                },
                                Relevance = HeuristicRelevance.Normal,
                                Condition = new gt::Expr
                                {
                                    Expression = "expressiond33c9763",
                                    Title = "title17dbd3d5",
                                    Description = "description2cf9da67",
                                    Location = "locatione09d18d5",
                                },
                            },
                        },
                        Relevance = HeuristicRelevance.Normal,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.TroubleshootIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IamCheckerClient client = new IamCheckerClientImpl(mockGrpcClient.Object, null);
            TroubleshootIamPolicyResponse response = client.TroubleshootIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TroubleshootIamPolicyRequestObjectAsync()
        {
            moq::Mock<IamChecker.IamCheckerClient> mockGrpcClient = new moq::Mock<IamChecker.IamCheckerClient>(moq::MockBehavior.Strict);
            TroubleshootIamPolicyRequest request = new TroubleshootIamPolicyRequest
            {
                AccessTuple = new AccessTuple
                {
                    Principal = "principala915d7e7",
                    FullResourceName = "full_resource_nameb0e77737",
                    Permission = "permission0fca654b",
                },
            };
            TroubleshootIamPolicyResponse expectedResponse = new TroubleshootIamPolicyResponse
            {
                Access = AccessState.UnknownInfoDenied,
                ExplainedPolicies =
                {
                    new ExplainedPolicy
                    {
                        Access = AccessState.UnknownInfoDenied,
                        FullResourceName = "full_resource_nameb0e77737",
                        Policy = new gciv::Policy
                        {
                            Version = 271578922,
                            Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                            Bindings =
                            {
                                new gciv::Binding
                                {
                                    Role = "role64e9a729",
                                    Members = { "members3408e3d2", },
                                    Condition = new gt::Expr
                                    {
                                        Expression = "expressiond33c9763",
                                        Title = "title17dbd3d5",
                                        Description = "description2cf9da67",
                                        Location = "locatione09d18d5",
                                    },
                                },
                            },
                        },
                        BindingExplanations =
                        {
                            new BindingExplanation
                            {
                                Access = AccessState.UnknownInfoDenied,
                                Role = "role64e9a729",
                                RolePermission = BindingExplanation.Types.RolePermission.Included,
                                RolePermissionRelevance = HeuristicRelevance.High,
                                Memberships =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new BindingExplanation.Types.AnnotatedMembership
                                        {
                                            Membership = BindingExplanation.Types.Membership.UnknownUnsupported,
                                            Relevance = HeuristicRelevance.Normal,
                                        }
                                    },
                                },
                                Relevance = HeuristicRelevance.Normal,
                                Condition = new gt::Expr
                                {
                                    Expression = "expressiond33c9763",
                                    Title = "title17dbd3d5",
                                    Description = "description2cf9da67",
                                    Location = "locatione09d18d5",
                                },
                            },
                        },
                        Relevance = HeuristicRelevance.Normal,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.TroubleshootIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TroubleshootIamPolicyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IamCheckerClient client = new IamCheckerClientImpl(mockGrpcClient.Object, null);
            TroubleshootIamPolicyResponse responseCallSettings = await client.TroubleshootIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TroubleshootIamPolicyResponse responseCancellationToken = await client.TroubleshootIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
