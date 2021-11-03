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
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.RecaptchaEnterprise.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecaptchaEnterpriseServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateAssessmentRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                RiskAnalysis = new RiskAnalysis(),
                TokenProperties = new TokenProperties(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssessmentRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                RiskAnalysis = new RiskAnalysis(),
                TokenProperties = new TokenProperties(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assessment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Assessment responseCallSettings = await client.CreateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assessment responseCancellationToken = await client.CreateAssessmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssessment()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                RiskAnalysis = new RiskAnalysis(),
                TokenProperties = new TokenProperties(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request.Parent, request.Assessment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssessmentAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                RiskAnalysis = new RiskAnalysis(),
                TokenProperties = new TokenProperties(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assessment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Assessment responseCallSettings = await client.CreateAssessmentAsync(request.Parent, request.Assessment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assessment responseCancellationToken = await client.CreateAssessmentAsync(request.Parent, request.Assessment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssessmentResourceNames()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                RiskAnalysis = new RiskAnalysis(),
                TokenProperties = new TokenProperties(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request.ParentAsProjectName, request.Assessment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssessmentResourceNamesAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Event = new Event(),
                RiskAnalysis = new RiskAnalysis(),
                TokenProperties = new TokenProperties(),
                AccountDefenderAssessment = new AccountDefenderAssessment(),
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assessment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Assessment responseCallSettings = await client.CreateAssessmentAsync(request.ParentAsProjectName, request.Assessment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assessment responseCancellationToken = await client.CreateAssessmentAsync(request.ParentAsProjectName, request.Assessment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateAssessmentRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
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
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateAssessmentRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
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
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse responseCallSettings = await client.AnnotateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateAssessmentResponse responseCancellationToken = await client.AnnotateAssessmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateAssessment()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request.Name, request.Annotation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateAssessmentAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateAssessmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse responseCallSettings = await client.AnnotateAssessmentAsync(request.Name, request.Annotation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateAssessmentResponse responseCancellationToken = await client.AnnotateAssessmentAsync(request.Name, request.Annotation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateAssessmentResourceNames()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request.AssessmentName, request.Annotation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateAssessmentResourceNamesAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.PasswordCorrect,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse { };
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateAssessmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse responseCallSettings = await client.AnnotateAssessmentAsync(request.AssessmentName, request.Annotation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateAssessmentResponse responseCancellationToken = await client.AnnotateAssessmentAsync(request.AssessmentName, request.Annotation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKeyRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Key = new Key(),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key response = client.CreateKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKeyRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Key = new Key(),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key responseCallSettings = await client.CreateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.CreateKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key response = client.GetKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key responseCallSettings = await client.GetKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.GetKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateKeyRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new wkt::FieldMask(),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key response = client.UpdateKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateKeyRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new wkt::FieldMask(),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key responseCallSettings = await client.UpdateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.UpdateKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteKeyRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteKey(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteKeyRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteKeyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MigrateKeyRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            MigrateKeyRequest request = new MigrateKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.MigrateKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key response = client.MigrateKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MigrateKeyRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            MigrateKeyRequest request = new MigrateKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                WebSettings = new WebKeySettings(),
                AndroidSettings = new AndroidKeySettings(),
                IosSettings = new IOSKeySettings(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                TestingOptions = new TestingOptions(),
            };
            mockGrpcClient.Setup(x => x.MigrateKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Key responseCallSettings = await client.MigrateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.MigrateKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricsRequestObject()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Metrics expectedResponse = new Metrics
            {
                StartTime = new wkt::Timestamp(),
                ScoreMetrics = { new ScoreMetrics(), },
                ChallengeMetrics =
                {
                    new ChallengeMetrics(),
                },
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Metrics response = client.GetMetrics(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricsRequestObjectAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Metrics expectedResponse = new Metrics
            {
                StartTime = new wkt::Timestamp(),
                ScoreMetrics = { new ScoreMetrics(), },
                ChallengeMetrics =
                {
                    new ChallengeMetrics(),
                },
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Metrics>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Metrics responseCallSettings = await client.GetMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Metrics responseCancellationToken = await client.GetMetricsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetrics()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Metrics expectedResponse = new Metrics
            {
                StartTime = new wkt::Timestamp(),
                ScoreMetrics = { new ScoreMetrics(), },
                ChallengeMetrics =
                {
                    new ChallengeMetrics(),
                },
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Metrics response = client.GetMetrics(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricsAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Metrics expectedResponse = new Metrics
            {
                StartTime = new wkt::Timestamp(),
                ScoreMetrics = { new ScoreMetrics(), },
                ChallengeMetrics =
                {
                    new ChallengeMetrics(),
                },
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Metrics>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Metrics responseCallSettings = await client.GetMetricsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Metrics responseCancellationToken = await client.GetMetricsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricsResourceNames()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Metrics expectedResponse = new Metrics
            {
                StartTime = new wkt::Timestamp(),
                ScoreMetrics = { new ScoreMetrics(), },
                ChallengeMetrics =
                {
                    new ChallengeMetrics(),
                },
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Metrics response = client.GetMetrics(request.MetricsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricsResourceNamesAsync()
        {
            moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient> mockGrpcClient = new moq::Mock<RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient>(moq::MockBehavior.Strict);
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            Metrics expectedResponse = new Metrics
            {
                StartTime = new wkt::Timestamp(),
                ScoreMetrics = { new ScoreMetrics(), },
                ChallengeMetrics =
                {
                    new ChallengeMetrics(),
                },
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Metrics>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceClient client = new RecaptchaEnterpriseServiceClientImpl(mockGrpcClient.Object, null);
            Metrics responseCallSettings = await client.GetMetricsAsync(request.MetricsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Metrics responseCancellationToken = await client.GetMetricsAsync(request.MetricsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
