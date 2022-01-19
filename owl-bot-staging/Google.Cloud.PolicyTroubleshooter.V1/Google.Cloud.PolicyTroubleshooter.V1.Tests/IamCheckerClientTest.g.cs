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
                AccessTuple = new AccessTuple(),
            };
            TroubleshootIamPolicyResponse expectedResponse = new TroubleshootIamPolicyResponse
            {
                Access = AccessState.UnknownInfoDenied,
                ExplainedPolicies =
                {
                    new ExplainedPolicy(),
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
                AccessTuple = new AccessTuple(),
            };
            TroubleshootIamPolicyResponse expectedResponse = new TroubleshootIamPolicyResponse
            {
                Access = AccessState.UnknownInfoDenied,
                ExplainedPolicies =
                {
                    new ExplainedPolicy(),
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
