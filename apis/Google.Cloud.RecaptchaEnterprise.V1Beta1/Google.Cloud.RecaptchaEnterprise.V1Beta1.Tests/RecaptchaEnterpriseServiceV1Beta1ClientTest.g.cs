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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecaptchaEnterpriseServiceV1Beta1ClientTest
    {
        [xunit::FactAttribute]
        public void CreateAssessmentRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                Score = -5.80354E+17F,
                TokenProperties = new TokenProperties(),
                Reasons =
                {
                    Assessment.Types.ClassificationReason.LowConfidenceScore,
                },
                PasswordLeakVerification = new PasswordLeakVerification(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssessmentRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                Score = -5.80354E+17F,
                TokenProperties = new TokenProperties(),
                Reasons =
                {
                    Assessment.Types.ClassificationReason.LowConfidenceScore,
                },
                PasswordLeakVerification = new PasswordLeakVerification(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assessment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment responseCallSettings = await client.CreateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assessment responseCancellationToken = await client.CreateAssessmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssessment()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                Score = -5.80354E+17F,
                TokenProperties = new TokenProperties(),
                Reasons =
                {
                    Assessment.Types.ClassificationReason.LowConfidenceScore,
                },
                PasswordLeakVerification = new PasswordLeakVerification(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request.Parent, request.Assessment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssessmentAsync()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                Score = -5.80354E+17F,
                TokenProperties = new TokenProperties(),
                Reasons =
                {
                    Assessment.Types.ClassificationReason.LowConfidenceScore,
                },
                PasswordLeakVerification = new PasswordLeakVerification(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assessment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment responseCallSettings = await client.CreateAssessmentAsync(request.Parent, request.Assessment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assessment responseCancellationToken = await client.CreateAssessmentAsync(request.Parent, request.Assessment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssessmentResourceNames()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                Score = -5.80354E+17F,
                TokenProperties = new TokenProperties(),
                Reasons =
                {
                    Assessment.Types.ClassificationReason.LowConfidenceScore,
                },
                PasswordLeakVerification = new PasswordLeakVerification(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request.ParentAsProjectName, request.Assessment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssessmentResourceNamesAsync()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                Score = -5.80354E+17F,
                TokenProperties = new TokenProperties(),
                Reasons =
                {
                    Assessment.Types.ClassificationReason.LowConfidenceScore,
                },
                PasswordLeakVerification = new PasswordLeakVerification(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assessment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment responseCallSettings = await client.CreateAssessmentAsync(request.ParentAsProjectName, request.Assessment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assessment responseCancellationToken = await client.CreateAssessmentAsync(request.ParentAsProjectName, request.Assessment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateAssessmentRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.InitiatedTwoFactor,
                },
                HashedAccountId = proto::ByteString.CopyFromUtf8("hashed_account_id016ad986"),
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateAssessmentRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.InitiatedTwoFactor,
                },
                HashedAccountId = proto::ByteString.CopyFromUtf8("hashed_account_id016ad986"),
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateAssessmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse responseCallSettings = await client.AnnotateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateAssessmentResponse responseCancellationToken = await client.AnnotateAssessmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateAssessment()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request.Name, request.Annotation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateAssessmentAsync()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateAssessmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse responseCallSettings = await client.AnnotateAssessmentAsync(request.Name, request.Annotation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateAssessmentResponse responseCancellationToken = await client.AnnotateAssessmentAsync(request.Name, request.Annotation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateAssessmentResourceNames()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request.AssessmentName, request.Annotation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateAssessmentResourceNamesAsync()
        {
            moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateAssessmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse responseCallSettings = await client.AnnotateAssessmentAsync(request.AssessmentName, request.Annotation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateAssessmentResponse responseCancellationToken = await client.AnnotateAssessmentAsync(request.AssessmentName, request.Annotation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
