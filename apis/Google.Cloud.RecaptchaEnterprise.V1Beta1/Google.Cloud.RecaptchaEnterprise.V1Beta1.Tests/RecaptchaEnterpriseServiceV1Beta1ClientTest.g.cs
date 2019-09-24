// Copyright 2019 Google LLC
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

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.RecaptchaEnterprise.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedRecaptchaEnterpriseServiceV1Beta1ClientTest
    {
        [Fact]
        public void CreateAssessment()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            CreateAssessmentRequest expectedRequest = new CreateAssessmentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Score = 1.0926453E7f,
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Assessment assessment = new Assessment();
            Assessment response = client.CreateAssessment(parent, assessment);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAssessmentAsync()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            CreateAssessmentRequest expectedRequest = new CreateAssessmentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Score = 1.0926453E7f,
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Assessment>(Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Assessment assessment = new Assessment();
            Assessment response = await client.CreateAssessmentAsync(parent, assessment);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAssessment2()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Score = 1.0926453E7f,
            };
            mockGrpcClient.Setup(x => x.CreateAssessment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment response = client.CreateAssessment(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAssessmentAsync2()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Assessment = new Assessment(),
            };
            Assessment expectedResponse = new Assessment
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Score = 1.0926453E7f,
            };
            mockGrpcClient.Setup(x => x.CreateAssessmentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Assessment>(Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Assessment response = await client.CreateAssessmentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnnotateAssessment()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            AnnotateAssessmentRequest expectedRequest = new AnnotateAssessmentRequest
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse();
            mockGrpcClient.Setup(x => x.AnnotateAssessment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AssessmentName name = new AssessmentName("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            AnnotateAssessmentResponse response = client.AnnotateAssessment(name, annotation);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnnotateAssessmentAsync()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            AnnotateAssessmentRequest expectedRequest = new AnnotateAssessmentRequest
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse();
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotateAssessmentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AssessmentName name = new AssessmentName("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            AnnotateAssessmentResponse response = await client.AnnotateAssessmentAsync(name, annotation);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnnotateAssessment2()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse();
            mockGrpcClient.Setup(x => x.AnnotateAssessment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = client.AnnotateAssessment(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnnotateAssessmentAsync2()
        {
            Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client> mockGrpcClient = new Mock<RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client>(MockBehavior.Strict);
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            AnnotateAssessmentResponse expectedResponse = new AnnotateAssessmentResponse();
            mockGrpcClient.Setup(x => x.AnnotateAssessmentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotateAssessmentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecaptchaEnterpriseServiceV1Beta1Client client = new RecaptchaEnterpriseServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            AnnotateAssessmentResponse response = await client.AnnotateAssessmentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
